using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfDemoApp.Models;

namespace WpfDemoApp.ViewModels
{
    internal class BindingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
        //public string MyText { get; set; }

        private string _myText;

        public string MyText
        {
            get { return _myText; }
            set
            {
                _myText = value;
                OnPropertyChanged(nameof(MyText));
            }
        }

        private Message _myNewMessage;

        public Message MyNewMessage
        {
            get { return _myNewMessage; }
            set
            {
                _myNewMessage = value;
                OnPropertyChanged(nameof(MyNewMessage));
            }
        }

        public ICommand EditMyText
        {
            get
            {
                //return new RelayCommand
                return new RelayCommand(param =>
                {
                    MyText = "Change by btn";
                });
            }
        }

        public ObservableCollection<string> MyStringList { get; set; } = new ObservableCollection<string>();

        public ICommand AddMyTextToMyStringList
        {
            get
            {
                return new RelayCommand(p =>
                {
                    MyStringList.Add(MyText);
                });
            }
        }

        public ICommand UpdateFirstToMyStringList
        {
            get
            {
                return new RelayCommand(p =>
                {
                    MyStringList[0] = MyText;
                }, p =>
                {
                    return MyStringList.Count > 0;
                });
            }
        }

        //public bool IsbtnDeleteFirstEnable { get; set; } = true;

        //public ICommand DeleteFirstToMyStringList
        //{
        //    get
        //    {
        //        return new RelayCommand(p =>
        //        {
        //            MyStringList.Remove(MyStringList[0]);
        //        }, p =>
        //        {
        //            if (MyStringList.Count == 0)
        //            {
        //                IsbtnDeleteFirstEnable = false;
        //            }
        //            return IsbtnDeleteFirstEnable;
        //        });
        //    }
        //}

        public ICommand DeleteFirstToMyStringListV2
        {
            get
            {
                return new RelayCommand(p =>
                {
                    MyStringList.RemoveAt(0);
                }, p =>
                {
                    return MyStringList.Count > 0;
                });
            }
        }

        public ObservableCollection<Message> MyMessagesList { get; set; } = new ObservableCollection<Message>();

        public ICommand AddToMyMessagesList
        {
            get
            {
                return new RelayCommand(p =>
                {
                    MyMessagesList.Add(MyNewMessage);
                });
            }
        }

        public ICommand UpdateFirstToMyMessagesList
        {
            get
            {
                return new RelayCommand(p =>
                {
                    MyMessagesList[0] = MyNewMessage;
                }, p =>
                {
                    return MyMessagesList.Count > 0;
                });
            }
        }

        public ICommand DeleteFirstToMyMessagesList
        {
            get
            {
                return new RelayCommand(p =>
                {
                    MyMessagesList.RemoveAt(0);
                }, p =>
                {
                    return MyMessagesList.Count > 0;
                });
            }
        }
        public int SelectedIndexValue { get; set; }

        public ICommand DeleteSelectedFromMyMessagesList
        {
            get
            {
                return new RelayCommand(p =>
                {
                    //SelectedIndex negative if I update MyMessagesList[0]
                    if (SelectedIndexValue < 0)
                    {
                        SelectedIndexValue = 0;
                    }
                    MyMessagesList.RemoveAt(SelectedIndexValue);
                    if (MyMessagesList.Count == 1)
                    {
                        SelectedIndexValue = 0;
                    }                  
                }, p =>
                {
                    return MyMessagesList.Count > 0;
                });
            }
        }

        private int _nbRandom = new Random().Next(-50, 50);

        public int NbRandom
        {
            get { return _nbRandom; }
            set
            {
                _nbRandom = value;
                OnPropertyChanged(nameof(NbRandom));
            }
        }

        public ICommand SetNewNbRandom
        {
            get
            {
                return new RelayCommand(p =>
                {
                    NbRandom = new Random().Next(-50, 50);
                });
            }
        }

        public BindingViewModel()
        {
            MyText = "Hello binding";

            MyStringList.Add("foo");
            MyStringList.Add("bar");
            MyStringList.Add("foobar");

            MyMessagesList.Add(
                new Message()
                {
                    Id = 1,
                    Content = "Toto fait du vélo",
                    Author = "Toto",
                    CreatedAt = DateTime.Now.AddDays(-25),
                }
            );
            MyMessagesList.Add(
                new Message()
                {
                    Id = 2,
                    Content = "C'est bientôt le weekend",
                    Author = "Jérémy",
                    CreatedAt = DateTime.Now,
                }
            );

            MyNewMessage = new Message()
            {
                Id = 3,
                Content = "C'est un nouveau message",
                Author = "Perceval",
                CreatedAt = DateTime.Now,
            };

        }
    }
}
