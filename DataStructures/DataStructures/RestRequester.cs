using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
//using System.

namespace DataStructures
{
    class RestRequester
    {
        public static void Main1()
        {
            Challenge();
            GetParagraphAndReturnCount();

        }

        public static void GetParagraphAndReturnCount()
        {
            Uri getUri = new Uri("https://http-hunt.thoughtworks-labs.net/challenge/input");
            WebRequest request = WebRequest.Create(getUri);
            request.ContentType = "application/json";
            request.Method = "GET";
            request.Headers.Add("userId", "rNg2Ap4S");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            WebResponse response = request.GetResponse();
            int paraCharCount = -1;
            int paraWords = -1;
            int sentancesCount = 0;
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream responseStream = response.GetResponseStream();
            var output = new response();
            output.output = new output();
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                paraCharCount = responseFromServer.Length;

                // Display the content.  
                var x = JsonConvert.DeserializeObject<input>(responseFromServer);
                paraWords = x.text.Split(' ').Length;
                Console.WriteLine(responseFromServer);
                x.text = x.text + " ";
                x.text = x.text.ToLower();
                
                for (int i=0;i< x.text.Length;i++)
                {
                    if(x.text[i]=='a')
                    {
                        output.output.a++;
                    }
                    else if(x.text[i] == 'e')
                    {
                        output.output.e++;
                    }
                    else if (x.text[i] == 'i')
                    {
                        output.output.i++;
                    }
                    else if (x.text[i] == 'o')
                    {
                        output.output.o++;
                    }
                    else if (x.text[i] == 'u')
                    {
                        output.output.u++;
                    }
                }
                //sentancesCount = Regex.Matches(x.text, @"? ").Count + Regex.Matches(x.text, @". ").Count;
            }

            Uri postUri = new Uri("https://http-hunt.thoughtworks-labs.net/challenge/output");
            WebRequest postRequest = WebRequest.Create(postUri);
            postRequest.ContentType = "application/json";
            //postRequest.Acc = "application/json";
            postRequest.Method = "POST";
            postRequest.Headers.Add("userId", "rNg2Ap4S");
            postRequest.Headers.Add("Accept", "application/json");
            Stream dataStreamPost = postRequest.GetRequestStream();

            
            //output.output.sentenceCount = sentancesCount;
            var content = JsonConvert.SerializeObject(output);
            byte[] byteArray = Encoding.ASCII.GetBytes(content);
            dataStreamPost.Write(byteArray, 0, byteArray.Length);
            dataStreamPost.Close();
            response = postRequest.GetResponse();
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds);
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            responseStream = response.GetResponseStream();
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                paraCharCount = responseFromServer.Length;
                // Display the content.  
                Console.WriteLine(responseFromServer);
            }

        }
        private static void Challenge()
        {
            Uri uri = new Uri("https://http-hunt.thoughtworks-labs.net/challenge");

            WebRequest request = WebRequest.Create(uri);
            request.ContentType = "application/json";
            request.Method = "GET";
            request.Headers.Add("userId", "rNg2Ap4S");

            //Stream dataStream = request.GetRequestStream();

            //Employee e = new Employee();
            //e.name = "Abcde";
            //e.salary = 1234567;
            //e.age = 27;

            //var content = JsonConvert.SerializeObject(e);
            //byte[] byteArray = Encoding.ASCII.GetBytes(content);
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //dataStream.Close();



            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream responseStream = response.GetResponseStream();
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                Console.WriteLine(responseFromServer);
            }

            response.Close();
            Console.WriteLine(responseStream);
        }

    }

    class Employee
    {
        public String name { get; set; }
        public int salary { get; set; }
        public int age { get; set; }
    }
    
    class output
    {
        public int a { get; set; }
        public int e { get; set; }
        public int i { get; set; }
        public int o { get; set; }
        public int u { get; set; }
    }
    class response
    {
        public output output { get; set; }
    }

    public class input
    {
        public string text { get; set; }
    }


}
