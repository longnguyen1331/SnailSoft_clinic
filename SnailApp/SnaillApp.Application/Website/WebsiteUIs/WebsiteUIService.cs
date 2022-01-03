﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SnailApp.Utilities.Constants;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Website.WebsiteUIs;
using SnailApp.ViewModels.Website.WebsiteMenus;
using SnailApp.ViewModels.System.ContactInformation;

namespace SnailApp.Application.Website.WebsiteUIs
{
    public interface IWebsiteUIService
    {
        Task<ApiResult<WebsiteUIDto>> GetTopHeaderObjects(WebsiteUIRequest request);
        Task<ApiResult<WebsiteUIDto>> GetFooterObjects(WebsiteUIRequest request);
    }
    public class WebsiteUIService : IWebsiteUIService
    {
        private readonly IConfiguration _configuration;
        private readonly ClinicDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public WebsiteUIService(ClinicDbContext context, IConfiguration configuration,
                                UserManager<AppUser> userManager)
        {
            _configuration = configuration;
            _context = context;
            _userManager = userManager;
        }
        public async Task<ApiResult<WebsiteUIDto>> GetTopHeaderObjects(WebsiteUIRequest request)
        {
            try
            {
                var websiteUI = new WebsiteUIDto()
                {
                    Logo = _configuration[SystemConstants.AppConstants.LogoFile1],
                    Menus = await (from wm in _context.WebsiteMenus
                                   join wmt in _context.WebsiteMenuTranslations on wm.Id equals wmt.WebsiteMenuId into wm_wmt
                                   from wmt in wm_wmt.DefaultIfEmpty()
                                   where wmt.LanguageId == request.LanguageId
                                        && wm.WebsiteMenuType == 1
                                   select new WebsiteMenuDto()
                                   {
                                       SortOrder = wm.SortOrder,
                                       Name = wmt.Name,
                                       Link = wm.Link
                                   }).AsNoTracking().ToListAsync(),
                    ContactInformation = await (from ci in _context.ContactInformation
                                                where ci.IsDefault == true
                                                select new ContactInformationDto() {
                                                    Address = ci.Address,
                                                    PhoneNumber = ci.PhoneNumber
                                                }).AsNoTracking().FirstOrDefaultAsync()
                };

                return new ApiSuccessResult<WebsiteUIDto>(websiteUI);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<WebsiteUIDto>(ex.Message);
            }            
        }
        public async Task<ApiResult<WebsiteUIDto>> GetFooterObjects(WebsiteUIRequest request)
        {
            try
            {
                var websiteUI = new WebsiteUIDto()
                {
                    Logo = _configuration[SystemConstants.AppConstants.LogoFile1],
                    Menus = await (from wm in _context.WebsiteMenus
                                   join wmt in _context.WebsiteMenuTranslations on wm.Id equals wmt.WebsiteMenuId into wm_wmt
                                   from wmt in wm_wmt.DefaultIfEmpty()
                                   where wmt.LanguageId == request.LanguageId
                                   select new WebsiteMenuDto()
                                   {
                                       SortOrder = wm.SortOrder,
                                       Name = wmt.Name,
                                       Link = wm.Link,
                                       WebsiteMenuType = wm.WebsiteMenuType
                                   }).AsNoTracking().ToListAsync(),
                    ContactInformation = await (from ci in _context.ContactInformation
                                                where ci.IsDefault == true
                                                select new ContactInformationDto()
                                                {
                                                    Address = ci.Address,
                                                    PhoneNumber = ci.PhoneNumber,
                                                    Email = ci.Email,
                                                    FacebookLink = ci.FacebookLink,
                                                    InstagramLink = ci.InstagramLink,
                                                    YoutubeLink = ci.YoutubeLink
                                                }).AsNoTracking().FirstOrDefaultAsync()
                };

                return new ApiSuccessResult<WebsiteUIDto>(websiteUI);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<WebsiteUIDto>(ex.Message);
            }
        }
    }
}