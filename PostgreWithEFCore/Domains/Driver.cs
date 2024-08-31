namespace PostgreWithEFCore.Domains;

public class Driver
{
    public int Id { get; set; }
    public int TeamId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int RacingNumber { get; set; }
    public string FavoriteColor { get; set; } = string.Empty;
    public virtual Team Team { get; set; } 
    public virtual DriverMedia DriverMedia { get; set; }    
}
