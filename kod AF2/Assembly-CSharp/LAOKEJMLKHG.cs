using System;
using AssetBundles;
using UnityEngine;

// Token: 0x020005AD RID: 1453
public class LAOKEJMLKHG : KEEHKMIFKCM
{
	// Token: 0x06013215 RID: 78357 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool EHNEGANJFBL()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013216 RID: 78358 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool HEKAOHPIMOM()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013217 RID: 78359 RVA: 0x0083A7B6 File Offset: 0x008389B6
	public virtual bool KHGANFAMOJA()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013218 RID: 78360 RVA: 0x0083A7EC File Offset: 0x008389EC
	public virtual bool IGEICBNMPAD()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013219 RID: 78361 RVA: 0x0083A834 File Offset: 0x00838A34
	public virtual bool BJOICAKCPLI()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x0601321A RID: 78362 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool ENKKIMODBDA()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601321B RID: 78363 RVA: 0x0083A8B0 File Offset: 0x00838AB0
	public virtual bool MNAHGMDDHCA()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x0601321C RID: 78364 RVA: 0x0083A8F8 File Offset: 0x00838AF8
	public virtual bool LFJHDHPJOPE()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x0601321D RID: 78365 RVA: 0x0083A940 File Offset: 0x00838B40
	public virtual bool HMLNMHOMMNO()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x0601321E RID: 78366 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool PEBGGKAOLIC()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601321F RID: 78367 RVA: 0x0083A988 File Offset: 0x00838B88
	public virtual bool MEFOGCFJBNE()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013220 RID: 78368 RVA: 0x0083A9D0 File Offset: 0x00838BD0
	public virtual bool LIOCDEICIFD()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013221 RID: 78369 RVA: 0x0083AA18 File Offset: 0x00838C18
	public virtual bool JMNNAPNJDNK()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013222 RID: 78370 RVA: 0x0083AA60 File Offset: 0x00838C60
	public virtual bool EMFOECIPBIP()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013223 RID: 78371 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool GMMJPFJGFPI()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013224 RID: 78372 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool AANKCKFJDJA()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013225 RID: 78373 RVA: 0x0083AAA8 File Offset: 0x00838CA8
	public virtual bool IANJLHIIGLN()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013226 RID: 78374 RVA: 0x0083A87A File Offset: 0x00838A7A
	public override bool PHDPANIEMMP()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013227 RID: 78375 RVA: 0x0083AAF0 File Offset: 0x00838CF0
	public virtual bool BNKJNBIDPME()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013228 RID: 78376 RVA: 0x0083AB38 File Offset: 0x00838D38
	public virtual bool AAEFACEGJMB()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013229 RID: 78377 RVA: 0x0083AB80 File Offset: 0x00838D80
	public virtual bool PMKOAHMNBBG()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x0601322A RID: 78378 RVA: 0x0083ABC8 File Offset: 0x00838DC8
	public virtual bool DKOIOBMMAGN()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x0601322B RID: 78379 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool OOAEEBONLNJ()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601322C RID: 78380 RVA: 0x0083AC10 File Offset: 0x00838E10
	public virtual bool IKHCCAANGOP()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x0601322D RID: 78381 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool GBHJEEJLDDL()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601322E RID: 78382 RVA: 0x0083AC58 File Offset: 0x00838E58
	public virtual bool GCNGEFBKMNC()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x0601322F RID: 78383 RVA: 0x0083AC9E File Offset: 0x00838E9E
	public LAOKEJMLKHG(string DIGAMKHDDDF, string DCGNANHJHBC, Type DFBHMIIPLCA)
	{
		this.PKELIBKCOFK = DIGAMKHDDDF;
		this.KDJIGONPAEL = DCGNANHJHBC;
		this.JGKKFNLDHAM = DFBHMIIPLCA;
	}

