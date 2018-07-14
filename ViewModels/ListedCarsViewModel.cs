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
        private ObservableCollection<CarEntity> filteredCars;
        private CarEntity selectedCar;
        private string titleFilter = "";

        public string TitleFilter
        {
            get
            { return titleFilter; }
            set
            {
                titleFilter = value;
                filteredCars = new ObservableCollection<CarEntity>((from c in cars
                                where c.Title.ToLower().Contains(titleFilter.ToLower())
                                select c).ToList());
                OnPropertyChanged("Cars");
            }
        }

        public CarEntity SelectedCar
        {
            get { return selectedCar; }
            set
            {
                if (selectedCar.ID != value.ID)
                    ;
                else
                    selectedCar = value;
            }
        }
        public ObservableCollection<CarEntity> Cars
        {
            get
            {
                if (titleFilter.Length >= 1)
                    return filteredCars;
                return cars;
            }
            private set {; }
        }
        public ListedCarsViewModel()
        {
            selectedCar = new CarEntity();
            cars = new ObservableCollection<CarEntity>();
            foreach (var c in DatabaseExecutes.GetCarEntities())
                cars.Add(c);
        }
    }
}
