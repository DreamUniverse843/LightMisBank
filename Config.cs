using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LightMisBank
{
    internal class Config//定义程序的配置项
    {
        /// <summary>
        /// 配置文件涉及路径请使用 \\ 进行转义
        /// </summary>
        //数据库文件路径配置，上方为相对路径，下方为绝对路径
        //生产环境时建议为相对路径
        //public static string SQLPath = System.Environment.CurrentDirectory + "\\sql\\database.db";
        public static string SQLPath = "data source=E:\\Dev\\LightMisBank\\sql\\database.db";
    }
    
}
