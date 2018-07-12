using Cars2._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cars2._0.ViewModels
{
    class ListedCarsViewModel:BaseViewModel
    {
        private ObservableCollection<CarEntity> cars;
        private CarEntity selectedCar;

        public CarEntity SelectedCar
        {
            get { return selectedCar; }
            set
            {
                if (selectedCar.ID != value.ID);
                else
                    selectedCar = value;
            }
        }

        public ObservableCollection<CarEntity> Cars
        {
            get { return cars; }
            private set {; }
        }
        public ListedCarsViewModel()
        {
            cars = new ObservableCollection<CarEntity>();
            foreach (var c in DatabaseExecutes.GetCarEntities())
                cars.Add(c);
        }
    }
}
