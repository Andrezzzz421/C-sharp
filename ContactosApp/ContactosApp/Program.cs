using ContactosApp.Data;
using ContactosApp.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ContactoService>();

builder.Services.AddScoped<TipoServices>();

builder.Services.AddDbContext<ContactosDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("con")));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
   // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//   app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contacto}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
