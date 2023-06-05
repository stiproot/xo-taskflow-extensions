internal class FlowBuilder : CoreFlowBuilder, IFlowBuilder
{
    public IFlowBuilder FromRoot<T>()
    {
        throw new NotImplementedException();
    }

    //public IFlowBuilder If<T>(
        //Expression<Action<IBranchFlowBuilder>> then, 
        //Expression<Action<IBranchFlowBuilder>> @else
    //)
    //{
        //var serviceType = typeof(T);

        //throw new NotImplementedException();
    //}

    public IFlowBuilder If<T>(
        Action<IBranchFlowBuilder> then, 
        Action<IBranchFlowBuilder> @else
    )
    {
        var serviceType = typeof(T);

        //  
        var thenBuilder = new BranchFlowBuilder();
        then(thenBuilder);
        var thenNode = thenBuilder.Build();

        var elseBuilder = new BranchFlowBuilder();
        @else(elseBuilder);
        var elseNode = elseBuilder.Build();

        return this;
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
