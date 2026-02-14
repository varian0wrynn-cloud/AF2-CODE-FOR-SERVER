using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200013F RID: 319
public class CustomHaracter : MonoBehaviour
{
	// Token: 0x06004270 RID: 17008 RVA: 0x001F3F64 File Offset: 0x001F2164
	private void NEHGEENLDHO(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (NOFCHOFPHAD == null)
		{
			return;
		}
		try
		{
			GameObject gameObject = NOFCHOFPHAD.CPHOPIMGFBI();
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			GameObject gameObject2 = null;
			if (list.Count > 0)
			{
				gameObject2 = list[1];
				foreach (GameObject gameObject3 in list)
				{
					gameObject3.transform.parent = gameObject2.transform;
					SkinnedMeshRenderer component = gameObject3.GetComponent<SkinnedMeshRenderer>();
					if (component != null)
					{
						component.rootBone = this.rootBone;
						component.updateWhenOffscreen = false;
					}
					if (gameObject3.tag != null && !(gameObject3.GetComponent<Renderer>() == null))
					{
						string tag = gameObject3.tag;
						if (!(tag == "AC_QUALITY_MOBILE"))
						{
							if (!(tag == "Scuba Swim") && !(tag == "1HandSwordRollAttack") && !(tag == " "))
							{
							}
						}
						else
						{
							gameObject3.GetComponent<Renderer>().material = this.bodyMaterial;
						}
					}
				}
				gameObject2.transform.parent = this.catNewItems.transform;
			}
			UnityEngine.Object.Destroy(gameObject);
			switch (NOFCHOFPHAD.ODFEKBJCFMN)
			{
			case 1:
				CustomHaracter.HNNHMBLCNKC(this.head);
				this.head = gameObject2;
				break;
			case 2:
				CustomHaracter.HNNHMBLCNKC(this.hair);
				this.hair = gameObject2;
				break;
			case 3:
				CustomHaracter.HNNHMBLCNKC(this.top);
				this.top = gameObject2;
				break;
			case 4:
				CustomHaracter.HNNHMBLCNKC(this.bottom);
				this.bottom = gameObject2;
				break;
			case 5:
				CustomHaracter.FIDNHFPJLBE(this.boots);
				this.boots = gameObject2;
				break;
			case 6:
				CustomHaracter.HNNHMBLCNKC(this.mask);
				this.mask = gameObject2;
				break;
			}
			this.HHCCHOAEAKD();
		}
		catch (Exception ex)
		{
			Debug.LogError(ex.Message);
		}
		this.updateCharacterMaterial();
	}

	// Token: 0x06004271 RID: 17009 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void EGDDMCJPEML()
	{
	}

