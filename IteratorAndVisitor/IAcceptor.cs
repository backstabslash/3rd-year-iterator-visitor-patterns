using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    public interface IAcceptor
    {
        public void Accept(IVisitor visitor);
    }
}
