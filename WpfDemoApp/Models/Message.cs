using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoApp.Models
{
    internal class Message : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set 
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _content;

        public string Content
        {
            get { return _content; }
            set 
            { 
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }

        private string _author;

        public string Author
        {
            get { return _author; }
            set 
            { 
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }

        private DateTime dateTime_createdAt;

        public DateTime CreatedAt
        {
            get { return dateTime_createdAt; }
            set 
            { 
                dateTime_createdAt = value;
                OnPropertyChanged(nameof(CreatedAt));
            }
        }


        public override string ToString()
        {
            return $"{Content} par {Author} le {CreatedAt.ToShortDateString()}";
        }
    }
}
