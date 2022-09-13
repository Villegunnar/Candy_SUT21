using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_SUT21.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingcart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingcart;

        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetails = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Candy.Price,
                    CandyId = shoppingCartItem.Candy.CandyId,
                    OrderId = order.OrderId
                };

                _appDbContext.OrdersDetails.Add(orderDetails);

            }
            _appDbContext.SaveChanges();
        }
    }
}
