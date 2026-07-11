namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

public class Meal
{
    private string _name;
    private string _category;
    private string _area;

    public Meal(string name, string category, string area)
    {
        _name = name;
        _category = category;
        _area = area;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Category
    {
        get => _category;
        set => _category = value;
    }

    public string Area
    {
        get => _area;
        set => _area = value;
    }
}