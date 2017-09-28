using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadSkill
{
    class ActiveSkill
    {
        uint min_cooldown;
        string effect;
        uint max_cooldown;
        string name;

        public uint Min_cooldown { get => min_cooldown; set => min_cooldown = value; }
        public string Effect { get => effect; set => effect = value; }
        public uint Max_cooldown { get => max_cooldown; set => max_cooldown = value; }
        public string Name { get => name; set => name = value; }
    }
}
