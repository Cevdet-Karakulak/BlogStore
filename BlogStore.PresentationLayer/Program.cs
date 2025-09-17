using BlogStore.BusinessLayer.Abstract;
using BlogStore.BusinessLayer.Concrete;
using BlogStore.BusinessLayer.Container;
using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using BlogStore.DataAccessLayer.EntityFramework;
using BlogStore.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.ContainerDependencies();
builder.Services.AddHttpClient<IToxicityDetectionService, ToxicityManager>();
builder.Services.AddHttpClient<ITranslationService, TranslationManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "articleDetail",
    pattern: "Article/ArticleDetail/{slug}",
    defaults: new { controller = "Article", action = "ArticleDetail" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
