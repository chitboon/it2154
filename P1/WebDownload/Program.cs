using System;
using System.Net;
using System.IO;
namespace WebDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2) {
                Console.WriteLine("Usage: WebDownload <url> <filename>");
            } else {
                string url = args[0];
                string filename = args[1];
                Console.WriteLine($"input_url = {url}, output_file = {filename}" );
                // TODO:
                // 1. open the URL and get the response
                // 2. write the response into the file.

                var uriBuilder = new UriBuilder(url);
                Uri uri = uriBuilder.Uri;
                WebRequest request = WebRequest.Create(uri);
                using (WebResponse response = request.GetResponse())
                {
                    if (!File.Exists(filename))
                    {
                        using (StreamWriter sw = File.CreateText(filename))
                        {
                            var reader = new StreamReader(response.GetResponseStream());
                            string s = reader.ReadToEnd();
                            sw.WriteLine(s);
                        }
                    } else { 
                        Console.WriteLine($"File {filename} already existed.");
                    }
                }
            }

        }
    }
}
