using SampleOfKeepPagingState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace SampleOfKeepPagingState.Controllers
{
    [OutputCache(Location = OutputCacheLocation.None)]
    public class PersonController : Controller
    {
        public PersonRepository Repository { get; set; }

        public PersonController()
        {
            this.Repository = new PersonRepository();
        }

        // GET: /Person/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListHtml(int pageIndex)
        {
            const int pageSize = 2;
            var allPeople = this.Repository.GetAll();
            var model = new PeopleListViewModel
            {
                PeopleAtAPage = allPeople
                    .Skip(pageSize * (pageIndex - 1))
                    .Take(pageSize),

                PageIndex = pageIndex,

                NumberOfPages = (int)Math.Ceiling((double)allPeople.Count() / pageSize)
            };
            return PartialView("_ListHtml", model);
        }

        // GET: /Person/Details/5
        public ActionResult Details(int id)
        {
            var model = this.Repository.FindById(id);
            return View(model);
        }
    }
}
