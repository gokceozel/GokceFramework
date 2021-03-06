using GokceFramework.Core.Utilities.Mvc.Infrastructure;
using GokceFramework.Northwind.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GokceFramework.MvcWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));
        }
        //public override void Init()
        //{
        //    PostAuthenticateRequest += MvcApplication_PostAuthenticateRequest;
        //    base.Init();
        //}

        //private void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
        //        if (authCookie == null)
        //        {
        //            return;
        //        }

        //        var encTicket = authCookie.Value;
        //        if (String.IsNullOrEmpty(encTicket))
        //        {
        //            return;
        //        }

        //        var ticket = FormsAuthentication.Decrypt(encTicket);

        //        var securityUtlities = new SecurityUtilities();
        //        var identity = securityUtlities.FormsAuthTicketToIdentity(ticket);
        //        var principal = new GenericPrincipal(identity, identity.Roles);

        //        HttpContext.Current.User = principal;
        //        Thread.CurrentPrincipal = principal;
        //    }
        //    catch (Exception)
        //    {

        //    }


        //}
    }
}
