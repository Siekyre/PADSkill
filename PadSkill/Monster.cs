using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadSkill
{
    class Monster
    {
        public uint? Element2 { get => element2;
            set {
                element2 = value;
                if (element2 == null) element2 = uint.MaxValue;
            }
        }
        public List<int> Awoken_skills { get => awoken_skills; set => awoken_skills = value; }
        public float Rcv_scale { get => rcv_scale; set => rcv_scale = value; }
        public uint Id { get => id; set => id = value; }
        public uint? Type3
        {
            get => type3;
            set
            {
                type3 = value;
                if (type3== null) type3 = uint.MaxValue;
            }
        }
        public uint? Type2
        {
            get => type2;
            set
            {
                type2 = value;
                if (type2 == null) type2 = uint.MaxValue;
            }
        }

        public string Image40_href { get => image40_href; set => image40_href = value; }
        public uint Xp_curve { get => xp_curve; set => xp_curve = value; }
        public string Leader_skill { get => leader_skill; set => leader_skill = value; }
        public uint Image40_size { get => image40_size; set => image40_size = value; }
        public string Version { get => version; set => version = value; }
        public uint Atk_min { get => atk_min; set => atk_min = value; }
        public uint Atk_max { get => atk_max; set => atk_max = value; }
        public bool Jp_only { get => jp_only; set => jp_only = value; }
        public uint Image60_size { get => image60_size; set => image60_size = value; }
        public uint Max_level { get => max_level; set => max_level = value; }
        public string Image60_href { get => image60_href; set => image60_href = value; }
        public uint Monster_points { get => monster_points; set => monster_points = value; }
        public int Rcv_min { get => rcv_min; set => rcv_min = value; }
        public int Rcv_max { get => rcv_max; set => rcv_max = value; }
        public uint Hp_max { get => hp_max; set => hp_max = value; }
        public float Hp_scale { get => hp_scale; set => hp_scale = value; }
        public string Name { get => name; set => name = value; }
        public uint Team_cost { get => team_cost; set => team_cost = value; }
        public uint Type { get => type; set => type = value; }
        public uint Hp_min { get => hp_min; set => hp_min = value; }
        public string Name_jp { get => name_jp; set => name_jp = value; }
        public uint Rarity { get => rarity; set => rarity = value; }
        public string Active_skill { get => active_skill; set => active_skill = value; }
        public float Feed_xp { get => feed_xp; set => feed_xp = value; }
        public uint Element { get => element; set => element = value; }
        public float Atk_scale { get => atk_scale; set => atk_scale = value; }


        uint? element2;
        List<int> awoken_skills;
        float rcv_scale;
        uint id;
        uint? type3;
        uint? type2;
        string image40_href;
        uint xp_curve;
        string leader_skill;
        uint image40_size;
        string version;
        uint atk_min;
        uint atk_max;
        bool jp_only;
        uint image60_size;
        uint max_level;
        string image60_href;
        uint monster_points;
        int rcv_min;
        int rcv_max;
        uint hp_max;
        float hp_scale;
        string name;
        uint team_cost;
        uint type;
        uint hp_min;
        string name_jp;
        uint rarity;
        string active_skill;
        float feed_xp;
        uint element;
        float atk_scale;

    }
}
