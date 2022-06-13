﻿using Microsoft.AspNetCore.Identity;
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
        //List<UserModelView> GetAll();
        PagedResult<UserModelView> GetAllPaging(AppUserViewModelSearch appUserViewModelSearch);
        //List<UserModelView> GetAllParent();
        //List<UserModelView> GetCategoryByParentId(int parentId);
        UserModelView GetById(int id);
        bool Add(UserModelView view);
        bool Update(UserModelView view);
        bool Deleted(int id);
        void Save();
    }
    public class UserService : IUserService
    {
        private readonly IAppUserRepository _userService;
        private IUnitOfWork _unitOfWork;
        public UserService(IAppUserRepository userService, IUnitOfWork unitOfWork)
        {
            _userService = userService;
            _unitOfWork = unitOfWork;
        }
        //public List<UserModelView> GetAll()
        //{
        //    var dataModel = _userService.FindAll().Select(c => new UserModelView()
        //    {
        //        Id = c.Id,
        //        Name = c.Name,
        //        //ParentName = (c.ParentId.HasValue && c.ParentId.Value > 0 ? _userService.FindById(c.ParentId.Value).Name :"") 
        //    }).ToList();
        //    if (dataModel != null && dataModel.Count > 0)
        //    {
        //        foreach (var item in dataModel)
        //        {
        //            if (item.ParentId.HasValue && item.ParentId.Value > 0)
        //            {
        //                item.ParentName = dataModel.FirstOrDefault(c => c.Id == item.ParentId.Value).Name;
        //            }
        //        }
        //    }
        //    return dataModel;
        //}
        //public List<UserModelView> GetAllParent()
        //{
        //    return _userService.FindAll().Where(c => !c.ParentId.HasValue).Select(c => new UserModelView()
        //    {
        //        Id = c.Id,
        //        Name = c.Name,
        //    }).ToList();
        //}

        public UserModelView GetById(int id)
        {
            var data = _userService.FindById(id);
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
                    _userService.Add(_category);
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
                var dataServer = _userService.FindById(view.Id);
                if (dataServer != null)
                {
                    dataServer.Name = view.Name;
                    _userService.Update(dataServer);
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
                var dataServer = _userService.FindById(id);
                if (dataServer != null)
                {
                    _userService.Remove(dataServer);
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
                var query = _userService.FindAll();
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
