using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreDemo.Models;

namespace NetCoreDemo
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("AppSettings.json");
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //注册Mvc服务
            services.AddMvc();
            //注册EF服务
            services.AddEntityFrameworkSqlServer().AddDbContext<NetCoreDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //调试模式
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //中间件-使用欢迎页面
            //app.UseWelcomePage();

            //中间件-使用默认文件
            //app.UseDefaultFiles();

            //中间件-使用静态文件
            //app.UseStaticFiles();

            //中间件-对UseDefaultFiles，UseStaticFiles的封装
            app.UseFileServer();

            //中间件-使用Mvc默认路由
            //app.UseMvcWithDefaultRoute();

            //中间件-使用Mvc路由配置
            app.UseMvc(ConfigureRoute);

            app.Run(async (context) =>
            {
                //throw new Exception("throw exception");
                var msg = Configuration["message"];
                await context.Response.WriteAsync(msg);
            });
        }

        //Mvc路由配置
        private void ConfigureRoute(IRouteBuilder routeBuilder)
        {
            //Home/Index 
            //routeBuilder.MapRoute("Default", "{controller}/{action}/{id?}");
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
