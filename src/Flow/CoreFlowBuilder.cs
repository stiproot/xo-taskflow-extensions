
internal abstract class CoreFlowBuilder : ICoreFlowBuilder 
{
    protected readonly INodeBuilderFactory _NodeBuilderFactory;
    protected INode _Node;

    public virtual IFlowBuilder With(Expression<Action<INodeConfigurationBuilder>> config)
    {
        throw new NotImplementedException();
    }

    public virtual INode Build() => this._Node;
}
