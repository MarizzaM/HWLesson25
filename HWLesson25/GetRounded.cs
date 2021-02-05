using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson25
{
    class GetRounded<T> : IEnumerable<T>
    {
        private List<T> entities = new List<T>();

        public void Add(T e) {
            entities.Add(e);
        }

        public void RemoveAt(int x) {
            
        }

        public void Sort()
        {
            entities.Sort();
        }

        public void Clear()
        {
            entities.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }


        public GetRounded()
        {
        }

    }
}
