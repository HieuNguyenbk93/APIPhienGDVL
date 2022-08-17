using AutoMapper;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using BusinessLogic.Implements;
using Interfaces;
//using Interfaces.Model.FIleAttacth;
using WebApi.Entities;
using WebApi.Maper;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
//using DataAccess.Models;
using DevExpress.Internal;
using Microsoft.OpenApi.Models;
using Repositories.Bases;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace WebApi
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
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue;
                x.MemoryBufferThreshold = int.MaxValue;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            // ===== Add our DbContext ========
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"))
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.Configure<ConnectionString>(Configuration.GetSection("ConnectionString"));

            // ===== Add Identity ========
            services.AddIdentity<IdentityUser, IdentityRole>(o =>
                {
                    // configure identity options
                    o.Password.RequireDigit = true;
                    o.Password.RequireLowercase = true;
                    o.Password.RequireUppercase = true;
                    o.Password.RequireNonAlphanumeric = true;
                    o.Password.RequiredLength = 6;
                    o.Lockout.MaxFailedAccessAttempts = 5;
                    o.Lockout.DefaultLockoutTimeSpan = new TimeSpan(300, 24, 60, 60);
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // ===== Add Jwt Authentication ========

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler
            {
                InboundClaimTypeMap = new Dictionary<string, string>()
            };

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear(); // => remove default claims
            // 17/08/2022 off authen
            //services
            //    .AddAuthentication(options =>
            //    {
            //        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            //    })
            //    .AddJwtBearer(cfg =>
            //    {
            //        cfg.RequireHttpsMetadata = false;
            //        cfg.SaveToken = true;
            //        cfg.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidIssuer = Configuration["JwtIssuer"],
            //            ValidAudience = Configuration["JwtIssuer"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtKey"])),
            //            ClockSkew = TimeSpan.Zero, // remove delay of token when expire,

            //        };
            //        cfg.SecurityTokenValidators.Clear();
            //        cfg.SecurityTokenValidators.Add(jwtSecurityTokenHandler);
            //    });
            //services.AddTransient<IDepartmentBusinessLogic, DepartmentBusinessLogic>();
            //services.AddTransient<IAuthenticationBusinessLogic, AuthenticationBusinessLogic>();
            //services.AddTransient<IGroupUserBusinessLogic, GroupUserBusinessLogic>();
            //services.AddTransient<IUserBusinessLogic, UserBusinessLogic>();
            //services.AddTransient<ISystemConfigBusinessLogic, SystemConfigBusinessLogic>();
            //services.AddTransient<ISystemLogBusinessLogic, SystemLogBusinessLogic>();
            //services.AddTransient<ILaborerBusinessLogic, LaborerBusinessLogic>();
            //services.AddTransient<IFileBusinessLogic, FileBusinessLogic>();
            //services.AddTransient<IDashBoardBusinessLogic, DashBoardBusinessLogic>();
            //services.AddTransient<IUnitBusinessLogic, UnitBusinessLogic>();
            //services.AddTransient<ICatalogBusinessLogic, CatalogBusinessLogic>();
            //services.AddTransient<IRegionBusinessLogic, RegionBusinessLogic>();
            //services.AddTransient<IBusinessBusinessLogic, BusinessBusinessLogic>();
            //services.AddTransient<INguoiSdLaoDongLogic, NguoiSdLaoDongLogic>();
            //services.AddTransient<IBsNguoiSdLaoDongBusinessLogic, BsNguoiSdLaoDongBusinessLogic>();
            //services.AddTransient<IHisNguoiSdLaoDongBusinessLogic, HisNguoiSdLaoDongBusinessLogic>();
            //services.AddTransient<IHisNguoiLaoDongBusinessLogic, HisNguoiLaoDongBusinessLogic>();
            //services.AddTransient<INguoiLaoDongBusinessLogic, NguoiLaoDongBusinessLogic>();
            //services.AddTransient<IUngVienBusinessLogic, UngVienBusinessLogic>();
            //services.AddTransient<IHisNhaTuyenDungBusinessLogic, HisNhaTuyenDungBusinessLogic>();
            //services.AddTransient<IHisUngVienBusinessLogic, HisUngVienBusinessLogic>();
            //services.AddTransient<INhaTuyenDungBusinessLogic, NhaTuyenDungBusinessLogic>();
            //services.AddTransient<IHtEmailBusinessLogic, HtEmailBusinessLogic>();
            //services.AddTransient<INguoiTimViecPortalBusinessLogic, NguoiTimViecPortalBusinessLogic>();
            //services.AddTransient<ICongBoNguoiSdLaoDongLogic, CongBoNguoiSdLaoDongLogic>();
            //services.AddTransient<ICongBoNguoiTimViecLogic, CongBoNguoiTimViecLogic>();
            //services.AddTransient<ITinTucLogic, TinTucBusinessLogic>();
            services.AddTransient<ITradingsessionBusinessLogic, TradingsessionBusinessLogic>();
            services.AddTransient<IHisTraddingSessionBusinessLogic, HisTraddingSessionBusinessLogic>();
            services.AddTransient<IPgdXacNhanDnBusinessLogic, PgdDnBusinessLogic>();
            services.AddAutoMapper(x => x.AddProfile(new MappingProfile()));
            services.AddCors();
            services.AddMvc().AddDefaultReportingControllers();

            services.AddMvc().ConfigureApplicationPartManager(x =>
            {
                var parts = x.ApplicationParts;
                var aspNetCoreReportingAssemblyName = typeof(DevExpress.AspNetCore.Reporting.WebDocumentViewer.WebDocumentViewerController).Assembly.GetName().Name;
                var reportingPart = parts.FirstOrDefault(part => part.Name == aspNetCoreReportingAssemblyName);
                if (reportingPart != null)
                {
                    parts.Remove(reportingPart);
                }
            });

            //Prevent automatically convert to UTC
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
                options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            });
            //services.AddSignalR();
            services.AddSingleton<WebDocumentViewerOperationLogger, WebDocumentViewerOperationLogger>();
            //Config EmailService
            //services.AddSingleton<IEmailConfiguration>(Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
            //services.AddSingleton<IUrlFileSupport>(Configuration.GetSection("UrlFileSupport").Get<UrlFileSupport>());

            //services.AddSingleton<UserInfoInMemory>();

            services.AddDevExpressControls();
            services.AddMvc().ConfigureApplicationPartManager(x => {
                var parts = x.ApplicationParts;
                var aspNetCoreReportingAssemblyName = typeof(DevExpress.AspNetCore.Reporting.WebDocumentViewer.WebDocumentViewerController).Assembly.GetName().Name;
                var reportingPart = parts.FirstOrDefault(part => part.Name == aspNetCoreReportingAssemblyName);
                if (reportingPart != null)
                {
                    parts.Remove(reportingPart);
                }
            });

            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SVL APIPhienGDVL", Version = "v1" });
            });
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
                app.UseHsts();
            }
            app.UseStaticFiles(); // wwwroot
            app.UseStaticFiles(new StaticFileOptions
            {
                //FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @".well-known")),
                //RequestPath = new PathString("/.well-known"),
                ServeUnknownFileTypes = true // serve extensionless file
            });
            // Dev
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(new ReportStorageWebExtension1(mapper));
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Bindings;
            //System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            app.UseDevExpressControls();
            app.UseStaticFiles();
            // end
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                await next.Invoke();
            });
            app.UseCors(
              options => options.WithOrigins("http://localhost:4200")
                          .AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowCredentials()
            );
            //app.UseAuthentication();
            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "SVL APIPhienGDVL V1");
            });

            app.UseMvc();
        }
    }
}
