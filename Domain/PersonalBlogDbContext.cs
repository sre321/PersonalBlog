using Domain.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PersonalBlogDbContext : DbContext, IDbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PersonalBlogDbContext() : base("sqlConnection")
        {
            //开启自动迁移
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PersonalBlogDbContext, Configuration>("sqlConnection"));
        }
        /// <summary>
        /// 动态加载映射配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
        }
        /// <summary>
        /// 获取DbSet
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns>DbSet</returns>
        public new IDbSet<T> Set<T>() where T : Entity
        {
            return base.Set<T>();
        }
    }
}
