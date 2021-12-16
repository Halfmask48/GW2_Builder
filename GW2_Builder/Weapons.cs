using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2_Builder
{
	public class Weapons
	{
		public class SavedWeaponData
		{
			public string weaponRarity;
			public string weaponName;
			public int strengthMinimum;
			public int strengthMaximum;
			public int defenseValue;
			public int primaryAttributeTriple;
			public int secondaryAttributeTriple;
			public int primaryAttributeQuartet;
			public int secondaryAttributeQuartet;
			public int attributeOmni;
			public bool twoHand;
		}

		public static Dictionary<int, SavedWeaponData> WeaponReference = new Dictionary<int, SavedWeaponData>()
		{
			{0, new SavedWeaponData{weaponRarity = "None", weaponName = "None", defenseValue = 0, strengthMinimum = 0,
				strengthMaximum = 0, primaryAttributeTriple = 0, secondaryAttributeTriple = 0,
				primaryAttributeQuartet = 0, secondaryAttributeQuartet = 0, attributeOmni = 0, twoHand = false}},
			{1, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Axe", defenseValue = 0,
				strengthMinimum = 857, strengthMaximum = 1048, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{2, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Dagger", defenseValue = 0,
				strengthMinimum = 924, strengthMaximum = 981, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{3, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Mace", defenseValue = 0,
				strengthMinimum = 895, strengthMaximum = 1010, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{4, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Pistol", defenseValue = 0,
				strengthMinimum = 876, strengthMaximum = 1029, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{5, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Sword", defenseValue = 0,
				strengthMinimum = 905, strengthMaximum = 1000, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{6, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Scepter", defenseValue = 0,
				strengthMinimum = 895, strengthMaximum = 1010, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{7, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Focus", defenseValue = 0,
				strengthMinimum = 832, strengthMaximum = 883, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{8, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Shield", defenseValue = 61,
				strengthMinimum = 806, strengthMaximum = 909, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{9, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Torch", defenseValue = 0,
				strengthMinimum = 789, strengthMaximum = 926, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{10, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Warhorn", defenseValue = 0,
				strengthMinimum = 814, strengthMaximum = 900, primaryAttributeTriple = 120,
				secondaryAttributeTriple = 85, primaryAttributeQuartet = 102, secondaryAttributeQuartet = 56,
				attributeOmni = 56, twoHand = false}},
			{11, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Greatsword", defenseValue = 0,
				strengthMinimum = 995, strengthMaximum = 1100, primaryAttributeTriple = 239,
				secondaryAttributeTriple = 171, primaryAttributeQuartet = 205, secondaryAttributeQuartet = 113,
				attributeOmni = 113, twoHand = true}},
			{12, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Hammer", defenseValue = 0,
				strengthMinimum = 985, strengthMaximum = 1111, primaryAttributeTriple = 239,
				secondaryAttributeTriple = 171, primaryAttributeQuartet = 205, secondaryAttributeQuartet = 113,
				attributeOmni = 113, twoHand = true}},
			{13, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Longbow", defenseValue = 0,
				strengthMinimum = 920, strengthMaximum = 1080, primaryAttributeTriple = 239,
				secondaryAttributeTriple = 171, primaryAttributeQuartet = 205, secondaryAttributeQuartet = 113,
				attributeOmni = 113, twoHand = true}},
			{14, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Rifle", defenseValue = 0,
				strengthMinimum = 986, strengthMaximum = 1205, primaryAttributeTriple = 239,
				secondaryAttributeTriple = 171, primaryAttributeQuartet = 205, secondaryAttributeQuartet = 113,
				attributeOmni = 113, twoHand = true}},
			{15, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Short bow", defenseValue = 0,
				strengthMinimum = 905, strengthMaximum = 1000, primaryAttributeTriple = 239,
				secondaryAttributeTriple = 171, primaryAttributeQuartet = 205, secondaryAttributeQuartet = 113,
				attributeOmni = 113, twoHand = true}},
			{16, new SavedWeaponData{weaponRarity = "Exotic", weaponName = "Staff", defenseValue = 0,
				strengthMinimum = 985, strengthMaximum = 1111, primaryAttributeTriple = 239,
				secondaryAttributeTriple = 171, primaryAttributeQuartet = 205, secondaryAttributeQuartet = 113,
				attributeOmni = 113, twoHand = true}}
		};
	}
}
