using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnailApp.ViewModels.System.MenuAppRoles;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Enums;

namespace SnailApp.AdminApp
{
    public class InternalService
    {
        public static UserDto FixedUserRole(UserDto currentUserRole, string controllerName, string actionName)
        {
            var result = currentUserRole;
            if ((controllerName.Trim().ToLower().Equals("user") && actionName.Trim().ToLower().Equals("changecurrentuserpassword"))
                || controllerName.Trim().ToLower().Equals("home")
                || (actionName.Trim().ToLower().Contains("filter")))
            {
                List<MenuAppRoleDto> menuAppRoles = new List<MenuAppRoleDto>();
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.GlobalDataView, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.GlobalDataEdit, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.GlobalDataDelete, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.SystemDataView, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.SystemDataEdit, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.SystemDataDelete, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.PersonalDataView, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.PersonalDataEdit, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.PersonalDataDelete, IsAllow = true });
                menuAppRoles.Add(new MenuAppRoleDto() { MenuAppRoleType = (int)MenuAppRoleType.DownloadExcel, IsAllow = true });
                result.MenuAppRoles = menuAppRoles;
            }
            else
            {
                //Điều chỉnh tên controller cho phù hợp để xét quyền truy cập
                switch (controllerName)
                {
                    case "User":
                        controllerName = "Staff";
                        break;
                    case "MenuAppRole":
                        controllerName = "AppRole";
                        break;
                }

                List<MenuAppRoleDto> menuAppRoles = currentUserRole.MenuAppRoles.Where(m => m.ControllerName.Trim().ToLower().Equals(controllerName.Trim().ToLower())).ToList();

                //Điều chỉnh tên action cho phù hợp để xét quyền truy cập
                //switch (actionName)
                //{

                //}

                if (menuAppRoles.Any(m => m.ActionName.Trim().ToLower().Equals(actionName.Trim().ToLower())))
                {
                    menuAppRoles = menuAppRoles.Where(m => m.ActionName.Trim().ToLower().Equals(actionName.Trim().ToLower())).ToList();
                }
                else
                {
                    menuAppRoles = menuAppRoles.Where(m => m.ActionName.Trim().ToLower().Equals("index")).ToList();
                }

                result.MenuAppRoles = menuAppRoles;
            }

            result.IsAllowView = false;
            result.IsAllowEdit = false;
            result.IsAllowDelete = false;

            if (result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.GlobalDataView && m.IsAllow == true)
                || result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.SystemDataView && m.IsAllow == true)
                || result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.PersonalDataView && m.IsAllow == true))
            {
                result.IsAllowView = true;
            }

            if (result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.GlobalDataEdit && m.IsAllow == true)
                || result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.SystemDataEdit && m.IsAllow == true)
                || result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.PersonalDataEdit && m.IsAllow == true))
            {
                result.IsAllowEdit = true;
            }

            if (result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.GlobalDataDelete && m.IsAllow == true)
                || result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.SystemDataDelete && m.IsAllow == true)
                || result.MenuAppRoles.Any(m => m.MenuAppRoleType == (int)MenuAppRoleType.PersonalDataDelete && m.IsAllow == true))
            {
                result.IsAllowDelete = true;
            }

            return result;
        }
    }
}
