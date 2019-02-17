using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIntroducao.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace APIIntroducao
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
            //PARA TRABALHAR COM MEMÓRIA LOCAL
            //services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("produtosDB"));

            //PARA UTILIZAR SQL
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));

            //CONFIGURAÇÃO PARA USUARIO
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //PARA USAR AUTENTICAÇÃO
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();

            //PARA EVITAR REFERENCE LOOPHANDING
            services.AddMvc().AddJsonOptions(ConfigureJson);
        }

        //PARA EVITAR REFERENCE LOOPHANDING
        private void ConfigureJson(MvcJsonOptions obj)
        {
            obj.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //PARA USAR AUTENTICAÇÃO
            app.UseAuthentication();

            app.UseMvc();

            if (!db.Categorias.Any())
            {
                //INSERTS NA MEMÓRIA
                db.Categorias.AddRange(
                    new List<Categoria>()
                    {
                        new Categoria(){Nome = "Alimentos", Produtos = new List<Produto>(){ new Produto() {Nome = "Biscoito Recheado" } } },
                        new Categoria(){Nome = "Bebidas" , Produtos = new List<Produto>(){ new Produto() {Nome = "Coca-Cola" }, new Produto() {Nome = "Skol" } } },
                        new Categoria(){Nome = "Limpeza" },
                    }    
                );
                db.SaveChanges();
            }
        }
    }
}
