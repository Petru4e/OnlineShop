﻿using OnlineShop.Models;

namespace OnlineShop
{
    public static class CartsRepository
    {
        public static List<Cart> carts = new List<Cart>();

        public static Cart TryGetByUserId(string userId)
        {
            return carts.FirstOrDefault(c => c.UserId == userId);
        }

        internal static void Add(Product product, string userId)
        {
            var existingCart = TryGetByUserId(userId);
            if (existingCart == null)
            {
                var newCart = new Cart()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Items = new List<CartItem>()
                    {
                       new CartItem
                    {
                        Id = Guid.NewGuid(),
                        Amount = 1,
                        Product = product
                    }
                    }
                };
                carts.Add(newCart);
            }
            else
            {
                var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount++;
                }
                else
                {
                    existingCart.Items.Add(new CartItem
                    {
                        Id = Guid.NewGuid(),
                        Amount = 1,
                        Product = product
                    });
                }
            }
        }
    }
}
