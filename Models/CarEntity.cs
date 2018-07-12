using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars2._0.Models
{
    public enum TradeMark { Ford, Opel, Audi }
    public enum Model { Fiesta, Laguna, A4 }
    public enum GearBox { Manual, Automatic }
    public enum Fuel { Petrol, Diesel }

    public class CarEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Title { get; set; }

        public Byte[] PictureOne { get; set; }
        public Byte[] PictureTwo { get; set; }
        public Byte[] PictureTree { get; set; }

        public int HorsePower { get; set; }
        public int Engine { get; set; }
        public string Color { get; set; }
        public int MileAge { get; set; }
    }
}
