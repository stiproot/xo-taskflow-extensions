internal class NodeConfigurationBuilder : INodeConfigurationBuilder
{
    private readonly INodeConfiguration _config = new NodeConfiguration();

    public INodeConfigurationBuilder RequireResult()
    {
        this._config.RequiresResult = true;
        return this;
    }

    public INodeConfigurationBuilder NextParam(string nextParamName)
    {
        this._config.NextParamName = nextParamName;
        return this;
    }

    public INodeConfiguration Build() => this._config;
}