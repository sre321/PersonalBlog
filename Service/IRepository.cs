using System;
using System.Linq;
using System.Linq.Expressions;

namespace Service
{
    /// <summary>
    /// 所有的数据操作基类接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        #region 单模型CRUD操作
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="entity"></param>
        bool Create(T entity);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(T entity);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(T entity);
        /// <summary>
        /// 根据id查询一条数据
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        T GetById(Guid entityId);
        #endregion

        #region 获取多条数据
        /// <summary>
        /// 返回IQueryable集合
        /// </summary>
        /// <returns></returns>
        IQueryable<T> LoadAll();
        #endregion
    }
}
