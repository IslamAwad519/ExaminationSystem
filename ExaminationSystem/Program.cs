var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services.AddPresentation(builder.Configuration);

    //builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
    //    .AddEntityFrameworkStores<ApplicationDbContext>();

}


var app = builder.Build();
{

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseAuthentication();
    app.UseHttpsRedirection();
    app.UseCors();

    app.UseAuthorization();
    //app.MapIdentityApi<ApplicationUser>();

    app.MapControllers();

    app.Run();
}