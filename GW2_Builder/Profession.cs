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
    /// <summary>
    /// <c><b>ProfessionData</b></c> contains colors and data for the Guild Wars 2 professions.
    /// <list type="bullet">
    /// <item><description><para><em><b>ProfRef</b> contains the data for a selected profession, using <b>ProfData</b> 
    /// to hold information.</em></para></description></item>
    /// <item><description><para><em><b>ProfData</b> is a data class, used for holding information on a selected 
    /// profession.</em></para></description></item>
    /// </list>
    /// </summary>
    public class ProfessionData
    {
        public static Color GuardianBlue = Color.FromArgb(0xFF, 0x72, 0xC1, 0xD9);
        public static Color RevenantRed = Color.FromArgb(0xFF, 0xD1, 0x6E, 0x5A);
        public static Color WarriorYellow = Color.FromArgb(0xFF, 0xFF, 0xD1, 0x66);
        public static Color EngineerOrange = Color.FromArgb(0xFF, 0xD0, 0x9C, 0x59);
        public static Color RangerLime = Color.FromArgb(0xFF, 0x8C, 0xDC, 0x82);
        public static Color ThiefBrown = Color.FromArgb(0xFF, 0xC0, 0x8F, 0x95);
        public static Color ElementalistRose = Color.FromArgb(0xFF, 0xDC, 0x42, 0x3E);
        public static Color MesmerViolet = Color.FromArgb(0xFF, 0xB6, 0x79, 0xD5);
        public static Color NecromancerGreen = Color.FromArgb(0xFF, 0x52, 0xA7, 0x6F);

        public static Dictionary<int, ProfData> ProfRef = new Dictionary<int, ProfData>()
            {
                {1, new ProfData {profColor = GuardianBlue, profName = "Guardian", armorClassCode = 3, healthClass = 9212}},
                {2, new ProfData {profColor = RevenantRed, profName = "Revenant", armorClassCode = 3, healthClass = 9212}},
                {3, new ProfData {profColor = WarriorYellow, profName = "Warrior", armorClassCode = 3, healthClass = 9212}},
                {4, new ProfData {profColor = EngineerOrange, profName = "Engineer", armorClassCode = 2, healthClass = 5922}},
                {5, new ProfData {profColor = RangerLime, profName = "Ranger", armorClassCode = 2, healthClass = 5922}},
                {6, new ProfData {profColor = ThiefBrown, profName = "Thief", armorClassCode = 2, healthClass = 5922}},
                {7, new ProfData {profColor = ElementalistRose, profName = "Elementalist", armorClassCode = 1, healthClass = 1645}},
                {8, new ProfData {profColor = MesmerViolet, profName = "Mesmer", armorClassCode = 1, healthClass = 1645}},
                {9, new ProfData {profColor = NecromancerGreen, profName = "Necromancer", armorClassCode = 1, healthClass = 1645}}
            };

        public class ProfData
        {
            public Color profColor;
            public string profName;
            public int armorClassCode;
            public int healthClass;
        }

    }
}