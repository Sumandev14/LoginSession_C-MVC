using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Helpers.Helpers
{
    public class OrderHelper
    {
        public static orders CreateOrder(OrderModel orderModel)
        {
            orders order = new orders()
            {
                OrderId = orderModel.OrderId,
                ProductId = orderModel.ProductId,
                Quantityt = orderModel.Quantityt,
                UserId = orderModel.UserId,
                Total = orderModel.Total,
                Price = orderModel.Price 
            };
            return order;
        }

        public static OrderModel GetOrderModel(orders orders)
        {
            OrderModel orderModel = new OrderModel()
            {
                OrderId = orders.OrderId,
                ProductId = orders.ProductId,
                Quantityt = orders.Quantityt,
                UserId = orders.UserId,
                Total = orders.Total,
                Price = orders.Price
            };
            return orderModel;
        }
    }
}
