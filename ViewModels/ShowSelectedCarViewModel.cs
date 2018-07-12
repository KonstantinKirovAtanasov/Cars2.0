using Cars2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Cars2._0.ViewModels
{
    class ShowSelectedCarViewModel:BaseViewModel
    {
        private CarEntity car;
        private BitmapImage mainImage;

        public CarEntity Car { get { return car; } private set {; } }
        public BitmapImage MainImage { get; set; }

        public ShowSelectedCarViewModel() { }

        public ShowSelectedCarViewModel(ref CarEntity car)
        {
            this.car = car;
            mainImage = Converters.BitmapFromByteArray(car.PictureOne);
        }
        
    }
}
