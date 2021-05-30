using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static async Task Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //HttpClient client = new HttpClient(); // Створюємо клієн для відправки запросів
            //HttpResponseMessage response = await client.GetAsync("https://api.thecatapi.com/v1/images/search?breed_id=beng");
            //var json = await response.Content.ReadAsStringAsync();
            //Console.WriteLine($"Отримана відповідь - {json}");

            ICatAPI catApi = RestService.For<ICatAPI>("https://api.thecatapi.com");
            //List<CatInfoObject> catInfos = await catApi.GetCatDescription();
            //CatInfoObject firstCatInfo = catInfos[0];
            //string url = firstCatInfo.Url;

            //Console.WriteLine($"{firstCatInfo.Id}, { firstCatInfo.Url}, {firstCatInfo.Width}");

            //ProcessStartInfo procStartInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", url);
            //Process.Start(procStartInfo);

            List<Categories> catInfos = await catApi.GetCategories();

            foreach (var item in catInfos)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
        }
    }


    public interface ICatAPI
    {
        [Get("/v1/images/search")]
        Task<List<CatInfoObject>> GetCatPictureInfo();

        [Get("/v1/images/search?breed_id=beng")]
        Task<List<CatInfoObject>> GetCatDescription();

        [Get("/v1/categories")]
        Task<List<Categories>> GetCategories();

        
    }

    public class CatInfoObject
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("breeds")]
        public List<BreedInfo> BreedInfos { get; set; }
    }

    public class BreedInfo
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("wikipedia_url")]
        public string Wiki { get; set; }
    }

    public class Categories
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
