using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.Enums
{
    public enum MenuAppRoleType: Byte
    {
        GlobalDataView = 0,
        GlobalDataEdit = 1,
        GlobalDataDelete = 2,
        SystemDataView = 3,
        SystemDataEdit = 4,
        SystemDataDelete = 5,
        PersonalDataView = 6,
        PersonalDataEdit = 7,
        PersonalDataDelete = 8,
        DownloadExcel = 9
    }
}
