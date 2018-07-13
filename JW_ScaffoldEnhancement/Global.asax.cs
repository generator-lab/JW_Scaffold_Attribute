using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using JW_ScaffoldEnhancement.Models;

namespace JW_ScaffoldEnhancement
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			// test code here
			List<string> list = ScaffoldFunctions.GetPropertyIsModifiedList("JW_ScaffoldEnhancement.Models", "Product", "Products"); 
			
			AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


        }
    }
}
