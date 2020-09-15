using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;
namespace JsonNewtonSoft
{
    class Product
    {
        public DateTime ExpiryDate { set; get; }  //.......ExpiryDate property
    }
    class Program
    {

        static void Main(string[] args)
        {
            Product product = new Product() { ExpiryDate = new DateTime(2020, 08,21) };
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"E:\JsonFile.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
            }
            Console.WriteLine("Done");
        }
    }
}
