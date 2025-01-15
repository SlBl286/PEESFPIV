using PEESFPIV.Frontend.Components;
using PEESFPIV.Frontend.Constants;
using PEESFPIV.Frontend.Databases;
using PEESFPIV.Frontend.States;
using PEESFPIV.Frontend.Utils;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddStates();
builder.Services.AddUtils();
builder.Services.AddBlazorBootstrap();

builder.Services.AddDatabase(builder.Configuration);
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddAuthentication(Cookies.AuthScheme)
                .AddCookie(Cookies.AuthScheme, options =>
                {
                    options.Cookie.Name = Cookies.AuthCoockie;
                    options.Cookie.Path = "/";
                    options.LoginPath = "/cms/auth/Login";
                    options.AccessDeniedPath = "/cms/auth/Access-Denied";
                    options.LogoutPath = "/cms/auth/Logout";

                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.Cookie.SameSite = SameSiteMode.Unspecified;

                    options.ExpireTimeSpan = TimeSpan.FromDays(2);
                    options.SlidingExpiration = true;
                });

builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddCors(options =>
{
     options.AddPolicy("AuthOrigins",
                           policy =>
                           {
                                policy.WithOrigins("http://192.168.0.23:5249")
                                                   .AllowAnyHeader()
                                                   .AllowAnyMethod()
                                                   .AllowCredentials();
                           });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStaticFiles();
app.UseCors("AuthOrigins");

app.UseHttpsRedirection();
app.UseAuthentication()
    .UseAuthorization();


app.UseAntiforgery();


app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
