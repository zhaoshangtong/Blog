﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    [SugarTable("tb_post")]
    public class Post
    {
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 作者ID
        /// </summary>
        public string AuthorId { get; set; }
        /// <summary>
        /// 作者姓名
        /// </summary>
        public string AuthorName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishedAt { get; set; }
        /// <summary>
        /// 是否标识已删除
        /// </summary>
        public int IsDeleted { get; set; }
        /// <summary>
        /// 是否允许展示
        /// </summary>
        public int AllowShow { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public int ViewCount { get; set; }
    }
}
