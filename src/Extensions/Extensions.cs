internal static class Extensions
{
    public static Type ServiceType(this Expression<Action<IBranchFlowBuilder>> @this)
    {
        return GetGenericType(@this);
    }

    public static Type GetGenericTypeParameter(this Type @this)
    {
        return @this.GenericTypeArguments.First();
    }

    public static Type GetGenericType(Expression<Action<IBranchFlowBuilder>> builder)
    {
        MethodCallExpression methodCallExpression = (MethodCallExpression)builder.Body;

        MethodInfo methodType = methodCallExpression.Method;

        Type genericArgument = methodType.GetGenericArguments().First();

        return genericArgument;
    }
}