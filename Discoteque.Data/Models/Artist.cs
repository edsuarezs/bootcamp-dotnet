namespace Discoteque.Data.Models;

public class Artist : BaseEntity<int>
{
    public required string Name { get; set; }
    public required string Label { get; set; }
    public bool IsOnTour { get; set; }

}