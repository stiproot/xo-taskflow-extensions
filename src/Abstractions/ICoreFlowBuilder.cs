internal interface ICoreFlowBuilder 
{
    IFlowBuilder With(Expression<Action<INodeConfigurationBuilder>> config);
}