﻿using System;
using System.Collections.Generic;

namespace test2.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public int CategoryId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Quantity { get; set; }

    public string Capacity { get; set; } = null!;

    public decimal Price { get; set; }

    public string Brand { get; set; } = null!;

    public string Origin { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string ImgUrl { get; set; } = null!;

    public string? SkinType { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
