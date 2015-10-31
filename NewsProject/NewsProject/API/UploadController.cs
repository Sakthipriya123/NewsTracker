using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NewsProject.API
{
    public class UploadController : ApiController
    {
        public async Task<IHttpActionResult> PostFile()
        {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                return StatusCode(HttpStatusCode.UnsupportedMediaType);
            }

            string root = HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                // Read the form data and return an async task.
                await Request.Content.ReadAsMultipartAsync(provider);
                var storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);
                var blobClient = storageAccount.CreateCloudBlobClient();

                //GET (OR CREATE) a blob container
                var container = blobClient.GetContainerReference("mycontainer");
                container.CreateIfNotExists();

                //create a blog
                
               

                    foreach (var file in provider.FileData)
                {
                    var blob = container.GetBlockBlobReference(file.Headers.ContentDisposition.FileName);
                    blob.UploadFromFile(file.LocalFileName,FileMode.Open);
                }
                
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
