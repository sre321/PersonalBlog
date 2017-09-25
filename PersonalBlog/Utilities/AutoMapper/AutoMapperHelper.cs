using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common
{
    /// <summary>
    /// AutoMapper扩展帮助类
    /// </summary>
    public static class AutoMapperHelper
    {
        /// <summary>
        /// 类型映射
        /// </summary>
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
            where TSource : class
            where TDestination : class
        {
            if (source == null) return destination;
            //获取所有映射类型
            var allConfiguration = Mapper.Configuration.GetAllTypeMaps();
            //判断当前映射类型是否已经初始化过了
            var configurationCount = allConfiguration.Where(n => n.SourceType.Name == typeof(TSource).Name && n.DestinationType.Name == typeof(TDestination).Name).Count();
            if (configurationCount > 0)
                return Mapper.Map(source, destination);

            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<TSource, TDestination>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map(source, destination);
        }
    }
}