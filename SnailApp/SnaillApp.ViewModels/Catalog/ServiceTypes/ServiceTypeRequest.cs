using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.ServiceTypes
{
    public class ServiceTypeRequest : BaseRequest
    {
        public IFormFile Image { set; get; }
        public int ClinicId { set; get; }
    }
}
