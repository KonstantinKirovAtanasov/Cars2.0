using Cars2._0.Models;
using Cars2._0.Views;
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
        private BitmapImage imageOne = null;
        private BitmapImage imageTwo = null;
        private BitmapImage imageTree = null;

        public BitmapImage ImageOne
        {
            get { return imageOne; }
            set {
                imageOne = value;
                OnPropertyChanged("ImageOne");
            }
        }
        public BitmapImage ImageTwo
        {
            get { return imageTwo; }
            set
            {
                imageTwo = value;
                OnPropertyChanged("ImageTwo");
            }
        }
        public BitmapImage ImageTree
        {
            get { return imageTree; }
            set
            {
                imageTree = value;
                OnPropertyChanged("ImageTree");
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
                
            }
            else if (parameter.Equals("Back"))
            {
                
            }
            else if (parameter.Equals("Save"))
            {
                DatabaseExecutes.AddCarEntity(car);
            }
        }

        private void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = @"C:\Users\v\Desktop";
            dialog.Title = "Please select an image file upload";

            if (dialog.ShowDialog()!=null)
            {
                if (imageOne == null)
                {
                    ImageOne = new BitmapImage(new Uri(dialog.FileName));
                    car.PictureOne = Converters.PathToByteArray(dialog.FileName);
                    return;
                }
                else if (imageTwo == null)
                {
                    ImageTwo = new BitmapImage(new Uri(dialog.FileName));
                    car.PictureTwo = Converters.PathToByteArray(dialog.FileName);
                    return;
                }
                else if(imageTree == null)
                {
                    ImageTree = new BitmapImage(new Uri(dialog.FileName));
                    car.PictureTree = Converters.PathToByteArray(dialog.FileName);
                    return;
                }
            }
        }
        ~AddCarViewModel()
        {
            DatabaseExecutes.OnAppClose();
        }

    }
}
