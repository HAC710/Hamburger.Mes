namespace API.Entities;
using Microsoft.AspNetCore.Identity;
public class User: IdentityUser
{
    // Thêm các trường bạn cần cho hệ thống MES
    public string FullName { get; set; }
    public string StaffCode { get; set; } // Mã nhân viên
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}