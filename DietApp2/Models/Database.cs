using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietApp2.Models
{
    public static class Database
    {
        private static List<Diet> _dietList;
        static Database()
        {
            _dietList = new List<Diet>()
            {
                new Diet(){meal="Kahvaltı", comment= "Peynir,zeytin", date =DateTime.Now.AddDays(-1), İsCompleted =true},
                new Diet(){meal="Öğlen", comment= "Elma,çay", date =DateTime.Now.AddDays(-1), İsCompleted =true},
                new Diet(){meal="Akşam", comment= "et,yoğurt", date =DateTime.Now.AddDays(-1), İsCompleted =true},
                new Diet(){meal="Kahvaltı", comment= "Peynir,zeytin", date =DateTime.Now.AddDays(0), İsCompleted =true},
                new Diet(){meal="Öğlen", comment= "Elma,çay", date =DateTime.Now.AddDays(0), İsCompleted =false},
                new Diet(){meal="Akşam", comment= "et,yoğurt", date =DateTime.Now.AddDays(0), İsCompleted =false}
            };
        }

        public static List<Diet> List
        {
            get { return _dietList; }
        }

        public static void Add(Diet diet)
        {
            _dietList.Add(diet);
        }
    }
}