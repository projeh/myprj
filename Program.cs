//////using Microsoft.AspNetCore.Authentication.Cookies;
//////using Microsoft.AspNetCore.Rewrite;

//////var builder = WebApplication.CreateBuilder(args);

////////#region Authentication
//////////////builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//////////////    .AddCookie(option =>
//////////////    {
//////////////        option.LoginPath = "/Login";
//////////////        option.LogoutPath = "/Logout";
//////////////        option.ExpireTimeSpan = TimeSpan.FromDays(30);
//////////////        option.Cookie.Name = "mhmdhidry";
//////////////    });
////////#endregion

//////builder.Services.AddSession(options => {
//////	options.IdleTimeout = TimeSpan.FromDays(1);
//////});

//////////////// Add services to the container.
//////////////builder.Services.AddRazorPages()
//////////////		.AddRazorPagesOptions(options =>
//////////////		{
//////////////			options.Conventions.AddPageRoute("/Landing", "Landing/{name}");
//////////////		});

//////var app = builder.Build();

////////var options = new RewriteOptions()
////////	.AddRedirect("Devreg", "Landing/Devreg", 301);
////////app.UseRewriter(options);

//////// Configure the HTTP request pipeline.
////////////if (!app.Environment.IsDevelopment())
////////////{
////////////    app.UseExceptionHandler("/Error");
////////////    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
////////////    app.UseHsts();
////////////    app.UseDeveloperExceptionPage();
////////////}

////////////app.UseHttpsRedirection();
//////app.UseStaticFiles();

//////////////app.UseRouting();

//////////////app.UseAuthentication();

//////////////app.UseAuthorization();

//////app.MapRazorPages();

//////app.UseSession();

////////////////app.Use(async (context, next) =>
////////////////{
////////////////	await next();
////////////////	if (context.Response.StatusCode == 404)
////////////////	{
////////////////		context.Response.Redirect("/Error");
////////////////	}
////////////////});

//////app.Run();
///
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();



//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
