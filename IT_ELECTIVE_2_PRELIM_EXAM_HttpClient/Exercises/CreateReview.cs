using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class CreateReview
{
    public static async Task Run(HttpClient client)
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        string jsonBody = "{\"title\":\"Great Meal\",\"body\":\"It was delicious!\",\"userId\":1}";
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(url, content);
        string responseBody = await response.Content.ReadAsStringAsync();
        using (JsonDocument doc = JsonDocument.Parse(responseBody))
        {
            var id = doc.RootElement.GetProperty("id").GetInt32();
        }
    }
}