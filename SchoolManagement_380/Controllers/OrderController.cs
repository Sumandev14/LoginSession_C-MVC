using Newtonsoft.Json;
using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_380.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IItemRepostery _itemRepo;
        private readonly ICoupanInterface _coupanRepo;
        public OrderController(IOrderRepository orderRepository, IItemRepostery itemRepostery, ICoupanInterface coupanInterface)
        {
            _orderRepo = orderRepository;
            _itemRepo = itemRepostery;
            _coupanRepo = coupanInterface;
        }
        // GET: Order
        public ActionResult OrderViewList(int? id)
        {
            ViewBag.ItemList = _itemRepo.GetItems();
            ViewBag.GetOrders = _orderRepo.GetListTest();
            //For tortal Amount
            var result = _orderRepo.GetListTest().ToList();
            var count = result.Count(x => x.Quantityt > 0);

            int totalAmount = (int)result.Sum(x => x.Total);
            ViewBag.Count = count;
            ViewBag.TotalAmount = totalAmount;

            //For SGST
            int GSTAmount = (totalAmount * 5) / 100;
            ViewBag.Gst = GSTAmount;

            //For Total PayBel Amount
            int TotalPayBelAmount = totalAmount + (2 * GSTAmount);
            ViewBag.Payble = TotalPayBelAmount;

            
            try
            {
                if (id == 0 || id != null)
                {
                    OrderModel orderModel = _orderRepo.GetDetails(id);
                    return View(orderModel);
                }
                else
                {
                    return View();
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        [HttpPost]
        public ActionResult OrderViewList(OrderModel orderModel, int? id)
        {
            try
            {
                if(orderModel.OrderId == 0)
                {
                    _orderRepo.createTest(orderModel, 0);
                    return RedirectToAction("OrderViewList");
                }
                else
                {
                    _orderRepo.createTest(orderModel, id);
                    return RedirectToAction("OrderViewList");
                }
            }
            catch (Exception ex)
            {

                throw ex;
                
            }
        }

        public ActionResult Delete(int id)
        {
            _orderRepo.DeleteTest(id);
            return RedirectToAction("OrderViewList");
        }

        //public JsonResult CoupenApply(int? id)
        //{
        //    var coupon = _coupanRepo.getCoupanId(id);
        //    var jsCoupon = JsonConvert.SerializeObject(coupon);
        //    return Json(jsCoupon, JsonRequestBehavior.AllowGet);
        //}

        public JsonResult ApplyCoupon(string code)
        {
            var coupen = _coupanRepo.GetCoupenDetail(code);
            if(coupen != null)
            {
                if (coupen.Expirydate != null && coupen.Expirydate < DateTime.Now)
                {
                    return Json(new { error = "Coupon code has expired." }, JsonRequestBehavior.AllowGet);
                }
                // Check usage limit
                if (coupen.UsageLimit != null && coupen.UsageLimit <= 0)
                {
                    return Json(new { error = "Coupon code has reached the usage limit." }, JsonRequestBehavior.AllowGet);
                }

                return Json(coupen, JsonRequestBehavior.AllowGet);
            }
            return Json("", JsonRequestBehavior.AllowGet);
            //int totalAmount = ViewBag.TotalAmount;
            //int netPayment = 0;
            //var coupon = _coupanRepo.getCoupanId(coupenModel);
            //if (coupon != null)
            //{
            //    if (coupon.Type == 1)
            //    {
            //        netPayment = totalAmount - (int)coupon.DiscountAmount;
            //    }else if(coupon.Type == 2)
            //    {
            //        decimal discountPercentage = (int)coupon.DiscountAmount / 100.0m;
            //        netPayment = (int)(totalAmount - (totalAmount * discountPercentage));
            //    }
            //    else
            //    {
            //        return RedirectToAction("error");
            //    }

            //    ViewBag.netPayment = netPayment;
            //    return View("OrderViewList");
            //}
            //else
            //{
            //    return RedirectToAction("error");
            //}
            //return View();
        }

    }
}
