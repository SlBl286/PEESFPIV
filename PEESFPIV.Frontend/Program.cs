using PEESFPIV.Frontend.Components;
using PEESFPIV.Frontend.Constants;
using PEESFPIV.Frontend.Databases;
using PEESFPIV.Frontend.States;
using PEESFPIV.Frontend.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddStates();
builder.Services.AddUtils();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddDatabase(builder.Configuration);

builder.Services.AddAuthentication(Cookies.AuthScheme)
                .AddCookie(Cookies.AuthScheme, options =>
                {
                    options.Cookie.Name = Cookies.AuthCoockie;
                    options.LoginPath = "/cms/auth/Login";
                    options.AccessDeniedPath = "/cms/auth/Access-Denied";
                    options.LogoutPath = "/cms/auth/Logout";

                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.Cookie.SameSite = SameSiteMode.Strict;

                    options.ExpireTimeSpan = TimeSpan.FromDays(2);
                    options.SlidingExpiration = true;
                });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication()
    .UseAuthorization();

app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
