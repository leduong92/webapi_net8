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
                    { new Guid("22a96002-14f2-4ef3-a820-3f9c1be5f62f"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4741), "Hạt Macca", null, true, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam", "Hạt Macca", "Hạt Macca", "Hạt Macca", "hat-macca", 1, 1, null, null, "hat-macca" },
                    { new Guid("59a89bce-2444-4061-8b3a-5e67b3cd5abd"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4751), "Hạnh nhân", null, true, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột hoặc bột nhão. Trong 28 gram hạnh nhân có chứa hàm lượng chất", "Hạnh nhân", "Hạnh nhân", "Hạnh nhân", "hanh-nhan", 2, 1, null, null, "hanh-nhan" },
                    { new Guid("8cea4866-3bb6-4c8c-a2b6-d5de042c8eb3"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4763), "Hạt óc chó", null, true, "Hạt óc chó", "Hạt óc chó", "Hạt óc chó", "Hạt óc chó", "hat-oc-cho", 5, 1, null, null, "hat-oc-cho" },
                    { new Guid("afa34fd5-d333-41b7-b65b-265fbae5bbd4"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4755), "Mix hạt dinh dưỡng", null, true, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay.", "Mix hạt dinh dưỡng", "Mix hạt dinh dưỡng", "Mix hạt dinh dưỡng", "mix-ha", 3, 1, null, null, "mix-hat" },
                    { new Guid("db90c84a-2f4d-4a14-b819-a2cd0a11780b"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4766), "Hạt điều", null, true, "Hạt điều", "Hạt điều", "Hạt điều", "Hạt điều", "hat-dieu", 6, 1, null, null, "hat-dieu" },
                    { new Guid("de547052-407b-4d21-b85d-8f534ce021b0"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4757), "Granola", null, true, "Granola", "Granola", "Granola", "Granola", "granola", 4, 1, null, null, "granola" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "Discount", "DisplayName", "IsBestSeller", "IsFeatured", "IsNew", "MetaDescription", "MetaKeyword", "MetaTitle", "Name", "OriginalPrice", "Price", "SeoAlias", "Sku", "Status", "UpdatedBy", "UpdatedOn", "UrlCode" },
                values: new object[,]
                {
                    { new Guid("072c4483-d304-419b-a7e5-dac21f5ab0c2"), new Guid("afa34fd5-d333-41b7-b65b-265fbae5bbd4"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(5002), "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ", 10000.0, "MIX HẠT CAO CẤP", true, true, false, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ", "MIX HẠT CAO CẤP", "MIX HẠT CAO CẤP", "MIX HẠT CAO CẤP", 170000.0, 160000.0, "mix-hat-cao-cap", "MIX01", 1, null, null, "mix-hat-cao-cap" },
                    { new Guid("28e1e5fe-8460-4d9d-a3c0-75fc3ee83c24"), new Guid("22a96002-14f2-4ef3-a820-3f9c1be5f62f"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4935), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 5000.0, "Hạt Macca nhân nguyên", false, false, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nhân nguyên", "Hạt Macca nhân nguyên", "Hạt Macca nhân nguyên", 165000.0, 160000.0, "hat-macca-nhan-nguyen", "M02", 1, null, null, "hat-macca-nhan-nguyen" },
                    { new Guid("2a8aa21f-8dfe-4285-b2d0-6b64980a3c2d"), new Guid("59a89bce-2444-4061-8b3a-5e67b3cd5abd"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(5013), "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", 5000.0, "HẠNH NHÂN RANG BƠ", true, true, false, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", "HẠNH NHÂN RANG BƠ", "HẠNH NHÂN RANG BƠ", "HẠNH NHÂN RANG BƠ", 130000.0, 125000.0, "hanh-nhan-rang-bo", "H01", 1, null, null, "hanh-nhan-rang-bo" },
                    { new Guid("7dcee8ad-4239-4ba4-9ec3-6fe34c815d70"), new Guid("22a96002-14f2-4ef3-a820-3f9c1be5f62f"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4925), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 10000.0, "Hạt Macca nhân nguyên", false, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nhân vỡ", "Hạt Macca nhân vỡ", "Hạt Macca nhân vỡ", 145000.0, 135000.0, "hat-macca-nhan-vo", "M01", 1, null, null, "hat-macca" },
                    { new Guid("9a856dac-516b-4c8a-b801-96743fd91c55"), new Guid("22a96002-14f2-4ef3-a820-3f9c1be5f62f"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4990), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 5000.0, "Hạt Macca nứt vỏ", false, false, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nứt vỏ", "Hạt Macca nứt vỏ", "Hạt Macca nứt vỏ (size lớn)", 130000.0, 125000.0, "hat-macca-nut-vo", "M03", 1, null, null, "hat-macca-nut-vo" },
                    { new Guid("a5413d2e-7c1a-43fc-b8b3-cac4603c9485"), new Guid("59a89bce-2444-4061-8b3a-5e67b3cd5abd"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(5017), "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", 5000.0, "HẠNH NHÂN SẤY", false, true, false, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", "HẠNH NHÂN SẤY", "HẠNH NHÂN SẤY", "HẠNH NHÂN SẤY", 135000.0, 130000.0, "hanh-nhan-say", "H02", 1, null, null, "hanh-nhan-say" },
                    { new Guid("bb0a5050-035a-4fee-a307-4b47c5b11080"), new Guid("22a96002-14f2-4ef3-a820-3f9c1be5f62f"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(4997), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 5000.0, "Hạt Macca nứt vỏ", false, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nứt vỏ", "Hạt Macca nứt vỏ", "Hạt Macca nứt vỏ (size nhỏ)", 100000.0, 95000.0, "hat-macca-nut-vo", "M04", 1, null, null, "hat-macca-nut-vo" },
                    { new Guid("d345fd72-4d30-4c39-8797-8df2860f08fc"), new Guid("afa34fd5-d333-41b7-b65b-265fbae5bbd4"), null, new DateTime(2023, 8, 28, 8, 2, 10, 700, DateTimeKind.Utc).AddTicks(5007), "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ", 10000.0, "MIX 6 LOẠI HẠT DINH DƯỠNG", false, false, true, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ", "MIX 6 LOẠI HẠT DINH DƯỠNG", "MIX 6 LOẠI HẠT DINH DƯỠNG", "MIX 6 LOẠI HẠT DINH DƯỠNG", 160000.0, 150000.0, "mix-6-loai-hat-dinh-duong", "MIX02", 1, null, null, "mix-6-loai-hat-dinh-duong" }
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
