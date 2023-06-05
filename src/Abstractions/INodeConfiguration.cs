namespace Xo.TaskFlow.Extensions.Abstractions;

public interface INodeConfiguration
{
    bool RequiresResult { get; set; }
    string? NextParamName{ get; set; }
}