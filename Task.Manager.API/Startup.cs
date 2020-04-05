using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FluentMediator;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Task.Manager.API.UseCases;
using Task.Manager.API.UseCases.GetBoards;
using Task.Manager.Application.Boundaries;
using Task.Manager.Application.Boundaries.GetBoards;
using Task.Manager.Application.Services.Implementations;
using Task.Manager.Application.Services.Interfaces;
using Task.Manager.Application.UseCases;
using Task.Manager.Domain.Boards;
using Task.Manager.Infrastructure.Factories;
using Task.Manager.Infrastructure.Repositories;

namespace Task.Manager.API
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

            services.AddFluentMediator(builder =>
            {
                builder.On<GetBoardsInput>().PipelineAsync().Call<IUseCase<GetBoardsInput>>((handler, request) => handler.Handle(request));
            });

            services.AddScoped<IUseCase<GetBoardsInput>, GetBoardsUseCase>();
            services.AddScoped<IPresenter<GetBoardsOutput>, GetBoardsPresenter>();
            services.AddScoped<IPresenterOutputPort<GetBoardsOutput>, GetBoardsPresenter>();
            services.AddScoped<IBoardService, BoardService>();
            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<IBoardFactory, EntityFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
