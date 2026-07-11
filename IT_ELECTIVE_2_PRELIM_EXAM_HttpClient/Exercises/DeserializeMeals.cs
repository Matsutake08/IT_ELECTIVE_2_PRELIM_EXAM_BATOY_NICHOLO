using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises
{
    public class DeserializeMeals
    {
        public static async Task Run(HttpClient client)
        {
            string url = "https://www.themealdb.com/api/json/v1/1/search.php?f=a";

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string body = await response.Content.ReadAsStringAsync();

            using (JsonDocument doc = JsonDocument.Parse(body))
            {
                var mealsArray = doc.RootElement.GetProperty("meals");

                if (mealsArray.GetArrayLength() > 0)
                {
                    foreach (JsonElement meal in mealsArray.EnumerateArray())
                    {
                        Console.WriteLine(meal.GetProperty("strMeal").GetString());
                    }
                }
                else
                {
                    throw new Exception("The meals array is empty.");
                }
            }
        }
    }
}