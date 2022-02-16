using InterfaceExp02.Models;
using InterfaceExp02.Utils;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceExp02.Controllers
{
    public class TextailController : Controller
    {

        IHelper helper;

        public TextailController(IHelper helper)
        {
            this.helper = helper;

        }
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult AddDetail(Textail newtextail)
        {
            helper.filewrite(newtextail);
            




            return View();
        }
    }
}
