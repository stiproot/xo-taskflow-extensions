namespace Xo.TaskFlow.Extensions.Builders;

public class FlowBuilder : IFlowBuilder
{
    public IFlowBuilder Root<T>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Root<T>(Action<INodeConfigurationBuilder> config)
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Root<T>(Action<IFlowBuilder> arg)
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Root<T>(
        Action<IFlowBuilder> arg,
        Action<INodeConfigurationBuilder> config
    )
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Arg<T>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Arg(Action<IFlowBuilder> arg)
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Arg<T>(Action<INodeConfigurationBuilder> config)
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder AsArg<T>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder AsArgs<T, U, V>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder If<T>(
        Action<IFlowBuilder> then,
        Action<IFlowBuilder> @else
    )
    {
        var serviceType = typeof(T);

        var thenBuilder = new FlowBuilder();
        then(thenBuilder);
        var thenNode = thenBuilder.Build();

        var elseBuilder = new FlowBuilder();
        @else(elseBuilder);
        var elseNode = elseBuilder.Build();

        return this;
    }

    public IFlowBuilder If<T, TResolver>(
        Action<IFlowBuilder> then,
        Action<IFlowBuilder> @else
    )
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder If<T>(
        Action<IFlowBuilder> then,
        Action<IFlowBuilder> @else,
        Action<INodeConfigurationBuilder> config
    )
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder If<T, TResolver>(
        Action<IFlowBuilder> then,
        Action<IFlowBuilder> @else,
        Action<INodeConfigurationBuilder> config
    )
    {
        throw new NotImplementedException();
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

    public IFlowBuilder Pool<T, U, V>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Next<T>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Hash<T, U, V>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder Node<T>()
    { 
        throw new NotImplementedException(); 
    }

    public IFlowBuilder Node<T>(Action<INodeConfigurationBuilder> config)
    { 
        throw new NotImplementedException(); 
    }

    public virtual IFlowBuilder With(Expression<Action<INodeConfigurationBuilder>> config)
    {
        throw new NotImplementedException();
    }

    public virtual INode Build() => throw new NotImplementedException();
}
