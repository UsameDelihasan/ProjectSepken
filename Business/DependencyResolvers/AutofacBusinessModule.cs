using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfAuthorDal>().As<IAuthorDal>();
            builder.RegisterType<AuthorManager>().As<IAuthorService>();

            builder.RegisterType<EfBookDal>().As<IBookDal>();
            builder.RegisterType<BookManager>().As<IBookService>();

            //var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions() { Selector = new AspectInterceptorSelector() }).SingleInstance();  
        }
    }
}
