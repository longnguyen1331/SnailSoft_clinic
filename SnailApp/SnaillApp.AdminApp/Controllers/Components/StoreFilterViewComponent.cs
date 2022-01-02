using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SnailApp.AdminApp.Models;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.Stores;
using SnailApp.ApiIntegration;

namespace SnailApp.AdminApp.Controllers.Components
{
    public class StoreFilterViewComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;
        private readonly IStoreApiClient _storeApiClient;

        public StoreFilterViewComponent(IConfiguration configuration,
            IStoreApiClient storeApiClient)
        {
            _configuration = configuration;
            _storeApiClient = storeApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //int storeIdSelected = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            //var data = await _storeApiClient.GetAll(new ManageStorePagingRequest()
            //{
            //    LanguageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId))
            //});
            //string storeName = string.Empty;
            //string options = GenerateOptionStore(data.Items, storeIdSelected, out storeName);

            return View("Default", new StoreFilterViewModel()
            {
                OptionStores = null,
                StoreNameSelected = "test"
            });
        }

        private string GenerateOptionStore(List<StoreDto> stores, int storeIdSelected, out string name)
        {
            string result = string.Empty;
            name = string.Empty;
            foreach (var store in stores.OrderBy(m => m.SortOrder))
            {
                if (store.Id == storeIdSelected)
                {
                    result += $@"<option value='" + store.Id + "' selected>" + store.Name + "</option>";
                    name = store.Name;
                    HttpContext.Session.SetString(SystemConstants.AppConstants.StoreName, store.Name);

                }
                else
                {
                    result += $@"<option value='" + store.Id + "'>" + store.Name + "</option>";
                }
            }

            return result;
        }

    }
}
