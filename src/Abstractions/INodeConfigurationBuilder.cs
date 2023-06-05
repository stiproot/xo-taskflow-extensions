internal interface INodeConfigurationBuilder
{
    INodeConfigurationBuilder RequireResult();
    INodeConfigurationBuilder NextParam(string nextParamName);
    INodeConfiguration Build();
}