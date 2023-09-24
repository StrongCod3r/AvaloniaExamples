using System.Diagnostics;
using TabControlExample.Models;

namespace TabControlExample.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public TabControlPageViewModel TabControlPage { get; }

        public MainWindowViewModel()
        {
            TabControlPage = new TabControlPageViewModel();
            TabControlPage.Tabs = new System.Collections.ObjectModel.ObservableCollection<TabControlModel>
            {
                new TabControlModel
                    {
                        Header = "Arch",
                        Content = "Content 1",
                    },
                    new TabControlModel
                    {
                        Header = "Leaf",
                        Content = "Content 2",
                    },
                    new TabControlModel
                    {
                        Header = "Disabled",
                        Content = "Content 3",
                        IsEnabled = false,
                    },
            };
        }

        public void AddTab()
        {
            TabControlPage.Tabs.Add(new TabControlModel
            {
                Header = "Test",
                Content = $"Content {TabControlPage.Tabs.Count + 1}",
                IsEnabled = true,
            });
        }
    }
}