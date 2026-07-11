using System.Collections.Generic;
using IT_ELECTIVE_2_PRELIM_EXAM.Models;

namespace IT_ELECTIVE_2_PRELIM_EXAM.Services;

public class RecipeBook
{
    private List<Meal> _meals = new List<Meal>();

    public string Name { get; set; } = "";
    public int Capacity { get; set; }

    public RecipeBook(string name) : this(name, 10) { }

    public RecipeBook(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }

    public void AddMeal(Meal meal) => _meals.Add(meal);

    public List<Meal> Search(string name, string category) => _meals;

    public List<Meal> Search(string text) => _meals;
}