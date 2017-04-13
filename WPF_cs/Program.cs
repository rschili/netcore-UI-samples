using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace WPF_cs
    {
    public class MyWindow : Window
        {
        public MyWindow()
            {
            Width = 300;
            Height = 300;

            var panel = new StackPanel();
            panel.Orientation = Orientation.Vertical;
            Content = panel;

            var button1 = new Button();
            button1.Content = "Call .NET Core";
            button1.Height = 23;
            panel.Children.Add(button1);

            var textBox = new TextBox();
            textBox.Height = 200;
            panel.Children.Add(textBox);

            var binding = new Binding("Text");
            binding.Mode = BindingMode.TwoWay;
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(textBox, TextBox.TextProperty, binding);

            binding = new Binding("CallNetCoreCommand");
            binding.Mode = BindingMode.OneWay;
            BindingOperations.SetBinding(button1, Button.CommandProperty, binding);
            }
        }

    public class MyViewModel : INotifyPropertyChanged
        {
        public event PropertyChangedEventHandler PropertyChanged;

        public MyViewModel()
            {
            CallNetCoreCommand = new DelegateCommand(DoCallNetCore);
            }

        private string _text = "Initial Value";
        public string Text
            {
            get => _text;
            set
                {
                _text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text)));
                }
            }

        public ICommand CallNetCoreCommand { get; }

        private void DoCallNetCore(object parameter)
            {
            Text = _Library.NetCoreClass.DoSomething();
            }
        }

    public class Program
        {

        [STAThread]
        public static void Main()
            {
            var app = new Application();
            var window = new MyWindow();
            var viewModel = new MyViewModel();
            window.DataContext = viewModel;
            app.Run(window);
            }
        }

    public class DelegateCommand : ICommand
        {
        public event EventHandler CanExecuteChanged;

        private Action<object> _handler;
        public DelegateCommand(Action<object> handler)
            {
            _handler = handler;
            }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _handler?.Invoke(parameter);
        }
    }
