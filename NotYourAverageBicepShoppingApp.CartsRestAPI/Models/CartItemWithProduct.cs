﻿namespace NotYourAverageBicepShoppingApp.CartsRestAPI.Models;
public partial class CartItemWithProduct
    {
        public CartItem? CartItem { get; set; }
        public Product? Product { get; set; }
    }
