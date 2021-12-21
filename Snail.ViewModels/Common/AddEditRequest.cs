using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.ViewModels.Common
{
    public class AddEditRequest<T> 
    {
        public int? Id { set; get; }
        public string Guid { set; get; }
        public T Data { set; get; }
    }
}