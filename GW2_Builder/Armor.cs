using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2_Builder
{
    public class ArmorDataClass
    {
        public class SavedArmorData
        {
            public string armorRarity;
            public string armorClass;
            public int defValue;
            public int attPriTri;
            public int attSecTri;
            public int attPriQuad;
            public int attSecQuad;
            public int attOmni;
        }

        public static Dictionary<int, SavedArmorData> HeadRef = new Dictionary<int, SavedArmorData>()
        {
            {0, new SavedArmorData{armorRarity = "None", armorClass = "None", defValue = 0, attPriTri = 0,
                attSecTri = 0, attPriQuad = 0, attSecQuad = 0, attOmni = 0}},
            {1, new SavedArmorData{armorRarity = "Exotic", armorClass = "Light", defValue = 73, attPriTri = 60,
                attSecTri = 43, attPriQuad = 51, attSecQuad = 28, attOmni = 28}},
            {2, new SavedArmorData{armorRarity = "Exotic", armorClass = "Medium", defValue = 97, attPriTri = 60,
                attSecTri = 43, attPriQuad = 51, attSecQuad = 28, attOmni = 28}},
            {3, new SavedArmorData{armorRarity = "Exotic", armorClass = "Heavy", defValue = 121, attPriTri = 60,
                attSecTri = 43, attPriQuad = 51, attSecQuad = 28, attOmni = 28}},
            {4, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 77, attPriTri = 63,
                attSecTri = 45, attPriQuad = 54, attSecQuad = 30, attOmni = 30}},
            {5, new SavedArmorData{armorRarity = "Ascended", armorClass = "Medium", defValue = 102, attPriTri = 63,
                attSecTri = 45, attPriQuad = 54, attSecQuad = 30, attOmni = 30}},
            {6, new SavedArmorData{armorRarity = "Ascended", armorClass = "Heavy", defValue = 127, attPriTri = 63,
                attSecTri = 45, attPriQuad = 54, attSecQuad = 30, attOmni = 30}}
        };

        public static Dictionary<int, SavedArmorData> ShoulderRef = new Dictionary<int, SavedArmorData>()
        {
            {0, new SavedArmorData{armorRarity = "None", armorClass = "None", defValue = 0, attPriTri = 0,
                attSecTri = 0, attPriQuad = 0, attSecQuad = 0, attOmni = 0}},
            {1, new SavedArmorData{armorRarity = "Exotic", armorClass = "Light", defValue = 73, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21}},
            {2, new SavedArmorData{armorRarity = "Exotic", armorClass = "Medium", defValue = 97, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21}},
            {3, new SavedArmorData{armorRarity = "Exotic", armorClass = "Heavy", defValue = 121, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21}},
            {4, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 77, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}},
            {5, new SavedArmorData{armorRarity = "Ascended", armorClass = "Medium", defValue = 102, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}},
            {6, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 127, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}}
        };

        public static Dictionary<int, SavedArmorData> ChestRef = new Dictionary<int, SavedArmorData>()
        {
            {0, new SavedArmorData{armorRarity = "None", armorClass = "None", defValue = 0, attPriTri = 0,
                attSecTri = 0, attPriQuad = 0, attSecQuad = 0, attOmni = 0}},
            {1, new SavedArmorData{armorRarity = "Exotic", armorClass = "Light", defValue = 314, attPriTri = 134,
                attSecTri = 96, attPriQuad = 115, attSecQuad = 63, attOmni = 63}},
            {2, new SavedArmorData{armorRarity = "Exotic", armorClass = "Medium", defValue = 338, attPriTri = 134,
                attSecTri = 96, attPriQuad = 115, attSecQuad = 63, attOmni = 63}},
            {3, new SavedArmorData{armorRarity = "Exotic", armorClass = "Heavy", defValue = 363, attPriTri = 134,
                attSecTri = 96, attPriQuad = 115, attSecQuad = 63, attOmni = 63}},
            {4, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 330, attPriTri = 141,
                attSecTri = 101, attPriQuad = 121, attSecQuad = 67, attOmni = 67}},
            {5, new SavedArmorData{armorRarity = "Ascended", armorClass = "Medium", defValue = 355, attPriTri = 141,
                attSecTri = 101, attPriQuad = 121, attSecQuad = 67, attOmni = 67}},
            {6, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 381, attPriTri = 141,
                attSecTri = 101, attPriQuad = 121, attSecQuad = 67, attOmni = 67}}
        };

        public static Dictionary<int, SavedArmorData> HandsRef = new Dictionary<int, SavedArmorData>()
        {
            {0, new SavedArmorData{armorRarity = "None", armorClass = "None", defValue = 0, attPriTri = 0,
                attSecTri = 0, attPriQuad = 0, attSecQuad = 0, attOmni = 0}},
            {1, new SavedArmorData{armorRarity = "Exotic", armorClass = "Light", defValue = 133, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21 }},
            {2, new SavedArmorData{armorRarity = "Exotic", armorClass = "Medium", defValue = 157, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21}},
            {3, new SavedArmorData{armorRarity = "Exotic", armorClass = "Heavy", defValue = 182, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21}},
            {4, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 140, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}},
            {5, new SavedArmorData{armorRarity = "Ascended", armorClass = "Medium", defValue = 165, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}},
            {6, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 191, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}}
        };

        public static Dictionary<int, SavedArmorData> LegRef = new Dictionary<int, SavedArmorData>()
        {
            {0, new SavedArmorData{armorRarity = "None", armorClass = "None", defValue = 0, attPriTri = 0,
                attSecTri = 0, attPriQuad = 0, attSecQuad = 0, attOmni = 0}},
            {1, new SavedArmorData{armorRarity = "Exotic", armorClass = "Light", defValue = 194, attPriTri = 90,
                attSecTri = 64, attPriQuad = 77, attSecQuad = 42, attOmni = 42}},
            {2, new SavedArmorData{armorRarity = "Exotic", armorClass = "Medium", defValue = 218, attPriTri = 90,
                attSecTri = 64, attPriQuad = 77, attSecQuad = 42, attOmni = 42}},
            {3, new SavedArmorData{armorRarity = "Exotic", armorClass = "Heavy", defValue = 242, attPriTri = 90,
                attSecTri = 64, attPriQuad = 77, attSecQuad = 42, attOmni = 42}},
            {4, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 203, attPriTri = 94,
                attSecTri = 67, attPriQuad = 81, attSecQuad = 44, attOmni = 44}},
            {5, new SavedArmorData{armorRarity = "Ascended", armorClass = "Medium", defValue = 229, attPriTri = 94,
                attSecTri = 67, attPriQuad = 81, attSecQuad = 44, attOmni = 44}},
            {6, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 254, attPriTri = 94,
                attSecTri = 67, attPriQuad = 81, attSecQuad = 44, attOmni = 44}}
        };

        public static Dictionary<int, SavedArmorData> FeetRef = new Dictionary<int, SavedArmorData>()
        {
            {0, new SavedArmorData{armorRarity = "None", armorClass = "None", defValue = 0, attPriTri = 0,
                attSecTri = 0, attPriQuad = 0, attSecQuad = 0, attOmni = 0}},
            {1, new SavedArmorData{armorRarity = "Exotic", armorClass = "Light", defValue = 133, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21}},
            {2, new SavedArmorData{armorRarity = "Exotic", armorClass = "Medium", defValue = 157, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21}},
            {3, new SavedArmorData{armorRarity = "Exotic", armorClass = "Heavy", defValue = 182, attPriTri = 45,
                attSecTri = 32, attPriQuad = 38, attSecQuad = 21, attOmni = 21}},
            {4, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 140, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}},
            {5, new SavedArmorData{armorRarity = "Ascended", armorClass = "Medium", defValue = 165, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}},
            {6, new SavedArmorData{armorRarity = "Ascended", armorClass = "Light", defValue = 191, attPriTri = 47,
                attSecTri = 34, attPriQuad = 40, attSecQuad = 22, attOmni = 22}}
        };



        public static int DefenseSum(int profCode, ref int[] rarityCode)
        {
            int[] refVal = { 0, 0, 0, 0, 0, 0 };
            int defSum = 0;

            if (profCode > 0)
            {
                for (int a = 0; a < 6; a++)
                {
                    refVal[a] = profCode + ((rarityCode[a] - 1) * 3);
                }
                defSum += HeadRef[refVal[0]].defValue;
                defSum += ShoulderRef[refVal[1]].defValue;
                defSum += ChestRef[refVal[2]].defValue;
                defSum += HandsRef[refVal[3]].defValue;
                defSum += LegRef[refVal[4]].defValue;
                defSum += FeetRef[refVal[5]].defValue;
                return defSum;
            }
            else
            {
                return 0;
            }
        }
    }
}
