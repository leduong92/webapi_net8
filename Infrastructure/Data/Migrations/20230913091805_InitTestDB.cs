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
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BuyerName = table.Column<string>(type: "text", nullable: true),
                    BuyerEmail = table.Column<string>(type: "text", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BuyerPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    BuyerAddress = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
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
                name: "order_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    PictureUrl = table.Column<string>(type: "text", nullable: true),
                    Sku = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_order_items_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
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
                    { new Guid("22b875fb-62de-4b86-acdd-52ee130b1bb8"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2742), "Mix hạt dinh dưỡng", null, true, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay.", "Mix hạt dinh dưỡng", "Mix hạt dinh dưỡng", "Mix hạt dinh dưỡng", "mix-ha", 3, 1, null, null, "mix-hat" },
                    { new Guid("3b8472f6-2d18-4770-a449-d2f3a4ad09ef"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2744), "Granola", null, true, "Granola", "Granola", "Granola", "Granola", "granola", 4, 1, null, null, "granola" },
                    { new Guid("58ee6eda-23e8-436e-bc8d-c62f66b47e2d"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2750), "Hạt điều", null, true, "Hạt điều", "Hạt điều", "Hạt điều", "Hạt điều", "hat-dieu", 6, 1, null, null, "hat-dieu" },
                    { new Guid("71f8cfd2-f0ab-49ae-9059-b0df1109c016"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2747), "Hạt óc chó", null, true, "Hạt óc chó", "Hạt óc chó", "Hạt óc chó", "Hạt óc chó", "hat-oc-cho", 5, 1, null, null, "hat-oc-cho" },
                    { new Guid("76de0415-456b-44fa-9945-db3d3b7f1b87"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2739), "Hạnh nhân", null, true, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột hoặc bột nhão. Trong 28 gram hạnh nhân có chứa hàm lượng chất", "Hạnh nhân", "Hạnh nhân", "Hạnh nhân", "hanh-nhan", 2, 1, null, null, "hanh-nhan" },
                    { new Guid("9084363c-2404-45c5-a611-673ba2846a6c"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2727), "Hạt Macca", null, true, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam", "Hạt Macca", "Hạt Macca", "Hạt Macca", "hat-macca", 1, 1, null, null, "hat-macca" },
                    { new Guid("ef9ef129-b647-47b1-82c8-2015d57eb90a"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2752), "Bánh kẹp hạt dinh dưỡng", null, true, "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "banh-kep-hat-dinh-duong", 7, 1, null, null, "banh-kep-hat-dinh-duong" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "Discount", "DisplayName", "IsBestSeller", "IsFeatured", "IsNew", "MetaDescription", "MetaKeyword", "MetaTitle", "Name", "OriginalPrice", "Price", "SeoAlias", "Sku", "Status", "UpdatedBy", "UpdatedOn", "UrlCode" },
                values: new object[,]
                {
                    { new Guid("0315ea40-5ab4-4e46-aabe-a8257ea79958"), new Guid("22b875fb-62de-4b86-acdd-52ee130b1bb8"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2981), "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 5 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng. ", 10000.0, "MIX hạt cao cấp", true, true, true, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 5 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng.", "MIX hạt cao cấp", "MIX hạt cao cấp", "MIX hạt cao cấp", 170000.0, 160000.0, "mix-hat-cao-cap", "MIX01", 1, null, null, "mix-hat-cao-cap" },
                    { new Guid("131ccfe0-4c13-4816-9053-d1f63b0fa7b8"), new Guid("58ee6eda-23e8-436e-bc8d-c62f66b47e2d"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3008), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 10000.0, "Hạt điều xếp hoa", true, true, true, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Hạt điều rang muối xếp hoa", "Hạt điều rang muối xếp hoa", "Hạt điều xếp hoa", 130000.0, 120000.0, "hat-dieu-rang-muoi-xep-hoa", "D01", 1, null, null, "hat-dieu-rang-muoi-xep-hoa" },
                    { new Guid("352660e6-3512-4001-899e-219fe0e7a68b"), new Guid("3b8472f6-2d18-4770-a449-d2f3a4ad09ef"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3004), "Granola là món ăn quen thuộc của người Mỹ vào buổi sáng, đây là hỗn hợp của nhiều thực phẩm lành lạnh với hàm lượng chất dinh dưỡng cao, nhất là giàu protein. Granola gồm các loại hạt dinh dưỡng, trái cây khô, yến mạch,…. được sấy giòn, giữ được 100% hương vị tươi ngon tự nhiên.", 10000.0, "Granola", true, true, true, "Granola là món ăn quen thuộc của người Mỹ vào buổi sáng, đây là hỗn hợp của nhiều thực phẩm lành lạnh với hàm lượng chất dinh dưỡng cao, nhất là giàu protein. Granola gồm các loại hạt dinh dưỡng, trái cây khô, yến mạch,…. được sấy giòn, giữ được 100% hương vị tươi ngon tự nhiên.", "Granola", "Granola", "Granola", 130000.0, 120000.0, "granola", "G01", 1, null, null, "granola" },
                    { new Guid("37ad7bb3-21a3-4afd-9fd0-fc8b6a6efbdb"), new Guid("9084363c-2404-45c5-a611-673ba2846a6c"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2955), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 20000.0, "Hạt Macca nhân nguyên", false, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nhân vỡ", "Hạt Macca nhân vỡ", "Hạt Macca nhân vỡ", 290000.0, 270000.0, "hat-macca-nhan-vo", "M01", 1, null, null, "hat-macca" },
                    { new Guid("517f347e-4316-43fe-a0d2-8ae5940b2bcc"), new Guid("ef9ef129-b647-47b1-82c8-2015d57eb90a"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3020), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 10000.0, "Bánh hạt điều", true, true, true, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Bánh hạt điều", "Bánh hạt điều", "Bánh hạt điều", 90000.0, 80000.0, "banh-hat-dieu", "B01", 1, null, null, "banh-hat-dieu" },
                    { new Guid("7bf93173-9db6-46dc-bee8-47dc6ab9f30c"), new Guid("ef9ef129-b647-47b1-82c8-2015d57eb90a"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3070), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 10000.0, "Bánh rong biển kẹp hạt", false, true, false, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Bánh rong biển kẹp hạt", "Bánh rong biển kẹp hạt", "Bánh rong biển kẹp hạt", 170000.0, 160000.0, "banh-rong-bien-kep-hat", "B02", 1, null, null, "banh-rong-bien-kep-hat" },
                    { new Guid("85fc6fac-243e-40a3-ae8f-90c271cbd541"), new Guid("76de0415-456b-44fa-9945-db3d3b7f1b87"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2992), "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", 5000.0, "Hạnh nhân sấy", false, true, false, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", "Hạnh nhân sấy", "Hạnh nhân sấy", "Hạnh nhân sấy", 135000.0, 130000.0, "hanh-nhan-say", "H02", 1, null, null, "hanh-nhan-say" },
                    { new Guid("9395fc8c-1e4b-43fc-80a5-a6dab7025246"), new Guid("9084363c-2404-45c5-a611-673ba2846a6c"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2978), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 5000.0, "Hạt Macca nứt vỏ (B)", false, true, true, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nứt vỏ (size B)", "Hạt Macca nứt vỏ (size B)", "Hạt Macca nứt vỏ (B)", 100000.0, 95000.0, "hat-macca-nut-vo-size-b", "M04", 1, null, null, "hat-macca-nut-vo-size-b" },
                    { new Guid("a1cd9775-a270-41b3-bb53-1d5152e2d329"), new Guid("76de0415-456b-44fa-9945-db3d3b7f1b87"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2989), "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", 5000.0, "Hạnh nhân rang bơ", true, true, true, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", "Hạnh nhân rang bơ", "Hạnh nhân rang bơ", "Hạnh nhân rang bơ", 130000.0, 125000.0, "hanh-nhan-rang-bo", "H01", 1, null, null, "hanh-nhan-rang-bo" },
                    { new Guid("ad48622a-f7cb-4244-8497-bb213ae72dc6"), new Guid("71f8cfd2-f0ab-49ae-9059-b0df1109c016"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2995), "Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.", 10000.0, "Hạt óc chó đỏ", false, true, true, "Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.", "Hạt óc chó đỏ", "Hạt óc chó đỏ", "Hạt óc chó đỏ", 160000.0, 150000.0, "hanh-nhan-say", "O01", 1, null, null, "oc-cho-do" },
                    { new Guid("b5752e06-efd5-4f8a-b3f3-a9095d66b5fa"), new Guid("9084363c-2404-45c5-a611-673ba2846a6c"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2970), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 10000.0, "Hạt Macca nhân nguyên", false, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nhân nguyên", "Hạt Macca nhân nguyên", "Hạt Macca nhân nguyên", 330000.0, 320000.0, "hat-macca-nhan-nguyen", "M02", 1, null, null, "hat-macca-nhan-nguyen" },
                    { new Guid("bedb9399-6d7e-430c-8219-c62189479dc7"), new Guid("22b875fb-62de-4b86-acdd-52ee130b1bb8"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2985), "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 6 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca, Bí xanh mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng. ", 10000.0, "MIX 6 hạt dinh dưỡng", false, true, false, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 6 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca, Bí xanh mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng.", "MIX 6 loại hạt dinh dưỡng", "MIX 6 loại hạt dinh dưỡng", "MIX 6 hạt dinh dưỡng", 160000.0, 150000.0, "mix-6-loai-hat-dinh-duong", "MIX02", 1, null, null, "mix-6-loai-hat-dinh-duong" },
                    { new Guid("ca430471-102c-4bdb-8774-8556b89098b5"), new Guid("9084363c-2404-45c5-a611-673ba2846a6c"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(2974), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 5000.0, "Hạt Macca nứt vỏ (A)", true, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nứt vỏ (size A)", "Hạt Macca nứt vỏ (size A)", "Hạt Macca nứt vỏ (A)", 130000.0, 125000.0, "hat-macca-nut-vo-size-a", "M03", 1, null, null, "hat-macca-nut-vo-size-a" },
                    { new Guid("e8e263bc-a93f-4a16-bf87-ccac16662477"), new Guid("71f8cfd2-f0ab-49ae-9059-b0df1109c016"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3001), "Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.", 10000.0, "Hạt óc chó vàng", false, true, true, "Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.", "Hạt óc chó vàng", "Hạt óc chó vàng", "Hạt óc chó vàng", 120000.0, 110000.0, "oc-cho-vang", "O02", 1, null, null, "oc-cho-vang" },
                    { new Guid("ea470a97-183a-4645-8e95-65e6c682c592"), new Guid("58ee6eda-23e8-436e-bc8d-c62f66b47e2d"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3012), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 10000.0, "Hạt điều sấy", false, true, false, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Hạt điều sấy", "Hạt điều sấy", "Hạt điều sấy", 130000.0, 120000.0, "hat-dieu-sấy", "D03", 1, null, null, "hat-dieu-sấy" },
                    { new Guid("fde12524-990e-4758-b2e5-9a512d067d86"), new Guid("58ee6eda-23e8-436e-bc8d-c62f66b47e2d"), null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3016), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 5000.0, "Hạt điều lon pet", false, true, false, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Hạt điều lon pet", "Hạt điều lon pet", "Hạt điều lon pet", 140000.0, 135000.0, "hat-dieu-lon-pet", "D02", 1, null, null, "hat-dieu-lon-pet" }
                });

            migrationBuilder.InsertData(
                table: "product_images",
                columns: new[] { "Id", "Caption", "CreatedBy", "CreatedOn", "FileSize", "IsDefault", "ProductId", "SortOrder", "Status", "UpdatedBy", "UpdatedOn", "Url" },
                values: new object[,]
                {
                    { new Guid("02529555-5e67-44f8-a7b4-a431fe50eb72"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3143), 0L, true, new Guid("bedb9399-6d7e-430c-8219-c62189479dc7"), 1, 1, null, null, "/images/mixcc_01.jpg" },
                    { new Guid("086542b7-ed2e-4bf9-b9ab-d3b55a27d122"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3211), 0L, true, new Guid("7bf93173-9db6-46dc-bee8-47dc6ab9f30c"), 2, 1, null, null, "/images/banhrong_02.jpg" },
                    { new Guid("0a6b3ffa-0632-435b-aa89-72516c122648"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3186), 0L, true, new Guid("fde12524-990e-4758-b2e5-9a512d067d86"), 1, 1, null, null, "/images/dieupet_01.jpg" },
                    { new Guid("11566685-5b83-4036-863d-8af450c80739"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3151), 0L, false, new Guid("85fc6fac-243e-40a3-ae8f-90c271cbd541"), 2, 1, null, null, "/images/hanhnhan_02.jpg" },
                    { new Guid("159112ba-592e-47f6-a8fe-f41e5ddc7c17"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3157), 0L, true, new Guid("a1cd9775-a270-41b3-bb53-1d5152e2d329"), 1, 1, null, null, "/images/hanhnhan_01.jpg" },
                    { new Guid("2c1c643f-82bd-4394-af5e-7f101b4ba7d9"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3208), 0L, false, new Guid("7bf93173-9db6-46dc-bee8-47dc6ab9f30c"), 1, 1, null, null, "/images/banhrong_01.jpg" },
                    { new Guid("376494d1-6b66-4992-8df9-ca9483443079"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3169), 0L, false, new Guid("ad48622a-f7cb-4244-8497-bb213ae72dc6"), 2, 1, null, null, "/images/occhodo_02.jpg" },
                    { new Guid("3c819277-8de3-4266-a27f-d88887585f34"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3109), 0L, false, new Guid("37ad7bb3-21a3-4afd-9fd0-fc8b6a6efbdb"), 4, 1, null, null, "/images/nhanvo_03.jpg" },
                    { new Guid("4fac59bd-4c69-46ac-9bcb-48785383cc22"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3145), 0L, false, new Guid("bedb9399-6d7e-430c-8219-c62189479dc7"), 2, 1, null, null, "/images/mix_02.jpg" },
                    { new Guid("754e8301-9bdd-4084-931e-836f6870df5b"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3172), 0L, true, new Guid("e8e263bc-a93f-4a16-bf87-ccac16662477"), 1, 1, null, null, "/images/occhovang_01.jpg" },
                    { new Guid("774e652a-6b2c-4f22-95bc-69067ccb78ce"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3191), 0L, true, new Guid("ea470a97-183a-4645-8e95-65e6c682c592"), 1, 1, null, null, "/images/dieusay_01.jpg" },
                    { new Guid("78fcf70f-01ab-41bb-8847-caa3b7efd7b6"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3196), 0L, true, new Guid("517f347e-4316-43fe-a0d2-8ae5940b2bcc"), 1, 1, null, null, "/images/banhdieu_01.jpg" },
                    { new Guid("7a276d78-4a39-44e9-b46a-be3c7b73d7cc"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3131), 0L, false, new Guid("9395fc8c-1e4b-43fc-80a5-a6dab7025246"), 2, 1, null, null, "/images/nutvo_02.jpg" },
                    { new Guid("869addcd-4db7-435f-a28f-2c192085073a"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3205), 0L, false, new Guid("517f347e-4316-43fe-a0d2-8ae5940b2bcc"), 3, 1, null, null, "/images/banhdieu_03.jpg" },
                    { new Guid("89133793-0223-4362-8156-2d18b3049a0a"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3111), 0L, false, new Guid("37ad7bb3-21a3-4afd-9fd0-fc8b6a6efbdb"), 4, 1, null, null, "/images/nhanvo_04.jpg" },
                    { new Guid("8964ca4a-d5c2-46ad-aad3-5cf05048ea88"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3160), 0L, false, new Guid("a1cd9775-a270-41b3-bb53-1d5152e2d329"), 2, 1, null, null, "/images/hanhnhan_02.jpg" },
                    { new Guid("8cc35af1-b4de-4784-ac59-624c52d92736"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3155), 0L, false, new Guid("85fc6fac-243e-40a3-ae8f-90c271cbd541"), 3, 1, null, null, "/images/hanhnhan_03.jpg" },
                    { new Guid("8f9ec34b-e7e4-46e4-934b-3528471cf04a"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3174), 0L, false, new Guid("e8e263bc-a93f-4a16-bf87-ccac16662477"), 2, 1, null, null, "/images/occhovang_02.jpg" },
                    { new Guid("a033ed23-2392-430c-8e71-f95ee410a10c"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3124), 0L, false, new Guid("b5752e06-efd5-4f8a-b3f3-a9095d66b5fa"), 4, 1, null, null, "/images/nhannguyen_04.jpg" },
                    { new Guid("a6264597-5390-450e-a7e3-d7b61aed3ab5"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3184), 0L, false, new Guid("352660e6-3512-4001-899e-219fe0e7a68b"), 3, 1, null, null, "/images/granola_03.jpg" },
                    { new Guid("a71a49fb-e6c9-4572-993d-b1d906cea970"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3203), 0L, false, new Guid("517f347e-4316-43fe-a0d2-8ae5940b2bcc"), 3, 1, null, null, "/images/banhdieu_03.jpg" },
                    { new Guid("a7b4b55f-0258-4e7e-8e26-21cf28cb5537"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3114), 0L, true, new Guid("b5752e06-efd5-4f8a-b3f3-a9095d66b5fa"), 1, 1, null, null, "/images/nhannguyen_01.jpg" },
                    { new Guid("ab650626-6f0e-407d-b3ab-c08a4447434d"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3181), 0L, false, new Guid("352660e6-3512-4001-899e-219fe0e7a68b"), 2, 1, null, null, "/images/granola_02.jpg" },
                    { new Guid("ad73c45a-a30a-4a6e-b16c-f6808e740418"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3167), 0L, true, new Guid("ad48622a-f7cb-4244-8497-bb213ae72dc6"), 1, 1, null, null, "/images/occhodo_01.jpg" },
                    { new Guid("b1dc696f-2e62-4029-b57f-68e358e020f7"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3121), 0L, false, new Guid("b5752e06-efd5-4f8a-b3f3-a9095d66b5fa"), 3, 1, null, null, "/images/nhannguyen_03.jpg" },
                    { new Guid("b5178767-41df-4228-97b5-49c92d92d8ec"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3193), 0L, true, new Guid("131ccfe0-4c13-4816-9053-d1f63b0fa7b8"), 1, 1, null, null, "/images/dieuxephoa_01.jpg" },
                    { new Guid("b9b342a8-ab93-492e-b399-a227c704127f"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3119), 0L, false, new Guid("b5752e06-efd5-4f8a-b3f3-a9095d66b5fa"), 2, 1, null, null, "/images/nhannguyen_02.jpg" },
                    { new Guid("baa1e58d-e2c9-473c-a04f-2afa1111b26f"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3134), 0L, true, new Guid("ca430471-102c-4bdb-8774-8556b89098b5"), 1, 1, null, null, "/images/nutvolon_01.jpg" },
                    { new Guid("bd3f3632-11f9-4060-a318-25f23602e121"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3179), 0L, true, new Guid("352660e6-3512-4001-899e-219fe0e7a68b"), 1, 1, null, null, "/images/granola_01.jpg" },
                    { new Guid("c5fb9d18-65ba-4c5b-b0db-5a23e3c29305"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3163), 0L, false, new Guid("a1cd9775-a270-41b3-bb53-1d5152e2d329"), 3, 1, null, null, "/images/hanhnhan_03.jpg" },
                    { new Guid("d6ba7e01-3dbb-4dbb-9bdf-fd3e8e9c0aaa"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3106), 0L, false, new Guid("37ad7bb3-21a3-4afd-9fd0-fc8b6a6efbdb"), 2, 1, null, null, "/images/nhanvo_02.jpg" },
                    { new Guid("e14666dd-be03-4da4-b834-6aa983bb9572"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3198), 0L, false, new Guid("517f347e-4316-43fe-a0d2-8ae5940b2bcc"), 2, 1, null, null, "/images/banhdieu_02.jpg" },
                    { new Guid("e2c6af42-6309-46ac-aabd-711d69bbca8b"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3139), 0L, true, new Guid("0315ea40-5ab4-4e46-aabe-a8257ea79958"), 1, 1, null, null, "/images/mix_01.jpg" },
                    { new Guid("e4f0aac5-6202-49b4-82f5-e71f3d28cef2"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3148), 0L, true, new Guid("85fc6fac-243e-40a3-ae8f-90c271cbd541"), 1, 1, null, null, "/images/hanhnhan_01.jpg" },
                    { new Guid("e6e3a368-4579-4ad6-93ff-e75428224341"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3098), 0L, true, new Guid("37ad7bb3-21a3-4afd-9fd0-fc8b6a6efbdb"), 1, 1, null, null, "/images/nhanvo_01.jpg" },
                    { new Guid("eb40e0b1-3d9b-418b-980f-bf33f6dd3793"), "Thumb Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3136), 0L, false, new Guid("ca430471-102c-4bdb-8774-8556b89098b5"), 2, 1, null, null, "/images/nutvolon_02.jpg" },
                    { new Guid("eb4aa156-dae6-4368-8d46-f7cef6583722"), "Main Image", null, new DateTime(2023, 9, 13, 9, 18, 5, 758, DateTimeKind.Utc).AddTicks(3127), 0L, true, new Guid("9395fc8c-1e4b-43fc-80a5-a6dab7025246"), 1, 1, null, null, "/images/nutvo_01.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_SortOrder",
                table: "categories",
                column: "SortOrder");

            migrationBuilder.CreateIndex(
                name: "IX_order_items_Id",
                table: "order_items",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_order_items_OrderId",
                table: "order_items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Id",
                table: "orders",
                column: "Id");

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
                name: "order_items");

            migrationBuilder.DropTable(
                name: "product_images");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropTable(
                name: "slides");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
