using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDemoApp.Models;

namespace WebAppRestaurantDemoApp.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public PaymentTypeRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objSelectListItem = new List<SelectListItem>();
            objSelectListItem = (from obj in objRestaurantDBEntities.Items
                                 select new SelectListItem()
                                 {
                                     Text = obj.ItemName,
                                     Value = obj.ItemId.ToString(),
                                     Selected = true

                                 }).ToList();
            return objSelectListItem;

        }
    }
}