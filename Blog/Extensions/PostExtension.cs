using Blog.Core;
using Blog.ViewModel.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Extensions
{
    public static class PostExtension
    {
        /// <summary>
        /// 格式化文章的视图实体
        /// </summary>
        /// <param name="model">文章视图实体类</param>
        /// <returns></returns>
        public static PostViewModel FormatPostViewModel(this PostViewModel model)
        {
            if (model == null)
            {
                return null;
            }

            model.Summary = model.Content
                .CleanHtml()            //去掉所有HTML标签
                .TruncateString(200, TruncateOptions.FinishWord | TruncateOptions.AllowLastWordToGoOverMaxLength);     //截断指定长度作为文章摘要
            return model;
        }
    }
}