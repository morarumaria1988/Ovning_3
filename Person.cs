using System;
namespace Ovning_3;

public class Person
{
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

    public int Age
    {
        get => age;
        set
        {
            if (value > 0)
                age = value;
            else throw new ArgumentException("Age must be greater than 0.");
        }
    }

    public string FName
    {
        get => fName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name is mandatory.");
            }
            else if (value.Length < 2 || value.Length > 10)
            {
                throw new ArgumentException("First name must have between 2 and 10 characters.");
            }
            fName = value;
        }
    }
    public string LName
    {
        get => lName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Last name is mandatory.");
            }
            else if (value.Length < 3 || value.Length > 15)
            {
                throw new ArgumentException("Last name must have between 3 and 15 characters.");
            }
            lName = value;
        }
    }
    public double Height { get => height; set => height = value; }
    public double Weight { get => weight; set => weight = value; }

    public override string? ToString()
    {
        return fName + " " + lName + " is " + age + " years old.";
    }
}
