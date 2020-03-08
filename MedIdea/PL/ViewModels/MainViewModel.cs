//using MedIdea.Views;

//using Prism.Commands;
//using Prism.Mvvm;
//using System.Collections.ObjectModel;

//namespace MedIdea.ViewModels
//{
//    public class MainViewModel : BindableBase
//    {
//            private DelegateCommand _editClick;
//        public DelegateCommand EditClick => _editClick ?? (_editClick = new DelegateCommand(() => { 
//            new EditClient().ShowDialog();
           
//        }));

//        private Client _selctedClient = null;
//        public Client SelctedClient { set { if (value != null) { _selctedClient = value; } } }

//        public MainViewModel()
//        {
//            //new EditClient().Show();
//            //EditClick = new DelegateCommand(() => {
//            //    MessageBox.Show("edit");
//            //    var edit = new EditClient();
//            //    edit.Show(); });

//        }

//        private ObservableCollection<Client> clients;
//        public ObservableCollection<Client> Clients
//        {
//            set
//            {
//                clients = value;
//                RaisePropertyChanged();
//            }
//            get { return clients; }
//        }


//        private string _searchTextClient = "";
//        public string SearchTextClient
//        {
//            get { return _searchTextClient; }
//            set
//            {
//                _searchTextClient = value;
               
//            }
//        }

//    }
//}
