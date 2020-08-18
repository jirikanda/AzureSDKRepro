using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Azure.Storage.Blobs.BlobServiceClient serviceClient = new Azure.Storage.Blobs.BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=havittempstorage;AccountKey=/0000000000000000000000000000000000000000000000000000000000000000000000000000000000000==;EndpointSuffix=core.windows.net");
			Azure.Storage.Blobs.BlobContainerClient containerClient = serviceClient.GetBlobContainerClient("any_container");
			Azure.Storage.Blobs.BlobClient blobClient = containerClient.GetBlobClient("abc.txt");
			blobClient.Exists(); // just run the method
		}
	}
}