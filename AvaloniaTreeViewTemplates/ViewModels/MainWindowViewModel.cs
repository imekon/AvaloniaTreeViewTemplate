using System.Collections.ObjectModel;

namespace AvaloniaTreeViewTemplates.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<ThingViewModel> m_things;

        public MainWindowViewModel()
        {
            m_things = new ObservableCollection<ThingViewModel>();
            var thing = new ThingViewModel { Name = "Thing", Address = "Here", Template = "Folder" };
            thing.Children.Add(new ThingViewModel { Name = "Child", Address = "There", Template = "Thing" });
            m_things.Add(thing);
        }

        public ObservableCollection<ThingViewModel> Things => m_things;
    }
}
