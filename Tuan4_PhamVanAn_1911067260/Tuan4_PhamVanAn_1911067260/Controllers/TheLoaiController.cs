using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan4_PhamVanAn_1911067260.Models;

namespace Tuan4_PhamVanAn_1911067260.Controllers
{
    public class TheLoaiController : Controller
    {
        // GET: TheLoai
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            var all_theloai = from tt in data.TheLoais select tt;
            return View(all_theloai);
        }
    }
}