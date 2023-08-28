
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
                     Id = Guid.NewGuid(),
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
                     Id = Guid.NewGuid(),
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
                     Id = Guid.NewGuid(),
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
                    IsFeatured = false,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = maccarId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Hạt Macca nứt vỏ (size lớn)",
                    Sku = "M03",
                    DisplayName = "Hạt Macca nứt vỏ",
                    UrlCode = "hat-macca-nut-vo",
                    Description = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    SeoAlias = "hat-macca-nut-vo",
                    MetaTitle = "Hạt Macca nứt vỏ",
                    MetaKeyword = "Hạt Macca nứt vỏ",
                    MetaDescription = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    OriginalPrice = 130000,
                    Price = 125000,
                    Discount = 5000,
                    IsFeatured = false,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = maccarId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Hạt Macca nứt vỏ (size nhỏ)",
                    Sku = "M04",
                    DisplayName = "Hạt Macca nứt vỏ",
                    UrlCode = "hat-macca-nut-vo",
                    Description = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    SeoAlias = "hat-macca-nut-vo",
                    MetaTitle = "Hạt Macca nứt vỏ",
                    MetaKeyword = "Hạt Macca nứt vỏ",
                    MetaDescription = @"Hạt Macca là hạt giống của cây macadamia, có nguồn gốc từ Úc và được trồng ở nhiều nơi trên thế giới, chằng hạn như Brazil, Costa Rica, Hawaii, New Zealand, trong đó có Việt Nam...
                    Đây được xem là nữ hoàng của các loại hạt vì rất giàu dinh dưỡng, phù hợp với mọi lứa tuổi. Hạt mắc ca có hình cầu khoảng 20-30mm, hương thơm, vị béo ngậy đặc trưng...
                    Tất cả các hạt đều đã được sấy giòn được tách vỏ chỉ còn nhân trắng nguyên bên trong giữ được 100% vị ngon tự nhiên.",
                    OriginalPrice = 100000,
                    Price = 95000,
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
                    Name = "MIX HẠT CAO CẤP",
                    Sku = "MIX01",
                    DisplayName = "MIX HẠT CAO CẤP",
                    UrlCode = "mix-hat-cao-cap",
                    Description = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ",
                    SeoAlias = "mix-hat-cao-cap",
                    MetaTitle = "MIX HẠT CAO CẤP",
                    MetaKeyword = "MIX HẠT CAO CẤP",
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
                    Name = "MIX 6 LOẠI HẠT DINH DƯỠNG",
                    Sku = "MIX02",
                    DisplayName = "MIX 6 LOẠI HẠT DINH DƯỠNG",
                    UrlCode = "mix-6-loai-hat-dinh-duong",
                    Description = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ",
                    SeoAlias = "mix-6-loai-hat-dinh-duong",
                    MetaTitle = "MIX 6 LOẠI HẠT DINH DƯỠNG",
                    MetaKeyword = "MIX 6 LOẠI HẠT DINH DƯỠNG",
                    MetaDescription = @"Hạt dinh dưỡng được hiểu một cách đơn giản là các loại hạt có vỏ cứng và tách vỏ khi dùng như hạt hạnh nhân, óc chó, điều, bí xanh…Những loại hạt này cung cấp cho cơ thể nhiều dưỡng chất cần thiết và được sử dụng rất nhiều để ăn kiêng, ăn chay. ",
                    OriginalPrice = 160000,
                    Price = 150000,
                    Discount = 10000,
                    IsFeatured = false,
                    IsNew = true,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = mixhatId
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "HẠNH NHÂN RANG BƠ",
                    Sku = "H01",
                    DisplayName = "HẠNH NHÂN RANG BƠ",
                    UrlCode = "hanh-nhan-rang-bo",
                    Description = @"Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...",
                    SeoAlias = "hanh-nhan-rang-bo",
                    MetaTitle = "HẠNH NHÂN RANG BƠ",
                    MetaKeyword = "HẠNH NHÂN RANG BƠ",
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
                    Name = "HẠNH NHÂN SẤY",
                    Sku = "H02",
                    DisplayName = "HẠNH NHÂN SẤY",
                    UrlCode = "hanh-nhan-say",
                    Description = @"Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...",
                    SeoAlias = "hanh-nhan-say",
                    MetaTitle = "HẠNH NHÂN SẤY",
                    MetaKeyword = "HẠNH NHÂN SẤY",
                    MetaDescription = @"Hạnh nhân có nguồn gốc từ Trung Đông. Hạnh nhân được bán sống hoặc rang. Chúng cũng được sử dụng để sản xuất sữa hạnh nhân, dầu, bơ, bột...",
                    OriginalPrice = 135000,
                    Price = 130000,
                    Discount = 5000,
                    IsFeatured = true,
                    IsNew = false,
                    IsBestSeller = false,
                    Status = Status.Active,
                    CategoryId = hanhnhanId
                }

            );
        }
    }
}