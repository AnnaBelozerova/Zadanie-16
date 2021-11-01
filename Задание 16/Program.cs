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


namespace Задание_16
{   //Запись информации о товарах
    class Program
    {
        static void Main(string[] args)
        {

            Товар[] товар = new Товар[5];
            
            for (int i = 0; i < 5; i++)
            {
                товар[i] = new Товар();
                Console.Write("Введите код товара: ");
                товар[i].CodeProduct = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Введите название товара: ");
                товар[i].NameProduct = Console.ReadLine();
                Console.Write("Введите цену товара: ");
                товар[i].PriceProduct = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
            
            string jsonString = JsonConvert.SerializeObject(товар, Formatting.Indented);
            string path = @"D:\Product.json";
            File.WriteAllText(path, jsonString);          
            
            Console.ReadKey();
        }
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
