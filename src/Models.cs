internal interface INodeConfiguration
{
    bool RequiresResult { get; set; }
}

internal class NodeConfiguration : INodeConfiguration
{
    public bool RequiresResult { get; set; }
}