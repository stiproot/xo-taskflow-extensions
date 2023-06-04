﻿IFlowBuilder builder = new FlowBuilder();

// example of a Binary branch's `then` lambda...
Expression<Action<IBranchFlowBuilder>> thenWithConfig = b => b.Then<IService>().With(c => c.RequireResult());

// lab: metadata inspection...
if(thenWithConfig.Body is MethodCallExpression expr)
{
    if(expr.Object is MethodCallExpression mcExpr)
    {
        var methodInfo = mcExpr.Method;
        Console.WriteLine(methodInfo.Name);
    }

    if(expr.Arguments.Any())
    {
        INodeConfigurationBuilder configBuilder = new NodeConfigurationBuilder();

        Action<INodeConfigurationBuilder> action = FlowBuilder.GetLambdaExpr(expr.Arguments[0]);

        action(configBuilder);

        var config = configBuilder.Build();

        Console.WriteLine(JsonSerializer.Serialize(config));
    }
}
