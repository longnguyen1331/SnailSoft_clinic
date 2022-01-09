using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace SnailApp.Data.Entities
{
    public class Region : BaseEntity
    {
        public string ParentName { get; set; }
        public int Level { get; set; }
    }
}
