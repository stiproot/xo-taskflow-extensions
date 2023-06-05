namespace Xo.TaskFlow.Extensions.Tests;

public class CoreUseCaseTests
{
    private readonly IServiceProvider _provider = ServiceProviderFactory.Create();

    [Fact]
    public void BinaryFlow()
    {
        var builder = _provider.GetService<IFlowBuilder>();

        var flow2 = builder
            .FromRoot<IService>()
            .If<IService>(
                b => b
                    .Then<IService>(c => c.RequireResult().NextParam("some_param_name")),
                b => b
                    .Else<IService>()
            );




    }
}