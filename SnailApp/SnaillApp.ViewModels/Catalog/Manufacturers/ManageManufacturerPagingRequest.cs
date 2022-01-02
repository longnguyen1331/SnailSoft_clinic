using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Manufacturers
{
    public class ManageManufacturerPagingRequest: PagingRequestBase
    {
        public int StoreId { set; get; }
    }
}
