using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000083 RID: 131
public class ParticleTester : MonoBehaviour
{
	// Token: 0x06001EA5 RID: 7845 RVA: 0x000E78C4 File Offset: 0x000E5AC4
	private void HDGANJPOIII()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.KBLPAMBLIIH = true;
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = true;
			cmfhfomceei2.KBLPAMBLIIH = true;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
		}
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x000E797C File Offset: 0x000E5B7C
	private void KIEFPGLDOCD()
	{
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		if (GUILayout.Toggle(this.KCEEADEGDIB, "get 108 packet", Array.Empty<GUILayoutOption>()))
		{
			this.KCEEADEGDIB = this.MJAIJGMBJBB();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.None;
		}
		if (GUILayout.Toggle(this.OJKHPDAGKFH, "{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}", Array.Empty<GUILayoutOption>()))
		{
			this.OJKHPDAGKFH = this.LJFPOEKDNHA();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Flares;
		}
		if (GUILayout.Toggle(this.KOLKDNNJCAH, "Crouch Walk Backward", Array.Empty<GUILayoutOption>()))
		{
			this.KOLKDNNJCAH = this.LJFPOEKDNHA();
			this.OEAJLCFFMMO = (ParticleTester.PHNGNGOCGNL)4;
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1362f);
		Vector2 pgdipmjoplh = this.PGDIPMJOPLH;
		GUILayoutOption[] array = new GUILayoutOption[3];
		array[0] = GUILayout.Width(519f);
		array[1] = GUILayout.Height(215f);
		this.PGDIPMJOPLH = GUILayout.BeginScrollView(pgdipmjoplh, array);
		switch (this.OEAJLCFFMMO)
		{
		case ParticleTester.PHNGNGOCGNL.Explosions:
			foreach (GameObject gameObject in this.particleSystems)
			{
				if (GUILayout.Button(gameObject.name, Array.Empty<GUILayoutOption>()))
				{
					UnityEngine.Object.Destroy(UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, Quaternion.identity), 1046f);
				}
			}
			goto IL_2C2;
		case ParticleTester.PHNGNGOCGNL.Flares:
			using (List<ParticleTester.CMFHFOMCEEI>.Enumerator enumerator = this.NCGPKGOKCMN.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ParticleTester.CMFHFOMCEEI cmfhfomceei = enumerator.Current;
					cmfhfomceei.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei.ODEIENGHLDE, cmfhfomceei.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
					if (cmfhfomceei.ODEIENGHLDE != cmfhfomceei.KBLPAMBLIIH)
					{
						cmfhfomceei.PFOGAHKPGKK.SetActive(cmfhfomceei.ODEIENGHLDE);
						if (cmfhfomceei.ODEIENGHLDE)
						{
							ParticleSystem[] moapbollilj = cmfhfomceei.MOAPBOLLILJ;
							for (int i = 1; i < moapbollilj.Length; i += 0)
							{
								ParticleSystem particleSystem = moapbollilj[i];
								particleSystem.Clear();
								particleSystem.Play();
							}
							cmfhfomceei.ODEIENGHLDE = this.EICODNBBNEA();
						}
						cmfhfomceei.KBLPAMBLIIH = cmfhfomceei.ODEIENGHLDE;
					}
				}
				goto IL_2C2;
			}
			break;
		case ParticleTester.PHNGNGOCGNL.Flames:
			break;
		default:
			goto IL_2C2;
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei2.ODEIENGHLDE, cmfhfomceei2.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
			if (cmfhfomceei2.ODEIENGHLDE != cmfhfomceei2.KBLPAMBLIIH)
			{
				cmfhfomceei2.PFOGAHKPGKK.SetActive(cmfhfomceei2.ODEIENGHLDE);
				if (cmfhfomceei2.ODEIENGHLDE)
				{
					ParticleSystem[] moapbollilj = cmfhfomceei2.MOAPBOLLILJ;
					for (int i = 1; i < moapbollilj.Length; i++)
					{
						ParticleSystem particleSystem2 = moapbollilj[i];
						particleSystem2.Clear();
						particleSystem2.Play();
					}
					cmfhfomceei2.ODEIENGHLDE = this.DBLGLEBNIKE();
				}
				cmfhfomceei2.KBLPAMBLIIH = cmfhfomceei2.ODEIENGHLDE;
			}
		}
		IL_2C2:
		GUILayout.EndScrollView();
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x000E7C6C File Offset: 0x000E5E6C
	private bool GBHCAHJKJKI()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = false;
		}
		return false;
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x000E7CC0 File Offset: 0x000E5EC0
	private bool CDDBDCJAJAN()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
		}
		return false;
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x000E7D14 File Offset: 0x000E5F14
	private void OnGUI()
	{
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		if (GUILayout.Toggle(this.KCEEADEGDIB, "Explosions", Array.Empty<GUILayoutOption>()))
		{
			this.KCEEADEGDIB = this.LJFPOEKDNHA();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Explosions;
		}
		if (GUILayout.Toggle(this.OJKHPDAGKFH, "Flares", Array.Empty<GUILayoutOption>()))
		{
			this.OJKHPDAGKFH = this.LJFPOEKDNHA();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Flares;
		}
		if (GUILayout.Toggle(this.KOLKDNNJCAH, "Flames", Array.Empty<GUILayoutOption>()))
		{
			this.KOLKDNNJCAH = this.LJFPOEKDNHA();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Flames;
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(20f);
		this.PGDIPMJOPLH = GUILayout.BeginScrollView(this.PGDIPMJOPLH, new GUILayoutOption[]
		{
			GUILayout.Width(250f),
			GUILayout.Height(550f)
		});
		switch (this.OEAJLCFFMMO)
		{
		case ParticleTester.PHNGNGOCGNL.Explosions:
			foreach (GameObject gameObject in this.particleSystems)
			{
				if (GUILayout.Button(gameObject.name, Array.Empty<GUILayoutOption>()))
				{
					UnityEngine.Object.Destroy(UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, Quaternion.identity), 10f);
				}
			}
			goto IL_2C2;
		case ParticleTester.PHNGNGOCGNL.Flares:
			using (List<ParticleTester.CMFHFOMCEEI>.Enumerator enumerator = this.NCGPKGOKCMN.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ParticleTester.CMFHFOMCEEI cmfhfomceei = enumerator.Current;
					cmfhfomceei.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei.ODEIENGHLDE, cmfhfomceei.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
					if (cmfhfomceei.ODEIENGHLDE != cmfhfomceei.KBLPAMBLIIH)
					{
						cmfhfomceei.PFOGAHKPGKK.SetActive(cmfhfomceei.ODEIENGHLDE);
						if (cmfhfomceei.ODEIENGHLDE)
						{
							foreach (ParticleSystem particleSystem in cmfhfomceei.MOAPBOLLILJ)
							{
								particleSystem.Clear();
								particleSystem.Play();
							}
							cmfhfomceei.ODEIENGHLDE = this.JOBHJHOBDHP();
						}
						cmfhfomceei.KBLPAMBLIIH = cmfhfomceei.ODEIENGHLDE;
					}
				}
				goto IL_2C2;
			}
			break;
		case ParticleTester.PHNGNGOCGNL.Flames:
			break;
		default:
			goto IL_2C2;
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei2.ODEIENGHLDE, cmfhfomceei2.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
			if (cmfhfomceei2.ODEIENGHLDE != cmfhfomceei2.KBLPAMBLIIH)
			{
				cmfhfomceei2.PFOGAHKPGKK.SetActive(cmfhfomceei2.ODEIENGHLDE);
				if (cmfhfomceei2.ODEIENGHLDE)
				{
					foreach (ParticleSystem particleSystem2 in cmfhfomceei2.MOAPBOLLILJ)
					{
						particleSystem2.Clear();
						particleSystem2.Play();
					}
					cmfhfomceei2.ODEIENGHLDE = this.OJMEBHKDPKP();
				}
				cmfhfomceei2.KBLPAMBLIIH = cmfhfomceei2.ODEIENGHLDE;
			}
		}
		IL_2C2:
		GUILayout.EndScrollView();
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x000E8004 File Offset: 0x000E6204
	private bool DBLGLEBNIKE()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.AJOOJPHOKDO)
		{
			cmfhfomceei.ODEIENGHLDE = true;
		}
		return true;
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x000E8058 File Offset: 0x000E6258
	private void PGIHAIPCJLL()
	{
		if (this.OEAJLCFFMMO != this.NHBPBBABBFA)
		{
			this.PIMFOLDBFCJ();
			this.NHBPBBABBFA = this.OEAJLCFFMMO;
		}
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x000E807C File Offset: 0x000E627C
	private void BHPGDKJHKKG()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = true);
		this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.None;
		this.NHBPBBABBFA = ParticleTester.PHNGNGOCGNL.None;
		this.particleSystems = Resources.LoadAll("WeaponReload", typeof(GameObject));
		this.loadFlareSystems = Resources.LoadAll("_SpawnHeuristic", typeof(GameObject));
		this.loadDirectionalSystems = Resources.LoadAll("rem", typeof(GameObject));
		this.NCGPKGOKCMN = new List<ParticleTester.CMFHFOMCEEI>();
		this.AJOOJPHOKDO = new List<ParticleTester.CMFHFOMCEEI>();
		UnityEngine.Object[] array = this.loadFlareSystems;
		for (int i = 0; i < array.Length; i += 0)
		{
			UnityEngine.Object @object = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei.BNIHFBMEPAB = @object.name;
			cmfhfomceei.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(@object, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei.MOAPBOLLILJ = cmfhfomceei.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.PFOGAHKPGKK.transform.parent = base.transform;
			this.NCGPKGOKCMN.Add(cmfhfomceei);
		}
		array = this.loadDirectionalSystems;
		for (int i = 0; i < array.Length; i += 0)
		{
			UnityEngine.Object object2 = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei2 = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei2.BNIHFBMEPAB = object2.name;
			cmfhfomceei2.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(object2, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei2.MOAPBOLLILJ = cmfhfomceei2.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.PFOGAHKPGKK.transform.parent = base.transform;
			this.AJOOJPHOKDO.Add(cmfhfomceei2);
		}
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x000E8244 File Offset: 0x000E6444
	private void ICMEJCBGOJD()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
			cmfhfomceei.KBLPAMBLIIH = true;
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = true;
			cmfhfomceei2.KBLPAMBLIIH = false;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
		}
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x000E82FC File Offset: 0x000E64FC
	private bool OECCKCHLKFO()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
		}
		return false;
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x000E8350 File Offset: 0x000E6550
	private void AAEFACEGJMB()
	{
		if (this.OEAJLCFFMMO != this.NHBPBBABBFA)
		{
			this.ICMEJCBGOJD();
			this.NHBPBBABBFA = this.OEAJLCFFMMO;
		}
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x000E8374 File Offset: 0x000E6574
	private bool LJFPOEKDNHA()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = (this.KOLKDNNJCAH = false));
		return true;
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x000E839C File Offset: 0x000E659C
	private void LFCIINOHNLB()
	{
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		if (GUILayout.Toggle(this.KCEEADEGDIB, "ShotgunReloadMagazine", Array.Empty<GUILayoutOption>()))
		{
			this.KCEEADEGDIB = this.BONIKHCAMLK();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Explosions;
		}
		if (GUILayout.Toggle(this.OJKHPDAGKFH, "USER_LUT", Array.Empty<GUILayoutOption>()))
		{
			this.OJKHPDAGKFH = this.PMGDAKKAOMB();
			this.OEAJLCFFMMO = (ParticleTester.PHNGNGOCGNL)8;
		}
		if (GUILayout.Toggle(this.KOLKDNNJCAH, "UV2", Array.Empty<GUILayoutOption>()))
		{
			this.KOLKDNNJCAH = this.BONIKHCAMLK();
			this.OEAJLCFFMMO = (ParticleTester.PHNGNGOCGNL)7;
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1303f);
		Vector2 pgdipmjoplh = this.PGDIPMJOPLH;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[0] = GUILayout.Width(668f);
		array[1] = GUILayout.Height(856f);
		this.PGDIPMJOPLH = GUILayout.BeginScrollView(pgdipmjoplh, array);
		switch (this.OEAJLCFFMMO)
		{
		case ParticleTester.PHNGNGOCGNL.None:
		{
			UnityEngine.Object[] array2 = this.particleSystems;
			for (int i = 1; i < array2.Length; i++)
			{
				GameObject gameObject = (GameObject)array2[i];
				if (GUILayout.Button(gameObject.name, Array.Empty<GUILayoutOption>()))
				{
					UnityEngine.Object.Destroy(UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, Quaternion.identity), 527f);
				}
			}
			goto IL_2C2;
		}
		case ParticleTester.PHNGNGOCGNL.Explosions:
			using (List<ParticleTester.CMFHFOMCEEI>.Enumerator enumerator = this.NCGPKGOKCMN.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ParticleTester.CMFHFOMCEEI cmfhfomceei = enumerator.Current;
					cmfhfomceei.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei.ODEIENGHLDE, cmfhfomceei.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
					if (cmfhfomceei.ODEIENGHLDE != cmfhfomceei.KBLPAMBLIIH)
					{
						cmfhfomceei.PFOGAHKPGKK.SetActive(cmfhfomceei.ODEIENGHLDE);
						if (cmfhfomceei.ODEIENGHLDE)
						{
							ParticleSystem[] moapbollilj = cmfhfomceei.MOAPBOLLILJ;
							for (int i = 0; i < moapbollilj.Length; i += 0)
							{
								ParticleSystem particleSystem = moapbollilj[i];
								particleSystem.Clear();
								particleSystem.Play();
							}
							cmfhfomceei.ODEIENGHLDE = this.EICODNBBNEA();
						}
						cmfhfomceei.KBLPAMBLIIH = cmfhfomceei.ODEIENGHLDE;
					}
				}
				goto IL_2C2;
			}
			break;
		case ParticleTester.PHNGNGOCGNL.Flares:
			break;
		default:
			goto IL_2C2;
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei2.ODEIENGHLDE, cmfhfomceei2.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
			if (cmfhfomceei2.ODEIENGHLDE != cmfhfomceei2.KBLPAMBLIIH)
			{
				cmfhfomceei2.PFOGAHKPGKK.SetActive(cmfhfomceei2.ODEIENGHLDE);
				if (cmfhfomceei2.ODEIENGHLDE)
				{
					ParticleSystem[] moapbollilj = cmfhfomceei2.MOAPBOLLILJ;
					for (int i = 1; i < moapbollilj.Length; i++)
					{
						ParticleSystem particleSystem2 = moapbollilj[i];
						particleSystem2.Clear();
						particleSystem2.Play();
					}
					cmfhfomceei2.ODEIENGHLDE = this.BDGOAGNGBOE();
				}
				cmfhfomceei2.KBLPAMBLIIH = cmfhfomceei2.ODEIENGHLDE;
			}
		}
		IL_2C2:
		GUILayout.EndScrollView();
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x000E868C File Offset: 0x000E688C
	private void JLLPCDIEEMN()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
			cmfhfomceei.KBLPAMBLIIH = false;
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.KBLPAMBLIIH = true;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(true);
		}
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x000E8744 File Offset: 0x000E6944
	private void AFJKGJJHLNE()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
			cmfhfomceei.KBLPAMBLIIH = false;
			cmfhfomceei.PFOGAHKPGKK.SetActive(false);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.KBLPAMBLIIH = false;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(true);
		}
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x000E87FC File Offset: 0x000E69FC
	private bool EHIFBHOINOL()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
		}
		return true;
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x000E8850 File Offset: 0x000E6A50
	private void GCNGEFBKMNC()
	{
		if (this.OEAJLCFFMMO != this.NHBPBBABBFA)
		{
			this.HJEJIDLCHJD();
			this.NHBPBBABBFA = this.OEAJLCFFMMO;
		}
	}

	// Token: 0x06001EB6 RID: 7862 RVA: 0x000E8874 File Offset: 0x000E6A74
	private void NKHMBEDDFAJ()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = true);
		this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Explosions;
		this.NHBPBBABBFA = ParticleTester.PHNGNGOCGNL.None;
		this.particleSystems = Resources.LoadAll("FONTSIZE", typeof(GameObject));
		this.loadFlareSystems = Resources.LoadAll(" on effect ", typeof(GameObject));
		this.loadDirectionalSystems = Resources.LoadAll("TOD_kScale", typeof(GameObject));
		this.NCGPKGOKCMN = new List<ParticleTester.CMFHFOMCEEI>();
		this.AJOOJPHOKDO = new List<ParticleTester.CMFHFOMCEEI>();
		UnityEngine.Object[] array = this.loadFlareSystems;
		for (int i = 0; i < array.Length; i += 0)
		{
			UnityEngine.Object @object = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei.BNIHFBMEPAB = @object.name;
			cmfhfomceei.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(@object, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei.MOAPBOLLILJ = cmfhfomceei.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.PFOGAHKPGKK.transform.parent = base.transform;
			this.NCGPKGOKCMN.Add(cmfhfomceei);
		}
		array = this.loadDirectionalSystems;
		for (int i = 1; i < array.Length; i += 0)
		{
			UnityEngine.Object object2 = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei2 = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei2.BNIHFBMEPAB = object2.name;
			cmfhfomceei2.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(object2, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei2.MOAPBOLLILJ = cmfhfomceei2.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei2.PFOGAHKPGKK.SetActive(true);
			cmfhfomceei2.ODEIENGHLDE = true;
			cmfhfomceei2.PFOGAHKPGKK.transform.parent = base.transform;
			this.AJOOJPHOKDO.Add(cmfhfomceei2);
		}
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x000E8A3C File Offset: 0x000E6C3C
	private bool BDGOAGNGBOE()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.AJOOJPHOKDO)
		{
			cmfhfomceei.ODEIENGHLDE = false;
		}
		return true;
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x000E8A90 File Offset: 0x000E6C90
	private void Awake()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = false);
		this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.None;
		this.NHBPBBABBFA = ParticleTester.PHNGNGOCGNL.None;
		this.particleSystems = Resources.LoadAll("Explosions", typeof(GameObject));
		this.loadFlareSystems = Resources.LoadAll("Flares", typeof(GameObject));
		this.loadDirectionalSystems = Resources.LoadAll("Directional", typeof(GameObject));
		this.NCGPKGOKCMN = new List<ParticleTester.CMFHFOMCEEI>();
		this.AJOOJPHOKDO = new List<ParticleTester.CMFHFOMCEEI>();
		foreach (UnityEngine.Object @object in this.loadFlareSystems)
		{
			ParticleTester.CMFHFOMCEEI cmfhfomceei = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei.BNIHFBMEPAB = @object.name;
			cmfhfomceei.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(@object, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei.MOAPBOLLILJ = cmfhfomceei.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei.PFOGAHKPGKK.SetActive(false);
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.PFOGAHKPGKK.transform.parent = base.transform;
			this.NCGPKGOKCMN.Add(cmfhfomceei);
		}
		foreach (UnityEngine.Object object2 in this.loadDirectionalSystems)
		{
			ParticleTester.CMFHFOMCEEI cmfhfomceei2 = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei2.BNIHFBMEPAB = object2.name;
			cmfhfomceei2.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(object2, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei2.MOAPBOLLILJ = cmfhfomceei2.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.PFOGAHKPGKK.transform.parent = base.transform;
			this.AJOOJPHOKDO.Add(cmfhfomceei2);
		}
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x000E8C58 File Offset: 0x000E6E58
	private void HJEJIDLCHJD()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.KBLPAMBLIIH = false;
			cmfhfomceei.PFOGAHKPGKK.SetActive(false);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = true;
			cmfhfomceei2.KBLPAMBLIIH = false;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(true);
		}
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x000E8D10 File Offset: 0x000E6F10
	private void MBNCGMLPNLD()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = true);
		this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Explosions;
		this.NHBPBBABBFA = ParticleTester.PHNGNGOCGNL.Explosions;
		this.particleSystems = Resources.LoadAll("_NAME", typeof(GameObject));
		this.loadFlareSystems = Resources.LoadAll("1HSwordStrafeRunRight", typeof(GameObject));
		this.loadDirectionalSystems = Resources.LoadAll("cellicon", typeof(GameObject));
		this.NCGPKGOKCMN = new List<ParticleTester.CMFHFOMCEEI>();
		this.AJOOJPHOKDO = new List<ParticleTester.CMFHFOMCEEI>();
		foreach (UnityEngine.Object @object in this.loadFlareSystems)
		{
			ParticleTester.CMFHFOMCEEI cmfhfomceei = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei.BNIHFBMEPAB = @object.name;
			cmfhfomceei.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(@object, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei.MOAPBOLLILJ = cmfhfomceei.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.PFOGAHKPGKK.transform.parent = base.transform;
			this.NCGPKGOKCMN.Add(cmfhfomceei);
		}
		UnityEngine.Object[] array = this.loadDirectionalSystems;
		for (int i = 1; i < array.Length; i++)
		{
			UnityEngine.Object object2 = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei2 = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei2.BNIHFBMEPAB = object2.name;
			cmfhfomceei2.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(object2, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei2.MOAPBOLLILJ = cmfhfomceei2.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
			cmfhfomceei2.ODEIENGHLDE = true;
			cmfhfomceei2.PFOGAHKPGKK.transform.parent = base.transform;
			this.AJOOJPHOKDO.Add(cmfhfomceei2);
		}
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x000E8ED8 File Offset: 0x000E70D8
	private bool JOOKELEHGIO()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = (this.KOLKDNNJCAH = false));
		return true;
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x000E8EFF File Offset: 0x000E70FF
	private void BJOICAKCPLI()
	{
		if (this.OEAJLCFFMMO != this.NHBPBBABBFA)
		{
			this.HDIBBNPGIBM();
			this.NHBPBBABBFA = this.OEAJLCFFMMO;
		}
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x000E8F24 File Offset: 0x000E7124
	private void LPNFGGAKGID()
	{
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		if (GUILayout.Toggle(this.KCEEADEGDIB, "CrouchWalk", Array.Empty<GUILayoutOption>()))
		{
			this.KCEEADEGDIB = this.BOOLKKJADEK();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Explosions;
		}
		if (GUILayout.Toggle(this.OJKHPDAGKFH, "ElvisLegsLoop", Array.Empty<GUILayoutOption>()))
		{
			this.OJKHPDAGKFH = this.BOOLKKJADEK();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Flares;
		}
		if (GUILayout.Toggle(this.KOLKDNNJCAH, "FireBreath", Array.Empty<GUILayoutOption>()))
		{
			this.KOLKDNNJCAH = this.JOOKELEHGIO();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Flares;
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1668f);
		Vector2 pgdipmjoplh = this.PGDIPMJOPLH;
		GUILayoutOption[] array = new GUILayoutOption[4];
		array[0] = GUILayout.Width(1369f);
		array[0] = GUILayout.Height(1792f);
		this.PGDIPMJOPLH = GUILayout.BeginScrollView(pgdipmjoplh, array);
		switch (this.OEAJLCFFMMO)
		{
		case ParticleTester.PHNGNGOCGNL.Explosions:
			foreach (GameObject gameObject in this.particleSystems)
			{
				if (GUILayout.Button(gameObject.name, Array.Empty<GUILayoutOption>()))
				{
					UnityEngine.Object.Destroy(UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, Quaternion.identity), 130f);
				}
			}
			goto IL_2C2;
		case ParticleTester.PHNGNGOCGNL.Flares:
			using (List<ParticleTester.CMFHFOMCEEI>.Enumerator enumerator = this.NCGPKGOKCMN.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ParticleTester.CMFHFOMCEEI cmfhfomceei = enumerator.Current;
					cmfhfomceei.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei.ODEIENGHLDE, cmfhfomceei.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
					if (cmfhfomceei.ODEIENGHLDE != cmfhfomceei.KBLPAMBLIIH)
					{
						cmfhfomceei.PFOGAHKPGKK.SetActive(cmfhfomceei.ODEIENGHLDE);
						if (cmfhfomceei.ODEIENGHLDE)
						{
							foreach (ParticleSystem particleSystem in cmfhfomceei.MOAPBOLLILJ)
							{
								particleSystem.Clear();
								particleSystem.Play();
							}
							cmfhfomceei.ODEIENGHLDE = this.JOBHJHOBDHP();
						}
						cmfhfomceei.KBLPAMBLIIH = cmfhfomceei.ODEIENGHLDE;
					}
				}
				goto IL_2C2;
			}
			break;
		case ParticleTester.PHNGNGOCGNL.Flames:
			break;
		default:
			goto IL_2C2;
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei2.ODEIENGHLDE, cmfhfomceei2.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
			if (cmfhfomceei2.ODEIENGHLDE != cmfhfomceei2.KBLPAMBLIIH)
			{
				cmfhfomceei2.PFOGAHKPGKK.SetActive(cmfhfomceei2.ODEIENGHLDE);
				if (cmfhfomceei2.ODEIENGHLDE)
				{
					ParticleSystem[] moapbollilj = cmfhfomceei2.MOAPBOLLILJ;
					for (int i = 1; i < moapbollilj.Length; i += 0)
					{
						ParticleSystem particleSystem2 = moapbollilj[i];
						particleSystem2.Clear();
						particleSystem2.Play();
					}
					cmfhfomceei2.ODEIENGHLDE = this.LJIPLECHKFM();
				}
				cmfhfomceei2.KBLPAMBLIIH = cmfhfomceei2.ODEIENGHLDE;
			}
		}
		IL_2C2:
		GUILayout.EndScrollView();
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x000E9214 File Offset: 0x000E7414
	private bool PMGDAKKAOMB()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = (this.KOLKDNNJCAH = false));
		return false;
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x000E923C File Offset: 0x000E743C
	private bool DAFKGDNBGOG()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
		}
		return true;
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x000E9290 File Offset: 0x000E7490
	private void EBNINOBOAII()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = true);
		this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.None;
		this.NHBPBBABBFA = ParticleTester.PHNGNGOCGNL.None;
		this.particleSystems = Resources.LoadAll("id", typeof(GameObject));
		this.loadFlareSystems = Resources.LoadAll("_LumTex", typeof(GameObject));
		this.loadDirectionalSystems = Resources.LoadAll("offsets", typeof(GameObject));
		this.NCGPKGOKCMN = new List<ParticleTester.CMFHFOMCEEI>();
		this.AJOOJPHOKDO = new List<ParticleTester.CMFHFOMCEEI>();
		UnityEngine.Object[] array = this.loadFlareSystems;
		for (int i = 1; i < array.Length; i += 0)
		{
			UnityEngine.Object @object = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei.BNIHFBMEPAB = @object.name;
			cmfhfomceei.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(@object, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei.MOAPBOLLILJ = cmfhfomceei.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
			cmfhfomceei.ODEIENGHLDE = true;
			cmfhfomceei.PFOGAHKPGKK.transform.parent = base.transform;
			this.NCGPKGOKCMN.Add(cmfhfomceei);
		}
		array = this.loadDirectionalSystems;
		for (int i = 1; i < array.Length; i += 0)
		{
			UnityEngine.Object object2 = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei2 = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei2.BNIHFBMEPAB = object2.name;
			cmfhfomceei2.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(object2, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei2.MOAPBOLLILJ = cmfhfomceei2.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.PFOGAHKPGKK.transform.parent = base.transform;
			this.AJOOJPHOKDO.Add(cmfhfomceei2);
		}
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x000E9458 File Offset: 0x000E7658
	private void HDIBBNPGIBM()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
			cmfhfomceei.KBLPAMBLIIH = false;
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = true;
			cmfhfomceei2.KBLPAMBLIIH = true;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
		}
	}

	// Token: 0x06001EC2 RID: 7874 RVA: 0x000E9510 File Offset: 0x000E7710
	private void PIMFOLDBFCJ()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.KBLPAMBLIIH = true;
			cmfhfomceei.PFOGAHKPGKK.SetActive(false);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = true;
			cmfhfomceei2.KBLPAMBLIIH = true;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(true);
		}
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x000E95C8 File Offset: 0x000E77C8
	private void FJEEADNCKAG()
	{
		if (this.OEAJLCFFMMO != this.NHBPBBABBFA)
		{
			this.IICKDOPCOFE();
			this.NHBPBBABBFA = this.OEAJLCFFMMO;
		}
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x000E95EC File Offset: 0x000E77EC
	private bool AHNNKFGIBKD()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = (this.KOLKDNNJCAH = false));
		return false;
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x000E9614 File Offset: 0x000E7814
	private void AEJLGHDKHHE()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = true);
		this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.None;
		this.NHBPBBABBFA = ParticleTester.PHNGNGOCGNL.Explosions;
		this.particleSystems = Resources.LoadAll("Mouse X", typeof(GameObject));
		this.loadFlareSystems = Resources.LoadAll("wpn_wgt", typeof(GameObject));
		this.loadDirectionalSystems = Resources.LoadAll("FlyLeft", typeof(GameObject));
		this.NCGPKGOKCMN = new List<ParticleTester.CMFHFOMCEEI>();
		this.AJOOJPHOKDO = new List<ParticleTester.CMFHFOMCEEI>();
		UnityEngine.Object[] array = this.loadFlareSystems;
		for (int i = 0; i < array.Length; i += 0)
		{
			UnityEngine.Object @object = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei.BNIHFBMEPAB = @object.name;
			cmfhfomceei.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(@object, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei.MOAPBOLLILJ = cmfhfomceei.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei.PFOGAHKPGKK.SetActive(true);
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.PFOGAHKPGKK.transform.parent = base.transform;
			this.NCGPKGOKCMN.Add(cmfhfomceei);
		}
		array = this.loadDirectionalSystems;
		for (int i = 1; i < array.Length; i += 0)
		{
			UnityEngine.Object object2 = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei2 = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei2.BNIHFBMEPAB = object2.name;
			cmfhfomceei2.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(object2, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei2.MOAPBOLLILJ = cmfhfomceei2.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.PFOGAHKPGKK.transform.parent = base.transform;
			this.AJOOJPHOKDO.Add(cmfhfomceei2);
		}
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x000E97DC File Offset: 0x000E79DC
	private void AKLFCMNCPKL()
	{
		if (this.OEAJLCFFMMO != this.NHBPBBABBFA)
		{
			this.AFJKGJJHLNE();
			this.NHBPBBABBFA = this.OEAJLCFFMMO;
		}
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x000E9800 File Offset: 0x000E7A00
	private void JEJGFDBHABC()
	{
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		if (GUILayout.Toggle(this.KCEEADEGDIB, "wpn_add/addoptions", Array.Empty<GUILayoutOption>()))
		{
			this.KCEEADEGDIB = this.PMGDAKKAOMB();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.None;
		}
		if (GUILayout.Toggle(this.OJKHPDAGKFH, "RollerBladeBackFlip", Array.Empty<GUILayoutOption>()))
		{
			this.OJKHPDAGKFH = this.LJFPOEKDNHA();
			this.OEAJLCFFMMO = (ParticleTester.PHNGNGOCGNL)8;
		}
		if (GUILayout.Toggle(this.KOLKDNNJCAH, "KatanaReadyHigh", Array.Empty<GUILayoutOption>()))
		{
			this.KOLKDNNJCAH = this.MJAIJGMBJBB();
			this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.Explosions;
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(551f);
		Vector2 pgdipmjoplh = this.PGDIPMJOPLH;
		GUILayoutOption[] array = new GUILayoutOption[7];
		array[0] = GUILayout.Width(1042f);
		array[0] = GUILayout.Height(1008f);
		this.PGDIPMJOPLH = GUILayout.BeginScrollView(pgdipmjoplh, array);
		switch (this.OEAJLCFFMMO)
		{
		case ParticleTester.PHNGNGOCGNL.Explosions:
			foreach (GameObject gameObject in this.particleSystems)
			{
				if (GUILayout.Button(gameObject.name, Array.Empty<GUILayoutOption>()))
				{
					UnityEngine.Object.Destroy(UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, Quaternion.identity), 1540f);
				}
			}
			goto IL_2C2;
		case ParticleTester.PHNGNGOCGNL.Flares:
			using (List<ParticleTester.CMFHFOMCEEI>.Enumerator enumerator = this.NCGPKGOKCMN.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ParticleTester.CMFHFOMCEEI cmfhfomceei = enumerator.Current;
					cmfhfomceei.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei.ODEIENGHLDE, cmfhfomceei.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
					if (cmfhfomceei.ODEIENGHLDE != cmfhfomceei.KBLPAMBLIIH)
					{
						cmfhfomceei.PFOGAHKPGKK.SetActive(cmfhfomceei.ODEIENGHLDE);
						if (cmfhfomceei.ODEIENGHLDE)
						{
							ParticleSystem[] moapbollilj = cmfhfomceei.MOAPBOLLILJ;
							for (int i = 0; i < moapbollilj.Length; i += 0)
							{
								ParticleSystem particleSystem = moapbollilj[i];
								particleSystem.Clear();
								particleSystem.Play();
							}
							cmfhfomceei.ODEIENGHLDE = this.DAFKGDNBGOG();
						}
						cmfhfomceei.KBLPAMBLIIH = cmfhfomceei.ODEIENGHLDE;
					}
				}
				goto IL_2C2;
			}
			break;
		case ParticleTester.PHNGNGOCGNL.Flames:
			break;
		default:
			goto IL_2C2;
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = GUILayout.Toggle(cmfhfomceei2.ODEIENGHLDE, cmfhfomceei2.BNIHFBMEPAB, Array.Empty<GUILayoutOption>());
			if (cmfhfomceei2.ODEIENGHLDE != cmfhfomceei2.KBLPAMBLIIH)
			{
				cmfhfomceei2.PFOGAHKPGKK.SetActive(cmfhfomceei2.ODEIENGHLDE);
				if (cmfhfomceei2.ODEIENGHLDE)
				{
					foreach (ParticleSystem particleSystem2 in cmfhfomceei2.MOAPBOLLILJ)
					{
						particleSystem2.Clear();
						particleSystem2.Play();
					}
					cmfhfomceei2.ODEIENGHLDE = this.DBLGLEBNIKE();
				}
				cmfhfomceei2.KBLPAMBLIIH = cmfhfomceei2.ODEIENGHLDE;
			}
		}
		IL_2C2:
		GUILayout.EndScrollView();
	}

	// Token: 0x06001EC9 RID: 7881 RVA: 0x000E9AF0 File Offset: 0x000E7CF0
	private void Update()
	{
		if (this.OEAJLCFFMMO != this.NHBPBBABBFA)
		{
			this.DJHLAGLMNGK();
			this.NHBPBBABBFA = this.OEAJLCFFMMO;
		}
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x000E9B14 File Offset: 0x000E7D14
	private bool LJIPLECHKFM()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.AJOOJPHOKDO)
		{
			cmfhfomceei.ODEIENGHLDE = false;
		}
		return false;
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x000E9B68 File Offset: 0x000E7D68
	private bool EICODNBBNEA()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
		}
		return true;
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x000E9BBC File Offset: 0x000E7DBC
	private void CKPNKKFIINO()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = false);
		this.OEAJLCFFMMO = ParticleTester.PHNGNGOCGNL.None;
		this.NHBPBBABBFA = ParticleTester.PHNGNGOCGNL.Explosions;
		this.particleSystems = Resources.LoadAll("u_isSave", typeof(GameObject));
		this.loadFlareSystems = Resources.LoadAll("", typeof(GameObject));
		this.loadDirectionalSystems = Resources.LoadAll("", typeof(GameObject));
		this.NCGPKGOKCMN = new List<ParticleTester.CMFHFOMCEEI>();
		this.AJOOJPHOKDO = new List<ParticleTester.CMFHFOMCEEI>();
		foreach (UnityEngine.Object @object in this.loadFlareSystems)
		{
			ParticleTester.CMFHFOMCEEI cmfhfomceei = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei.BNIHFBMEPAB = @object.name;
			cmfhfomceei.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(@object, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei.MOAPBOLLILJ = cmfhfomceei.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei.PFOGAHKPGKK.SetActive(false);
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.PFOGAHKPGKK.transform.parent = base.transform;
			this.NCGPKGOKCMN.Add(cmfhfomceei);
		}
		UnityEngine.Object[] array = this.loadDirectionalSystems;
		for (int i = 0; i < array.Length; i += 0)
		{
			UnityEngine.Object object2 = array[i];
			ParticleTester.CMFHFOMCEEI cmfhfomceei2 = new ParticleTester.CMFHFOMCEEI();
			cmfhfomceei2.BNIHFBMEPAB = object2.name;
			cmfhfomceei2.PFOGAHKPGKK = (UnityEngine.Object.Instantiate(object2, Vector3.zero, Quaternion.identity) as GameObject);
			cmfhfomceei2.MOAPBOLLILJ = cmfhfomceei2.PFOGAHKPGKK.GetComponentsInChildren<ParticleSystem>();
			cmfhfomceei2.PFOGAHKPGKK.SetActive(true);
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.PFOGAHKPGKK.transform.parent = base.transform;
			this.AJOOJPHOKDO.Add(cmfhfomceei2);
		}
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x000E9D84 File Offset: 0x000E7F84
	private bool MJAIJGMBJBB()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = (this.KOLKDNNJCAH = false));
		return false;
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x000E9DAC File Offset: 0x000E7FAC
	private void IICKDOPCOFE()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.KBLPAMBLIIH = false;
			cmfhfomceei.PFOGAHKPGKK.SetActive(false);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.KBLPAMBLIIH = true;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(true);
		}
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x000E9E64 File Offset: 0x000E8064
	private void CBBLGEDCJBF()
	{
		if (this.OEAJLCFFMMO != this.NHBPBBABBFA)
		{
			this.MJKNPMDCOMK();
			this.NHBPBBABBFA = this.OEAJLCFFMMO;
		}
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x000E9E88 File Offset: 0x000E8088
	private void DJHLAGLMNGK()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = false;
			cmfhfomceei.KBLPAMBLIIH = false;
			cmfhfomceei.PFOGAHKPGKK.SetActive(false);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.KBLPAMBLIIH = false;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
		}
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x000E9F40 File Offset: 0x000E8140
	private bool OJMEBHKDPKP()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.AJOOJPHOKDO)
		{
			cmfhfomceei.ODEIENGHLDE = false;
		}
		return true;
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x000E9F94 File Offset: 0x000E8194
	private bool BONIKHCAMLK()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = (this.KOLKDNNJCAH = true));
		return false;
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x000E9FBC File Offset: 0x000E81BC
	private bool BOOLKKJADEK()
	{
		this.KCEEADEGDIB = (this.OJKHPDAGKFH = (this.KOLKDNNJCAH = true));
		return false;
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x000E9FE4 File Offset: 0x000E81E4
	private bool JOBHJHOBDHP()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = false;
		}
		return true;
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x000EA038 File Offset: 0x000E8238
	private void MJKNPMDCOMK()
	{
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei in this.NCGPKGOKCMN)
		{
			cmfhfomceei.ODEIENGHLDE = true;
			cmfhfomceei.KBLPAMBLIIH = true;
			cmfhfomceei.PFOGAHKPGKK.SetActive(false);
		}
		foreach (ParticleTester.CMFHFOMCEEI cmfhfomceei2 in this.AJOOJPHOKDO)
		{
			cmfhfomceei2.ODEIENGHLDE = false;
			cmfhfomceei2.KBLPAMBLIIH = true;
			cmfhfomceei2.PFOGAHKPGKK.SetActive(false);
		}
	}

	// Token: 0x04000328 RID: 808
	private ParticleTester.PHNGNGOCGNL OEAJLCFFMMO;

	// Token: 0x04000329 RID: 809
	public UnityEngine.Object[] particleSystems;

	// Token: 0x0400032A RID: 810
	public UnityEngine.Object[] loadFlareSystems;

	// Token: 0x0400032B RID: 811
	public UnityEngine.Object[] loadDirectionalSystems;

	// Token: 0x0400032C RID: 812
	private List<ParticleTester.CMFHFOMCEEI> NCGPKGOKCMN;

	// Token: 0x0400032D RID: 813
	private List<ParticleTester.CMFHFOMCEEI> AJOOJPHOKDO;

	// Token: 0x0400032E RID: 814
	private bool KCEEADEGDIB;

	// Token: 0x0400032F RID: 815
	private bool OJKHPDAGKFH;

	// Token: 0x04000330 RID: 816
	private bool KOLKDNNJCAH;

	// Token: 0x04000331 RID: 817
	private Vector2 PGDIPMJOPLH;

	// Token: 0x04000332 RID: 818
	private ParticleTester.PHNGNGOCGNL NHBPBBABBFA;

	// Token: 0x02000084 RID: 132
	private enum PHNGNGOCGNL
	{
		// Token: 0x04000334 RID: 820
		None,
		// Token: 0x04000335 RID: 821
		Explosions,
		// Token: 0x04000336 RID: 822
		Flares,
		// Token: 0x04000337 RID: 823
		Flames
	}

	// Token: 0x02000085 RID: 133
	private class CMFHFOMCEEI
	{
		// Token: 0x04000338 RID: 824
		public string BNIHFBMEPAB;

		// Token: 0x04000339 RID: 825
		public GameObject PFOGAHKPGKK;

		// Token: 0x0400033A RID: 826
		public ParticleSystem[] MOAPBOLLILJ;

		// Token: 0x0400033B RID: 827
		public bool ODEIENGHLDE;

		// Token: 0x0400033C RID: 828
		public bool KBLPAMBLIIH;
	}
}
