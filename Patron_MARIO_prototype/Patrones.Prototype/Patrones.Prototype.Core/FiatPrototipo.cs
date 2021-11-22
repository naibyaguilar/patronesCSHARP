using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.Core
{
    public class FiatPrototipo : AutoPrototipo
    {
        public override AutoPrototipo Clonar()
        {
            return (FiatPrototipo)this.MemberwiseClone();
        }
        public override string VerAuto()
        {
            return $"Fiat {_modelo} color {_color}";
        }
    }
}
