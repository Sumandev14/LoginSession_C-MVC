using SchoolManagement_380.Helpers.Helpers;
using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Services
{
    public class OrderService : IOrderRepository
    {
        Sandhya_380Entities9 _dbTest = new Sandhya_380Entities9();
        public bool createTest(OrderModel orderModel, int? id)
        {
                orders orders = OrderHelper.CreateOrder(orderModel);
            try
            {
                if(orders != null)
                {
                    if(id == 0)
                    {
                        _dbTest.orders.Add(orders);
                        _dbTest.SaveChanges();
                        return true;
                    }
                    else
                    {
                        _dbTest.Entry(orders).State = System.Data.Entity.EntityState.Modified;
                        _dbTest.SaveChanges();
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        public void DeleteTest(int id)
        {
            var delerte = _dbTest.orders.Find(id);
            _dbTest.orders.Remove(delerte);
            _dbTest.SaveChanges();
        }

        public OrderModel GetDetails(int? id)
        {
            orders orders = _dbTest.orders.Where(x => x.OrderId == id).FirstOrDefault();
            OrderModel orderModel = OrderHelper.GetOrderModel(orders);
            return orderModel;
        }

        public IEnumerable<Test_Order_Item_Result> GetListTest()
        {
            return _dbTest.Test_Order_Item().ToList();
        }
    }
}
