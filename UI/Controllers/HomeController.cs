using Playground.Data;
using Playground.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Playground.UI.Controllers
{
    public class HomeController : Controller
    {
        //PlaygroundContext ctx = new PlaygroundContext();
        PlaygroundContext _context;

        public HomeController(PlaygroundContext ctx)
        {
            _context = ctx;
        }

        public ActionResult Index()
        {
            AutoMapper.Mapper.CreateMap<Tag, TagVM>()
                .ForMember(dst => dst.ExpensesCount, opt => opt.MapFrom(src => src.Expenses.Count));
            var tags = _context.TagSet.Include(x => x.Expenses);

            var sql = tags.ToString();

            var tagModels = AutoMapper.Mapper.Map<List<TagVM>>(tags);
            return View(new HomeVM
            {
                Tags = tagModels
            });
        }
	}
}