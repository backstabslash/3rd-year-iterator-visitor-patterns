using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    public class ListIterator : IIterator
    {
        private List<object> collection;
        private int pos = 0;
        public ListIterator(List<object> collection)
        {
            this.collection = collection;
        }
        public object Next()
        {
            return collection[pos++];
        }
        public bool HasNext()
        {
            return pos < collection.Count;
        }
    }
}
