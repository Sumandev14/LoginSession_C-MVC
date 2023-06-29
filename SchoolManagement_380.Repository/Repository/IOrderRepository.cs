using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Test_Order_Item_Result> GetListTest();

        bool createTest(OrderModel orderModel, int? id);

        OrderModel GetDetails(int? id);

        void DeleteTest(int id);
    }
}
