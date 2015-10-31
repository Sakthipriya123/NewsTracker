using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsProject.API
{
    public class BlobController : ApiController
    {
        //public IHttpActionResult Get(string message)
        //{
        //    var storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);
        //    var blobClient = storageAccount.CreateCloudBlobClient();

        //    //GET (OR CREATE) a blob container
        //    var container = blobClient.GetContainerReference("mycontainer");
        //    container.CreateIfNotExists();

        //    //create a blog
        //    var blob = container.GetBlockBlobReference("myblob");
        //    blob.UploadText(message);

        //    return Ok();
        }
    }

