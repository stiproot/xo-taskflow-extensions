internal class FlowBuilder : IFlowBuilder
{
    public IFlowBuilder FromRoot<T>()
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder With(Expression<Action<INodeConfigurationBuilder>> config)
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder If<T>(
        Expression<Action<IBranchFlowBuilder>> then, 
        Expression<Action<IBranchFlowBuilder>> @else
    )
    {
        throw new NotImplementedException();
    }

    public IFlowBuilder _If<T>(
        Action<IBranchFlowBuilder> then, 
        Action<IBranchFlowBuilder> @else
    )
    {
        var serviceType = typeof(T);



    }

    public static Action<INodeConfigurationBuilder> GetLambdaExpr(Expression expr)
    {
        return expr switch
        {
            UnaryExpression _expr => GetLambdaExpr(_expr.Operand),
            LambdaExpression _expr => _expr.Compile() as Action<INodeConfigurationBuilder>, 
            _ => throw new NotSupportedException()
        };
    }
}
