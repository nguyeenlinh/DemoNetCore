using Microsoft.AspNetCore.Mvc;
using Demo.Models.Process;

namespace Demo.Controllers
{
  public class String : Controller
  {
    StringProcess strPro = new StringProcess();
    public IActionResult Index()
    {
      return View();
    }
  
    [HttpPost]
    public IActionResult Index(string strInput)
    {
      ViewBag.str = strPro.RemoveRemainingWhiteSpace(strInput);
      // ViewBag.str = strPro.LowerToUpper(strInput);
      // ViewBag.str = strPro.CapitalizeOneFirstCharacter(strInput);
      // ViewBag.str = strPro.CapitalizeFirstCharacter(strInput);
      ViewBag.str = strPro.RemoveVietnameseAccents(strInput);
      return View();
    }
  }
}