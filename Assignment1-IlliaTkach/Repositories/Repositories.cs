using Assignment1_IlliaTkach.Models;

namespace Assignment1_IlliaTkach.Repositories;

public static class Repository
{
    private static int _nextId = 1;

    public static List<EquipmentRequest> Requests { get; } = new();
    
    public static List<EquipmentItem> Equipment { get; } = new()
    {
        new EquipmentItem { Id = 1, Type = EquipmentType.Laptop,  Description = "Dell 1101, 8GB RAM",    IsAvailable = true },
        new EquipmentItem { Id = 2, Type = EquipmentType.Laptop,  Description = "MacBook Pro M3, 8GB RAM",        IsAvailable = false },
        new EquipmentItem { Id = 3, Type = EquipmentType.Phone,   Description = "iPhone 11 ",          IsAvailable = true },
        new EquipmentItem { Id = 4, Type = EquipmentType.Phone,   Description = "Samsung Galaxy S20",             IsAvailable = false },
        new EquipmentItem { Id = 5, Type = EquipmentType.Tablet,  Description = "iPad ",           IsAvailable = true },
        new EquipmentItem { Id = 6, Type = EquipmentType.Another, Description = "HDMI projector",        IsAvailable = true },
        new EquipmentItem { Id = 7, Type = EquipmentType.Another, Description = "Charging kit", IsAvailable = false }
    };

    public static void AddRequest(EquipmentRequest request)
    {
        request.Id = _nextId++;
        Requests.Add(request);
    }
}