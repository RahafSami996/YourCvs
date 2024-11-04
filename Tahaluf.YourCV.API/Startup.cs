using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.YourCV.Core.Common;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;
using Tahaluf.YourCV.Infra.Common;
using Tahaluf.YourCV.Infra.Repository;
using Tahaluf.YourCV.Infra.Service;
using Tahalut.YourCV.Infra.Repository;
using Tahalut.YourCV.Infra.Service;

namespace Tahaluf.YourCV.API
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
            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();

            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<ITemplateDocumentRepository, TemplateDocumentRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<IWebsiteInfoRepository, WebsiteInfoRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRoleRepository, PermissionRoleRepository>();



            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<IPermissionRoleService, PermissionRoleService>();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ITemplateDocumentService, TemplateDocumentService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IWebsiteInfoService, WebsiteInfoService>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IExperienceRepository, ExperienceRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IPermessionRepository, PermessionRepository>();

            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IExperienceService, ExperienceService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IPermessionService, PermessionService>();
            services.AddScoped<IAboutUsRepository, AboutUsRepository>();
            services.AddScoped<ICreditCardRepository, CreditCardRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<IResumeRepository, ResumeRepository>();
            services.AddScoped<IAboutUsService, AboutUsService>();
            services.AddScoped<ICreditCardService, CreditCardService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IResumeService, ResumeService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<IContactUsService, ContactUsService>();

            services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
            services.AddScoped<IContactInfoService, ContactInfoService>();

            services.AddScoped<IJwtRepository, JwtRepository>();
            services.AddScoped<IJwtService,JwtService>();

            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("x",
                builder =>
                {
                    //builder.WithOrigins("http://127.0.0.1:4200", "http://localhost:4200", "https://localhost:4200")
                    // .AllowAnyHeader()
                    // .AllowAnyMethod();

                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
           
            // Jwt Section
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(y =>
            {
                y.RequireHttpsMetadata = false;
                y.SaveToken = true;
                y.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]")),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseHttpsRedirection();
            
            app.UseCors("x");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
