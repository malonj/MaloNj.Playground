using Autofac;
using MaloNj.Playground.WebApi.Core.Interfaces;
using MaloNj.Playground.WebApi.Core.Services;

namespace MaloNj.Playground.WebApi.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
