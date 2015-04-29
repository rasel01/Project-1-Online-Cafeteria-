using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using UiuCanteen.Domain.Entities;
using UiuCanteen.WebUi.App_Start;
using UiuCanteen.WebUi.Binders;

namespace UiuCanteen.WebUi
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);     
            ModelBinders.Binders.Add(typeof(Cart),new CartModelBinder());
        }
    }
}