namespace EmptyObjectRepro
{
    public class GetVersionResponse
    {
        public GetVersionResponse(string version)
        {
            Version = version;
        }

        public string Version { get; set; }
    }
}
