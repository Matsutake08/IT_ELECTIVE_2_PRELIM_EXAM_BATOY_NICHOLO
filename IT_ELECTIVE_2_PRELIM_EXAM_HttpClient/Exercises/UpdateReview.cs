using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class UpdateReview
{
    public static async Task Run(HttpClient client)
    {
        string url = "https://jsonplaceholder.typicode.com/posts/1";
        string jsonBody = "{\"id\":1,\"title\":\"Updated Meal Review\",\"body\":\"Updated body text\",\"userId\":1}";
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        var response = await client.PutAsync(url, content);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        using (JsonDocument doc = JsonDocument.Parse(responseBody))
        {
            var returnedTitle = doc.RootElement.GetProperty("title").GetString();
        }
    }
}