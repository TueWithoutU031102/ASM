using ASM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //tạo bảng (DB) tương ứng model (Code)
        //Book: tên của Model (design của bảng)
        //Books: tên của bảng & tên của DbSet (collection) được gọi đến trong Controller
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //add dữ liệu cho bảng User
            SeedUser(builder);

            //add dữ liệu cho bảng Role
            SeedRole(builder);

            //add dữ liệu cho bảng UserRole
            SeedUserRole(builder);
        }

        private void SeedUser(ModelBuilder builder)
        {
            //1. tạo tài khoản ban đầu để add vào DB
            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@fpt.com",
                Email = "admin@fpt.com",
                NormalizedUserName = "admin@fpt.com",
                EmailConfirmed = true
            };

            var customer = new IdentityUser
            {
                Id = "2",
                UserName = "customer@fpt.com",
                Email = "customer@fpt.com",
                NormalizedUserName = "customer@fpt.com",
                EmailConfirmed = true
            };
            var staff = new IdentityUser
            {
                Id = "3",
                UserName = "staff@fpt.com",
                Email = "staff@fpt.com",
                NormalizedUserName = "staff@fpt.com",
                EmailConfirmed = true
            };
            //2. khai báo thư viện để mã hóa mật khẩu
            var hasher = new PasswordHasher<IdentityUser>();

            //3. thiết lập và mã hóa mật khẩu   từng tài khoản
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");
            staff.PasswordHash = hasher.HashPassword(staff, "123456");

            //4. add tài khoản vào db
            builder.Entity<IdentityUser>().HasData(admin, customer, staff);
        }

        private void SeedRole(ModelBuilder builder)
        {
            //1. tạo các role cho hệ thống
            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };
            var customer = new IdentityRole
            {
                Id = "B",
                Name = "Customer",
                NormalizedName = "Customer"
            };
            var staff = new IdentityRole
            {
                Id = "C",
                Name = "Staff",
                NormalizedName = "Staff"
            };
            //2. add role vào trong DB
            builder.Entity<IdentityRole>().HasData(admin, customer, staff);

        }

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "A"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "B"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "C"
                }
             );
        }
    }
}
