using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore;
using Persistence;
>>>>>>> a09b1b0fafb371bcf02944b5d7dcf58ffc9c2ac9

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
=======
       
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });
>>>>>>> a09b1b0fafb371bcf02944b5d7dcf58ffc9c2ac9
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
<<<<<<< HEAD
                // app.UseHsts();
            }

            // app.UseHttpsRedirection();
=======
                //app.UseHsts();
            }

            //app.UseHttpsRedirection();
>>>>>>> a09b1b0fafb371bcf02944b5d7dcf58ffc9c2ac9
            app.UseMvc();
        }
    }
}
