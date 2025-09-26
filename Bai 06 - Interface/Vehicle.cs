using System;

public class Vehicle
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Vehicle()
	{
	}

    public Vehicle(int Id, string Name, string Description)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
    }
}
