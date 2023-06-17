namespace Microsoft
{
    internal class Data
    {
        internal class SqlClient
        {
            internal class SqlConnectionStringBuilder
            {
                private string udlContent;

                public SqlConnectionStringBuilder()
                {
                }

                public SqlConnectionStringBuilder(string udlContent)
                {
                    this.udlContent = udlContent;
                }

                public string SqlConnectionString { get; internal set; }
                public string ConnectionString { get; internal set; }
            }
        }
    }
}