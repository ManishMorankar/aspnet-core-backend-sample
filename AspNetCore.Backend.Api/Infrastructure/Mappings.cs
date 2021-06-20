using System.IO;
using System.Linq;
using AspNetCore.Backend.Api.DbModels;
using AspNetCore.Backend.Api.ViewModels;

namespace AspNetCore.Backend.Api.Infrastructure
{
    public static class Mappings
    {
        public static ProductModel MapToProductModel(Product model)
        {
            return new ProductModel
            {
                Id = model.Id,
                Code = model.Code,
                Description1 = model.Description1,
                Description2 = model.Description2,
                Discount = model.Discount,
                HashTag = model.HashTag,
                Img = model.Img,
                Price = model.Price,
                Rating = model.Rating,
                Subtitle = model.Subtitle,
                Technologies = model.Technologies.Split(",").ToList(),
                Title = model.Title
            };
        }

        public static Product MapToProductDbModel(ProductModel model)
        {
            return new Product
            {
                Code = model.Code,
                Description1 = model.Description1,
                Description2 = model.Description2,
                Discount = model.Discount,
                HashTag = model.HashTag,
                Img = Path.GetFileName(model.Img),
                Price = model.Price,
                Rating = model.Rating,
                Subtitle = model.Subtitle,
                Technologies = string.Join(",", model.Technologies),
                Title = model.Title
            };
        }

        public static void UpdateProduct(ProductModel source, Product dest)
        {
            dest.Code = source.Code;
            dest.Description1 = source.Description1;
            dest.Description2 = source.Description2;
            dest.Discount = source.Discount;
            dest.HashTag = source.HashTag;
            dest.Img = Path.GetFileName(source.Img);
            dest.Price = source.Price;
            dest.Rating = source.Rating;
            dest.Subtitle = source.Subtitle;
            dest.Title = source.Title;
            dest.Technologies = string.Join(",", source.Technologies);
        }
    }
}