

using API.Extensions;
using API.Middleware;

var builder = WebApplication.CreateBuilder(args);

//services container

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddCors();          
builder.Services.AddIdentityServices(builder.Configuration);

//middleware container

var app = builder.Build();

            app.UseMiddleware<ExceptionMiddleware>();
            app.UseHttpsRedirection();
            app.UseRouting();

            //should use policy in place of x but this course guy uses x alot
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
            app.UseAuthentication();
            app.UseAuthorization();        
            app.MapControllers();

            app.Run();
            

