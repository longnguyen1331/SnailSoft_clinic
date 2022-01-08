using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.Enums
{
    public enum MenuAppRoleType: Byte
    {
      
        SystemDataView = 0,
        SystemDataEdit = 1,
        SystemDataDelete = 2,
        PersonalDataView = 3,
        PersonalDataEdit = 4,
        PersonalDataDelete = 5,
        DownloadExcel = 6,
        GlobalDataView = 7,
        GlobalDataEdit = 8,
        GlobalDataDelete = 9
    }
}
