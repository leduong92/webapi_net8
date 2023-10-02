
using Core.Entities;
using Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var maccarId = Guid.NewGuid();
            var mixhatId = Guid.NewGuid();
            var hanhnhanId = Guid.NewGuid();
            var banhkepId = Guid.NewGuid();
            var hatdieuId = Guid.NewGuid();
            var granolaId = Guid.NewGuid();
            var occhoId = Guid.NewGuid();
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = maccarId,
                    Name = "Hạt Macca",
                    DisplayName = "Hạt Macca",
                    UrlCode = "hat-macca",
                    IsShowOnHome = true,
                    SortOrder = 1,
                    SeoAlias = "hat-macca",
                    MetaTitle = "Hạt Macca",
                    MetaKeyword = "Hạt Macca",
                    MetaDescription = "Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam",
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = hanhnhanId,
                     Name = "Hạnh nhân",
                     DisplayName = "Hạnh nhân",
                     UrlCode = "hanh-nhan",
                     IsShowOnHome = true,
                     SortOrder = 2,
                     SeoAlias = "hanh-nhan",
                     MetaTitle = "Hạnh nhân",
                     MetaKeyword = "Hạnh nhân",
                     MetaDescription = "Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột hoặc bột nhão. Trong 28 gram hạnh nhân có chứa hàm lượng chất",
                     Status = Status.Active,
                 },
                 new Category()
                 {
                     Id = mixhatId,
                     Name = "Mix hạt dinh dưỡng",
                     DisplayName = "Mix hạt dinh dưỡng",
                     UrlCode = "mix-hat",
                     IsShowOnHome = true,
                     SortOrder = 3,
                     SeoAlias = "mix-ha",
                     MetaTitle = "Mix hạt dinh dưỡng",
                     MetaKeyword = "Mix hạt dinh dưỡng",
                     MetaDescription = "Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay.",
                     Status = Status.Active,
                 },
                 new Category()
                 {
                     Id = granolaId,
                     Name = "Granola",
                     DisplayName = "Granola",
                     UrlCode = "granola",
                     IsShowOnHome = true,
                     SortOrder = 4,
                     SeoAlias = "granola",
                     MetaTitle = "Granola",
                     MetaKeyword = "Granola",
                     MetaDescription = "Granola là món ăn quen thuộc của người Mỹ vào buổi sáng, đây là hỗn hợp của nhiều thực phẩm lành lạnh với hàm lượng chất dinh dưỡng cao, nhất là giàu protein.",
                     Status = Status.Active,
                 },
                 new Category()
                 {
                     Id = occhoId,
                     Name = "Hạt óc chó",
                     DisplayName = "Hạt óc chó",
                     UrlCode = "hat-oc-cho",
                     IsShowOnHome = true,
                     SortOrder = 5,
                     SeoAlias = "hat-oc-cho",
                     MetaTitle = "Hạt óc chó",
                     MetaKeyword = "Hạt óc chó",
                     MetaDescription = "Hạt óc chó",
                     Status = Status.Active,
                 },
                 new Category()
                 {
                     Id = hatdieuId,
                     Name = "Hạt điều",
                     DisplayName = "Hạt điều",
                     UrlCode = "hat-dieu",
                     IsShowOnHome = true,
                     SortOrder = 6,
                     SeoAlias = "hat-dieu",
                     MetaTitle = "Hạt điều",
                     MetaKeyword = "Hạt điều",
                     MetaDescription = "Hạt điều",
                     Status = Status.Active,
                 },
                 new Category()
                 {
                     Id = banhkepId,
                     Name = "Bánh kẹp hạt dinh dưỡng",
                     DisplayName = "Bánh kẹp hạt dinh dưỡng",
                     UrlCode = "banh-kep-hat-dinh-duong",
                     IsShowOnHome = true,
                     SortOrder = 7,
                     SeoAlias = "banh-kep-hat-dinh-duong",
                     MetaTitle = "Bánh kẹp hạt dinh dưỡng",
                     MetaKeyword = "Bánh kẹp hạt dinh dưỡng",
                     MetaDescription = "Bánh kẹp hạt dinh dưỡng",
                     Status = Status.Active,
                 }

            );
            var p_maccanhanvoId = Guid.NewGuid();
            var p_maccanhannguyen = Guid.NewGuid();
            var p_maccanutvosizelon = Guid.NewGuid();
            var p_maccanutvosizenho = Guid.NewGuid();
            var p_mixid = Guid.NewGuid();
            var p_mixcc_id = Guid.NewGuid();
            var p_hanhnhansayId = Guid.NewGuid();
            var p_hanhnhanrang = Guid.NewGuid();
            var p_occhovangId = Guid.NewGuid();
            var p_occhodoId = Guid.NewGuid();
            var p_granolaId = Guid.NewGuid();
            var p_hatdieusayId = Guid.NewGuid();
            var p_hatdieuapetId = Guid.NewGuid();
            var p_hatdieuxephoaId = Guid.NewGuid();
            var p_banhkepId = Guid.NewGuid();
            var p_banhkeprongId = Guid.NewGuid();
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = p_maccanhanvoId,
                    Name = "Hạt Macca nhân vỡ",
                    Sku = "M01",
                    DisplayName = "Hạt Macca nhân nguyên",
                    UrlCode = "hat-macca",
                    Description = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    SeoAlias = "hat-macca-nhan-vo",
                    MetaTitle = "Hạt Macca nhân vỡ",
                    MetaKeyword = "Hạt Macca nhân vỡ",
                    MetaDescription = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    OriginalPrice = 290000,
                    Price = 270000,
                    Discount = 20000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = maccarId
                },
                new Product()
                {
                    Id = p_maccanhannguyen,
                    Name = "Hạt Macca nhân nguyên",
                    Sku = "M02",
                    DisplayName = "Hạt Macca nhân nguyên",
                    UrlCode = "hat-macca-nhan-nguyen",
                    Description = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    SeoAlias = "hat-macca-nhan-nguyen",
                    MetaTitle = "Hạt Macca nhân nguyên",
                    MetaKeyword = "Hạt Macca nhân nguyên",
                    MetaDescription = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    OriginalPrice = 330000,
                    Price = 320000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = maccarId
                },
                new Product()
                {
                    Id = p_maccanutvosizelon,
                    Name = "Hạt Macca nứt vỏ (A)",
                    Sku = "M03",
                    DisplayName = "Hạt Macca nứt vỏ (A)",
                    UrlCode = "hat-macca-nut-vo-size-a",
                    Description = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    SeoAlias = "hat-macca-nut-vo-size-a",
                    MetaTitle = "Hạt Macca nứt vỏ (size A)",
                    MetaKeyword = "Hạt Macca nứt vỏ (size A)",
                    MetaDescription = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    OriginalPrice = 130000,
                    Price = 125000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = true,
                    Status = Status.Active,
                    CategoryId = maccarId
                },
                new Product()
                {
                    Id = p_maccanutvosizenho,
                    Name = "Hạt Macca nứt vỏ (B)",
                    Sku = "M04",
                    DisplayName = "Hạt Macca nứt vỏ (B)",
                    UrlCode = "hat-macca-nut-vo-size-b",
                    Description = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    SeoAlias = "hat-macca-nut-vo-size-b",
                    MetaTitle = "Hạt Macca nứt vỏ (size B)",
                    MetaKeyword = "Hạt Macca nứt vỏ (size B)",
                    MetaDescription = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    OriginalPrice = 100000,
                    Price = 95000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = maccarId
                },
                new Product()
                {
                    Id = p_mixid,
                    Name = "MIX hạt cao cấp",
                    Sku = "MIX01",
                    DisplayName = "MIX hạt cao cấp",
                    UrlCode = "mix-hat-cao-cap",
                    Description = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 5 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng. ",
                    SeoAlias = "mix-hat-cao-cap",
                    MetaTitle = "MIX hạt cao cấp",
                    MetaKeyword = "MIX hạt cao cấp",
                    MetaDescription = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 5 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng.",
                    OriginalPrice = 170000,
                    Price = 160000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = true,
                    Status = Status.Active,
                    CategoryId = mixhatId
                },
                new Product()
                {
                    Id = p_mixcc_id,
                    Name = "MIX 6 hạt dinh dưỡng",
                    Sku = "MIX02",
                    DisplayName = "MIX 6 hạt dinh dưỡng",
                    UrlCode = "mix-6-loai-hat-dinh-duong",
                    Description = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 6 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca, Bí xanh mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng. ",
                    SeoAlias = "mix-6-loai-hat-dinh-duong",
                    MetaTitle = "MIX 6 loại hạt dinh dưỡng",
                    MetaKeyword = "MIX 6 loại hạt dinh dưỡng",
                    MetaDescription = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. Mix 6 loại hạt gồm Óc chó đỏ, Hạnh Nhân, Hạt điều, Óc chó vàng, Macca, Bí xanh mang đến cho bạn nguồn dinh dưỡng tự nhiên, đa dạng.",
                    OriginalPrice = 160000,
                    Price = 150000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = mixhatId
                },
                new Product()
                {
                    Id = p_hanhnhansayId,
                    Name = "Hạnh nhân rang bơ",
                    Sku = "H01",
                    DisplayName = "Hạnh nhân rang bơ",
                    UrlCode = "hanh-nhan-rang-bo",
                    Description = @"Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...",
                    SeoAlias = "hanh-nhan-rang-bo",
                    MetaTitle = "Hạnh nhân rang bơ",
                    MetaKeyword = "Hạnh nhân rang bơ",
                    MetaDescription = @"Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...",
                    OriginalPrice = 130000,
                    Price = 125000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = true,
                    Status = Status.Active,
                    CategoryId = hanhnhanId
                },
                new Product()
                {
                    Id = p_hanhnhanrang,
                    Name = "Hạnh nhân sấy",
                    Sku = "H02",
                    DisplayName = "Hạnh nhân sấy",
                    UrlCode = "hanh-nhan-say",
                    Description = @"Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...",
                    SeoAlias = "hanh-nhan-say",
                    MetaTitle = "Hạnh nhân sấy",
                    MetaKeyword = "Hạnh nhân sấy",
                    MetaDescription = @"Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...",
                    OriginalPrice = 135000,
                    Price = 130000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = hanhnhanId
                },
                new Product()
                {
                    Id = p_occhodoId,
                    Name = "Hạt óc chó đỏ",
                    Sku = "O01",
                    DisplayName = "Hạt óc chó đỏ",
                    UrlCode = "oc-cho-do",
                    Description = @"Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.",
                    SeoAlias = "hanh-nhan-say",
                    MetaTitle = "Hạt óc chó đỏ",
                    MetaKeyword = "Hạt óc chó đỏ",
                    MetaDescription = @"Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.",
                    OriginalPrice = 160000,
                    Price = 150000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = occhoId
                },
                new Product()
                {
                    Id = p_occhovangId,
                    Name = "Hạt óc chó vàng",
                    Sku = "O02",
                    DisplayName = "Hạt óc chó vàng",
                    UrlCode = "oc-cho-vang",
                    Description = @"Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.",
                    SeoAlias = "oc-cho-vang",
                    MetaTitle = "Hạt óc chó vàng",
                    MetaKeyword = "Hạt óc chó vàng",
                    MetaDescription = @"Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.",
                    OriginalPrice = 120000,
                    Price = 110000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = occhoId
                },
                new Product()
                {
                    Id = p_granolaId,
                    Name = "Granola",
                    Sku = "G01",
                    DisplayName = "Granola",
                    UrlCode = "granola",
                    Description = @"Granola là món ăn quen thuộc của người Mỹ vào buổi sáng, đây là hỗn hợp của nhiều thực phẩm lành lạnh với hàm lượng chất dinh dưỡng cao, nhất là giàu protein. Granola gồm các loại hạt dinh dưỡng, trái cây khô, yến mạch,…. được sấy giòn, giữ được 100% hương vị tươi ngon tự nhiên.",
                    SeoAlias = "granola",
                    MetaTitle = "Granola",
                    MetaKeyword = "Granola",
                    MetaDescription = @"Granola là món ăn quen thuộc của người Mỹ vào buổi sáng, đây là hỗn hợp của nhiều thực phẩm lành lạnh với hàm lượng chất dinh dưỡng cao, nhất là giàu protein. Granola gồm các loại hạt dinh dưỡng, trái cây khô, yến mạch,…. được sấy giòn, giữ được 100% hương vị tươi ngon tự nhiên.",
                    OriginalPrice = 130000,
                    Price = 120000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = true,
                    Status = Status.Active,
                    CategoryId = granolaId
                },
                new Product()
                {
                    Id = p_hatdieuxephoaId,
                    Name = "Hạt điều xếp hoa",
                    Sku = "D01",
                    DisplayName = "Hạt điều xếp hoa",
                    UrlCode = "hat-dieu-rang-muoi-xep-hoa",
                    Description = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    SeoAlias = "hat-dieu-rang-muoi-xep-hoa",
                    MetaTitle = "Hạt điều rang muối xếp hoa",
                    MetaKeyword = "Hạt điều rang muối xếp hoa",
                    MetaDescription = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    OriginalPrice = 130000,
                    Price = 120000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = true,
                    Status = Status.Active,
                    CategoryId = hatdieuId
                },
                new Product()
                {
                    Id = p_hatdieusayId,
                    Name = "Hạt điều sấy",
                    Sku = "D03",
                    DisplayName = "Hạt điều sấy",
                    UrlCode = "hat-dieu-sấy",
                    Description = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    SeoAlias = "hat-dieu-sấy",
                    MetaTitle = "Hạt điều sấy",
                    MetaKeyword = "Hạt điều sấy",
                    MetaDescription = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    OriginalPrice = 130000,
                    Price = 120000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = hatdieuId
                },
                new Product()
                {
                    Id = p_hatdieuapetId,
                    Name = "Hạt điều lon pet",
                    Sku = "D02",
                    DisplayName = "Hạt điều lon pet",
                    UrlCode = "hat-dieu-lon-pet",
                    Description = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    SeoAlias = "hat-dieu-lon-pet",
                    MetaTitle = "Hạt điều lon pet",
                    MetaKeyword = "Hạt điều lon pet",
                    MetaDescription = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    OriginalPrice = 140000,
                    Price = 135000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = hatdieuId
                },
                new Product()
                {
                    Id = p_banhkepId,
                    Name = "Bánh hạt điều",
                    Sku = "B01",
                    DisplayName = "Bánh hạt điều",
                    UrlCode = "banh-hat-dieu",
                    Description = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    SeoAlias = "banh-hat-dieu",
                    MetaTitle = "Bánh hạt điều",
                    MetaKeyword = "Bánh hạt điều",
                    MetaDescription = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    OriginalPrice = 90000,
                    Price = 80000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = true,
                    Status = Status.Active,
                    CategoryId = banhkepId
                },
                new Product()
                {
                    Id = p_banhkeprongId,
                    Name = "Bánh rong biển kẹp hạt",
                    Sku = "B02",
                    DisplayName = "Bánh rong biển kẹp hạt",
                    UrlCode = "banh-rong-bien-kep-hat",
                    Description = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    SeoAlias = "banh-rong-bien-kep-hat",
                    MetaTitle = "Bánh rong biển kẹp hạt",
                    MetaKeyword = "Bánh rong biển kẹp hạt",
                    MetaDescription = @"Hạt điều là hạt thuộc họ Anacardium occidentale có nguồn gốc từ Brazil được trồng nhiều ở các tỉnh phía Nam của Việt Nam. Ngoài hương vị thơm ngon thì hạt điều còn có giá trị dinh dưỡng cao cùng với những công dụng tuyệt vời đối với sức khỏe con người.",
                    OriginalPrice = 170000,
                    Price = 160000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = banhkepId
                }
            );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nhanvo_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_maccanhanvoId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nhanvo_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_maccanhanvoId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nhanvo_03.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 4,
                    ProductId = p_maccanhanvoId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nhanvo_04.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 4,
                    ProductId = p_maccanhanvoId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nhannguyen_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_maccanhannguyen,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nhannguyen_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_maccanhannguyen,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nhannguyen_03.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 3,
                    ProductId = p_maccanhannguyen,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nhannguyen_04.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 4,
                    ProductId = p_maccanhannguyen,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nutvo_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_maccanutvosizenho,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nutvo_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_maccanutvosizenho,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nutvolon_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_maccanutvosizelon,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/nutvolon_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_maccanutvosizelon,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/mix_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_mixid,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/mixcc_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_mixcc_id,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/mix_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_mixcc_id,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/hanhnhan_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_hanhnhanrang,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/hanhnhan_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_hanhnhanrang,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/hanhnhan_03.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 3,
                    ProductId = p_hanhnhanrang,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/hanhnhan_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_hanhnhansayId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/hanhnhan_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_hanhnhansayId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/hanhnhan_03.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 3,
                    ProductId = p_hanhnhansayId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/occhodo_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_occhodoId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/occhodo_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_occhodoId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/occhovang_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_occhovangId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/occhovang_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_occhovangId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/granola_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_granolaId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/granola_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_granolaId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/granola_03.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 3,
                    ProductId = p_granolaId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/dieupet_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_hatdieuapetId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/dieusay_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_hatdieusayId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/dieuxephoa_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_hatdieuxephoaId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/banhdieu_01.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 1,
                    ProductId = p_banhkepId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/banhdieu_02.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 2,
                    ProductId = p_banhkepId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/banhdieu_03.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 3,
                    ProductId = p_banhkepId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/banhdieu_03.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 3,
                    ProductId = p_banhkepId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/banhrong_01.jpg",
                    Caption = "Thumb Image",
                    IsDefault = false,
                    SortOrder = 1,
                    ProductId = p_banhkeprongId,
                    Status = Status.Active
                },
                new ProductImage()
                {
                    Id = Guid.NewGuid(),
                    Url = "/images/banhrong_02.jpg",
                    Caption = "Main Image",
                    IsDefault = true,
                    SortOrder = 2,
                    ProductId = p_banhkeprongId,
                    Status = Status.Active
                }

            );
        }
    }
}
