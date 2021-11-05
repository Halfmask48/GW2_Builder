using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2_Builder
{
    /// <summary>
    /// <c><b>Attributes</b></c> contains the active values for calculation.
    /// <list type="bullet">
    /// <item><description><para><em><b>AttribRef</b> contains the attribute codes used by the program.
    /// </em></para></description></item>
    /// <item><description><para><em><b>RecalAttributes(int, int)</b> calculates the derived attributes.
    /// </em></para></description></item>
    /// </list>
    /// </summary>
    public class Attributes
    {
        // The primary attributes. Receives a +1000 value at level 80 in-game.

        public int powerTotal = 1000;      // Total power from all gear. Used to determine attack damage value.
        public int preciTotal = 1000;      // Total precision. Used to calculate critical chance.
        public int toughTotal = 1000;      // Total toughness. Used to calculate armor.
        public int vitalTotal = 1000;      // Total vitality. Used to calculate health.

        // The secondary attributes. Receives no base value added at level 80.

        public int conceTotal;      // Total concentration. Used to calculate boon duration.
        public int condiTotal;      // Total condition damage. Used to calculate effect damage (i.e. bleeding, burning, etc.).
        public int experTotal;      // Total expertise. Used to calculate condition duration.
        public int ferocTotal;      // Total ferocity. Used to calculate critical damage.
        public int healingTotal;      // Total healing power. Used to calculate ability healing values.

        // The derived attributes. All calculate from the previous two attribute categories.

        public int armorTotal;          // Total armor. Calculated from adding toughness and defense.
        public double boonDuration;     // Added time for all boons. Calculated from concentration.
        public double critChance;       // Chance of critical attack. Calculated from precision.
        public double critDamage;       // Damage amp for critical attacks. Calculated from ferocity.
        public double condiDuration;    // Added time for all outgoing conditions. Calculated from expertise.
        public int healthTotal;         // Total health. Calculated from profession and vitality.

        // The attribute codes, and their names.
        /// <summary>
        /// <c>AttribRef</c> contains the attribute codes used by the program, and their matching names.
        /// </summary>
        public static Dictionary<int, string> AttribRef = new Dictionary<int, string>()
        {
            {0, ""}, {1, "Power"}, {2, "Precision"}, {3, "Toughness"}, {4, "Vitality"}, {5, "Concentration"},
            {6, "Condition Damage"}, {7, "Expertise"}, {8, "Ferocity"}, {9, "Healing Power"}
        };

        /// <summary>
        /// <c><b>RecalAttributes</b></c> calculates the derived attributes from the primary and secondary attributes.
        /// <list type="bullet">
        /// <item><description><para><em><b>defense</b> The defense value, added from the armor selected.
        /// </em></para></description></item>
        /// <item><description><para><em><b>profHealth</b>The base health value, determined by the selected profession.
        /// </em></para></description></item>
        /// </list>
        /// </summary>
        public void RecalAttributes(int defense, int profHealth)
        {
            armorTotal = toughTotal + defense;
            boonDuration = conceTotal / 15;
            critChance = 5 + ((preciTotal - 100) / 21);
            critDamage = 150 + (ferocTotal / 15);
            condiDuration = experTotal / 15;
            healthTotal = profHealth + (10 * vitalTotal);
        }

        public void AddAtt(int attCode, int attValue)
        {
            if (attCode > 0)
            {
                switch (attCode)
                {
                    case 1:
                        powerTotal += attValue;
                        break;
                    case 2:
                        preciTotal += attValue;
                        break;
                    case 3:
                        toughTotal += attValue;
                        break;
                    case 4:
                        vitalTotal += attValue;
                        break;
                    case 5:
                        conceTotal += attValue;
                        break;
                    case 6:
                        condiTotal += attValue;
                        break;
                    case 7:
                        experTotal += attValue;
                        break;
                    case 8:
                        ferocTotal += attValue;
                        break;
                    case 9:
                        healingTotal += attValue;
                        break;
                }
            }
            else
            {
                return;
            }
        }
    }
}
