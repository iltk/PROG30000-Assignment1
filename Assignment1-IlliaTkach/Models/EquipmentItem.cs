namespace Assignment1_IlliaTkach.Models;

public class EquipmentItem
{
    public int Id { get; set; }
    public EquipmentType Type { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
}