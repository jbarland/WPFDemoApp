using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfDemoApp.ViewModels
{
    internal class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }

        private int _number = 0;

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        public ICommand IncreaseCounter
        {
            get
            {
                return new RelayCommand(p =>
                {
                    Number++;
                });
            }
        }

        public ICommand DecreaseCounter
        {
            get
            {
                return new RelayCommand(p =>
                {
                    Number--;
                });
            }
        }

        public ICommand ResetCounter
        {
            get
            {
                return new RelayCommand(p =>
                {
                    Number = 0;
                });
            }
        }
    }
}
