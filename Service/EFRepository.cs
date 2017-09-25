using Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;

namespace Service
{
    public class EFRepository<T> : IRepository<T> where T : Entity
    {
        #region 字段

        private readonly IDbContext _context=new EFDbContextFactory().db;
        private IDbSet<T> _entities;
        #endregion

        /// <summary>
        /// Entities
        /// </summary>
        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities=_context.Set<T>();
                return _entities;
            }
        }
        #region 单模型CRUD操作
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns></returns>
        public bool Create(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));
                this.Entities.Add(entity);
                return this._context.SaveChanges() > 0;
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        public bool Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));
                this.Entities.Remove(entity);
                return this._context.SaveChanges() > 0;
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }
        /// <summary>
        /// 根据Id查询一条数据
        /// </summary>
        /// <param name="entityId">实体数据Id</param>
        /// <returns>实体数据</returns>
        public T GetById(Guid entityId)
        {
            return this.Entities.Find(entityId);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        public bool Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));
                return this._context.SaveChanges() > 0;
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }
        #endregion

        #region 获取多条数据
        /// <summary>
        /// 返回IQueryable集合
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> LoadAll()
        {
            return this.Entities;
        }
        #endregion

        #region Utilities
        /// <summary>
        /// 得到所有错误
        /// </summary>
        /// <param name="dbEx"></param>
        /// <returns></returns>
        protected string GetFullErrorText(DbEntityValidationException dbEx)
        {
            var msg = string.Empty;
            foreach (var validationErrors in dbEx.EntityValidationErrors)
                foreach (var error in validationErrors.ValidationErrors)
                    msg += $"Property:{error.PropertyName} Error:{error.ErrorMessage}" + Environment.NewLine;
            return msg;
        }
        #endregion
    }
}
