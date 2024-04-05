﻿
using NotYourAverageBicepShoppingApp.UIApp.Models;

namespace NotYourAverageBicepShoppingApp.UIApp.APIClient
{
    public interface ICartsClient
    {
        Task<List<CartItem>?> PutDeleteProductFromCartAsync(int cartId, int productId);
        Task<CartDetailsDTO?> GetAllCartItemsForCartAsync(int cartId);
        Task<Cart?> PostNewCartAsync();
        Task<CartItem?> PutAddProductToCartAsync(int cartId, int productId);
        Task<List<CartItem>?> PutDeleteAllProductsFromCartAsync(int cartId);
    }
}
