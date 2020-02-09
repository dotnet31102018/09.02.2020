using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    public interface IVisitable
    {
        double Accept(IVisitor visitor);
    }
}
