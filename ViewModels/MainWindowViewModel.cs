using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;

namespace TestResol.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {

        public MainWindowViewModel()
        {
            colorBrushList = new ObservableCollection<string>(MockStringColorBrush());
        }

        private ObservableCollection<string> colorBrushList = null!;

        public ObservableCollection<string> ColorBrushList
        {
            get => colorBrushList;
            set => this.RaiseAndSetIfChanged(ref colorBrushList, value);
        }

        private IEnumerable<string> MockStringColorBrush()
        {
            var defaultBrush = new List<string>()
            {
                    new string("#F00000"),
                    new string("#FA0000"),
                    new string("#FB0000"),
                    new string("#FF0000"),
                    new string("#FFF000"),
                    new string("#FFFA00"),
                    new string("#FFFB00"),
                    new string("#FFFF00"),
                    new string("#FFFFF0"),
                    new string("#FFFFA0"),
                    new string("#FFFFB0"),
                    new string("#FFFFFF")
            };

            return defaultBrush;

        }

    }
}
