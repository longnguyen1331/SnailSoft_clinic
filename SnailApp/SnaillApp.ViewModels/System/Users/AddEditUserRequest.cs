using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.System.Users
{
    public class AddEditUserRequest<T>
    {
        public string Id { set; get; }
        public T Data { set; get; }
    }
}
