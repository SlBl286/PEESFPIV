using PEESFPIV.Frontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();


builder.Services.AddCascadingAuthenticationState();
const string AuthScheme = "PEESFPIV-AUTH";
const string AuthCoockie = "PEESFPIV-AUTH";

builder.Services.AddAuthentication(AuthScheme)
                .AddCookie(AuthScheme, options =>
                {
                    options.Cookie.Name = AuthCoockie;
                    options.LoginPath = "/CMS/auth/Login";
                    options.AccessDeniedPath = "/CMS/auth/Access-Denied";
                    options.LogoutPath = "/CMS/auth/Logout";

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
