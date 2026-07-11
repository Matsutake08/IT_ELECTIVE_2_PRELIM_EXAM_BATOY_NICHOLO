using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class GetCategories
{
    public static async Task Run(HttpClient client)
    {
        string url = "https://www.themealdb.com/api/json/v1/1/lookup.php?i=52771";
        var response = await client.GetAsync(url);
        string body = await response.Content.ReadAsStringAsync();
        using (JsonDocument doc = JsonDocument.Parse(body))
        {
            var categoriesArray = doc.RootElement.GetProperty("meals");
            int count = categoriesArray.GetArrayLength();
        }
    }
}
