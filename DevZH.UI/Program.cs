

namespace DevZH.UI
{
    public class MainWindow : Window
        {
        private MultilineEntry textControl;

        public MainWindow(string title = "DevZH.UI", int width = 300, int height = 200, bool hasMenubar = false) 
            : base(title, width, height, hasMenubar)
            {
            InitializeComponent();
            }

        private void InitializeComponent()
            {
            var box = new VerticalBox();
            box.AllowPadding = true;

            textControl = new MultilineEntry();
            box.Children.Add(textControl, true);

            var button = new Button("Call .NET Core");
            box.Children.Add(button);

            button.Click += Button_Click;

            Child = box;
            }

        private void Button_Click(object sender, System.EventArgs e)
            {
            textControl.Text = NetCoreLibrary.NetCoreClass.DoSomething();
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            var app = new Application(true);
            var window = new MainWindow()
                {
                AllowMargins = true
                };
            app.Run(window);
        }
    }
}
