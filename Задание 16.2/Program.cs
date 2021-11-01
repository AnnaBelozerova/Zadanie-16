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


namespace Задание_16._2
{   //Самый дорогой товар
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Product.json";
            string json = File.ReadAllText(path);

            dynamic array = JsonConvert.DeserializeObject(json);
            double max=0;
            string name = "";

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].PriceProduct > max)
                {
                    max = array[i].PriceProduct;
                    name = array[i].NameProduct;
                }
            }


            Console.WriteLine("Название самого дорогого товара: {0}\nЕго цена: {1}",name,max);
            Console.ReadKey();

        }
        
    }   
    
}
