namespace Xo.TaskFlow.Extensions.Tests;

public class ComplexUseCaseTests
{
    private readonly IServiceProvider _provider = ServiceProviderFactory.Create();
    private static CancellationToken NewCancellationToken() => new CancellationToken();

    [Fact]
    public async Task ComplexFlow()
    {
        var ct = NewCancellationToken();
        IFlowBuilder builder = _provider.Get<IFlowBuilder>();

        var flow = builder
            .Root<IY_InBoolStr_OutConstInt_AsyncService>(
                arg => arg.Node<IY_OutConstBool_SyncService>(), 
                c => c.AddArg("simon", "args")
            )
            .If<IY_InInt_OutBool_SyncService>(
                b => b
                    .Then<IY_InBoolStr_OutConstInt_AsyncService>(c => c.RequireResult().AddArg("simon", "args"))
                    .Then<IY_InInt_OutBool_SyncService>(c => c.RequireResult())
                    .Pool<IY_InBool_OutBool_AsyncService, IY_InObjBool_OutStr_AsyncService, IY_InStr_AsyncService>(),
                b => b.Else<IService>(),
                c => c.RequireResult()
            );

        var node = flow.Build();
        var msg = await node.Run(ct);
        int data = (msg as Msg<int>)!.GetData();

        data
            .Should()
            .Be(1);
    }
}