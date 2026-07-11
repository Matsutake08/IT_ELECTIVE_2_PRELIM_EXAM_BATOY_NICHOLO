using IT_ELECTIVE_2_PRELIM_EXAM.Interfaces;

namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

public class MealRecipe : RecipeBase, IRecipeSearchable
{
    public string Category { get; set; }
    public string Area { get; set; }

    public MealRecipe(string title, int prepTime, string area) : base(title, prepTime, "Meal Description")
    {
        Category = "Pasta";
        Area = area;
    }

    public string SearchCriteria => Title;

    public override string GetRecipeInfo() => $"Category: {Category}";

    public bool MatchesSearch(string searchTerm)
    {
        return Title.Contains(searchTerm, System.StringComparison.OrdinalIgnoreCase);
    }
}