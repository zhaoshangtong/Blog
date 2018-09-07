using AutoMapper;
using Blog.Domain.Entities;
using Blog.ViewModel.Post;
using Blog.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.AutoMapperConfig
{
    /// <summary>
    /// AutoMapper的全局实体映射配置静态类
    /// </summary>
    public static class AutoMapperConfiguration
    {
        public static IMapper Mapper { get; private set; }
        public static MapperConfiguration MapperConfiguration { get; private set; }
        public static void Init()
        {
            MapperConfiguration  = new MapperConfiguration(cfg => 
            {
                //将领域实体映射到视图实体
                // 将布尔类型映射成字符串类型的是 / 否
                cfg.CreateMap<Post, PostViewModel>().ForMember(d => d.IsDeleted, d => d.MapFrom(s => s.IsDeleted>0 ? "是" : "否"));
                cfg.CreateMap<Post, PostViewModel>().ForMember(d => d.PublishedAt, d => d.MapFrom(s=>s.PublishedAt.ToString("yyyy年MM月dd日")));
                //将视图实体映射到领域实体
                cfg.CreateMap<PostViewModel, Post>();
                //loginname对应到username
                cfg.CreateMap<User, LoginViewModel>().ForMember(d => d.UserName, d => d.MapFrom(s => s.LoginName));
            });
            Mapper  =MapperConfiguration.CreateMapper();
        }
    }
}
