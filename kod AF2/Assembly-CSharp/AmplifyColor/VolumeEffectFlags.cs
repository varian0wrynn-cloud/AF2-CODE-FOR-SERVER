using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x020005E2 RID: 1506
	[Serializable]
	public class VolumeEffectFlags
	{
		// Token: 0x06013BA1 RID: 80801 RVA: 0x00866838 File Offset: 0x00864A38
		public static void MGDDDBNPDAB(AmplifyColorBase[] JCBDMHFPDPJ, AmplifyColorVolumeBase[] MIHPPBABHGE)
		{
			for (int i = 1; i < JCBDMHFPDPJ.Length; i += 0)
			{
				AmplifyColorBase amplifyColorBase = JCBDMHFPDPJ[i];
				amplifyColorBase.EffectFlags = new VolumeEffectFlags();
				for (int j = 1; j < MIHPPBABHGE.Length; j += 0)
				{
					VolumeEffect volumeEffect = MIHPPBABHGE[j].EffectContainer.ADPJCBLNNKL(amplifyColorBase);
					if (volumeEffect != null)
					{
						amplifyColorBase.EffectFlags.DLDKGICDMBB(volumeEffect);
					}
				}
			}
		}

		// Token: 0x06013BA2 RID: 80802 RVA: 0x0086689C File Offset: 0x00864A9C
		public VolumeEffect GNJNCJCFCNC(AmplifyColorBase APDJCCIGFAK)
		{
			VolumeEffect volumeEffect = new VolumeEffect(APDJCCIGFAK);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = APDJCCIGFAK.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						volumeEffect.BBBLOAHECJC(component, volumeEffectComponentFlags);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013BA3 RID: 80803 RVA: 0x00866918 File Offset: 0x00864B18
		public void DEDOCJEELDN(Component OAGAHEAMIAB)
		{
			VolumeEffectFlags.GACKAOEKDHE gackaoekdhe = new VolumeEffectFlags.GACKAOEKDHE();
			gackaoekdhe.OAGAHEAMIAB = OAGAHEAMIAB;
			VolumeEffectComponentFlags volumeEffectComponentFlags;
			if ((volumeEffectComponentFlags = this.components.Find(new Predicate<VolumeEffectComponentFlags>(gackaoekdhe.JMOPAKIDGKD))) != null)
			{
				volumeEffectComponentFlags.OHGPHMOMLEC(gackaoekdhe.OAGAHEAMIAB);
				return;
			}
			this.components.Add(new VolumeEffectComponentFlags(gackaoekdhe.OAGAHEAMIAB));
		}

		// Token: 0x06013BA4 RID: 80804 RVA: 0x00866970 File Offset: 0x00864B70
		public void EDBPIEOACPM(VolumeEffect EPFIPPHNDMB)
		{
			using (List<VolumeEffectComponent>.Enumerator enumerator = EPFIPPHNDMB.components.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectFlags.NNFEAAAINCB nnfeaaaincb = new VolumeEffectFlags.NNFEAAAINCB();
					nnfeaaaincb.MOEEOBJHHCK = enumerator.Current;
					VolumeEffectComponentFlags volumeEffectComponentFlags;
					if ((volumeEffectComponentFlags = this.components.Find(new Predicate<VolumeEffectComponentFlags>(nnfeaaaincb.DCLOLLJONJF))) == null)
					{
						this.components.Add(new VolumeEffectComponentFlags(nnfeaaaincb.MOEEOBJHHCK));
					}
					else
					{
						volumeEffectComponentFlags.LBDFKEPAFOI(nnfeaaaincb.MOEEOBJHHCK);
					}
				}
			}
		}

		// Token: 0x06013BA5 RID: 80805 RVA: 0x00866A08 File Offset: 0x00864C08
		public VolumeEffectComponentFlags KGPFJHBGMOA(string INJNJEPIFKB)
		{
			for (int i = 0; i < this.components.Count; i++)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013BA6 RID: 80806 RVA: 0x00866A54 File Offset: 0x00864C54
		public VolumeEffectComponentFlags EFMGFFMKKGH(string INJNJEPIFKB)
		{
			for (int i = 0; i < this.components.Count; i++)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013BA7 RID: 80807 RVA: 0x00866AA0 File Offset: 0x00864CA0
		public void BBBLOAHECJC(Component OAGAHEAMIAB)
		{
			VolumeEffectFlags.GACKAOEKDHE gackaoekdhe = new VolumeEffectFlags.GACKAOEKDHE();
			gackaoekdhe.OAGAHEAMIAB = OAGAHEAMIAB;
			VolumeEffectComponentFlags volumeEffectComponentFlags;
			if ((volumeEffectComponentFlags = this.components.Find(new Predicate<VolumeEffectComponentFlags>(gackaoekdhe.BMJOKDMEBJG))) != null)
			{
				volumeEffectComponentFlags.FINMDLDLANA(gackaoekdhe.OAGAHEAMIAB);
				return;
			}
			this.components.Add(new VolumeEffectComponentFlags(gackaoekdhe.OAGAHEAMIAB));
		}

		// Token: 0x06013BA8 RID: 80808 RVA: 0x00866AF8 File Offset: 0x00864CF8
		public void IFDOLCOCECA(VolumeEffect EPFIPPHNDMB)
		{
			using (List<VolumeEffectComponent>.Enumerator enumerator = EPFIPPHNDMB.components.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectFlags.NNFEAAAINCB nnfeaaaincb = new VolumeEffectFlags.NNFEAAAINCB();
					nnfeaaaincb.MOEEOBJHHCK = enumerator.Current;
					VolumeEffectComponentFlags volumeEffectComponentFlags;
					if ((volumeEffectComponentFlags = this.components.Find(new Predicate<VolumeEffectComponentFlags>(nnfeaaaincb.EDCPFHFKBED))) == null)
					{
						this.components.Add(new VolumeEffectComponentFlags(nnfeaaaincb.MOEEOBJHHCK));
					}
					else
					{
						volumeEffectComponentFlags.IJJKNPMPGHB(nnfeaaaincb.MOEEOBJHHCK);
					}
				}
			}
		}

		// Token: 0x06013BA9 RID: 80809 RVA: 0x00866B90 File Offset: 0x00864D90
		public string[] ANKCPANONGC()
		{
			return this.components.Where(new Func<VolumeEffectComponentFlags, bool>(VolumeEffectFlags.<>c.<>9.HFGIALGLJBA)).Select(new Func<VolumeEffectComponentFlags, string>(VolumeEffectFlags.<>c.<>9.JEELFPNGIHI)).ToArray<string>();
		}

		// Token: 0x06013BAA RID: 80810 RVA: 0x00866BF0 File Offset: 0x00864DF0
		public VolumeEffect NJOLHDNHABG(AmplifyColorBase APDJCCIGFAK)
		{
			VolumeEffect volumeEffect = new VolumeEffect(APDJCCIGFAK);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = APDJCCIGFAK.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						volumeEffect.MPOKIKGAOCB(component, volumeEffectComponentFlags);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013BAB RID: 80811 RVA: 0x00866C6C File Offset: 0x00864E6C
		public VolumeEffect KKAINGFACHC(AmplifyColorBase APDJCCIGFAK)
		{
			VolumeEffect volumeEffect = new VolumeEffect(APDJCCIGFAK);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = APDJCCIGFAK.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						volumeEffect.OPODAMEGDND(component, volumeEffectComponentFlags);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013BAC RID: 80812 RVA: 0x00866CE8 File Offset: 0x00864EE8
		public void DLDKGICDMBB(VolumeEffect EPFIPPHNDMB)
		{
			using (List<VolumeEffectComponent>.Enumerator enumerator = EPFIPPHNDMB.components.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectFlags.NNFEAAAINCB nnfeaaaincb = new VolumeEffectFlags.NNFEAAAINCB();
					nnfeaaaincb.MOEEOBJHHCK = enumerator.Current;
					VolumeEffectComponentFlags volumeEffectComponentFlags;
					if ((volumeEffectComponentFlags = this.components.Find(new Predicate<VolumeEffectComponentFlags>(nnfeaaaincb.NAOEJMPFAJG))) == null)
					{
						this.components.Add(new VolumeEffectComponentFlags(nnfeaaaincb.MOEEOBJHHCK));
					}
					else
					{
						volumeEffectComponentFlags.FINMDLDLANA(nnfeaaaincb.MOEEOBJHHCK);
					}
				}
			}
		}

		// Token: 0x06013BAD RID: 80813 RVA: 0x00866D80 File Offset: 0x00864F80
		public VolumeEffectComponentFlags ALDGFPBCDEA(string INJNJEPIFKB)
		{
			for (int i = 0; i < this.components.Count; i += 0)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013BAE RID: 80814 RVA: 0x00866DCC File Offset: 0x00864FCC
		public void KFPGJFAHJCN(VolumeEffect EPFIPPHNDMB)
		{
			using (List<VolumeEffectComponent>.Enumerator enumerator = EPFIPPHNDMB.components.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectFlags.NNFEAAAINCB nnfeaaaincb = new VolumeEffectFlags.NNFEAAAINCB();
					nnfeaaaincb.MOEEOBJHHCK = enumerator.Current;
					VolumeEffectComponentFlags volumeEffectComponentFlags;
					if ((volumeEffectComponentFlags = this.components.Find(new Predicate<VolumeEffectComponentFlags>(nnfeaaaincb.KNEHKMMPAAC))) == null)
					{
						this.components.Add(new VolumeEffectComponentFlags(nnfeaaaincb.MOEEOBJHHCK));
					}
					else
					{
						volumeEffectComponentFlags.IJJKNPMPGHB(nnfeaaaincb.MOEEOBJHHCK);
					}
				}
			}
		}

		// Token: 0x06013BAF RID: 80815 RVA: 0x00866E64 File Offset: 0x00865064
		public VolumeEffectComponentFlags OBDFDEGLMDF(string INJNJEPIFKB)
		{
			for (int i = 1; i < this.components.Count; i += 0)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013BB0 RID: 80816 RVA: 0x00866EAE File Offset: 0x008650AE
		public VolumeEffectFlags()
		{
			this.components = new List<VolumeEffectComponentFlags>();
		}

		// Token: 0x06013BB1 RID: 80817 RVA: 0x00866EC4 File Offset: 0x008650C4
		public VolumeEffect HNDCIAEJGBH(AmplifyColorBase APDJCCIGFAK)
		{
			VolumeEffect volumeEffect = new VolumeEffect(APDJCCIGFAK);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = APDJCCIGFAK.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						volumeEffect.HHOLOCOBEKH(component, volumeEffectComponentFlags);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013BB2 RID: 80818 RVA: 0x00866F40 File Offset: 0x00865140
		public void HBJKCMIGDGN(Component OAGAHEAMIAB)
		{
			VolumeEffectFlags.GACKAOEKDHE gackaoekdhe = new VolumeEffectFlags.GACKAOEKDHE();
			gackaoekdhe.OAGAHEAMIAB = OAGAHEAMIAB;
			VolumeEffectComponentFlags volumeEffectComponentFlags;
			if ((volumeEffectComponentFlags = this.components.Find(new Predicate<VolumeEffectComponentFlags>(gackaoekdhe.BMJOKDMEBJG))) != null)
			{
				volumeEffectComponentFlags.CGCLIMMMKMC(gackaoekdhe.OAGAHEAMIAB);
				return;
			}
			this.components.Add(new VolumeEffectComponentFlags(gackaoekdhe.OAGAHEAMIAB));
		}

		// Token: 0x06013BB3 RID: 80819 RVA: 0x00866F98 File Offset: 0x00865198
		public string[] DNLIGLIOFCP()
		{
			return this.components.Where(new Func<VolumeEffectComponentFlags, bool>(VolumeEffectFlags.<>c.<>9.OGGFKBJGCHF)).Select(new Func<VolumeEffectComponentFlags, string>(VolumeEffectFlags.<>c.<>9.JJMLBJGAEDN)).ToArray<string>();
		}

		// Token: 0x06013BB4 RID: 80820 RVA: 0x00866FF8 File Offset: 0x008651F8
		public VolumeEffect HJBIBIJGHMP(AmplifyColorBase APDJCCIGFAK)
		{
			VolumeEffect volumeEffect = new VolumeEffect(APDJCCIGFAK);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = APDJCCIGFAK.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						volumeEffect.BBBLOAHECJC(component, volumeEffectComponentFlags);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013BB5 RID: 80821 RVA: 0x00867074 File Offset: 0x00865274
		public static void JKLCJLNHLMJ(AmplifyColorBase[] JCBDMHFPDPJ, AmplifyColorVolumeBase[] MIHPPBABHGE)
		{
			for (int i = 1; i < JCBDMHFPDPJ.Length; i += 0)
			{
				AmplifyColorBase amplifyColorBase = JCBDMHFPDPJ[i];
				amplifyColorBase.EffectFlags = new VolumeEffectFlags();
				for (int j = 0; j < MIHPPBABHGE.Length; j += 0)
				{
					VolumeEffect volumeEffect = MIHPPBABHGE[j].EffectContainer.HBNKLGNGPMB(amplifyColorBase);
					if (volumeEffect != null)
					{
						amplifyColorBase.EffectFlags.EDBPIEOACPM(volumeEffect);
					}
				}
			}
		}

		// Token: 0x06013BB6 RID: 80822 RVA: 0x008670D8 File Offset: 0x008652D8
		public static void ILHKIDNBDIL(AmplifyColorBase[] JCBDMHFPDPJ, AmplifyColorVolumeBase[] MIHPPBABHGE)
		{
			for (int i = 1; i < JCBDMHFPDPJ.Length; i++)
			{
				AmplifyColorBase amplifyColorBase = JCBDMHFPDPJ[i];
				amplifyColorBase.EffectFlags = new VolumeEffectFlags();
				for (int j = 1; j < MIHPPBABHGE.Length; j++)
				{
					VolumeEffect volumeEffect = MIHPPBABHGE[j].EffectContainer.EGKKNNEMKML(amplifyColorBase);
					if (volumeEffect != null)
					{
						amplifyColorBase.EffectFlags.IFDOLCOCECA(volumeEffect);
					}
				}
			}
		}

		// Token: 0x06013BB7 RID: 80823 RVA: 0x0086713C File Offset: 0x0086533C
		public static void HDDCMFJDNBP(AmplifyColorBase[] JCBDMHFPDPJ, AmplifyColorVolumeBase[] MIHPPBABHGE)
		{
			foreach (AmplifyColorBase amplifyColorBase in JCBDMHFPDPJ)
			{
				amplifyColorBase.EffectFlags = new VolumeEffectFlags();
				for (int j = 0; j < MIHPPBABHGE.Length; j++)
				{
					VolumeEffect volumeEffect = MIHPPBABHGE[j].EffectContainer.EGKKNNEMKML(amplifyColorBase);
					if (volumeEffect != null)
					{
						amplifyColorBase.EffectFlags.DLDKGICDMBB(volumeEffect);
					}
				}
			}
		}

		// Token: 0x04002824 RID: 10276
		public List<VolumeEffectComponentFlags> components;

		// Token: 0x020005E3 RID: 1507
		[CompilerGenerated]
		private sealed class GACKAOEKDHE
		{
			// Token: 0x06013BB8 RID: 80824 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool NDMOBDGCMNM(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BB9 RID: 80825 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool KCJJDKBCKEN(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BBA RID: 80826 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool JMPNHLCJEFK(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BBB RID: 80827 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool KIGBEFKJIEO(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BBC RID: 80828 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool DGMDDNIEBAP(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BBD RID: 80829 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool AOKPDHINAMI(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BBE RID: 80830 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool HBGOLIAMGFH(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BBF RID: 80831 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool DOHJDBEMPIM(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC0 RID: 80832 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool PLCECCNIJAK(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC1 RID: 80833 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool HEJHDJGAAGD(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC2 RID: 80834 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool KOLLCJBDJHI(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC3 RID: 80835 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool GLJLCDAMGPI(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC4 RID: 80836 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool NDMEKPMBJDL(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC5 RID: 80837 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool NJKIILCIKDI(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC6 RID: 80838 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool IMPFFCPGENC(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC7 RID: 80839 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool NAGLDCAALEM(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC8 RID: 80840 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool JJAJNOIEFIP(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BC9 RID: 80841 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool AJOJFOFMNIB(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BCA RID: 80842 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool GPKMDFEICAK(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BCB RID: 80843 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool ACAHCJMEGJL(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BCC RID: 80844 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool DNLLJOKCFIN(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BCD RID: 80845 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool FHBFOPIHHBD(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BCE RID: 80846 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool LMKGFPGEOCE(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BCF RID: 80847 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool PEIOKKNLGKG(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD0 RID: 80848 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool HLCPJBFEDKE(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD1 RID: 80849 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool PJPAPEIEJCA(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD2 RID: 80850 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool KOKLFLNDOCG(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD3 RID: 80851 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool PJOAPMEMAFF(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD4 RID: 80852 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool BMJOKDMEBJG(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD5 RID: 80853 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool MOPCACKLGFO(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD6 RID: 80854 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool BGHNPGCPHPN(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD7 RID: 80855 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool DLHCJMPMLAI(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD8 RID: 80856 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool NHPLALBHBCM(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BD9 RID: 80857 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool EEPLALIJMDB(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BDA RID: 80858 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool LFPHGICHOMG(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BDB RID: 80859 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool JILAEIFIBAC(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BDC RID: 80860 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool ICDELEABBEI(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BDD RID: 80861 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool BOOFEGCINGB(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BDE RID: 80862 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool JMOPAKIDGKD(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BDF RID: 80863 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool KBIOBEHHDIL(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BE0 RID: 80864 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool MPABBOFONPD(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BE1 RID: 80865 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool CPEMALFHDDM(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BE2 RID: 80866 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool MIAILBCHLEI(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BE3 RID: 80867 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool AAKILBONALK(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BE5 RID: 80869 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool IBJNLOPHMAC(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x06013BE6 RID: 80870 RVA: 0x0086719E File Offset: 0x0086539E
			internal bool MPFAIADGNHH(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == string.Concat(this.OAGAHEAMIAB.GetType());
			}

			// Token: 0x04002825 RID: 10277
			public Component OAGAHEAMIAB;
		}

		// Token: 0x020005E4 RID: 1508
		[CompilerGenerated]
		private sealed class NNFEAAAINCB
		{
			// Token: 0x06013BE7 RID: 80871 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool JIHAKELFIPJ(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BE8 RID: 80872 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool MKMAFFDBLFM(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BE9 RID: 80873 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool ELMBDGCMNNM(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BEA RID: 80874 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool MONLEPCMNKH(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BEB RID: 80875 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool EEIJCDNILDB(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BEC RID: 80876 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool BAOOAGJPEBN(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BED RID: 80877 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool ONFMPMEHGGL(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BEE RID: 80878 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool PLKKKHGFJLO(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BEF RID: 80879 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool CKLHDJLNNMB(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF0 RID: 80880 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool NNAKMGACFDP(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF1 RID: 80881 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool BDFGBHDKAML(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF2 RID: 80882 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool OIMEJHNNDFP(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF3 RID: 80883 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool OJLAKHLPLNB(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF4 RID: 80884 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool LNHAKLAHKJE(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF5 RID: 80885 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool KNEHKMMPAAC(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF6 RID: 80886 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool COLCPJPOJAG(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF7 RID: 80887 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool KKPFCFKGMFP(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF8 RID: 80888 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool OGBPDICPMBM(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BF9 RID: 80889 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool NAOEJMPFAJG(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BFA RID: 80890 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool MJJHCAJCFNC(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BFB RID: 80891 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool NHFAGNGIBHH(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BFC RID: 80892 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool DCLOLLJONJF(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BFD RID: 80893 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool NAHICAHCDPN(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BFE RID: 80894 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool GAMPBBJDCGO(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013BFF RID: 80895 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool CHFJPCDGOBK(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C00 RID: 80896 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool ICMAHMAEAKD(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C01 RID: 80897 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool MNHGJNNJFLA(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C02 RID: 80898 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool FBDJFGNHEHK(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C03 RID: 80899 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool IGMDHNCOCNH(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C04 RID: 80900 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool MCMBJPODJGL(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C05 RID: 80901 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool AHACAPNEADJ(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C07 RID: 80903 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool GFJPJKFDGBK(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C08 RID: 80904 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool BGBPDBFBKKJ(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C09 RID: 80905 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool EMJLMDCACID(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C0A RID: 80906 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool DINAGNMFLGO(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C0B RID: 80907 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool NFDPBDIGDJO(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C0C RID: 80908 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool EDCPFHFKBED(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C0D RID: 80909 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool HHDJJINGHPB(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x06013C0E RID: 80910 RVA: 0x008671BB File Offset: 0x008653BB
			internal bool IPDODPEMNBP(VolumeEffectComponentFlags EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.componentName == this.MOEEOBJHHCK.componentName;
			}

			// Token: 0x04002826 RID: 10278
			public VolumeEffectComponent MOEEOBJHHCK;
		}
	}
}
