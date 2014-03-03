using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebMatrix.WebData;

namespace Relation.Web.App_Start
{
    public class SiteSettings
    {
        public static void Setup()
        {
            WebSecurity.InitializeDatabaseConnection("RelationUser", "tblUser", "userID", "strUsername", autoCreateTables: true);

      
            //Skapa roller
            if (!Roles.RoleExists("admin"))
                Roles.CreateRole("admin");
            if (!Roles.RoleExists("superadmin"))
                Roles.CreateRole("superadmin");
            if (!Roles.RoleExists("user"))
                Roles.CreateRole("user");

            Core.Class.Settings.CompanyID = SiteSettings.CompanyId;

        }

        public static int CompanyId
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["CompanyID"].ToString());
            }
        }
    }
}