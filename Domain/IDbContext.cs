using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// DbContext的接口
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// 获取DbSet
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns>DbSet</returns>
        IDbSet<T> Set<T>() where T : Entity;
        /// <summary>
        /// 保存修改
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}
