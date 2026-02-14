using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x0200013B RID: 315
public class EKBAPCMPANI : ItemBase
{
	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06004174 RID: 16756 RVA: 0x001D911C File Offset: 0x001D731C
	public bool IEHCLOIEBJA
	{
		get
		{
			bool result = false;
			if (this.BDHHPAEHFHG.FOAPCABBLBG && this.BGGJKOMAKEE > 0)
			{
				int num = (int)(this.DLHPFGHOINI / (float)this.BGGJKOMAKEE * 100f);
				if (this.DLHPFGHOINI < 20f && num < 30)
				{
					result = true;
				}
			}
			if (this.MJHGLLIJMIM)
			{
				result = true;
			}
			return result;
		}
	}

	// Token: 0x06004175 RID: 16757 RVA: 0x001D9176 File Offset: 0x001D7376
	public IIBEEKCAAHK EMBKDHKGIEL()
	{
		return this.LODGJCMEGAI;
	}

	// Token: 0x06004176 RID: 16758 RVA: 0x001D9180 File Offset: 0x001D7380
	public string DEKKACKHJDF(NEBJANKNJOG EEPNACDOOBF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (this.BDHHPAEHFHG.MBOOFLANJID != 0)
		{
			bool flag = true;
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1 && EEPNACDOOBF.GDJMBFGEMFJ != 1)
			{
				flag = true;
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 7 && EEPNACDOOBF.GDJMBFGEMFJ != 0)
			{
				flag = false;
			}
			string arg = "GestureHandUp";
			if (flag)
			{
				arg = "\n";
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 0)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.DOEMGEAEBPN("System.Boolean"), arg));
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 7)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.LPHMKPDBMPP().FLEANFGEJML("invn_ver6"), arg));
			}
		}
		if (this.PKIICJOILKI.Count > 0)
		{
			foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
			{
				bool flag2 = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) >= dlmglijdiai.CNOLCNDBLJE;
				string text = "";
				if (flag2)
				{
					text = "BaseMaterial";
				}
				StringBuilder stringBuilder2 = stringBuilder;
				string format = "auk_wavg";
				object[] array = new object[1];
				array[1] = text;
				array[0] = dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN;
				array[1] = dlmglijdiai.CNOLCNDBLJE;
				array[7] = JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("_FogHeightData");
				stringBuilder2.Append(string.Format(format, array));
			}
		}
		if (this.GOEGADLBGML > 0)
		{
			string arg2 = "MB Down lot=";
			if (this.GOEGADLBGML > ObscuredInt.GOOIABGKMHK(EEPNACDOOBF.CNOLCNDBLJE))
			{
				arg2 = "wpn_rec4";
			}
			stringBuilder.Append(string.Format("WeaponRunBackward", arg2, this.GOEGADLBGML, JNBICAJIJMM.DBMJJPBOPEK().FLEANFGEJML("")));
		}
		if (stringBuilder.Length != 0)
		{
			return stringBuilder.ToString();
		}
		return "OfficeSittingMouseMovement";
	}

	// Token: 0x06004177 RID: 16759 RVA: 0x001D937C File Offset: 0x001D757C
	public void MFPPBKEALBO(Vector2 FEEBMFDLDHB)
	{
		if (this.BDHHPAEHFHG == null)
		{
			return;
		}
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		HFIINBICCLO.JFNBEACKGKI().PLDOIIEKPCA(new Rect(vector.x - FEEBMFDLDHB.x, vector.y - FEEBMFDLDHB.y, 648f, 1687f), this.BDHHPAEHFHG.KEEDCOIMPMP(), Color.white);
	}

	// Token: 0x06004178 RID: 16760 RVA: 0x001D93F8 File Offset: 0x001D75F8
	public string FCBNJMANOIB(bool NKFPOLMOKPE = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = this.MBKMKGABBGE;
		if (this.MBKMKGABBGE == 7)
		{
			stringBuilder.Append(JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("MotorbikeWheely") + "IceHockeyShotLeft");
			if (this.BDHHPAEHFHG.JALOCNOIDFJ > 0)
			{
				num = this.BDHHPAEHFHG.JALOCNOIDFJ;
			}
		}
		switch (num)
		{
		case 0:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE("AssetLoader: "), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 0);
			string text = JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)num2);
			if (this.OKHPDILIOCH.Count > 0)
			{
				text = "no_money";
				foreach (int jjjnkodleel in this.OKHPDILIOCH)
				{
					num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, jjjnkodleel);
					text = text + JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)num2) + "turn_base1";
				}
				text = text.Remove(text.Length - 0);
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.EDKGBBIIBBC().FLEANFGEJML("__c"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.EMBKDHKGIEL().OIGIHEPJFFJ()), text));
			stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("UIChat_channel"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.EMBKDHKGIEL().HDPNCIECLKP() / 5.0)));
			string text2 = "ScatterDitherMap";
			if (this.ADOFHHCDGON > 0)
			{
				object[] array = new object[8];
				array[1] = text2;
				array[0] = "{";
				array[0] = JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM("AUTO_KEY_VALUE");
				array[5] = "Sorry, VRIK Script reference is not finished yet.";
				array[1] = this.ADOFHHCDGON;
				array[8] = "CrouchWalkBackward";
				text2 = string.Concat(array);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array2 = new object[3];
				array2[0] = text2;
				array2[0] = "no_money";
				array2[8] = JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("rodEventProc act=");
				array2[3] = "ComeHere";
				array2[2] = this.ECKKCDKHNEH;
				array2[6] = "no_model_fish ";
				text2 = string.Concat(array2);
			}
			if (text2 != "Jump")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("ExceptionOnConnect PROCEDURE "), text2));
			}
			stringBuilder.Append(string.Format("shortCostumeId=" + JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI(" ") + "Giant2HandSlamIdle", this.FJJEAMJNLIO));
			break;
		}
		case 1:
		{
			float num3 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 1);
			stringBuilder.Append(string.Format(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("textAsset is NULL! Path: fishModelData"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.EMBKDHKGIEL().AIMCFAHLPEF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("WateringCan"), JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC(this.MIMANMPNLPE.NMKCBJKHBOH), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)num3)));
			string text3 = "OfficeSittingLegCross";
			if (this.ADOFHHCDGON > 0)
			{
				object[] array3 = new object[7];
				array3[1] = text3;
				array3[0] = "MotorbikeBackwardStand";
				array3[0] = JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("GiantGrabIdle2");
				array3[5] = "human_move_2.wav";
				array3[1] = this.ADOFHHCDGON;
				array3[2] = "IdleReadyCrouch";
				text3 = string.Concat(array3);
			}
			if (this.ECKKCDKHNEH > 1)
			{
				object[] array4 = new object[8];
				array4[1] = text3;
				array4[1] = "WandStand";
				array4[4] = JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("Watering Can Watering");
				array4[2] = "cht_msg8";
				array4[0] = this.ECKKCDKHNEH;
				array4[2] = "SoccerRun";
				text3 = string.Concat(array4);
			}
			if (text3 != "Climb Left")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM("Handlebar Sit"), text3));
			}
			stringBuilder.Append(string.Format("MotorbikeLookBack" + JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("Sound/") + "locid: ", this.FJJEAMJNLIO));
			break;
		}
		case 2:
		{
			float num4 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 0);
			stringBuilder.Append(string.Format(JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN("Sewing"), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.EEOPOHEALPK().HLBAJBLHLNI("{0:0} ч{1}, "), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.OIGIHEPJFFJ()), JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL((double)num4)));
			string text4 = "часа";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array5 = new object[6];
				array5[1] = text4;
				array5[0] = "move";
				array5[4] = JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("Failed parsing default rotation values.  Using defaults.");
				array5[0] = "/";
				array5[5] = this.ADOFHHCDGON;
				array5[0] = "gi_um_2";
				text4 = string.Concat(array5);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array6 = new object[4];
				array6[1] = text4;
				array6[1] = "[sysname]";
				array6[0] = JNBICAJIJMM.IMLLGEMPHAP().NLJOLOBPCBJ("FlyDown");
				array6[3] = "Mouse ScrollWheel";
				array6[5] = this.ECKKCDKHNEH;
				array6[3] = "knopje.wav";
				text4 = string.Concat(array6);
			}
			if (text4 != "****************  stopMusic ")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EDKGBBIIBBC().CKAOHMEKLMH("_DepthCurveLut"), text4));
			}
			stringBuilder.Append(string.Format("ZombieIdle" + JNBICAJIJMM.APMJBBDBOJO().CKAOHMEKLMH("_TapHigh") + "[HA ", this.FJJEAMJNLIO));
			break;
		}
		case 3:
		{
			stringBuilder.Append(JNBICAJIJMM.DCEBAJIILPC("System.Boolean") + "ShotgunFire" + JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH()) + "Flashlight");
			stringBuilder.Append(JNBICAJIJMM.BDKHMOOFHHK("gi_uinf_4i") + "Flap_02.wav" + JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC(this.MIMANMPNLPE.NMKCBJKHBOH) + "Чат очищен");
			string str = JNBICAJIJMM.NGALDMFKMJH("1.6.2");
			if (this.MIMANMPNLPE.CJKILDPJCFJ() > 0)
			{
				str = JNBICAJIJMM.APMJBBDBOJO().FLEANFGEJML("?") + "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" + JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)(this.MIMANMPNLPE.GJBKBEEJLDF() * 76.0));
			}
			stringBuilder.Append(JNBICAJIJMM.DIOJFJMOPJO("CrouchStrafeLeft") + "MotorbikeSeatStand" + str + "_PrefilterOffs");
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("gi_cachhe") + "ShotgunReadyFire", this.BDHHPAEHFHG.LHLMFBEJKGL(1466f)));
			string jmbkdinhdlo = "\\,";
			if (Mathf.Abs(this.BDHHPAEHFHG.MFMLCHFNALC) > 1173f)
			{
				if (this.BDHHPAEHFHG.MFMLCHFNALC > 1131f)
				{
					jmbkdinhdlo = "Roller Blade Turn Right";
				}
				if (this.BDHHPAEHFHG.MFMLCHFNALC < 1861f)
				{
					jmbkdinhdlo = " ";
				}
			}
			stringBuilder.Append("Finished" + string.Format(JNBICAJIJMM.PPNKMDJBMLP(""), JNBICAJIJMM.PPNKMDJBMLP(jmbkdinhdlo)));
			break;
		}
		case 4:
		{
			Vector2 vector = this.KPLOLDJFGBE();
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("offsets") + "wpn_wgt", JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("nowp" + this.BDHHPAEHFHG.ILOCKJIAPFC) + " iterations for read and write", 0));
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("Okay") + "\n", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("IdleStand") + "Error via pay request", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("Player") + "wpn_onlyw", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(vector.x * 1831f)), JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)Mathf.RoundToInt(vector.y * 1983f))));
			break;
		}
		case 5:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("id") + "Vertical", JLFJEGIPIMM.IKGFHGKKCPG.PEGPHIOEKHI(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("{0}/{1}/{2}"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.EMBKDHKGIEL().AIMCFAHLPEF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("") + "KatanaReadyHigh", "BowInstant2" + JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC((double)this.EMBKDHKGIEL().KMGAHCANELI())));
			if (this.MIMANMPNLPE.GJBKBEEJLDF() > 416.0)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("KneesIdle") + "oldvermsg", JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.EMBKDHKGIEL().FJACMDGJEBL())));
			}
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.PKGMBFEMKGP().PBHCNOAPLNN(this.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("_TrStartYou.ogg"), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)iibeekcaahk.KEHIFGILLJA()), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)iibeekcaahk.ICJDPPOJINN)));
			break;
		}
		case 6:
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("The root node, the left upper arm and the right upper arm bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left upper arm and the right upper arm bones. This might cause unwanted behaviour like the spine turning upside down when pulled by a hand effector.Please set the root node bone to be one of the lower bones in the spine.") + "wpn_rod3", JLFJEGIPIMM.PKGMBFEMKGP().MIEDNDLOEJH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("demoQuaternion") + "SneakIdle", JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("auk_wset") + "OfficeSitting1LegStraight", JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("val=") + "Wizard Neo Block", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.GJBKBEEJLDF())));
			break;
		case 7:
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("H:") + " is different than vertices length", JLFJEGIPIMM.IKGFHGKKCPG.KCLHEMJLEFJ(this.NKHBAJKMAGD)));
			break;
		case 8:
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("ArmFlex3") + "offsets", JLFJEGIPIMM.IKGFHGKKCPG.PEGPHIOEKHI(this.NKHBAJKMAGD)));
			if (this.BBLEPPMMPIL("BowIdle", "[WH Detector Service]").DGEEJKEEHPE())
			{
				stringBuilder.Append(JNBICAJIJMM.PGJCPFNJNPM("MotorbikeTurnRight"));
			}
			break;
		case 9:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("RollerBladeFrontFlip") + "", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.EMBKDHKGIEL().DHJBAKDAMGH())));
			string str2 = JNBICAJIJMM.CELEPPAEKAB("LOC_NAMES" + this.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
			stringBuilder.Append(str2 + "Walk Backward");
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("info"), JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			break;
		}
		case 10:
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("MotorbikeIdle") + "Walk Dehydrated", JLFJEGIPIMM.NNEAHAFBOHC().MIEDNDLOEJH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("HeelClick"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.LNEPKLKELMI)));
			break;
		case 11:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("/") + "WizardBlock", JLFJEGIPIMM.PKGMBFEMKGP().KCLHEMJLEFJ(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH(" %") + "CrouchWalk", JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC(this.EMBKDHKGIEL().DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("Citates.xml") + JNBICAJIJMM.BDKHMOOFHHK("offsets" + this.BDHHPAEHFHG.BBOODPCDKAJ) + "RunningDance", this.BDHHPAEHFHG.BBOODPCDKAJ));
			int ilockjiapfc = this.BDHHPAEHFHG.ILOCKJIAPFC;
			if (ilockjiapfc == 5)
			{
				stringBuilder.Append(JNBICAJIJMM.NGALDMFKMJH("Flares") + "Katana" + string.Format(JNBICAJIJMM.OOOKJHOHPNN("and I needed"), this.BDHHPAEHFHG.GLLIKKONFAJ) + "Player");
			}
			if (ilockjiapfc > 1)
			{
				string jmbkdinhdlo2 = string.Format("\n", ilockjiapfc);
				stringBuilder.Append("IdleDie" + JNBICAJIJMM.DIOJFJMOPJO(jmbkdinhdlo2) + "{");
			}
			break;
		}
		case 15:
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("FBIK chain contains no nodes.") + "1 Hand Sword Jab Foot Push", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.EMBKDHKGIEL().KEHIFGILLJA())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("cht_msg15") + "UIChat_fontSize", this.EMBKDHKGIEL().NLHKFMMDMMK()));
			break;
		case 20:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NKEOCCKEOCE() > 1) ? string.Format(JNBICAJIJMM.CELEPPAEKAB(" L "), this.MIMANMPNLPE.KEHIFGILLJA()) : string.Format(JNBICAJIJMM.LEBHCLDODNI("X"), Mathf.Abs(this.EMBKDHKGIEL().KEHIFGILLJA())));
			}
			if (this.MIMANMPNLPE.KMGAHCANELI() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().KMGAHCANELI() > 1) ? string.Format(JNBICAJIJMM.OOOKJHOHPNN("Missing shader in "), this.EMBKDHKGIEL().KMGAHCANELI()) : string.Format(JNBICAJIJMM.DIOJFJMOPJO("Assets/Weapons/baseLegs.unity3d"), Mathf.Abs(this.EMBKDHKGIEL().KMGAHCANELI())));
			}
			if (this.MIMANMPNLPE.CJKILDPJCFJ() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().NODLBGKEGPM > 1) ? string.Format(JNBICAJIJMM.OOOKJHOHPNN("knopje.wav"), this.MIMANMPNLPE.NFCDJLJNDLO()) : string.Format(JNBICAJIJMM.CELEPPAEKAB("</color>"), Mathf.Abs(this.EMBKDHKGIEL().NODLBGKEGPM)));
			}
			break;
		case 21:
			if (this.MIMANMPNLPE.KEHIFGILLJA() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.DIOJFJMOPJO(""), this.EMBKDHKGIEL().KEHIFGILLJA()) : string.Format(JNBICAJIJMM.LEBHCLDODNI("<b>Supported types:</b>\n"), Mathf.Abs(this.MIMANMPNLPE.KEHIFGILLJA())));
			}
			if (this.EMBKDHKGIEL().KMGAHCANELI() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().NLHKFMMDMMK() > 1) ? string.Format(JNBICAJIJMM.CELEPPAEKAB("WorkerHammer2"), this.MIMANMPNLPE.KMGAHCANELI()) : string.Format(JNBICAJIJMM.BDKHMOOFHHK("2000"), Mathf.Abs(this.EMBKDHKGIEL().KMGAHCANELI())));
			}
			if (this.EMBKDHKGIEL().CJKILDPJCFJ() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 1) ? string.Format(JNBICAJIJMM.PPNKMDJBMLP("_WrinkleInfluences2"), this.EMBKDHKGIEL().CJKILDPJCFJ()) : string.Format(JNBICAJIJMM.PPNKMDJBMLP("_Offsets"), Mathf.Abs(this.EMBKDHKGIEL().NODLBGKEGPM)));
			}
			break;
		case 22:
			if (this.MIMANMPNLPE.KMIOLLENCOL() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 1) ? string.Format(JNBICAJIJMM.PGJCPFNJNPM("id"), this.EMBKDHKGIEL().IBEIBAHKIAH) : string.Format(JNBICAJIJMM.LEBHCLDODNI("OfficeSittingHandRestFingerTap"), Mathf.Abs(this.EMBKDHKGIEL().KEHIFGILLJA())));
			}
			if (this.EMBKDHKGIEL().NLHKFMMDMMK() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().ICJDPPOJINN > 1) ? string.Format(JNBICAJIJMM.DIOJFJMOPJO("wpnlang/weapons/weapon"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.PPNKMDJBMLP("UnityEngine.Vector3"), Mathf.Abs(this.MIMANMPNLPE.KMGAHCANELI())));
			}
			if (this.EMBKDHKGIEL().CJKILDPJCFJ() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.CJKILDPJCFJ() > 1) ? string.Format(JNBICAJIJMM.DIOJFJMOPJO(">"), this.MIMANMPNLPE.CJKILDPJCFJ()) : string.Format(JNBICAJIJMM.OOOKJHOHPNN("gi_tit_inf"), Mathf.Abs(this.EMBKDHKGIEL().NODLBGKEGPM)));
			}
			break;
		case 27:
			if (this.FJKAFCDDDGO != null && this.BPNNJBBCOFO != null)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("qualityLevel"), this.FJKAFCDDDGO.JPBOPFNPNHC(false, -1), this.BPNNJBBCOFO.MNFCAAIAGOL.NLHKFMMDMMK()));
				if (this.MIMANMPNLPE.NFCDJLJNDLO() < 1)
				{
					stringBuilder.Append(JNBICAJIJMM.PGJCPFNJNPM("WizardEyeBeam"));
				}
				else
				{
					stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("help"), this.EMBKDHKGIEL().CJKILDPJCFJ()));
				}
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI(""), CLFFOBKFKDN.IKGFHGKKCPG.CLIEHLMDOAD(this.BPNNJBBCOFO.BKLCKNOLEFD)));
				stringBuilder.Append("gi_nl2");
				string arg = "Flap_04.wav";
				if (NLNNIDBPKAO.IKGFHGKKCPG.JEFCOLDKFPI(this.BPNNJBBCOFO.ABLFIGDGCBG) != null)
				{
					string arg2 = " is represented multiple times in a single IK chain. Can't initiate solver.";
					if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(this.BPNNJBBCOFO.ABLFIGDGCBG) < this.BPNNJBBCOFO.LKCIDOHHADJ)
					{
						arg2 = "fwgt_uniq_m";
					}
					stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("SneakForward"), arg2, arg));
				}
			}
			break;
		case 31:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("Player"), this.EMBKDHKGIEL().LNEPKLKELMI));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("sunshine_ShadowToWorldScale"), this.EMBKDHKGIEL().OIGIHEPJFFJ()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("Leg"), this.EMBKDHKGIEL().HDPNCIECLKP()));
			List<int> list = this.BDHHPAEHFHG.JHCFMFNCOLM("_TrEndWin.ogg", "MovementX").BEJDLFKONDO();
			string text5 = JNBICAJIJMM.CELEPPAEKAB("\n") + "CrouchStrafeLeft";
			foreach (int lpfkfnlhgbi in list)
			{
				text5 = text5 + IHFEDJEMJMB.NNEAHAFBOHC().DOHHCICALIL(lpfkfnlhgbi) + "FlyBackward";
			}
			stringBuilder.Append(text5);
			break;
		}
		case 32:
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("info"), this.EMBKDHKGIEL().DHJBAKDAMGH()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("id"), this.MIMANMPNLPE.OIGIHEPJFFJ()));
			break;
		case 33:
		{
			int num5 = this.EMBKDHKGIEL().NKEOCCKEOCE();
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.DJDLJCFCPPH(num5);
			if (kdhoddmndfc != null)
			{
				bool flag = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num5);
				stringBuilder.Append(flag ? string.Format(JNBICAJIJMM.BDKHMOOFHHK("wpn_eat1"), kdhoddmndfc.KKEBDLGHBMN) : string.Format(JNBICAJIJMM.DIOJFJMOPJO("MotorbikeHandstand"), kdhoddmndfc.KKEBDLGHBMN));
			}
			break;
		}
		case 35:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("1HandSwordJabCombo"), this.MIMANMPNLPE.NMKCBJKHBOH) + "_BlurPass");
			string jmbkdinhdlo3 = "KatanaReadyHigh";
			if (this.MIMANMPNLPE.DBFOHFDOCIB() > 827.0)
			{
				jmbkdinhdlo3 = "<color=\"";
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM(jmbkdinhdlo3), this.MIMANMPNLPE.HDPNCIECLKP()) + "");
			break;
		}
		}
		if (NKFPOLMOKPE)
		{
			if (this.MJHGLLIJMIM)
			{
				stringBuilder.Append(JNBICAJIJMM.PPNKMDJBMLP("Pick Up "));
			}
			if (this.MHNDPGDBPNA.Count > 0)
			{
				stringBuilder.Append("Back to Idle Ready");
				stringBuilder.Append("{not_found}");
				stringBuilder.Append(",");
				stringBuilder.Append("WalkInjured");
				foreach (IIBEEKCAAHK iibeekcaahk2 in this.MHNDPGDBPNA)
				{
					string str3 = iibeekcaahk2.ToString();
					if (iibeekcaahk2.KMIOLLENCOL() == 0)
					{
						string arg3 = AKPJIACDDFI.IKGFHGKKCPG.KOACOPGBPHD(iibeekcaahk2.ICJDPPOJINN, true);
						if (iibeekcaahk2.NODLBGKEGPM > 1)
						{
							str3 = string.Format("droplinemsg1", iibeekcaahk2.CJKILDPJCFJ(), arg3);
						}
						else
						{
							str3 = string.Format("", iibeekcaahk2.CJKILDPJCFJ(), arg3);
						}
					}
					if (iibeekcaahk2.KEHIFGILLJA() == 3)
					{
						string arg4 = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(iibeekcaahk2.ICJDPPOJINN);
						if (iibeekcaahk2.NODLBGKEGPM > 0)
						{
							str3 = string.Format(" is removed", iibeekcaahk2.NFCDJLJNDLO(), arg4);
						}
						else
						{
							str3 = string.Format("wpn_add/addoptions/klevprop", iibeekcaahk2.CJKILDPJCFJ(), arg4);
						}
					}
					if (iibeekcaahk2.NKEOCCKEOCE() == 6)
					{
						string arg5 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk2.NLHKFMMDMMK()).PCLBFMPCKBE(0);
						if (iibeekcaahk2.CJKILDPJCFJ() > 1)
						{
							str3 = string.Format("wpn_dress1", iibeekcaahk2.NODLBGKEGPM, arg5);
						}
						else
						{
							str3 = string.Format("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module).", iibeekcaahk2.CJKILDPJCFJ(), arg5);
						}
					}
					stringBuilder.Append(str3 + "[X]");
				}
			}
			if (this.FGJIJFNGAIF.Count > 0)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(JNBICAJIJMM.DIOJFJMOPJO("Jump"));
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) > 1;
					string arg6 = "FistPump";
					if (flag2)
					{
						arg6 = "knopje.wav";
					}
					string value = string.Format("PlayerPrefs:", arg6, dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai.CNOLCNDBLJE);
					stringBuilder.Append(value);
				}
			}
			if (this.AHLLIPJFCJB != "<color='#808080'>[{2}]</color> <color='#c0c0c0'>{0}</color>: {1}")
			{
				stringBuilder.Append("800000");
				stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("wpn_hook2"), this.AHLLIPJFCJB));
			}
			List<IIBEEKCAAHK> list2 = this.BBLEPPMMPIL("Giant 3 Hit Combo 2", "").BNAMDHOMEHH();
			if (list2.Count > 1)
			{
				stringBuilder.Append("lifeBar");
				stringBuilder.Append(JNBICAJIJMM.CELEPPAEKAB("OfficeSittingReadingPageFlip"));
				foreach (IIBEEKCAAHK iibeekcaahk3 in list2)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(iibeekcaahk3.KEHIFGILLJA());
					stringBuilder.Append(string.Format("u_UniqueShadowLightWidth", iibeekcaahk3.NLHKFMMDMMK(), befchfngomi.BNIHFBMEPAB));
				}
			}
			if (this.ABPGFHKGFEK)
			{
				TimeSpan makoioidpjk = this.MGNLHNLJJLD - DateTime.Now;
				string value2 = string.Format(JNBICAJIJMM.OOOKJHOHPNN("Hidden/Image Effects/Cinematic/Bloom"), JLFJEGIPIMM.MHFDIJGJGBJ().CLDPDFPGMBP(makoioidpjk));
				stringBuilder.Append(value2);
			}
		}
		return "" + stringBuilder + "OnChatMessage";
	}

	// Token: 0x06004179 RID: 16761 RVA: 0x001DAE08 File Offset: 0x001D9008
	public BNOOIOKIFJC.DIGGOHPGCNN BBLEPPMMPIL(string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		EKBAPCMPANI.HFMCCHGPFJF hfmcchgpfjf = new EKBAPCMPANI.HFMCCHGPFJF();
		hfmcchgpfjf.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = hfmcchgpfjf.LJOEIPHIJOE) == null)
			{
				predicate = (hfmcchgpfjf.LJOEIPHIJOE = new Func<XmlNode, bool>(hfmcchgpfjf.BBJKDMMPCGM));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("val=" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("val=");
	}

	// Token: 0x0600417A RID: 16762 RVA: 0x001DAEBC File Offset: 0x001D90BC
	public override string ToString()
	{
		string text = "";
		if (this.BDHHPAEHFHG.FOAPCABBLBG && this.BGGJKOMAKEE > 0)
		{
			int num = (int)(this.DLHPFGHOINI / (float)this.BGGJKOMAKEE * 100f);
			text = string.Format("{0}/{1}", Mathf.RoundToInt(this.DLHPFGHOINI), this.BGGJKOMAKEE);
			if (num < 20)
			{
				text = "<color='#602000'>" + text + "</color>";
			}
			if (num >= 50)
			{
				text = "<color='#206000'>" + text + "</color>";
			}
		}
		return this.JPBOPFNPNHC(false) + string.Format(JNBICAJIJMM.LEBHCLDODNI("inv_pcs1"), this.ILFHHDNJHNM) + text;
	}

	// Token: 0x0600417B RID: 16763 RVA: 0x001DAF74 File Offset: 0x001D9174
	public string PODMCILDOLH(NEBJANKNJOG EEPNACDOOBF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (this.BDHHPAEHFHG.MBOOFLANJID != 0)
		{
			bool flag = false;
			if (this.BDHHPAEHFHG.MBOOFLANJID == 0 && EEPNACDOOBF.GDJMBFGEMFJ != 0)
			{
				flag = false;
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1 && EEPNACDOOBF.GDJMBFGEMFJ != 0)
			{
				flag = true;
			}
			string arg = "Player";
			if (flag)
			{
				arg = "ZombieIdle";
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("right"), arg));
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 4)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("_ScratchTex"), arg));
			}
		}
		if (this.PKIICJOILKI.Count > 1)
		{
			foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
			{
				bool flag2 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) >= dlmglijdiai.CNOLCNDBLJE;
				string text = "ObscuredUShort vs ushort, ";
				if (flag2)
				{
					text = "SoccerKeeperStrafeRight";
				}
				StringBuilder stringBuilder2 = stringBuilder;
				string format = "uint:";
				object[] array = new object[6];
				array[1] = text;
				array[1] = dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN;
				array[1] = dlmglijdiai.CNOLCNDBLJE;
				array[7] = JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD("jamp");
				stringBuilder2.Append(string.Format(format, array));
			}
		}
		if (this.GOEGADLBGML > 1)
		{
			string arg2 = "";
			if (this.GOEGADLBGML > ObscuredInt.LBDMFALMOLD(EEPNACDOOBF.CNOLCNDBLJE))
			{
				arg2 = "Pick Up Ball";
			}
			stringBuilder.Append(string.Format("focus :D", arg2, this.GOEGADLBGML, JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("2000")));
		}
		if (stringBuilder.Length != 0)
		{
			return stringBuilder.ToString();
		}
		return "X (R)";
	}

	// Token: 0x0600417C RID: 16764 RVA: 0x001DB170 File Offset: 0x001D9370
	public string NPEJAOIOKAC(NEBJANKNJOG EEPNACDOOBF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (this.BDHHPAEHFHG.MBOOFLANJID != 0)
		{
			bool flag = false;
			if (this.BDHHPAEHFHG.MBOOFLANJID == 0 && EEPNACDOOBF.GDJMBFGEMFJ != 1)
			{
				flag = false;
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 6 && EEPNACDOOBF.GDJMBFGEMFJ != 0)
			{
				flag = false;
			}
			string arg = "shop_t13";
			if (flag)
			{
				arg = "";
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("<color='#003000'>"), arg));
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 3)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE(" ms"), arg));
			}
		}
		if (this.PKIICJOILKI.Count > 1)
		{
			foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
			{
				bool flag2 = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) < dlmglijdiai.CNOLCNDBLJE;
				string text = "-HYPERLINK";
				if (flag2)
				{
					text = "RollerBladeCrossoverLeft";
				}
				StringBuilder stringBuilder2 = stringBuilder;
				string format = "Player";
				object[] array = new object[2];
				array[0] = text;
				array[0] = dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN;
				array[3] = dlmglijdiai.CNOLCNDBLJE;
				array[3] = JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("Vertical");
				stringBuilder2.Append(string.Format(format, array));
			}
		}
		if (this.GOEGADLBGML > 1)
		{
			string arg2 = "_rcIn.ogg";
			if (this.GOEGADLBGML > ObscuredInt.LBDMFALMOLD(EEPNACDOOBF.CNOLCNDBLJE))
			{
				arg2 = "+";
			}
			stringBuilder.Append(string.Format("", arg2, this.GOEGADLBGML, JNBICAJIJMM.IKGFHGKKCPG.CKAOHMEKLMH("t_much")));
		}
		if (stringBuilder.Length != 0)
		{
			return stringBuilder.ToString();
		}
		return "No IK assigned in HitReaction";
	}

	// Token: 0x0600417D RID: 16765 RVA: 0x001DB36C File Offset: 0x001D956C
	public bool NHNPNMPGJJI()
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		if (this.GOEGADLBGML > ObscuredInt.LBDMFALMOLD(kfhelhglnmh.CNOLCNDBLJE))
		{
			return true;
		}
		foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
		{
			if (dlmglijdiai.CNOLCNDBLJE > kfhelhglnmh.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600417E RID: 16766 RVA: 0x001DB3F4 File Offset: 0x001D95F4
	public string MIFBALOCLFO(NEBJANKNJOG EEPNACDOOBF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (this.BDHHPAEHFHG.MBOOFLANJID != 0)
		{
			bool flag = true;
			if (this.BDHHPAEHFHG.MBOOFLANJID == 0 && EEPNACDOOBF.GDJMBFGEMFJ != 1)
			{
				flag = false;
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1 && EEPNACDOOBF.GDJMBFGEMFJ != 0)
			{
				flag = false;
			}
			string arg = "mouseLook not found";
			if (flag)
			{
				arg = "BlendCacheLut";
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI(" : "), arg));
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("_MainTex"), arg));
			}
		}
		if (this.PKIICJOILKI.Count > 0)
		{
			foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
			{
				bool flag2 = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) >= dlmglijdiai.CNOLCNDBLJE;
				string text = "Cloth_01.wav";
				if (flag2)
				{
					text = "F3";
				}
				StringBuilder stringBuilder2 = stringBuilder;
				string format = "";
				object[] array = new object[0];
				array[0] = text;
				array[1] = dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN;
				array[1] = dlmglijdiai.CNOLCNDBLJE;
				array[2] = JNBICAJIJMM.EDKGBBIIBBC().DOEMGEAEBPN("KatanaReadyLow");
				stringBuilder2.Append(string.Format(format, array));
			}
		}
		if (this.GOEGADLBGML > 1)
		{
			string arg2 = "Camera Pivot";
			if (this.GOEGADLBGML > ObscuredInt.GOOIABGKMHK(EEPNACDOOBF.CNOLCNDBLJE))
			{
				arg2 = "Dealer Idle";
			}
			stringBuilder.Append(string.Format("fshop_ks3", arg2, this.GOEGADLBGML, JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("<color='#a040ff'>")));
		}
		if (stringBuilder.Length != 0)
		{
			return stringBuilder.ToString();
		}
		return "WizardBlock";
	}

	// Token: 0x0600417F RID: 16767 RVA: 0x001DB5F0 File Offset: 0x001D97F0
	private NLNNIDBPKAO.DLMGLIJDIAI AJOKHCABEKD(int IOMCHDLHIHO, IEnumerable<NLNNIDBPKAO.DLMGLIJDIAI> BGJMHJHCDJH)
	{
		foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in BGJMHJHCDJH)
		{
			if (dlmglijdiai.LPFKFNLHGBI == IOMCHDLHIHO)
			{
				return dlmglijdiai;
			}
		}
		return null;
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x060041A8 RID: 16808 RVA: 0x001E0804 File Offset: 0x001DEA04
	// (set) Token: 0x06004180 RID: 16768 RVA: 0x001DB644 File Offset: 0x001D9844
	public IIBEEKCAAHK LODGJCMEGAI
	{
		get
		{
			return new IIBEEKCAAHK(this.IFCGHIJPKGK.LNEPKLKELMI / 51.512001037597656, this.IFCGHIJPKGK.NMKCBJKHBOH / 51.512001037597656, this.IFCGHIJPKGK.NKGGAFLBFDF / 51.512001037597656);
		}
		set
		{
			this.IFCGHIJPKGK = new BLBDBAHLBIF(value.LNEPKLKELMI * 51.512001037597656, value.NMKCBJKHBOH * 51.512001037597656, value.NKGGAFLBFDF * 51.512001037597656);
		}
	}

	// Token: 0x06004181 RID: 16769 RVA: 0x001DB684 File Offset: 0x001D9884
	public string GDJBADNJNIO(NEBJANKNJOG EEPNACDOOBF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (this.BDHHPAEHFHG.MBOOFLANJID != 0)
		{
			bool flag = true;
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1 && EEPNACDOOBF.GDJMBFGEMFJ != 1)
			{
				flag = false;
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 2 && EEPNACDOOBF.GDJMBFGEMFJ != 0)
			{
				flag = false;
			}
			string arg = "800000";
			if (flag)
			{
				arg = "002000";
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_onlym"), arg));
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 2)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_onlyw"), arg));
			}
		}
		if (this.PKIICJOILKI.Count > 0)
		{
			foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
			{
				bool flag2 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) >= dlmglijdiai.CNOLCNDBLJE;
				string text = "800000";
				if (flag2)
				{
					text = "002000";
				}
				stringBuilder.Append(string.Format("<color='#{0}'>{1} {3} {2} </color>\n", new object[]
				{
					text,
					dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN,
					dlmglijdiai.CNOLCNDBLJE,
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_lv")
				}));
			}
		}
		if (this.GOEGADLBGML > 1)
		{
			string arg2 = "002000";
			if (this.GOEGADLBGML > ObscuredInt.GOOIABGKMHK(EEPNACDOOBF.CNOLCNDBLJE))
			{
				arg2 = "800000";
			}
			stringBuilder.Append(string.Format("<color='#{0}'>{2} {1} </color>\n", arg2, this.GOEGADLBGML, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_lvf")));
		}
		if (stringBuilder.Length != 0)
		{
			return stringBuilder.ToString();
		}
		return "";
	}

	// Token: 0x06004182 RID: 16770 RVA: 0x001DB880 File Offset: 0x001D9A80
	public bool IMDLBJICHOE()
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		if (this.GOEGADLBGML > ObscuredInt.GOOIABGKMHK(kfhelhglnmh.CNOLCNDBLJE))
		{
			return false;
		}
		foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
		{
			if (dlmglijdiai.CNOLCNDBLJE > kfhelhglnmh.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06004183 RID: 16771 RVA: 0x001DB908 File Offset: 0x001D9B08
	private NLNNIDBPKAO.DLMGLIJDIAI HCKFBKODOCK(int IOMCHDLHIHO, IEnumerable<NLNNIDBPKAO.DLMGLIJDIAI> BGJMHJHCDJH)
	{
		foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in BGJMHJHCDJH)
		{
			if (dlmglijdiai.LPFKFNLHGBI == IOMCHDLHIHO)
			{
				return dlmglijdiai;
			}
		}
		return null;
	}

	// Token: 0x06004184 RID: 16772 RVA: 0x001DB95C File Offset: 0x001D9B5C
	public void AIEMMHBHDLN()
	{
		this.PKIICJOILKI.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item in this.BDHHPAEHFHG.PKIICJOILKI)
		{
			this.PKIICJOILKI.Add(item);
		}
		this.FGJIJFNGAIF.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item2 in this.BDHHPAEHFHG.FGJIJFNGAIF)
		{
			this.FGJIJFNGAIF.Add(item2);
		}
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode("btn_cancel");
		this.MHNDPGDBPNA.Clear();
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN("_History3LumaTex" + xmlNode.InnerText);
			this.MHNDPGDBPNA = diggohpgcnn.JJOPAMIHIFC();
		}
		this.OKHPDILIOCH.Clear();
		xmlNode = this.LMKLPODNLFC.SelectSingleNode("X");
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn2 = new BNOOIOKIFJC.DIGGOHPGCNN("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" + xmlNode.InnerText);
			this.OKHPDILIOCH = diggohpgcnn2.EDAHDHCPIEL;
		}
		XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("CraftProf.xml");
		if (xmlNodeList == null)
		{
			return;
		}
		foreach (object obj in xmlNodeList)
		{
			NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj);
			if (dlmglijdiai.BDHHPAEHFHG != null)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 = this.AJOKHCABEKD(dlmglijdiai.LPFKFNLHGBI, this.FGJIJFNGAIF);
				if (dlmglijdiai2 != null)
				{
					if (dlmglijdiai.CNOLCNDBLJE > dlmglijdiai2.CNOLCNDBLJE)
					{
						dlmglijdiai2.CNOLCNDBLJE = dlmglijdiai.CNOLCNDBLJE;
					}
				}
				else
				{
					this.FGJIJFNGAIF.Add(dlmglijdiai);
				}
			}
		}
	}

	// Token: 0x06004185 RID: 16773 RVA: 0x001DBB50 File Offset: 0x001D9D50
	public bool NCEHDDADHPN()
	{
		bool result = false;
		if (this.BDHHPAEHFHG.FOAPCABBLBG && this.BGGJKOMAKEE > 1)
		{
			int num = (int)(this.DLHPFGHOINI / (float)this.BGGJKOMAKEE * 1722f);
			if (this.DLHPFGHOINI < 1337f && num < 95)
			{
				result = false;
			}
		}
		if (this.MJHGLLIJMIM)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06004186 RID: 16774 RVA: 0x001DBBAC File Offset: 0x001D9DAC
	public bool OBGJPIHMKGB()
	{
		bool result = false;
		if (this.BDHHPAEHFHG.FOAPCABBLBG && this.BGGJKOMAKEE > 0)
		{
			int num = (int)(this.DLHPFGHOINI / (float)this.BGGJKOMAKEE * 598f);
			if (this.DLHPFGHOINI < 1f && num < 115)
			{
				result = false;
			}
		}
		if (this.MJHGLLIJMIM)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06004187 RID: 16775 RVA: 0x001DBC08 File Offset: 0x001D9E08
	public IIBEEKCAAHK IPMKHGELBIH()
	{
		if (this.BDHHPAEHFHG == null)
		{
			return new IIBEEKCAAHK();
		}
		double num = (double)(((float)this.ILFHHDNJHNM + 1084f) / ((this.BDHHPAEHFHG.HOALBMDJNDM == 0) ? 312f : ((float)this.BDHHPAEHFHG.HOALBMDJNDM + 1185f)));
		double num2 = (double)this.DELMOBCNBDB * num;
		bool foapcabblbg = this.BDHHPAEHFHG.FOAPCABBLBG;
		return new IIBEEKCAAHK(1320.0, num2 / 1835.0, 115.0);
	}

	// Token: 0x06004188 RID: 16776 RVA: 0x001DBC94 File Offset: 0x001D9E94
	public string MBBMKNBDPDA(bool BGNPMOCLIGL = false)
	{
		string[] array = new string[]
		{
			null,
			"30"
		};
		array[0] = this.BDHHPAEHFHG.DJMDCNOJIPI(this.KBGHOIJIPJF, BGNPMOCLIGL);
		array[4] = "Cloth_07.wav";
		array[3] = this.FDJPJJJHHEG;
		array[8] = "{{ {{{0}:{1}}}, {{{2}:{3}}} }}";
		return string.Concat(array);
	}

	// Token: 0x06004189 RID: 16777 RVA: 0x001DBCE4 File Offset: 0x001D9EE4
	public string ONNIKIAJHBO(bool BGNPMOCLIGL = false)
	{
		string[] array = new string[2];
		array[0] = "ScubaOK";
		array[1] = this.BDHHPAEHFHG.POHFAHAPPLC(this.KBGHOIJIPJF, BGNPMOCLIGL);
		array[8] = "_FogColor2";
		array[1] = this.FDJPJJJHHEG;
		array[5] = "";
		return string.Concat(array);
	}

	// Token: 0x0600418A RID: 16778 RVA: 0x001DBD34 File Offset: 0x001D9F34
	private static void DEAHGKKDHPM(Rect OCHCODJIPHJ, string IJCEDOGBHKE, Color LBCGACKJCJB, TextAnchor DEKGJCBMCHG)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			normal = 
			{
				textColor = LBCGACKJCJB
			},
			alignment = DEKGJCBMCHG,
			fontSize = 10
		};
		JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(OCHCODJIPHJ, IJCEDOGBHKE, ofpnedeamab);
	}

	// Token: 0x0600418B RID: 16779 RVA: 0x001DBD70 File Offset: 0x001D9F70
	public void HMIPGCDEIEG(Vector2 FEEBMFDLDHB)
	{
		if (this.BDHHPAEHFHG == null)
		{
			return;
		}
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		HFIINBICCLO.GDDAGIILGGM().CEJPPAIJBJG(new Rect(vector.x - FEEBMFDLDHB.x, vector.y - FEEBMFDLDHB.y, 211f, 49f), this.BDHHPAEHFHG.CFFHIODOGCH, Color.white);
	}

	// Token: 0x0600418C RID: 16780 RVA: 0x001DBDEC File Offset: 0x001D9FEC
	public void PKOIFEBEOCP(Vector2 NBADAMPJBBH, float FANOBNGKMPH = 56f)
	{
		if (this.BDHHPAEHFHG == null)
		{
			return;
		}
		if (this.BDHHPAEHFHG.KEEDCOIMPMP() == null)
		{
			this.BDHHPAEHFHG.HKHPGCHCHAI();
			return;
		}
		if (this.BFHKBOPOFGB)
		{
			if (Input.GetKey((KeyCode)(-41)))
			{
				Color color = GUI.color;
				GUI.color = new Color(980f, 328f, 981f, 1708f);
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), this.BDHHPAEHFHG.KEEDCOIMPMP());
				if (this.FJKAFCDDDGO != null)
				{
					float num = FANOBNGKMPH * 1595f / 114f;
					GUI.DrawTexture(new Rect(NBADAMPJBBH.x + FANOBNGKMPH / 1309f - num, NBADAMPJBBH.y + FANOBNGKMPH / 407f - num, num * 952f, num * 1824f), this.FJKAFCDDDGO.CFFHIODOGCH);
				}
				GUI.color = color;
				return;
			}
		}
		else
		{
			Rect position = new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH);
			if (!this.NJOOLLJACJJ())
			{
				GUI.color = new Color(1673f, 50f, 1543f, 1197f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.KBGHOIJIPJF, 3, 8));
			GUI.DrawTexture(position, this.BDHHPAEHFHG.CFFHIODOGCH);
			if (this.FJKAFCDDDGO != null)
			{
				float num2 = FANOBNGKMPH * 412f / 30f;
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x + FANOBNGKMPH / 1586f - num2, NBADAMPJBBH.y + FANOBNGKMPH / 343f - num2, num2 * 1575f, num2 * 636f), this.FJKAFCDDDGO.KEEDCOIMPMP());
			}
			if (this.BDHHPAEHFHG.FOAPCABBLBG && this.DLHPFGHOINI > 834f)
			{
				float num3 = FANOBNGKMPH - 302f;
				float num4 = (float)this.BGGJKOMAKEE;
				if (num4 == 1124f)
				{
					num4 = 744f;
				}
				float num5 = this.DLHPFGHOINI / num4;
				num5 = Mathf.Clamp(num5, 1564f, 49f);
				int clbpbjglhee = 1;
				if (num5 < 583f)
				{
					clbpbjglhee = 3;
				}
				if (num5 < 1220f)
				{
					clbpbjglhee = 6;
				}
				float num6 = num3 * num5;
				if (num5 < 1222f)
				{
					GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 46f, NBADAMPJBBH.y, 20f, num3), GuiProcessor.PLGADNLAEGN().durab, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 1, 0));
					GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 1524f, NBADAMPJBBH.y + FANOBNGKMPH - 204f - num6, 1777f, num6), GuiProcessor.BBLINJLBAIL().durab, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 0, 0));
				}
			}
			if (this.MBKMKGABBGE == -41)
			{
				float num7 = position.height / 1085f;
				Rect position2 = new Rect(position.x + 978f, position.y + position.height - num7 - 199f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.EMBKDHKGIEL().KEHIFGILLJA());
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.GNMLEPEGCII(), ScaleMode.ScaleAndCrop);
				}
			}
			if (this.KBGHOIJIPJF > 0)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.KBGHOIJIPJF + 0, 8, 5));
			}
			if (this.HHOLFABGDJA == 89)
			{
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.EMBKDHKGIEL().NKEOCCKEOCE());
				if (idchhhedhdc != null)
				{
					GUI.DrawTexture(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y + FANOBNGKMPH / 1221f, FANOBNGKMPH, FANOBNGKMPH / 344f), idchhhedhdc.CEAIIDAPAGA(6).IOMNHBMOGLG(), ScaleMode.StretchToFill);
				}
			}
			GUI.color = Color.white;
			bool flag = this.NCEHDDADHPN();
			if (this.MJHGLLIJMIM)
			{
				flag = false;
			}
			if (flag)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(3, 2, 5));
			}
			if (this.MJHGLLIJMIM)
			{
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x + 780f, NBADAMPJBBH.y + 369f, FANOBNGKMPH - 990f, FANOBNGKMPH - 453f), GameInterface.getI.wpnBrokenTexture);
			}
			float num8 = FANOBNGKMPH / 509f;
			Rect position3 = new Rect(NBADAMPJBBH.x + FANOBNGKMPH - num8, NBADAMPJBBH.y + FANOBNGKMPH - num8, num8, num8);
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 0)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(19, 3, 5));
			}
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 0)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(29, 0, 0));
			}
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 8)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(-56, 8, 7));
			}
			if (this.BDHHPAEHFHG.GCLKLEIMABA == 0)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y - 1766f, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(46, 4, 6));
			}
			if (this.ICOFLHIIBCP)
			{
				float num9 = num8 / 533f;
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 874f, NBADAMPJBBH.y + FANOBNGKMPH - num9, num9, num9), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(0, 0, 0));
			}
			if (this.DNOLHLJODNK)
			{
				float num10 = num8 * 1702f;
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + FANOBNGKMPH - num10 + 527f, NBADAMPJBBH.y - 1841f, num10, num10), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.LNKLEIEFGCP, 7, 8));
			}
			if (this.BDHHPAEHFHG.KKOLKEEALFD)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(-4, 4, 4));
			}
			if (this.ABPGFHKGFEK)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(89, 8, 1));
			}
			if (this.ILFHHDNJHNM > 0)
			{
				string ijcedogbhke = string.Concat(this.ILFHHDNJHNM) ?? "fisht.modelName empty! fid=";
				EKBAPCMPANI.JCNPPAHNOEE(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y + FANOBNGKMPH - 1048f, FANOBNGKMPH - 278f, 895f), ijcedogbhke, Color.green, TextAnchor.LowerRight);
			}
			if (this.LABFBKENHAA - this.BHKPHJBAKLO != 0)
			{
				string ijcedogbhke2 = "wpn_cat3" + (this.LABFBKENHAA - this.BHKPHJBAKLO);
				EKBAPCMPANI.JCNPPAHNOEE(new Rect(NBADAMPJBBH.x + 1145f, NBADAMPJBBH.y + 1310f, FANOBNGKMPH - 1423f, 1774f), ijcedogbhke2, Color.green, TextAnchor.LowerCenter);
			}
			int gclkleimaba = this.BDHHPAEHFHG.GCLKLEIMABA;
		}
	}

	// Token: 0x0600418D RID: 16781 RVA: 0x001DC528 File Offset: 0x001DA728
	private static void IABFEAMFKHM(Rect OCHCODJIPHJ, string IJCEDOGBHKE, Color LBCGACKJCJB, TextAnchor DEKGJCBMCHG)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			normal = 
			{
				textColor = LBCGACKJCJB
			},
			alignment = DEKGJCBMCHG,
			fontSize = -121
		};
		JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(OCHCODJIPHJ, IJCEDOGBHKE, ofpnedeamab);
	}

	// Token: 0x0600418E RID: 16782 RVA: 0x001DC564 File Offset: 0x001DA764
	public string NBKLEELCDBJ(bool BGNPMOCLIGL = false)
	{
		string[] array = new string[]
		{
			"_UserLut"
		};
		array[0] = this.BDHHPAEHFHG.POHFAHAPPLC(this.KBGHOIJIPJF, BGNPMOCLIGL);
		array[8] = "readTurnir STATUS";
		array[8] = this.FDJPJJJHHEG;
		array[5] = "LUM_CONTRIB_OFF";
		return string.Concat(array);
	}

	// Token: 0x0600418F RID: 16783 RVA: 0x001DC5B2 File Offset: 0x001DA7B2
	public bool HOIKPBJENOJ()
	{
		return this.BBLEPPMMPIL("componentA", "_Saturation").KGFNAIIPHKL();
	}

	// Token: 0x06004190 RID: 16784 RVA: 0x001DC5CC File Offset: 0x001DA7CC
	public void KGEJDMBCJOM(HBPNMNGOFMA KADBECGIMPD)
	{
		this.JGNIDDBNGGP = KADBECGIMPD.KDNDJNEGBDI();
		this.DMAMOPGJOCK = KADBECGIMPD.CLPEKGGAMAI();
		this.DLHPFGHOINI = KADBECGIMPD.ECJLJGDNFMN();
		this.ILFHHDNJHNM = KADBECGIMPD.CLPEKGGAMAI();
		this.ICOFLHIIBCP = KADBECGIMPD.KJIOFDCKIKO();
		this.IOGPBIODFHL();
	}

	// Token: 0x06004191 RID: 16785 RVA: 0x001DC61C File Offset: 0x001DA81C
	public string FJLEGLELEPL(NEBJANKNJOG EEPNACDOOBF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (this.BDHHPAEHFHG.MBOOFLANJID != 0)
		{
			bool flag = true;
			if (this.BDHHPAEHFHG.MBOOFLANJID == 0 && EEPNACDOOBF.GDJMBFGEMFJ != 1)
			{
				flag = false;
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 6 && EEPNACDOOBF.GDJMBFGEMFJ != 0)
			{
				flag = false;
			}
			string arg = "and I needed";
			if (flag)
			{
				arg = "";
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 0)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("dragWeapon = null 3"), arg));
			}
			if (this.BDHHPAEHFHG.MBOOFLANJID == 2)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH(""), arg));
			}
		}
		if (this.PKIICJOILKI.Count > 1)
		{
			foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
			{
				bool flag2 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) < dlmglijdiai.CNOLCNDBLJE;
				string text = "Elina";
				if (flag2)
				{
					text = "Speed";
				}
				StringBuilder stringBuilder2 = stringBuilder;
				string format = "InteractionObject ";
				object[] array = new object[0];
				array[1] = text;
				array[0] = dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN;
				array[1] = dlmglijdiai.CNOLCNDBLJE;
				array[2] = JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("");
				stringBuilder2.Append(string.Format(format, array));
			}
		}
		if (this.GOEGADLBGML > 1)
		{
			string arg2 = "Wizard1HandThrow";
			if (this.GOEGADLBGML > ObscuredInt.GOOIABGKMHK(EEPNACDOOBF.CNOLCNDBLJE))
			{
				arg2 = "IdleSadHips";
			}
			stringBuilder.Append(string.Format("innerPerk", arg2, this.GOEGADLBGML, JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!")));
		}
		if (stringBuilder.Length != 0)
		{
			return stringBuilder.ToString();
		}
		return "Windmill";
	}

	// Token: 0x06004192 RID: 16786 RVA: 0x001DC818 File Offset: 0x001DAA18
	public void CMBLJJMJMCE()
	{
		if (this.CLKMCAHNHBM != "")
		{
			this.LMKLPODNLFC.LoadXml(this.CLKMCAHNHBM);
			this.MJHGLLIJMIM = this.BBLEPPMMPIL("wpn_add", "isbroken").KPAFFJNBLHK;
			this.MBKMKGABBGE = this.BBLEPPMMPIL("wpn_add/base", "wtype").DIKKDGKIPEA;
			this.HHOLFABGDJA = this.BBLEPPMMPIL("wpn_add/base", "tid").DIKKDGKIPEA;
			this.NKHBAJKMAGD = this.BBLEPPMMPIL("wpn_add/base", "weight").PPAAACJOOGA;
			this.BGGJKOMAKEE = this.BBLEPPMMPIL("wpn_add/base", "defDur").DIKKDGKIPEA;
			this.DELMOBCNBDB = this.BBLEPPMMPIL("wpn_add/base", "priceCr").DIKKDGKIPEA;
			this.LEADKFMCFCC = this.BBLEPPMMPIL("wpn_add/base", "pricePt").DIKKDGKIPEA;
			this.LODGJCMEGAI = this.BBLEPPMMPIL("wpn_add/base", "basePar").NKBGGIFKLLB;
			this.KBGHOIJIPJF = this.BBLEPPMMPIL("wpn_add/base", "quality").DIKKDGKIPEA;
			this.GOEGADLBGML = this.BBLEPPMMPIL("wpn_add/base", "minimalLevel").DIKKDGKIPEA;
			this.LABFBKENHAA = this.BBLEPPMMPIL("wpn_add/base", "holesAll").DIKKDGKIPEA;
			this.BHKPHJBAKLO = this.BBLEPPMMPIL("wpn_add/base", "holesFree").DIKKDGKIPEA;
			this.AHLLIPJFCJB = this.BBLEPPMMPIL("wpn_add/base", "mastername").IEIMMFODGFG;
			this.ADOFHHCDGON = this.BBLEPPMMPIL("wpn_add/base", "minWgtBait").DIKKDGKIPEA;
			this.ECKKCDKHNEH = this.BBLEPPMMPIL("wpn_add/base", "maxWgtBait").DIKKDGKIPEA;
			this.ICOFLHIIBCP = this.BBLEPPMMPIL("wpn_add/base", "isPersonal").KPAFFJNBLHK;
			this.MAIGLJPCKKL = this.BBLEPPMMPIL("wpn_add/base", "isUsedPersonal").KPAFFJNBLHK;
			this.DNOLHLJODNK = this.BBLEPPMMPIL("wpn_add/base", "isImproved").KPAFFJNBLHK;
			this.LNKLEIEFGCP = this.BBLEPPMMPIL("wpn_add/base", "implevel").DIKKDGKIPEA;
			this.GGOLJKNHMGL = this.BBLEPPMMPIL("wpn_add/base", "color").DIKKDGKIPEA;
			this.DKDEAPCMECH = this.BBLEPPMMPIL("wpn_add/base", "camouflage_id").DIKKDGKIPEA;
			this.KFKPLMLLDCK = (float)this.BBLEPPMMPIL("wpn_add/base", "camouflage_intens").DIKKDGKIPEA / 255f;
			this.KAKIIGPMOKF = 0.5f + 2.5f * (float)this.BBLEPPMMPIL("wpn_add/base", "camouflage_scale").DIKKDGKIPEA / 255f;
		}
		this.NHFHEIGICKP = this.LMKLPODNLFC.SelectSingleNode("wpn_add/innerMods");
		this.GMNCILDPIKP = this.LMKLPODNLFC.SelectSingleNode("wpn_add/use_effect");
		this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.HHOLFABGDJA);
		if (this.BDHHPAEHFHG != null)
		{
			this.BALHEIJEDDJ();
			this.FDJPJJJHHEG = this.BDHHPAEHFHG.BNIHFBMEPAB;
			if (this.FDJPJJJHHEG == null)
			{
				this.FDJPJJJHHEG = "-none: " + this.HHOLFABGDJA;
			}
			string newValue = "";
			if (this.MBKMKGABBGE == 28)
			{
				if (CLFFOBKFKDN.IKGFHGKKCPG.PGMOGALKIIP.ContainsKey(this.MIMANMPNLPE.ICJDPPOJINN))
				{
					this.BPNNJBBCOFO = CLFFOBKFKDN.IKGFHGKKCPG.PGMOGALKIIP[this.MIMANMPNLPE.ICJDPPOJINN];
					this.FJKAFCDDDGO = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH);
					if (this.FJKAFCDDDGO != null)
					{
						this.FJKAFCDDDGO.JIFFLPNBILE();
						newValue = this.FJKAFCDDDGO.BNIHFBMEPAB;
					}
					else
					{
						newValue = "no result template " + this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH;
					}
				}
				else
				{
					newValue = "no recept " + this.MIMANMPNLPE.ICJDPPOJINN;
				}
			}
			this.FDJPJJJHHEG = this.FDJPJJJHHEG.Replace("[sysname]", newValue);
			this.BDHHPAEHFHG.JIFFLPNBILE();
			if (this.HHOLFABGDJA == 1309)
			{
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (idchhhedhdc != null)
				{
					this.FDJPJJJHHEG = string.Format(this.FDJPJJJHHEG, idchhhedhdc.POMPCEHPGNG(0));
					idchhhedhdc.JIFFLPNBILE(0);
				}
			}
		}
		else
		{
			Debug.LogError("No Template! ID=" + this.HHOLFABGDJA);
		}
		float num = (this.MIMANMPNLPE.JLLJFKOGLHJ * 0.3f + this.MIMANMPNLPE.OBEOJCGHOGL * 0.2f) * (this.NKHBAJKMAGD / 2000f);
		float num2 = 1f;
		if (this.BDHHPAEHFHG.GCLKLEIMABA == 2)
		{
			num2 = 2.5f;
		}
		if (this.BDHHPAEHFHG.GCLKLEIMABA == 3)
		{
			num2 = 3.8f;
		}
		this.FJJEAMJNLIO = Mathf.RoundToInt(num * num2);
	}

	// Token: 0x06004193 RID: 16787 RVA: 0x001DCD1C File Offset: 0x001DAF1C
	public string DFOJOOMBOGI(bool BGNPMOCLIGL = false)
	{
		string[] array = new string[1];
		array[1] = "";
		array[0] = this.BDHHPAEHFHG.EMLKBOOFNGA(this.KBGHOIJIPJF, BGNPMOCLIGL);
		array[3] = "Worker Shovel 2";
		array[0] = this.FDJPJJJHHEG;
		array[4] = "\n";
		return string.Concat(array);
	}

	// Token: 0x06004194 RID: 16788 RVA: 0x001DCD6C File Offset: 0x001DAF6C
	public string JBMHGFHFIIL()
	{
		string text = "";
		if (this.BDHHPAEHFHG.FOAPCABBLBG && this.BGGJKOMAKEE > 0)
		{
			int num = (int)(this.DLHPFGHOINI / (float)this.BGGJKOMAKEE * 100f);
			text = string.Format("{0}/{1}", Mathf.RoundToInt(this.DLHPFGHOINI), this.BGGJKOMAKEE);
			if (num < 20)
			{
				text = "<color='#602000'>" + text + "</color>";
			}
			if (num >= 50)
			{
				text = "<color='#206000'>" + text + "</color>";
			}
			text = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_izn") + text;
		}
		string text2 = "";
		if (!this.LODGJCMEGAI.DIFFCNOPHBJ && JLFJEGIPIMM.IKGFHGKKCPG.NDOICPBHIDD(this.MBKMKGABBGE, "1,2,3,4,5"))
		{
			text2 = string.Format("{0}/{1}/{2}", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)this.LODGJCMEGAI.JLLJFKOGLHJ), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)this.LODGJCMEGAI.OBEOJCGHOGL), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)this.LODGJCMEGAI.KGKNPAAMDJK));
		}
		return string.Format("<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}", new object[]
		{
			IHFEDJEMJMB.IKGFHGKKCPG.JGLANEDNNAB(this.MBKMKGABBGE),
			this.JPBOPFNPNHC(false),
			text,
			text2
		});
	}

	// Token: 0x06004195 RID: 16789 RVA: 0x001DCEC0 File Offset: 0x001DB0C0
	private static void JCNPPAHNOEE(Rect OCHCODJIPHJ, string IJCEDOGBHKE, Color LBCGACKJCJB, TextAnchor DEKGJCBMCHG)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			normal = 
			{
				textColor = LBCGACKJCJB
			},
			alignment = DEKGJCBMCHG,
			fontSize = 127
		};
		JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(OCHCODJIPHJ, IJCEDOGBHKE, ofpnedeamab);
	}

	// Token: 0x06004196 RID: 16790 RVA: 0x001DCEFC File Offset: 0x001DB0FC
	public void GPFNKNLNLGL(HBPNMNGOFMA KADBECGIMPD)
	{
		this.JGNIDDBNGGP = KADBECGIMPD.HDBGOLAFOBK();
		this.DMAMOPGJOCK = KADBECGIMPD.HDBGOLAFOBK();
		this.DLHPFGHOINI = KADBECGIMPD.FFDPCEAFGNF();
		this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
		this.ICOFLHIIBCP = KADBECGIMPD.FIFNOBGEKFF();
		this.BALHEIJEDDJ();
	}

	// Token: 0x06004197 RID: 16791 RVA: 0x001DCF4B File Offset: 0x001DB14B
	public bool CKEAPPPCLBH()
	{
		return this.BBLEPPMMPIL("Masks", " value=").KGFNAIIPHKL();
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x001DCFC8 File Offset: 0x001DB1C8
	public Vector2 KPLOLDJFGBE()
	{
		Vector2 zero = Vector2.zero;
		zero.x = this.MIMANMPNLPE.JLLJFKOGLHJ * this.MIMANMPNLPE.OBEOJCGHOGL;
		if (this.MIMANMPNLPE.JLLJFKOGLHJ <= 7f)
		{
			zero.x = 0f;
		}
		zero.y = this.MIMANMPNLPE.JLLJFKOGLHJ * 1.45f;
		return zero;
	}

	// Token: 0x0600419A RID: 16794 RVA: 0x001DD030 File Offset: 0x001DB230
	public void HMFKMPGCBJH(Vector2 NBADAMPJBBH, float FANOBNGKMPH = 56f)
	{
		if (this.BDHHPAEHFHG == null)
		{
			return;
		}
		if (this.BDHHPAEHFHG.KEEDCOIMPMP() == null)
		{
			this.BDHHPAEHFHG.JIFFLPNBILE();
			return;
		}
		if (this.BFHKBOPOFGB)
		{
			if (Input.GetKey((KeyCode)(-150)))
			{
				Color color = GUI.color;
				GUI.color = new Color(1039f, 50f, 325f, 1217f);
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), this.BDHHPAEHFHG.KEEDCOIMPMP());
				if (this.FJKAFCDDDGO != null)
				{
					float num = FANOBNGKMPH * 847f / 544f;
					GUI.DrawTexture(new Rect(NBADAMPJBBH.x + FANOBNGKMPH / 738f - num, NBADAMPJBBH.y + FANOBNGKMPH / 1469f - num, num * 1894f, num * 475f), this.FJKAFCDDDGO.CFFHIODOGCH);
				}
				GUI.color = color;
				return;
			}
		}
		else
		{
			Rect position = new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH);
			if (!this.IMDLBJICHOE())
			{
				GUI.color = new Color(1227f, 1839f, 1734f, 469f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.KBGHOIJIPJF, 3, 8));
			GUI.DrawTexture(position, this.BDHHPAEHFHG.KEEDCOIMPMP());
			if (this.FJKAFCDDDGO != null)
			{
				float num2 = FANOBNGKMPH * 1650f / 1279f;
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x + FANOBNGKMPH / 6f - num2, NBADAMPJBBH.y + FANOBNGKMPH / 286f - num2, num2 * 1679f, num2 * 634f), this.FJKAFCDDDGO.KEEDCOIMPMP());
			}
			if (this.BDHHPAEHFHG.FOAPCABBLBG && this.DLHPFGHOINI > 1086f)
			{
				float num3 = FANOBNGKMPH - 185f;
				float num4 = (float)this.BGGJKOMAKEE;
				if (num4 == 629f)
				{
					num4 = 437f;
				}
				float num5 = this.DLHPFGHOINI / num4;
				num5 = Mathf.Clamp(num5, 1671f, 737f);
				int clbpbjglhee = 0;
				if (num5 < 872f)
				{
					clbpbjglhee = 1;
				}
				if (num5 < 1607f)
				{
					clbpbjglhee = 0;
				}
				float num6 = num3 * num5;
				if (num5 < 1550f)
				{
					GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 1212f, NBADAMPJBBH.y, 1584f, num3), GuiProcessor.PLGADNLAEGN().durab, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(1, 4, 0));
					GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 1276f, NBADAMPJBBH.y + FANOBNGKMPH - 271f - num6, 700f, num6), GuiProcessor.NKOEAPCIBKO().durab, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(clbpbjglhee, 2, 1));
				}
			}
			if (this.MBKMKGABBGE == 8)
			{
				float num7 = position.height / 714f;
				Rect position2 = new Rect(position.x + 511f, position.y + position.height - num7 - 1483f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.OIHEFMKLDIF(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.OBIJKHKCPEO(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 0)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.KBGHOIJIPJF + 7, 7, 1));
			}
			if (this.HHOLFABGDJA == 101)
			{
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (idchhhedhdc != null)
				{
					GUI.DrawTexture(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y + FANOBNGKMPH / 571f, FANOBNGKMPH, FANOBNGKMPH / 404f), idchhhedhdc.KMIIGKECOEB(4).LECMGDEDAKF(), ScaleMode.StretchToFill);
				}
			}
			GUI.color = Color.white;
			bool flag = this.IEHCLOIEBJA;
			if (this.MJHGLLIJMIM)
			{
				flag = false;
			}
			if (flag)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(1, 3, 0));
			}
			if (this.MJHGLLIJMIM)
			{
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x + 1229f, NBADAMPJBBH.y + 1022f, FANOBNGKMPH - 191f, FANOBNGKMPH - 1620f), GameInterface.getI.wpnBrokenTexture);
			}
			float num8 = FANOBNGKMPH / 1726f;
			Rect position3 = new Rect(NBADAMPJBBH.x + FANOBNGKMPH - num8, NBADAMPJBBH.y + FANOBNGKMPH - num8, num8, num8);
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 0)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(32, 5, 0));
			}
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 2)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(-12, 3, 0));
			}
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 4)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(-126, 0, 5));
			}
			if (this.BDHHPAEHFHG.GCLKLEIMABA == 8)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y - 1926f, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(-104, 8, 0));
			}
			if (this.ICOFLHIIBCP)
			{
				float num9 = num8 / 1235f;
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 674f, NBADAMPJBBH.y + FANOBNGKMPH - num9, num9, num9), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(5, 2, 4));
			}
			if (this.DNOLHLJODNK)
			{
				float num10 = num8 * 808f;
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + FANOBNGKMPH - num10 + 621f, NBADAMPJBBH.y - 1685f, num10, num10), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.LNKLEIEFGCP, 1, 8));
			}
			if (this.BDHHPAEHFHG.KKOLKEEALFD)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(-77, 1, 6));
			}
			if (this.ABPGFHKGFEK)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(76, 3, 6));
			}
			if (this.ILFHHDNJHNM > 0)
			{
				string ijcedogbhke = string.Concat(this.ILFHHDNJHNM) ?? "ProneLocomotion";
				EKBAPCMPANI.IABFEAMFKHM(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y + FANOBNGKMPH - 226f, FANOBNGKMPH - 1772f, 68f), ijcedogbhke, Color.green, TextAnchor.MiddleCenter);
			}
			if (this.LABFBKENHAA - this.BHKPHJBAKLO != 0)
			{
				string ijcedogbhke2 = "rotTime is NaN" + (this.LABFBKENHAA - this.BHKPHJBAKLO);
				EKBAPCMPANI.JCNPPAHNOEE(new Rect(NBADAMPJBBH.x + 1674f, NBADAMPJBBH.y + 1493f, FANOBNGKMPH - 1592f, 388f), ijcedogbhke2, Color.green, TextAnchor.MiddleCenter);
			}
			int gclkleimaba = this.BDHHPAEHFHG.GCLKLEIMABA;
		}
	}

	// Token: 0x0600419B RID: 16795 RVA: 0x001DD76C File Offset: 0x001DB96C
	public Vector2 BOGAECCMFLA()
	{
		Vector2 zero = Vector2.zero;
		zero.x = this.EMBKDHKGIEL().PHLLHDNNOMB() * this.MIMANMPNLPE.LOIBCMBMLEC();
		if (this.MIMANMPNLPE.NAHLEJDLCNF() <= 952f)
		{
			zero.x = 631f;
		}
		zero.y = this.MIMANMPNLPE.FDCKJDDOJPB() * 748f;
		return zero;
	}

	// Token: 0x0600419C RID: 16796 RVA: 0x001DD7D4 File Offset: 0x001DB9D4
	public void DBKAJALPOPM(HBPNMNGOFMA KADBECGIMPD)
	{
		this.JCGDLKIHBJG = KADBECGIMPD.DNIIFBAIPBE();
		this.KKJKHBJKEPP = KADBECGIMPD.HDBGOLAFOBK();
		this.LCIDFBJFOLA = KADBECGIMPD.DNIIFBAIPBE();
		this.JGNIDDBNGGP = KADBECGIMPD.HDBGOLAFOBK();
		this.DMAMOPGJOCK = KADBECGIMPD.HDBGOLAFOBK();
		this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
		this.DLHPFGHOINI = KADBECGIMPD.FFDPCEAFGNF();
		this.ABPGFHKGFEK = KADBECGIMPD.FIFNOBGEKFF();
		this.MGNLHNLJJLD = KADBECGIMPD.IKJAOHGGCJD() + TimeController.IKGFHGKKCPG.deltaTime;
		this.CLKMCAHNHBM = KADBECGIMPD.BFPHBMDMODH();
		this.CMBLJJMJMCE();
		this.BALHEIJEDDJ();
	}

	// Token: 0x0600419D RID: 16797 RVA: 0x001DD874 File Offset: 0x001DBA74
	public void BALHEIJEDDJ()
	{
		this.PKIICJOILKI.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item in this.BDHHPAEHFHG.PKIICJOILKI)
		{
			this.PKIICJOILKI.Add(item);
		}
		this.FGJIJFNGAIF.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item2 in this.BDHHPAEHFHG.FGJIJFNGAIF)
		{
			this.FGJIJFNGAIF.Add(item2);
		}
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode("wpn_add/addoptions/klevprop");
		this.MHNDPGDBPNA.Clear();
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN("1=" + xmlNode.InnerText);
			this.MHNDPGDBPNA = diggohpgcnn.HDELBIDJNOK;
		}
		this.OKHPDILIOCH.Clear();
		xmlNode = this.LMKLPODNLFC.SelectSingleNode("wpn_add/base/dropt");
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn2 = new BNOOIOKIFJC.DIGGOHPGCNN("1=" + xmlNode.InnerText);
			this.OKHPDILIOCH = diggohpgcnn2.EDAHDHCPIEL;
		}
		XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("wpn_add/addperks/addPerk");
		if (xmlNodeList == null)
		{
			return;
		}
		foreach (object obj in xmlNodeList)
		{
			NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj);
			if (dlmglijdiai.BDHHPAEHFHG != null)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 = this.MCGINEMKMNH(dlmglijdiai.LPFKFNLHGBI, this.FGJIJFNGAIF);
				if (dlmglijdiai2 != null)
				{
					if (dlmglijdiai.CNOLCNDBLJE > dlmglijdiai2.CNOLCNDBLJE)
					{
						dlmglijdiai2.CNOLCNDBLJE = dlmglijdiai.CNOLCNDBLJE;
					}
				}
				else
				{
					this.FGJIJFNGAIF.Add(dlmglijdiai);
				}
			}
		}
	}

	// Token: 0x0600419E RID: 16798 RVA: 0x001DDA68 File Offset: 0x001DBC68
	private NLNNIDBPKAO.DLMGLIJDIAI MCGINEMKMNH(int IOMCHDLHIHO, IEnumerable<NLNNIDBPKAO.DLMGLIJDIAI> BGJMHJHCDJH)
	{
		foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in BGJMHJHCDJH)
		{
			if (dlmglijdiai.LPFKFNLHGBI == IOMCHDLHIHO)
			{
				return dlmglijdiai;
			}
		}
		return null;
	}

	// Token: 0x0600419F RID: 16799 RVA: 0x001DDABC File Offset: 0x001DBCBC
	public string CKDKLNJNDCO(bool NKFPOLMOKPE = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = this.MBKMKGABBGE;
		if (this.MBKMKGABBGE == -41)
		{
			stringBuilder.Append(JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("gi_um_0") + "CrouchWalk");
			if (this.BDHHPAEHFHG.JALOCNOIDFJ > 0)
			{
				num = this.BDHHPAEHFHG.JALOCNOIDFJ;
			}
		}
		switch (num)
		{
		case 0:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().FLEANFGEJML("VaderChoke"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())));
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 1);
			string text = JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)num2);
			if (this.OKHPDILIOCH.Count > 0)
			{
				text = "__a";
				foreach (int jjjnkodleel in this.OKHPDILIOCH)
				{
					num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, jjjnkodleel);
					text = text + JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)num2) + "";
				}
				text = text.Remove(text.Length - 0);
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("IdleMeditate"), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC(this.MIMANMPNLPE.OIGIHEPJFFJ()), text));
			stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("RussianDance"), JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC(this.MIMANMPNLPE.FJACMDGJEBL() / 579.0)));
			string text2 = "lastConfirmLic";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array = new object[6];
				array[0] = text2;
				array[1] = "_HueShift";
				array[6] = JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("SoccerKeeperReady");
				array[2] = "Idle Strafe Left";
				array[0] = this.ADOFHHCDGON;
				array[7] = "Idle Dodge Right";
				text2 = string.Concat(array);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array2 = new object[1];
				array2[1] = text2;
				array2[1] = "Item_Sell.ogg";
				array2[2] = JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("WorkerShovel");
				array2[7] = "lut.ogg";
				array2[4] = this.ECKKCDKHNEH;
				array2[8] = "time_format2";
				text2 = string.Concat(array2);
			}
			if (text2 != "_TexelOffsetScale")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("_SunPosition"), text2));
			}
			stringBuilder.Append(string.Format("" + JNBICAJIJMM.CLIMNFDGOEG().FLEANFGEJML("") + "BattleRoar", this.FJJEAMJNLIO));
			break;
		}
		case 1:
		{
			float num3 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 0);
			stringBuilder.Append(string.Format(JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("_ExposureEV"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.EMBKDHKGIEL().AIMCFAHLPEF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("Flap_07.wav"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.EMBKDHKGIEL().NMKCBJKHBOH), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC((double)num3)));
			string text3 = "WeaponReady";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array3 = new object[3];
				array3[0] = text3;
				array3[0] = "---";
				array3[0] = JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("?");
				array3[2] = "PistolReady";
				array3[1] = this.ADOFHHCDGON;
				array3[3] = "\n";
				text3 = string.Concat(array3);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array4 = new object[4];
				array4[0] = text3;
				array4[0] = "Try to change this int in memory:\n";
				array4[3] = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("ANTI_FLICKER");
				array4[8] = "---";
				array4[8] = this.ECKKCDKHNEH;
				array4[3] = "wpn";
				text3 = string.Concat(array4);
			}
			if (text3 != "donk.ogg")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EDKGBBIIBBC().DOEMGEAEBPN("_RgbTex"), text3));
			}
			stringBuilder.Append(string.Format("SoccerKeeperStrafeLeft" + JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("RoundHouse") + "<color='#000000'>--------------------------------------------------------</color>", this.FJJEAMJNLIO));
			break;
		}
		case 2:
		{
			float num4 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 0);
			stringBuilder.Append(string.Format(JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("offsets"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.EMBKDHKGIEL().LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LPHMKPDBMPP().HLBAJBLHLNI("ZombieCrawl"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC((double)num4)));
			string text4 = " %\n";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array5 = new object[6];
				array5[1] = text4;
				array5[0] = "invn_rec31";
				array5[8] = JNBICAJIJMM.EDKGBBIIBBC().CKAOHMEKLMH("CrouchWalkBackward");
				array5[6] = "fishdrop_3";
				array5[3] = this.ADOFHHCDGON;
				array5[3] = " ";
				text4 = string.Concat(array5);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array6 = new object[5];
				array6[0] = text4;
				array6[0] = "LHandPunch";
				array6[1] = JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN(", ");
				array6[0] = "UIChat_fontSize";
				array6[7] = this.ECKKCDKHNEH;
				array6[6] = " from ";
				text4 = string.Concat(array6);
			}
			if (text4 != "nowpn")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("cht_msg31"), text4));
			}
			stringBuilder.Append(string.Format("qd_prise_titul" + JNBICAJIJMM.EEOPOHEALPK().ECNKLECOKHD(" iterations for read and write") + "id", this.FJJEAMJNLIO));
			break;
		}
		case 3:
		{
			stringBuilder.Append(JNBICAJIJMM.CELEPPAEKAB("") + "MotorbikeShootRight" + JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.EMBKDHKGIEL().DHJBAKDAMGH()) + "************ reelPoint set manually");
			stringBuilder.Append(JNBICAJIJMM.DCEBAJIILPC("IdleStrafeRight") + "UNIQUE_SHADOW" + JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.OIGIHEPJFFJ()) + "<color='#100000'>{0} {1}</color>");
			string str = JNBICAJIJMM.CDDCIKKDFMP("_Offsets");
			if (this.MIMANMPNLPE.NFCDJLJNDLO() > 1)
			{
				str = JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("WorkerPickaxe2") + "?" + JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)(this.EMBKDHKGIEL().GJBKBEEJLDF() * 911.0));
			}
			stringBuilder.Append(JNBICAJIJMM.OOOKJHOHPNN("Demo") + "GiantGrabIdle" + str + " Bones.");
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("") + "Hey, you can easily change me in memory!", this.BDHHPAEHFHG.AGJPNGBDNFE(106f)));
			string jmbkdinhdlo = "_Specular";
			if (Mathf.Abs(this.BDHHPAEHFHG.MFMLCHFNALC) > 802f)
			{
				if (this.BDHHPAEHFHG.MFMLCHFNALC > 1717f)
				{
					jmbkdinhdlo = "qd_prise";
				}
				if (this.BDHHPAEHFHG.MFMLCHFNALC < 586f)
				{
					jmbkdinhdlo = "#02C85F";
				}
			}
			stringBuilder.Append("TONEMAPPING_FILMIC" + string.Format(JNBICAJIJMM.DIOJFJMOPJO("IceHockey Idle"), JNBICAJIJMM.CELEPPAEKAB(jmbkdinhdlo)));
			break;
		}
		case 4:
		{
			Vector2 vector = this.BOGAECCMFLA();
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("_PrevViewProj") + "How your position is stored in memory when obscured:\n(", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.AIMCFAHLPEF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("Try to change this string in memory:\n" + this.BDHHPAEHFHG.ILOCKJIAPFC) + "En", 1));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("hip") + "MotorbikeTurnRight", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.EMBKDHKGIEL().OIGIHEPJFFJ())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("MotorbikeHandlebarSit") + "PistolInstant", JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.NKGGAFLBFDF)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("white") + "Giant2HandSlamIdle", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(vector.x * 69f)), JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)Mathf.RoundToInt(vector.y * 784f))));
			break;
		}
		case 5:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("IdleDie") + "RollerBladeGrindRoyale", JLFJEGIPIMM.IKGFHGKKCPG.PEGPHIOEKHI(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("OnRodChangeClck order_check="), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.EMBKDHKGIEL().AIMCFAHLPEF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("noShowPopl") + "Add random value", "UserOut" + JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)this.EMBKDHKGIEL().ICJDPPOJINN)));
			if (this.EMBKDHKGIEL().HDPNCIECLKP() > 799.0)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("CratePush") + "\n", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.EMBKDHKGIEL().HDPNCIECLKP())));
			}
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.PKGMBFEMKGP().APIDFEMKFDI(this.BDHHPAEHFHG.MIMANMPNLPE.KMGAHCANELI());
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("\n"), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)iibeekcaahk.IBEIBAHKIAH), JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)iibeekcaahk.KMGAHCANELI())));
			break;
		}
		case 6:
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("WorkerPickaxe") + "Save", JLFJEGIPIMM.MHFDIJGJGBJ().DIOCHACFPHJ(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("****** FlyIcon tmpl is null id=") + "cht_msg29", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.EMBKDHKGIEL().DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("SUNSHINE_TWO_CASCADES") + "GestureWonderful", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("colorC") + "fwgt_big_w", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.DBFOHFDOCIB())));
			break;
		case 7:
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("IdleStrafeRight") + "isWoman", JLFJEGIPIMM.PKGMBFEMKGP().MIEDNDLOEJH(this.NKHBAJKMAGD)));
			break;
		case 8:
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("RollerBladeStand") + "OfficeSittingReadingCoffeeSip", JLFJEGIPIMM.IKGFHGKKCPG.MIEDNDLOEJH(this.NKHBAJKMAGD)));
			if (this.LOLCPOPODKE("</color>\n", "_FogAlpha").DGEEJKEEHPE())
			{
				stringBuilder.Append(JNBICAJIJMM.NGALDMFKMJH("\n"));
			}
			break;
		case 9:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("i shrank because the inputfield was this big") + "shop_t20", JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.AIMCFAHLPEF())));
			string str2 = JNBICAJIJMM.PPNKMDJBMLP("RunDive" + this.BDHHPAEHFHG.MIMANMPNLPE.KMGAHCANELI());
			stringBuilder.Append(str2 + "PaperTurn.wav");
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("_parent"), JLFJEGIPIMM.NNEAHAFBOHC().DIOCHACFPHJ(this.NKHBAJKMAGD)));
			break;
		}
		case 10:
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("money") + "ClimbIdle", JLFJEGIPIMM.IKGFHGKKCPG.MIEDNDLOEJH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("UnityEngine.Vector3"), JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC(this.EMBKDHKGIEL().LNEPKLKELMI)));
			break;
		case 11:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("chan_nam") + "stat: ", JLFJEGIPIMM.MHFDIJGJGBJ().PEGPHIOEKHI(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("MotorbikeTurnLeft") + "isImproved", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("Add random value") + JNBICAJIJMM.CELEPPAEKAB("walk" + this.BDHHPAEHFHG.BBOODPCDKAJ) + "upRod", this.BDHHPAEHFHG.BBOODPCDKAJ));
			int ilockjiapfc = this.BDHHPAEHFHG.ILOCKJIAPFC;
			if (ilockjiapfc == 4)
			{
				stringBuilder.Append(JNBICAJIJMM.CELEPPAEKAB("_l_") + "\n" + string.Format(JNBICAJIJMM.PGJCPFNJNPM("CheerKnees"), this.BDHHPAEHFHG.GLLIKKONFAJ) + "_Source");
			}
			if (ilockjiapfc > 1)
			{
				string jmbkdinhdlo2 = string.Format("Failed parsing organizational group.  Setting to group 0", ilockjiapfc);
				stringBuilder.Append("MotorbikeLassoBack" + JNBICAJIJMM.PGJCPFNJNPM(jmbkdinhdlo2) + "demoByteArray");
			}
			break;
		}
		case 15:
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("WRINKLE_MAPS") + "wpn_rec5", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.EMBKDHKGIEL().IBEIBAHKIAH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("wpn_eat1") + "Idle Button Press", this.MIMANMPNLPE.NLHKFMMDMMK()));
			break;
		case 20:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().KMIOLLENCOL() > 1) ? string.Format(JNBICAJIJMM.DCEBAJIILPC("lifeBar"), this.EMBKDHKGIEL().IBEIBAHKIAH) : string.Format(JNBICAJIJMM.CELEPPAEKAB("RollerBladeSkateFwd"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 1) ? string.Format(JNBICAJIJMM.NGALDMFKMJH("Twist"), this.EMBKDHKGIEL().NLHKFMMDMMK()) : string.Format(JNBICAJIJMM.OOOKJHOHPNN("default"), Mathf.Abs(this.EMBKDHKGIEL().KMGAHCANELI())));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.CJKILDPJCFJ() > 0) ? string.Format(JNBICAJIJMM.DCEBAJIILPC("ScubaSwim"), this.MIMANMPNLPE.CJKILDPJCFJ()) : string.Format(JNBICAJIJMM.CDDCIKKDFMP(" iterations for read and write"), Mathf.Abs(this.EMBKDHKGIEL().NFCDJLJNDLO())));
			}
			break;
		case 21:
			if (this.MIMANMPNLPE.KMIOLLENCOL() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().KEHIFGILLJA() > 1) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_look_at_i_k.html"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.PPNKMDJBMLP(""), Mathf.Abs(this.MIMANMPNLPE.KEHIFGILLJA())));
			}
			if (this.EMBKDHKGIEL().KMGAHCANELI() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().NLHKFMMDMMK() > 0) ? string.Format(JNBICAJIJMM.BDKHMOOFHHK("<b>Obscured types:</b>\n<color=\"#75C4EB\">"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.PGJCPFNJNPM("Visit docs to see where PlayerPrefs are stored"), Mathf.Abs(this.EMBKDHKGIEL().NLHKFMMDMMK())));
			}
			if (this.MIMANMPNLPE.CJKILDPJCFJ() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().CJKILDPJCFJ() > 1) ? string.Format(JNBICAJIJMM.DIOJFJMOPJO("Mouse X"), this.EMBKDHKGIEL().NFCDJLJNDLO()) : string.Format(JNBICAJIJMM.PPNKMDJBMLP("Reveling"), Mathf.Abs(this.EMBKDHKGIEL().NFCDJLJNDLO())));
			}
			break;
		case 22:
			if (this.MIMANMPNLPE.NKEOCCKEOCE() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().KEHIFGILLJA() > 1) ? string.Format(JNBICAJIJMM.BDKHMOOFHHK("Resume Interaction With "), this.MIMANMPNLPE.KMIOLLENCOL()) : string.Format(JNBICAJIJMM.NGALDMFKMJH("ScubaOK"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.KMGAHCANELI() != 0)
			{
				stringBuilder.Append((this.EMBKDHKGIEL().KMGAHCANELI() > 1) ? string.Format(JNBICAJIJMM.NGALDMFKMJH("Bone 2 of a BipedReferences limb is null."), this.EMBKDHKGIEL().NLHKFMMDMMK()) : string.Format(JNBICAJIJMM.BDKHMOOFHHK("aa="), Mathf.Abs(this.EMBKDHKGIEL().NLHKFMMDMMK())));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NFCDJLJNDLO() > 0) ? string.Format(JNBICAJIJMM.CDDCIKKDFMP("StaffAttack"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.PPNKMDJBMLP("Reset"), Mathf.Abs(this.EMBKDHKGIEL().NFCDJLJNDLO())));
			}
			break;
		case 27:
			if (this.FJKAFCDDDGO != null && this.BPNNJBBCOFO != null)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("_CameraToWorldMatrix"), this.FJKAFCDDDGO.MPKGPJJKCPK(false, -1), this.BPNNJBBCOFO.MNFCAAIAGOL.NLHKFMMDMMK()));
				if (this.MIMANMPNLPE.NFCDJLJNDLO() < 0)
				{
					stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("Cloth_01.wav"));
				}
				else
				{
					stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("MENU.WAV"), this.MIMANMPNLPE.CJKILDPJCFJ()));
				}
				stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("componentA="), CLFFOBKFKDN.JDELMFDJFNC().ILPNFPBLBGO(this.BPNNJBBCOFO.BKLCKNOLEFD)));
				stringBuilder.Append("MotorbikeWheelyNoHands");
				string arg = "+";
				if (NLNNIDBPKAO.IKGFHGKKCPG.JEFCOLDKFPI(this.BPNNJBBCOFO.ABLFIGDGCBG) != null)
				{
					string arg2 = ".unity3d";
					if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.FOACIAGMAPD(this.BPNNJBBCOFO.ABLFIGDGCBG) < this.BPNNJBBCOFO.LKCIDOHHADJ)
					{
						arg2 = "[curcnt]";
					}
					stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("OneHandSwordJab"), arg2, arg));
				}
			}
			break;
		case 31:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO(""), this.EMBKDHKGIEL().LNEPKLKELMI));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("BackPackOff"), this.EMBKDHKGIEL().OIGIHEPJFFJ()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("IceHockeyGoalieSave2"), this.EMBKDHKGIEL().NKGGAFLBFDF));
			List<int> list = this.BDHHPAEHFHG.JJCFHNLNBCJ("************ isChangedRod *********", "_LightColor").LHMOBCOLGLJ();
			string text5 = JNBICAJIJMM.DIOJFJMOPJO("WorkerShovel2") + "Swimming";
			foreach (int lpfkfnlhgbi in list)
			{
				text5 = text5 + IHFEDJEMJMB.EDKKJNHDBPF().MKCGOALNJDO(lpfkfnlhgbi) + "OfficeSittingHandRestFingerTap";
			}
			stringBuilder.Append(text5);
			break;
		}
		case 32:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("_HrDepthTex"), this.MIMANMPNLPE.DHJBAKDAMGH()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("intensity"), this.EMBKDHKGIEL().NMKCBJKHBOH));
			break;
		case 33:
		{
			int num5 = this.MIMANMPNLPE.KEHIFGILLJA();
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.BOGLJIPFCLI(num5);
			if (kdhoddmndfc != null)
			{
				bool flag = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num5);
				stringBuilder.Append(flag ? string.Format(JNBICAJIJMM.OOOKJHOHPNN("BlackSmithHammer"), kdhoddmndfc.KKEBDLGHBMN) : string.Format(JNBICAJIJMM.CELEPPAEKAB("_WorldToCameraMatrix"), kdhoddmndfc.KKEBDLGHBMN));
			}
			break;
		}
		case 35:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("Calf"), this.MIMANMPNLPE.NMKCBJKHBOH) + "DepthTolerance");
			string jmbkdinhdlo3 = "u_pass";
			if (this.MIMANMPNLPE.FJACMDGJEBL() > 607.0)
			{
				jmbkdinhdlo3 = "ShotgunReloadMagazine";
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP(jmbkdinhdlo3), this.EMBKDHKGIEL().NKGGAFLBFDF) + "name");
			break;
		}
		}
		if (NKFPOLMOKPE)
		{
			if (this.MJHGLLIJMIM)
			{
				stringBuilder.Append(JNBICAJIJMM.PGJCPFNJNPM("28"));
			}
			if (this.MHNDPGDBPNA.Count > 0)
			{
				stringBuilder.Append("Ban OK. Object:");
				stringBuilder.Append("Demo 1 scene: windy mist fog style. Notice the subtle fog animation. To change look, select Main Camera and check image effect settings in inspector.");
				stringBuilder.Append("<color='#a0a0a0'>{2:D2}:{0:D2}:{1:D2}</color>");
				stringBuilder.Append("wpn_book1");
				foreach (IIBEEKCAAHK iibeekcaahk2 in this.MHNDPGDBPNA)
				{
					string str3 = iibeekcaahk2.ToString();
					if (iibeekcaahk2.IBEIBAHKIAH == 1)
					{
						string arg3 = AKPJIACDDFI.IKGFHGKKCPG.KOACOPGBPHD(iibeekcaahk2.KMGAHCANELI(), true);
						if (iibeekcaahk2.CJKILDPJCFJ() > 0)
						{
							str3 = string.Format("FOG CUTTING ON", iibeekcaahk2.CJKILDPJCFJ(), arg3);
						}
						else
						{
							str3 = string.Format("OfficeSittingReadingPageFlip", iibeekcaahk2.NFCDJLJNDLO(), arg3);
						}
					}
					if (iibeekcaahk2.IBEIBAHKIAH == 7)
					{
						string arg4 = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(iibeekcaahk2.ICJDPPOJINN);
						if (iibeekcaahk2.CJKILDPJCFJ() > 1)
						{
							str3 = string.Format("cntx_use", iibeekcaahk2.CJKILDPJCFJ(), arg4);
						}
						else
						{
							str3 = string.Format("PistolLeftHandStab", iibeekcaahk2.CJKILDPJCFJ(), arg4);
						}
					}
					if (iibeekcaahk2.IBEIBAHKIAH == 7)
					{
						string arg5 = IHFEDJEMJMB.OOIJFNAMEDP().IMCJNFHAFGE(iibeekcaahk2.KMGAHCANELI()).KDKILDJEELH(0);
						if (iibeekcaahk2.NFCDJLJNDLO() > 1)
						{
							str3 = string.Format("{0}, ({1}) (Events : {2})", iibeekcaahk2.NODLBGKEGPM, arg5);
						}
						else
						{
							str3 = string.Format("BAG", iibeekcaahk2.CJKILDPJCFJ(), arg5);
						}
					}
					stringBuilder.Append(str3 + "*********read ");
				}
			}
			if (this.FGJIJFNGAIF.Count > 0)
			{
				stringBuilder.Append("_NoiseTex");
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method."));
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) > 0;
					string arg6 = "<color='#{0}'>{1} {3} {2} </color>\n";
					if (flag2)
					{
						arg6 = "Right arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.";
					}
					string value = string.Format("WateringCanWatering", arg6, dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai.CNOLCNDBLJE);
					stringBuilder.Append(value);
				}
			}
			if (this.AHLLIPJFCJB != "wpn_eat3")
			{
				stringBuilder.Append("SkateboardIdle");
				stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("_Refraction"), this.AHLLIPJFCJB));
			}
			List<IIBEEKCAAHK> list2 = this.BBLEPPMMPIL("_MainTex", "name").PBCAFLLKCAO();
			if (list2.Count > 1)
			{
				stringBuilder.Append("invn_rec18");
				stringBuilder.Append(JNBICAJIJMM.DIOJFJMOPJO("Cloth_05_00.wav"));
				foreach (IIBEEKCAAHK iibeekcaahk3 in list2)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(iibeekcaahk3.KEHIFGILLJA());
					stringBuilder.Append(string.Format("crft_cnt", iibeekcaahk3.KMGAHCANELI(), befchfngomi.BNIHFBMEPAB));
				}
			}
			if (this.ABPGFHKGFEK)
			{
				TimeSpan makoioidpjk = this.MGNLHNLJJLD - DateTime.Now;
				string value2 = string.Format(JNBICAJIJMM.NGALDMFKMJH("_Threshold"), JLFJEGIPIMM.NNEAHAFBOHC().CLDPDFPGMBP(makoioidpjk));
				stringBuilder.Append(value2);
			}
		}
		return "wpn_fid1" + stringBuilder + "Отпущена рыба";
	}

	// Token: 0x060041A0 RID: 16800 RVA: 0x001DF4CC File Offset: 0x001DD6CC
	public void HHJHLOPHFMI()
	{
		this.PKIICJOILKI.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item in this.BDHHPAEHFHG.PKIICJOILKI)
		{
			this.PKIICJOILKI.Add(item);
		}
		this.FGJIJFNGAIF.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item2 in this.BDHHPAEHFHG.FGJIJFNGAIF)
		{
			this.FGJIJFNGAIF.Add(item2);
		}
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode("_AllowBackwardsRays");
		this.MHNDPGDBPNA.Clear();
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN("System.Boolean" + xmlNode.InnerText);
			this.MHNDPGDBPNA = diggohpgcnn.LEINEMFIMML();
		}
		this.OKHPDILIOCH.Clear();
		xmlNode = this.LMKLPODNLFC.SelectSingleNode("");
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn2 = new BNOOIOKIFJC.DIGGOHPGCNN("StartControllerModule" + xmlNode.InnerText);
			this.OKHPDILIOCH = diggohpgcnn2.BABLCDMBEAN();
		}
		XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("_Curve");
		if (xmlNodeList == null)
		{
			return;
		}
		foreach (object obj in xmlNodeList)
		{
			NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj);
			if (dlmglijdiai.BDHHPAEHFHG != null)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 = this.MCGINEMKMNH(dlmglijdiai.LPFKFNLHGBI, this.FGJIJFNGAIF);
				if (dlmglijdiai2 != null)
				{
					if (dlmglijdiai.CNOLCNDBLJE > dlmglijdiai2.CNOLCNDBLJE)
					{
						dlmglijdiai2.CNOLCNDBLJE = dlmglijdiai.CNOLCNDBLJE;
					}
				}
				else
				{
					this.FGJIJFNGAIF.Add(dlmglijdiai);
				}
			}
		}
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x001DF6C0 File Offset: 0x001DD8C0
	public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
	{
		return this.BDHHPAEHFHG.OLNGOHEPLBO;
	}

	// Token: 0x060041A2 RID: 16802 RVA: 0x001DF6D0 File Offset: 0x001DD8D0
	public void JCIIPCEDICP(Vector2 NBADAMPJBBH, float FANOBNGKMPH = 56f)
	{
		if (this.BDHHPAEHFHG == null)
		{
			return;
		}
		if (this.BDHHPAEHFHG.CFFHIODOGCH == null)
		{
			this.BDHHPAEHFHG.JIFFLPNBILE();
			return;
		}
		if (this.BFHKBOPOFGB)
		{
			if (Input.GetKey(KeyCode.LeftControl))
			{
				Color color = GUI.color;
				GUI.color = new Color(0.5f, 0.5f, 0.5f, 0.3f);
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), this.BDHHPAEHFHG.CFFHIODOGCH);
				if (this.FJKAFCDDDGO != null)
				{
					float num = FANOBNGKMPH * 0.85f / 2f;
					GUI.DrawTexture(new Rect(NBADAMPJBBH.x + FANOBNGKMPH / 2f - num, NBADAMPJBBH.y + FANOBNGKMPH / 2f - num, num * 2f, num * 2f), this.FJKAFCDDDGO.CFFHIODOGCH);
				}
				GUI.color = color;
				return;
			}
		}
		else
		{
			Rect position = new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH);
			if (!this.IMDLBJICHOE())
			{
				GUI.color = new Color(1f, 0.6f, 0.6f, 1f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF, 7, 2));
			GUI.DrawTexture(position, this.BDHHPAEHFHG.CFFHIODOGCH);
			if (this.FJKAFCDDDGO != null)
			{
				float num2 = FANOBNGKMPH * 0.85f / 2f;
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x + FANOBNGKMPH / 2f - num2, NBADAMPJBBH.y + FANOBNGKMPH / 2f - num2, num2 * 2f, num2 * 2f), this.FJKAFCDDDGO.CFFHIODOGCH);
			}
			if (this.BDHHPAEHFHG.FOAPCABBLBG && this.DLHPFGHOINI > 2f)
			{
				float num3 = FANOBNGKMPH - 4f;
				float num4 = (float)this.BGGJKOMAKEE;
				if (num4 == 0f)
				{
					num4 = 0.001f;
				}
				float num5 = this.DLHPFGHOINI / num4;
				num5 = Mathf.Clamp(num5, 0f, 1f);
				int clbpbjglhee = 1;
				if (num5 < 0.5f)
				{
					clbpbjglhee = 2;
				}
				if (num5 < 0.2f)
				{
					clbpbjglhee = 3;
				}
				float num6 = num3 * num5;
				if (num5 < 0.6f)
				{
					GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 2f, NBADAMPJBBH.y, 5f, num3), GuiProcessor.IKGFHGKKCPG.durab, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 4, 1));
					GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 2f, NBADAMPJBBH.y + FANOBNGKMPH - 2f - num6, 4f, num6), GuiProcessor.IKGFHGKKCPG.durab, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 4, 1));
				}
			}
			if (this.MBKMKGABBGE == 34)
			{
				float num7 = position.height / 2f;
				Rect position2 = new Rect(position.x + 2f, position.y + position.height - num7 - 2f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.KMIIGKECOEB(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 0)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF + 7, 7, 2));
			}
			if (this.HHOLFABGDJA == 1309)
			{
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (idchhhedhdc != null)
				{
					GUI.DrawTexture(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y + FANOBNGKMPH / 6f, FANOBNGKMPH, FANOBNGKMPH / 2f), idchhhedhdc.KMIIGKECOEB(2).KEDGAOBCNJG, ScaleMode.StretchToFill);
				}
			}
			GUI.color = Color.white;
			bool flag = this.IEHCLOIEBJA;
			if (this.MJHGLLIJMIM)
			{
				flag = true;
			}
			if (flag)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, FANOBNGKMPH, FANOBNGKMPH), GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(7, 7, 2));
			}
			if (this.MJHGLLIJMIM)
			{
				GUI.DrawTexture(new Rect(NBADAMPJBBH.x + 8f, NBADAMPJBBH.y + 8f, FANOBNGKMPH - 16f, FANOBNGKMPH - 16f), GameInterface.getI.wpnBrokenTexture);
			}
			float num8 = FANOBNGKMPH / 3.5f;
			Rect position3 = new Rect(NBADAMPJBBH.x + FANOBNGKMPH - num8, NBADAMPJBBH.y + FANOBNGKMPH - num8, num8, num8);
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 1)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(16, 8, 8));
			}
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 2)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(17, 8, 8));
			}
			if (this.BDHHPAEHFHG.MBKMKGABBGE == 3)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(18, 8, 8));
			}
			if (this.BDHHPAEHFHG.GCLKLEIMABA == 2)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y - 2f, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(24, 8, 8));
			}
			if (this.ICOFLHIIBCP)
			{
				float num9 = num8 / 1.5f;
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + 4f, NBADAMPJBBH.y + FANOBNGKMPH - num9, num9, num9), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(8, 8, 8));
			}
			if (this.DNOLHLJODNK)
			{
				float num10 = num8 * 1.3f;
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x + FANOBNGKMPH - num10 + 2f, NBADAMPJBBH.y - 2f, num10, num10), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.LNKLEIEFGCP, 8, 4));
			}
			if (this.BDHHPAEHFHG.KKOLKEEALFD)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(11, 8, 8));
			}
			if (this.ABPGFHKGFEK)
			{
				GUI.DrawTextureWithTexCoords(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, num8, num8), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(12, 8, 8));
			}
			if (this.ILFHHDNJHNM > 1)
			{
				string ijcedogbhke = string.Concat(this.ILFHHDNJHNM) ?? "";
				EKBAPCMPANI.DEAHGKKDHPM(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y + FANOBNGKMPH - 16f, FANOBNGKMPH - 4f, 12f), ijcedogbhke, Color.green, TextAnchor.LowerRight);
			}
			if (this.LABFBKENHAA - this.BHKPHJBAKLO != 0)
			{
				string ijcedogbhke2 = "+" + (this.LABFBKENHAA - this.BHKPHJBAKLO);
				EKBAPCMPANI.DEAHGKKDHPM(new Rect(NBADAMPJBBH.x + 2f, NBADAMPJBBH.y + 4f, FANOBNGKMPH - 4f, 12f), ijcedogbhke2, Color.green, TextAnchor.UpperRight);
			}
			int gclkleimaba = this.BDHHPAEHFHG.GCLKLEIMABA;
		}
	}

	// Token: 0x060041A3 RID: 16803 RVA: 0x001DFE0C File Offset: 0x001DE00C
	public override void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		Rect rect = new Rect(COAGIAMOCIA.x + 1f, COAGIAMOCIA.y + 1f, COAGIAMOCIA.height - 2f, COAGIAMOCIA.height - 2f);
		if (COAGIAMOCIA.height >= 40f)
		{
			this.JCIIPCEDICP(new Vector2(rect.x, rect.y), rect.height);
			Rect position = rect;
			position.x = rect.x + rect.width + 10f;
			position.width = COAGIAMOCIA.width - position.x - 10f;
			GUI.Label(position, this.JBMHGFHFIIL(), OFPNEDEAMAB);
			return;
		}
		GUI.DrawTextureWithTexCoords(rect, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF, 7, 2));
		GUI.DrawTexture(rect, this.BDHHPAEHFHG.CFFHIODOGCH);
		if (this.MBKMKGABBGE == 34)
		{
			float num = rect.height / 2f;
			Rect position2 = new Rect(rect.x + 2f, rect.y + rect.height - num - 2f, num, num);
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.IBEIBAHKIAH);
			if (kdhoddmndfc != null)
			{
				GUI.DrawTexture(position2, kdhoddmndfc.KMIIGKECOEB(), ScaleMode.StretchToFill);
			}
		}
		if (this.BDHHPAEHFHG.FOAPCABBLBG && this.BGGJKOMAKEE > 0)
		{
			if ((int)(this.DLHPFGHOINI / (float)this.BGGJKOMAKEE * 100f) < 10)
			{
				GUI.DrawTextureWithTexCoords(rect, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(7, 7, 2));
			}
		}
		else if (this.KBGHOIJIPJF > 1)
		{
			GUI.DrawTextureWithTexCoords(rect, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF + 7, 7, 2));
		}
		Rect position3 = rect;
		position3.x = rect.x + rect.width + 5f;
		position3.width = COAGIAMOCIA.width - position3.x - 5f;
		position3.height = COAGIAMOCIA.height - 8f;
		GUI.Label(position3, this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x060041A4 RID: 16804 RVA: 0x001E0044 File Offset: 0x001DE244
	public void CCEBHJMAGPP()
	{
		this.PKIICJOILKI.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item in this.BDHHPAEHFHG.PKIICJOILKI)
		{
			this.PKIICJOILKI.Add(item);
		}
		this.FGJIJFNGAIF.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item2 in this.BDHHPAEHFHG.FGJIJFNGAIF)
		{
			this.FGJIJFNGAIF.Add(item2);
		}
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode("name");
		this.MHNDPGDBPNA.Clear();
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN("demoColor" + xmlNode.InnerText);
			this.MHNDPGDBPNA = diggohpgcnn.JJOPAMIHIFC();
		}
		this.OKHPDILIOCH.Clear();
		xmlNode = this.LMKLPODNLFC.SelectSingleNode("RollerBladeTurnRight");
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn2 = new BNOOIOKIFJC.DIGGOHPGCNN("Horizontal" + xmlNode.InnerText);
			this.OKHPDILIOCH = diggohpgcnn2.EDAHDHCPIEL;
		}
		XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("#002000");
		if (xmlNodeList == null)
		{
			return;
		}
		foreach (object obj in xmlNodeList)
		{
			NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj);
			if (dlmglijdiai.BDHHPAEHFHG != null)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 = this.MCGINEMKMNH(dlmglijdiai.LPFKFNLHGBI, this.FGJIJFNGAIF);
				if (dlmglijdiai2 != null)
				{
					if (dlmglijdiai.CNOLCNDBLJE > dlmglijdiai2.CNOLCNDBLJE)
					{
						dlmglijdiai2.CNOLCNDBLJE = dlmglijdiai.CNOLCNDBLJE;
					}
				}
				else
				{
					this.FGJIJFNGAIF.Add(dlmglijdiai);
				}
			}
		}
	}

	// Token: 0x060041A5 RID: 16805 RVA: 0x001E0238 File Offset: 0x001DE438
	public IIBEEKCAAHK MCPFLBKLJHG()
	{
		if (this.BDHHPAEHFHG == null)
		{
			return new IIBEEKCAAHK();
		}
		double num = (double)(((float)this.ILFHHDNJHNM + 1167f) / ((this.BDHHPAEHFHG.HOALBMDJNDM == 0) ? 301f : ((float)this.BDHHPAEHFHG.HOALBMDJNDM + 1538f)));
		double num2 = (double)this.DELMOBCNBDB * num;
		bool foapcabblbg = this.BDHHPAEHFHG.FOAPCABBLBG;
		return new IIBEEKCAAHK(1782.0, num2 / 675.0, 127.0);
	}

	// Token: 0x060041A6 RID: 16806 RVA: 0x001E02C1 File Offset: 0x001DE4C1
	public void IKDEALKJOLM(IIBEEKCAAHK DCCPCBLODIG)
	{
		this.IFCGHIJPKGK = new BLBDBAHLBIF(DCCPCBLODIG.AIMCFAHLPEF() * 188.0, DCCPCBLODIG.NMKCBJKHBOH * 654.0, DCCPCBLODIG.DBFOHFDOCIB() * 802.0);
	}

	// Token: 0x060041A7 RID: 16807 RVA: 0x001E0300 File Offset: 0x001DE500
	public void CILBHAALIEF()
	{
		if (this.CLKMCAHNHBM != "wpn_add/base")
		{
			this.LMKLPODNLFC.LoadXml(this.CLKMCAHNHBM);
			this.MJHGLLIJMIM = this.BBLEPPMMPIL("", "Error!").KGFNAIIPHKL();
			this.MBKMKGABBGE = this.BBLEPPMMPIL("", "UnityEngine.Vector3").NOHLIOHBLMF();
			this.HHOLFABGDJA = this.LOLCPOPODKE("Water Refl Camera id", "RunBackLeft").NOHLIOHBLMF();
			this.NKHBAJKMAGD = this.BBLEPPMMPIL("err: recttrans is null", "_MainTex").PPAAACJOOGA;
			this.BGGJKOMAKEE = this.LOLCPOPODKE("Bot", "netUpdater").IGEAGOANELP();
			this.DELMOBCNBDB = this.BBLEPPMMPIL("_TempTexture", "isKeyPress").LMNLDJABLMH();
			this.LEADKFMCFCC = this.BBLEPPMMPIL("Hit", "ChannelCastDirected").DCGNALDFPDB();
			this.LODGJCMEGAI = this.BBLEPPMMPIL("Invalid IKEffector.positionOffset (contains NaN)! Please make sure not to set IKEffector.positionOffset to NaN values.", "error").OBAODGNJIDB();
			this.KBGHOIJIPJF = this.BBLEPPMMPIL("Location ", "WizardBlock").INFKMCKHMAN();
			this.GOEGADLBGML = this.BBLEPPMMPIL("Loading ", "enableFog").NOHLIOHBLMF();
			this.LABFBKENHAA = this.LOLCPOPODKE("#FF4040", "1HandHeavySwing").DCGNALDFPDB();
			this.BHKPHJBAKLO = this.LOLCPOPODKE("ArmFlex5", "wpn_line2").CMNMAJAOGDK();
			this.AHLLIPJFCJB = this.LOLCPOPODKE("-no result-", "SatNightFever").LEPDIDFPFBO();
			this.ADOFHHCDGON = this.BBLEPPMMPIL("1 Hand Heavy Swing 2", "\n").DCGNALDFPDB();
			this.ECKKCDKHNEH = this.BBLEPPMMPIL("#000000", "BAG").DIKKDGKIPEA;
			this.ICOFLHIIBCP = this.LOLCPOPODKE("error", "Sorry, VRIK User Manual is not finished yet.").KPAFFJNBLHK;
			this.MAIGLJPCKKL = this.BBLEPPMMPIL("choldposx", "{{ {{{0}:{1}}}, {{{2}:{3}}} }}").LOLBCAIEFMN();
			this.DNOLHLJODNK = this.BBLEPPMMPIL("crft_crft", "MotorbikeLookBack").KGFNAIIPHKL();
			this.LNKLEIEFGCP = this.BBLEPPMMPIL("This method requires a mesh filter!", "").IPPDIFCDJHE();
			this.GGOLJKNHMGL = this.LOLCPOPODKE("get 1401 cmd", "{0} {1}\n{2}").LMNLDJABLMH();
			this.DKDEAPCMECH = this.BBLEPPMMPIL("_ClipToWorld", "  ").IPPDIFCDJHE();
			this.KFKPLMLLDCK = (float)this.LOLCPOPODKE("Eat", "_ZTest").IGEAGOANELP() / 1763f;
			this.KAKIIGPMOKF = 1340f + 1799f * (float)this.BBLEPPMMPIL("val=", "FOG_EXP2").LMNLDJABLMH() / 860f;
		}
		this.NHFHEIGICKP = this.LMKLPODNLFC.SelectSingleNode("CheerJump");
		this.GMNCILDPIKP = this.LMKLPODNLFC.SelectSingleNode("wpn_add/addoptions");
		this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(this.HHOLFABGDJA);
		if (this.BDHHPAEHFHG != null)
		{
			this.HHJHLOPHFMI();
			this.FDJPJJJHHEG = this.BDHHPAEHFHG.BNIHFBMEPAB;
			if (this.FDJPJJJHHEG == null)
			{
				this.FDJPJJJHHEG = " / " + this.HHOLFABGDJA;
			}
			string newValue = "********* LoadAllAssets via ASYNC loadLevelTime=";
			if (this.MBKMKGABBGE == -10)
			{
				if (CLFFOBKFKDN.OOIJFNAMEDP().PGMOGALKIIP.ContainsKey(this.EMBKDHKGIEL().ICJDPPOJINN))
				{
					this.BPNNJBBCOFO = CLFFOBKFKDN.GAPIOPHMBNB().PGMOGALKIIP[this.MIMANMPNLPE.KMGAHCANELI()];
					this.FJKAFCDDDGO = IHFEDJEMJMB.OELKEADDKPE().GBKMHIGNKJA(this.BPNNJBBCOFO.MNFCAAIAGOL.NKEOCCKEOCE());
					if (this.FJKAFCDDDGO != null)
					{
						this.FJKAFCDDDGO.JIFFLPNBILE();
						newValue = this.FJKAFCDDDGO.BNIHFBMEPAB;
					}
					else
					{
						newValue = "</i></color>" + this.BPNNJBBCOFO.MNFCAAIAGOL.NKEOCCKEOCE();
					}
				}
				else
				{
					newValue = "" + this.EMBKDHKGIEL().NLHKFMMDMMK();
				}
			}
			this.FDJPJJJHHEG = this.FDJPJJJHHEG.Replace("IdleStrafeLeft", newValue);
			this.BDHHPAEHFHG.HKHPGCHCHAI();
			if (this.HHOLFABGDJA == -81)
			{
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.MIMANMPNLPE.NKEOCCKEOCE());
				if (idchhhedhdc != null)
				{
					this.FDJPJJJHHEG = string.Format(this.FDJPJJJHHEG, idchhhedhdc.JEFGMLHAAFP(1));
					idchhhedhdc.JIFFLPNBILE(0);
				}
			}
		}
		else
		{
			Debug.LogError("CrawlLocomotion" + this.HHOLFABGDJA);
		}
		float num = (this.EMBKDHKGIEL().PHLLHDNNOMB() * 1392f + this.EMBKDHKGIEL().LOIBCMBMLEC() * 719f) * (this.NKHBAJKMAGD / 1953f);
		float num2 = 130f;
		if (this.BDHHPAEHFHG.GCLKLEIMABA == 6)
		{
			num2 = 276f;
		}
		if (this.BDHHPAEHFHG.GCLKLEIMABA == 5)
		{
			num2 = 1406f;
		}
		this.FJJEAMJNLIO = Mathf.RoundToInt(num * num2);
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x001E0858 File Offset: 0x001DEA58
	public void OHDHFJFKLAJ(Vector2 FEEBMFDLDHB)
	{
		if (this.BDHHPAEHFHG == null)
		{
			return;
		}
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		HFIINBICCLO.IKGFHGKKCPG.HHMMBALEHIH(new Rect(vector.x - FEEBMFDLDHB.x, vector.y - FEEBMFDLDHB.y, 64f, 64f), this.BDHHPAEHFHG.CFFHIODOGCH, Color.white);
	}

	// Token: 0x060041AA RID: 16810 RVA: 0x001E08D4 File Offset: 0x001DEAD4
	public Vector2 HMPDFKJDDKO()
	{
		Vector2 zero = Vector2.zero;
		zero.x = this.MIMANMPNLPE.FDCKJDDOJPB() * this.EMBKDHKGIEL().OBEOJCGHOGL;
		if (this.EMBKDHKGIEL().PHLLHDNNOMB() <= 1168f)
		{
			zero.x = 1386f;
		}
		zero.y = this.MIMANMPNLPE.PHLLHDNNOMB() * 238f;
		return zero;
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x060041AB RID: 16811 RVA: 0x001D9176 File Offset: 0x001D7376
	public IIBEEKCAAHK MIMANMPNLPE
	{
		get
		{
			return this.LODGJCMEGAI;
		}
	}

	// Token: 0x060041AC RID: 16812 RVA: 0x001E093C File Offset: 0x001DEB3C
	public BNOOIOKIFJC.DIGGOHPGCNN LOLCPOPODKE(string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		EKBAPCMPANI.HFMCCHGPFJF hfmcchgpfjf = new EKBAPCMPANI.HFMCCHGPFJF();
		hfmcchgpfjf.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = hfmcchgpfjf.LJOEIPHIJOE) == null)
			{
				predicate = (hfmcchgpfjf.LJOEIPHIJOE = new Func<XmlNode, bool>(hfmcchgpfjf.EONLNPOOMNB));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("FOG_OF_WAR_ON" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("Dealer Shuffle");
	}

	// Token: 0x060041AD RID: 16813 RVA: 0x001E09F0 File Offset: 0x001DEBF0
	public string MEKPGCCFEOO(bool NKFPOLMOKPE = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = this.MBKMKGABBGE;
		if (this.MBKMKGABBGE == 25)
		{
			stringBuilder.Append(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_cmp") + "\n");
			if (this.BDHHPAEHFHG.JALOCNOIDFJ > 0)
			{
				num = this.BDHHPAEHFHG.JALOCNOIDFJ;
			}
		}
		switch (num)
		{
		case 1:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 1);
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num2);
			if (this.OKHPDILIOCH.Count > 0)
			{
				text = "";
				foreach (int jjjnkodleel in this.OKHPDILIOCH)
				{
					num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, jjjnkodleel);
					text = text + JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num2) + " /";
				}
				text = text.Remove(text.Length - 1);
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod2"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), text));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod3"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF / 100.0)));
			string text2 = "";
			if (this.ADOFHHCDGON > 0)
			{
				text2 = string.Concat(new object[]
				{
					text2,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_from"),
					" ",
					this.ADOFHHCDGON,
					" гр "
				});
			}
			if (this.ECKKCDKHNEH > 0)
			{
				text2 = string.Concat(new object[]
				{
					text2,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to"),
					" ",
					this.ECKKCDKHNEH,
					" гр "
				});
			}
			if (text2 != "")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod4"), text2));
			}
			stringBuilder.Append(string.Format("<color='#003000'>" + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cnt_energ") + "</color>\n", this.FJJEAMJNLIO));
			break;
		}
		case 2:
		{
			float num3 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 1);
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod2"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num3)));
			string text3 = "";
			if (this.ADOFHHCDGON > 0)
			{
				text3 = string.Concat(new object[]
				{
					text3,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_from"),
					" ",
					this.ADOFHHCDGON,
					" гр "
				});
			}
			if (this.ECKKCDKHNEH > 0)
			{
				text3 = string.Concat(new object[]
				{
					text3,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to"),
					" ",
					this.ECKKCDKHNEH,
					" гр "
				});
			}
			if (text3 != "")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod4"), text3));
			}
			stringBuilder.Append(string.Format("<color='#003000'>" + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cnt_energ") + "</color>\n", this.FJJEAMJNLIO));
			break;
		}
		case 3:
		{
			float num4 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.LODGJCMEGAI, 1);
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod2"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num4)));
			string text4 = "";
			if (this.ADOFHHCDGON > 0)
			{
				text4 = string.Concat(new object[]
				{
					text4,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_from"),
					" ",
					this.ADOFHHCDGON,
					" гр "
				});
			}
			if (this.ECKKCDKHNEH > 0)
			{
				text4 = string.Concat(new object[]
				{
					text4,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to"),
					" ",
					this.ECKKCDKHNEH,
					" гр "
				});
			}
			if (text4 != "")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod4"), text4));
			}
			stringBuilder.Append(string.Format("<color='#003000'>" + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cnt_energ") + "</color>\n", this.FJJEAMJNLIO));
			break;
		}
		case 4:
		{
			stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_cat1") + " " + JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI) + " %\n");
			stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_cat2") + " " + JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH) + " %\n");
			string str = JNBICAJIJMM.LEBHCLDODNI("wpn_cat3");
			if (this.MIMANMPNLPE.NODLBGKEGPM > 0)
			{
				str = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to") + " " + JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)(this.MIMANMPNLPE.NKGGAFLBFDF * 1000.0));
			}
			stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_cat4") + " " + str + " \n");
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_cat5") + "\n", this.BDHHPAEHFHG.AGJPNGBDNFE(0.2f)));
			string jmbkdinhdlo = "reel_type0";
			if (Mathf.Abs(this.BDHHPAEHFHG.MFMLCHFNALC) > 0.5f)
			{
				if (this.BDHHPAEHFHG.MFMLCHFNALC > 0f)
				{
					jmbkdinhdlo = "reel_type1";
				}
				if (this.BDHHPAEHFHG.MFMLCHFNALC < 0f)
				{
					jmbkdinhdlo = "reel_type2";
				}
			}
			stringBuilder.Append("\n" + string.Format(JNBICAJIJMM.LEBHCLDODNI("reel_type"), JNBICAJIJMM.LEBHCLDODNI(jmbkdinhdlo)));
			break;
		}
		case 5:
		{
			Vector2 vector = this.KPLOLDJFGBE();
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_line1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("line_type" + this.BDHHPAEHFHG.ILOCKJIAPFC) + "\n", 0));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_line3") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_line2") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hookf") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(vector.x * 1000f)), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(vector.y * 1000f))));
			break;
		}
		case 6:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hook1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hook2") + "\n", " №" + JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)this.MIMANMPNLPE.ICJDPPOJINN)));
			if (this.MIMANMPNLPE.NKGGAFLBFDF > 0.009999999776482582)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hook3") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF)));
			}
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.IKGFHGKKCPG.BLJKHILCCDL(this.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hookf"), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)iibeekcaahk.IBEIBAHKIAH), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)iibeekcaahk.ICJDPPOJINN)));
			break;
		}
		case 7:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_fid1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_fid2") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_fid3") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF)));
			break;
		case 8:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			break;
		case 9:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			if (this.BBLEPPMMPIL("wpn_add/addoptions", "signal_enable").KPAFFJNBLHK)
			{
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_popl1"));
			}
			break;
		case 10:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			string str2 = JNBICAJIJMM.LEBHCLDODNI("wpn_ibsize_" + this.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
			stringBuilder.Append(str2 + "\n");
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_iwgt"), JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			break;
		}
		case 11:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			break;
		case 12:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait_sz") + JNBICAJIJMM.LEBHCLDODNI("wpn_bait_sz" + this.BDHHPAEHFHG.BBOODPCDKAJ) + "\n", this.BDHHPAEHFHG.BBOODPCDKAJ));
			int ilockjiapfc = this.BDHHPAEHFHG.ILOCKJIAPFC;
			if (ilockjiapfc == 7)
			{
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_bait_vob_1") + " " + string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait_vob_deep"), this.BDHHPAEHFHG.GLLIKKONFAJ) + "\n");
			}
			if (ilockjiapfc > 0)
			{
				string jmbkdinhdlo2 = string.Format("wpn_bait_inf_{0}", ilockjiapfc);
				stringBuilder.Append("\n" + JNBICAJIJMM.LEBHCLDODNI(jmbkdinhdlo2) + "\n");
			}
			break;
		}
		case 16:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_tank1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.MIMANMPNLPE.IBEIBAHKIAH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_tank2") + "\n", this.MIMANMPNLPE.ICJDPPOJINN));
			break;
		case 21:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat1"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat1"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat3"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat4"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat5"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat6"), Mathf.Abs(this.MIMANMPNLPE.NODLBGKEGPM)));
			}
			break;
		case 22:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat1"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat1"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat3"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat4"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat7"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat8"), Mathf.Abs(this.MIMANMPNLPE.NODLBGKEGPM)));
			}
			break;
		case 23:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_med1"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_med2"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat5"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat6"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat7"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat8"), Mathf.Abs(this.MIMANMPNLPE.NODLBGKEGPM)));
			}
			break;
		case 28:
			if (this.FJKAFCDDDGO != null && this.BPNNJBBCOFO != null)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rec1"), this.FJKAFCDDDGO.JPBOPFNPNHC(false, -1), this.BPNNJBBCOFO.MNFCAAIAGOL.ICJDPPOJINN));
				if (this.MIMANMPNLPE.NODLBGKEGPM < 0)
				{
					stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_rec2"));
				}
				else
				{
					stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rec3"), this.MIMANMPNLPE.NODLBGKEGPM));
				}
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rec4"), CLFFOBKFKDN.IKGFHGKKCPG.CLIEHLMDOAD(this.BPNNJBBCOFO.BKLCKNOLEFD)));
				stringBuilder.Append("\n");
				string arg = "";
				if (NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.BPNNJBBCOFO.ABLFIGDGCBG) != null)
				{
					string arg2 = "#80ff00";
					if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(this.BPNNJBBCOFO.ABLFIGDGCBG) < this.BPNNJBBCOFO.LKCIDOHHADJ)
					{
						arg2 = "#ff6000";
					}
					stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rec5"), arg2, arg));
				}
			}
			break;
		case 32:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rem1"), this.MIMANMPNLPE.LNEPKLKELMI));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rem2"), this.MIMANMPNLPE.NMKCBJKHBOH));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rem3"), this.MIMANMPNLPE.NKGGAFLBFDF));
			List<int> list = this.BDHHPAEHFHG.BBLEPPMMPIL("wpn_add/base", "rem").EDAHDHCPIEL;
			string text5 = JNBICAJIJMM.LEBHCLDODNI("wpn_rem4") + " ";
			foreach (int lpfkfnlhgbi in list)
			{
				text5 = text5 + IHFEDJEMJMB.IKGFHGKKCPG.JGLANEDNNAB(lpfkfnlhgbi) + "; ";
			}
			stringBuilder.Append(text5);
			break;
		}
		case 33:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_dress1"), this.MIMANMPNLPE.LNEPKLKELMI));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_dress2"), this.MIMANMPNLPE.NMKCBJKHBOH));
			break;
		case 34:
		{
			int num5 = this.MIMANMPNLPE.IBEIBAHKIAH;
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(num5);
			if (kdhoddmndfc != null)
			{
				bool flag = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num5);
				stringBuilder.Append(flag ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_book1"), kdhoddmndfc.KKEBDLGHBMN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_book2"), kdhoddmndfc.KKEBDLGHBMN));
			}
			break;
		}
		case 36:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_chair1"), this.MIMANMPNLPE.NMKCBJKHBOH) + "\n");
			string jmbkdinhdlo3 = "wpn_chair2";
			if (this.MIMANMPNLPE.NKGGAFLBFDF > 0.0)
			{
				jmbkdinhdlo3 = "wpn_chair3";
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI(jmbkdinhdlo3), this.MIMANMPNLPE.NKGGAFLBFDF) + "\n");
			break;
		}
		}
		if (NKFPOLMOKPE)
		{
			if (this.MJHGLLIJMIM)
			{
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_break"));
			}
			if (this.MHNDPGDBPNA.Count > 0)
			{
				stringBuilder.Append("\n");
				stringBuilder.Append("\n");
				stringBuilder.Append("____________________________________");
				stringBuilder.Append("\n");
				foreach (IIBEEKCAAHK iibeekcaahk2 in this.MHNDPGDBPNA)
				{
					string str3 = iibeekcaahk2.ToString();
					if (iibeekcaahk2.IBEIBAHKIAH == 1)
					{
						string arg3 = AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(iibeekcaahk2.ICJDPPOJINN, false);
						if (iibeekcaahk2.NODLBGKEGPM > 0)
						{
							str3 = string.Format("<color='#003000'>+{0} {1}</color>", iibeekcaahk2.NODLBGKEGPM, arg3);
						}
						else
						{
							str3 = string.Format("<color='#300000'>{0} {1}</color>", iibeekcaahk2.NODLBGKEGPM, arg3);
						}
					}
					if (iibeekcaahk2.IBEIBAHKIAH == 2)
					{
						string arg4 = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(iibeekcaahk2.ICJDPPOJINN);
						if (iibeekcaahk2.NODLBGKEGPM > 0)
						{
							str3 = string.Format("<color='#000030'>+{0} {1}</color>", iibeekcaahk2.NODLBGKEGPM, arg4);
						}
						else
						{
							str3 = string.Format("<color='#100000'>{0} {1}</color>", iibeekcaahk2.NODLBGKEGPM, arg4);
						}
					}
					if (iibeekcaahk2.IBEIBAHKIAH == 3)
					{
						string arg5 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk2.ICJDPPOJINN).BEFIAPHPIBJ(0);
						if (iibeekcaahk2.NODLBGKEGPM > 0)
						{
							str3 = string.Format("<color='#002030'>+{0} {1}</color>", iibeekcaahk2.NODLBGKEGPM, arg5);
						}
						else
						{
							str3 = string.Format("<color='#100000'>{0} {1}</color>", iibeekcaahk2.NODLBGKEGPM, arg5);
						}
					}
					stringBuilder.Append(str3 + "\n");
				}
			}
			if (this.FGJIJFNGAIF.Count > 0)
			{
				stringBuilder.Append("\n");
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("inv_bonus"));
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) > 0;
					string arg6 = "404040";
					if (flag2)
					{
						arg6 = "206000";
					}
					string value = string.Format("\n<color='#{0}'>+{2} '{1}'</color> ", arg6, dlmglijdiai.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai.CNOLCNDBLJE);
					stringBuilder.Append(value);
				}
			}
			if (this.AHLLIPJFCJB != "")
			{
				stringBuilder.Append("\n");
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_master"), this.AHLLIPJFCJB));
			}
			List<IIBEEKCAAHK> list2 = this.BBLEPPMMPIL("wpn_add/base", "inner_craft_wpn").HDELBIDJNOK;
			if (list2.Count > 0)
			{
				stringBuilder.Append("\n");
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_sost"));
				foreach (IIBEEKCAAHK iibeekcaahk3 in list2)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk3.IBEIBAHKIAH);
					stringBuilder.Append(string.Format("x{0} {1}\n", iibeekcaahk3.ICJDPPOJINN, befchfngomi.BNIHFBMEPAB));
				}
			}
			if (this.ABPGFHKGFEK)
			{
				TimeSpan makoioidpjk = this.MGNLHNLJJLD - DateTime.Now;
				string value2 = string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_timed"), JLFJEGIPIMM.IKGFHGKKCPG.CLDPDFPGMBP(makoioidpjk));
				stringBuilder.Append(value2);
			}
		}
		return "<color='#000000'>" + stringBuilder + "</color>";
	}

	// Token: 0x060041AE RID: 16814 RVA: 0x001E2400 File Offset: 0x001E0600
	public void IOGPBIODFHL()
	{
		this.PKIICJOILKI.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item in this.BDHHPAEHFHG.PKIICJOILKI)
		{
			this.PKIICJOILKI.Add(item);
		}
		this.FGJIJFNGAIF.Clear();
		foreach (NLNNIDBPKAO.DLMGLIJDIAI item2 in this.BDHHPAEHFHG.FGJIJFNGAIF)
		{
			this.FGJIJFNGAIF.Add(item2);
		}
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode("_MaxRadiusOrKInPaper");
		this.MHNDPGDBPNA.Clear();
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN("BackPackOff" + xmlNode.InnerText);
			this.MHNDPGDBPNA = diggohpgcnn.GDOEONNNHKL();
		}
		this.OKHPDILIOCH.Clear();
		xmlNode = this.LMKLPODNLFC.SelectSingleNode("msg_other");
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn2 = new BNOOIOKIFJC.DIGGOHPGCNN("1" + xmlNode.InnerText);
			this.OKHPDILIOCH = diggohpgcnn2.BEJDLFKONDO();
		}
		XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("SneakLeft");
		if (xmlNodeList == null)
		{
			return;
		}
		foreach (object obj in xmlNodeList)
		{
			NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj);
			if (dlmglijdiai.BDHHPAEHFHG != null)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 = this.AJOKHCABEKD(dlmglijdiai.LPFKFNLHGBI, this.FGJIJFNGAIF);
				if (dlmglijdiai2 != null)
				{
					if (dlmglijdiai.CNOLCNDBLJE > dlmglijdiai2.CNOLCNDBLJE)
					{
						dlmglijdiai2.CNOLCNDBLJE = dlmglijdiai.CNOLCNDBLJE;
					}
				}
				else
				{
					this.FGJIJFNGAIF.Add(dlmglijdiai);
				}
			}
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x060041AF RID: 16815 RVA: 0x001E25F4 File Offset: 0x001E07F4
	public bool HGLFHCHIEJI
	{
		get
		{
			return this.BBLEPPMMPIL("wpn_add/base", "isPaint").KPAFFJNBLHK;
		}
	}

	// Token: 0x060041B0 RID: 16816 RVA: 0x001E260C File Offset: 0x001E080C
	public string JPBOPFNPNHC(bool BGNPMOCLIGL = false)
	{
		return string.Concat(new string[]
		{
			"<color='",
			this.BDHHPAEHFHG.BKKCDJHCCHP(this.KBGHOIJIPJF, BGNPMOCLIGL),
			"'>",
			this.FDJPJJJHHEG,
			"</color>"
		});
	}

	// Token: 0x060041B1 RID: 16817 RVA: 0x001E265C File Offset: 0x001E085C
	public bool NJOOLLJACJJ()
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		if (this.GOEGADLBGML > ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.CNOLCNDBLJE))
		{
			return false;
		}
		foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
		{
			if (dlmglijdiai.CNOLCNDBLJE > kfhelhglnmh.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060041B2 RID: 16818 RVA: 0x001E26E4 File Offset: 0x001E08E4
	public IIBEEKCAAHK JHCJMGBOECH()
	{
		if (this.BDHHPAEHFHG == null)
		{
			return new IIBEEKCAAHK();
		}
		double num = (double)(((float)this.ILFHHDNJHNM + 0.001f) / ((this.BDHHPAEHFHG.HOALBMDJNDM == 0) ? 1.001f : ((float)this.BDHHPAEHFHG.HOALBMDJNDM + 0.001f)));
		double num2 = (double)this.DELMOBCNBDB * num;
		bool foapcabblbg = this.BDHHPAEHFHG.FOAPCABBLBG;
		return new IIBEEKCAAHK(0.0, num2 / 3.0, 0.0);
	}

	// Token: 0x060041B3 RID: 16819 RVA: 0x001E2770 File Offset: 0x001E0970
	public virtual string HLHHDFFDHGL()
	{
		string text = "SecondaryCausticsProjector";
		if (this.BDHHPAEHFHG.FOAPCABBLBG && this.BGGJKOMAKEE > 1)
		{
			int num = (int)(this.DLHPFGHOINI / (float)this.BGGJKOMAKEE * 30f);
			text = string.Format("Assets/Weapons/", Mathf.RoundToInt(this.DLHPFGHOINI), this.BGGJKOMAKEE);
			if (num < 100)
			{
				text = "RollerBladeCrossoverLeft" + text + " ";
			}
			if (num >= -51)
			{
				text = "End" + text + " ";
			}
		}
		return this.MBBMKNBDPDA(false) + string.Format(JNBICAJIJMM.PPNKMDJBMLP("Hidden/Post FX/Grain Generator"), this.ILFHHDNJHNM) + text;
	}

	// Token: 0x060041B4 RID: 16820 RVA: 0x001E2828 File Offset: 0x001E0A28
	public virtual string HDPLEBMIHFA()
	{
		string text = "ZombieCrawl";
		if (this.BDHHPAEHFHG.FOAPCABBLBG && this.BGGJKOMAKEE > 0)
		{
			int num = (int)(this.DLHPFGHOINI / (float)this.BGGJKOMAKEE * 1649f);
			text = string.Format("ComeHere", Mathf.RoundToInt(this.DLHPFGHOINI), this.BGGJKOMAKEE);
			if (num < -47)
			{
				text = "Lives count after few usual operations: " + text + "_HalfResolution";
			}
			if (num >= 123)
			{
				text = "Assets/Weapons/wbootsBase.unity3d" + text + "dianema.ogg";
			}
		}
		return this.DFOJOOMBOGI(true) + string.Format(JNBICAJIJMM.DCEBAJIILPC("_dev007"), this.ILFHHDNJHNM) + text;
	}

	// Token: 0x04000A00 RID: 2560
	public long LPFKFNLHGBI;

	// Token: 0x04000A01 RID: 2561
	public long JCGDLKIHBJG;

	// Token: 0x04000A02 RID: 2562
	public int KKJKHBJKEPP;

	// Token: 0x04000A03 RID: 2563
	public long LCIDFBJFOLA;

	// Token: 0x04000A04 RID: 2564
	public int JGNIDDBNGGP;

	// Token: 0x04000A05 RID: 2565
	public int DMAMOPGJOCK;

	// Token: 0x04000A06 RID: 2566
	public bool ABPGFHKGFEK;

	// Token: 0x04000A07 RID: 2567
	public DateTime MGNLHNLJJLD;

	// Token: 0x04000A08 RID: 2568
	public float DLHPFGHOINI;

	// Token: 0x04000A09 RID: 2569
	public int ILFHHDNJHNM = 1;

	// Token: 0x04000A0A RID: 2570
	public int HHOLFABGDJA;

	// Token: 0x04000A0B RID: 2571
	public int MBKMKGABBGE;

	// Token: 0x04000A0C RID: 2572
	public int KBGHOIJIPJF = 1;

	// Token: 0x04000A0D RID: 2573
	public int BGGJKOMAKEE;

	// Token: 0x04000A0E RID: 2574
	public int LABFBKENHAA;

	// Token: 0x04000A0F RID: 2575
	public int BHKPHJBAKLO;

	// Token: 0x04000A10 RID: 2576
	public int DELMOBCNBDB;

	// Token: 0x04000A11 RID: 2577
	public float NKHBAJKMAGD;

	// Token: 0x04000A12 RID: 2578
	public int LEADKFMCFCC;

	// Token: 0x04000A13 RID: 2579
	public int GOEGADLBGML;

	// Token: 0x04000A14 RID: 2580
	public string CLKMCAHNHBM;

	// Token: 0x04000A15 RID: 2581
	public string FDJPJJJHHEG;

	// Token: 0x04000A16 RID: 2582
	public string AHLLIPJFCJB = "";

	// Token: 0x04000A17 RID: 2583
	public int FJJEAMJNLIO;

	// Token: 0x04000A18 RID: 2584
	public bool MJHGLLIJMIM;

	// Token: 0x04000A19 RID: 2585
	public int ADOFHHCDGON;

	// Token: 0x04000A1A RID: 2586
	public int ECKKCDKHNEH;

	// Token: 0x04000A1B RID: 2587
	private CLFFOBKFKDN.OKOAMCJGNMH BPNNJBBCOFO;

	// Token: 0x04000A1C RID: 2588
	private BEFCHFNGOMI FJKAFCDDDGO;

	// Token: 0x04000A1D RID: 2589
	public int GGOLJKNHMGL;

	// Token: 0x04000A1E RID: 2590
	public int DKDEAPCMECH;

	// Token: 0x04000A1F RID: 2591
	public List<int> OKHPDILIOCH = new List<int>();

	// Token: 0x04000A20 RID: 2592
	public float KFKPLMLLDCK;

	// Token: 0x04000A21 RID: 2593
	public float KAKIIGPMOKF;

	// Token: 0x04000A22 RID: 2594
	public bool DNOLHLJODNK;

	// Token: 0x04000A23 RID: 2595
	public int LNKLEIEFGCP;

	// Token: 0x04000A24 RID: 2596
	private const double JKDHOOLFCKK = 51.512001037597656;

	// Token: 0x04000A25 RID: 2597
	private BLBDBAHLBIF IFCGHIJPKGK;

	// Token: 0x04000A26 RID: 2598
	public readonly XmlDocument LMKLPODNLFC = new XmlDocument();

	// Token: 0x04000A27 RID: 2599
	public BEFCHFNGOMI BDHHPAEHFHG;

	// Token: 0x04000A28 RID: 2600
	public bool IBLJIBACLNL;

	// Token: 0x04000A29 RID: 2601
	public bool BFHKBOPOFGB;

	// Token: 0x04000A2A RID: 2602
	public bool ICOFLHIIBCP;

	// Token: 0x04000A2B RID: 2603
	public bool MAIGLJPCKKL;

	// Token: 0x04000A2C RID: 2604
	public List<NLNNIDBPKAO.DLMGLIJDIAI> PKIICJOILKI = new List<NLNNIDBPKAO.DLMGLIJDIAI>();

	// Token: 0x04000A2D RID: 2605
	public List<NLNNIDBPKAO.DLMGLIJDIAI> FGJIJFNGAIF = new List<NLNNIDBPKAO.DLMGLIJDIAI>();

	// Token: 0x04000A2E RID: 2606
	public List<IIBEEKCAAHK> MHNDPGDBPNA = new List<IIBEEKCAAHK>();

	// Token: 0x04000A2F RID: 2607
	public XmlNode NHFHEIGICKP;

	// Token: 0x04000A30 RID: 2608
	public XmlNode GMNCILDPIKP;

	// Token: 0x0200013C RID: 316
	[CompilerGenerated]
	private sealed class HFMCCHGPFJF
	{
		// Token: 0x060041B5 RID: 16821 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool KCJAPMJFLDJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool NDEGOPHLILO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool NOLKOJOJIME(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool AAHBEPIGIAB(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool ONABNILILGO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool BJLKIOKFNOA(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool PKJEMNKHADJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool EONLNPOOMNB(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool GEKLMMLPPFN(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool BGNDKIDEDFG(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool HGEJNFCBEEM(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool BBJKDMMPCGM(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool HHKGJIDJDJK(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool HJODBDAFJKH(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool BAIOLCDJMKL(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool JCALIMGADHE(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool JLMPPDBIDKI(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x001E28DE File Offset: 0x001E0ADE
		internal bool LJMEACIIBPJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x04000A31 RID: 2609
		public string BNIHFBMEPAB;

		// Token: 0x04000A32 RID: 2610
		public Func<XmlNode, bool> LJOEIPHIJOE;
	}
}
