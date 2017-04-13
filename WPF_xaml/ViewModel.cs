using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
            Text = NetCoreLibrary.NetCoreClass.DoSomething();
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
