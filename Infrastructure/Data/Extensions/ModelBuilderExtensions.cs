
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
                     MetaDescription = "Granola",
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
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.NewGuid(),
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
                    OriginalPrice = 145000,
                    Price = 135000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = maccarId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
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
                    OriginalPrice = 165000,
                    Price = 160000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = maccarId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "MIX hạt cao cấp",
                    Sku = "MIX01",
                    DisplayName = "MIX hạt cao cấp",
                    UrlCode = "mix-hat-cao-cap",
                    Description = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ",
                    SeoAlias = "mix-hat-cao-cap",
                    MetaTitle = "MIX hạt cao cấp",
                    MetaKeyword = "MIX hạt cao cấp",
                    MetaDescription = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ",
                    OriginalPrice = 170000,
                    Price = 160000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = true,
                    Status = Status.Active,
                    CategoryId = mixhatId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "MIX 6 loại hạt dinh dưỡng",
                    Sku = "MIX02",
                    DisplayName = "MIX 6 loại hạt dinh dưỡng",
                    UrlCode = "mix-6-loai-hat-dinh-duong",
                    Description = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ",
                    SeoAlias = "mix-6-loai-hat-dinh-duong",
                    MetaTitle = "MIX 6 loại hạt dinh dưỡng",
                    MetaKeyword = "MIX 6 loại hạt dinh dưỡng",
                    MetaDescription = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ",
                    OriginalPrice = 160000,
                    Price = 150000,
                    Discount = 10000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = mixhatId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
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
                    IsNew = false,
                    IsBestSeller = true,
                    Status = Status.Active,
                    CategoryId = hanhnhanId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
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
                    Id = Guid.NewGuid(),
                    Name = "Hạt óc chó đỏ",
                    Sku = "O01",
                    DisplayName = "Hạt óc chó đỏ",
                    UrlCode = "oc-cho-do",
                    Description = @"Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.",
                    SeoAlias = "hanh-nhan-say",
                    MetaTitle = "Hạt óc chó đỏ",
                    MetaKeyword = "Hạt óc chó đỏ",
                    MetaDescription = @"Hạt óc chó đỏ là loại hạt óc chó không biến đổi Gen được tạo ra bằng phương pháp lai tạo tự nhiên. Sở dĩ được gọi là hạt óc chó đỏ bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu đỏ, thịt bên trong nhân là màu trắng sữa.",
                    OriginalPrice = 135000,
                    Price = 130000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = true,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = occhoId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Hạt óc chó vàng",
                    Sku = "O02",
                    DisplayName = "Hạt óc chó vàng",
                    UrlCode = "oc-cho-vang",
                    Description = @"Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.",
                    SeoAlias = "oc-cho-vang",
                    MetaTitle = "Hạt óc chó vàng",
                    MetaKeyword = "Hạt óc chó vàng",
                    MetaDescription = @"Hạt óc chó vàng là loại hạt óc chó được trồng thông dụng nhất hiện nay tại Mỹ, Úc, Anh, Trung Quốc… Sở dĩ gọi là hạt óc chó vàng bởi vì sau khi tách lớp vỏ cứng bên ngoài thì nhân bên trong có một lớp vỏ lụa màu vàng, thịt bên trong nhân là màu trắng sữa.",
                    OriginalPrice = 135000,
                    Price = 130000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = occhoId
                }
            );
        }
    }
}
