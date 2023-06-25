using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using OneRecordApiNew.Data;
using OneRecordMySql.Dapper;
using OneRecordMySql.IRepository;
using OneRecordMySql.Repository;
using OneRecordText.Model.OneRecord;
using OneRecordText.Utils;
using System.Reflection;
using System.Text;

namespace OneRecordApiNew//����Ŀ����cors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
                var requestfilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OneRecordText.xml");
                c.IncludeXmlComments(requestfilePath);
            });
            // ��ʼ�������ļ�
            var configuration = new ConfigurationBuilder()
                .SetBasePath(builder.Environment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // ��ʼ�� ConfigurationHelper
            ConfigurationHelper.Initialize(configuration);


            builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new LinkedObjectConverter());
            });
            //����������
            //builder.Services.AddCors(c =>
            //{
            //    c.AddPolicy("LimitRequests", policy =>
            //    {
            //        policy.WithOrigins("", "")//���������ʵĵ�ַ
            //        .AllowAnyHeader()
            //        .AllowAnyMethod();
            //    });
            //});
            builder.Services.AddSingleton(sp => new BaseDBContext(
                builder.Configuration.GetConnectionString("DbConnectionString")
            ));
            builder.Services.AddScoped<IMyTextRepository, MyTextRepository>();
            builder.Services.AddScoped<IwaybillRepository, waybillRepository>();

            builder.Services.AddRazorPages();

      

            //���Ի����򿪷�������
            //�κο�������ͨ��

            builder.Services.AddCors(c =>
            {
                c.AddPolicy("AllowAllOrigins", policy =>
                {
                    policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            var app = builder.Build();



            app.UseCors("AllowAllOrigins");

           

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StaticFiles")),
                RequestPath = "/StaticFiles"
            });

            app.UseHttpsRedirection();


            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }


    }
}