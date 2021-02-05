using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson25
{
    class Magician
    {
        public string Name { get; set; }
        public string BirthTown { get; set; }
        public  string FavoriteSpell { get; set; }

        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return this.Name;
                if (fieldName == "BirthTown")
                    return this.BirthTown;
                if (fieldName == "FavoriteSpell")
                    return this.FavoriteSpell;
                return "Unknown";
            }
            set 
            {
                if (fieldName == "Name")
                    this.Name = value;
                if (fieldName == "BirthTown")
                    this.BirthTown = value;
                if (fieldName == "FavoriteSpell")
                    this.FavoriteSpell = value;
            }
        }

        public override string ToString()
        {
            return $"\nName: {Name}\n Birth Town: {BirthTown}\nFavoriteSpell: {FavoriteSpell} ";
        }
    }
}
