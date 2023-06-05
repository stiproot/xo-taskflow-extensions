internal interface IBranchFlowBuilder : ICoreFlowBuilder
{
    IBranchFlowBuilder Then<T>();
    IBranchFlowBuilder Then<T>(Action<INodeConfigurationBuilder> config);
    IBranchFlowBuilder Else<T>();
    IBranchFlowBuilder Else<T>(Action<INodeConfigurationBuilder> config);
}