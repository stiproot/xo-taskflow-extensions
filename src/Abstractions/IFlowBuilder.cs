﻿internal interface IFlowBuilder
{
    IFlowBuilder FromRoot<T>();

    IFlowBuilder With(Expression<Action<INodeConfigurationBuilder>> config);

    IFlowBuilder If<T>(
        Action<IFlowBuilder> then, 
        Action<IFlowBuilder> @else
    );

    IFlowBuilder Then<T>();
    IFlowBuilder Then<T>(Action<INodeConfigurationBuilder> config);
    IFlowBuilder Else<T>();
    IFlowBuilder Else<T>(Action<INodeConfigurationBuilder> config);

    INode Build();
}