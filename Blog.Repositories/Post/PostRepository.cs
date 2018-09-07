using Blog.Domain.Entities;
using MySql.Data.MySqlClient;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    /// <summary>
    /// POST表的数据库操作类
    /// </summary>
    public class PostRepository:GenericRepository<Post>,IPostRepository
    {
        /// <summary>
        /// 查询首页文章列表
        /// </summary>
        /// <param name="limit">要查询的记录数</param>
        /// <returns></returns>
        public IEnumerable<Post> FindHomePagePosts(int limit = 20)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                var list = db.Queryable<Post>().OrderBy(x => x.Id, OrderByType.Desc).Take(limit).ToList();
                return list;
            }
        }
    }
}
