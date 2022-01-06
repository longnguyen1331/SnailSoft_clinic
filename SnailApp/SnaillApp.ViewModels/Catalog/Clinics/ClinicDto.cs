using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Clinics
{
    public class ClinicDto : BaseDto
    {
        public string Logo { set; get; }
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
        public DateTime StartDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool Status { set; get; }
    }
    
}