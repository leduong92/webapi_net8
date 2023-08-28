using API.Extensions;
using API.Middleware;
using Infrastructure.Data;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// var conn = builder.Configuration.GetConnectionString("DefaultConnection");

// builder.Services.AddDbContext<TestdbContext>(option =>
//         option.UseNpgsql(conn)
// );

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocumentation();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.Urls.Add("http://172.18.108.243:5046");
app.Urls.Add("http://localhost:5046");

app.UseMiddleware<ExceptionMiddleware>();
// app.UseMiddleware<ApiKeyAuthMiddleware>();
app.UseStatusCodePagesWithReExecute("/errors/{0}");
app.UseSwaggerDocumentation();
app.UseStaticFiles();

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// using var scope = app.Services.CreateScope();
// var services = scope.ServiceProvider;
// var context = services.GetRequiredService<TestdbContext>();
// var logger = services.GetRequiredService<ILogger<Program>>();
// try
// {
//     // await context.Database.MigrateAsync();
// }
// catch (Exception ex)
// {
//     logger.LogError(ex, "An error occured during migration");
// }

app.Run();
