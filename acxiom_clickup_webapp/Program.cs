
using Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

////Configure Azure AD authentication
//builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
//    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

//builder.Configuration.GetSection("ClickUpSettings").Get<ClickUpConfig>();

//builder.Services.AddAuthorization(options =>
//{
//    options.FallbackPolicy = new Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder()
//        .RequireAuthenticatedUser()
//        .Build();
//});

//// Configure cookie login path so unauthenticated users are redirected to a local sign-in page first
////builder.Services.Configure<CookieAuthenticationOptions>(CookieAuthenticationDefaults.AuthenticationScheme, options =>
////{
////    options.LoginPath = "/Account/SignIn";
////});

//// Restrict sign-in to configured company domain (optional)
//builder.Services.Configure<OpenIdConnectOptions>(OpenIdConnectDefaults.AuthenticationScheme, options =>
//{
//    var config = builder.Configuration;
//    options.Events ??= new OpenIdConnectEvents();
//    options.Events.OnTokenValidated = context =>
//    {
//        var domain = config["AzureAd:Domain"];
//        var preferred = context.Principal?.FindFirst("preferred_username")?.Value
//                        ?? context.Principal?.FindFirst(ClaimTypes.Upn)?.Value;
//        if (!string.IsNullOrEmpty(domain) && !string.IsNullOrEmpty(preferred) &&
//            !preferred.EndsWith("@" + domain, StringComparison.OrdinalIgnoreCase))
//        {
//            context.Fail("Sign-in not allowed for this account domain.");
//        }
//        return Task.CompletedTask;
//    };
//});
builder.Services
    .AddApplicationServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
