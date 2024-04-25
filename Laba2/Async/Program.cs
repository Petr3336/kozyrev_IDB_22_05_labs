using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        //Версия 2: Асинхронные запросы
        Console.WriteLine("\nВерсия 2: Асинхронные запросы");
        using (var client = new HttpClient())
        {
            try
            {
                var task1 = client.GetAsync("http://localhost:3000/Test1/");
                var task2 = client.GetAsync("http://localhost:3000/Test2/");
                var task3 = client.GetAsync("http://localhost:3000/Test3/");
        
                await Task.WhenAll(task1, task2, task3);

                Console.WriteLine("1 Ссылка");
                Console.WriteLine(await (await task1).Content.ReadAsStringAsync());
                Console.WriteLine("2 Ссылка");
                Console.WriteLine(await (await task2).Content.ReadAsStringAsync());
                Console.WriteLine("3 Ссылка");
                Console.WriteLine(await (await task3).Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
