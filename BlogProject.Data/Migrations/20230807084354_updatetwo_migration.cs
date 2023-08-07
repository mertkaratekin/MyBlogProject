using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.Data.Migrations
{
    public partial class updatetwo_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3a89f742-78f4-473e-9e0e-506d824e4c2d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("74388afc-34f6-431c-8829-c05e7b2cd8b4"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("8de6adea-9f32-4976-8a5e-e94f73fc23bc"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 8, 7, 11, 43, 53, 711, DateTimeKind.Local).AddTicks(2150), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Visual Studio Deneme Makalesi 1", 8 },
                    { new Guid("97549191-17e5-44eb-bea1-769fb17a99d7"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 8, 7, 11, 43, 53, 711, DateTimeKind.Local).AddTicks(2142), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("95fd6878-a514-4c01-8fb8-eb665e512d3f"),
                column: "ConcurrencyStamp",
                value: "c1202fbd-5b03-42aa-85b4-fcf9f38add28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ca5fa4ec-be54-47bd-bc29-506687fba08e"),
                column: "ConcurrencyStamp",
                value: "c576f870-37cb-4375-9d7c-34c7055e90df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dfb45ace-1801-46b3-917b-eeaa7b1539b6"),
                column: "ConcurrencyStamp",
                value: "35f4064d-195f-4506-a1be-6e1f8babf5c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b48803d-a991-48e2-a19e-d6ca562f1d96"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7f3cff6-941e-44cf-a6d6-c28c56f43346", "AQAAAAEAACcQAAAAEJIf6J7UoSY0ReS69IQOG8j4qVisjWFDN8CYwATXDXD2xwQHxQvXUfHSuCDTH8yeIg==", "477e41ba-1ec1-4dda-bd25-c00a2053a053" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c34da79-f839-4aa8-95de-1d31a3b39c28"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a0ccbcf-362e-476d-b104-8318ed907b49", "AQAAAAEAACcQAAAAEKH2LDvkLuxKmORox1WOJYIPKRtyOmB86RjKACy+HDDyWRMb59O06FJjF57TWdvGDw==", "ab70a80e-7953-42b6-9cf4-882587e4bfdb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 11, 43, 53, 711, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 11, 43, 53, 711, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 11, 43, 53, 711, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 11, 43, 53, 711, DateTimeKind.Local).AddTicks(2637));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8de6adea-9f32-4976-8a5e-e94f73fc23bc"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("97549191-17e5-44eb-bea1-769fb17a99d7"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3a89f742-78f4-473e-9e0e-506d824e4c2d"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 8, 7, 11, 42, 0, 378, DateTimeKind.Local).AddTicks(1486), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("74388afc-34f6-431c-8829-c05e7b2cd8b4"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 8, 7, 11, 42, 0, 378, DateTimeKind.Local).AddTicks(1494), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Visual Studio Deneme Makalesi 1", 8 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("95fd6878-a514-4c01-8fb8-eb665e512d3f"),
                column: "ConcurrencyStamp",
                value: "7b4ac5fd-051f-42ae-bb14-6613dfdf2e41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ca5fa4ec-be54-47bd-bc29-506687fba08e"),
                column: "ConcurrencyStamp",
                value: "ab16f3ff-3f57-483f-ba8a-34ee33750786");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dfb45ace-1801-46b3-917b-eeaa7b1539b6"),
                column: "ConcurrencyStamp",
                value: "35086e64-e1fa-4803-84df-c4a6eff58d7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b48803d-a991-48e2-a19e-d6ca562f1d96"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b687ff5-3ab8-4830-91d4-59d5b2ed0ae1", "AQAAAAEAACcQAAAAEKcH76dq+Rqs0UMFP5kWVkmuxy0F1MNz5VYYl8HC+U6hzdpJ6Dm2PhBptJkRdkfiRg==", "a355ab72-be05-45bf-9f61-8211fdf281b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c34da79-f839-4aa8-95de-1d31a3b39c28"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84ddd711-98cc-49dc-9c16-3d6bdf9079f9", "AQAAAAEAACcQAAAAEGnr9tjbPOxTipPj5tUhHzilkYtvGEIhJClDunE+YOm1FX+jnhYiPUm2T74wFeNrRQ==", "9036e707-adb6-41e4-be04-17f17a10b277" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 11, 42, 0, 378, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 11, 42, 0, 378, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 11, 42, 0, 378, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 11, 42, 0, 378, DateTimeKind.Local).AddTicks(1713));
        }
    }
}
