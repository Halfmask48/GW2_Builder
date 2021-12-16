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
    public partial class GWBuilder : Form
    {

        protected int[] rarityArmor = { 1, 1, 1, 1, 1, 1 };
        protected int armorCode = 0;
        protected int baseHealth = 0;

        private bool classSelectTrue;

        public GWBuilder()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetComboBoxes();
            RecalculateValues();
            // When the form            
        }

        // The following nine methods handle clicking on the picture-boxes to set the class.
        private void GuardianPictureBox_Click(object sender, EventArgs e)
        {
            GuardianPictureBox.BackColor = PictureBoxClick(1);
        }

        private void RevenantPictureBox_Click(object sender, EventArgs e)
        {
            RevenantPictureBox.BackColor = PictureBoxClick(2);
        }

        private void WarriorPictureBox_Click(object sender, EventArgs e)
        {
            WarriorPictureBox.BackColor = PictureBoxClick(3);
        }

        private void EngineerPictureBox_Click(object sender, EventArgs e)
        {
            EngineerPictureBox.BackColor = PictureBoxClick(4);
        }

        private void RangerPictureBox_Click(object sender, EventArgs e)
        {
            RangerPictureBox.BackColor = PictureBoxClick(5);
        }

        private void ThiefPictureBox_Click(object sender, EventArgs e)
        {
            ThiefPictureBox.BackColor = PictureBoxClick(6);
        }

        private void ElementalistPictureBox_Click(object sender, EventArgs e)
        {
            ElementalistPictureBox.BackColor = PictureBoxClick(7);
        }

        private void MesmerPictureBox_Click(object sender, EventArgs e)
        {
            MesmerPictureBox.BackColor = PictureBoxClick(8);
        }

        private void NecromancerPictureBox_Click(object sender, EventArgs e)
        {
            NecromancerPictureBox.BackColor = PictureBoxClick(9);
        }

        // The following six methods handle the rarity buttons being toggled between rarities.
        private void HeadButton_Click_1(object sender, EventArgs e)
        {
            HeadButton.BackColor = RarityButtonColor(0);
            HeadButton.Text = RarityButtonText(0);
        }

        private void ShoulderButton_Click(object sender, EventArgs e)
        {
            ShoulderButton.BackColor = RarityButtonColor(1);
            ShoulderButton.Text = RarityButtonText(1);
        }

        private void ChestButton_Click(object sender, EventArgs e)
        {
            ChestButton.BackColor = RarityButtonColor(2);
            ChestButton.Text = RarityButtonText(2);
        }

        private void HandButton_Click(object sender, EventArgs e)
        {
            HandButton.BackColor = RarityButtonColor(3);
            HandButton.Text = RarityButtonText(3);
        }

        private void LegButton_Click(object sender, EventArgs e)
        {
            LegButton.BackColor = RarityButtonColor(4);
            LegButton.Text = RarityButtonText(4);
        }

        private void FeetButton_Click(object sender, EventArgs e)
        {
            FeetButton.BackColor = RarityButtonColor(5);
            FeetButton.Text = RarityButtonText(5);
        }

        private void HeadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateValues();
        }

        private void ShoulderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateValues();
        }

        private void ChestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateValues();
        }

        private void HandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateValues();
        }

        private void LegComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateValues();
        }

        private void FeetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateValues();
        }

        /// <summary>
        /// <c><b>RecalculateValues</b></c> is run every time the user changes a value in the program.
        /// It reads all selected values, and calculates the resulting attributes.
        /// </summary>
        public void RecalculateValues()
        {
            int defTotal;

            Attributes RecalAtt = new Attributes();

            for (int z = 0; z < 6; z++)
            {
                AttSender(z, RecalAtt);
            }
            defTotal = ArmorDataClass.DefenseSum(armorCode, ref rarityArmor);
            RecalAtt.RecalAttributes(defTotal, baseHealth);
            ReloadLabels(RecalAtt, defTotal);
        }

        /// <summary>
        /// <c><b>AttSender</b></c> receives the active Attributes object, with an armor code,
        /// determines which prefix is selected, adds the values to the attributes object, and
        /// returns it to <c><b>RecalculateValues()</b></c>
        /// <list type="bullet">
        /// <item><description><para><em><b>piece</b> The armor slot being examined (i.e. head, 
        /// chest, etc...)</em></para></description></item>
        /// <item><description><para><em><b>attSend</b> The active Attributes class object. It will
        /// contain all the added attributes.</em></para></description></item>
        /// </list>
        /// </summary>
        private void AttSender(int piece, Attributes attSend)
        {
            int[] preHolder = { 0, 0, 0, 0 };
            int prefixSel;
            int tempArmorClass = armorCode + ((rarityArmor[piece] - 1) * 3);
            ArmorDataClass.SavedArmorData tempArmorRef;

            switch (piece)
            {
                case 0:
                    tempArmorRef = ArmorDataClass.HeadRef[tempArmorClass];
                    prefixSel = HeadComboBox.SelectedIndex;
                    if (prefixSel < 0) { prefixSel = 0; }
                    break;
                case 1:
                    tempArmorRef = ArmorDataClass.ShoulderRef[tempArmorClass];
                    prefixSel = ShoulderComboBox.SelectedIndex;
                    if (prefixSel < 0) { prefixSel = 0; }
                    break;
                case 2:
                    tempArmorRef = ArmorDataClass.ChestRef[tempArmorClass];
                    prefixSel = ChestComboBox.SelectedIndex;
                    if (prefixSel < 0) { prefixSel = 0; }
                    break;
                case 3:
                    tempArmorRef = ArmorDataClass.HandsRef[tempArmorClass];
                    prefixSel = HandComboBox.SelectedIndex;
                    if (prefixSel < 0) { prefixSel = 0; }
                    break;
                case 4:
                    tempArmorRef = ArmorDataClass.LegRef[tempArmorClass];
                    prefixSel = LegComboBox.SelectedIndex;
                    if (prefixSel < 0) { prefixSel = 0; }
                    break;
                case 5:
                    tempArmorRef = ArmorDataClass.FeetRef[tempArmorClass];
                    prefixSel = FeetComboBox.SelectedIndex;
                    if (prefixSel < 0) { prefixSel = 0; }
                    break;
                default:
                    tempArmorRef = ArmorDataClass.HeadRef[0];
                    prefixSel = HeadComboBox.SelectedIndex;
                    if (prefixSel < 0) { prefixSel = 0; }
                    break;
            }

            preHolder[0] = PrefixData.PrefixRef[prefixSel].attCodeA;
            preHolder[1] = PrefixData.PrefixRef[prefixSel].attCodeB;
            preHolder[2] = PrefixData.PrefixRef[prefixSel].attCodeC;
            preHolder[3] = PrefixData.PrefixRef[prefixSel].attCodeD;

            if (prefixSel == 7)
            {
                for (int a = 1; a < 10; a++)
                {
                    attSend.AddAtt(a, tempArmorRef.attOmni);
                }
            }
            else if (preHolder[3] == 0)
            {
                attSend.AddAtt(preHolder[0], tempArmorRef.attPriTri);
                attSend.AddAtt(preHolder[1], tempArmorRef.attSecTri);
                attSend.AddAtt(preHolder[2], tempArmorRef.attSecTri);
            }
            else
            {
                attSend.AddAtt(preHolder[0], tempArmorRef.attPriQuad);
                attSend.AddAtt(preHolder[1], tempArmorRef.attPriQuad);
                attSend.AddAtt(preHolder[2], tempArmorRef.attSecQuad);
                attSend.AddAtt(preHolder[3], tempArmorRef.attSecQuad);
            }
        }

        /// <summary>
        /// <c><b>ReloadLables</b></c> will take the values from the active Attributes class
        /// object, and load them into the matching label objects of the GUI.
        /// <list type="bullet">
        /// <item><description><para><em><b>Values</b> The active Attributes class object. It will
        /// contain all added values, and calculated totals.</em></para></description></item>
        /// <item><description><para><em><b>defense</b> The total armor defense value, stored
        /// separatly from the other values.</em></para></description></item>
        /// </list>
        /// </summary>
        private void ReloadLabels(Attributes Values, int defense)
        {
            PowerValueLabel.Text = Values.powerTotal.ToString();
            PreciValueLabel.Text = Values.preciTotal.ToString();
            ToughValueLabel.Text = Values.toughTotal.ToString();
            VitalValueLabel.Text = Values.vitalTotal.ToString();
            ConceValueLabel.Text = Values.conceTotal.ToString();
            CondiValueLabel.Text = Values.condiTotal.ToString();
            ExperValueLabel.Text = Values.experTotal.ToString();
            FerocValueLabel.Text = Values.ferocTotal.ToString();
            HealPValueLabel.Text = Values.healingTotal.ToString();
            DefenseValueLabel.Text = defense.ToString();
            ArmorValueLabel.Text = Values.armorTotal.ToString();
        }

        private Color PictureBoxClick(int identify)
        {
            ProfessionData.ProfData temp = ProfessionData.ProfRef[identify];

            if (classSelectTrue == false)
            {
                /* If there is no profession already selected, then I will change all text and colors, and update
                values to reflect the selected profession. Finally, I will recalculate all values. */
                classSelectTrue = true;

                ProfessionLabel.Text = temp.profName;
                ProfessionLabel.BackColor = temp.profColor;
                armorCode = temp.armorClassCode;
                baseHealth = temp.healthClass;
                RecalculateValues();
                return temp.profColor;
            }
            else if (ProfessionLabel.Text == temp.profName)
            {
                /* If this profession has already been selected, then I will reset all values and colors, and deselect
                the profession. */ 
                classSelectTrue = false;
                ProfessionLabel.Text = "None Selected";
                ProfessionLabel.BackColor = SystemColors.Control;
                baseHealth = 0;
                armorCode = 0;
                RecalculateValues();
                return SystemColors.Control;
            }
            else
            {
                // If another profession has already been selected, I simply return the default color.
                return SystemColors.Control;
            }
        }

        private Color RarityButtonColor(int identify)
        {
            // Changes the armor rarity for the button pressed, and recalculates the attributes. Returns the rarity color.
            if (rarityArmor[identify] == 1)
            {
                rarityArmor[identify] = 2;
                RecalculateValues();
                return Color.Pink;
            }
            else
            {
                rarityArmor[identify] = 1;
                RecalculateValues();
                return Color.Orange;
            }
        }

        private string RarityButtonText(int identify)
        {
            // Determines what rarity is selected, via the method "RarityButtonColor", and sets the correct text.
            if (rarityArmor[identify] == 2)
            {
                return "Ascended";
            }
            else
            {
                return "Exotic";
            }
        }

        private void SetComboBoxes()
        {
            for (int a = 0; a < 36; a++)
            {
                HeadComboBox.Items.Add(AttributeFormatText(a));
            }

            for (int b = 0; b < 36; b++)
            {
                ShoulderComboBox.Items.Add(AttributeFormatText(b));
            }

            for (int c = 0; c < 36; c++)
            {
                ChestComboBox.Items.Add(AttributeFormatText(c));
            }

            for (int d = 0; d < 36; d++)
            {
                HandComboBox.Items.Add(AttributeFormatText(d));
            }

            for (int e = 0; e < 36; e++)
            {
                LegComboBox.Items.Add(AttributeFormatText(e));
            }

            for (int f = 0; f < 36; f++)
            {
                FeetComboBox.Items.Add(AttributeFormatText(f));
            }
        }

        private string AttributeFormatText(int identify)
        {
            PrefixData.PreData preTemp = PrefixData.PrefixRef[identify];
            string attOne = Attributes.AttribRef[preTemp.attCodeA];
            string attTwo = Attributes.AttribRef[preTemp.attCodeB];
            string attThree = Attributes.AttribRef[preTemp.attCodeC];
            string attFour = Attributes.AttribRef[preTemp.attCodeD];

            if (identify == 7)
            {
                return preTemp.prfxStr + ": ALL ATTRIBUTES";
            }
            else if (identify == 0)
            {
                return preTemp.prfxStr;
            }
            else if (preTemp.attCodeD == 0)
            {
                return preTemp.prfxStr + ": " + attOne.ToUpper() + ", " + attTwo + ", " + attThree;
            }
            else
            {
                return preTemp.prfxStr + ": " + attOne.ToUpper() + ", " + attTwo.ToUpper() + ", " + attThree + ", " +
                    attFour;
            }
        }
    }
}