using Core.Models;
using PL_WPF.Views;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;

namespace PL_WPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
       
        public DelegateCommand EditClick =>  ( new DelegateCommand(() => {
            new EditClientWindow().ShowDialog();

        }));
        

        public DelegateCommand AddClick =>  ( new DelegateCommand(() => {
           var Add = new AddWindow();
           var boo= Add.ShowDialog();
           MessageBox.Show(boo.ToString());

        }));

        private ClientCart _selctedClient = null;
        public ClientCart SelctedClient { set { if (value != null) { _selctedClient = value; } } }

        public MainWindowViewModel()
        {        

        }

        private ObservableCollection<ClientCart> clients;
        public ObservableCollection<ClientCart> Clients
        {
            set
            {
                clients = value;
                RaisePropertyChanged();
            }
            get { return clients; }
        }


        private string _searchTextClient = "";
        public string SearchTextClient
        {
            get { return _searchTextClient; }
            set
            {
                _searchTextClient = value;

            }
        }

    }
}
