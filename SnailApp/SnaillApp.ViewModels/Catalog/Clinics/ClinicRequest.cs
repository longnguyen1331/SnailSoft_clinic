using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Clinics
{
    public class ClinicRequest
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual string Description { set; get; }
        public string StartDate { set; get; }
        public string CreatedDate { set; get; }
        public string ExpirationDate { set; get; }
        public string ModifiedDate { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }

        public  IFormFile Logo { set; get; }
        public string Favicon { set; get; }
        public string PrimaryColor { set; get; }
        public string SecondaryColor { set; get; }
        public string Introduction { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string GoogleScript { set; get; }
        public string FacebookPixel { set; get; }
        public string FacebookChat { set; get; }
        public string Firebase_apiKey { set; get; }
        public string Firebase_authDomain { set; get; }
        public string Firebase_projectId { set; get; }
        public string Firebase_storageBucket { set; get; }
        public string Firebase_messagingSenderId { set; get; }
        public string Firebase_appId { set; get; }
        public string Firebase_measurementId { set; get; }
        public string ClinicDomain { set; get; }
        public string FacebookAppname { set; get; }
        public string FacebookAppid { set; get; }
        public string FacebookAppsecret { set; get; }
        public bool FacebookLogin { set; get; }
        public bool GoogleLogin { set; get; }
        public string GoogleAppname { set; get; }
        public string GoogleApikey { set; get; }
        public string GoogleClientid { set; get; }
        public string GoogleClientsecret { set; get; }
        public bool Status { set; get; }
    }

}