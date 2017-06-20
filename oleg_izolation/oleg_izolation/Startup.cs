using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(oleg_izolation.Startup))]
namespace oleg_izolation
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var loginPath = new PathString("/CallBack/LogIn");
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = loginPath
            });
        }
    }
}