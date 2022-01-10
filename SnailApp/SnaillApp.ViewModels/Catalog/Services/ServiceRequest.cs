using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.Services
{
    public class ServiceRequest : BaseRequest
    {
        public decimal Charges { set; get; }
        public IFormFile Image { set; get; }
        public int ClinicId { set; get; }
        public int ServiceTypeId { set; get; }
    }
}
