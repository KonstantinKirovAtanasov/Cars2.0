using Cars2._0.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cars2._0.ViewModels
{

    public class NavigationViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static NavigationViewModel instance;
        private Stack<BaseViewModel> selectedVM = new Stack<BaseViewModel>();

        public BaseViewModel SelectedVM
        {
            get
            {
                if (selectedVM.Count<1)
                {
                    selectedVM.Push(new ListedCarsViewModel());
                }
                return selectedVM.Peek();
            }
            set
            {
                if (selectedVM.Count >1 && value == selectedVM.Peek())
                    ;
                else
                {
                    selectedVM.Push(value);
                    OnPropertyChanged("SelectedVM");
                }
            }
        }
        public static NavigationViewModel getInstance
        {
            get { return instance; }
        }
        public NavigationViewModel()
        {
            instance = this;
        }

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
