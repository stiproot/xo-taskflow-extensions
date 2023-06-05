internal class BranchFlowBuilder : CoreFlowBuilder, IBranchFlowBuilder
{
    public IBranchFlowBuilder Then<T>()
    {
        throw new NotImplementedException();
    }

    public IBranchFlowBuilder Then<T>(Action<INodeConfigurationBuilder> config)
    {
        var serviceType = typeof(T);

        var configBuilder = new NodeConfigurationBuilder();
        config(configBuilder);
        var configuration = configBuilder.Build();

        this._NodeBuilderFactory. 

        return this;
    }

    public IBranchFlowBuilder Else<T>()
    {
        throw new NotImplementedException();
    }

    public IBranchFlowBuilder Else<T>(Action<INodeConfigurationBuilder> config)
    {
        throw new NotImplementedException();
    }
}
