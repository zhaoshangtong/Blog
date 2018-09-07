using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    /// <summary>
    /// 数据库工厂
    /// </summary>
    public class DbFactory
    {
        /// <summary>
        /// SqlSugarClient属性
        /// </summary>
        /// <returns></returns>
        public static SqlSugarClient GetSqlSugarClient()
        {
            var db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString, //必填 连接字符串
                DbType = DbType.MySql, //必填 数据库类型
                IsAutoCloseConnection = true, //默认false 是否自动释放数据库，设为true我们不需要close或者Using的操作，比较推荐
                InitKeyType = InitKeyType.Attribute//InitKeyType.SystemTable表示自动从数据库读取主键自增列的信息 ,InitKeyType.Attribute 表示从属性中读取 主键和自增列的信息
            }); //默认SystemTable
            return db;
        }
    }
}
