using Client.FirstWebServiceReference;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        FirstWCFWebServiceClient client = new FirstWCFWebServiceClient();


        public ActionResult Index()
        {
            ViewBag.Message = client.Message();
            int x = client.add(2, 3);
            ViewBag.X = 2;
            ViewBag.Y = 3;
            ViewBag.Z = x;
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
    }
}