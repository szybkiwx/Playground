using Playground.Data;
using Playground.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            AutoMapper.Mapper.CreateMap<Tag, TagVM>();

            var tags = AutoMapper.Mapper.Map<List<TagVM>>( _context.TagSet);
            return View(new HomeVM
            { 
                Tags = tags
            });
        }
	}
}