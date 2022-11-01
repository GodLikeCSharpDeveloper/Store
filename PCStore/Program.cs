using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using PCStore.Data;
using PCStore.Models;
<<<<<<< HEAD
using PCStore.Repositories;
=======
>>>>>>> 08e829bc27e7c8f48bfe9df118c6c2ff3dafa3d5

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
<<<<<<< HEAD


builder.Services.AddDbContext<StoreContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));
builder.Services.AddScoped<StoreRepository>();
=======
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<StoreContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("Server=DESKTOP-0E043TF;Database=Store;Trusted_Connection=True;")));
>>>>>>> 08e829bc27e7c8f48bfe9df118c6c2ff3dafa3d5
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    
        app.UseSwaggerUI();
    }

    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();


// some changge

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
