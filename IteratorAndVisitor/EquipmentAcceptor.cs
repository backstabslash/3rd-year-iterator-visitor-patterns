using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    public class EquipmentAcceptor : IAcceptor
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
