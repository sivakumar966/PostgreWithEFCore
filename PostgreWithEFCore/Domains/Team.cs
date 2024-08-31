namespace PostgreWithEFCore.Domains;

public class Team
{

    public Team()
    {
        Drivers = new HashSet<Driver>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Year { get; set; } = 2024;

    public virtual ICollection<Driver> Drivers { get; set; }
}
