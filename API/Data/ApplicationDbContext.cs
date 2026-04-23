using API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
// Thay bằng namespace chuẩn của bạn
namespace API.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<User>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Tùy chỉnh tên bảng nếu muốn, ví dụ: builder.Entity<User>().ToTable("Users");
    }
}