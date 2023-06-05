using Microsoft.Extensions.DependencyInjection;
using Xo.TaskFlow.DependencyInjection.Extensions;

namespace Xo.TaskFlow.Extensions.DependencyInjection;

public static class TaskFlowServiceCollectionExtensions
{
    public static IServiceCollection AddTaskFlowExtensions(this IServiceCollection @this)
    {
        @this.AddTaskWorkflowEngineServices();
        return @this;
    }
}