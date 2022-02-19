using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class WhiteMan : Human
    {
        public override void Breath()
        {
            age++;
            height += 0.0002f;
            weight += 0.0002f;
        }
    }
}
