using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace itproekt.Controllers
{
    public class BlogController : Controller
    {
        newdbEntities nd = new newdbEntities();
        // GET: Blog
        public ActionResult Index()
        {
            var blogdetails = nd.Tables.ToList().OrderByDescending(x=>x.Id);
            return View(blogdetails);
        }
        [Authorize(Roles = "Direktor")]
        public ActionResult UploadBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadBlog(Table bg)
        {
            nd.Tables.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Известувањето е објавено успешно";
            return View();
        }
        public ActionResult dodatniaktivnosti()
        {
            var dodatniaktivnosti = nd.Tables.Where(x => x.BCategory == "Додатни активности");
            return View(dodatniaktivnosti);
        }
        public ActionResult proekti()
        {
            var proekti = nd.Tables.Where(x => x.BCategory == "Проекти");
            return View(proekti);
        }
        public ActionResult nastani()
        {
            var nastani = nd.Tables.Where(x => x.BCategory == "Екскурзии и настани");
            return View(nastani);
        }
    }
}