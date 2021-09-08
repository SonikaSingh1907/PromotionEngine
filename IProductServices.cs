using System;
using System.Collections.Generic;
using PromotionEngine.Models;

namespace PromotionEngine.IProductServices
{
    public interface IProductServices
    {
        int GetTotalPrice(List<Product> products);
    }
}
