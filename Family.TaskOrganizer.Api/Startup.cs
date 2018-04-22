using Family.TaskOrganizer.Api.Infrastructure.Repositories;
using Family.TaskOrganizer.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Family.TaskOrganizer.Api
{
    public class Startup
    {
        private string _mongoConnectionString =
            "mongodb://taskmanagerdb:l0MeXgSmaql1bDc5edaDl1s3lpcyf7MFNIW7Le5e05d8cNimWRfWyi5ybAZWyzUmgbd6gxE6Lsv8Qhj9bXb8WA==@taskmanagerdb.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IMongoClient>(client => new MongoClient(_mongoConnectionString));
            services.AddTransient<IBoardsRepository, BoardsRepository>();
            services.AddTransient<IWorkItemsService, WorkItemsService>();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
