using System;

namespace SecretsSecrets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=aunsecuredstoragelf;AccountKey=E4NiFw9T8zXZWiSTVf6XCTjCnJH6Pfzry+rca1CQIohtW2qShXKUs9810qn0mEZds+GuKpW01cr8u4NklJGh8A==;EndpointSuffix=core.windows.net";
            Console.WriteLine("Hello World!");

            Azure.Storage.Blobs.BlobClient client = new Azure.Storage.Blobs.BlobClient(storageConnectionString, "test", "test");
        }
    }
}
