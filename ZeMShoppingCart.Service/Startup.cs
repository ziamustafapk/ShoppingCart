﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ZeMShoppingCart.Service.Startup))]

namespace ZeMShoppingCart.Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
