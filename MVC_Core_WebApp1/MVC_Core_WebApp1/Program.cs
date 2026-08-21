var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("1.What is your name: \n");
//    await next.Invoke();  //it will invoke the next component in the pipeline

//});
//app.Use(async (context, next) =>
//{
//    //await context.Response.WriteAsync("2.In which city you liv?e: \n");
//    await next.Invoke();
//    await context.Response.WriteAsync("2.In which city you live: \n");

//});
//app.Run(async context =>
//{
//    await context.Response.WriteAsync("3.Purpose of visit here: \n");

//});
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
