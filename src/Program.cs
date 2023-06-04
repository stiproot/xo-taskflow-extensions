IFlowBuilder builder = new FlowBuilder();

var flow = builder
    .FromRoot<IService>()
    .If<IService>(
        b => b
            .Then<IService>()
            .With(c => c.RequireResult()), 
        b => b
            .Else<IService>()
    )
        .With(c => c.RequireResult());

