using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Версия 1: Синхронные запросы
        Console.WriteLine("Версия 1: Синхронные запросы");
        using (var client = new HttpClient())
        {
            try
            {
                var response1 = client.GetAsync("http://localhost:3000/Test1/").Result;
                Console.WriteLine("1 Ссылка");
                Console.WriteLine(await response1.Content.ReadAsStringAsync());

                var response2 = client.GetAsync("http://localhost:3000/Test2/").Result;
                Console.WriteLine("2 Ссылка");
                Console.WriteLine(await response2.Content.ReadAsStringAsync());
                
                var response3 = client.GetAsync("http://localhost:3000/Test3/").Result;
                Console.WriteLine("3 Ссылка");
                Console.WriteLine(await response3.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
