using System;
using AssetBundles;
using UnityEngine;

// Token: 0x020005AA RID: 1450
public class JAFGFNNELOP : MONPHAHBOAM
{
	// Token: 0x06013180 RID: 78208 RVA: 0x00839E87 File Offset: 0x00838087
	public virtual bool CHMEMIOIBEO()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013181 RID: 78209 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool IDGDAMGIEIJ()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013182 RID: 78210 RVA: 0x00839EF0 File Offset: 0x008380F0
	public virtual bool JPHLMNIMDHH()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return true;
	}

	// Token: 0x06013183 RID: 78211 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool NEFHINFOMEK()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013184 RID: 78212 RVA: 0x00839F7D File Offset: 0x0083817D
	public virtual bool EJGCEBLKNPK()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013185 RID: 78213 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool NHGNOBGAIMC()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013186 RID: 78214 RVA: 0x00839FB4 File Offset: 0x008381B4
	public virtual bool OPDCJCFMIPE()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		if (AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return true;
	}

	// Token: 0x06013187 RID: 78215 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool EHGDKLNHGDD()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013188 RID: 78216 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool PPDOKLLGBHJ()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013189 RID: 78217 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool JFFPJJEHJJN()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601318A RID: 78218 RVA: 0x00839F7D File Offset: 0x0083817D
	public virtual bool KHGANFAMOJA()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601318B RID: 78219 RVA: 0x0083A010 File Offset: 0x00838210
	public virtual bool LACNPNKHCAA()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return false;
	}

	// Token: 0x0601318C RID: 78220 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool EHNEGANJFBL()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601318D RID: 78221 RVA: 0x0083A06C File Offset: 0x0083826C
	public virtual bool OHKHOAKCENL()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		if (AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return true;
	}

	// Token: 0x0601318E RID: 78222 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool GBPKMLGJDLC()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601318F RID: 78223 RVA: 0x00839F7D File Offset: 0x0083817D
	public virtual bool FPPHKPNHAAB()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013190 RID: 78224 RVA: 0x0083A0C8 File Offset: 0x008382C8
	public virtual bool AKLFCMNCPKL()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		if (AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return false;
	}

	// Token: 0x06013191 RID: 78225 RVA: 0x00839E87 File Offset: 0x00838087
	public virtual bool JOCHKDIHIMN()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013192 RID: 78226 RVA: 0x0083A124 File Offset: 0x00838324
	public virtual bool DFFOEGHGPGP()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return false;
	}

	// Token: 0x06013193 RID: 78227 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool JNHBGJMICEH()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013194 RID: 78228 RVA: 0x0083A180 File Offset: 0x00838380
	public virtual bool MFHGOLNLAAF()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return false;
	}

	// Token: 0x06013195 RID: 78229 RVA: 0x0083A1DC File Offset: 0x008383DC
	public virtual bool HMEAENGBFKC()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return true;
	}

	// Token: 0x06013196 RID: 78230 RVA: 0x0083A238 File Offset: 0x00838438
	public virtual bool EMFOECIPBIP()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return true;
	}

	// Token: 0x06013197 RID: 78231 RVA: 0x0083A294 File Offset: 0x00838494
	public virtual bool JOHDLNOKCOK()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return false;
	}

	// Token: 0x06013198 RID: 78232 RVA: 0x0083A2F0 File Offset: 0x008384F0
	public virtual bool PFPPDNHLCCA()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		if (AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return false;
	}

	// Token: 0x06013199 RID: 78233 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool KIMFKIIJNFE()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601319A RID: 78234 RVA: 0x00839E87 File Offset: 0x00838087
	public virtual bool KIJPCHCDLDE()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601319B RID: 78235 RVA: 0x0083A34C File Offset: 0x0083854C
	public virtual bool KMLNBHIIGKH()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return false;
	}

	// Token: 0x0601319C RID: 78236 RVA: 0x00839F7D File Offset: 0x0083817D
	public virtual bool PGGKLNLGAME()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601319D RID: 78237 RVA: 0x0083A3A8 File Offset: 0x008385A8
	public virtual bool LDDIGEMBDNF()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return true;
	}

	// Token: 0x0601319E RID: 78238 RVA: 0x0083A404 File Offset: 0x00838604
	public virtual bool PNBGJBMJLFM()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return true;
	}

	// Token: 0x0601319F RID: 78239 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool JKAKMIJBCGE()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131A0 RID: 78240 RVA: 0x0083A460 File Offset: 0x00838660
	public virtual bool AIAMIFEPALP()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return true;
	}

	// Token: 0x060131A1 RID: 78241 RVA: 0x0083A4BC File Offset: 0x008386BC
	public virtual bool CDLDCKAHLHC()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return true;
	}

	// Token: 0x060131A2 RID: 78242 RVA: 0x0083A518 File Offset: 0x00838718
	public virtual bool HAIMGCDKPDC()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return true;
	}

	// Token: 0x060131A3 RID: 78243 RVA: 0x0083A574 File Offset: 0x00838774
	public virtual bool GCNGEFBKMNC()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		if (AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return true;
	}

	// Token: 0x060131A4 RID: 78244 RVA: 0x0083A5D0 File Offset: 0x008387D0
	public virtual bool FPLNDDMFFKG()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		if (AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return true;
	}

	// Token: 0x060131A5 RID: 78245 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool PNECFCMGOOG()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131A6 RID: 78246 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool DEKBOMGBPFE()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131A7 RID: 78247 RVA: 0x0083A62C File Offset: 0x0083882C
	public override bool FANPFKHEDPA()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		if (AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return false;
		}
		return true;
	}

	// Token: 0x060131A8 RID: 78248 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool NLILCIGCCCK()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131A9 RID: 78249 RVA: 0x00839F7D File Offset: 0x0083817D
	public override bool PHDPANIEMMP()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131AA RID: 78250 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool BENBOJIBBLH()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131AB RID: 78251 RVA: 0x0083A688 File Offset: 0x00838888
	public virtual bool BNKJNBIDPME()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return false;
	}

	// Token: 0x060131AC RID: 78252 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool JBBLKHHDPCA()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131AD RID: 78253 RVA: 0x0083A6E1 File Offset: 0x008388E1
	public JAFGFNNELOP(string DLELNBLNHBF, string KBBPAHGMKNG, bool NKFPOLMOKPE)
	{
		this.PKELIBKCOFK = DLELNBLNHBF;
		this.PKNFCAFLJOM = KBBPAHGMKNG;
		this.PENLHIEONMD = NKFPOLMOKPE;
	}

	// Token: 0x060131AE RID: 78254 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool BPEFIHJODDL()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131AF RID: 78255 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool NIMNFDPODMC()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131B0 RID: 78256 RVA: 0x00839F49 File Offset: 0x00838149
	public virtual bool HEKAOHPIMOM()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131B1 RID: 78257 RVA: 0x00839EBB File Offset: 0x008380BB
	public virtual bool KLPBIMBAJAF()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x060131B2 RID: 78258 RVA: 0x0083A700 File Offset: 0x00838900
	public virtual bool EKCKBDKEAKO()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		if (AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM) != null)
		{
			if (this.PENLHIEONMD)
			{
				this.NJKLGHHHKAN = Application.LoadLevelAdditiveAsync(this.PKNFCAFLJOM);
			}
			else
			{
				this.NJKLGHHHKAN = Application.LoadLevelAsync(this.PKNFCAFLJOM);
			}
			return true;
		}
		return true;
	}

	// Token: 0x0400274F RID: 10063
	protected string PKELIBKCOFK;

	// Token: 0x04002750 RID: 10064
	protected string PKNFCAFLJOM;

	// Token: 0x04002751 RID: 10065
	protected bool PENLHIEONMD;

	// Token: 0x04002752 RID: 10066
	protected string JPJLKHMHIOM;

	// Token: 0x04002753 RID: 10067
	protected AsyncOperation NJKLGHHHKAN;
}