	// Token: 0x06013230 RID: 78384 RVA: 0x0083ACBC File Offset: 0x00838EBC
	public virtual bool LBOONMDONCF()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013231 RID: 78385 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool LMHCALPDDJD()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013232 RID: 78386 RVA: 0x0083AD04 File Offset: 0x00838F04
	public virtual bool INKGAFANFIB()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x06013233 RID: 78387 RVA: 0x0083AD4C File Offset: 0x00838F4C
	public virtual bool PAKOHKKBKHD()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013234 RID: 78388 RVA: 0x0083A7B6 File Offset: 0x008389B6
	public virtual bool FIBOINMFBBL()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013235 RID: 78389 RVA: 0x0083AD94 File Offset: 0x00838F94
	public virtual bool KJJEEMEHGBF()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x06013236 RID: 78390 RVA: 0x0083A7B6 File Offset: 0x008389B6
	public virtual bool PGGKLNLGAME()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013237 RID: 78391 RVA: 0x0083ADDC File Offset: 0x00838FDC
	public virtual bool BOAJJAKEMLH()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x06013238 RID: 78392 RVA: 0x0083AE24 File Offset: 0x00839024
	public virtual bool DFFOEGHGPGP()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013239 RID: 78393 RVA: 0x0083A7B6 File Offset: 0x008389B6
	public virtual bool HENCMKMELJJ()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601323A RID: 78394 RVA: 0x0083AE6C File Offset: 0x0083906C
	public virtual bool GPCKACGEILI()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x0601323B RID: 78395 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool JKAKMIJBCGE()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601323C RID: 78396 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool PGEAPKLFKHE()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601323D RID: 78397 RVA: 0x0083AEB4 File Offset: 0x008390B4
	public virtual bool EKCKBDKEAKO()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x0601323E RID: 78398 RVA: 0x0083AEFC File Offset: 0x008390FC
	public virtual bool OIBIGDFPHGO()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x0601323F RID: 78399 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool DDAHLHCLNLD()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013240 RID: 78400 RVA: 0x0083AF44 File Offset: 0x00839144
	public virtual bool LACNPNKHCAA()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013241 RID: 78401 RVA: 0x0083AF8C File Offset: 0x0083918C
	public virtual bool JPHLMNIMDHH()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013242 RID: 78402 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool OBGDDOEKLPL()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013243 RID: 78403 RVA: 0x0083AFD4 File Offset: 0x008391D4
	public virtual bool HCDJABMBDFF()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x06013244 RID: 78404 RVA: 0x0083B01C File Offset: 0x0083921C
	public virtual bool MFHGOLNLAAF()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013245 RID: 78405 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool JBBLKHHDPCA()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013246 RID: 78406 RVA: 0x0083B064 File Offset: 0x00839264
	public override bool FANPFKHEDPA()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013247 RID: 78407 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool PFADHBLKJLK()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013248 RID: 78408 RVA: 0x0083B0AC File Offset: 0x008392AC
	public virtual bool LMMDHJJJNJO()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x06013249 RID: 78409 RVA: 0x0083B0F4 File Offset: 0x008392F4
	public virtual bool PJHEGHHOJHJ()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x0601324A RID: 78410 RVA: 0x0083B13C File Offset: 0x0083933C
	public virtual bool JIBKGOFOPHJ()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x0601324B RID: 78411 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool MLCGGKBGHKM()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601324C RID: 78412 RVA: 0x0083A7B6 File Offset: 0x008389B6
	public virtual bool GDNKGIJEBHF()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601324D RID: 78413 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool BIEFFLLKBBF()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601324E RID: 78414 RVA: 0x0083B184 File Offset: 0x00839384
	public override T GJDMLCHAKLH<T>()
	{
		if (this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone)
		{
			return this.NJKLGHHHKAN.asset as T;
		}
		return default(T);
	}

