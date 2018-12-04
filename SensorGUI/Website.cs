﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SensorGUI
{
    class Website
    {
        public Website()
        {

        }

        public string SendWebsiteData(string url, string data)
        {
            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create(url);
            // Set the Method property of the request to POST.  
            request.Method = "POST";
            // Create POST data and convert it to a byte array.  
            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            // Set the ContentType property of the WebRequest.  
            request.ContentType = "text/plain";
            // Set the credentials for the Http post
            request.Credentials = CredentialCache.DefaultCredentials;
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Clean up the streams.  
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }
    }
}
