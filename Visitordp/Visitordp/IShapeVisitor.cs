using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    public interface IShapeVisitor
    {
        float Visit(Rectangle rectangle);

        float Visit(Circle circle);

    }
}
