using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.Core
{
    public class AlfaRomeoPrototipo : AutoPrototipo
    {
        public override AutoPrototipo Clonar()
        {
            return (AlfaRomeoPrototipo)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Alfa Romeo {_modelo} color {_color}";
        }
    }
}
