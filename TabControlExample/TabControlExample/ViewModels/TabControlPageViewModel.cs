using System.Collections.ObjectModel;
using TabControlExample.Models;

namespace TabControlExample.ViewModels;

public class TabControlPageViewModel : ViewModelBase
{
    public ObservableCollection<TabControlModel>? Tabs { get; set; }
}
