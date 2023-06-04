internal class NodeConfiguration : INodeConfiguration
{
    public bool RequiresResult { get; set; }
    public string? NextParamName{ get; set; }
}