using System;

namespace Domain
{
    public class Category : Entity
    {
        /// <summary>
        /// 类别
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 类别Id
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 模块Id
        /// </summary>
        public int ModuleId { get; set; }
    }
}
