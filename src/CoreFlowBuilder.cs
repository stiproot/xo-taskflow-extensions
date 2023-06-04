
internal abstract class CoreFlowBuilder : ICoreFlowBuilder 
{
    public virtual IFlowBuilder With(Expression<Action<INodeConfigurationBuilder>> config)
    {
        throw new NotImplementedException();
    }
}
