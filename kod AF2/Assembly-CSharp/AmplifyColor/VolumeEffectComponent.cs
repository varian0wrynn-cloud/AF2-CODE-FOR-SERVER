using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x020005D6 RID: 1494
	[Serializable]
	public class VolumeEffectComponent
	{
		// Token: 0x0601393A RID: 80186 RVA: 0x0085C050 File Offset: 0x0085A250
		public VolumeEffectField AMBBNKINALO(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x0601393B RID: 80187 RVA: 0x0085C09A File Offset: 0x0085A29A
		public string[] AGOOOFMBLEC()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.CMMGIABGPAI)).ToArray<string>();
		}

		// Token: 0x0601393C RID: 80188 RVA: 0x0085C0CC File Offset: 0x0085A2CC
		public VolumeEffectField BBGCJCFMIHI(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.JAPKIAAFHEB(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601393D RID: 80189 RVA: 0x0085C128 File Offset: 0x0085A328
		public void MPFNOFHEMBM(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.GMHFLODGLOD)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.KMLHFOLPPAL(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601393E RID: 80190 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void AANMPINADBD(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x0601393F RID: 80191 RVA: 0x0085C1FC File Offset: 0x0085A3FC
		public static FieldInfo[] CGEFFCNGLJB(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.BPKIHNLINMF)).ToArray<FieldInfo>();
		}

		// Token: 0x06013940 RID: 80192 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void MFEMIIKJDHH(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x06013941 RID: 80193 RVA: 0x0085C250 File Offset: 0x0085A450
		public VolumeEffectField PICBGFLPAHP(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013942 RID: 80194 RVA: 0x0085C29C File Offset: 0x0085A49C
		public VolumeEffectField JNHLFFJGHNF(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013943 RID: 80195 RVA: 0x0085C2E8 File Offset: 0x0085A4E8
		public static FieldInfo[] IPICBFEMFLK(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[1];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.IIOKENNLKDJ)).ToArray<FieldInfo>();
		}

		// Token: 0x06013944 RID: 80196 RVA: 0x0085C339 File Offset: 0x0085A539
		public string[] FOADOIBDMCO()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.CJMJAMCPCMJ)).ToArray<string>();
		}

		// Token: 0x06013945 RID: 80197 RVA: 0x0085C36C File Offset: 0x0085A56C
		public static FieldInfo[] HFDDAJKECOJ(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.AMGJMECDEGJ)).ToArray<FieldInfo>();
		}

		// Token: 0x06013946 RID: 80198 RVA: 0x0085C3BD File Offset: 0x0085A5BD
		public string[] LHCDMIPKHMH()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.OKNOPONDHGJ)).ToArray<string>();
		}

		// Token: 0x06013947 RID: 80199 RVA: 0x0085C3F0 File Offset: 0x0085A5F0
		public static FieldInfo[] EGPMKCBDICJ(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.BPKIHNLINMF)).ToArray<FieldInfo>();
		}

		// Token: 0x06013948 RID: 80200 RVA: 0x0085C444 File Offset: 0x0085A644
		public void BGKHOBNDJOI(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.ILIGNCGHMOK)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.GNFMNLBLACP(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013949 RID: 80201 RVA: 0x0085C508 File Offset: 0x0085A708
		public void CIMCHDCGMHH(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.GMHFLODGLOD)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.JIFBKMNIHFP(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601394A RID: 80202 RVA: 0x0085C5CC File Offset: 0x0085A7CC
		public void DFOEJJCDFIK(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.CCOKFKBLBDH)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.GLEPEDDNMKC(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601394B RID: 80203 RVA: 0x0085C690 File Offset: 0x0085A890
		public string[] EAABPKAINNF()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.BOPNLJPJLFK)).ToArray<string>();
		}

		// Token: 0x0601394C RID: 80204 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void CBABAKGIPIB(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x0601394D RID: 80205 RVA: 0x0085C6C4 File Offset: 0x0085A8C4
		public void BECIPJDGBEC(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.BOGOBMDOJOP)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.OMPKBOGAHOK(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601394E RID: 80206 RVA: 0x0085C788 File Offset: 0x0085A988
		public VolumeEffectField HLOGEMIPDBB(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x0601394F RID: 80207 RVA: 0x0085C7D4 File Offset: 0x0085A9D4
		public VolumeEffectField ICEIDEAADLO(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.FJHFAENOJBD(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 0 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x06013950 RID: 80208 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void HDOEJJDDAEA(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x06013951 RID: 80209 RVA: 0x0085C830 File Offset: 0x0085AA30
		public VolumeEffectField HLKLONJMLJL(string OHPEHLMFMHK)
		{
			for (int i = 1; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013952 RID: 80210 RVA: 0x0085C87C File Offset: 0x0085AA7C
		public VolumeEffectField BBCBIJAEGKN(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013953 RID: 80211 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void MEMFHPOEHAH(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x06013954 RID: 80212 RVA: 0x0085C8C8 File Offset: 0x0085AAC8
		public static FieldInfo[] FNBCBJPGAII(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.HNELGPCDHIP)).ToArray<FieldInfo>();
		}

		// Token: 0x06013955 RID: 80213 RVA: 0x0085C91C File Offset: 0x0085AB1C
		public void CFHOLDBLCEE(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.KOECDJPHHOI)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.ANBJBENOHPD(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013956 RID: 80214 RVA: 0x0085C9E0 File Offset: 0x0085ABE0
		public static FieldInfo[] GMJMBPBINJC(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.CJIKINLJEHD)).ToArray<FieldInfo>();
		}

		// Token: 0x06013957 RID: 80215 RVA: 0x0085CA31 File Offset: 0x0085AC31
		public string[] MAMLAHPEAPN()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.GPPODEGMDIF)).ToArray<string>();
		}

		// Token: 0x06013958 RID: 80216 RVA: 0x0085CA64 File Offset: 0x0085AC64
		public VolumeEffectField KMJOHAGHOBE(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.KPDFDAGBDKF(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x06013959 RID: 80217 RVA: 0x0085CAC0 File Offset: 0x0085ACC0
		public VolumeEffectField BPCIHGIABCK(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.CLOAAMIOGHM(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601395A RID: 80218 RVA: 0x0085CB1C File Offset: 0x0085AD1C
		public VolumeEffectField OONPGNDKCLD(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.JIFBKMNIHFP(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601395B RID: 80219 RVA: 0x0085CB78 File Offset: 0x0085AD78
		public VolumeEffectField CPIALOPOIMC(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.FCCBCEIPMNE(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 0 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601395C RID: 80220 RVA: 0x0085CBD4 File Offset: 0x0085ADD4
		public static FieldInfo[] EPDDHJEMCMN(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.BDHHANCKLOF)).ToArray<FieldInfo>();
		}

		// Token: 0x0601395D RID: 80221 RVA: 0x0085CC28 File Offset: 0x0085AE28
		public void PALKCHAMFLE(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.HNEEJJJNCNM)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.CNJLKPBCKBE(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601395E RID: 80222 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void ECIBGKMLIKG(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x0601395F RID: 80223 RVA: 0x0085CCEC File Offset: 0x0085AEEC
		public void NFNIAAHFGNN(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.KAPBACHINOA)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.CLOAAMIOGHM(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013960 RID: 80224 RVA: 0x0085CDB0 File Offset: 0x0085AFB0
		public void KHENDOIAHLP(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.EFLCGKFILCE)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.OHHKILKAICF(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013961 RID: 80225 RVA: 0x0085CE74 File Offset: 0x0085B074
		public void JBEGMKAPBGA(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.GOMLGHFGPEC)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.BMLNIFCCGDF(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013962 RID: 80226 RVA: 0x0085CF38 File Offset: 0x0085B138
		public VolumeEffectField OMLBKFJIBLN(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.BIHKNCIBBPK(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x06013963 RID: 80227 RVA: 0x0085CF94 File Offset: 0x0085B194
		public static FieldInfo[] MPNELDDFEOF(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.GFDANFECBII)).ToArray<FieldInfo>();
		}

		// Token: 0x06013964 RID: 80228 RVA: 0x0085CFE5 File Offset: 0x0085B1E5
		public VolumeEffectField PAABALAEBJO(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.OMLBKFJIBLN(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013965 RID: 80229 RVA: 0x0085CFF0 File Offset: 0x0085B1F0
		public VolumeEffectField FLMFGBNJCAO(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.KPDFDAGBDKF(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 0 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x06013966 RID: 80230 RVA: 0x0085D04C File Offset: 0x0085B24C
		public VolumeEffectField NLGOKBCGMBI(string OHPEHLMFMHK)
		{
			for (int i = 1; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013967 RID: 80231 RVA: 0x0085D098 File Offset: 0x0085B298
		public void CPKDHGBHGKH(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.GKGEDAGBLKD)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.CLOAAMIOGHM(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013968 RID: 80232 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void AHAGIGEPPLH(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x06013969 RID: 80233 RVA: 0x0085D15C File Offset: 0x0085B35C
		public VolumeEffectField FCIMLBKKNMM(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.DKOFAJHIOHA(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x0601396A RID: 80234 RVA: 0x0085D167 File Offset: 0x0085B367
		public string[] FMBFMOLFNIK()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.LLBFDDCEDAP)).ToArray<string>();
		}

		// Token: 0x0601396B RID: 80235 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void AIIACENLDMC(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x0601396C RID: 80236 RVA: 0x0085D198 File Offset: 0x0085B398
		public VolumeEffectField LHIBCDKMPED(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x0601396D RID: 80237 RVA: 0x0085D1E4 File Offset: 0x0085B3E4
		public VolumeEffectField NBMPGJELFCA(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.JIFBKMNIHFP(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 0 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601396E RID: 80238 RVA: 0x0085D240 File Offset: 0x0085B440
		public void KIIBHOLEECM(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.NHFKBFCFDJL)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.CLOAAMIOGHM(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601396F RID: 80239 RVA: 0x0085C09A File Offset: 0x0085A29A
		public string[] KJPIDAMPHAC()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.CMMGIABGPAI)).ToArray<string>();
		}

		// Token: 0x06013970 RID: 80240 RVA: 0x0085D304 File Offset: 0x0085B504
		public static FieldInfo[] IMHOHHODMEN(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.FDMFHFKFJOP)).ToArray<FieldInfo>();
		}

		// Token: 0x06013971 RID: 80241 RVA: 0x0085D355 File Offset: 0x0085B555
		public VolumeEffectField IOFBOHHBLNK(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.BBGCJCFMIHI(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013972 RID: 80242 RVA: 0x0085CA31 File Offset: 0x0085AC31
		public string[] HNCAJGJLHIG()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.GPPODEGMDIF)).ToArray<string>();
		}

		// Token: 0x06013973 RID: 80243 RVA: 0x0085D360 File Offset: 0x0085B560
		public VolumeEffectField FAFNBLILLCI(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.FDCEIKENDOF(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013974 RID: 80244 RVA: 0x0085D36B File Offset: 0x0085B56B
		public string[] JHIAKIPEOKF()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.POJCLCJHHIE)).ToArray<string>();
		}

		// Token: 0x06013975 RID: 80245 RVA: 0x0085D39C File Offset: 0x0085B59C
		public void LODMFEMHBBB(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.DEFFKKHIOKE)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.FCCBCEIPMNE(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013976 RID: 80246 RVA: 0x0085D15C File Offset: 0x0085B35C
		public VolumeEffectField PFDEKAHPJCG(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.DKOFAJHIOHA(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013977 RID: 80247 RVA: 0x0085D460 File Offset: 0x0085B660
		public static FieldInfo[] LJAMMGFLAID(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[1];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.KGCONLPCPCI)).ToArray<FieldInfo>();
		}

		// Token: 0x06013978 RID: 80248 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void LCNKMFHNMAN(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x06013979 RID: 80249 RVA: 0x0085D4B4 File Offset: 0x0085B6B4
		public void MDHJGGDGJBK(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.PMBNBEIOJBM)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.FJHFAENOJBD(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601397A RID: 80250 RVA: 0x0085D578 File Offset: 0x0085B778
		public void ADMFLBMNFCB(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.BJDBGCGGHNK)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.GNFMNLBLACP(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601397B RID: 80251 RVA: 0x0085D63C File Offset: 0x0085B83C
		public VolumeEffectField HODAOIDEAGL(string OHPEHLMFMHK)
		{
			for (int i = 1; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x0601397C RID: 80252 RVA: 0x0085D688 File Offset: 0x0085B888
		public static FieldInfo[] NCCGFILLBDH(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.OCBPOCLEOLO)).ToArray<FieldInfo>();
		}

		// Token: 0x0601397D RID: 80253 RVA: 0x0085D6D9 File Offset: 0x0085B8D9
		public VolumeEffectComponent(string BNIHFBMEPAB)
		{
			this.componentName = BNIHFBMEPAB;
			this.fields = new List<VolumeEffectField>();
		}

		// Token: 0x0601397E RID: 80254 RVA: 0x0085D6F4 File Offset: 0x0085B8F4
		public VolumeEffectField FGOPHDAFBHN(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.GEJDPNIIKIE(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601397F RID: 80255 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void AEGIJIDFKEE(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x06013980 RID: 80256 RVA: 0x0085D74F File Offset: 0x0085B94F
		public VolumeEffectField LEICGCPJICC(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.BGPELBHCOMD(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013981 RID: 80257 RVA: 0x0085D75C File Offset: 0x0085B95C
		public static FieldInfo[] IEMJIAFOIGI(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[1];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.OOCCGHDKKHK)).ToArray<FieldInfo>();
		}

		// Token: 0x06013982 RID: 80258 RVA: 0x0085D7B0 File Offset: 0x0085B9B0
		public void FHEJOBGNHOH(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.DKFGOKLGJPI)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.BMLNIFCCGDF(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013983 RID: 80259 RVA: 0x0085D874 File Offset: 0x0085BA74
		public static FieldInfo[] NOFHKNHELPO(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[1];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.BIPJCNLHBEB)).ToArray<FieldInfo>();
		}

		// Token: 0x06013984 RID: 80260 RVA: 0x0085D8C8 File Offset: 0x0085BAC8
		public VolumeEffectField BGPELBHCOMD(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.KMLHFOLPPAL(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x06013985 RID: 80261 RVA: 0x0085D924 File Offset: 0x0085BB24
		public void PEHMFJBGNLP(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.CJEBCPHILBO)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.OLABKGLJJEK(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013986 RID: 80262 RVA: 0x0085D9E8 File Offset: 0x0085BBE8
		public void AGLDEGGJIFN(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.BLMKKKMAFKH)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.HHGFMAIENOH(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013987 RID: 80263 RVA: 0x0085DAAC File Offset: 0x0085BCAC
		public VolumeEffectField EBCDLADEEKO(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.KCNNBDBGNCE(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x06013988 RID: 80264 RVA: 0x0085DB07 File Offset: 0x0085BD07
		public VolumeEffectField AJOHLLGFJOA(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.CNOIJJNKPHP(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013989 RID: 80265 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void HGBAACBBNGH(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x0601398A RID: 80266 RVA: 0x0085DB14 File Offset: 0x0085BD14
		public VolumeEffectField KPCFAKIBBAO(string OHPEHLMFMHK)
		{
			for (int i = 1; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x0601398B RID: 80267 RVA: 0x0085DB60 File Offset: 0x0085BD60
		public void CENDGENKMCH(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.AELFDIFIINE)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.HFBKFKFPFKC(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601398C RID: 80268 RVA: 0x0085DC24 File Offset: 0x0085BE24
		public VolumeEffectComponent(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE) : this(LCNOOKMLHKE.componentName)
		{
			foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in LCNOOKMLHKE.componentFields)
			{
				if (volumeEffectFieldFlags.blendFlag)
				{
					FieldInfo field = OAGAHEAMIAB.GetType().GetField(volumeEffectFieldFlags.fieldName);
					VolumeEffectField volumeEffectField = VolumeEffectField.CNJLKPBCKBE(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
					if (volumeEffectField != null)
					{
						this.fields.Add(volumeEffectField);
					}
				}
			}
		}

		// Token: 0x0601398D RID: 80269 RVA: 0x0085DCC4 File Offset: 0x0085BEC4
		public VolumeEffectField OKCFDIONNJF(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.GNFMNLBLACP(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 0 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601398E RID: 80270 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void MEBNHGDBIAF(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x0601398F RID: 80271 RVA: 0x0085DD20 File Offset: 0x0085BF20
		public VolumeEffectField CKBKFDDOMFB(string OHPEHLMFMHK)
		{
			for (int i = 1; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013990 RID: 80272 RVA: 0x0085DD6C File Offset: 0x0085BF6C
		public VolumeEffectField DDEPIBFMILD(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i += 0)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013991 RID: 80273 RVA: 0x0085DDB8 File Offset: 0x0085BFB8
		public void OOFKIOBCGNK(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.DCHDCDEBFKJ)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.LCCNKOLNMCH(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06013992 RID: 80274 RVA: 0x0085D15C File Offset: 0x0085B35C
		public VolumeEffectField MBJMOPGEIGM(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.DKOFAJHIOHA(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013993 RID: 80275 RVA: 0x0085D15C File Offset: 0x0085B35C
		public VolumeEffectField GMPJKHGDEML(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.DKOFAJHIOHA(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013994 RID: 80276 RVA: 0x0085DE7C File Offset: 0x0085C07C
		public VolumeEffectField BPPJPDOCAGC(string OHPEHLMFMHK)
		{
			for (int i = 1; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013995 RID: 80277 RVA: 0x0085DEC8 File Offset: 0x0085C0C8
		public VolumeEffectField FDCEIKENDOF(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.HHGFMAIENOH(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x06013996 RID: 80278 RVA: 0x0085D360 File Offset: 0x0085B560
		public VolumeEffectField KFFONCAHIML(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.FDCEIKENDOF(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x06013997 RID: 80279 RVA: 0x0085DF24 File Offset: 0x0085C124
		public VolumeEffectField JBJIHHJCIPJ(string OHPEHLMFMHK)
		{
			for (int i = 1; i < this.fields.Count; i += 0)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06013998 RID: 80280 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void KIBIEHINJHN(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x06013999 RID: 80281 RVA: 0x0085DF70 File Offset: 0x0085C170
		public VolumeEffectField CNOIJJNKPHP(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.HFBKFKFPFKC(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601399A RID: 80282 RVA: 0x0085DFCC File Offset: 0x0085C1CC
		public static FieldInfo[] BDPKIIJCBME(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[1];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.LALHNIIGPNA)).ToArray<FieldInfo>();
		}

		// Token: 0x0601399B RID: 80283 RVA: 0x0085E020 File Offset: 0x0085C220
		public VolumeEffectField PIKMCMCGDOM(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.HHGFMAIENOH(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 1 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x0601399C RID: 80284 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void MJILFPLIJBJ(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x0601399D RID: 80285 RVA: 0x0085E07C File Offset: 0x0085C27C
		public void BEGENIODGNI(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.GOMLGHFGPEC)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.JAPKIAAFHEB(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0601399E RID: 80286 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void EDOBHNHJGPK(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x0601399F RID: 80287 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void EJINKFHOJHN(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x060139A0 RID: 80288 RVA: 0x0085E140 File Offset: 0x0085C340
		public VolumeEffectField GLGFBOJKMKP(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.OOEKDKLLGFB(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 0 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x060139A1 RID: 80289 RVA: 0x0085E19C File Offset: 0x0085C39C
		public void FOCOKMDNKAA(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.HNEEJJJNCNM)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.NKBOKNKOPFD(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x060139A2 RID: 80290 RVA: 0x0085E260 File Offset: 0x0085C460
		public VolumeEffectField KMEAPJDNGGC(string OHPEHLMFMHK)
		{
			for (int i = 1; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x060139A3 RID: 80291 RVA: 0x0085E2AA File Offset: 0x0085C4AA
		public string[] EOMMPFDDJKK()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.KDGKEAGLBCH)).ToArray<string>();
		}

		// Token: 0x060139A4 RID: 80292 RVA: 0x0085E2DB File Offset: 0x0085C4DB
		public string[] FLCDNDFKGHB()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.JDJIOANOHIJ)).ToArray<string>();
		}

		// Token: 0x060139A5 RID: 80293 RVA: 0x0085E30C File Offset: 0x0085C50C
		public VolumeEffectField DGMFAJBPNPD(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i += 0)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x060139A6 RID: 80294 RVA: 0x0085E358 File Offset: 0x0085C558
		public VolumeEffectField PPKPBFIKFFL(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.CCMGOAAIGDJ(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 0 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x060139A7 RID: 80295 RVA: 0x0085D15C File Offset: 0x0085B35C
		public VolumeEffectField DKOFAJHIOHA(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.DKOFAJHIOHA(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x060139A8 RID: 80296 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void PJJLNCKOJJC(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x060139A9 RID: 80297 RVA: 0x0085E3B3 File Offset: 0x0085C5B3
		public string[] OPAJNBKJANF()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.PCJGNNEBGHA)).ToArray<string>();
		}

		// Token: 0x060139AA RID: 80298 RVA: 0x0085E3E4 File Offset: 0x0085C5E4
		public static FieldInfo[] PPMHCIGINBC(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.GHOCPDOENEA)).ToArray<FieldInfo>();
		}

		// Token: 0x060139AB RID: 80299 RVA: 0x0085E435 File Offset: 0x0085C635
		public VolumeEffectField JPEJAENCGKN(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB)
		{
			return this.OKCFDIONNJF(JFMMNIJJODD, OAGAHEAMIAB, -1);
		}

		// Token: 0x060139AC RID: 80300 RVA: 0x0085E440 File Offset: 0x0085C640
		public static FieldInfo[] FODAMMMDDBF(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.JDKELHKCFCJ)).ToArray<FieldInfo>();
		}

		// Token: 0x060139AD RID: 80301 RVA: 0x0085E494 File Offset: 0x0085C694
		public void BMGHCBLNENB(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.MIIPAJAIJEK)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.JMBLHLLAIKI(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x060139AE RID: 80302 RVA: 0x0085E3B3 File Offset: 0x0085C5B3
		public string[] CDDIKIDJEBC()
		{
			return this.fields.Select(new Func<VolumeEffectField, string>(VolumeEffectComponent.<>c.<>9.PCJGNNEBGHA)).ToArray<string>();
		}

		// Token: 0x060139AF RID: 80303 RVA: 0x0085E558 File Offset: 0x0085C758
		public VolumeEffectField DKOFAJHIOHA(FieldInfo JFMMNIJJODD, Component OAGAHEAMIAB, int MGALEAJOGPL)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.CNJLKPBCKBE(JFMMNIJJODD.FieldType.FullName) ? new VolumeEffectField(JFMMNIJJODD, OAGAHEAMIAB) : null;
			if (volumeEffectField != null)
			{
				if (MGALEAJOGPL < 0 || MGALEAJOGPL >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(MGALEAJOGPL, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x060139B0 RID: 80304 RVA: 0x0085E5B4 File Offset: 0x0085C7B4
		public static FieldInfo[] LINFMFPKHOI(Component OAGAHEAMIAB)
		{
			if (OAGAHEAMIAB == null)
			{
				return new FieldInfo[0];
			}
			return OAGAHEAMIAB.GetType().GetFields().Where(new Func<FieldInfo, bool>(VolumeEffectComponent.<>c.<>9.CJIKINLJEHD)).ToArray<FieldInfo>();
		}

		// Token: 0x060139B1 RID: 80305 RVA: 0x0085E608 File Offset: 0x0085C808
		public VolumeEffectField LBFCDONKPAI(string OHPEHLMFMHK)
		{
			for (int i = 0; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == OHPEHLMFMHK)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x060139B2 RID: 80306 RVA: 0x0085C1EC File Offset: 0x0085A3EC
		public void ALHKHIFHGHA(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fields.Remove(ILLLMBKGLOJ);
		}

		// Token: 0x060139B3 RID: 80307 RVA: 0x0085E654 File Offset: 0x0085C854
		public void KAOEPKHABND(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = LCNOOKMLHKE.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent.AJNGGEKPNKE ajnggekpnke = new VolumeEffectComponent.AJNGGEKPNKE();
					ajnggekpnke.PDPDNCGHOJA = enumerator.Current;
					if (ajnggekpnke.PDPDNCGHOJA.blendFlag && !this.fields.Exists(new Predicate<VolumeEffectField>(ajnggekpnke.AELJEILOFPH)))
					{
						FieldInfo field = OAGAHEAMIAB.GetType().GetField(ajnggekpnke.PDPDNCGHOJA.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.CNJLKPBCKBE(field.FieldType.FullName) ? new VolumeEffectField(field, OAGAHEAMIAB) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x0400280B RID: 10251
		public string componentName;

		// Token: 0x0400280C RID: 10252
		public List<VolumeEffectField> fields;

		// Token: 0x020005D7 RID: 1495
		[CompilerGenerated]
		private sealed class AJNGGEKPNKE
		{
			// Token: 0x060139B4 RID: 80308 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool NAOFGJBFJOJ(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139B5 RID: 80309 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool MCLFBJLLJLP(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139B6 RID: 80310 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool CJEBCPHILBO(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139B7 RID: 80311 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool AOFCELHFHCA(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139B8 RID: 80312 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool EEPOELCOGNF(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139B9 RID: 80313 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool DKFGOKLGJPI(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139BA RID: 80314 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool KPGKKBLJLIM(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139BB RID: 80315 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool GDIBJDAICPD(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139BC RID: 80316 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool GOMLGHFGPEC(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139BD RID: 80317 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool BLMKKKMAFKH(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139BE RID: 80318 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool HHLCAOFBAAE(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139BF RID: 80319 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool KAPBACHINOA(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C0 RID: 80320 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool BJHDDCGGMGO(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C1 RID: 80321 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool KJCOLJMPIEO(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C2 RID: 80322 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool GMHFLODGLOD(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C3 RID: 80323 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool BOGOBMDOJOP(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C4 RID: 80324 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool MGHKLGKEEPO(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C5 RID: 80325 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool OBLJLJNNHHH(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C6 RID: 80326 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool HNEEJJJNCNM(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C7 RID: 80327 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool NLEAJMNADGL(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C8 RID: 80328 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool GFNCGFBGKBH(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139C9 RID: 80329 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool NLMIKFLHEDE(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139CA RID: 80330 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool CCOKFKBLBDH(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139CB RID: 80331 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool EFLCGKFILCE(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139CC RID: 80332 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool AELJEILOFPH(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139CD RID: 80333 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool NMEAJPBNECL(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139CE RID: 80334 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool NHFKBFCFDJL(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139CF RID: 80335 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool HJNJGCHFFBK(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D0 RID: 80336 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool DEFFKKHIOKE(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D1 RID: 80337 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool KOECDJPHHOI(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D2 RID: 80338 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool HILLFNCIOIB(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D3 RID: 80339 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool DCHDCDEBFKJ(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D4 RID: 80340 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool CMCBOPNGFDE(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D5 RID: 80341 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool NOLKAPNAOKG(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D6 RID: 80342 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool GOPCAMICOCG(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D7 RID: 80343 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool INEKLMELPKB(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D8 RID: 80344 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool DELEAKGNFDA(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139D9 RID: 80345 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool ILIGNCGHMOK(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139DB RID: 80347 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool IAPDBOJOODL(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139DC RID: 80348 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool JGHDMLHJFKE(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139DD RID: 80349 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool BJDBGCGGHNK(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139DE RID: 80350 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool DCDENMAOOOI(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139DF RID: 80351 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool MIIPAJAIJEK(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139E0 RID: 80352 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool OEJFKFCOECN(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139E1 RID: 80353 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool PLOPIFGGLJI(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139E2 RID: 80354 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool CNCODBMFPFK(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139E3 RID: 80355 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool PAJAFPMCAHO(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139E4 RID: 80356 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool PMBNBEIOJBM(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139E5 RID: 80357 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool PEOECPIEACP(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139E6 RID: 80358 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool AELFDIFIINE(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x060139E7 RID: 80359 RVA: 0x0085E718 File Offset: 0x0085C918
			internal bool GKGEDAGBLKD(VolumeEffectField EEOOKGDHNCO)
			{
				return EEOOKGDHNCO.fieldName == this.PDPDNCGHOJA.fieldName;
			}

			// Token: 0x0400280D RID: 10253
			public VolumeEffectFieldFlags PDPDNCGHOJA;
		}
	}
}
