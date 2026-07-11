using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class SearchMealByName
{
    public static async Task Run(HttpClient client)
    {
        string url = "https://www.themealdb.com/api/json/v1/1/search.php?s=Arrabiata";
        var response = await client.GetAsync(url);
        string body = await response.Content.ReadAsStringAsync();
        using (JsonDocument doc = JsonDocument.Parse(body))
        {
            var mealsArray = doc.RootElement.GetProperty("meals");
            int count = mealsArray.GetArrayLength();
        }
    }
}