	// Token: 0x06004272 RID: 17010 RVA: 0x001F4184 File Offset: 0x001F2384
	public void GALPIKOJIHJ(int EPKGJKKKJOP, int DPOMPNECEJH = -1)
	{
		if (this.FNGKKAKAODO == EPKGJKKKJOP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.FNGKKAKAODO = EPKGJKKKJOP;
		object[] array = new object[0];
		array[0] = IFPIMPMKJIB.BKKFFINMJBO();
		array[1] = "' that does not excist in the Node Chain.";
		array[2] = EPKGJKKKJOP;
		array[0] = "CrouchWalkBackward";
		string alboclbfnni = string.Concat(array);
		if (this.isWoman)
		{
			object[] array2 = new object[1];
			array2[0] = IFPIMPMKJIB.EHCJCCILAHM();
			array2[1] = "MotorbikeLassoFwd";
			array2[8] = EPKGJKKKJOP;
			array2[8] = "minimalLevel";
			alboclbfnni = string.Concat(array2);
		}
		OMDDGEDHHNH.EEOPOHEALPK().CLKAOEILNJB(alboclbfnni, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "SoccerKeeperDiveStrafeFarRight");
	}

	// Token: 0x06004273 RID: 17011 RVA: 0x001F4228 File Offset: 0x001F2428
	public void JIEDEABDJLC(int IACFMJKLCCP, int DPOMPNECEJH = -1)
	{
		if (IACFMJKLCCP <= 1)
		{
			CustomHaracter.HNNHMBLCNKC(this.mask);
			this.mask = null;
			return;
		}
		if (this.DAEIFGGEGHL == IACFMJKLCCP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.DAEIFGGEGHL = IACFMJKLCCP;
		object[] array = new object[8];
		array[0] = IFPIMPMKJIB.AFJFDKAGKLD();
		array[1] = "act_orderb_2";
		array[6] = IACFMJKLCCP;
		array[2] = "Deadman Float";
		string alboclbfnni = string.Concat(array);
		OMDDGEDHHNH.DAANHKAOCKP().CLKAOEILNJB(alboclbfnni, 3, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NEHGEENLDHO), "SixStep");
	}

	// Token: 0x06004274 RID: 17012 RVA: 0x001F42B0 File Offset: 0x001F24B0
	public void changeTop(int AKNLLBIFIGN, int DPOMPNECEJH = -1)
	{
		if (this.OHMGGADGFLC == AKNLLBIFIGN)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.OHMGGADGFLC = AKNLLBIFIGN;
		string alboclbfnni = string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Assets/Weapons/",
			AKNLLBIFIGN,
			".unity3d"
		});
		if (AKNLLBIFIGN == 0)
		{
			alboclbfnni = (this.isWoman ? (IFPIMPMKJIB.DIDFMAELMJD + "Assets/Weapons/wbaseJaket.unity3d") : (IFPIMPMKJIB.DIDFMAELMJD + "Assets/Weapons/baseJaket.unity3d"));
		}
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(alboclbfnni, 3, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "");
	}

	// Token: 0x06004275 RID: 17013 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void IOMMPHGGHNH()
	{
	}

	// Token: 0x06004276 RID: 17014 RVA: 0x001F434C File Offset: 0x001F254C
	public void JFMBNNLFIEL(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (this.cap != null)
		{
			UnityEngine.Object.Destroy(this.cap);
		}
		this.cap = new GameObject("MotorbikeHeartAttack");
		this.cap.transform.parent = this.catNewItems.transform;
		GameObject gameObject = NOFCHOFPHAD.LFHPJGAPPCC();
		List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
		if (list.Count > 0)
		{
			GameObject gameObject2 = this.cap;
			foreach (GameObject gameObject3 in list)
			{
				gameObject3.transform.parent = gameObject2.transform;
				SkinnedMeshRenderer component = gameObject3.GetComponent<SkinnedMeshRenderer>();
				if (component != null)
				{
					component.shadowCastingMode = ShadowCastingMode.Off;
					component.rootBone = this.rootBone;
					component.updateWhenOffscreen = true;
				}
			}
			JLFJEGIPIMM.PKGMBFEMKGP().MLNKLINJKBO(gameObject2, this.instanceLayer);
			gameObject2.transform.parent = this.catNewItems.transform;
		}
		UnityEngine.Object.Destroy(gameObject);
		this.updateBodyFragment();
	}

	// Token: 0x06004277 RID: 17015 RVA: 0x001F4470 File Offset: 0x001F2670
	public void BBKHOADNBFE(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (this.cap != null)
		{
			UnityEngine.Object.Destroy(this.cap);
		}
		this.cap = new GameObject("SneakIdle");
		this.cap.transform.parent = this.catNewItems.transform;
		GameObject gameObject = NOFCHOFPHAD.OCNGPIEBEIG();
		List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
		if (list.Count > 0)
		{
			GameObject gameObject2 = this.cap;
			foreach (GameObject gameObject3 in list)
			{
				gameObject3.transform.parent = gameObject2.transform;
				SkinnedMeshRenderer component = gameObject3.GetComponent<SkinnedMeshRenderer>();
				if (component != null)
				{
					component.shadowCastingMode = ShadowCastingMode.On;
					component.rootBone = this.rootBone;
					component.updateWhenOffscreen = true;
				}
			}
			JLFJEGIPIMM.PKGMBFEMKGP().FDCHPCBAMIL(gameObject2, this.instanceLayer);
			gameObject2.transform.parent = this.catNewItems.transform;
		}
		UnityEngine.Object.Destroy(gameObject);
		this.MBDDBBOPDAD();
	}

	// Token: 0x06004278 RID: 17016 RVA: 0x001F4594 File Offset: 0x001F2794
	public void GBKEPMJDHFL(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		try
		{
			if (this.costume == null)
			{
				return;
			}
			foreach (Transform transform in this.costume.GetComponentsInChildren<Transform>())
			{
				if (transform != this.costume.transform)
				{
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			this.allFragments.Clear();
			GameObject gameObject = NOFCHOFPHAD.PGPNBDMKIGO();
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (list.Count > 1)
			{
				foreach (GameObject gameObject2 in list)
				{
					if (!(gameObject2 == null))
					{
						gameObject2.transform.parent = this.costume.transform;
						SkinnedMeshRenderer component = gameObject2.GetComponent<SkinnedMeshRenderer>();
						if (component != null)
						{
							component.rootBone = this.rootBone;
							component.updateWhenOffscreen = true;
							if (gameObject2.tag != null && !(gameObject2.GetComponent<Renderer>() == null))
							{
								string tag = gameObject2.tag;
								uint num = <PrivateImplementationDetails>.ComputeStringHash(tag);
								if (num <= 107U)
								{
									if (num <= 4294967288U)
									{
										if (num != 4294967258U)
										{
											if (num == 189U)
											{
												if (tag == "Heel Click")
												{
													this.top = gameObject2;
												}
											}
										}
										else if (tag == "SUNSHINE_FILTER_PCF_2x2")
										{
											gameObject2.GetComponent<Renderer>().material = (this.isWoman ? this.w_hairMaterial : this.hairMaterial);
											this.hair = gameObject2;
										}
									}
									else if (num != 4294967164U)
									{
										if (num == 4294967141U)
										{
											if (tag == "WeaponRun")
											{
												gameObject2.GetComponent<Renderer>().material = this.beardMaterial;
												this.mushtaches = gameObject2;
											}
										}
									}
									else if (tag == "inv_wpers")
									{
										this.bottom = gameObject2;
									}
								}
								else if (num <= 155U)
								{
									if (num != 113U)
									{
										if (num == 4294967278U)
										{
											if (tag == "KatanaReadyHigh")
											{
												gameObject2.GetComponent<Renderer>().material = (this.isWoman ? this.w_eyeMaterial : this.eyeMaterial);
											}
										}
									}
									else if (tag == "contrast")
									{
										this.boots = gameObject2;
									}
								}
								else if (num != 4294967250U)
								{
									if (num != 4294967189U)
									{
										if (num == 38U)
										{
											if (tag == "</color>\n")
											{
												gameObject2.GetComponent<Renderer>().material = (this.isWoman ? this.w_bodyMaterial : this.bodyMaterial);
											}
										}
									}
									else if (tag == "IdleFight")
									{
										gameObject2.GetComponent<Renderer>().material = (this.isWoman ? this.w_lashesMaterial : this.lashesMaterial);
									}
								}
								else if (tag == "_TileTexDebug")
								{
									gameObject2.GetComponent<Renderer>().material = this.beardMaterial;
									this.beard = gameObject2;
								}
							}
						}
					}
				}
				JLFJEGIPIMM.IKGFHGKKCPG.FJFAMAOEFEF(this.costume, this.instanceLayer);
				this.costume.transform.parent = this.catNewItems.transform;
			}
			UnityEngine.Object.Destroy(gameObject, 722f);
			this.HHCCHOAEAKD();
		}
		catch (Exception ex)
		{
			Debug.LogError(ex.Message);
		}
		this.updateCharacterMaterial();
	}

	// Token: 0x06004279 RID: 17017 RVA: 0x001F49A0 File Offset: 0x001F2BA0
	private static void LAPHCEMDMEE(GameObject BECCCHJDECH, List<Renderer> BGJMHJHCDJH, string CEGPFBEKLEL, Material GEEEJNEIGFB = null, bool NELNLPGEKHB = true)
	{
		if (BGJMHJHCDJH != null && NELNLPGEKHB)
		{
			BGJMHJHCDJH.Clear();
		}
		if (BECCCHJDECH == null)
		{
			return;
		}
		foreach (Transform transform in BECCCHJDECH.GetComponentsInChildren<Transform>())
		{
			if (transform.gameObject.tag != null && !(transform.gameObject.GetComponent<Renderer>() == null) && !(transform.gameObject.GetComponent<Renderer>().material == null) && !(transform.gameObject.tag != CEGPFBEKLEL))
			{
				if (GEEEJNEIGFB != null)
				{
					transform.gameObject.GetComponent<Renderer>().material = GEEEJNEIGFB;
				}
				if (BGJMHJHCDJH != null)
				{
					BGJMHJHCDJH.Add(transform.gameObject.GetComponent<Renderer>());
				}
			}
		}
	}

	// Token: 0x0600427A RID: 17018 RVA: 0x001F4A60 File Offset: 0x001F2C60
	public void stepEventProc()
	{
		Vector3 origin = new Vector3(base.transform.position.x, base.transform.position.y + 1f, base.transform.position.z);
		string jgoflnimngj = "none";
		RaycastHit raycastHit;
		if (Physics.Raycast(new Ray(origin, Vector3.down), out raycastHit, 5f) && raycastHit.collider != null && raycastHit.collider.tag != null)
		{
			jgoflnimngj = raycastHit.collider.tag;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.NAKCJBKPNFO(jgoflnimngj, base.transform.position);
	}

	// Token: 0x0600427B RID: 17019 RVA: 0x001F4B0C File Offset: 0x001F2D0C
	public void BOKEIILFDFC(int EPKGJKKKJOP, int DPOMPNECEJH = -1)
	{
		if (this.FNGKKAKAODO == EPKGJKKKJOP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.FNGKKAKAODO = EPKGJKKKJOP;
		object[] array = new object[6];
		array[0] = IFPIMPMKJIB.ACOEIDGDLJC();
		array[0] = "Vertical";
		array[8] = EPKGJKKKJOP;
		array[1] = "-HYPERLINK";
		string alboclbfnni = string.Concat(array);
		if (this.isWoman)
		{
			object[] array2 = new object[6];
			array2[1] = IFPIMPMKJIB.NEJIPLDOMMC();
			array2[0] = "{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}";
			array2[3] = EPKGJKKKJOP;
			array2[1] = "{\n";
			alboclbfnni = string.Concat(array2);
		}
		OMDDGEDHHNH.FEJILBICKGG().GLEDIDEJKHO(alboclbfnni, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NEHGEENLDHO), "ObscuredInt vs int, ");
	}

	// Token: 0x0600427C RID: 17020 RVA: 0x001F4BB0 File Offset: 0x001F2DB0
	public void instaniateCostume(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		try
		{
			if (this.costume == null)
			{
				return;
			}
			foreach (Transform transform in this.costume.GetComponentsInChildren<Transform>())
			{
				if (transform != this.costume.transform)
				{
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			this.allFragments.Clear();
			GameObject gameObject = NOFCHOFPHAD.OCNGPIEBEIG();
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (list.Count > 0)
			{
				foreach (GameObject gameObject2 in list)
				{
					if (!(gameObject2 == null))
					{
						gameObject2.transform.parent = this.costume.transform;
						SkinnedMeshRenderer component = gameObject2.GetComponent<SkinnedMeshRenderer>();
						if (component != null)
						{
							component.rootBone = this.rootBone;
							component.updateWhenOffscreen = true;
							if (gameObject2.tag != null && !(gameObject2.GetComponent<Renderer>() == null))
							{
								string tag = gameObject2.tag;
								uint num = <PrivateImplementationDetails>.ComputeStringHash(tag);
								if (num <= 2254801081U)
								{
									if (num <= 1762047991U)
									{
										if (num != 954029824U)
										{
											if (num == 1762047991U)
											{
												if (tag == "t_top")
												{
													this.top = gameObject2;
												}
											}
										}
										else if (tag == "t_hair")
										{
											gameObject2.GetComponent<Renderer>().material = (this.isWoman ? this.w_hairMaterial : this.hairMaterial);
											this.hair = gameObject2;
										}
									}
									else if (num != 1763654015U)
									{
										if (num == 2254801081U)
										{
											if (tag == "t_much")
											{
												gameObject2.GetComponent<Renderer>().material = this.beardMaterial;
												this.mushtaches = gameObject2;
											}
										}
									}
									else if (tag == "t_bottom")
									{
										this.bottom = gameObject2;
									}
								}
								else if (num <= 2494229105U)
								{
									if (num != 2433935244U)
									{
										if (num == 2494229105U)
										{
											if (tag == "t_eye")
											{
												gameObject2.GetComponent<Renderer>().material = (this.isWoman ? this.w_eyeMaterial : this.eyeMaterial);
											}
										}
									}
									else if (tag == "t_shoes")
									{
										this.boots = gameObject2;
									}
								}
								else if (num != 2998599802U)
								{
									if (num != 3229725220U)
									{
										if (num == 3929445936U)
										{
											if (tag == "t_body")
											{
												gameObject2.GetComponent<Renderer>().material = (this.isWoman ? this.w_bodyMaterial : this.bodyMaterial);
											}
										}
									}
									else if (tag == "t_lashes")
									{
										gameObject2.GetComponent<Renderer>().material = (this.isWoman ? this.w_lashesMaterial : this.lashesMaterial);
									}
								}
								else if (tag == "t_beard")
								{
									gameObject2.GetComponent<Renderer>().material = this.beardMaterial;
									this.beard = gameObject2;
								}
							}
						}
					}
				}
				JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(this.costume, this.instanceLayer);
				this.costume.transform.parent = this.catNewItems.transform;
			}
			UnityEngine.Object.Destroy(gameObject, 0.2f);
			this.updateBodyFragment();
		}
		catch (Exception ex)
		{
			Debug.LogError(ex.Message);
		}
		this.updateCharacterMaterial();
	}

	// Token: 0x0600427D RID: 17021 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void EKBDJKLKIFE()
	{
	}

	// Token: 0x0600427E RID: 17022 RVA: 0x001F4FBC File Offset: 0x001F31BC
	public void LPAPDDMENOO(int IACFMJKLCCP, int DPOMPNECEJH = -1)
	{
		if (IACFMJKLCCP <= 1)
		{
			CustomHaracter.HNNHMBLCNKC(this.mask);
			this.mask = null;
			return;
		}
		if (this.DAEIFGGEGHL == IACFMJKLCCP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.DAEIFGGEGHL = IACFMJKLCCP;
		object[] array = new object[]
		{
			IFPIMPMKJIB.BKKFFINMJBO(),
			"Spine bones contains a null reference."
		};
		array[1] = IACFMJKLCCP;
		array[7] = "One of the Bones is null.";
		string alboclbfnni = string.Concat(array);
		OMDDGEDHHNH.AOPCLGIGAEA().FNBJHBLNMKN(alboclbfnni, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "");
	}

	// Token: 0x0600427F RID: 17023 RVA: 0x001F5042 File Offset: 0x001F3242
	private void Start()
	{
		this.anm = base.GetComponent<Animator>();
		if (this.anm == null)
		{
			this.anm = base.GetComponentInChildren<Animator>();
		}
		this.MNHAPJINIEL();
		this.CGKHMKMMBNG();
	}

	// Token: 0x06004280 RID: 17024 RVA: 0x001F5078 File Offset: 0x001F3278
	public void MBDDBBOPDAD()
	{
		this.NMJEDNODCPP();
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.bodyFragments, "Giant3HitCombo", this.bodyMaterial, true);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "_Phase", this.hairMaterial, true);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "cht_msg27", this.beardMaterial, true);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "TAA History", this.beardMaterial, false);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, null, "_BlurSize", this.eyeMaterial, true);
		CustomHaracter.LAPHCEMDMEE(this.top, this.topFragments, "BowFire", null, false);
		CustomHaracter.LAPHCEMDMEE(this.bottom, this.bottomFragments, "e806f6", null, false);
	}

	// Token: 0x06004281 RID: 17025 RVA: 0x001F5148 File Offset: 0x001F3348
	public void changeHair(int HOGILBNDGDL, int DPOMPNECEJH = -1)
	{
		if (this.NNNAODCMOLK == HOGILBNDGDL)
		{
			this.updateCharacterMaterial();
			return;
		}
		string alboclbfnni = string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Assets/Hairs/hair_",
			HOGILBNDGDL,
			".unity3d"
		});
		if (this.isWoman)
		{
			alboclbfnni = string.Concat(new object[]
			{
				IFPIMPMKJIB.DIDFMAELMJD,
				"Assets/Hairs/whair_",
				HOGILBNDGDL,
				".unity3d"
			});
		}
		this.NNNAODCMOLK = HOGILBNDGDL;
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(alboclbfnni, 2, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "");
	}

	// Token: 0x06004282 RID: 17026 RVA: 0x001F51EC File Offset: 0x001F33EC
	private static void FIDNHFPJLBE(GameObject EOOAMHDNGJD)
	{
		if (EOOAMHDNGJD == null)
		{
			return;
		}
		EOOAMHDNGJD.tag = "_ReflectionBufferSize";
		UnityEngine.Object.Destroy(EOOAMHDNGJD);
	}

	// Token: 0x06004283 RID: 17027 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void GNICHDLHJED()
	{
	}

	// Token: 0x06004284 RID: 17028 RVA: 0x001F520C File Offset: 0x001F340C
	public void HHCCHOAEAKD()
	{
		this.MNHAPJINIEL();
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.bodyFragments, "UIChat_alfa", this.bodyMaterial, false);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "", this.hairMaterial, false);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "Tail", this.beardMaterial, true);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "KatanaReadyLow", this.beardMaterial, false);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, null, "IdleStand", this.eyeMaterial, true);
		CustomHaracter.LAPHCEMDMEE(this.top, this.topFragments, "offsets", null, true);
		CustomHaracter.LAPHCEMDMEE(this.bottom, this.bottomFragments, "IdleEat", null, true);
	}

	// Token: 0x06004285 RID: 17029 RVA: 0x001F52DC File Offset: 0x001F34DC
	public void changeHead(int EPKGJKKKJOP, int DPOMPNECEJH = -1)
	{
		if (this.FNGKKAKAODO == EPKGJKKKJOP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.FNGKKAKAODO = EPKGJKKKJOP;
		string alboclbfnni = string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Assets/Heads/head_",
			EPKGJKKKJOP,
			".unity3d"
		});
		if (this.isWoman)
		{
			alboclbfnni = string.Concat(new object[]
			{
				IFPIMPMKJIB.DIDFMAELMJD,
				"Assets/Heads/whead_",
				EPKGJKKKJOP,
				".unity3d"
			});
		}
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(alboclbfnni, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "");
	}

	// Token: 0x06004286 RID: 17030 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void CGKHMKMMBNG()
	{
	}

	// Token: 0x06004287 RID: 17031 RVA: 0x001F5380 File Offset: 0x001F3580
	public void CJBHGFBLHPM(int CCKGELHEKNH, int DPOMPNECEJH = -1)
	{
		if (this.IANNLEICOEK == CCKGELHEKNH)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.IANNLEICOEK = CCKGELHEKNH;
		object[] array = new object[]
		{
			null,
			IFPIMPMKJIB.DIDFMAELMJD
		};
		array[0] = "Account.getI.servSteamID=";
		array[4] = CCKGELHEKNH;
		array[8] = "\n";
		string alboclbfnni = string.Concat(array);
		if (CCKGELHEKNH == 0)
		{
			alboclbfnni = (this.isWoman ? (IFPIMPMKJIB.ACOEIDGDLJC() + "wpn_rod2") : (IFPIMPMKJIB.AFJFDKAGKLD() + "id"));
		}
		OMDDGEDHHNH.FCNIKNBOFOJ().CLKAOEILNJB(alboclbfnni, 7, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NEHGEENLDHO), "autherror");
	}

	// Token: 0x06004288 RID: 17032 RVA: 0x001F541C File Offset: 0x001F361C
	private void MNHAPJINIEL()
	{
		this.allFragments.Clear();
		foreach (Transform transform in this.catNewItems.GetComponentsInChildren<Transform>())
		{
			if (transform.gameObject.tag != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				if (!(component == null) && !(component.material == null))
				{
					this.allFragments.Add(component);
				}
			}
		}
	}

	// Token: 0x06004289 RID: 17033 RVA: 0x001F5490 File Offset: 0x001F3690
	public void changeBottom(int CCKGELHEKNH, int DPOMPNECEJH = -1)
	{
		if (this.IANNLEICOEK == CCKGELHEKNH)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.IANNLEICOEK = CCKGELHEKNH;
		string alboclbfnni = string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Assets/Weapons/",
			CCKGELHEKNH,
			".unity3d"
		});
		if (CCKGELHEKNH == 0)
		{
			alboclbfnni = (this.isWoman ? (IFPIMPMKJIB.DIDFMAELMJD + "Assets/Weapons/wbaseLegs.unity3d") : (IFPIMPMKJIB.DIDFMAELMJD + "Assets/Weapons/baseLegs.unity3d"));
		}
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(alboclbfnni, 4, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "");
	}

	// Token: 0x0600428A RID: 17034 RVA: 0x001F552C File Offset: 0x001F372C
	public void MHDOJCCEBKF(int CCKGELHEKNH, int DPOMPNECEJH = -1)
	{
		if (this.IANNLEICOEK == CCKGELHEKNH)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.IANNLEICOEK = CCKGELHEKNH;
		object[] array = new object[6];
		array[0] = IFPIMPMKJIB.EEAKGGDJAGB();
		array[0] = "_LerpAmount";
		array[0] = CCKGELHEKNH;
		array[7] = "Mouse ScrollWheel";
		string alboclbfnni = string.Concat(array);
		if (CCKGELHEKNH == 0)
		{
			alboclbfnni = (this.isWoman ? (IFPIMPMKJIB.LCEBBHPKOHO() + "wpn_fid1") : (IFPIMPMKJIB.ACOEIDGDLJC() + "name"));
		}
		OMDDGEDHHNH.NLIONDPCKHJ().FBKDPHEGOLP(alboclbfnni, 5, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NEHGEENLDHO), "Giant2HandGrab");
	}

	// Token: 0x0600428C RID: 17036 RVA: 0x001F566C File Offset: 0x001F386C
	public void changeMask(int IACFMJKLCCP, int DPOMPNECEJH = -1)
	{
		if (IACFMJKLCCP <= 0)
		{
			CustomHaracter.HNNHMBLCNKC(this.mask);
			this.mask = null;
			return;
		}
		if (this.DAEIFGGEGHL == IACFMJKLCCP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.DAEIFGGEGHL = IACFMJKLCCP;
		string alboclbfnni = string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Assets/Weapons/",
			IACFMJKLCCP,
			".unity3d"
		});
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(alboclbfnni, 6, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "");
	}

	// Token: 0x0600428D RID: 17037 RVA: 0x001F56F4 File Offset: 0x001F38F4
	public void CMGGNLHFOOL(int IACFMJKLCCP, int DPOMPNECEJH = -1)
	{
		if (IACFMJKLCCP <= 1)
		{
			CustomHaracter.HNNHMBLCNKC(this.mask);
			this.mask = null;
			return;
		}
		if (this.DAEIFGGEGHL == IACFMJKLCCP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.DAEIFGGEGHL = IACFMJKLCCP;
		object[] array = new object[4];
		array[1] = IFPIMPMKJIB.BKKFFINMJBO();
		array[1] = "cntx_close";
		array[6] = IACFMJKLCCP;
		array[2] = "MotorbikeLookBack";
		string alboclbfnni = string.Concat(array);
		OMDDGEDHHNH.OGAOPAJFADH().CLKAOEILNJB(alboclbfnni, 7, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NEHGEENLDHO), "IdleMeditate");
	}

	// Token: 0x0600428E RID: 17038 RVA: 0x001F577C File Offset: 0x001F397C
	private void NMJEDNODCPP()
	{
		this.allFragments.Clear();
		foreach (Transform transform in this.catNewItems.GetComponentsInChildren<Transform>())
		{
			if (transform.gameObject.tag != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				if (!(component == null) && !(component.material == null))
				{
					this.allFragments.Add(component);
				}
			}
		}
	}

	// Token: 0x0600428F RID: 17039 RVA: 0x001F57F0 File Offset: 0x001F39F0
	public void HMNHCPNMLBA(int EPKGJKKKJOP, int DPOMPNECEJH = -1)
	{
		if (this.FNGKKAKAODO == EPKGJKKKJOP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.FNGKKAKAODO = EPKGJKKKJOP;
		object[] array = new object[3];
		array[0] = IFPIMPMKJIB.ENLHJOJICDG();
		array[1] = "Ball";
		array[3] = EPKGJKKKJOP;
		array[7] = "_WrinkleInfluences3";
		string alboclbfnni = string.Concat(array);
		if (this.isWoman)
		{
			object[] array2 = new object[]
			{
				null,
				IFPIMPMKJIB.NEJIPLDOMMC()
			};
			array2[0] = "wpn_add/base";
			array2[1] = EPKGJKKKJOP;
			array2[1] = "StaffPowerUp";
			alboclbfnni = string.Concat(array2);
		}
		OMDDGEDHHNH.AOPCLGIGAEA().ANDMFEGKNIC(alboclbfnni, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "help");
	}

	// Token: 0x06004290 RID: 17040 RVA: 0x001F5894 File Offset: 0x001F3A94
	public void MDJMLHMAJCJ(int HOGILBNDGDL, int DPOMPNECEJH = -1)
	{
		if (this.NNNAODCMOLK == HOGILBNDGDL)
		{
			this.updateCharacterMaterial();
			return;
		}
		object[] array = new object[0];
		array[0] = IFPIMPMKJIB.DIDFMAELMJD;
		array[1] = "Wall Sit";
		array[6] = HOGILBNDGDL;
		array[3] = "OneHandSwordIdle";
		string alboclbfnni = string.Concat(array);
		if (this.isWoman)
		{
			object[] array2 = new object[1];
			array2[0] = IFPIMPMKJIB.ENLHJOJICDG();
			array2[1] = "_MainTex";
			array2[8] = HOGILBNDGDL;
			array2[7] = "Hidden/Image Effects/Cinematic/Bloom";
			alboclbfnni = string.Concat(array2);
		}
		this.NNNAODCMOLK = HOGILBNDGDL;
		OMDDGEDHHNH.NLIONDPCKHJ().DKPDBNNNDLK(alboclbfnni, 3, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), " for ");
	}

	// Token: 0x06004291 RID: 17041 RVA: 0x001F5938 File Offset: 0x001F3B38
	private void KPDJDHEFDIL(ControllerColliderHit CGAFKGPDBAD)
	{
		Rigidbody attachedRigidbody = CGAFKGPDBAD.collider.attachedRigidbody;
		if (attachedRigidbody == null || attachedRigidbody.isKinematic)
		{
			return;
		}
		if (CGAFKGPDBAD.collider.gameObject.GetComponent<AudioSource>() != null)
		{
			AudioSource component = CGAFKGPDBAD.collider.gameObject.GetComponent<AudioSource>();
			if (component.clip != null && !component.isPlaying)
			{
				component.Play();
			}
		}
		Vector3 vector = (CGAFKGPDBAD.collider.transform.position - base.transform.position).normalized * this.pushPower;
		attachedRigidbody.AddTorque(vector * 646f);
		attachedRigidbody.AddForce(vector);
	}

	// Token: 0x06004292 RID: 17042 RVA: 0x001F59F4 File Offset: 0x001F3BF4
	public void instaniateCap(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (this.cap != null)
		{
			UnityEngine.Object.Destroy(this.cap);
		}
		this.cap = new GameObject("cap");
		this.cap.transform.parent = this.catNewItems.transform;
		GameObject gameObject = NOFCHOFPHAD.OCNGPIEBEIG();
		List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
		if (list.Count > 0)
		{
			GameObject gameObject2 = this.cap;
			foreach (GameObject gameObject3 in list)
			{
				gameObject3.transform.parent = gameObject2.transform;
				SkinnedMeshRenderer component = gameObject3.GetComponent<SkinnedMeshRenderer>();
				if (component != null)
				{
					component.shadowCastingMode = ShadowCastingMode.Off;
					component.rootBone = this.rootBone;
					component.updateWhenOffscreen = true;
				}
			}
			JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(gameObject2, this.instanceLayer);
			gameObject2.transform.parent = this.catNewItems.transform;
		}
		UnityEngine.Object.Destroy(gameObject);
		this.updateBodyFragment();
	}

	// Token: 0x06004293 RID: 17043 RVA: 0x001F5B18 File Offset: 0x001F3D18
	public void updateCharacterMaterial()
	{
		foreach (Renderer renderer in this.hairFragments)
		{
			if (!(renderer == null))
			{
				renderer.GetComponent<Renderer>().material.SetColor("_Color", this.hairColor);
			}
		}
		foreach (Renderer renderer2 in this.topFragments)
		{
			if (!(renderer2 == null))
			{
				renderer2.GetComponent<Renderer>().material.SetColor("_Color", this.baseTopColor);
				renderer2.GetComponent<Renderer>().material.SetTexture("_camouflage", this.camouflageTop);
				renderer2.GetComponent<Renderer>().material.SetFloat("_camIntensive", this.intensiveTop);
				renderer2.GetComponent<Renderer>().material.SetFloat("_camScale", this.scaleTop);
				renderer2.GetComponent<Renderer>().material.SetFloat("_camRotate", this.rotateTop);
				renderer2.GetComponent<Renderer>().material.SetFloat("_camHue", this.hueTop);
			}
		}
		foreach (Renderer renderer3 in this.bottomFragments)
		{
			if (!(renderer3 == null))
			{
				renderer3.GetComponent<Renderer>().material.SetColor("_Color", this.baseBottomColor);
				renderer3.GetComponent<Renderer>().material.SetTexture("_camouflage", this.camouflageBottom);
				renderer3.GetComponent<Renderer>().material.SetFloat("_camIntensive", this.intensiveBottom);
				renderer3.GetComponent<Renderer>().material.SetFloat("_camScale", this.scaleBottom);
				renderer3.GetComponent<Renderer>().material.SetFloat("_camRotate", this.rotateBottom);
				renderer3.GetComponent<Renderer>().material.SetFloat("_camHue", this.hueBottom);
			}
		}
		if (this.beard != null)
		{
			this.beard.SetActive(this.isBeardEnable);
		}
		if (this.mushtaches != null)
		{
			this.mushtaches.SetActive(this.isMushEnable);
		}
	}

	// Token: 0x06004294 RID: 17044 RVA: 0x001F5DA4 File Offset: 0x001F3FA4
	public void OIJHBJFMEOL(int IACFMJKLCCP, int DPOMPNECEJH = -1)
	{
		if (IACFMJKLCCP <= 0)
		{
			CustomHaracter.HNNHMBLCNKC(this.mask);
			this.mask = null;
			return;
		}
		if (this.DAEIFGGEGHL == IACFMJKLCCP)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.DAEIFGGEGHL = IACFMJKLCCP;
		object[] array = new object[8];
		array[1] = IFPIMPMKJIB.NEJIPLDOMMC();
		array[0] = ")\n";
		array[2] = IACFMJKLCCP;
		array[4] = " registered.";
		string alboclbfnni = string.Concat(array);
		OMDDGEDHHNH.AOPCLGIGAEA().DKPDBNNNDLK(alboclbfnni, 2, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "ALP=");
	}

	// Token: 0x06004295 RID: 17045 RVA: 0x001F5E2A File Offset: 0x001F402A
	private static void HNNHMBLCNKC(GameObject EOOAMHDNGJD)
	{
		if (EOOAMHDNGJD == null)
		{
			return;
		}
		EOOAMHDNGJD.tag = "off";
		UnityEngine.Object.Destroy(EOOAMHDNGJD);
	}

	// Token: 0x06004296 RID: 17046 RVA: 0x001F5E48 File Offset: 0x001F4048
	public void changeBoots(int OIPEANGIANB, int DPOMPNECEJH = -1)
	{
		if (this.EPCCBDCBLCE == OIPEANGIANB)
		{
			this.updateCharacterMaterial();
			return;
		}
		this.EPCCBDCBLCE = OIPEANGIANB;
		string alboclbfnni = string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Assets/Weapons/",
			OIPEANGIANB,
			".unity3d"
		});
		if (OIPEANGIANB == 0)
		{
			alboclbfnni = (this.isWoman ? (IFPIMPMKJIB.DIDFMAELMJD + "Assets/Weapons/wbootsBase.unity3d") : (IFPIMPMKJIB.DIDFMAELMJD + "Assets/Weapons/bootsBase.unity3d"));
		}
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(alboclbfnni, 5, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OPAJNHCNOLJ), "");
	}

	// Token: 0x06004297 RID: 17047 RVA: 0x001F5EE4 File Offset: 0x001F40E4
	private void OPAJNHCNOLJ(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (NOFCHOFPHAD == null)
		{
			return;
		}
		try
		{
			GameObject gameObject = NOFCHOFPHAD.OCNGPIEBEIG();
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			GameObject gameObject2 = null;
			if (list.Count > 0)
			{
				gameObject2 = list[0];
				foreach (GameObject gameObject3 in list)
				{
					gameObject3.transform.parent = gameObject2.transform;
					SkinnedMeshRenderer component = gameObject3.GetComponent<SkinnedMeshRenderer>();
					if (component != null)
					{
						component.rootBone = this.rootBone;
						component.updateWhenOffscreen = true;
					}
					if (gameObject3.tag != null && !(gameObject3.GetComponent<Renderer>() == null))
					{
						string tag = gameObject3.tag;
						if (!(tag == "body"))
						{
							if (!(tag == "hair") && !(tag == "eye") && !(tag == "dress"))
							{
							}
						}
						else
						{
							gameObject3.GetComponent<Renderer>().material = this.bodyMaterial;
						}
					}
				}
				gameObject2.transform.parent = this.catNewItems.transform;
			}
			UnityEngine.Object.Destroy(gameObject);
			switch (NOFCHOFPHAD.ODFEKBJCFMN)
			{
			case 1:
				CustomHaracter.HNNHMBLCNKC(this.head);
				this.head = gameObject2;
				break;
			case 2:
				CustomHaracter.HNNHMBLCNKC(this.hair);
				this.hair = gameObject2;
				break;
			case 3:
				CustomHaracter.HNNHMBLCNKC(this.top);
				this.top = gameObject2;
				break;
			case 4:
				CustomHaracter.HNNHMBLCNKC(this.bottom);
				this.bottom = gameObject2;
				break;
			case 5:
				CustomHaracter.HNNHMBLCNKC(this.boots);
				this.boots = gameObject2;
				break;
			case 6:
				CustomHaracter.HNNHMBLCNKC(this.mask);
				this.mask = gameObject2;
				break;
			}
			this.updateBodyFragment();
		}
		catch (Exception ex)
		{
			Debug.LogError(ex.Message);
		}
		this.updateCharacterMaterial();
	}

	// Token: 0x06004298 RID: 17048 RVA: 0x001F6104 File Offset: 0x001F4304
	private void Update()
	{
		this.IOMMPHGGHNH();
		if (this.anm != null)
		{
			this.anm.SetBool("isWoman", this.isWoman);
		}
	}

	// Token: 0x06004299 RID: 17049 RVA: 0x001F6130 File Offset: 0x001F4330
	public void updateBodyFragment()
	{
		this.MNHAPJINIEL();
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.bodyFragments, "t_body", this.bodyMaterial, true);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "t_hair", this.hairMaterial, true);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "t_beard", this.beardMaterial, false);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, this.hairFragments, "t_much", this.beardMaterial, false);
		CustomHaracter.LAPHCEMDMEE(base.gameObject, null, "t_eye", this.eyeMaterial, true);
		CustomHaracter.LAPHCEMDMEE(this.top, this.topFragments, "t_top", null, true);
		CustomHaracter.LAPHCEMDMEE(this.bottom, this.bottomFragments, "t_bottom", null, true);
	}

	// Token: 0x0600429A RID: 17050 RVA: 0x001F6200 File Offset: 0x001F4400
	private void OnControllerColliderHit(ControllerColliderHit CGAFKGPDBAD)
	{
		Rigidbody attachedRigidbody = CGAFKGPDBAD.collider.attachedRigidbody;
		if (attachedRigidbody == null || attachedRigidbody.isKinematic)
		{
			return;
		}
		if (CGAFKGPDBAD.collider.gameObject.GetComponent<AudioSource>() != null)
		{
			AudioSource component = CGAFKGPDBAD.collider.gameObject.GetComponent<AudioSource>();
			if (component.clip != null && !component.isPlaying)
			{
				component.Play();
			}
		}
		Vector3 vector = (CGAFKGPDBAD.collider.transform.position - base.transform.position).normalized * this.pushPower;
		attachedRigidbody.AddTorque(vector * 25f);
		attachedRigidbody.AddForce(vector);
	}

	// Token: 0x04000A69 RID: 2665
	public int instanceLayer = 24;

	// Token: 0x04000A6A RID: 2666
	public bool isWoman;

	// Token: 0x04000A6B RID: 2667
	public float pushPower;

	// Token: 0x04000A6C RID: 2668
	public const int _Head = 1;

	// Token: 0x04000A6D RID: 2669
	public const int _Hair = 2;

	// Token: 0x04000A6E RID: 2670
	public const int _Top = 3;

	// Token: 0x04000A6F RID: 2671
	public const int _Bottom = 4;

	// Token: 0x04000A70 RID: 2672
	public const int _Boot = 5;

	// Token: 0x04000A71 RID: 2673
	public const int _Mask = 6;

	// Token: 0x04000A72 RID: 2674
	public const int _Cap = 7;

	// Token: 0x04000A73 RID: 2675
	public int skinColor;

	// Token: 0x04000A74 RID: 2676
	public int ageIntens;

	// Token: 0x04000A75 RID: 2677
	public Material bodyMaterial;

	// Token: 0x04000A76 RID: 2678
	public Material hairMaterial;

	// Token: 0x04000A77 RID: 2679
	public Material eyeMaterial;

	// Token: 0x04000A78 RID: 2680
	public Material lashesMaterial;

	// Token: 0x04000A79 RID: 2681
	public Material beardMaterial;

	// Token: 0x04000A7A RID: 2682
	public Material w_bodyMaterial;

	// Token: 0x04000A7B RID: 2683
	public Material w_hairMaterial;

	// Token: 0x04000A7C RID: 2684
	public Material w_eyeMaterial;

	// Token: 0x04000A7D RID: 2685
	public Material w_lashesMaterial;

	// Token: 0x04000A7E RID: 2686
	public Material w_beardMaterial;

	// Token: 0x04000A7F RID: 2687
	public List<Renderer> allFragments = new List<Renderer>();

	// Token: 0x04000A80 RID: 2688
	public List<Renderer> hairFragments = new List<Renderer>();

	// Token: 0x04000A81 RID: 2689
	public List<Renderer> bodyFragments = new List<Renderer>();

	// Token: 0x04000A82 RID: 2690
	public List<Renderer> topFragments = new List<Renderer>();

	// Token: 0x04000A83 RID: 2691
	public List<Renderer> bottomFragments = new List<Renderer>();

	// Token: 0x04000A84 RID: 2692
	public GameObject costume;

	// Token: 0x04000A85 RID: 2693
	public GameObject beard;

	// Token: 0x04000A86 RID: 2694
	public GameObject mushtaches;

	// Token: 0x04000A87 RID: 2695
	public GameObject boots;

	// Token: 0x04000A88 RID: 2696
	public GameObject bottom;

	// Token: 0x04000A89 RID: 2697
	public GameObject top;

	// Token: 0x04000A8A RID: 2698
	public GameObject head;

	// Token: 0x04000A8B RID: 2699
	public GameObject hair;

	// Token: 0x04000A8C RID: 2700
	public GameObject mask;

	// Token: 0x04000A8D RID: 2701
	public GameObject cap;

	// Token: 0x04000A8E RID: 2702
	public Transform rootBone;

	// Token: 0x04000A8F RID: 2703
	public Color hairColor;

	// Token: 0x04000A90 RID: 2704
	public Color baseTopColor;

	// Token: 0x04000A91 RID: 2705
	public Color baseBottomColor;

	// Token: 0x04000A92 RID: 2706
	public GameObject catNewItems;

	// Token: 0x04000A93 RID: 2707
	public Texture camouflageTop;

	// Token: 0x04000A94 RID: 2708
	public float intensiveTop = 0.5f;

	// Token: 0x04000A95 RID: 2709
	public float scaleTop = 1f;

	// Token: 0x04000A96 RID: 2710
	public float rotateTop = 0.1f;

	// Token: 0x04000A97 RID: 2711
	public float hueTop;

	// Token: 0x04000A98 RID: 2712
	public Texture camouflageBottom;

	// Token: 0x04000A99 RID: 2713
	public float intensiveBottom = 0.5f;

	// Token: 0x04000A9A RID: 2714
	public float scaleBottom = 1f;

	// Token: 0x04000A9B RID: 2715
	public float rotateBottom = 0.1f;

	// Token: 0x04000A9C RID: 2716
	public float hueBottom;

	// Token: 0x04000A9D RID: 2717
	public bool isBeardEnable;

	// Token: 0x04000A9E RID: 2718
	public bool isMushEnable;

	// Token: 0x04000A9F RID: 2719
	private int FNGKKAKAODO = -1;

	// Token: 0x04000AA0 RID: 2720
	private int NNNAODCMOLK = -1;

	// Token: 0x04000AA1 RID: 2721
	private int OHMGGADGFLC;

	// Token: 0x04000AA2 RID: 2722
	private int IANNLEICOEK;

	// Token: 0x04000AA3 RID: 2723
	private int EPCCBDCBLCE;

	// Token: 0x04000AA4 RID: 2724
	private int LLMHFICGOJI;

	// Token: 0x04000AA5 RID: 2725
	private int DAEIFGGEGHL;

	// Token: 0x04000AA6 RID: 2726
	public Animator anm;
}
