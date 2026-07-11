using System.Net.Http;
using System.Threading.Tasks;

public class DeleteReview
{
    public static async Task Run(HttpClient client)
    {
        string url = "https://jsonplaceholder.typicode.com/posts/1";
        var response = await client.DeleteAsync(url);
        response.EnsureSuccessStatusCode();
    }
}