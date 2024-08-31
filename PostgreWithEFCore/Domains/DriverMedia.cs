namespace PostgreWithEFCore.Domains;

public class DriverMedia
{
    public int Id { get; set; }
    public int DriverId { get; set; }
    public string Media { get; set; } = string.Empty; 

    public virtual Driver Driver { get; set; }
}
