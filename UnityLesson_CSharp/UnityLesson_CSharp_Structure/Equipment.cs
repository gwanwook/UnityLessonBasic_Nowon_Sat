using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_Structure
{
    internal class Equipment
    {
        public Stats stats;
        public EquipmentAbility equipmentAbility;

        public void SetEquipmentAbility(int _ATK, int _DEF, int _HP, int _MP, int _Durability)
        {
            equipmentAbility._ATK = _ATK;
            equipmentAbility._DEF = _DEF;
            equipmentAbility._HP = _HP;
            equipmentAbility._MP = _MP;
            equipmentAbility._Durability = _Durability;
        }
    }
}
