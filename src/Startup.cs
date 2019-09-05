using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Configuration;
using IdentityServer4.Quickstart.UI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace identityserver4tokenservice
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddIdentityServer(options =>
                {
                    options.Endpoints = GetEndpointsOptions();
                    options.Discovery = GetDiscoveryOptions();
                    options.Events.RaiseErrorEvents = true;
                    options.Events.RaiseFailureEvents = true;
                    options.Events.RaiseInformationEvents = true;
                    options.Events.RaiseSuccessEvents = true;
                })
                .AddInMemoryApiResources(Config.GetApis())
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryClients(Config.GetClients())
                .AddTestUsers(TestUsers.Users)
                .AddDeveloperSigningCredential(persistKey: false);
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseIdentityServer();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvcWithDefaultRoute();
        }

        protected EndpointsOptions GetEndpointsOptions()
        {
            return new EndpointsOptions()
            {
                EnableDiscoveryEndpoint = true,
                EnableAuthorizeEndpoint = true,
                EnableTokenEndpoint = true,
                EnableUserInfoEndpoint = true,
                EnableTokenRevocationEndpoint = true,
                EnableIntrospectionEndpoint = true,
                EnableCheckSessionEndpoint = true,
                EnableEndSessionEndpoint = true
            };
        }

        protected DiscoveryOptions GetDiscoveryOptions()
        {
            return new DiscoveryOptions()
            {
                ShowClaims = false,
                ShowGrantTypes = true,
                ShowExtensionGrantTypes = false,
                ShowKeySet = true,
                ShowResponseModes = false,
                ShowResponseTypes = false
            };
        }
    }
}
