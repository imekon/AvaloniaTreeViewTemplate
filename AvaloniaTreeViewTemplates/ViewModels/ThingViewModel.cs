using System.Collections.ObjectModel;

namespace AvaloniaTreeViewTemplates.ViewModels
{
    public class ThingViewModel
    {
        private ObservableCollection<ThingViewModel> m_children;

        public ThingViewModel()
        {
            Name = "";
            Address = "";
            Template = "";
            m_children = new ObservableCollection<ThingViewModel>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public ObservableCollection<ThingViewModel> Children => m_children;

        public string Template { get; set; }
    }
}
