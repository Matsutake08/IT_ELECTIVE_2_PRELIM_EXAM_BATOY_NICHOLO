namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

public class QuickRecipe : RecipeBase
{
    public QuickRecipe(string title, int prepTime, string description, int maxMinutes)
        : base(title, prepTime, description, maxMinutes)
    {
    }

    public override string GetRecipeInfo() => $"Quick - {Title}, max minutes: {MaxMinutes}";
}