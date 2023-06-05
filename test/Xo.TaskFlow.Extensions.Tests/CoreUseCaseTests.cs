namespace Xo.TaskFlow.Extensions.Tests;

public class CoreUseCaseTests
{
    private readonly IServiceProvider _provider = ServiceProviderFactory.Create();
    private static CancellationToken NewCancellationToken() => new CancellationToken();

    [Fact]
    public async Task BinaryFlow()
    {
        var ct = NewCancellationToken();
        IFlowBuilder builder = _provider.Get<IFlowBuilder>();
        var flow = builder
            .FromRoot<IY_OutConstBool_SyncService>()
            .If<IY_InBool_OutBool_AsyncService>(
                b => b
                    .Then<IY_InBoolStr_OutConstInt_AsyncService>(
                        c => c
                            .RequireResult()
                            .AddArg("simon", "args")),
                b => b.Else<IService>(),
                c => c.RequireResult()
            );
        
        var node = flow.Build();
        var msg = await node.Run(ct);
        int data = (msg as Msg<int>)!.GetData();

        data.Should().Be(1);
    }
}