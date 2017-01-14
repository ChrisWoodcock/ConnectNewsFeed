using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsFeed.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ViewResult GetArticles(string category)
        {
            return View();
        }
    }
}