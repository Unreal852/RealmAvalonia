using System.Collections.ObjectModel;
using RealmAvalonia.Models;

namespace RealmAvalonia.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
    }

    public ObservableCollection<Player> Players { get; } = new();

    public void AddPlayer()
    {
        Players.Add(new Player { Name = "Unreal", Experience = 15.2 });
    }
}