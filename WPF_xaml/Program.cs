using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

/*
 * 
 * THIS DOES NOT WORK. UNSURE HOW TO MAKE THE XAML FILE COMPILE 
 * 
 */

namespace WPF_xaml
    {
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
