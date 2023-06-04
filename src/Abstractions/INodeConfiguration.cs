internal interface INodeConfiguration
{
    bool RequiresResult { get; set; }
    string? NextParamName{ get; set; }
}