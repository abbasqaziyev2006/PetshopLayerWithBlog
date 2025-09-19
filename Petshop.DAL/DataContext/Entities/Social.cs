namespace Petshop.DAL.DataContext.Entities;

public class Social : TimeStample
{
    public string Url { get; set; } = null!;
    public string IconUrl { get; set; } = null!;
}