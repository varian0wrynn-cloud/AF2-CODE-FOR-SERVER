using System;
using System.Collections.Generic;
using UnityEngine;

namespace ProCore.Decals
{
	// Token: 0x020004D1 RID: 1233
	[Serializable]
	public class DecalGroup
	{
		// Token: 0x06010CCA RID: 68810 RVA: 0x0077CD74 File Offset: 0x0077AF74
		public bool GDLPBBDPDCB(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06010CCB RID: 68811 RVA: 0x0077CDD4 File Offset: 0x0077AFD4
		public bool KJKHGAGILKF(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return false;
					}
				}
			}
			return false;
		}

		// Token: 0x06010CCC RID: 68812 RVA: 0x0077CE34 File Offset: 0x0077B034
		public bool HONDAMBLELE(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06010CCD RID: 68813 RVA: 0x0077CE94 File Offset: 0x0077B094
		public bool HBHKLJMFILG(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06010CCE RID: 68814 RVA: 0x0077CEF4 File Offset: 0x0077B0F4
		public bool CJLCKLGLECE(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06010CCF RID: 68815 RVA: 0x0077CF54 File Offset: 0x0077B154
		public bool JPAFDKOFPFK(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06010CD0 RID: 68816 RVA: 0x0077CFB4 File Offset: 0x0077B1B4
		public bool IAJCJFHBJJN(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06010CD1 RID: 68817 RVA: 0x0077D014 File Offset: 0x0077B214
		public bool EIGLJIGAHOA(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x06010CD2 RID: 68818 RVA: 0x0077D074 File Offset: 0x0077B274
		public bool MLDNMHOKMML(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06010CD3 RID: 68819 RVA: 0x0077D0D4 File Offset: 0x0077B2D4
		public bool LCHAHDCFMOA(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06010CD4 RID: 68820 RVA: 0x0077D134 File Offset: 0x0077B334
		public bool IHJPDLNPJMF(Texture2D NAGPDILILNL)
		{
			using (List<Decal>.Enumerator enumerator = this.decals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.texture == NAGPDILILNL)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06010CD5 RID: 68821 RVA: 0x0077D194 File Offset: 0x0077B394
		public DecalGroup(string BNIHFBMEPAB, List<Decal> AJDACCIAOKI, bool AMMGBICCKFG, Shader BAKBIMBKKNP, Material MHNAJNGGDFJ, int DAEPJPCMAJE, int EEHDDIJCLMF)
		{
			this.name = BNIHFBMEPAB;
			this.decals = AJDACCIAOKI;
			this.shader = BAKBIMBKKNP;
			this.isPacked = AMMGBICCKFG;
			this.material = MHNAJNGGDFJ;
			this.maxAtlasSize = DAEPJPCMAJE;
			this.padding = EEHDDIJCLMF;
		}

		// Token: 0x040022FC RID: 8956
		public const int MAX_ATLAS_SIZE_DEFAULT = 4096;

		// Token: 0x040022FD RID: 8957
		public const int ATLAS_PADDING_DEFAULT = 4;

		// Token: 0x040022FE RID: 8958
		public List<Decal> decals;

		// Token: 0x040022FF RID: 8959
		public string name;

		// Token: 0x04002300 RID: 8960
		public Shader shader;

		// Token: 0x04002301 RID: 8961
		public bool isPacked;

		// Token: 0x04002302 RID: 8962
		public Material material;

		// Token: 0x04002303 RID: 8963
		public int maxAtlasSize;

		// Token: 0x04002304 RID: 8964
		public int padding;
	}
}