	// Token: 0x0601324F RID: 78415 RVA: 0x0083B1C8 File Offset: 0x008393C8
	public virtual bool EMHGNEMIGII()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013250 RID: 78416 RVA: 0x0083B210 File Offset: 0x00839410
	public virtual bool DIAIKCBANBK()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013251 RID: 78417 RVA: 0x0083B258 File Offset: 0x00839458
	public virtual bool AKLFCMNCPKL()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013252 RID: 78418 RVA: 0x0083B2A0 File Offset: 0x008394A0
	public virtual bool OPDCJCFMIPE()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x06013253 RID: 78419 RVA: 0x0083A7B6 File Offset: 0x008389B6
	public virtual bool NEFHINFOMEK()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013254 RID: 78420 RVA: 0x0083B2E8 File Offset: 0x008394E8
	public virtual bool HNMODJBBKBI()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x06013255 RID: 78421 RVA: 0x0083B32E File Offset: 0x0083952E
	public virtual bool MHPCJHKALBJ()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013256 RID: 78422 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool JEJJFPFKFLD()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013257 RID: 78423 RVA: 0x0083B364 File Offset: 0x00839564
	public virtual bool HAIMGCDKPDC()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013258 RID: 78424 RVA: 0x0083B32E File Offset: 0x0083952E
	public virtual bool NHGNOBGAIMC()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013259 RID: 78425 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool FLLGBABPOML()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601325A RID: 78426 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool FGHKKOEJGHI()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601325B RID: 78427 RVA: 0x0083B3AC File Offset: 0x008395AC
	public virtual bool HJCLNJLADKL()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x0601325C RID: 78428 RVA: 0x0083B3F4 File Offset: 0x008395F4
	public virtual bool OFPGMNGFLNH()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x0601325D RID: 78429 RVA: 0x0083B43C File Offset: 0x0083963C
	public virtual bool FPLNDDMFFKG()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x0601325E RID: 78430 RVA: 0x0083B484 File Offset: 0x00839684
	public virtual bool PFNOEACNHON()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x0601325F RID: 78431 RVA: 0x0083B32E File Offset: 0x0083952E
	public virtual bool AINAALOGEBN()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013260 RID: 78432 RVA: 0x0083B4CC File Offset: 0x008396CC
	public virtual bool CJHBCHBOLBI()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x06013261 RID: 78433 RVA: 0x0083B514 File Offset: 0x00839714
	public virtual bool KOLCEBEIHKP()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return true;
	}

	// Token: 0x06013262 RID: 78434 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool FGGFDIEKENJ()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013263 RID: 78435 RVA: 0x0083A7B6 File Offset: 0x008389B6
	public virtual bool FPPHKPNHAAB()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013264 RID: 78436 RVA: 0x0083B55C File Offset: 0x0083975C
	public virtual bool IDMCOLDDNCF()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.ANBLIFKNMGG(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x06013265 RID: 78437 RVA: 0x0083B5A4 File Offset: 0x008397A4
	public virtual bool IEOICHPKEMD()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x06013266 RID: 78438 RVA: 0x0083B5EC File Offset: 0x008397EC
	public virtual bool MPLCAGFGEBO()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return true;
	}

	// Token: 0x06013267 RID: 78439 RVA: 0x0083B634 File Offset: 0x00839834
	public virtual bool FOHLAIIMNFB()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x06013268 RID: 78440 RVA: 0x0083A782 File Offset: 0x00838982
	public virtual bool DEBDGLCCBII()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return false;
		}
		return this.NJKLGHHHKAN == null || this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x06013269 RID: 78441 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool DEKBOMGBPFE()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x0601326A RID: 78442 RVA: 0x0083B67C File Offset: 0x0083987C
	public virtual bool LBGKAMLLACN()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x0601326B RID: 78443 RVA: 0x0083B6C4 File Offset: 0x008398C4
	public virtual bool PGIHAIPCJLL()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (loadedAssetBundle != null)
		{
			this.NJKLGHHHKAN = loadedAssetBundle.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x0601326C RID: 78444 RVA: 0x0083B70C File Offset: 0x0083990C
	public virtual bool HMEAENGBFKC()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return true;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return false;
		}
		return false;
	}

	// Token: 0x0601326D RID: 78445 RVA: 0x0083B754 File Offset: 0x00839954
	public virtual bool BBFCMCAFOMH()
	{
		if (this.NJKLGHHHKAN != null)
		{
			return false;
		}
		GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(this.PKELIBKCOFK, out this.JPJLKHMHIOM);
		if (gbkehgibalk != null)
		{
			this.NJKLGHHHKAN = gbkehgibalk.OGOBMOCHKCK.LoadAllAssetsAsync(this.JGKKFNLDHAM);
			return true;
		}
		return false;
	}

	// Token: 0x0601326E RID: 78446 RVA: 0x0083A87A File Offset: 0x00838A7A
	public virtual bool JFPFOCDKPML()
	{
		if (this.NJKLGHHHKAN == null && this.JPJLKHMHIOM != null)
		{
			Debug.LogError(this.JPJLKHMHIOM);
			return true;
		}
		return this.NJKLGHHHKAN != null && this.NJKLGHHHKAN.isDone;
	}

	// Token: 0x04002755 RID: 10069
	protected string PKELIBKCOFK;

	// Token: 0x04002756 RID: 10070
	protected string KDJIGONPAEL;

	// Token: 0x04002757 RID: 10071
	protected string JPJLKHMHIOM;

	// Token: 0x04002758 RID: 10072
	protected Type JGKKFNLDHAM;

	// Token: 0x04002759 RID: 10073
	protected AssetBundleRequest NJKLGHHHKAN;
}
