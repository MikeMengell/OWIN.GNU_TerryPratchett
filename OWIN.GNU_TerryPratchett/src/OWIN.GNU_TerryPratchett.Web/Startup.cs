﻿using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace OWIN.GNU_TerryPratchett.Web
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseGNUTerryPratchett();
        }
    }
}