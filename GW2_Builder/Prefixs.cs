using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW2_Builder
{
    public class PrefixData
    {
        public static Dictionary<int, PreData> PrefixRef = new Dictionary<int, PreData>()
            {
                {0, new PreData {prfxStr = "None", attCodeA = 0, attCodeB = 0, attCodeC = 0, attCodeD = 0}},
                {1, new PreData {prfxStr = "Apothecary", attCodeA = 9, attCodeB = 3, attCodeC = 6, attCodeD = 0}},
                {2, new PreData {prfxStr = "Assassin", attCodeA = 2, attCodeB = 1, attCodeC = 8, attCodeD = 0}},
                {3, new PreData {prfxStr = "Berserker", attCodeA = 1, attCodeB = 2, attCodeC = 8, attCodeD = 0}},
                {4, new PreData {prfxStr = "Bringer", attCodeA = 9, attCodeB = 2, attCodeC = 4, attCodeD = 0}},
                {5, new PreData {prfxStr = "Carrion", attCodeA = 6, attCodeB = 1, attCodeC = 4, attCodeD = 0}},
                {6, new PreData {prfxStr = "Cavalier", attCodeA = 3, attCodeB = 1, attCodeC = 8, attCodeD = 0}},
                {7, new PreData {prfxStr = "Celestial", attCodeA = 1, attCodeB = 0, attCodeC = 0, attCodeD = 0}},
                {8, new PreData {prfxStr = "Cleric", attCodeA = 9, attCodeB = 1, attCodeC = 3, attCodeD = 0}},
                {9, new PreData {prfxStr = "Commander", attCodeA = 1, attCodeB = 2, attCodeC = 3, attCodeD = 5}},
                {10, new PreData {prfxStr = "Crusader", attCodeA = 1, attCodeB = 3, attCodeC = 8, attCodeD = 9}},
                {11, new PreData {prfxStr = "Dire", attCodeA = 6, attCodeB = 3, attCodeC = 4, attCodeD = 0}},
                {12, new PreData {prfxStr = "Diviner", attCodeA = 1, attCodeB = 5, attCodeC = 2, attCodeD = 8}},
                {13, new PreData {prfxStr = "Giver", attCodeA = 3, attCodeB = 9, attCodeC = 5, attCodeD = 0}},
                {14, new PreData {prfxStr = "Grieving", attCodeA = 1, attCodeB = 6, attCodeC = 2, attCodeD = 8}},
                {15, new PreData {prfxStr = "Harrier", attCodeA = 1, attCodeB = 9, attCodeC = 5, attCodeD = 0}},
                {16, new PreData {prfxStr = "Knight", attCodeA = 3, attCodeB = 1, attCodeC = 2, attCodeD = 0}},
                {17, new PreData {prfxStr = "Magi", attCodeA = 9, attCodeB = 2, attCodeC = 4, attCodeD = 0}},
                {18, new PreData {prfxStr = "Marauder", attCodeA = 1, attCodeB = 2, attCodeC = 4, attCodeD = 8}},
                {19, new PreData {prfxStr = "Marshal", attCodeA = 1, attCodeB = 9, attCodeC = 2, attCodeD = 5}},
                {20, new PreData {prfxStr = "Minstrel", attCodeA = 3, attCodeB = 9, attCodeC = 4, attCodeD = 5}},
                {21, new PreData {prfxStr = "Nomad", attCodeA = 3, attCodeB = 4, attCodeC = 9, attCodeD = 0}},
                {22, new PreData {prfxStr = "Plaguedoctor", attCodeA = 6, attCodeB = 4, attCodeC = 9, attCodeD = 5}},
                {23, new PreData {prfxStr = "Rabid", attCodeA = 6, attCodeB = 2, attCodeC = 3, attCodeD = 0}},
                {24, new PreData {prfxStr = "Rampager", attCodeA = 2, attCodeB = 1, attCodeC = 6, attCodeD = 0}},
                {25, new PreData {prfxStr = "Sentinel", attCodeA = 4, attCodeB = 1, attCodeC = 3, attCodeD = 0}},
                {26, new PreData {prfxStr = "Seraph", attCodeA = 2, attCodeB = 6, attCodeC = 5, attCodeD = 9}},
                {27, new PreData {prfxStr = "Settler", attCodeA = 3, attCodeB = 6, attCodeC = 9, attCodeD = 0}},
                {28, new PreData {prfxStr = "Shaman", attCodeA = 4, attCodeB = 6, attCodeC = 9, attCodeD = 0}},
                {29, new PreData {prfxStr = "Sinister", attCodeA = 6, attCodeB = 1, attCodeC = 2, attCodeD = 0}},
                {30, new PreData {prfxStr = "Soldier", attCodeA = 1, attCodeB = 3, attCodeC = 4, attCodeD = 0}},
                {31, new PreData {prfxStr = "Trailblazer", attCodeA = 3, attCodeB = 6, attCodeC = 4, attCodeD = 7}},
                {32, new PreData {prfxStr = "Valkyrie", attCodeA = 1, attCodeB = 4, attCodeC = 8, attCodeD = 0}},
                {33, new PreData {prfxStr = "Vigilant", attCodeA = 1, attCodeB = 3, attCodeC = 5, attCodeD = 7}},
                {34, new PreData {prfxStr = "Viper", attCodeA = 1, attCodeB = 6, attCodeC = 2, attCodeD = 7}},
                {35, new PreData {prfxStr = "Wanderer", attCodeA = 1, attCodeB = 4, attCodeC = 3, attCodeD = 5}},
                {36, new PreData {prfxStr = "Zealot", attCodeA = 1, attCodeB = 2, attCodeC = 9, attCodeD = 0}}
            };

        public class PreData
        {
            public string prfxStr;
            public int attCodeA;
            public int attCodeB;
            public int attCodeC;
            public int attCodeD;
        }
    }
}
