using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson25
{
    class Knight
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string Title { get; private set; }

        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return this.Name;
                if (fieldName == "BirthTown")
                    return this.BirthTown;
                if (fieldName == "Title")
                    return this.Title;
                return "Unknown";
            }
            set
            {
                if (fieldName == "Name")
                    this.Name = value;
                if (fieldName == "BirthTown")
                    this.BirthTown = value;
                if (fieldName == "Title")
                    this.Title = value;
            }
        }
        public override string ToString()
        {
            return $"\nName: {Name}\nBirth Town: {BirthTown}\nTitle: {Title}";
        }
    }
}
