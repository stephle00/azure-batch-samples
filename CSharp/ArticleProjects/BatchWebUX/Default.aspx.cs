using System;

using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Blob; // Namespace for Blob storage types
using Microsoft.WindowsAzure;
using Microsoft.Azure;


namespace BatchWebUX
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void Button1_Click(object sender, EventArgs e)
        {


            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();


            // Use the blob client to create the containers in Azure Storage if they don't yet exist
            const string appContainerName = "application";
            const string inputContainerName = "input";
            const string outputContainerName = "output";


            CloudBlobContainer application = blobClient.GetContainerReference(appContainerName);
            application.CreateIfNotExists();
            CloudBlobContainer input = blobClient.GetContainerReference(inputContainerName);
            input.CreateIfNotExists();
            CloudBlobContainer output = blobClient.GetContainerReference(outputContainerName);
            output.CreateIfNotExists();

            
            if (this.FileUpload1.HasFile)
            {

                string uniqueBlobName = FileUpload1.FileName;
               
                CloudBlockBlob blob = input.GetBlockBlobReference(uniqueBlobName);
               
                blob.Properties.ContentType = FileUpload1.PostedFile.ContentType;
                blob.UploadFromStream(FileUpload1.FileContent);
             
                System.Diagnostics.Trace.TraceInformation("Uploaded file '{0}' to blob storage as '{1}'", this.FileUpload1.FileName, uniqueBlobName);

                uploadStatusLabel.Text = "Sucessfully uploaded file " + uniqueBlobName; 

            }

        }
    }
}

    
