using System;
using System.Collections.Generic;
using CoffeeShop_Product;

namespace CoffeeShop_Product.Model;

public partial class ProductList
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? Category { get; set; }
}
