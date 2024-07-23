using Authenticate.API.Configurations;
using Authenticate.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.AddKeysMiddleware();
builder.AddDataBaseMiddleware();
builder.AddJwtAuthenticationMiddleware();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapEndpoints();

app.Run();
