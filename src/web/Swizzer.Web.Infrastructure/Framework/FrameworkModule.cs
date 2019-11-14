using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Core;
using Microsoft.Extensions.Configuration;

namespace Swizzer.Web.Infrastructure.Framework
{
    public class FrameworkModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public FrameworkModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
