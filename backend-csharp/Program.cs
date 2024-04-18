using backend_csharp.Database;
using backend_csharp.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        configurePolicy => configurePolicy
            .SetIsOriginAllowed(x => true)
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton(typeof(IProductService), typeof(ProductService));
builder.Services.AddSingleton(typeof(IStoreProduct), typeof(StoreProduct));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(
    options =>
    {
        // make the swagger ui show at app's root. Else will see localhost page not found error.
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    }
);

app.UseRouting();
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

//ResolveService<IProductService>(app);
//ResolveService<IStoreProduct>(app);

app.Run();

T? ResolveService<T>(IApplicationBuilder app)
{
    var serviceProvider = app.ApplicationServices;
    T? service = serviceProvider.GetService<T>();
    return service;
}