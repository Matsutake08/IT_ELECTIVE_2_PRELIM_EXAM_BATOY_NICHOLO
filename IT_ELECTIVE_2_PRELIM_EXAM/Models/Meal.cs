namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

public class Meal
{
    private string _name = string.Empty;
    private double _price;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public double Price
    {
        get => _price;
        set => _price = value;
    }
}