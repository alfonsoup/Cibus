using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;



namespace CibusMVC
{
    public class RouteConfig 
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           // string ipChris = "10.0.0.2";
           // string ip = HttpContext.Current.Request.UserHostAddress;
          // string ip = HttpContext.Request.ServerVariables["REMOTE_ADDR"];
           // if (ipChris == ip)
           // {
            //    routes.MapRoute(
             // name: "Chris",
              //url: "{controller}/{action}/{id}",
           //   defaults: new { controller = "Pedido", action = "Index", id = UrlParameter.Optional }
          //);
            //}
            //else
            //{
                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Restaurantes", action = "Index", id = UrlParameter.Optional }
                );
           // }




        }
    }
}
