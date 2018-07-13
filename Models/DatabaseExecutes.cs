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
        private static HashSet<CarEntity> Cars = new HashSet<CarEntity>(new CarEntityEqualityComparer());

        public static void AddCarEntity(CarEntity c)
        {
            Cars.Add(new CarEntity(c));
            if (Cars.Count() > 3)
            {
                using(var db = new DBContext())
                {
                    db.Cars.AddRange(Cars);
                    db.SaveChanges();
                    Cars.Clear();
                }
            }
        }
        public static IEnumerable<CarEntity> GetCarEntities()
        {
            Cars.Clear();
            using (var db = new DBContext())
            {
                return db.Cars.ToList();
            }
        }
        public static void OnAppClose()
        {
            using (var db = new DBContext())
            {
                db.Cars.AddRange(Cars);
                db.SaveChanges();
                Cars.Clear();
            }
        }
    }
}
