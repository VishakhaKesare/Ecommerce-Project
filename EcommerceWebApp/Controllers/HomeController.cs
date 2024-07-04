using EcommerceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWebApp.Controllers
{
    public class HomeController : Controller
    {
        DB_ECOM_ENTITIES dB_ECOM_ENTITIES;
        public ActionResult Index()
        {
           dB_ECOM_ENTITIES = new DB_ECOM_ENTITIES();
            int total_orders = dB_ECOM_ENTITIES.ecom_order.Count();
            int total_sales = dB_ECOM_ENTITIES.ecom_order.Count();
            int total_customer = dB_ECOM_ENTITIES.ecom_customer.Count();
            int total_user = dB_ECOM_ENTITIES.ecom_user.Count();

            ViewBag.total_orders = total_orders;
            ViewBag.total_sales = total_sales;
            ViewBag.TotalCustomer = total_customer;
            ViewBag.TotalUser = total_user;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult categories()
        {
            ViewBag.Message = "Categories";
            IList<categories> Categories = new List<categories>() 
            {
               new categories() { CategoryId =1,CategoryName="Camera",SortOrder=1 },
               new categories() { CategoryId =2,CategoryName="Mobile",SortOrder=2},
               new categories() { CategoryId =3,CategoryName="Furniture",SortOrder=3 },
               new categories() { CategoryId =4,CategoryName="Car",SortOrder=4},
            };
            ViewBag.Categories = Categories; 

            return View();
        }


        public ActionResult product()
        {
            ViewBag.Message = "products";

            return View();
        }


        public ActionResult subscription()
        {
            ViewBag.Message = "subscription";

            return View();
        }

        public ActionResult Filters()
        {
            ViewBag.Message = "Filters";

            return View();
        }

        public ActionResult attributes()
        {
            ViewBag.Message = "attributes";

            return View();
        }

        public ActionResult attributesGroup()
        {
            ViewBag.Message = "attributesGroup";

            return View();
        }

        public ActionResult Information()
        {
            ViewBag.Message = "Information";

            return View();
        }

        public ActionResult Downlods()
        {
            ViewBag.Message = "Downlods";

            return View();
        }

        public ActionResult Manifactures()
        {
            ViewBag.Message = "Manifactures";

            return View();
        }

        public ActionResult Option()
        {
            ViewBag.Message = "Option";

            return View();
        }

        public ActionResult AddCategory()
        {
            ViewBag.Message = "AddCategory";

            return View();
        }

        public ActionResult AddProduct()
        {
            ViewBag.Message = "AddProduct";

            return View();
        }

        public ActionResult AddSubscription()
        {
            ViewBag.Message = "AddSubscription";

            return View();
        }

        public ActionResult orders()
        {
            ViewBag.Message = "orders";

            return View();
        }

        public ActionResult Returns()
        {
            ViewBag.Message = "Returns";

            return View();
        }

        public ActionResult Giftvochers()
        {
            ViewBag.Message = "Giftvochers";

            return View();
        }
        public ActionResult vocherThemes()
        {
            ViewBag.Message = "vocherThemes";

            return View();
        }

        public ActionResult AddFilters()
        {
            ViewBag.Message = "AddFilters";

            return View();
        }

         public ActionResult AddAttributes()
        {
            ViewBag.Message = "AddAttributes";

            return View();
        }

        public ActionResult AddAttributesGroup()
        {
            ViewBag.Message = "AddAttributesGroup";

            return View();
        }

        public ActionResult AddInformation()
        {
            ViewBag.Message = "AddInformation";

            return View();
        }

        public ActionResult AddDownlods()
        {
            ViewBag.Message = "AddDownlods";

            return View();
        }

        public ActionResult AddMAnifactures()
        {
            ViewBag.Message = "AddManifactures";

            return View();
        }

        public ActionResult AddProductReturns()
        {
            ViewBag.Message = "AddProductReturns";

            return View();
        }

        public ActionResult AddGiftVochers()
        {
            ViewBag.Message = "AddGiftVochers";

            return View();
        }

        public ActionResult AddVochersThemes()
        {
            ViewBag.Message = "AddVochersThemes";

            return View();
        }

        public ActionResult Customers()
        {
            ViewBag.Message = "Customers";

            return View();
        }

        public ActionResult AddCustomers()
        {
            ViewBag.Message = "AddCustomers";

            return View();
        }

        public ActionResult CustomerGroup()
        {
            ViewBag.Message = "AddCustomerGroup";

            return View();
        }

        public ActionResult AddCustomerGroup()
        {
            ViewBag.Message = "AddCustomerGroup";

            return View();
        }

      

        public ActionResult AddOptions()
        {
            ViewBag.Message = "AddOptions";

            return View();
        }
        public ActionResult AddOrders()
        {
            ViewBag.Message = "AddOrders";

            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(ecom_category_description ecom_Category)
        {
            dB_ECOM_ENTITIES = new DB_ECOM_ENTITIES();
            /* string value = ecom_Category.name.ToString();*/
            /*ecom_Category.language_id = 2;*/
           dB_ECOM_ENTITIES.ecom_category_description.Add(ecom_Category);
            dB_ECOM_ENTITIES.SaveChanges();
            return View();

            return View(ecom_Category);
        }







    }
}

    



