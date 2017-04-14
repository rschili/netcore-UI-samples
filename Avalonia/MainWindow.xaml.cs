using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia
    {
    public class MainWindow : Window
        {
        public MainWindow()
            {
            this.InitializeComponent();
            App.AttachDevTools(this);
            this.DataContext = new MyViewModel();
            }

        private void InitializeComponent()
            {
            AvaloniaXamlLoader.Load(this);
            }
        }
    }
