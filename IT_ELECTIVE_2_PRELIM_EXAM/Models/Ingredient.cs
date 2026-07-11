namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

public class Ingredient
{
    private string _name;
    private string _unit;
    private int _quantity;

    public Ingredient(string name, string unit, int quantity)
    {
        Name = name;
        Unit = unit;
        Quantity = quantity;
    }

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException();
            _name = value;
        }
    }

    public string Unit
    {
        get => _unit;
        set => _unit = value;
    }

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            _quantity = value;
        }
    }
}