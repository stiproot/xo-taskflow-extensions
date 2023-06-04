internal interface IBranchFlowBuilder : ICoreFlowBuilder
{
    IBranchFlowBuilder Then<T>();
    IBranchFlowBuilder Else<T>();
}