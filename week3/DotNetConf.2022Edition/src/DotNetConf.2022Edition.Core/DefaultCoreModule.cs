using Autofac;
using DotNetConf._2022Edition.Core.Interfaces;
using DotNetConf._2022Edition.Core.Services;

namespace DotNetConf._2022Edition.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
