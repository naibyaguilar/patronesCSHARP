using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.Core
{
    public class DSPrototipo : AutoPrototipo
    {
        public override AutoPrototipo Clonar()
        {
            return (DSPrototipo)this.MemberwiseClone();
        }
        public override string VerAuto()
        {
            return $"DS {_modelo} color {_color}";
        }
    }
}
