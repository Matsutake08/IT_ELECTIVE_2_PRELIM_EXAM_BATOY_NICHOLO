namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

public abstract class RecipeBase
{
    public string Title { get; set; }
    public int PrepTime { get; set; }
    public string Description { get; set; }
    public int MaxMinutes { get; set; }

    protected RecipeBase(string title, int prepTime, string description, int maxMinutes)
    {
        Title = title;
        PrepTime = prepTime;
        Description = description;
        MaxMinutes = maxMinutes;
    }

    public abstract string GetRecipeInfo();
}