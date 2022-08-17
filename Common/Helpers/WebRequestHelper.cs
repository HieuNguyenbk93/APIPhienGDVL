using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class WebRequestHelper
    {
        public static string SendTextFirebaseRequest(string url, object data, string method = "post")
        {
            try
            {
                // Create a request using a URL that can receive a post.   
                WebRequest request = WebRequest.Create(url);
                var myHttpWebRequest = (HttpWebRequest)request;
                myHttpWebRequest.PreAuthenticate = true;
                myHttpWebRequest.Headers.Add("Authorization", "key=AAAAWmC4Coo:APA91bHyZK2bu7--OXfzWA2Fjy4dmGvBsOy8qAfhAXX8vLtv4MYYtKcrRGBGYGWkbwV5fLyDdzQnP43558ePq7LBd4LK0Mf9oWn0KBZiR8S_u21kbMvZsWahanapR4qVCZMlrSzzqqt6");
                myHttpWebRequest.Accept = "application/json";
                // Set the Method property of the request to POST.  
                myHttpWebRequest.Method = method;
                // Create POST data and convert it to a byte array.  
                string postData = null;
                if (data.GetType() == typeof(string))
                {
                    postData = data.ToString();
                }
                else
                {
                    postData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                }
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Set the ContentType property of the WebRequest.  
                myHttpWebRequest.ContentType = "application/json";
                // Set the ContentLength property of the WebRequest.  
                myHttpWebRequest.ContentLength = byteArray.Length;

                // Get the request stream.  
                Stream dataStream = myHttpWebRequest.GetRequestStream();
                // Write the data to the request stream.  
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.  
                dataStream.Close();

                // Get the response.  
                WebResponse response = myHttpWebRequest.GetResponse();

                // Get the stream containing content returned by the server.  
                // The using block ensures the stream is automatically closed.
                string contentAll = "";
                using (dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.  
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.  
                    contentAll = reader.ReadToEnd();
                }
                // Close the response.  
                response.Close();
                return contentAll;
            }
            catch (Exception)
            {

            }
            return "";
        }
    }
}
