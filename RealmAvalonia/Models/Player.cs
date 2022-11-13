using Realms;

namespace RealmAvalonia.Models;

public partial class Player : IRealmObject
{
    public string? Name       { get; set; }
    public double  Experience { get; set; }
}