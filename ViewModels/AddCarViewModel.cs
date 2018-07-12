using Cars2._0.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Cars2._0.ViewModels
{
    class AddCarViewModel:BaseViewModel
    {
        private CarEntity car;
        private BitmapImage image;
       

        public BitmapImage Image
        {
            get { return image; }
            set {
                image = value;
                OnPropertyChanged("Image");
            }
        }

        public CarEntity Car
        {
            get
            {
                return car;
            }
            private set
            {
                car = value;
            }
        }

        public AddCarViewModel()
        {
            this.car = new CarEntity();
        }

        public override void Execute(object parameter)
        {
            if (parameter.Equals("Upload"))
            {
                UploadPhoto();
            }
            else if (parameter.Equals("See"))
            {
                NavigationViewModel
            }
            else if (parameter.Equals("Back"))
            {

            }
            else if (parameter.Equals("Save"))
            {

            }
        }

        private void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file upload";

            if (dialog.ShowDialog()!=null)
            {
                Image = Converters.UriToBitmapImage(dialog.FileName);
                car.PictureOne = Converters.BitmapImageToByteArray(image);
            }
        }
    }
}
