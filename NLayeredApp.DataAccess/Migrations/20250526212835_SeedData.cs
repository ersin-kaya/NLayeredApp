using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayeredApp.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", "Electronic products category", true, null, null, "Electronics" },
                    { 2, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", "Clothing products category", true, null, null, "Clothing" },
                    { 3, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", "Home and living products", true, null, null, "Home & Living" }
                });

            migrationBuilder.InsertData(
                table: "FeatureTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Color" },
                    { 2, "Size" },
                    { 3, "Material" },
                    { 4, "Storage" },
                    { 5, "Memory" },
                    { 6, "Processor" },
                    { 7, "Screen Size" }
                });

            migrationBuilder.InsertData(
                table: "CategoryFeatureTypes",
                columns: new[] { "CategoryId", "FeatureTypeId", "Label" },
                values: new object[,]
                {
                    { 1, 1, "Color" },
                    { 1, 4, "Storage Capacity" },
                    { 1, 5, "RAM" },
                    { 1, 6, "Processor" },
                    { 1, 7, "Screen Size" },
                    { 2, 1, "Color" },
                    { 2, 2, "Size" },
                    { 2, 3, "Material" },
                    { 3, 1, "Color" },
                    { 3, 3, "Material" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsActive", "LastModifiedAt", "LastModifiedBy", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Samsung's latest smartphone", true, null, null, "Galaxy S25", 74999.00m, 200 },
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Samsung's flagship phone", true, null, null, "Galaxy S24", 54999.00m, 200 },
                    { 3, 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Wireless performance mouse", true, null, null, "Logitech MX Master 3S", 3129.99m, 110 },
                    { 4, 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Wireless illuminated keyboard", true, null, null, "Logitech MX Keys", 3119.99m, 95 },
                    { 5, 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Gaming headset with Blue VO!CE", true, null, null, "Logitech G Pro X", 5149.99m, 70 },
                    { 6, 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Wired gamepad controller", true, null, null, "Logitech F310", 529.99m, 200 },
                    { 7, 2, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "100% cotton polo shirt", true, null, null, "Polo Shirt", 299.99m, 500 },
                    { 8, 2, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Regular Fit Denim Jeans", true, null, null, "Blue Denim Jean", 599.99m, 300 },
                    { 9, 2, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "High-quality running shoes designed for daily training and comfort", true, null, null, "Running Shoes", 899.99m, 100 },
                    { 10, 3, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Wooden dining table with 6 chairs", true, null, null, "Dining Table Set", 1899.99m, 15 },
                    { 11, 3, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "Modern adjustable LED floor lamp", true, null, null, "LED Floor Lamp", 299.99m, 50 },
                    { 12, 3, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "system", null, null, "5-tier wooden bookshelf", true, null, null, "Bookshelf", 599.99m, 30 }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CategoryId", "FeatureTypeId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Black" },
                    { 2, 1, 1, "White" },
                    { 3, 1, 1, "Silver" },
                    { 4, 1, 4, "64 GB" },
                    { 5, 1, 4, "128 GB" },
                    { 6, 1, 4, "256 GB" },
                    { 7, 1, 4, "512 GB" },
                    { 8, 1, 5, "4 GB" },
                    { 9, 1, 5, "8 GB" },
                    { 10, 1, 5, "16 GB" },
                    { 11, 1, 5, "32 GB" },
                    { 12, 1, 6, "Amd Ryzen 5 7600X" },
                    { 13, 1, 6, "Amd Ryzen 7 9800X3D" },
                    { 14, 1, 6, "Amd Ryzen 9 9950X3D" },
                    { 15, 1, 7, "5.5\"" },
                    { 16, 1, 7, "6.1\"" },
                    { 17, 1, 7, "13.3\"" },
                    { 18, 1, 7, "15.6\"" },
                    { 19, 1, 7, "24\"" },
                    { 20, 1, 7, "27\"" },
                    { 21, 2, 1, "Red" },
                    { 22, 2, 1, "Blue" },
                    { 23, 2, 1, "Green" },
                    { 24, 2, 1, "Yellow" },
                    { 25, 2, 2, "XS" },
                    { 26, 2, 2, "S" },
                    { 27, 2, 2, "M" },
                    { 28, 2, 2, "L" },
                    { 29, 2, 2, "XL" },
                    { 30, 2, 3, "Cotton" },
                    { 31, 2, 3, "Polyester" },
                    { 32, 2, 3, "Wool" },
                    { 33, 2, 3, "Denim" },
                    { 34, 2, 3, "Silk" },
                    { 35, 2, 3, "Leather" },
                    { 36, 2, 3, "Faux Leather" },
                    { 37, 2, 3, "Linen" },
                    { 38, 2, 3, "Viscose" },
                    { 39, 3, 1, "Beige" },
                    { 40, 3, 1, "White" },
                    { 41, 3, 1, "Brown" },
                    { 42, 3, 1, "Gray" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CategoryId", "FeatureTypeId", "Value" },
                values: new object[,]
                {
                    { 43, 3, 3, "Wood" },
                    { 44, 3, 3, "Metal" },
                    { 45, 3, 3, "Plastic" },
                    { 46, 3, 3, "Glass" },
                    { 47, 3, 3, "Ceramic" }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatureTypes",
                columns: new[] { "FeatureTypeId", "ProductId", "CategoryId", "FeatureId" },
                values: new object[,]
                {
                    { 1, 1, 1, 3 },
                    { 4, 1, 1, 6 },
                    { 5, 1, 1, 10 },
                    { 1, 2, 1, 2 },
                    { 4, 2, 1, 5 },
                    { 5, 2, 1, 9 },
                    { 1, 3, 1, 1 },
                    { 1, 4, 1, 1 },
                    { 1, 5, 1, 1 },
                    { 1, 6, 1, 3 },
                    { 1, 7, 2, 21 },
                    { 2, 7, 2, 27 },
                    { 3, 7, 2, 30 },
                    { 1, 8, 2, 22 },
                    { 3, 8, 2, 33 },
                    { 1, 9, 2, 23 },
                    { 3, 9, 2, 31 },
                    { 1, 10, 3, 42 },
                    { 3, 10, 3, 47 },
                    { 1, 11, 3, 40 },
                    { 3, 11, 3, 44 },
                    { 1, 12, 3, 41 },
                    { 3, 12, 3, 43 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "ProductFeatureTypes",
                keyColumns: new[] { "FeatureTypeId", "ProductId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatureTypes",
                keyColumns: new[] { "CategoryId", "FeatureTypeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
