using AngryMonkey.CloudWeb;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


CloudWebConfig cloudWeb = new()
{
    PageDefaults = new()
    {
        Title = "Marketing Agency",
        Bundles = new()
         {
         new(){ Source = "https://cdn.amcapi.com/cloudweb/1.0.2/cloud-base.min.js" },   
         new(){ Source = "css/site.css"},
         new(){ Source = "js/site.js"},
         },
        TitleAddOns = new()
        {

        }
    },
    TitleSuffix = " - Marketing Agency",
};

builder.Services.AddCloudWeb(cloudWeb);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

await app.RunAsync();
