// 1. Khai báo DbContext

using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Thiết lập Identity
builder.Services.AddIdentity<User, IdentityRole>(options => {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6; // Cho phép pass đơn giản lúc dev
        options.Password.RequireNonAlphanumeric = false;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddProblemDetails();
var app = builder.Build();
app.UseExceptionHandler();
app.UseStaticFiles();
// ... sau đó bên dưới app.Build()
app.UseAuthentication(); // Phải đứng trước Authorization
app.UseAuthorization();
app.Run();