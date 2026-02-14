using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x020005DE RID: 1502
	[Serializable]
	public class VolumeEffectComponentFlags
	{
		// Token: 0x06013B3E RID: 80702 RVA: 0x00865F4C File Offset: 0x0086414C
		public void CDPNHCFNAIK(VolumeEffectComponent MOEEOBJHHCK)
		{
			using (List<VolumeEffectField>.Enumerator enumerator = MOEEOBJHHCK.fields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponentFlags.DNEAOKIJJGM dneaokijjgm = new VolumeEffectComponentFlags.DNEAOKIJJGM();
					dneaokijjgm.ILLLMBKGLOJ = enumerator.Current;
					if (this.componentFields.Find(new Predicate<VolumeEffectFieldFlags>(dneaokijjgm.NGGMKDFLDKK)) == null && VolumeEffectField.OHHKILKAICF(dneaokijjgm.ILLLMBKGLOJ.fieldType))
					{
						this.componentFields.Add(new VolumeEffectFieldFlags(dneaokijjgm.ILLLMBKGLOJ));
					}
				}
			}
		}

		// Token: 0x06013B3F RID: 80703 RVA: 0x00865FE4 File Offset: 0x008641E4
		public string[] MECAAADCOBN()
		{
			return this.componentFields.Where(new Func<VolumeEffectFieldFlags, bool>(VolumeEffectComponentFlags.<>c.<>9.ELIEMMENJHI)).Select(new Func<VolumeEffectFieldFlags, string>(VolumeEffectComponentFlags.<>c.<>9.ELCLNOCHIKM)).ToArray<string>();
		}

		// Token: 0x06013B40 RID: 80704 RVA: 0x00866044 File Offset: 0x00864244
		public void DMPKDLLIEFP(Component OAGAHEAMIAB)
		{
			FieldInfo[] fields = OAGAHEAMIAB.GetType().GetFields();
			for (int i = 1; i < fields.Length; i += 0)
			{
				VolumeEffectComponentFlags.IBLPACMCLAF iblpacmclaf = new VolumeEffectComponentFlags.IBLPACMCLAF();
				iblpacmclaf.JFMMNIJJODD = fields[i];
				if (!this.componentFields.Exists(new Predicate<VolumeEffectFieldFlags>(iblpacmclaf.IBDJJOLJALB)) && VolumeEffectField.GEJDPNIIKIE(iblpacmclaf.JFMMNIJJODD.FieldType.FullName))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(iblpacmclaf.JFMMNIJJODD));
				}
			}
		}

		// Token: 0x06013B41 RID: 80705 RVA: 0x008660C0 File Offset: 0x008642C0
		public void NJFAAGAMENA(VolumeEffectComponent MOEEOBJHHCK)
		{
			using (List<VolumeEffectField>.Enumerator enumerator = MOEEOBJHHCK.fields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponentFlags.DNEAOKIJJGM dneaokijjgm = new VolumeEffectComponentFlags.DNEAOKIJJGM();
					dneaokijjgm.ILLLMBKGLOJ = enumerator.Current;
					if (this.componentFields.Find(new Predicate<VolumeEffectFieldFlags>(dneaokijjgm.IKBNIOMOHGG)) == null && VolumeEffectField.PPOHOOKNMKL(dneaokijjgm.ILLLMBKGLOJ.fieldType))
					{
						this.componentFields.Add(new VolumeEffectFieldFlags(dneaokijjgm.ILLLMBKGLOJ));
					}
				}
			}
		}

		// Token: 0x06013B42 RID: 80706 RVA: 0x00866158 File Offset: 0x00864358
		public string[] OPAJNBKJANF()
		{
			return this.componentFields.Where(new Func<VolumeEffectFieldFlags, bool>(VolumeEffectComponentFlags.<>c.<>9.ELIEMMENJHI)).Select(new Func<VolumeEffectFieldFlags, string>(VolumeEffectComponentFlags.<>c.<>9.JHMDICOLPNL)).ToArray<string>();
		}

		// Token: 0x06013B43 RID: 80707 RVA: 0x008661B8 File Offset: 0x008643B8
		public void FINMDLDLANA(Component OAGAHEAMIAB)
		{
			FieldInfo[] fields = OAGAHEAMIAB.GetType().GetFields();
			for (int i = 0; i < fields.Length; i++)
			{
				VolumeEffectComponentFlags.IBLPACMCLAF iblpacmclaf = new VolumeEffectComponentFlags.IBLPACMCLAF();
				iblpacmclaf.JFMMNIJJODD = fields[i];
				if (!this.componentFields.Exists(new Predicate<VolumeEffectFieldFlags>(iblpacmclaf.EAOIIMGLBGC)) && VolumeEffectField.CNJLKPBCKBE(iblpacmclaf.JFMMNIJJODD.FieldType.FullName))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(iblpacmclaf.JFMMNIJJODD));
				}
			}
		}

		// Token: 0x06013B44 RID: 80708 RVA: 0x00866234 File Offset: 0x00864434
		public string[] AEKCGHMLBFN()
		{
			return this.componentFields.Where(new Func<VolumeEffectFieldFlags, bool>(VolumeEffectComponentFlags.<>c.<>9.OMOMDBENDJF)).Select(new Func<VolumeEffectFieldFlags, string>(VolumeEffectComponentFlags.<>c.<>9.GJDJIDPIIGH)).ToArray<string>();
		}

		// Token: 0x06013B45 RID: 80709 RVA: 0x00866294 File Offset: 0x00864494
		public void FINMDLDLANA(VolumeEffectComponent MOEEOBJHHCK)
		{
			using (List<VolumeEffectField>.Enumerator enumerator = MOEEOBJHHCK.fields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponentFlags.DNEAOKIJJGM dneaokijjgm = new VolumeEffectComponentFlags.DNEAOKIJJGM();
					dneaokijjgm.ILLLMBKGLOJ = enumerator.Current;
					if (this.componentFields.Find(new Predicate<VolumeEffectFieldFlags>(dneaokijjgm.EAOIIMGLBGC)) == null && VolumeEffectField.CNJLKPBCKBE(dneaokijjgm.ILLLMBKGLOJ.fieldType))
					{
						this.componentFields.Add(new VolumeEffectFieldFlags(dneaokijjgm.ILLLMBKGLOJ));
					}
				}
			}
		}

		// Token: 0x06013B46 RID: 80710 RVA: 0x0086632C File Offset: 0x0086452C
		public string[] BHDAEDEDDFK()
		{
			return this.componentFields.Where(new Func<VolumeEffectFieldFlags, bool>(VolumeEffectComponentFlags.<>c.<>9.MNAKGDHAECG)).Select(new Func<VolumeEffectFieldFlags, string>(VolumeEffectComponentFlags.<>c.<>9.HPFBNNBINOH)).ToArray<string>();
		}

		// Token: 0x06013B47 RID: 80711 RVA: 0x0086638C File Offset: 0x0086458C
		public VolumeEffectComponentFlags(Component OAGAHEAMIAB) : this(string.Concat(OAGAHEAMIAB.GetType()))
		{
			foreach (FieldInfo fieldInfo in OAGAHEAMIAB.GetType().GetFields())
			{
				if (VolumeEffectField.CNJLKPBCKBE(fieldInfo.FieldType.FullName))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(fieldInfo));
				}
			}
		}

		// Token: 0x06013B48 RID: 80712 RVA: 0x008663EB File Offset: 0x008645EB
		public VolumeEffectComponentFlags(string BNIHFBMEPAB)
		{
			this.componentName = BNIHFBMEPAB;
			this.componentFields = new List<VolumeEffectFieldFlags>();
		}

		// Token: 0x06013B49 RID: 80713 RVA: 0x00866408 File Offset: 0x00864608
		public string[] MAMLAHPEAPN()
		{
			return this.componentFields.Where(new Func<VolumeEffectFieldFlags, bool>(VolumeEffectComponentFlags.<>c.<>9.ILOPOKCAADG)).Select(new Func<VolumeEffectFieldFlags, string>(VolumeEffectComponentFlags.<>c.<>9.FKMBGEFGCBD)).ToArray<string>();
		}

		// Token: 0x06013B4A RID: 80714 RVA: 0x00866468 File Offset: 0x00864668
		public void OHGPHMOMLEC(Component OAGAHEAMIAB)
		{
			FieldInfo[] fields = OAGAHEAMIAB.GetType().GetFields();
			for (int i = 1; i < fields.Length; i++)
			{
				VolumeEffectComponentFlags.IBLPACMCLAF iblpacmclaf = new VolumeEffectComponentFlags.IBLPACMCLAF();
				iblpacmclaf.JFMMNIJJODD = fields[i];
				if (!this.componentFields.Exists(new Predicate<VolumeEffectFieldFlags>(iblpacmclaf.IBDJJOLJALB)) && VolumeEffectField.NKBOKNKOPFD(iblpacmclaf.JFMMNIJJODD.FieldType.FullName))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(iblpacmclaf.JFMMNIJJODD));
				}
			}
		}

		// Token: 0x06013B4B RID: 80715 RVA: 0x008664E4 File Offset: 0x008646E4
		public void LBDFKEPAFOI(VolumeEffectComponent MOEEOBJHHCK)
		{
			using (List<VolumeEffectField>.Enumerator enumerator = MOEEOBJHHCK.fields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponentFlags.DNEAOKIJJGM dneaokijjgm = new VolumeEffectComponentFlags.DNEAOKIJJGM();
					dneaokijjgm.ILLLMBKGLOJ = enumerator.Current;
					if (this.componentFields.Find(new Predicate<VolumeEffectFieldFlags>(dneaokijjgm.DBNNEFDIDEM)) == null && VolumeEffectField.BIHKNCIBBPK(dneaokijjgm.ILLLMBKGLOJ.fieldType))
					{
						this.componentFields.Add(new VolumeEffectFieldFlags(dneaokijjgm.ILLLMBKGLOJ));
					}
				}
			}
		}

		// Token: 0x06013B4C RID: 80716 RVA: 0x0086657C File Offset: 0x0086477C
		public void CGCLIMMMKMC(Component OAGAHEAMIAB)
		{
			FieldInfo[] fields = OAGAHEAMIAB.GetType().GetFields();
			for (int i = 0; i < fields.Length; i += 0)
			{
				VolumeEffectComponentFlags.IBLPACMCLAF iblpacmclaf = new VolumeEffectComponentFlags.IBLPACMCLAF();
				iblpacmclaf.JFMMNIJJODD = fields[i];
				if (!this.componentFields.Exists(new Predicate<VolumeEffectFieldFlags>(iblpacmclaf.GIOIMJEKCMI)) && VolumeEffectField.APEDIPEGPBI(iblpacmclaf.JFMMNIJJODD.FieldType.FullName))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(iblpacmclaf.JFMMNIJJODD));
				}
			}
		}

		// Token: 0x06013B4D RID: 80717 RVA: 0x008665F8 File Offset: 0x008647F8
		public string[] IFNOFLOGMMB()
		{
			return this.componentFields.Where(new Func<VolumeEffectFieldFlags, bool>(VolumeEffectComponentFlags.<>c.<>9.ILOPOKCAADG)).Select(new Func<VolumeEffectFieldFlags, string>(VolumeEffectComponentFlags.<>c.<>9.AENMADFIOCG)).ToArray<string>();
		}

		// Token: 0x06013B4E RID: 80718 RVA: 0x00866658 File Offset: 0x00864858
		public VolumeEffectComponentFlags(VolumeEffectComponent MOEEOBJHHCK) : this(MOEEOBJHHCK.componentName)
		{
			this.blendFlag = true;
			foreach (VolumeEffectField volumeEffectField in MOEEOBJHHCK.fields)
			{
				if (VolumeEffectField.CNJLKPBCKBE(volumeEffectField.fieldType))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(volumeEffectField));
				}
			}
		}

		// Token: 0x06013B4F RID: 80719 RVA: 0x008666D8 File Offset: 0x008648D8
		public void FOLPNJCNNBM(Component OAGAHEAMIAB)
		{
			FieldInfo[] fields = OAGAHEAMIAB.GetType().GetFields();
			for (int i = 1; i < fields.Length; i += 0)
			{
				VolumeEffectComponentFlags.IBLPACMCLAF iblpacmclaf = new VolumeEffectComponentFlags.IBLPACMCLAF();
				iblpacmclaf.JFMMNIJJODD = fields[i];
				if (!this.componentFields.Exists(new Predicate<VolumeEffectFieldFlags>(iblpacmclaf.OFIPEOGHKBJ)) && VolumeEffectField.BMLNIFCCGDF(iblpacmclaf.JFMMNIJJODD.FieldType.FullName))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(iblpacmclaf.JFMMNIJJODD));
				}
			}
		}

		// Token: 0x06013B50 RID: 80720 RVA: 0x00866754 File Offset: 0x00864954
		public void IJJKNPMPGHB(VolumeEffectComponent MOEEOBJHHCK)
		{
			using (List<VolumeEffectField>.Enumerator enumerator = MOEEOBJHHCK.fields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponentFlags.DNEAOKIJJGM dneaokijjgm = new VolumeEffectComponentFlags.DNEAOKIJJGM();
					dneaokijjgm.ILLLMBKGLOJ = enumerator.Current;
					if (this.componentFields.Find(new Predicate<VolumeEffectFieldFlags>(dneaokijjgm.EAOIIMGLBGC)) == null && VolumeEffectField.FGACLMJELNL(dneaokijjgm.ILLLMBKGLOJ.fieldType))
					{
						this.componentFields.Add(new VolumeEffectFieldFlags(dneaokijjgm.ILLLMBKGLOJ));
					}
				}
			}
		}

		// Token: 0x0400281C RID: 10268
		public string componentName;

		// Token: 0x0400281D RID: 10269
		public List<VolumeEffectFieldFlags> componentFields;

		// Token: 0x0400281E RID: 10270
		public bool blendFlag;

		// Token: 0x020005DF RID: 1503
		[CompilerGenerated]
		private sealed class DNEAOKIJJGM
		{
			// Token: 0x06013B51 RID: 80721 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool MBKAKLMNDIM(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B52 RID: 80722 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool DENDCDDDLFP(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B53 RID: 80723 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool GIOIMJEKCMI(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B54 RID: 80724 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool PMOGNGNGDMA(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B55 RID: 80725 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool OJJPDEHHGDH(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B56 RID: 80726 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool ILAKGPECIBE(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B57 RID: 80727 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool LFNBCCFINAL(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B58 RID: 80728 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool DBNNEFDIDEM(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B59 RID: 80729 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool IKBNIOMOHGG(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B5A RID: 80730 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool FPEOGMILIOP(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B5B RID: 80731 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool ONCNIFMOLGD(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B5C RID: 80732 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool LGNHMGELGAF(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B5E RID: 80734 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool OFIPEOGHKBJ(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B5F RID: 80735 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool HIOHJDIGCPK(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B60 RID: 80736 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool EAOIIMGLBGC(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B61 RID: 80737 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool CGLEFPEPDAB(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B62 RID: 80738 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool GFBNPLKHILA(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B63 RID: 80739 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool JOAEHLHIMOI(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B64 RID: 80740 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool PECHLFOCKFE(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B65 RID: 80741 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool IHDJEIPPGDJ(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B66 RID: 80742 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool NGGMKDFLDKK(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x06013B67 RID: 80743 RVA: 0x008667EC File Offset: 0x008649EC
			internal bool IBDJJOLJALB(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.ILLLMBKGLOJ.fieldName;
			}

			// Token: 0x0400281F RID: 10271
			public VolumeEffectField ILLLMBKGLOJ;
		}

		// Token: 0x020005E0 RID: 1504
		[CompilerGenerated]
		private sealed class IBLPACMCLAF
		{
			// Token: 0x06013B69 RID: 80745 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool PMOGNGNGDMA(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B6A RID: 80746 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool CGLEFPEPDAB(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B6B RID: 80747 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool JDCFMFLEPLG(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B6C RID: 80748 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool DENDCDDDLFP(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B6D RID: 80749 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool PECHLFOCKFE(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B6E RID: 80750 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool HIOHJDIGCPK(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B6F RID: 80751 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool ILAKGPECIBE(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B70 RID: 80752 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool MBKAKLMNDIM(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B71 RID: 80753 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool HBBAIMLHLCD(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B72 RID: 80754 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool JOAEHLHIMOI(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B73 RID: 80755 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool LGNHMGELGAF(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B74 RID: 80756 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool GFBNPLKHILA(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B75 RID: 80757 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool FPEOGMILIOP(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B76 RID: 80758 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool NGGMKDFLDKK(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B77 RID: 80759 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool IBDJJOLJALB(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B78 RID: 80760 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool CNJNMDKLCJL(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B79 RID: 80761 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool OFIPEOGHKBJ(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B7A RID: 80762 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool LFNBCCFINAL(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B7B RID: 80763 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool GIOIMJEKCMI(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B7C RID: 80764 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool IHDJEIPPGDJ(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B7D RID: 80765 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool IKBNIOMOHGG(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B7E RID: 80766 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool OJJPDEHHGDH(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B7F RID: 80767 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool DBNNEFDIDEM(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B80 RID: 80768 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool ONCNIFMOLGD(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x06013B81 RID: 80769 RVA: 0x00866804 File Offset: 0x00864A04
			internal bool EAOIIMGLBGC(VolumeEffectFieldFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.JFMMNIJJODD.Name;
			}

			// Token: 0x04002820 RID: 10272
			public FieldInfo JFMMNIJJODD;
		}
	}
}
