namespace Xo.TaskFlow.Extensions.Abstractions;

public interface INodeConfigurationBuilder
{
    INodeConfigurationBuilder RequireResult();
    INodeConfigurationBuilder NextParam(string nextParamName);
    INodeConfiguration Build();
}