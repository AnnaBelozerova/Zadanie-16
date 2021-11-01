using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace _16._2_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Product v2.json";
            string json = File.ReadAllText(path);
                               

            dynamic array = JsonConvert.DeserializeObject(json);

            for (int i = 0; i < array.Count; i++)
            {

            }

            
            Console.WriteLine(array[1].CodeProduct);
            Console.ReadKey();
        }
        
        public class Товар
        {
            [JsonPropertyName("Код товара")]
            public uint CodeProduct { get; set; }
            [JsonPropertyName("Название товара")]
            public string NameProduct { get; set; }
            [JsonPropertyName("Цена товара")]
            public double PriceProduct { get; set; }
        }


    }
   

}
