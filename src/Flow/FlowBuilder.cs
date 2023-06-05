internal class FlowBuilder : IFlowBuilder
{
    public IFlowBuilder FromRoot<T>()
    {
        throw new NotImplementedException();
    }

    //public IFlowBuilder If<T>(
        //Expression<Action<IFlowBuilder>> then, 
        //Expression<Action<IFlowBuilder>> @else
    //)
    //{
        //var serviceType = typeof(T);

        //throw new NotImplementedException();
    //}

    public IFlowBuilder If<T>(
        Action<IFlowBuilder> then, 
        Action<IFlowBuilder> @else
    )
    {
        var serviceType = typeof(T);

        //  
        var thenBuilder = new FlowBuilder();
        then(thenBuilder);
        var thenNode = thenBuilder.Build();

        var elseBuilder = new FlowBuilder();
        @else(elseBuilder);
        var elseNode = elseBuilder.Build();

        return this;
    }

    public IFlowBuilder Then<T>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Then<T>(Action<INodeConfigurationBuilder> config)
    {
        var serviceType = typeof(T);

        var configBuilder = new NodeConfigurationBuilder();
        config(configBuilder);
        var configuration = configBuilder.Build();

        // this._NodeBuilderFactory.

        return this;
    }

    public IFlowBuilder Else<T>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Else<T>(Action<INodeConfigurationBuilder> config)
    {
        throw new NotImplementedException();
    }

    public virtual IFlowBuilder With(Expression<Action<INodeConfigurationBuilder>> config)
    {
        throw new NotImplementedException();
    }

    public virtual INode Build() => throw new NotImplementedException(); 

}
