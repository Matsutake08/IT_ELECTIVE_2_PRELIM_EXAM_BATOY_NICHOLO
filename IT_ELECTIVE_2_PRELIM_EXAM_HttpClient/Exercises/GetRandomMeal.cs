using System.Net.Http;
using System.Threading.Tasks;

public class GetRandomMeal
{
    public static async Task Run(HttpClient client)
    {
        string url = "https://www.themealdb.com/api/json/v1/1/random.php";
        var response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();

        string body = await response.Content.ReadAsStringAsync();
        bool isBodyEmpty = string.IsNullOrWhiteSpace(body);
    }
}