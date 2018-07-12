using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars2._0.Models
{
    public static class DatabaseExecutes
    {
        private static List<CarEntity> Cars = new List<CarEntity>();

        public static void AddCarEntity(CarEntity c)
        {
            if (Cars.Count() > 5)
            {
                using(var db = new DBContext())
                {
                    foreach (var car in Cars)
                        db.Cars.Add(car);
                    db.SaveChanges();
                    Cars.Clear();
                }
            }
            else
                Cars.Add(c);
        }
        public static IEnumerable<CarEntity> GetCarEntities()
        {
            using (var db = new DBContext())
            {
                return db.Cars.ToList();
            }
        }
    }
}
