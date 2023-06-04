internal interface IFlowBuilder : ICoreFlowBuilder
{
    IFlowBuilder FromRoot<T>();
    IFlowBuilder If<T>(
        Expression<Action<IBranchFlowBuilder>> then, 
        Expression<Action<IBranchFlowBuilder>> @else
    );
}