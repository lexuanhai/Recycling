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
    public interface IProductService
    {
        PagedResult<ProductModelView> GetAllPaging(ProductViewModelSearch productViewModelSearch);
        ProductModelView GetById(int id);
        List<ProductModelView> GetProductByUserId(int userId);
        List<TelecomModelView> GetTelecomByUserId(int userId);
        int Add(ProductModelView view);
        bool AddUserPointProduct(int productId,int userId);
        bool AddUserTelecom(int userId, TelecomModelView telecomModelView);
        bool Update(ProductModelView view);
        bool Deleted(int id);
        void Save();
    }
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IAppUserProductRepository _appUserProductRepository;
        private readonly ITelecomRepository _telecomRepository;
        private readonly IAppUserRepository _appUserRepository;
        private IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository, 
            IUnitOfWork unitOfWork,
            IAppUserRepository appUserRepository,
            ITelecomRepository telecomRepository,
            IAppUserProductRepository appUserProductRepository)
        {
            _productRepository = productRepository;
            _telecomRepository = telecomRepository;
            _appUserRepository = appUserRepository;
            _unitOfWork = unitOfWork;
            _appUserProductRepository = appUserProductRepository;
        }              
        public ProductModelView GetById(int id)
        {
            var data = _productRepository.FindAll(p=>p.Id == id).FirstOrDefault();
            if (data != null)
            {
                var model = new ProductModelView()
                {
                    Id = data.Id,
                    Name = data.Name,
                    Decription = data.Decription,
                    SubDecription = data.SubDecription,
                    CategoryId = data.CategoryId,
                    Total = data.Total,
                    Price = data.Price,
                    ReducedPrice = data.ReducedPrice,
                    TotalPoint = data.Point,
                    DateExpired =data.DateExpired,
                    PricePercent = data.PricePercent
                };
                return model;
            }
            return null;
        }
        public List<TelecomModelView> GetTelecomByUserId(int userId)
        {
            var model = _telecomRepository.FindAll().Where(p => p.UserId == userId).Select(t=> new TelecomModelView() { 
            UserId=t.UserId,
            Name = t.Name,
            Exchange = t.Exchange,
            Point = t.Point            
            }).ToList();
            //if (model != null && model.Count > 0)
            //{                
            //    foreach (var item in model)
            //    {
            //        if (!item.Point.HasValue)
            //        {
            //            item.Point.Value = 0;
            //        }
            //    }
            //    return lstProduct;
            //}
            return model;

        }
        public bool AddUserPointProduct(int productId,int userId)
        {
            try
            {
                var appUserProduct = new AppUsersProduct()
                {
                    ProductId = productId,
                    AppUserId = userId
                };
                _appUserProductRepository.Add(appUserProduct);

                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddUserTelecom(int userId,TelecomModelView telecomModelView)
        {
            try
            {
                var appUserProduct = new Telecom()
                {
                    UserId = userId,
                    Name = telecomModelView.Name,
                    Exchange = telecomModelView.Exchange,
                    Point = telecomModelView.Point
                };
                _telecomRepository.Add(appUserProduct);

                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<ProductModelView> GetProductByUserId(int userId)
        {
            var model = _appUserProductRepository.FindAll().Where(p => p.AppUserId == userId).ToList();
            if (model != null && model.Count > 0)
            {
                var lstProduct = new List<ProductModelView>();
                model = model.Distinct().ToList();

                foreach (var item in model)
                {
                    var product = GetById(item.ProductId.Value);
                    if (product != null)
                    {
                        if (product.TotalPoint == null)
                        {
                            product.TotalPoint = 0;
                        }                      
                        lstProduct.Add(product);
                    }
                }
                return lstProduct;
            }
            return null;

        }

        public int Add(ProductModelView view)
        {            
            try
            {
                if (view != null)
                {
                    var _product = new Product
                    {
                        Name = view.Name,
                        Decription = view.Decription,
                        SubDecription = view.SubDecription,
                        CategoryId = view.CategoryId,
                        Total = view.Total,
                        Price = view.Price,
                        ReducedPrice = view.ReducedPrice,
                        //BrandsId = view.BrandsId,                        
                    };
                    _productRepository.Add(_product);
                    Save();

                    return _product.Id;
                }
            }
            catch (Exception ex)
            {
                //return false;
            }
            return 0;

        }
        public void Save()
        {
            _unitOfWork.Commit();
        }
        public bool Update(ProductModelView view)
        {
            try
            {
                var dataServer = _productRepository.FindById(view.Id);
                if (dataServer != null)
                {
                    dataServer.Name = view.Name;
                    dataServer.Decription = view.Decription;
                    dataServer.SubDecription = view.SubDecription;
                    dataServer.CategoryId = view.CategoryId;
                    dataServer.Total = view.Total;
                    dataServer.Price = view.Price;
                    dataServer.ReducedPrice = view.ReducedPrice;
                    //dataServer.BrandsId = view.BrandsId;  
                    _productRepository.Update(dataServer);
                    Save();
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
                var dataServer = _productRepository.FindById(id);
                if (dataServer != null)
                {
                    var listCategoryChild = _productRepository.FindAll().Where(c => c.Id == dataServer.Id).ToList();
                    foreach (var itemChild in listCategoryChild)
                    {
                        _productRepository.Remove(itemChild);
                    }

                    _productRepository.Remove(dataServer);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return false;
        }
        public PagedResult<ProductModelView> GetAllPaging(ProductViewModelSearch ProductViewModelSearch)
        {
            try
            {
                var query = _productRepository.FindAll();
                //if (ProductViewModelSearch.CategoryParentId.HasValue && ProductViewModelSearch.CategoryParentId.Value > 0)
                //{
                //    if (!ProductViewModelSearch.CategoryId.HasValue)
                //    {
                //        query = query.Where(c => c.Id == ProductViewModelSearch.CategoryParentId.Value);
                //    }
                //    else
                //    {
                //        if (ProductViewModelSearch.CategoryId.HasValue && ProductViewModelSearch.CategoryId.Value > 0)
                //        {
                //            query = query.Where(c => c.Id == ProductViewModelSearch.CategoryId.Value);
                //        }
                //    }

                //}
                //else
                //{
                //    if (ProductViewModelSearch.CategoryId.HasValue && ProductViewModelSearch.CategoryId.Value > 0)
                //    {
                //        query = query.Where(c => c.Id == ProductViewModelSearch.CategoryId.Value);
                //    }
                //}

                if (ProductViewModelSearch.CategoryId.HasValue && ProductViewModelSearch.CategoryId.Value > 0)
                {
                    query = query.Where(c => c.CategoryId == ProductViewModelSearch.CategoryId.Value);
                }

                int totalRow = query.Count();
                query = query.Skip((ProductViewModelSearch.PageIndex - 1) * ProductViewModelSearch.PageSize).Take(ProductViewModelSearch.PageSize);
                var data = query.Select(c => new ProductModelView()
                {
                    Name = c.Name,
                    Id = c.Id,
                    Price = c.Price,
                    Total = c.Total,
                    TotalPoint = c.Point,          
                    CategoryId = c.CategoryId,
                    UrlImage = c.UrlImage,
                    PricePercent = c.PricePercent,
                    DateExpired = c.DateExpired
                    //ParentId = c.ParentId
                }).ToList();
                var pagingData = new PagedResult<ProductModelView>
                {
                    Results = data,
                    CurrentPage = ProductViewModelSearch.PageIndex,
                    PageSize = ProductViewModelSearch.PageSize,
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
