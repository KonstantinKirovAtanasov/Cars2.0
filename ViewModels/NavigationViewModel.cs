using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars2._0.ViewModels
{
    public class NavigationViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Stack<BaseViewModel> selectedVM = null;

        public BaseViewModel SelectedVM
        {
            get
            {
                if (selectedVM == null)
                    selectedVM.Push(new AddCarViewModel());
                return selectedVM.Pop();
            }
            set
            {
                if (value == selectedVM.Peek())
                    ;
                else
                {
                    selectedVM.Push(value);
                    OnPropertyChanged("SelectedVM");
                }
            }
        }

        public NavigationViewModel() { }

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

    }
}
