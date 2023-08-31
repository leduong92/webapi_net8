using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitTestDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    DisplayName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    UrlCode = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    IsShowOnHome = table.Column<bool>(type: "boolean", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    SeoAlias = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    MetaTitle = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true),
                    MetaKeyword = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true),
                    MetaDescription = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true),
                    ImageUrl = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "slides",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Url = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Image = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_slides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Sku = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    UrlCode = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true),
                    SeoAlias = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    MetaTitle = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    MetaKeyword = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    MetaDescription = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    OriginalPrice = table.Column<double>(type: "double precision", nullable: false),
                    Discount = table.Column<double>(type: "double precision", nullable: false),
                    IsFeatured = table.Column<bool>(type: "boolean", nullable: true),
                    IsNew = table.Column<bool>(type: "boolean", nullable: true),
                    IsBestSeller = table.Column<bool>(type: "boolean", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_product_images_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sizes_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DisplayName", "ImageUrl", "IsShowOnHome", "MetaDescription", "MetaKeyword", "MetaTitle", "Name", "SeoAlias", "SortOrder", "Status", "UpdatedBy", "UpdatedOn", "UrlCode" },
                values: new object[,]
                {
                    { new Guid("05aa2a1f-1d0b-4d9e-aef3-0f10d58e0243"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(860), "Hạt óc chó", null, true, "Hạt óc chó", "Hạt óc chó", "Hạt óc chó", "Hạt óc chó", "hat-oc-cho", 5, 1, null, null, "hat-oc-cho" },
                    { new Guid("2162e297-66f7-4881-9207-6ff6642be343"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(854), "Granola", null, true, "Granola", "Granola", "Granola", "Granola", "granola", 4, 1, null, null, "granola" },
                    { new Guid("54b21e27-6aaf-415c-97a9-905436f61d67"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(864), "Hạt điều", null, true, "Hạt điều", "Hạt điều", "Hạt điều", "Hạt điều", "hat-dieu", 6, 1, null, null, "hat-dieu" },
                    { new Guid("be943ba9-2286-4130-a1a7-965bd4c1ea75"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(852), "Mix hạt dinh dưỡng", null, true, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay.", "Mix hạt dinh dưỡng", "Mix hạt dinh dưỡng", "Mix hạt dinh dưỡng", "mix-ha", 3, 1, null, null, "mix-hat" },
                    { new Guid("d1cb73c7-b2a4-4960-b8ba-dc1f4332f581"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(751), "Hạnh nhân", null, true, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột hoặc bột nhão. Trong 28 gram hạnh nhân có chứa hàm lượng chất", "Hạnh nhân", "Hạnh nhân", "Hạnh nhân", "hanh-nhan", 2, 1, null, null, "hanh-nhan" },
                    { new Guid("d2bee319-1f72-480e-921f-81720853a26b"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(742), "Hạt Macca", null, true, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam", "Hạt Macca", "Hạt Macca", "Hạt Macca", "hat-macca", 1, 1, null, null, "hat-macca" },
                    { new Guid("fdedc8d3-d614-4088-9a24-0cdc246e0d09"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(866), "Bánh kẹp hạt dinh dưỡng", null, true, "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "banh-kep-hat-dinh-duong", 7, 1, null, null, "banh-kep-hat-dinh-duong" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "Discount", "DisplayName", "IsBestSeller", "IsFeatured", "IsNew", "MetaDescription", "MetaKeyword", "MetaTitle", "Name", "OriginalPrice", "Price", "SeoAlias", "Sku", "Status", "UpdatedBy", "UpdatedOn", "UrlCode" },
                values: new object[,]
                {
                    { new Guid("073d2f0a-b5d7-431b-9e9d-9947994d8204"), new Guid("05aa2a1f-1d0b-4d9e-aef3-0f10d58e0243"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(1072), "Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.", 5000.0, "Hạt óc chó vàng", false, true, false, "Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.", "Hạt óc chó vàng", "Hạt óc chó vàng", "Hạt óc chó vàng", 135000.0, 130000.0, "oc-cho-vang", "O02", 1, null, null, "oc-cho-vang" },
                    { new Guid("131a4be0-5fda-4be9-bcb8-6571029d4f1f"), new Guid("d1cb73c7-b2a4-4960-b8ba-dc1f4332f581"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(1062), "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", 5000.0, "Hạnh nhân sấy", false, true, false, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", "Hạnh nhân sấy", "Hạnh nhân sấy", "Hạnh nhân sấy", 135000.0, 130000.0, "hanh-nhan-say", "H02", 1, null, null, "hanh-nhan-say" },
                    { new Guid("2188e97d-2c73-4c3a-8cd6-e905ac60db63"), new Guid("d1cb73c7-b2a4-4960-b8ba-dc1f4332f581"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(1059), "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", 5000.0, "Hạnh nhân rang bơ", true, true, false, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", "Hạnh nhân rang bơ", "Hạnh nhân rang bơ", "Hạnh nhân rang bơ", 130000.0, 125000.0, "hanh-nhan-rang-bo", "H01", 1, null, null, "hanh-nhan-rang-bo" },
                    { new Guid("23e48a20-d7db-41ad-bc9c-a85a551980d8"), new Guid("05aa2a1f-1d0b-4d9e-aef3-0f10d58e0243"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(1066), "Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.", 5000.0, "Hạt óc chó đỏ", false, true, true, "Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.", "Hạt óc chó đỏ", "Hạt óc chó đỏ", "Hạt óc chó đỏ", 135000.0, 130000.0, "hanh-nhan-say", "O01", 1, null, null, "oc-cho-do" },
                    { new Guid("32f6ce6f-193c-4049-85f1-24d52ce316bf"), new Guid("d2bee319-1f72-480e-921f-81720853a26b"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(1035), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 10000.0, "Hạt Macca nhân nguyên", false, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nhân vỡ", "Hạt Macca nhân vỡ", "Hạt Macca nhân vỡ", 145000.0, 135000.0, "hat-macca-nhan-vo", "M01", 1, null, null, "hat-macca" },
                    { new Guid("68dc68ea-c786-4500-9af4-5c6a2b77e278"), new Guid("d2bee319-1f72-480e-921f-81720853a26b"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(1043), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 5000.0, "Hạt Macca nhân nguyên", false, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nhân nguyên", "Hạt Macca nhân nguyên", "Hạt Macca nhân nguyên", 165000.0, 160000.0, "hat-macca-nhan-nguyen", "M02", 1, null, null, "hat-macca-nhan-nguyen" },
                    { new Guid("e1c7dc2f-8b72-4b37-80a1-c139cae694a1"), new Guid("be943ba9-2286-4130-a1a7-965bd4c1ea75"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(1047), "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ", 10000.0, "MIX hạt cao cấp", true, true, false, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ", "MIX hạt cao cấp", "MIX hạt cao cấp", "MIX hạt cao cấp", 170000.0, 160000.0, "mix-hat-cao-cap", "MIX01", 1, null, null, "mix-hat-cao-cap" },
                    { new Guid("fe538332-bee6-45ce-b691-f81fb118c0e9"), new Guid("be943ba9-2286-4130-a1a7-965bd4c1ea75"), null, new DateTime(2023, 8, 31, 3, 55, 59, 53, DateTimeKind.Utc).AddTicks(1055), "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ", 10000.0, "MIX 6 loại hạt dinh dưỡng", false, true, true, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ", "MIX 6 loại hạt dinh dưỡng", "MIX 6 loại hạt dinh dưỡng", "MIX 6 loại hạt dinh dưỡng", 160000.0, 150000.0, "mix-6-loai-hat-dinh-duong", "MIX02", 1, null, null, "mix-6-loai-hat-dinh-duong" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_SortOrder",
                table: "categories",
                column: "SortOrder");

            migrationBuilder.CreateIndex(
                name: "IX_product_images_Id",
                table: "product_images",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_product_images_ProductId",
                table: "product_images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_Id_Name_Sku_UrlCode",
                table: "products",
                columns: new[] { "Id", "Name", "Sku", "UrlCode" });

            migrationBuilder.CreateIndex(
                name: "IX_sizes_Id",
                table: "sizes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_sizes_ProductId",
                table: "sizes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_slides_Id",
                table: "slides",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_slides_SortOrder",
                table: "slides",
                column: "SortOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product_images");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropTable(
                name: "slides");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
