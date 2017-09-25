using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common
{
    public class AutoMapperConfiguration
    {
        public static void Register()
        {
            Mapper.Initialize(x => {
                x.AddProfile<SourceProfile>();
            });
        }
    }
}