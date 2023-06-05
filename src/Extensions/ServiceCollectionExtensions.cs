using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Xo.TaskFlow.DependencyInjection.Extensions;

namespace Xo.TaskFlow.Extensions.DependencyInjection;

public static class TaskFlowServiceCollectionExtensions
{
    public static IServiceCollection AddTaskFlowExtensions(this IServiceCollection @this)
    {
        return @this
            .AddTaskWorkflowEngineServices()
            .AddFrameworkServices();
    }

    private static IServiceCollection AddFrameworkServices(this IServiceCollection @this)
    {
        @this.TryAddSingleton<IFlowBuilder, FlowBuilder>();

        return @this;
    }
}