internal interface IFlowBuilder : ICoreFlowBuilder
{
    IFlowBuilder FromRoot<T>();
    IFlowBuilder If<T>(
        Expression<Action<IBranchFlowBuilder>> then, 
        Expression<Action<IBranchFlowBuilder>> @else
    );
}

internal interface IBranchFlowBuilder : ICoreFlowBuilder
{
    IBranchFlowBuilder Then<T>();
    IBranchFlowBuilder Else<T>();
}

internal interface ICoreFlowBuilder 
{
    IFlowBuilder With(Expression<Action<INodeConfigurationBuilder>> config);
}

internal interface INodeConfigurationBuilder
{
    INodeConfigurationBuilder RequireResult();
    INodeConfiguration Build();
}

internal class NodeConfigurationBuilder : INodeConfigurationBuilder
{
    private readonly INodeConfiguration _config = new NodeConfiguration();

    public INodeConfigurationBuilder RequireResult()
    {
        this._config.RequiresResult = true;
        return this;
    }

    public INodeConfiguration Build() => this._config;
}