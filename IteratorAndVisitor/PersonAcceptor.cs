using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    public class PersonAcceptor : IAcceptor
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
