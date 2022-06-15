using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Areas.Admin.Models;
using WEBSITE.Areas.Admin.Models.Search;
using WEBSITE.Data.DatabaseEntity;
using WEBSITE.Reponsitory;
using WEBSITE.Utilities;

namespace WEBSITE.Service
{
    public interface IUserService
    {
        List<UserModelView> GetAll();
        UserModelView GetUserByUserName(string userName,string password);
        PagedResult<UserModelView> GetAllPaging(AppUserViewModelSearch appUserViewModelSearch);
        void UpdatePointUser(int id, int point);
        UserModelView GetById(int id);
        bool Add(UserModelView view);
        bool Update(UserModelView view);
        bool Deleted(int id);
        void Save();
    }
    public class UserService : IUserService
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly IProductRepository _productRepository;
        private readonly IAppUserProductRepository _appUserProductRepository;
        private IUnitOfWork _unitOfWork;
        public UserService(IAppUserRepository userService,
            IAppUserProductRepository appUserProductRepository,
            IAppUserRepository appUserRepository,
        IProductRepository productRepository,
            IUnitOfWork unitOfWork)
        {
            _appUserRepository = appUserRepository;
            _unitOfWork = unitOfWork;
            _appUserProductRepository = appUserProductRepository;
            _productRepository = productRepository;
        }
        public void UpdatePointUser(int id, int point)
        {
            var dataServer = _appUserRepository.FindAll().Where(u=>u.Id ==id).FirstOrDefault();
            if (dataServer != null)
            {
                dataServer.TotalPoint = point > 0? point:0;
            }
            _appUserRepository.Update(dataServer);

            Save();

        }
        public UserModelView GetUserByUserName(string userName, string password)
        {
            var data = _appUserRepository.FindAll().Where(u => u.UserName == userName && u.PassWord == password).Select(c => new UserModelView()
            {
                Id = c.Id,
                Name = c.Name,
                UserName = c.UserName,
                TotalPoint = c.TotalPoint
            }).FirstOrDefault();
            if (data != null)
            {
                return data;
            }
            return null;
        }
        public List<UserModelView> GetAll()
        {
            var dataModel = _appUserRepository.FindAll().Select(c => new UserModelView()
            {
                Id = c.Id,
                Name = c.Name,
                UserName = c.UserName,
                Phone = c.Phone,
                Address = c.Address,
                TotalPoint = c.TotalPoint
            }).ToList();

            if (dataModel != null && dataModel.Count > 0)
            {
                var appUserProductModel = _appUserProductRepository.FindAll().ToList();
                if (appUserProductModel != null && appUserProductModel.Count > 0)
                {
                    foreach (var item in dataModel)
                    {
                        var _appUserProduct = appUserProductModel.Where(au => au.AppUserId == item.Id).ToList();

                        if (_appUserProduct != null && _appUserProduct.Count > 0)
                        {
                            item.Products = new List<ProductModelView>();
                            foreach (var item_appUserProduct in _appUserProduct)
                            {
                                var _product = _productRepository.FindAll().Where(p => p.Id == item_appUserProduct.ProductId).Select(p=> new ProductModelView() {
                                    Name = p.Name,
                                    Decription = p.Decription,
                                    SubDecription = p.SubDecription,
                                    CategoryId = p.CategoryId,
                                    Total = p.Total,
                                    Price = p.Price,
                                    ReducedPrice = p.ReducedPrice,
                                    TotalPoint = p.Point                                    
                                }).FirstOrDefault();
                                item.Products.Add(_product);
                            }                           
                        }
                    }
                }
               
            }

            return dataModel;
        }
        //public List<UserModelView> GetAllParent()
        //{
        //    return _appUserRepository.FindAll().Where(c => !c.ParentId.HasValue).Select(c => new UserModelView()
        //    {
        //        Id = c.Id,
        //        Name = c.Name,
        //    }).ToList();
        //}

        public UserModelView GetById(int id)
        {
            var data = _appUserRepository.FindById(id);
            if (data != null)
            {
                var model = new UserModelView()
                {
                    Id = data.Id,
                    Name = data.Name
                };
                return model;
            }
            return null;
        }

        public bool Add(UserModelView view)
        {
            try
            {
                if (view != null)
                {
                    var _category = new AppUsers
                    {
                        Name = view.Name,
                    };
                    _appUserRepository.Add(_category);
                    return true;
                }
            }
            catch (Exception ex)
            {
                //return false;
            }

            return false;

        }
        public void Save()
        {
            _unitOfWork.Commit();
        }
        public bool Update(UserModelView view)
        {
            try
            {
                var dataServer = _appUserRepository.FindById(view.Id);
                if (dataServer != null)
                {
                    dataServer.Name = view.Name;
                    _appUserRepository.Update(dataServer);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return false;
        }
        public bool Deleted(int id)
        {
            try
            {
                var dataServer = _appUserRepository.FindById(id);
                if (dataServer != null)
                {
                    _appUserRepository.Remove(dataServer);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return false;
        }
        public PagedResult<UserModelView> GetAllPaging(AppUserViewModelSearch appUserViewModelSearch)
        {
            try
            {
                var query = _appUserRepository.FindAll();
                //if (categoryViewModelSearch.CategoryParentId.HasValue && categoryViewModelSearch.CategoryParentId.Value > 0)
                //{
                //    if (!categoryViewModelSearch.CategoryId.HasValue)
                //    {
                //        query = query.Where(c => c.Id == categoryViewModelSearch.CategoryParentId.Value);
                //    }
                //    else
                //    {
                //        if (categoryViewModelSearch.CategoryId.HasValue && categoryViewModelSearch.CategoryId.Value > 0)
                //        {
                //            query = query.Where(c => c.Id == categoryViewModelSearch.CategoryId.Value);
                //        }
                //    }

                //}
                //else
                //{
                //    if (categoryViewModelSearch.CategoryId.HasValue && categoryViewModelSearch.CategoryId.Value > 0)
                //    {
                //        query = query.Where(c => c.Id == categoryViewModelSearch.CategoryId.Value);
                //    }
                //}

                int totalRow = query.Count();
                query = query.Skip((appUserViewModelSearch.PageIndex - 1) * appUserViewModelSearch.PageSize).Take(appUserViewModelSearch.PageSize);
                var data = query.Select(c => new UserModelView()
                {
                    Name = c.Name,
                    Id = c.Id,
                }).ToList();
                var pagingData = new PagedResult<UserModelView>
                {
                    Results = data,
                    CurrentPage = appUserViewModelSearch.PageIndex,
                    PageSize = appUserViewModelSearch.PageSize,
                    RowCount = totalRow,
                };
                return pagingData;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
