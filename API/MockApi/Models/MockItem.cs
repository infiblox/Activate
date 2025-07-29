namespace MockApi.Models;

public class MockItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Secret { get; set; } // This property is not exposed in the DTO
}