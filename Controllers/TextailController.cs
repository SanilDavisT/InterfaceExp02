using InterfaceExp02.Models;
using InterfaceExp02.Utils;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceExp02.Controllers
{
    public class TextailController : Controller
    {


        //IHelper helper;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddDetail(Textail newtextail)
        {
            IHelper obj = new Helper();
            obj.filewrite(newtextail);
            //this.helper = helper;




            return View();
        }
    }
}
