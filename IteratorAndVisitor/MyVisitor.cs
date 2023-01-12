using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    public class MyVisitor : IVisitor
    {
        public void Visit(PersonAcceptor item)
        {
            Console.WriteLine("Visited Person!");
        }
        public void Visit(EquipmentAcceptor item)
        {
            Console.WriteLine("Visited Equipment!");
        }
    }
}
