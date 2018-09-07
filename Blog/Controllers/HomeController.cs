using Blog.AutoMapperConfig;
using Blog.Extensions;
using Blog.Repositories;
using Blog.Services;
using Blog.ViewModel.Post;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        public HomeController(IPostService postService)
        {
            _postService = postService;
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int? page)
        {
            //var list = _postService.FindHomePagePosts();
            //读取分页数据,返回IPagedList<Post>
            page = page ?? 1;
            var list = _postService.FindPagedList(x => x.IsDeleted==0 && x.AllowShow>0, pageIndex: (int)page, pageSize: 10);
            var model = list.Select(x => x.ToModel().FormatPostViewModel());
            ViewBag.Pagination = new StaticPagedList<PostViewModel>(model, list.PageIndex, list.PageSize, list.TotalCount);
            return View(model);
        }
    }
}