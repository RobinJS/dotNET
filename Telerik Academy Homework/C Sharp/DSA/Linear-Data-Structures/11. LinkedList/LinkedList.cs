using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LinkedList
{
    class LinkedList<T>
    {
        public ListItem<T> FirstElement { get; set; }

        public void Add(T item)
        {
            this.FirstElement = new ListItem<T>(item);
        }

        private int Count()
        {
            if (FirstElement == null)
            {
                return 0;
            }

            int counter = 1;

            while (FirstElement.NextItem != null)
            {
                counter++;
            }

            return counter;
        }

        public override string ToString()
        {
            StringBuilder linkedListString = new StringBuilder();

            while (FirstElement.NextItem != null)
            {
                linkedListString.Append(FirstElement.NextItem.Value);
            }

            return linkedListString.ToString();
        }
    }
}
