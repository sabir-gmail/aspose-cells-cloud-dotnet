﻿
namespace Aspose.Cells.Cloud.SDK.Test
{
    using NUnit.Framework;

    using Aspose.Cells.Cloud.SDK.Client;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    using Com.Aspose.Storage.Api;
    using System.IO;
    using System.Collections.Generic;
    public class CellsBaseTest
    {
        protected ApiClient client;
        protected Configuration config;
        protected static OAuthApi oauth2 =null;
        protected string grantType = "client_credentials";
        protected string clientId = "66164C51-693E-4904-A121-545961673EC1";
        protected string clientSecret = "536e76768419db9585afdd37bb5f7533";
        protected static string accesstoken;
        protected string refreshtoken;
        protected string BOOK1 = "Book1.xlsx";
        protected string MYDOC = "myDocument.xlsx";
        protected string PivTestFile = "TestCase.xlsx";
        protected string TEMPFOLDER = "Temp";
        protected string SHEET1 = "Sheet1";
        protected string SHEET2 = "Sheet2";
        protected string SHEET3 = "Sheet3";
        protected string SHEET4 = "Sheet4";
        protected string SHEET5 = "Sheet5";
        protected string SHEET6 = "Sheet6";
        protected string SHEET7 = "Sheet7";
        protected string SHEET8 = "Sheet8";
        protected string CellName = "A1";
        protected string RANGE = "A1:C10";
        protected string CELLAREA = "A1:C10";
        protected StorageApi storageApi;
        private string TestDataFolder = @"D:\Projects\Aspose\Aspose for Cloud\Aspose.Cells for Cloud SDK\src\TestData\";
        protected void UpdateDataFile( string folder, string filename)
        {
            this.storageApi = new StorageApi( clientSecret, clientId, "https://api.aspose.cloud/v1.1");
            if(string.IsNullOrEmpty(folder))
            {
                this.storageApi.DeleteFile( filename, null, null);
                this.storageApi.PutCreate(filename, null, null, File.ReadAllBytes(TestDataFolder + filename));

            }
            else
            {
                this.storageApi.DeleteFile(folder + "/" + filename, null, null);
                this.storageApi.PutCreate(folder + "/" + filename, null, null, File.ReadAllBytes(TestDataFolder + filename));

            }
        }
        protected Stream GetTestDataStream( string filename)
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter writer = new StreamWriter(ms);
            writer.Write(System.Text.Encoding.Default.GetString(File.ReadAllBytes(TestDataFolder + filename)));
            writer.Flush();
            ms.Position = 0;
            return ms;
        }
        protected byte[] GetTestDataByteArray(string filename)
        {
            return File.ReadAllBytes(TestDataFolder + filename);
        }
        protected Configuration GetConfiguration()
        {
            if (oauth2 == null)
            {
                oauth2 = new OAuthApi("https://api.aspose.cloud");
                var oauth2response = oauth2.OAuthPost(grantType, clientId, clientSecret);
                accesstoken = oauth2response.AccessToken;
                refreshtoken = oauth2response.RefreshToken;
            }
            Dictionary<string, string> headerParameters = new Dictionary<string, string>();
            headerParameters.Add("Authorization", "Bearer " + accesstoken);
            client = new ApiClient();
            config = new Configuration(client, headerParameters);
            return config;
        }
    }
}
