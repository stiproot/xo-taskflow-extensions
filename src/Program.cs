// Expression<Action<int>> expr_ = (i) => Console.WriteLine(i);

// LambdaExpression lExpr_ = expr_;

// var compiledExpr  = lExpr_.Compile(); 

// var decompiled = compiledExpr as Action<int>;

// decompiled(1);

Expression<Action<IBranchFlowBuilder>> thenWithConfig = b => b.Then<IService>().With(c => c.RequireResult());

if(thenWithConfig.Body is MethodCallExpression expr)
{
    if(expr.Object is MethodCallExpression expr2)
    {
        var methodInfo = expr2.Method;
        Console.WriteLine(methodInfo.Name);
    }

    if(expr.Arguments.Any())
    {
        INodeConfigurationBuilder config = new NodeConfigurationBuilder();

        var action = FlowBuilder.GetLambdaExpr(expr.Arguments[0]);

        action(config);

        string s = string.Empty;
    }
}


// if(thenWithConfig.Body is MethodCallExpression expr)
// {
    // if(expr.Object is MethodCallExpression expr2)
    // {
        // var methodInfo = expr2.Method;
        // Console.WriteLine(methodInfo.Name);
    // }

    // if(expr.Arguments.Any())
    // {
        // if(expr.Arguments[0] is UnaryExpression unaryExpr)
        // {
            // if(unaryExpr.Operand is Expression expr3)
            // {
                // if(expr3 is LambdaExpression lExpr)
                // {
                    // // var mcx = lExpr.Body as MethodCallExpression;

                    // Action<IService> action = (lExpr.Compile() as Action<IService>)!;

                    // if(expr3 is MethodCallExpression mcExpr)
                    // {
                        // Console.WriteLine();
                    // }
                // }
            // }
            // //var methodInfo = methodCallExpr.Method;
        // }
    // }
// }


// var type = thenMethodInfo.GetGenericArguments().First();

//var methodCallExpression1 = (MethodCallExpression)thenWithConfig.Body;
//var genericArgument = methodCallExpression1.Method.GetGenericArguments().First();

//var methodCallExpression2 = (MethodCallExpression)((LambdaExpression)methodCallExpression1.Arguments[0]).Body;
//var invokedMethod = methodCallExpression2.Method;

return;

// [WORKS]
//var thenMethodInfo = ((thenWithConfig.Body as MethodCallExpression)!.Object as MethodCallExpression)!.Method;