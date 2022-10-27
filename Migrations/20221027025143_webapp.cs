using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASM.Migrations
{
    public partial class webapp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: false),
                    CategoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    ISBN = table.Column<string>(maxLength: 10, nullable: false),
                    PublicationDate = table.Column<DateTime>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    BookTitle = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    BookId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:Migrations/20221027053237_webapp.cs
                    { "A", "9f6d9def-76e4-4c85-b99c-f30947af1035", "Administrator", "Administrator" },
                    { "B", "44a4fa50-16f9-4243-a257-9faecce913d0", "Customer", "Customer" },
                    { "C", "f0300460-dee7-47e1-9fba-a9e569e818cc", "Staff", "Staff" }
========
<<<<<<<< HEAD:Migrations/20221027025143_webapp.cs
                    { "A", "f7d6b333-7d11-40db-a083-18d0fa641571", "Administrator", "Administrator" },
                    { "B", "8c07dfbc-155a-4f57-8eda-d16b48246aa0", "Customer", "Customer" },
                    { "C", "32a809fc-7b37-4022-810f-d169d373fb26", "Staff", "Staff" }
========
                    { "A", "f763332b-374a-4e38-9086-ba8077693039", "Administrator", "Administrator" },
                    { "B", "bfc1ce6a-6dfc-41f2-a78c-0e4d49dd4fa1", "Customer", "Customer" },
                    { "C", "7357cb27-d99a-41fd-b6a5-7d4068d46884", "Staff", "Staff" }
>>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d:Migrations/20221027025729_webapp.cs
>>>>>>>> 615ff2b489eea107576871fecc600ec1b8559e21:Migrations/20221027025143_webapp.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:Migrations/20221027053237_webapp.cs
                    { "1", 0, "b7691d6b-f3dc-4bdb-b711-53ca4995f3a1", "admin@fpt.com", true, false, null, null, "admin@fpt.com", "AQAAAAEAACcQAAAAEKJMpCSwVIxEuhvqf5nhfjz/ltGVcZTqHYOltKHYVGmXNI2mTjzbi2DPD6gJSr3sAQ==", null, false, "dbe115fe-36ba-45ca-abed-b2e46ca7dc86", false, "admin@fpt.com" },
                    { "2", 0, "9b3da2d8-3385-46b7-aeed-901adf1f3df1", "customer@fpt.com", true, false, null, null, "customer@fpt.com", "AQAAAAEAACcQAAAAEPipjceG7ITUav1vDKAa4PZIggLjOzqcV5YUZR2MYD5iIz8BTNKbr7FMRYGNBzmWRg==", null, false, "08541ceb-a895-4c6d-a855-55af0b03dbb6", false, "customer@fpt.com" },
                    { "3", 0, "dbd6edbd-42ab-4144-992c-7725cdc973f6", "staff@fpt.com", true, false, null, null, "staff@fpt.com", "AQAAAAEAACcQAAAAENQq0hUg8wiJdls+NWYzHGIx/fbyFBW55ontZF4crVU1PIxt4usYaJwDnWsFZaM5zQ==", null, false, "f18dfabc-e4f5-47dd-9005-321bad6e3480", false, "staff@fpt.com" }
========
<<<<<<<< HEAD:Migrations/20221027025143_webapp.cs
                    { "1", 0, "0b34d035-c82a-4558-9b04-630b61e9d729", "admin@fpt.com", true, false, null, null, "admin@fpt.com", "AQAAAAEAACcQAAAAEDh5kp/3t0BPNjUbTAb6pZvHdoeZ9NMoDopSBMNz2suaxGNtilT+Y3dZsi9YH4zYCg==", null, false, "58c1a1d2-7ab2-4039-9fed-f300d4077274", false, "admin@fpt.com" },
                    { "2", 0, "b600d782-e3a3-46a9-9c32-853196ee5e2e", "customer@fpt.com", true, false, null, null, "customer@fpt.com", "AQAAAAEAACcQAAAAEMvy4rkjZmCthIocRmU42YjZh5s2CYXm8J39lDrvLc+Rxqk2ddgiImGNAYUGxbIwNQ==", null, false, "903d34f3-5226-4b1f-ad53-1726aca801f1", false, "customer@fpt.com" },
                    { "3", 0, "e2a1e26d-1793-47bf-92f2-aa76b24af06e", "staff@fpt.com", true, false, null, null, "staff@fpt.com", "AQAAAAEAACcQAAAAEIj9Sw9lsI0hwRFr/mxFztWNAwLxcmpgbj/ky8Jx8LNNkj2JV2Z/yx0GS6ba33vsJA==", null, false, "32dd9158-2d4e-47a2-8a9f-d685acebe26e", false, "staff@fpt.com" }
========
                    { "1", 0, "18f3d524-50d0-4044-9e40-a2fdd5428fc5", "admin@fpt.com", true, false, null, null, "admin@fpt.com", "AQAAAAEAACcQAAAAEEHSv3jgNve4S3UL/kdISlXJZHjdpuQVnXYHUxGncznY+XNohBjRt/5f2qYXAAWaJw==", null, false, "ec02c351-431e-46b8-9772-8211432328ff", false, "admin@fpt.com" },
                    { "2", 0, "4ab2d9fa-a21b-4950-99d1-d1659cf4d40e", "customer@fpt.com", true, false, null, null, "customer@fpt.com", "AQAAAAEAACcQAAAAED8075cUTvQv00LmRO31zbthOTg8+7i94PBpLh+Jx4gQsh8g6VWigheQDcRTAhvnQA==", null, false, "080104dc-ad91-461f-96cc-75055c88c4db", false, "customer@fpt.com" },
                    { "3", 0, "fadee8d5-be09-4f76-ada2-3e1ca9e114c8", "staff@fpt.com", true, false, null, null, "staff@fpt.com", "AQAAAAEAACcQAAAAEOsOHW3j5oW1xZT+WgM0gpVp0xeUk0O0yTeq5AE+mQQwBn1INTkCcCZuWOn0OWMtoA==", null, false, "9ef9f0a7-a178-419d-afdc-bb621ee462e4", false, "staff@fpt.com" }
>>>>>>>> d451d31f1eb7a5b82a1c58644d2a0a5239b1a06d:Migrations/20221027025729_webapp.cs
>>>>>>>> 615ff2b489eea107576871fecc600ec1b8559e21:Migrations/20221027025143_webapp.cs
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, "A Academic Book for academical uses", "Academic" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "A" },
                    { "2", "B" },
                    { "3", "C" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "ISBN", "Image", "Price", "PublicationDate", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "George Beekman", 1, "1292021063", "https://m.media-amazon.com/images/I/41KpijH6OML._SX392_BO1,204,203,200_.jpg", 1000.0, new DateTime(2013, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pearson", "Digital Planet: Pearson New International Edition: Tomorrow's Technology and You, Complete" },
                    { 2, "ClydeBank Technology", 1, "1945051086", "https://m.media-amazon.com/images/I/41p8fQ6kRfL._SX331_BO1,204,203,200_.jpg", 2000.0, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), " ClydeBank Media LLC", "ITSM: QuickStart Guide - The Simplified Beginner's Guide to IT Service Management" },
                    { 3, "James Bernstein", 1, "1983154830", "https://m.media-amazon.com/images/I/41sSdMa14gL._SX348_BO1,204,203,200_.jpg", 2500.0, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Independently published", "Computers Made Easy: From Dummy To Geek" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
