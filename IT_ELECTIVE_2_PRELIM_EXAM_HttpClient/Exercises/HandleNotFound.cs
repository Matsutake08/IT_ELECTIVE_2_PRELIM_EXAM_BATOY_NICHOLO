using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class HandleNotFound
{
    public static async Task Run(HttpClient client)
    {
        string url = "https://www.themealdb.com/api/json/v1/1/lookup.php?i=52771";
        var response = await client.GetAsync(url);
        string body = await response.Content.ReadAsStringAsync();
        using (JsonDocument doc = JsonDocument.Parse(body))
        {
            if (doc.RootElement.TryGetProperty("meals", out JsonElement mealsElement) && mealsElement.ValueKind != JsonValueKind.Null)
            {
                var mealName = mealsElement[0].GetProperty("strMeal").GetString();
            }
            else
            {
                
            }
        }
    }
}
