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
    public delegate NavigationViewModel VMChanged(BaseViewModel viewModel);

    public class NavigationViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        internal static Stack<UserControl> selectedVM = new Stack<UserControl>();

        public static UserControl SelectedVM
        {
            get
            {
                if (selectedVM.Count<1)
                {
                    selectedVM.Push(new AddCarView());
                    return selectedVM.Pop();
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
                    //OnPropertyChanged("SelectedVM");
                }
            }
        }

        public NavigationViewModel() { }

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        //public void 
    }
}
