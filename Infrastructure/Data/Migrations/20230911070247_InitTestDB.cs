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
                    { new Guid("030bfb43-c2d2-4921-9cdf-6109caa104cb"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(8985), "Hạt điều", null, true, "Hạt điều", "Hạt điều", "Hạt điều", "Hạt điều", "hat-dieu", 6, 1, null, null, "hat-dieu" },
                    { new Guid("0e6b14eb-242d-46ec-b90b-75559c14df26"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(8975), "Hạnh nhân", null, true, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột hoặc bột nhão. Trong 28 gram hạnh nhân có chứa hàm lượng chất", "Hạnh nhân", "Hạnh nhân", "Hạnh nhân", "hanh-nhan", 2, 1, null, null, "hanh-nhan" },
                    { new Guid("2ba2070c-d658-4348-a490-d22c1baaed75"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(8983), "Hạt óc chó", null, true, "Hạt óc chó", "Hạt óc chó", "Hạt óc chó", "Hạt óc chó", "hat-oc-cho", 5, 1, null, null, "hat-oc-cho" },
                    { new Guid("3f17239b-a420-4597-8cbd-0c188e1d4ada"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(8962), "Hạt Macca", null, true, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam", "Hạt Macca", "Hạt Macca", "Hạt Macca", "hat-macca", 1, 1, null, null, "hat-macca" },
                    { new Guid("6c5d6237-94b0-47bb-9f2c-1f4d89e74043"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(8980), "Granola", null, true, "Granola", "Granola", "Granola", "Granola", "granola", 4, 1, null, null, "granola" },
                    { new Guid("7e6e5f6f-9f18-42fb-91ff-418e09261fb4"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(8991), "Bánh kẹp hạt dinh dưỡng", null, true, "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "Bánh kẹp hạt dinh dưỡng", "banh-kep-hat-dinh-duong", 7, 1, null, null, "banh-kep-hat-dinh-duong" },
                    { new Guid("d3a7f832-fb28-4458-97b4-90d0bb61b622"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(8978), "Mix hạt dinh dưỡng", null, true, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay.", "Mix hạt dinh dưỡng", "Mix hạt dinh dưỡng", "Mix hạt dinh dưỡng", "mix-ha", 3, 1, null, null, "mix-hat" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "Discount", "DisplayName", "IsBestSeller", "IsFeatured", "IsNew", "MetaDescription", "MetaKeyword", "MetaTitle", "Name", "OriginalPrice", "Price", "SeoAlias", "Sku", "Status", "UpdatedBy", "UpdatedOn", "UrlCode" },
                values: new object[,]
                {
                    { new Guid("02306207-f983-4bcc-b7ec-70221cee8dc7"), new Guid("d3a7f832-fb28-4458-97b4-90d0bb61b622"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9240), "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 5 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng. ", 10000.0, "MIX hạt cao cấp", true, true, true, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 5 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng.", "MIX hạt cao cấp", "MIX hạt cao cấp", "MIX hạt cao cấp", 170000.0, 160000.0, "mix-hat-cao-cap", "MIX01", 1, null, null, "mix-hat-cao-cap" },
                    { new Guid("18495028-3944-4d00-b2af-9292a6b2dcaa"), new Guid("7e6e5f6f-9f18-42fb-91ff-418e09261fb4"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9287), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 10000.0, "Bánh rong biển kẹp hạt", false, true, false, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Bánh rong biển kẹp hạt", "Bánh rong biển kẹp hạt", "Bánh rong biển kẹp hạt", 170000.0, 160000.0, "banh-rong-bien-kep-hat", "B02", 1, null, null, "banh-rong-bien-kep-hat" },
                    { new Guid("31b72883-ee9d-45b7-9770-51f4d7d2ba2f"), new Guid("3f17239b-a420-4597-8cbd-0c188e1d4ada"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9226), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 10000.0, "Hạt Macca nhân nguyên", false, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nhân nguyên", "Hạt Macca nhân nguyên", "Hạt Macca nhân nguyên", 330000.0, 320000.0, "hat-macca-nhan-nguyen", "M02", 1, null, null, "hat-macca-nhan-nguyen" },
                    { new Guid("3aeb1881-6bc5-4ffa-9a8e-eabf2ca215e1"), new Guid("2ba2070c-d658-4348-a490-d22c1baaed75"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9262), "Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.", 10000.0, "Hạt óc chó vàng", false, true, true, "Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.", "Hạt óc chó vàng", "Hạt óc chó vàng", "Hạt óc chó vàng", 120000.0, 110000.0, "oc-cho-vang", "O02", 1, null, null, "oc-cho-vang" },
                    { new Guid("3cc41fff-3203-441b-acfc-6273def75b42"), new Guid("0e6b14eb-242d-46ec-b90b-75559c14df26"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9255), "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", 5000.0, "Hạnh nhân sấy", false, true, false, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", "Hạnh nhân sấy", "Hạnh nhân sấy", "Hạnh nhân sấy", 135000.0, 130000.0, "hanh-nhan-say", "H02", 1, null, null, "hanh-nhan-say" },
                    { new Guid("42fe6086-ea71-4c84-8197-bc72cb2eaba6"), new Guid("0e6b14eb-242d-46ec-b90b-75559c14df26"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9248), "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", 5000.0, "Hạnh nhân rang bơ", true, true, true, "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...", "Hạnh nhân rang bơ", "Hạnh nhân rang bơ", "Hạnh nhân rang bơ", 130000.0, 125000.0, "hanh-nhan-rang-bo", "H01", 1, null, null, "hanh-nhan-rang-bo" },
                    { new Guid("4e254c2a-9083-49dd-93f0-cc86f78502bc"), new Guid("2ba2070c-d658-4348-a490-d22c1baaed75"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9259), "Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.", 10000.0, "Hạt óc chó đỏ", false, true, true, "Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.", "Hạt óc chó đỏ", "Hạt óc chó đỏ", "Hạt óc chó đỏ", 160000.0, 150000.0, "hanh-nhan-say", "O01", 1, null, null, "oc-cho-do" },
                    { new Guid("4f4055a6-eb23-41c5-b885-1672c207e273"), new Guid("3f17239b-a420-4597-8cbd-0c188e1d4ada"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9230), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 5000.0, "Hạt Macca nứt vỏ (size A)", true, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nứt vỏ (size A)", "Hạt Macca nứt vỏ (size A)", "Hạt Macca nứt vỏ (A)", 130000.0, 125000.0, "hat-macca-nut-vo-size-a", "M03", 1, null, null, "hat-macca-nut-vo-size-a" },
                    { new Guid("5875eb00-05d2-4ee9-98c4-277ba5474d39"), new Guid("6c5d6237-94b0-47bb-9f2c-1f4d89e74043"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9267), "Granola là món ăn quen thuộc của người Mỹ vào buổi sáng, đây là hỗn hợp của nhiều thực phẩm lành lạnh với hàm lượng chất dinh dưỡng cao, nhất là giàu protein. Granola gồm các loại hạt dinh dưỡng, trái cây khô, yến mạch,…. được sấy giòn, giữ được 100% hương vị tươi ngon tự nhiên.", 10000.0, "Granola", true, true, true, "Granola là món ăn quen thuộc của người Mỹ vào buổi sáng, đây là hỗn hợp của nhiều thực phẩm lành lạnh với hàm lượng chất dinh dưỡng cao, nhất là giàu protein. Granola gồm các loại hạt dinh dưỡng, trái cây khô, yến mạch,…. được sấy giòn, giữ được 100% hương vị tươi ngon tự nhiên.", "Granola", "Granola", "Granola", 130000.0, 120000.0, "granola", "G01", 1, null, null, "granola" },
                    { new Guid("6018769a-736d-40b8-9d5d-8a69b42877a9"), new Guid("030bfb43-c2d2-4921-9cdf-6109caa104cb"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9277), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 5000.0, "Hạt điều lon pet", false, true, false, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Hạt điều lon pet", "Hạt điều lon pet", "Hạt điều lon pet", 140000.0, 135000.0, "hat-dieu-lon-pet", "D02", 1, null, null, "hat-dieu-lon-pet" },
                    { new Guid("6fe5001c-0cc9-4873-a826-81676479ec52"), new Guid("3f17239b-a420-4597-8cbd-0c188e1d4ada"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9217), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 20000.0, "Hạt Macca nhân nguyên", false, true, false, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nhân vỡ", "Hạt Macca nhân vỡ", "Hạt Macca nhân vỡ", 290000.0, 270000.0, "hat-macca-nhan-vo", "M01", 1, null, null, "hat-macca" },
                    { new Guid("7b4186af-bf18-494c-a941-8c6b1ecc33a0"), new Guid("030bfb43-c2d2-4921-9cdf-6109caa104cb"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9274), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 10000.0, "Hạt điều sấy", false, true, false, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Hạt điều sấy", "Hạt điều sấy", "Hạt điều sấy", 130000.0, 120000.0, "hat-dieu-sấy", "D03", 1, null, null, "hat-dieu-sấy" },
                    { new Guid("c09653ee-9781-4b47-b1b9-23975c147bc5"), new Guid("3f17239b-a420-4597-8cbd-0c188e1d4ada"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9234), "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", 5000.0, "Hạt Macca nứt vỏ (size B)", false, true, true, "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...\r\n                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...\r\n                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.", "Hạt Macca nứt vỏ (size B)", "Hạt Macca nứt vỏ (size B)", "Hạt Macca nứt vỏ (B)", 100000.0, 95000.0, "hat-macca-nut-vo-size-b", "M04", 1, null, null, "hat-macca-nut-vo-size-b" },
                    { new Guid("cf229b93-7d33-406c-af26-53633d301a19"), new Guid("7e6e5f6f-9f18-42fb-91ff-418e09261fb4"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9281), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 10000.0, "Bánh hạt điều", true, true, true, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Bánh hạt điều", "Bánh hạt điều", "Bánh hạt điều", 90000.0, 80000.0, "banh-hat-dieu", "B01", 1, null, null, "banh-hat-dieu" },
                    { new Guid("deebff1d-3097-46f3-b299-b7025c6688a7"), new Guid("d3a7f832-fb28-4458-97b4-90d0bb61b622"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9245), "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 6 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca, Bí xanh mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng. ", 10000.0, "MIX 6 hạt dinh dưỡng", false, true, false, "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 6 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca, Bí xanh mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng.", "MIX 6 loại hạt dinh dưỡng", "MIX 6 loại hạt dinh dưỡng", "MIX 6 hạt dinh dưỡng", 160000.0, 150000.0, "mix-6-loai-hat-dinh-duong", "MIX02", 1, null, null, "mix-6-loai-hat-dinh-duong" },
                    { new Guid("e0638d29-bc83-4104-8161-e76b4a952145"), new Guid("030bfb43-c2d2-4921-9cdf-6109caa104cb"), null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9270), "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", 10000.0, "Hạt điều xếp hoa", true, true, true, "Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.", "Hạt điều rang muối xếp hoa", "Hạt điều rang muối xếp hoa", "Hạt điều xếp hoa", 130000.0, 120000.0, "hat-dieu-rang-muoi-xep-hoa", "D01", 1, null, null, "hat-dieu-rang-muoi-xep-hoa" }
                });

            migrationBuilder.InsertData(
                table: "product_images",
                columns: new[] { "Id", "Caption", "CreatedBy", "CreatedOn", "FileSize", "IsDefault", "ProductId", "SortOrder", "Status", "UpdatedBy", "UpdatedOn", "Url" },
                values: new object[,]
                {
                    { new Guid("08598ca8-1126-460a-b2af-b0ae3bdf0ec9"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9384), 0L, true, new Guid("4f4055a6-eb23-41c5-b885-1672c207e273"), 1, 1, null, null, "/images/nutvolon_01.jpg" },
                    { new Guid("0a44ed2a-d49e-4704-949c-c2f32947b91e"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9391), 0L, true, new Guid("02306207-f983-4bcc-b7ec-70221cee8dc7"), 1, 1, null, null, "/images/mix_01.jpg" },
                    { new Guid("0d8bd15c-4926-4476-a771-2e8027dc116f"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9360), 0L, false, new Guid("6fe5001c-0cc9-4873-a826-81676479ec52"), 4, 1, null, null, "/images/nhanvo_03.jpg" },
                    { new Guid("0ef3e1b8-bba0-431c-b9db-7213c12d8008"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9495), 0L, false, new Guid("cf229b93-7d33-406c-af26-53633d301a19"), 3, 1, null, null, "/images/banhdieu_03.jpg" },
                    { new Guid("1d14c9bf-93a3-4cc1-ae93-5985eaf81957"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9464), 0L, true, new Guid("3aeb1881-6bc5-4ffa-9a8e-eabf2ca215e1"), 1, 1, null, null, "/images/occhovang_01.jpg" },
                    { new Guid("1e7052a5-dc4d-4039-b484-2a275bb46fa6"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9399), 0L, true, new Guid("3cc41fff-3203-441b-acfc-6273def75b42"), 1, 1, null, null, "/images/hanhnhan_01.jpg" },
                    { new Guid("2439a6bb-0eb3-4d6c-b726-483d37f43b8e"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9477), 0L, false, new Guid("5875eb00-05d2-4ee9-98c4-277ba5474d39"), 3, 1, null, null, "/images/granola_03.jpg" },
                    { new Guid("4440468f-f4e4-4ade-8014-5744a5eff0fc"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9352), 0L, true, new Guid("6fe5001c-0cc9-4873-a826-81676479ec52"), 1, 1, null, null, "/images/nhanvo_01.jpg" },
                    { new Guid("46446d1f-67f9-479b-8bc2-af2bc92f3292"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9418), 0L, true, new Guid("4e254c2a-9083-49dd-93f0-cc86f78502bc"), 1, 1, null, null, "/images/occhodo_01.jpg" },
                    { new Guid("4e5ab9fe-8058-47e3-85cf-79ad07bcfd76"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9474), 0L, false, new Guid("5875eb00-05d2-4ee9-98c4-277ba5474d39"), 2, 1, null, null, "/images/granola_02.jpg" },
                    { new Guid("537e1bb9-2ff6-4bc4-a11a-fdd1481ea252"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9469), 0L, false, new Guid("3aeb1881-6bc5-4ffa-9a8e-eabf2ca215e1"), 2, 1, null, null, "/images/occhovang_02.jpg" },
                    { new Guid("5fd6f001-d42f-4c3c-8379-774459f58b55"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9488), 0L, true, new Guid("cf229b93-7d33-406c-af26-53633d301a19"), 1, 1, null, null, "/images/banhdieu_01.jpg" },
                    { new Guid("61a0fe7f-1ec4-47db-8d6a-c67bbe7c4af4"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9387), 0L, false, new Guid("4f4055a6-eb23-41c5-b885-1672c207e273"), 2, 1, null, null, "/images/nutvolon_02.jpg" },
                    { new Guid("6d4e78c4-4da5-4133-9b9a-f29b79062ac1"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9504), 0L, true, new Guid("18495028-3944-4d00-b2af-9292a6b2dcaa"), 2, 1, null, null, "/images/banhrong_02.jpg" },
                    { new Guid("6dd8fdff-19ed-4da2-ba38-143bd549042c"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9394), 0L, true, new Guid("deebff1d-3097-46f3-b299-b7025c6688a7"), 1, 1, null, null, "/images/mixcc_01.jpg" },
                    { new Guid("6fe6cc1c-4ddd-4684-a554-0d117cc596a1"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9420), 0L, false, new Guid("4e254c2a-9083-49dd-93f0-cc86f78502bc"), 2, 1, null, null, "/images/occhodo_02.jpg" },
                    { new Guid("73e60cad-ba66-4d41-a7b0-521cf9bf09f0"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9497), 0L, false, new Guid("cf229b93-7d33-406c-af26-53633d301a19"), 3, 1, null, null, "/images/banhdieu_03.jpg" },
                    { new Guid("78dde65a-3184-4aaa-8305-ee630c0a5fb2"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9411), 0L, false, new Guid("42fe6086-ea71-4c84-8197-bc72cb2eaba6"), 2, 1, null, null, "/images/hanhnhan_02.jpg" },
                    { new Guid("8a804d4c-539a-45f1-bb4d-660b0dc57c09"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9370), 0L, false, new Guid("31b72883-ee9d-45b7-9770-51f4d7d2ba2f"), 2, 1, null, null, "/images/nhannguyen_02.jpg" },
                    { new Guid("97ebb7e0-bd66-457b-a21c-e4207f0365ce"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9382), 0L, false, new Guid("c09653ee-9781-4b47-b1b9-23975c147bc5"), 2, 1, null, null, "/images/nutvo_02.jpg" },
                    { new Guid("9b71006d-73fa-4b66-84c1-8d4d8e365e89"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9486), 0L, true, new Guid("e0638d29-bc83-4104-8161-e76b4a952145"), 1, 1, null, null, "/images/dieuxephoa_01.jpg" },
                    { new Guid("9bc06aaf-b62f-416c-8848-84780a7bc627"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9408), 0L, true, new Guid("42fe6086-ea71-4c84-8197-bc72cb2eaba6"), 1, 1, null, null, "/images/hanhnhan_01.jpg" },
                    { new Guid("a063a6eb-826d-44ec-85c2-c67f569f758b"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9396), 0L, false, new Guid("deebff1d-3097-46f3-b299-b7025c6688a7"), 2, 1, null, null, "/images/mix_02.jpg" },
                    { new Guid("a2acea8f-6f37-4dd3-87f5-7484a1acd14e"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9362), 0L, false, new Guid("6fe5001c-0cc9-4873-a826-81676479ec52"), 4, 1, null, null, "/images/nhanvo_04.jpg" },
                    { new Guid("b88cef82-538d-4b55-8e16-8011e79cfd36"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9415), 0L, false, new Guid("42fe6086-ea71-4c84-8197-bc72cb2eaba6"), 3, 1, null, null, "/images/hanhnhan_03.jpg" },
                    { new Guid("c260f5fe-ae95-4d66-ada4-7c3d0063bcf0"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9481), 0L, true, new Guid("6018769a-736d-40b8-9d5d-8a69b42877a9"), 1, 1, null, null, "/images/dieupet_01.jpg" },
                    { new Guid("c3a5e39b-b268-4591-bc81-7874935ef8ef"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9483), 0L, true, new Guid("7b4186af-bf18-494c-a941-8c6b1ecc33a0"), 1, 1, null, null, "/images/dieusay_01.jpg" },
                    { new Guid("c4b9964d-79f7-4336-adf8-4743fac2ee56"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9357), 0L, false, new Guid("6fe5001c-0cc9-4873-a826-81676479ec52"), 2, 1, null, null, "/images/nhanvo_02.jpg" },
                    { new Guid("c749cd4e-9c35-44d6-b6b6-804ad7919713"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9403), 0L, false, new Guid("3cc41fff-3203-441b-acfc-6273def75b42"), 2, 1, null, null, "/images/hanhnhan_02.jpg" },
                    { new Guid("cbbc9644-113c-4854-bbed-df0b886f0226"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9500), 0L, false, new Guid("18495028-3944-4d00-b2af-9292a6b2dcaa"), 1, 1, null, null, "/images/banhrong_01.jpg" },
                    { new Guid("cd07005a-f2c7-4935-a575-cd4e5f0a5979"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9493), 0L, false, new Guid("cf229b93-7d33-406c-af26-53633d301a19"), 2, 1, null, null, "/images/banhdieu_02.jpg" },
                    { new Guid("e057e570-813a-4569-aee8-6b7d37090740"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9367), 0L, true, new Guid("31b72883-ee9d-45b7-9770-51f4d7d2ba2f"), 1, 1, null, null, "/images/nhannguyen_01.jpg" },
                    { new Guid("f3a39995-f182-4b4a-a10e-4dbd5197d58a"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9375), 0L, false, new Guid("31b72883-ee9d-45b7-9770-51f4d7d2ba2f"), 4, 1, null, null, "/images/nhannguyen_04.jpg" },
                    { new Guid("f7fbe196-8bdf-48aa-8fe4-1076b87f8d1f"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9379), 0L, true, new Guid("c09653ee-9781-4b47-b1b9-23975c147bc5"), 1, 1, null, null, "/images/nutvo_01.jpg" },
                    { new Guid("f9d89a63-9a03-4a06-8372-ac0ce649aaa0"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9406), 0L, false, new Guid("3cc41fff-3203-441b-acfc-6273def75b42"), 3, 1, null, null, "/images/hanhnhan_03.jpg" },
                    { new Guid("fd7f3a72-612b-49ad-be1f-6e44ee69064a"), "Main Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9472), 0L, true, new Guid("5875eb00-05d2-4ee9-98c4-277ba5474d39"), 1, 1, null, null, "/images/granola_01.jpg" },
                    { new Guid("fee79c1e-2e01-4bc4-9632-af2199e4550c"), "Thumb Image", null, new DateTime(2023, 9, 11, 7, 2, 47, 849, DateTimeKind.Utc).AddTicks(9372), 0L, false, new Guid("31b72883-ee9d-45b7-9770-51f4d7d2ba2f"), 3, 1, null, null, "/images/nhannguyen_03.jpg" }
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
