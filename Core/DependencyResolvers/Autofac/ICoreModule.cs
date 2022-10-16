using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers.Autofac
{
    public interface ICoreModule
    {
        public void Load(IServiceCollection services);
    }
}
