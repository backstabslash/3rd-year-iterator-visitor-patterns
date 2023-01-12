using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    public interface IVisitor
    {
        public void Visit(PersonAcceptor item);
        public void Visit(EquipmentAcceptor item);
    }
}
