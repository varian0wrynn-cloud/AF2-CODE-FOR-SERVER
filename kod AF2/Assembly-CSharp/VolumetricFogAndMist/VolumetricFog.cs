using System;
using System.Collections.Generic;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020002C2 RID: 706
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[HelpURL("http://kronnect.com/taptapgo")]
	[AddComponentMenu("Image Effects/Rendering/Volumetric Fog & Mist")]
	public class VolumetricFog : MonoBehaviour
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600A5CB RID: 42443 RVA: 0x004A9DFE File Offset: 0x004A7FFE
		// (set) Token: 0x0600A5D4 RID: 42452 RVA: 0x004AA27D File Offset: 0x004A847D
		public Vector3 ENIDAAMKMJB
		{
			get
			{
				return this._fogOfWarSize;
			}
			set
			{
				if (value != this._fogOfWarSize && value.x > 0f && value.z > 0f)
				{
					this._fogOfWarSize = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x004A9E06 File Offset: 0x004A8006
		public GameObject FBMKOKHDBKI()
		{
			return this._character;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600A64E RID: 42574 RVA: 0x004AC172 File Offset: 0x004AA372
		// (set) Token: 0x0600A5CD RID: 42445 RVA: 0x004A9E0E File Offset: 0x004A800E
		public float IFCIILHHKPI
		{
			get
			{
				return this._lightScatteringWeight;
			}
			set
			{
				if (value != this._lightScatteringWeight)
				{
					this._lightScatteringWeight = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600A5DB RID: 42459 RVA: 0x004AA3C8 File Offset: 0x004A85C8
		// (set) Token: 0x0600A5CE RID: 42446 RVA: 0x004A9E2D File Offset: 0x004A802D
		public float COEDJJMKLAO
		{
			get
			{
				return this._steppingNear;
			}
			set
			{
				if (value != this._steppingNear)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._steppingNear = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x004A9E57 File Offset: 0x004A8057
		public void SetPointLightIntensityMultiplier(int CLBPBJGLHEE, float GHLFLNGFLGD)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightIntensitiesMultiplier.Length)
			{
				return;
			}
			if (GHLFLNGFLGD != this._pointLightIntensitiesMultiplier[CLBPBJGLHEE])
			{
				this._pointLightIntensitiesMultiplier[CLBPBJGLHEE] = GHLFLNGFLGD;
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600A64D RID: 42573 RVA: 0x004AC16A File Offset: 0x004AA36A
		// (set) Token: 0x0600A5D0 RID: 42448 RVA: 0x004A9E8A File Offset: 0x004A808A
		public float ILLKFNCFGMP
		{
			get
			{
				return this._height;
			}
			set
			{
				if (value != this._height)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._height = Mathf.Max(value, 1E-05f);
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x004A9EC0 File Offset: 0x004A80C0
		internal void FMNMOMDOLGA(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this._density == 0f || !base.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.ANFNPKEGGGH.SetMatrix("_ClipToWorld", this.CDCBEKBHMMM.cameraToWorldMatrix * this.CDCBEKBHMMM.projectionMatrix.inverse);
			if (this._sun != null && this._lightScatteringEnabled)
			{
				this.OMLFPHCCFGD();
			}
			for (int i = 0; i < 6; i++)
			{
				Light light = this.EIAFEHFANLH[i];
				if (light != null)
				{
					if (this._pointLightColors[i] != light.color)
					{
						this._pointLightColors[i] = light.color;
						this.isDirty = true;
					}
					if (this._pointLightRanges[i] != light.range)
					{
						this._pointLightRanges[i] = light.range;
						this.isDirty = true;
					}
					if (this._pointLightPositions[i] != light.transform.position)
					{
						this._pointLightPositions[i] = light.transform.position;
						this.isDirty = true;
					}
					if (this._pointLightIntensities[i] != light.intensity)
					{
						this._pointLightIntensities[i] = light.intensity;
						this.isDirty = true;
					}
				}
				if (this._pointLightRanges[i] * this._pointLightIntensities[i] > 0f)
				{
					string str = i.ToString();
					this.ANFNPKEGGGH.SetVector("_FogPointLightPosition" + str, this._pointLightPositions[i] + Vector3.down * this._baselineHeight);
					Vector3 vector = new Vector3(this._pointLightColors[i].r, this._pointLightColors[i].g, this._pointLightColors[i].b);
					vector *= this._pointLightIntensities[i] * 0.1f * this._pointLightIntensitiesMultiplier[i] * (this._pointLightRanges[i] * this._pointLightRanges[i]);
					this.ANFNPKEGGGH.SetVector("_FogPointLightColor" + str, vector);
				}
			}
			if ((float)this._downsampling > 1f)
			{
				this.KJCLHCFDPEP = RenderTexture.GetTemporary(this.OAANPCIKMNF(JONJODLFAEN.width, (float)this._downsampling), this.OAANPCIKMNF(JONJODLFAEN.height, (float)this._downsampling), 0, RenderTextureFormat.ARGB32);
				Graphics.Blit(JONJODLFAEN, this.KJCLHCFDPEP, this.ANFNPKEGGGH, 2);
				this.ANFNPKEGGGH.SetTexture("_FogDownsampled", this.KJCLHCFDPEP);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ANFNPKEGGGH, 3);
				RenderTexture.ReleaseTemporary(this.KJCLHCFDPEP);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ANFNPKEGGGH, 0);
			}
			this.DEAKJILOFJD = OKIIDHIJBEA;
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x004AA19A File Offset: 0x004A839A
		public void LIIMCGGKDHH(bool DCCPCBLODIG)
		{
			if (DCCPCBLODIG != this._jitter)
			{
				this._jitter = DCCPCBLODIG;
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x004AA1BC File Offset: 0x004A83BC
		public void CheckWaterLevel(bool PKMONANEJGB)
		{
			if (this._baselineHeight > this.CDCBEKBHMMM.transform.position.y || PKMONANEJGB)
			{
				this._baselineHeight = 0f;
			}
			GameObject gameObject = GameObject.Find("Water");
			if (gameObject == null)
			{
				GameObject[] array = UnityEngine.Object.FindObjectsOfType<GameObject>();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null && array[i].layer == 4)
					{
						gameObject = array[i];
						break;
					}
				}
			}
			if (gameObject != null)
			{
				this._renderOpaque = false;
				if (this._baselineHeight < gameObject.transform.position.y)
				{
					this._baselineHeight = gameObject.transform.position.y;
				}
			}
			this.BJJKBPCAIDC();
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600A5D8 RID: 42456 RVA: 0x004AA377 File Offset: 0x004A8577
		// (set) Token: 0x0600A5D5 RID: 42453 RVA: 0x004AA2BB File Offset: 0x004A84BB
		public float CAGPHABINKG
		{
			get
			{
				return this._skyHaze;
			}
			set
			{
				if (value != this._skyHaze)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._skyHaze = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x004AA2E8 File Offset: 0x004A84E8
		private void NJAEHIDBCOA()
		{
			if (this.DKOLLEMPAIC == null)
			{
				return;
			}
			float num = Mathf.Clamp(this._noiseStrength, 0f, 0.95f);
			for (int i = 0; i < this.DKOLLEMPAIC.Length; i++)
			{
				this.DKOLLEMPAIC[i].a = (1f - this.APBCGMJLEFB[i].b * num) * this._density;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600A618 RID: 42520 RVA: 0x004AB63F File Offset: 0x004A983F
		// (set) Token: 0x0600A5D7 RID: 42455 RVA: 0x004AA358 File Offset: 0x004A8558
		public bool DDEMBEODEGP
		{
			get
			{
				return this._dithering;
			}
			set
			{
				if (value != this._dithering)
				{
					this._dithering = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600A61B RID: 42523 RVA: 0x004AB657 File Offset: 0x004A9857
		// (set) Token: 0x0600A5D9 RID: 42457 RVA: 0x004AA37F File Offset: 0x004A857F
		public float BDKNGMKLFBM
		{
			get
			{
				return this._lightScatteringIllumination;
			}
			set
			{
				if (value != this._lightScatteringIllumination)
				{
					this._lightScatteringIllumination = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600A676 RID: 42614 RVA: 0x004AE1E4 File Offset: 0x004AC3E4
		// (set) Token: 0x0600A5DA RID: 42458 RVA: 0x004AA39E File Offset: 0x004A859E
		public float AIFIJJADKHN
		{
			get
			{
				return this._speed;
			}
			set
			{
				if (value != this._speed)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._speed = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600A5DC RID: 42460 RVA: 0x004AA3D0 File Offset: 0x004A85D0
		// (set) Token: 0x0600A681 RID: 42625 RVA: 0x004AE387 File Offset: 0x004AC587
		public float AIGOPNNCBEM
		{
			get
			{
				return this._lightScatteringSpread;
			}
			set
			{
				if (value != this._lightScatteringSpread)
				{
					this._lightScatteringSpread = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600A612 RID: 42514 RVA: 0x004AB4DA File Offset: 0x004A96DA
		// (set) Token: 0x0600A5DD RID: 42461 RVA: 0x004AA3D8 File Offset: 0x004A85D8
		public Color32[] EBMHBBGFIMH
		{
			get
			{
				return this.GNGCEOOOGJG;
			}
			set
			{
				this.GCGOFNOLIMJ = true;
				this.GNGCEOOOGJG = value;
				if (value == null || this.GMDLHIFDCAK == null)
				{
					return;
				}
				if (value.Length != this.GMDLHIFDCAK.width * this.GMDLHIFDCAK.height)
				{
					return;
				}
				this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600A5DE RID: 42462 RVA: 0x004AA43E File Offset: 0x004A863E
		// (set) Token: 0x0600A638 RID: 42552 RVA: 0x004ABD03 File Offset: 0x004A9F03
		public int EPMBPFOFHPL
		{
			get
			{
				return this._lightScatteringSamples;
			}
			set
			{
				if (value != this._lightScatteringSamples)
				{
					this._lightScatteringSamples = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600A68C RID: 42636 RVA: 0x004AE475 File Offset: 0x004AC675
		// (set) Token: 0x0600A5DF RID: 42463 RVA: 0x004AA446 File Offset: 0x004A8646
		public Color LBCGACKJCJB
		{
			get
			{
				return this._color;
			}
			set
			{
				if (value != this._color)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._color = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x004AA478 File Offset: 0x004A8678
		private GameObject EIHKMBONFFB(Light[] HKNKHIOIBAH)
		{
			float num = float.MaxValue;
			Vector3 position = this.CDCBEKBHMMM.transform.position;
			GameObject result = null;
			int num2 = -1;
			for (int i = 0; i < HKNKHIOIBAH.Length; i++)
			{
				if (!(HKNKHIOIBAH[i] == null) && HKNKHIOIBAH[i].enabled && HKNKHIOIBAH[i].type == LightType.Point)
				{
					GameObject gameObject = HKNKHIOIBAH[i].gameObject;
					if (gameObject.activeSelf)
					{
						float sqrMagnitude = (gameObject.transform.position - position).sqrMagnitude;
						if (sqrMagnitude < num)
						{
							result = gameObject;
							num = sqrMagnitude;
							num2 = i;
						}
					}
				}
			}
			if (num2 >= 0)
			{
				HKNKHIOIBAH[num2] = null;
			}
			return result;
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x004AA51D File Offset: 0x004A871D
		public void SetPointLightIntensity(int CLBPBJGLHEE, float INAEHEBPLNN)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightIntensities.Length)
			{
				return;
			}
			if (INAEHEBPLNN != this._pointLightIntensities[CLBPBJGLHEE])
			{
				this._pointLightIntensities[CLBPBJGLHEE] = INAEHEBPLNN;
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x004AA550 File Offset: 0x004A8750
		public void NKJIEGBDCAP(float DCCPCBLODIG)
		{
			if (DCCPCBLODIG != this._baselineRelativeToCameraDelay)
			{
				this._baselineRelativeToCameraDelay = DCCPCBLODIG;
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x004AA56F File Offset: 0x004A876F
		public float GetPointLightIntensityMultiplier(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightIntensitiesMultiplier.Length)
			{
				return 0f;
			}
			return this._pointLightIntensitiesMultiplier[CLBPBJGLHEE];
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x004AA58E File Offset: 0x004A878E
		// (set) Token: 0x0600A631 RID: 42545 RVA: 0x004ABA39 File Offset: 0x004A9C39
		public float LAKJCOAFMNC
		{
			get
			{
				return this._distanceFallOff;
			}
			set
			{
				if (value != this._distanceFallOff)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._distanceFallOff = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600A64F RID: 42575 RVA: 0x004AC17A File Offset: 0x004AA37A
		// (set) Token: 0x0600A5E5 RID: 42469 RVA: 0x004AA596 File Offset: 0x004A8796
		public Vector3 GJDBFGOIJBO
		{
			get
			{
				return this._fogAreaPosition;
			}
			set
			{
				if (value != this._fogAreaPosition)
				{
					this._fogAreaPosition = value;
					this._baselineHeight = this._fogAreaPosition.y;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x004AA5CC File Offset: 0x004A87CC
		private void Update()
		{
			if (this.OIOFPBCMMDL >= 0f || this.NHNKDLKINKG >= 0f)
			{
				if (this.OIOFPBCMMDL != this.CPDLIPDNIBP || this.NHNKDLKINKG != this.ILOCCABDDMI)
				{
					if (this.NBLMJMBBOIP > 0f)
					{
						this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.OIOFPBCMMDL, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
						this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.NHNKDLKINKG, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					}
					else
					{
						this.CPDLIPDNIBP = this.OIOFPBCMMDL;
						this.ILOCCABDDMI = this.NHNKDLKINKG;
					}
					this.ANFNPKEGGGH.SetFloat("_FogAlpha", this.CPDLIPDNIBP);
					this.PMJHCJIOPKN(this.ILOCCABDDMI);
				}
			}
			else if (this.CPDLIPDNIBP != this._alpha || this.ILOCCABDDMI != this._skyAlpha)
			{
				if (this.NBLMJMBBOIP > 0f)
				{
					this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this._alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.CGFLAIMHHOO, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
				}
				else
				{
					this.CPDLIPDNIBP = this._alpha;
					this.ILOCCABDDMI = this._skyAlpha;
				}
				this.ANFNPKEGGGH.SetFloat("_FogAlpha", this.CPDLIPDNIBP);
				this.PMJHCJIOPKN(this.ILOCCABDDMI);
			}
			if (this._baselineRelativeToCamera)
			{
				this.BJJKBPCAIDC();
			}
			else if (this._character != null)
			{
				this._fogVoidPosition = this._character.transform.position;
				this.BJJKBPCAIDC();
			}
			if (this._fogAreaCenter != null)
			{
				this._fogAreaPosition = this._fogAreaCenter.transform.position;
				this.BJJKBPCAIDC();
			}
			if (this._pointLightTrackingAuto)
			{
				if (this.HOLBLGOEFBK < 180)
				{
					this.HOLBLGOEFBK++;
				}
				else
				{
					this.HOLBLGOEFBK = 0;
					this.MCOAJJICKHL();
				}
			}
			if (this._sun != null)
			{
				bool flag = false;
				if (this._sun.transform.forward != this._lightDirection && (!Application.isPlaying || Time.time - this.KLDEEGLHHID >= 0.2f))
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.color != this._lightColor)
				{
					flag = true;
				}
				if (flag)
				{
					this.MBIKOFABHKN();
				}
			}
			if (this._fogOfWarEnabled)
			{
				this.AOKIJLKPCLL();
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600A603 RID: 42499 RVA: 0x004AB128 File Offset: 0x004A9328
		// (set) Token: 0x0600A5E7 RID: 42471 RVA: 0x004AA891 File Offset: 0x004A8A91
		public float PFPFCIIIANB
		{
			get
			{
				return this._lightIntensity;
			}
			set
			{
				if (value != this._lightIntensity)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._lightIntensity = value;
					this.DGLHMGDJMMM();
					this.MBIKOFABHKN();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x004AA8C1 File Offset: 0x004A8AC1
		// (set) Token: 0x0600A68A RID: 42634 RVA: 0x004AA550 File Offset: 0x004A8750
		public float CFMDEHAMLCG
		{
			get
			{
				return this._baselineRelativeToCameraDelay;
			}
			set
			{
				if (value != this._baselineRelativeToCameraDelay)
				{
					this._baselineRelativeToCameraDelay = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5E9 RID: 42473 RVA: 0x004AA8C9 File Offset: 0x004A8AC9
		public void DestroySelf()
		{
			this.ANHIEPCDMCI<VolumetricFogPreT>();
			this.ANHIEPCDMCI<VolumetricFogPosT>();
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600A67E RID: 42622 RVA: 0x004AE301 File Offset: 0x004AC501
		// (set) Token: 0x0600A5EA RID: 42474 RVA: 0x004AA8DD File Offset: 0x004A8ADD
		[Obsolete("Fog Void inverted is now deprecated. Use Fog Area settings.")]
		public bool LLGDEADKECD
		{
			get
			{
				return this._fogVoidInverted;
			}
			set
			{
				this._fogVoidInverted = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600A5EB RID: 42475 RVA: 0x004AA8E6 File Offset: 0x004A8AE6
		// (set) Token: 0x0600A698 RID: 42648 RVA: 0x004AE559 File Offset: 0x004AC759
		public GameObject BNEPHLKMALH
		{
			get
			{
				return this._sun;
			}
			set
			{
				if (value != this._sun)
				{
					this._sun = value;
					this.HEFFDDEHNDO();
				}
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600A69D RID: 42653 RVA: 0x004AE5CE File Offset: 0x004AC7CE
		// (set) Token: 0x0600A5EC RID: 42476 RVA: 0x004AA8EE File Offset: 0x004A8AEE
		public float FOFIGFCAECC
		{
			get
			{
				return this._lightScatteringJittering;
			}
			set
			{
				if (value != this._lightScatteringJittering)
				{
					this._lightScatteringJittering = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600A5ED RID: 42477 RVA: 0x004AA90D File Offset: 0x004A8B0D
		// (set) Token: 0x0600A602 RID: 42498 RVA: 0x004AB109 File Offset: 0x004A9309
		public bool EPCKPJCCPGJ
		{
			get
			{
				return this._sunCopyColor;
			}
			set
			{
				if (value != this._sunCopyColor)
				{
					this._sunCopyColor = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600A61D RID: 42525 RVA: 0x004AB67E File Offset: 0x004A987E
		// (set) Token: 0x0600A5EE RID: 42478 RVA: 0x004AA915 File Offset: 0x004A8B15
		public int AGLNNPJOLKC
		{
			get
			{
				return this._pointLightTrackingCount;
			}
			set
			{
				if (value != this._pointLightTrackingCount)
				{
					this._pointLightTrackingCount = Mathf.Clamp(value, 0, 6);
					this.MCOAJJICKHL();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600A5EF RID: 42479 RVA: 0x004AA93B File Offset: 0x004A8B3B
		// (set) Token: 0x0600A600 RID: 42496 RVA: 0x004AB0EA File Offset: 0x004A92EA
		public bool HLPDBFOIGMB
		{
			get
			{
				return this._lightScatteringEnabled;
			}
			set
			{
				if (value != this._lightScatteringEnabled)
				{
					this._lightScatteringEnabled = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x004AA943 File Offset: 0x004A8B43
		internal void OEEFHDICHJD()
		{
			if (this._density == 0f || !base.enabled)
			{
				return;
			}
			Graphics.Blit(this.DEAKJILOFJD, this.ANFNPKEGGGH, 1);
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600A5F1 RID: 42481 RVA: 0x004AA96D File Offset: 0x004A8B6D
		// (set) Token: 0x0600A636 RID: 42550 RVA: 0x004ABAD2 File Offset: 0x004A9CD2
		public float IHDEJJAOGFD
		{
			get
			{
				return this._noiseStrength;
			}
			set
			{
				if (value != this._noiseStrength)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._noiseStrength = value;
					this.DGLHMGDJMMM();
					this.NJAEHIDBCOA();
					this.MBIKOFABHKN();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600A5F2 RID: 42482 RVA: 0x004AA975 File Offset: 0x004A8B75
		// (set) Token: 0x0600A60F RID: 42511 RVA: 0x004AB42D File Offset: 0x004A962D
		public Vector3 NHPCOKJBAEJ
		{
			get
			{
				return this._lightDirection;
			}
			set
			{
				if (value != this._lightDirection)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._lightDirection = value;
					this.DGLHMGDJMMM();
					this.MBIKOFABHKN();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x004AA980 File Offset: 0x004A8B80
		public void ResetFogOfWar()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int height = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num = height * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num)
			{
				this.GNGCEOOOGJG = new Color32[num];
			}
			Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			for (int i = 0; i < num; i++)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
			this.isDirty = true;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600A628 RID: 42536 RVA: 0x004AB64F File Offset: 0x004A984F
		// (set) Token: 0x0600A5F4 RID: 42484 RVA: 0x004AAA2C File Offset: 0x004A8C2C
		public bool JPJDDBDEMGD
		{
			get
			{
				return this._pointLightTrackingAuto;
			}
			set
			{
				if (value != this._pointLightTrackingAuto)
				{
					this._pointLightTrackingAuto = value;
					this.MCOAJJICKHL();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600A694 RID: 42644 RVA: 0x004AE4D3 File Offset: 0x004AC6D3
		// (set) Token: 0x0600A5F5 RID: 42485 RVA: 0x004AAA4B File Offset: 0x004A8C4B
		public float CFBHJFKMDIL
		{
			get
			{
				return this._fogVoidDepth;
			}
			set
			{
				if (value != this._fogVoidDepth)
				{
					this._fogVoidDepth = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600A664 RID: 42596 RVA: 0x004ADE6E File Offset: 0x004AC06E
		// (set) Token: 0x0600A5F6 RID: 42486 RVA: 0x004AAA6A File Offset: 0x004A8C6A
		public Color CDIMIEAMACH
		{
			get
			{
				return this._skyColor;
			}
			set
			{
				if (value != this._skyColor)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._skyColor = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600A64A RID: 42570 RVA: 0x004AC119 File Offset: 0x004AA319
		// (set) Token: 0x0600A5F7 RID: 42487 RVA: 0x004AAA99 File Offset: 0x004A8C99
		public IBFDPDLGLBC EDBIMEMLHCP
		{
			get
			{
				return this._preset;
			}
			set
			{
				if (value != this._preset)
				{
					this._preset = value;
					this.OFKDCOJNMFE();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x004AAAB8 File Offset: 0x004A8CB8
		private void MCOAJJICKHL()
		{
			if (!this._pointLightTrackingAuto)
			{
				return;
			}
			Light[] hknkhioibah = UnityEngine.Object.FindObjectsOfType<Light>();
			for (int i = 0; i < 6; i++)
			{
				GameObject gameObject = null;
				if (i < this._pointLightTrackingCount)
				{
					gameObject = this.EIHKMBONFFB(hknkhioibah);
				}
				this._pointLights[i] = gameObject;
				this._pointLightRanges[i] = 0f;
			}
			this.KLADJJFCPND();
			this.DGLHMGDJMMM();
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600A5F9 RID: 42489 RVA: 0x004AAB15 File Offset: 0x004A8D15
		public Camera AAAOLCMHAGN
		{
			get
			{
				return this.CDCBEKBHMMM;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600A691 RID: 42641 RVA: 0x004AE4A4 File Offset: 0x004AC6A4
		// (set) Token: 0x0600A5FA RID: 42490 RVA: 0x004AAB1D File Offset: 0x004A8D1D
		public float JCPHHIEKBGH
		{
			get
			{
				return this._fogVoidFallOff;
			}
			set
			{
				if (value != this._fogVoidFallOff)
				{
					this._fogVoidFallOff = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600A69F RID: 42655 RVA: 0x004AE5DE File Offset: 0x004AC7DE
		// (set) Token: 0x0600A5FB RID: 42491 RVA: 0x004AAB3C File Offset: 0x004A8D3C
		public Color BNJHIJPGJAA
		{
			get
			{
				return this._specularColor;
			}
			set
			{
				if (value != this._specularColor)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._specularColor = value;
					this.DGLHMGDJMMM();
					this.MBIKOFABHKN();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600A5FC RID: 42492 RVA: 0x004AAB71 File Offset: 0x004A8D71
		// (set) Token: 0x0600A6AA RID: 42666 RVA: 0x004AE741 File Offset: 0x004AC941
		public float NOBJLKMBMHP
		{
			get
			{
				return this._edgeThreshold;
			}
			set
			{
				if (value != this._edgeThreshold)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._edgeThreshold = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5FD RID: 42493 RVA: 0x004AAB7C File Offset: 0x004A8D7C
		private void DGLHMGDJMMM()
		{
			if (this.ANFNPKEGGGH == null)
			{
				return;
			}
			this.PMJHCJIOPKN(this._skyAlpha);
			this.ANFNPKEGGGH.SetVector("_FogSkyData", new Vector4(this._skyHaze, this._skyNoiseStrength, this._skySpeed, this._skyDepth));
			Vector4 value = new Vector4(1f / (this._stepping + 1f), 1f / (1f + this._steppingNear), this._edgeThreshold, this._dithering ? (this._ditherStrength * 0.1f) : 0f);
			if (!this._edgeImprove)
			{
				value.z = 0f;
			}
			this.ANFNPKEGGGH.SetVector("_FogStepping", value);
			this.ANFNPKEGGGH.SetFloat("_FogAlpha", this.CPDLIPDNIBP);
			this.BJJKBPCAIDC();
			float num = 0.01f / this._noiseScale;
			this.ANFNPKEGGGH.SetFloat("_FogScale", num);
			Vector4 value2 = this._windDirection.normalized * this._speed / num;
			value2.w = (this._jitter ? this._jitterrStrength : 0f);
			this.ANFNPKEGGGH.SetVector("_FogWindDir", value2);
			this.ANFNPKEGGGH.SetFloat("_FogDensity", 1f / this._density);
			this.ANFNPKEGGGH.SetVector("_FogDistance", new Vector3(num * num * this._distance * this._distance, this._distanceFallOff * this._distanceFallOff + 0.1f, this._maxFogLength));
			this.ANFNPKEGGGH.SetColor("_Color", this._color * 2f);
			float value3 = 0f;
			if (LocNewLogic.getI != null)
			{
				value3 = LocNewLogic.getI.waterLevel4Fog;
			}
			this.ANFNPKEGGGH.SetFloat("_FogWaterLevel", value3);
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this._distance > 0f)
			{
				this.ABEHHDIGHFJ.Add("FOG_DISTANCE_ON");
			}
			if (this._fogVoidRadius > 0f && this._fogVoidFallOff > 0f)
			{
				Vector4 value4 = new Vector4(1f / (1f + this._fogVoidRadius), 1f / (1f + this._fogVoidHeight), 1f / (1f + this._fogVoidDepth), this._fogVoidFallOff);
				if (this._fogVoidHeight > 0f && this._fogVoidDepth > 0f)
				{
					this.ABEHHDIGHFJ.Add("FOG_VOID_BOX");
				}
				else
				{
					this.ABEHHDIGHFJ.Add("FOG_VOID_SPHERE");
				}
				this.ANFNPKEGGGH.SetVector("_FogVoidData", value4);
			}
			if (this._fogAreaRadius > 0f && this._fogAreaFallOff > 0f)
			{
				Vector4 value5 = new Vector4(1f / (1f + this._fogAreaRadius), 1f / (1f + this._fogAreaHeight), 1f / (1f + this._fogAreaDepth), this._fogAreaFallOff);
				if (this._fogAreaHeight > 0f && this._fogAreaDepth > 0f)
				{
					this.ABEHHDIGHFJ.Add("FOG_AREA_BOX");
				}
				else
				{
					this.ABEHHDIGHFJ.Add("FOG_AREA_SPHERE");
					value5.y = this._fogAreaRadius * this._fogAreaRadius;
					value5.x /= num;
					value5.z /= num;
				}
				this.ANFNPKEGGGH.SetVector("_FogAreaData", value5);
			}
			if (this._skyHaze > 0f && this._skyAlpha > 0f)
			{
				this.ABEHHDIGHFJ.Add("FOG_HAZE_ON");
			}
			if (this._fogOfWarEnabled)
			{
				this.ABEHHDIGHFJ.Add("FOG_OF_WAR_ON");
				this.ANFNPKEGGGH.SetTexture("_FogOfWar", this.GMDLHIFDCAK);
				this.ANFNPKEGGGH.SetVector("_FogOfWarCenter", this._fogOfWarCenter);
				this.ANFNPKEGGGH.SetVector("_FogOfWarSize", this._fogOfWarSize);
				Vector3 vector = this._fogOfWarCenter - 0.5f * this._fogOfWarSize;
				this.ANFNPKEGGGH.SetVector("_FogOfWarCenterAdjusted", new Vector3(vector.x / this._fogOfWarSize.x, 1f, vector.z / this._fogOfWarSize.z));
			}
			int num2 = -1;
			for (int i = 0; i < 6; i++)
			{
				if (this._pointLights[i] != null || this._pointLightRanges[i] * this._pointLightIntensities[i] > 0f)
				{
					num2 = i;
				}
			}
			if (num2 >= 0)
			{
				this.ABEHHDIGHFJ.Add("FOG_POINT_LIGHT" + num2.ToString());
			}
			if (this._lightScatteringEnabled)
			{
				this.OMLFPHCCFGD();
				this.ABEHHDIGHFJ.Add("FOG_SCATTERING_ON");
			}
			this.ANFNPKEGGGH.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600A5FE RID: 42494 RVA: 0x004AB0CF File Offset: 0x004A92CF
		// (set) Token: 0x0600A669 RID: 42601 RVA: 0x004ADF58 File Offset: 0x004AC158
		public float NBCIMDAMODL
		{
			get
			{
				return this._specularThreshold;
			}
			set
			{
				if (value != this._specularThreshold)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._specularThreshold = value;
					this.MBIKOFABHKN();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A5FF RID: 42495 RVA: 0x004AB0D7 File Offset: 0x004A92D7
		public static VolumetricFog CreateFogArea(Vector3 MGALEAJOGPL, Vector3 GEFEOMDOOHD)
		{
			return VolumetricFog.CreateFogArea(Camera.main.gameObject, MGALEAJOGPL, GEFEOMDOOHD);
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600A601 RID: 42497 RVA: 0x004A9E06 File Offset: 0x004A8006
		// (set) Token: 0x0600A695 RID: 42645 RVA: 0x004AE4DB File Offset: 0x004AC6DB
		public GameObject IFIIFDKAKDJ
		{
			get
			{
				return this._character;
			}
			set
			{
				if (value != this._character)
				{
					this._character = value;
					this.isDirty = true;
					if (this._fogVoidRadius < 20f)
					{
						this.AGLFEEHFCHB = 20f;
					}
				}
			}
		}

		// Token: 0x0600A604 RID: 42500 RVA: 0x004AB130 File Offset: 0x004A9330
		public static Terrain GetActiveTerrain()
		{
			Terrain terrain = Terrain.activeTerrain;
			if (terrain != null && terrain.isActiveAndEnabled)
			{
				return terrain;
			}
			for (int i = 0; i < Terrain.activeTerrains.Length; i++)
			{
				terrain = Terrain.activeTerrains[i];
				if (terrain != null && terrain.isActiveAndEnabled)
				{
					return terrain;
				}
			}
			return null;
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x004AB184 File Offset: 0x004A9384
		public static VolumetricFog CreateFogArea(GameObject HHFKOCCHHKH, Vector3 MGALEAJOGPL, float AEIAFIIMHEL)
		{
			if (HHFKOCCHHKH == null)
			{
				return null;
			}
			VolumetricFog volumetricFog = HHFKOCCHHKH.AddComponent<VolumetricFog>();
			volumetricFog.EDBIMEMLHCP = IBFDPDLGLBC.SeaClouds;
			volumetricFog.GJDBFGOIJBO = MGALEAJOGPL;
			volumetricFog.KNKNDOFLNMP = AEIAFIIMHEL;
			volumetricFog.ENIMEAJNMLM = 0f;
			volumetricFog.GNDFOJIILMC = 0f;
			volumetricFog.CAGPHABINKG = 0f;
			VolumetricFog.FOKHHHJJMCE(true, MGALEAJOGPL, AEIAFIIMHEL, volumetricFog.ILLKFNCFGMP, AEIAFIIMHEL, volumetricFog);
			return volumetricFog;
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x004AB1EC File Offset: 0x004A93EC
		private void OMLFPHCCFGD()
		{
			if (this._sun == null)
			{
				return;
			}
			Vector3 vector = this.CDCBEKBHMMM.WorldToViewportPoint(this._sun.transform.forward * 10000f);
			if (vector.z < 0f)
			{
				Vector2 vector2 = new Vector2(vector.x, vector.y);
				if (vector2 != this.FFELAGLIGFM)
				{
					this.FFELAGLIGFM = vector2;
					this.ANFNPKEGGGH.SetVector("_SunPosition", vector2);
					float num = Mathf.Clamp01(1f - this._lightDirection.y);
					this.BGOIMEOBLLF = Mathf.SmoothStep(1f, 0f, (vector2 - Vector2.one * 0.5f).magnitude * 0.5f) * num;
				}
				if (this._lightScatteringEnabled && !this.ANFNPKEGGGH.IsKeywordEnabled("FOG_SCATTERING_ON"))
				{
					this.ANFNPKEGGGH.EnableKeyword("FOG_SCATTERING_ON");
				}
				this.ANFNPKEGGGH.SetVector("_FogScatteringData", new Vector4(this._lightScatteringSpread / (float)this._lightScatteringSamples, (float)this._lightScatteringSamples, this._lightScatteringExposure * this.BGOIMEOBLLF, this._lightScatteringWeight / (float)this._lightScatteringSamples));
				this.ANFNPKEGGGH.SetVector("_FogScatteringData2", new Vector3(this._lightScatteringIllumination, this._lightScatteringDecay, this._lightScatteringJittering));
				return;
			}
			if (this.ANFNPKEGGGH.IsKeywordEnabled("FOG_SCATTERING_ON"))
			{
				this.ANFNPKEGGGH.DisableKeyword("FOG_SCATTERING_ON");
			}
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x004AB38B File Offset: 0x004A958B
		public Vector3 GetPointLightPosition(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightPositions.Length)
			{
				return Vector3.zero;
			}
			return this._pointLightPositions[CLBPBJGLHEE];
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600A608 RID: 42504 RVA: 0x004AB3AE File Offset: 0x004A95AE
		// (set) Token: 0x0600A6A3 RID: 42659 RVA: 0x004AE69F File Offset: 0x004AC89F
		public bool APEJICIAOAB
		{
			get
			{
				return this._useFogVolumes;
			}
			set
			{
				if (value != this._useFogVolumes)
				{
					this._useFogVolumes = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x004AB3B6 File Offset: 0x004A95B6
		public static void RemoveAllFogAreas()
		{
			VolumetricFog.RemoveAllFogAreas(Camera.main.gameObject);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600A61F RID: 42527 RVA: 0x004AB6AA File Offset: 0x004A98AA
		// (set) Token: 0x0600A60A RID: 42506 RVA: 0x004AB3C7 File Offset: 0x004A95C7
		public float JPEMIKIACDA
		{
			get
			{
				return this._jitterrStrength;
			}
			set
			{
				if (value != this._jitterrStrength)
				{
					this._jitterrStrength = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600A60B RID: 42507 RVA: 0x004AB3E6 File Offset: 0x004A95E6
		// (set) Token: 0x0600A625 RID: 42533 RVA: 0x004AB806 File Offset: 0x004A9A06
		public Vector3 MDEHBKAEDCJ
		{
			get
			{
				return this._windDirection;
			}
			set
			{
				if (value != this._windDirection)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._windDirection = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x004AB3EE File Offset: 0x004A95EE
		public GameObject GENIOBBGMFN(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLights.Length)
			{
				return null;
			}
			return this._pointLights[CLBPBJGLHEE];
		}

		// Token: 0x0600A60D RID: 42509 RVA: 0x004AB409 File Offset: 0x004A9609
		public string GetCurrentPresetName()
		{
			return Enum.GetName(typeof(IBFDPDLGLBC), this._preset);
		}

		// Token: 0x0600A60E RID: 42510 RVA: 0x004AB425 File Offset: 0x004A9625
		public bool KLDHJFGAOKD()
		{
			return this._fogOfWarEnabled;
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600A62E RID: 42542 RVA: 0x004AB9E6 File Offset: 0x004A9BE6
		// (set) Token: 0x0600A610 RID: 42512 RVA: 0x004AB464 File Offset: 0x004A9664
		public float LHEHLDMKBKB
		{
			get
			{
				return this._baselineHeight;
			}
			set
			{
				if (value != this._baselineHeight)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._baselineHeight = value;
					if (this._fogAreaRadius > 0f)
					{
						this._fogAreaPosition.y = this._baselineHeight;
					}
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A611 RID: 42513 RVA: 0x004AB4B7 File Offset: 0x004A96B7
		public Color GetPointLightColor(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightColors.Length)
			{
				return Color.white;
			}
			return this._pointLightColors[CLBPBJGLHEE];
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600A683 RID: 42627 RVA: 0x004AE3AE File Offset: 0x004AC5AE
		// (set) Token: 0x0600A613 RID: 42515 RVA: 0x004AB4E2 File Offset: 0x004A96E2
		public bool ALIGMOJJOHF
		{
			get
			{
				return this._edgeImprove;
			}
			set
			{
				if (value != this._edgeImprove)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._edgeImprove = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x004AB50C File Offset: 0x004A970C
		public void ClearTargetAlpha(float FDBHLKAEDBF)
		{
			this.SetTargetAlpha(-1f, -1f, FDBHLKAEDBF);
		}

		// Token: 0x0600A615 RID: 42517 RVA: 0x004AB520 File Offset: 0x004A9720
		private void KLADJJFCPND()
		{
			for (int i = 0; i < this._pointLights.Length; i++)
			{
				GameObject gameObject = this._pointLights[i];
				if (gameObject != null)
				{
					this.EIAFEHFANLH[i] = gameObject.GetComponent<Light>();
				}
				else
				{
					this.EIAFEHFANLH[i] = null;
				}
			}
		}

		// Token: 0x0600A616 RID: 42518 RVA: 0x004AB56C File Offset: 0x004A976C
		public static void RemoveAllFogAreas(GameObject HHFKOCCHHKH)
		{
			if (HHFKOCCHHKH == null)
			{
				return;
			}
			VolumetricFogPreT[] componentsInChildren = HHFKOCCHHKH.GetComponentsInChildren<VolumetricFogPreT>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].ANCIMKLOHFH.KNKNDOFLNMP > 0f)
				{
					UnityEngine.Object.DestroyImmediate(componentsInChildren[i]);
				}
			}
			VolumetricFogPosT[] componentsInChildren2 = HHFKOCCHHKH.GetComponentsInChildren<VolumetricFogPosT>(true);
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				if (componentsInChildren2[j].ANCIMKLOHFH.KNKNDOFLNMP > 0f)
				{
					UnityEngine.Object.DestroyImmediate(componentsInChildren2[j]);
				}
			}
			VolumetricFog[] componentsInChildren3 = HHFKOCCHHKH.GetComponentsInChildren<VolumetricFog>(true);
			for (int k = 0; k < componentsInChildren3.Length; k++)
			{
				if (componentsInChildren3[k].KNKNDOFLNMP > 0f)
				{
					UnityEngine.Object.DestroyImmediate(componentsInChildren3[k]);
				}
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600A6A7 RID: 42663 RVA: 0x004AE71A File Offset: 0x004AC91A
		// (set) Token: 0x0600A617 RID: 42519 RVA: 0x004AB620 File Offset: 0x004A9820
		public float ENIMEAJNMLM
		{
			get
			{
				return this._fogAreaHeight;
			}
			set
			{
				if (value != this._fogAreaHeight)
				{
					this._fogAreaHeight = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x004AB647 File Offset: 0x004A9847
		public Color EPBEJOMONNA()
		{
			return this._lightColor;
		}

		// Token: 0x0600A61A RID: 42522 RVA: 0x004AB64F File Offset: 0x004A984F
		public bool CFILHMFCAPM()
		{
			return this._pointLightTrackingAuto;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600A63D RID: 42557 RVA: 0x004ABF01 File Offset: 0x004AA101
		// (set) Token: 0x0600A61C RID: 42524 RVA: 0x004AB65F File Offset: 0x004A985F
		public float AADFJHKNIBM
		{
			get
			{
				return this._maxFogLength;
			}
			set
			{
				if (value != this._maxFogLength)
				{
					this._maxFogLength = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600A634 RID: 42548 RVA: 0x004ABAAB File Offset: 0x004A9CAB
		// (set) Token: 0x0600A61E RID: 42526 RVA: 0x004AB686 File Offset: 0x004A9886
		public Vector3 AGIPHCGMPIE
		{
			get
			{
				return this._fogOfWarCenter;
			}
			set
			{
				if (value != this._fogOfWarCenter)
				{
					this._fogOfWarCenter = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600A6A1 RID: 42657 RVA: 0x004AE678 File Offset: 0x004AC878
		// (set) Token: 0x0600A620 RID: 42528 RVA: 0x004AB6B2 File Offset: 0x004A98B2
		public float GNDFOJIILMC
		{
			get
			{
				return this._fogAreaDepth;
			}
			set
			{
				if (value != this._fogAreaDepth)
				{
					this._fogAreaDepth = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x004AB6D4 File Offset: 0x004A98D4
		private void EONEODPEJCJ<T>() where T : Component, HPLMICNEDGL
		{
			T[] componentsInChildren = base.GetComponentsInChildren<T>(true);
			int num = -1;
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].ANCIMKLOHFH == this)
				{
					return;
				}
				if (componentsInChildren[i].ANCIMKLOHFH == null)
				{
					num = i;
				}
			}
			if (num < 0)
			{
				base.gameObject.AddComponent<T>().ANCIMKLOHFH = this;
				return;
			}
			componentsInChildren[num].ANCIMKLOHFH = this;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600A622 RID: 42530 RVA: 0x004AB75B File Offset: 0x004A995B
		// (set) Token: 0x0600A69A RID: 42650 RVA: 0x004AE59F File Offset: 0x004AC79F
		public float LKMNLFLGNLP
		{
			get
			{
				return this._lightScatteringDecay;
			}
			set
			{
				if (value != this._lightScatteringDecay)
				{
					this._lightScatteringDecay = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600A643 RID: 42563 RVA: 0x004AC061 File Offset: 0x004AA261
		// (set) Token: 0x0600A623 RID: 42531 RVA: 0x004AB763 File Offset: 0x004A9963
		public float GPCJBNHMLIE
		{
			get
			{
				return this._skyAlpha;
			}
			set
			{
				if (value != this._skyAlpha)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._skyAlpha = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600A624 RID: 42532 RVA: 0x004AB790 File Offset: 0x004A9990
		public static VolumetricFog COIPKPKLDAH
		{
			get
			{
				if (VolumetricFog.BOKKCFIFEED == null)
				{
					if (Camera.main != null)
					{
						VolumetricFog.BOKKCFIFEED = Camera.main.GetComponent<VolumetricFog>();
					}
					if (VolumetricFog.BOKKCFIFEED == null)
					{
						Camera[] allCameras = Camera.allCameras;
						for (int i = 0; i < allCameras.Length; i++)
						{
							VolumetricFog.BOKKCFIFEED = allCameras[i].GetComponent<VolumetricFog>();
							if (VolumetricFog.BOKKCFIFEED != null)
							{
								break;
							}
						}
					}
				}
				return VolumetricFog.BOKKCFIFEED;
			}
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x004AB3C7 File Offset: 0x004A95C7
		public void KFNHKOGBKFJ(float DCCPCBLODIG)
		{
			if (DCCPCBLODIG != this._jitterrStrength)
			{
				this._jitterrStrength = DCCPCBLODIG;
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x004AB835 File Offset: 0x004A9A35
		public void HNGGEPELJIG(float DCCPCBLODIG)
		{
			if (DCCPCBLODIG != this._height)
			{
				this._preset = (IBFDPDLGLBC)163;
				this._height = Mathf.Max(DCCPCBLODIG, 561f);
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600A629 RID: 42537 RVA: 0x004AB869 File Offset: 0x004A9A69
		// (set) Token: 0x0600A68F RID: 42639 RVA: 0x004AE47D File Offset: 0x004AC67D
		public float PNMHGEDJKHL
		{
			get
			{
				return this._ditherStrength;
			}
			set
			{
				if (value != this._ditherStrength)
				{
					this._ditherStrength = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x004AB874 File Offset: 0x004A9A74
		private void AOKIJLKPCLL()
		{
			if (!this._fogOfWarEnabled || this._fogOfWarRestoreDelay <= 0f)
			{
				return;
			}
			int count = this.LECEDJIHNOF.Count;
			int width = this.GMDLHIFDCAK.width;
			bool flag = false;
			for (int i = 0; i < count; i++)
			{
				VolumetricFog.JLDHOIEEOID jldhoieeoid = this.LECEDJIHNOF[i];
				if (jldhoieeoid.PMPMAALNEBO)
				{
					float num = Time.time - jldhoieeoid.JOJHMMFOPPJ - this._fogOfWarRestoreDelay;
					if (num > 0f)
					{
						float num2 = (this._fogOfWarRestoreDuration <= 0f) ? 1f : (num / this._fogOfWarRestoreDuration);
						num2 = Mathf.Clamp01(num2);
						float num3 = Mathf.Lerp((float)jldhoieeoid.LFLNBKCDOFJ, 255f, num2);
						int num4 = jldhoieeoid.ADMFAEOOOHD * width + jldhoieeoid.OCNGPCPMCPM;
						this.GNGCEOOOGJG[num4].a = (byte)num3;
						this.GMDLHIFDCAK.SetPixel(jldhoieeoid.OCNGPCPMCPM, jldhoieeoid.ADMFAEOOOHD, this.GNGCEOOOGJG[num4]);
						flag = true;
						if (num2 >= 1f)
						{
							jldhoieeoid.PMPMAALNEBO = false;
						}
					}
				}
			}
			if (flag)
			{
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x00482626 File Offset: 0x00480826
		private int OAANPCIKMNF(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 4;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 1;
			}
			return BBOODPCDKAJ * 4;
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x004AB9B1 File Offset: 0x004A9BB1
		private void OLAJCBIHPKI()
		{
			this.LECEDJIHNOF = new List<VolumetricFog.JLDHOIEEOID>();
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600A66E RID: 42606 RVA: 0x004AE166 File Offset: 0x004AC366
		// (set) Token: 0x0600A62D RID: 42541 RVA: 0x004AB9BE File Offset: 0x004A9BBE
		public bool KJLHOBIAFKM
		{
			get
			{
				return this._improveTransparency;
			}
			set
			{
				if (value != this._improveTransparency)
				{
					this._improveTransparency = value;
					if (this._improveTransparency)
					{
						this.IKKACJEEEHG = true;
					}
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x004AE5C6 File Offset: 0x004AC7C6
		// (set) Token: 0x0600A62F RID: 42543 RVA: 0x004AB9EE File Offset: 0x004A9BEE
		public bool IEFAMDEHCBD
		{
			get
			{
				return this._baselineRelativeToCamera;
			}
			set
			{
				if (value != this._baselineRelativeToCamera)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._baselineRelativeToCamera = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x004ABA18 File Offset: 0x004A9C18
		private void FFJNAABIBOH()
		{
			if (this.EPLJMFAGBBL)
			{
				RenderTexture.ReleaseTemporary(this.EPLJMFAGBBL);
				this.EPLJMFAGBBL = null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600A632 RID: 42546 RVA: 0x004ABA63 File Offset: 0x004A9C63
		// (set) Token: 0x0600A655 RID: 42581 RVA: 0x004AC1E6 File Offset: 0x004AA3E6
		public float GBIHEOLACLH
		{
			get
			{
				return this._density;
			}
			set
			{
				if (value != this._density)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._density = value;
					this.DGLHMGDJMMM();
					this.NJAEHIDBCOA();
					this.MBIKOFABHKN();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x004ABA6B File Offset: 0x004A9C6B
		public void SetPointLightPosition(int CLBPBJGLHEE, Vector3 MGALEAJOGPL)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightPositions.Length)
			{
				return;
			}
			if (MGALEAJOGPL != this._pointLightPositions[CLBPBJGLHEE])
			{
				this._pointLightPositions[CLBPBJGLHEE] = MGALEAJOGPL;
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x004ABAB3 File Offset: 0x004A9CB3
		public float GetPointLightIntensity(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightIntensities.Length)
			{
				return 0f;
			}
			return this._pointLightIntensities[CLBPBJGLHEE];
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x004ABB08 File Offset: 0x004A9D08
		public void SetFogOfWarAlpha(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this._fogOfWarCenter.x) / this._fogOfWarSize.x + 0.5f;
			if (num < 0f || num > 1f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this._fogOfWarCenter.z) / this._fogOfWarSize.z + 0.5f;
			if (num2 < 0f || num2 > 1f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int height = this.GMDLHIFDCAK.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(HCECNDOJHHK * 255f);
			Color32 color = this.GNGCEOOOGJG[num5];
			if (b != color.a)
			{
				float num6 = AEIAFIIMHEL / this._fogOfWarSize.z;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 0 && i < height - 1)
					{
						for (int j = num3 - num7; j <= num3 + num7; j++)
						{
							if (j > 0 && j < width - 1)
							{
								int num8 = Mathf.FloorToInt(Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j))));
								if (num8 <= num7)
								{
									num5 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num5];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
									this.GNGCEOOOGJG[num5] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
									this.DIDICIMKFCK(j, i, color2.a);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x004ABD24 File Offset: 0x004A9F24
		internal void PIHLDMFCHNP()
		{
			if (!base.enabled || !base.gameObject.activeSelf || !this._improveTransparency)
			{
				return;
			}
			this.FFJNAABIBOH();
			Camera component;
			if (this.AABLBMICILO == null)
			{
				this.AABLBMICILO = new GameObject("DepthCamera");
				this.AABLBMICILO.AddComponent<Camera>();
				component = this.AABLBMICILO.GetComponent<Camera>();
				component.enabled = false;
				this.AABLBMICILO.hideFlags = HideFlags.HideAndDontSave;
			}
			else
			{
				component = this.AABLBMICILO.GetComponent<Camera>();
			}
			component.CopyFrom(this.CDCBEKBHMMM);
			this.EPLJMFAGBBL = RenderTexture.GetTemporary(this.CDCBEKBHMMM.pixelWidth, this.CDCBEKBHMMM.pixelHeight, 16, RenderTextureFormat.ARGB32);
			component.backgroundColor = new Color(0f, 0f, 0f, 0f);
			component.clearFlags = CameraClearFlags.Color;
			component.targetTexture = this.EPLJMFAGBBL;
			component.RenderWithShader(Shader.Find("VolumetricFogAndMist/CopyDepth"), "RenderType");
			this.ANFNPKEGGGH.SetTexture("_DepthTexture", this.EPLJMFAGBBL);
		}

		// Token: 0x0600A63A RID: 42554 RVA: 0x004ABE3A File Offset: 0x004AA03A
		public void SetPointLightRange(int CLBPBJGLHEE, float DPMJPLPBBHC)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightRanges.Length)
			{
				return;
			}
			if (DPMJPLPBBHC != this._pointLightRanges[CLBPBJGLHEE])
			{
				this._pointLightRanges[CLBPBJGLHEE] = DPMJPLPBBHC;
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A63B RID: 42555 RVA: 0x004AB3EE File Offset: 0x004A95EE
		public GameObject GetPointLight(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLights.Length)
			{
				return null;
			}
			return this._pointLights[CLBPBJGLHEE];
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x004ABE70 File Offset: 0x004AA070
		public static VolumetricFog CreateFogArea(GameObject HHFKOCCHHKH, Vector3 MGALEAJOGPL, Vector3 GEFEOMDOOHD)
		{
			if (HHFKOCCHHKH == null)
			{
				return null;
			}
			VolumetricFog volumetricFog = HHFKOCCHHKH.AddComponent<VolumetricFog>();
			volumetricFog.EDBIMEMLHCP = IBFDPDLGLBC.SeaClouds;
			volumetricFog.GJDBFGOIJBO = MGALEAJOGPL;
			volumetricFog.KNKNDOFLNMP = GEFEOMDOOHD.x;
			volumetricFog.ENIMEAJNMLM = GEFEOMDOOHD.y;
			volumetricFog.GNDFOJIILMC = GEFEOMDOOHD.z;
			volumetricFog.ILLKFNCFGMP = GEFEOMDOOHD.y * 0.98f;
			volumetricFog.MDJKLNALBLD = true;
			volumetricFog.CAGPHABINKG = 0f;
			VolumetricFog.FOKHHHJJMCE(false, MGALEAJOGPL, GEFEOMDOOHD.x, GEFEOMDOOHD.y, GEFEOMDOOHD.z, volumetricFog);
			return volumetricFog;
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x004ABF0C File Offset: 0x004AA10C
		private void PINLMCCKKNA()
		{
			this.OIOFPBCMMDL = -1f;
			this.NHNKDLKINKG = -1f;
			this.CPDLIPDNIBP = this._alpha;
			this._skyColor.a = this._skyAlpha;
			this.ILOCCABDDMI = this._skyAlpha;
			this.ANFNPKEGGGH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Materials/VolumetricFog"));
			this.ANFNPKEGGGH.hideFlags = HideFlags.DontSave;
			this.CDCBEKBHMMM = base.gameObject.GetComponent<Camera>();
			if (this.CDCBEKBHMMM.depthTextureMode == DepthTextureMode.None)
			{
				this.CDCBEKBHMMM.depthTextureMode = DepthTextureMode.Depth;
			}
			Texture2D texture2D = Resources.Load<Texture2D>("Textures/Noise3");
			this.APBCGMJLEFB = texture2D.GetPixels();
			this.DKOLLEMPAIC = new Color[this.APBCGMJLEFB.Length];
			this.NIBGOBNJCDH = new Texture2D(texture2D.width, texture2D.height, TextureFormat.RGBA32, false);
			this.NIBGOBNJCDH.hideFlags = HideFlags.DontSave;
			this.NJAEHIDBCOA();
			this.HEFFDDEHNDO();
			if (this._pointLightTrackingAuto)
			{
				this.MCOAJJICKHL();
			}
			else
			{
				this.KLADJJFCPND();
			}
			this.OLAJCBIHPKI();
			if (this.GMDLHIFDCAK == null)
			{
				this.KMOMODPDMHI();
			}
			this.OFKDCOJNMFE();
			this.FHIEKJBFGKI = this.CDCBEKBHMMM.transform.position.y;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600A63F RID: 42559 RVA: 0x004AC051 File Offset: 0x004AA251
		// (set) Token: 0x0600A6A4 RID: 42660 RVA: 0x004AE6B8 File Offset: 0x004AC8B8
		public float PKBAEDJEGPK
		{
			get
			{
				return this._lightScatteringExposure;
			}
			set
			{
				if (value != this._lightScatteringExposure)
				{
					this._lightScatteringExposure = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x004ABF01 File Offset: 0x004AA101
		public float MAMAEIKKDOM()
		{
			return this._maxFogLength;
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x004AB75B File Offset: 0x004A995B
		public float LKAPAEFEEHO()
		{
			return this._lightScatteringDecay;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600A642 RID: 42562 RVA: 0x004AC059 File Offset: 0x004AA259
		// (set) Token: 0x0600A64C RID: 42572 RVA: 0x004AC151 File Offset: 0x004AA351
		public float BBAHKJDEEMJ
		{
			get
			{
				return this._fogOfWarRestoreDelay;
			}
			set
			{
				if (value != this._fogOfWarRestoreDelay)
				{
					this._fogOfWarRestoreDelay = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600A644 RID: 42564 RVA: 0x004AC069 File Offset: 0x004AA269
		// (set) Token: 0x0600A670 RID: 42608 RVA: 0x004AE176 File Offset: 0x004AC376
		public float DKIHDOELFEH
		{
			get
			{
				return this._distance;
			}
			set
			{
				if (value != this._distance)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._distance = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x004AC074 File Offset: 0x004AA274
		private void OnDestroy()
		{
			if (this.AABLBMICILO != null)
			{
				UnityEngine.Object.DestroyImmediate(this.AABLBMICILO);
				this.AABLBMICILO = null;
			}
			if (this.NIBGOBNJCDH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.NIBGOBNJCDH);
				this.NIBGOBNJCDH = null;
			}
			if (this.ANFNPKEGGGH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.ANFNPKEGGGH);
				this.ANFNPKEGGGH = null;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600A646 RID: 42566 RVA: 0x004AB647 File Offset: 0x004A9847
		// (set) Token: 0x0600A686 RID: 42630 RVA: 0x004AE3D8 File Offset: 0x004AC5D8
		public Color MFIHIKDAFGC
		{
			get
			{
				return this._lightColor;
			}
			set
			{
				if (value != this._lightColor)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._lightColor = value;
					this.DGLHMGDJMMM();
					this.MBIKOFABHKN();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x004AC0E1 File Offset: 0x004AA2E1
		public void FGHHNIHNNOO(float DCCPCBLODIG)
		{
			if (DCCPCBLODIG != this._skyDepth)
			{
				this._skyDepth = DCCPCBLODIG;
				this.DGLHMGDJMMM();
				this.isDirty = false;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600A665 RID: 42597 RVA: 0x004ADE76 File Offset: 0x004AC076
		// (set) Token: 0x0600A648 RID: 42568 RVA: 0x004AC100 File Offset: 0x004AA300
		public float IJCKPFOPFFC
		{
			get
			{
				return this._fogOfWarRestoreDuration;
			}
			set
			{
				if (value != this._fogOfWarRestoreDuration)
				{
					this._fogOfWarRestoreDuration = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x004AA8C9 File Offset: 0x004A8AC9
		public void CMCEEMFLMHC()
		{
			this.ANHIEPCDMCI<VolumetricFogPreT>();
			this.ANHIEPCDMCI<VolumetricFogPosT>();
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600A65D RID: 42589 RVA: 0x004AC6B3 File Offset: 0x004AA8B3
		// (set) Token: 0x0600A64B RID: 42571 RVA: 0x004AC121 File Offset: 0x004AA321
		public float BPIILMBNDIA
		{
			get
			{
				return this._specularIntensity;
			}
			set
			{
				if (value != this._specularIntensity)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._specularIntensity = value;
					this.DGLHMGDJMMM();
					this.MBIKOFABHKN();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600A650 RID: 42576 RVA: 0x004AC182 File Offset: 0x004AA382
		// (set) Token: 0x0600A67C RID: 42620 RVA: 0x004AE297 File Offset: 0x004AC497
		public int NMPIFLHONMI
		{
			get
			{
				return this._fogOfWarTextureSize;
			}
			set
			{
				if (value != this._fogOfWarTextureSize && value > 16)
				{
					this._fogOfWarTextureSize = value;
					this.KMOMODPDMHI();
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x004AC18A File Offset: 0x004AA38A
		public void NDGPNHCGHID(Color DCCPCBLODIG)
		{
			if (DCCPCBLODIG != this._lightColor)
			{
				this._preset = (IBFDPDLGLBC)98;
				this._lightColor = DCCPCBLODIG;
				this.DGLHMGDJMMM();
				this.MBIKOFABHKN();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x004AB3AE File Offset: 0x004A95AE
		public bool JKNNJPEDOFK()
		{
			return this._useFogVolumes;
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x004AC1BF File Offset: 0x004AA3BF
		public bool DANPLALFHLE()
		{
			return this._renderOpaque;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600A684 RID: 42628 RVA: 0x004AE3B6 File Offset: 0x004AC5B6
		// (set) Token: 0x0600A654 RID: 42580 RVA: 0x004AC1C7 File Offset: 0x004AA3C7
		public float BDMGGBCGEEB
		{
			get
			{
				return this._fogVoidHeight;
			}
			set
			{
				if (value != this._fogVoidHeight)
				{
					this._fogVoidHeight = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x004AC21C File Offset: 0x004AA41C
		public void SetTargetAlpha(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this._useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A657 RID: 42583 RVA: 0x004AC26C File Offset: 0x004AA46C
		private void BJJKBPCAIDC()
		{
			float num = this._baselineHeight;
			Vector3 fogAreaPosition = this._fogAreaPosition;
			if (this._fogAreaRadius > 0f)
			{
				if (this._fogAreaCenter != null)
				{
					num += this._fogAreaCenter.transform.position.y;
				}
				fogAreaPosition.y = 0f;
			}
			if (this._baselineRelativeToCamera)
			{
				this.FHIEKJBFGKI += (this.CDCBEKBHMMM.transform.position.y - this.FHIEKJBFGKI) * Mathf.Clamp01(1.001f - this._baselineRelativeToCameraDelay);
				num += this.FHIEKJBFGKI - 1f;
			}
			this.ANFNPKEGGGH.SetFloat("_FogHeight", this._height);
			this.ANFNPKEGGGH.SetFloat("_FogBaseHeight", num);
			float value = 0f;
			if (LocNewLogic.getI != null)
			{
				value = LocNewLogic.getI.OGJHINOLHJJ;
			}
			this.ANFNPKEGGGH.SetFloat("_FogWaterLevel", value);
			this.ANFNPKEGGGH.SetFloat("_FogSkyHaze", this._skyHaze + num);
			Vector3 v = this._fogVoidPosition - num * Vector3.up;
			this.ANFNPKEGGGH.SetVector("_FogVoidPosition", v);
			this.ANFNPKEGGGH.SetVector("_FogAreaPosition", fogAreaPosition);
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600A690 RID: 42640 RVA: 0x004AE49C File Offset: 0x004AC69C
		// (set) Token: 0x0600A658 RID: 42584 RVA: 0x004AC3C9 File Offset: 0x004AA5C9
		public float FGFPBIDKALK
		{
			get
			{
				return this._stepping;
			}
			set
			{
				if (value != this._stepping)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._stepping = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x004AC3F4 File Offset: 0x004AA5F4
		private void MBIKOFABHKN()
		{
			if (this.ANFNPKEGGGH == null)
			{
				return;
			}
			this.PMJHCJIOPKN(this._skyAlpha);
			float num = (this._lightIntensity + this.CNDIJMEHMDB) * Mathf.Clamp01(1f - this._lightDirection.y * 2f);
			Color a = Color.Lerp(RenderSettings.ambientLight * RenderSettings.ambientIntensity, this._lightColor * num, num);
			Vector3 vector = new Vector3(-this._lightDirection.x, 0f, -this._lightDirection.z).normalized * 0.3f;
			vector.y = ((this._lightDirection.y > 0f) ? Mathf.Clamp01(1f - this._lightDirection.y) : (1f - Mathf.Clamp01(-this._lightDirection.y)));
			int width = this.NIBGOBNJCDH.width;
			int num2 = (int)((float)(Mathf.FloorToInt(vector.z * (float)width) * width) + vector.x * (float)width) + this.DKOLLEMPAIC.Length;
			float num3 = 1.0001f - this._specularThreshold;
			float num4 = vector.y / num3;
			Color a2 = this._specularColor * (1f + this._specularIntensity) * this._specularIntensity;
			bool flag = false;
			for (int i = 0; i < this.DKOLLEMPAIC.Length; i++)
			{
				int num5 = (i + num2) % this.DKOLLEMPAIC.Length;
				float a3 = this.DKOLLEMPAIC[i].a;
				float num6 = (a3 - this.DKOLLEMPAIC[num5].a) * num4;
				if (num6 < 0f)
				{
					num6 = 0f;
				}
				else if (num6 > 1f)
				{
					num6 = 1f;
				}
				Color color = (a + a2 * num6) * 0.5f;
				color.a = a3;
				if (i == 0)
				{
					if (!(this.DKOLLEMPAIC[i] != color))
					{
						break;
					}
					flag = true;
				}
				this.DKOLLEMPAIC[i] = color;
			}
			if (flag)
			{
				this.NIBGOBNJCDH.SetPixels(this.DKOLLEMPAIC);
				this.NIBGOBNJCDH.Apply();
			}
			this.ANFNPKEGGGH.SetTexture("_NoiseTex", this.NIBGOBNJCDH);
			this.KLDEEGLHHID = Time.time;
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x004AC668 File Offset: 0x004AA868
		public float GetPointLightRange(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightRanges.Length)
			{
				return 0f;
			}
			return this._pointLightRanges[CLBPBJGLHEE];
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600A65F RID: 42591 RVA: 0x004AC6E5 File Offset: 0x004AA8E5
		// (set) Token: 0x0600A65B RID: 42587 RVA: 0x004AC687 File Offset: 0x004AA887
		public Vector3 DPOLOFPPAGH
		{
			get
			{
				return this._fogVoidPosition;
			}
			set
			{
				if (value != this._fogVoidPosition)
				{
					this._fogVoidPosition = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600A65C RID: 42588 RVA: 0x004AC6AB File Offset: 0x004AA8AB
		// (set) Token: 0x0600A6A5 RID: 42661 RVA: 0x004AE6D7 File Offset: 0x004AC8D7
		public int OJIECMNALGE
		{
			get
			{
				return this._downsampling;
			}
			set
			{
				if (value != this._downsampling)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._downsampling = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600A69B RID: 42651 RVA: 0x004AE5BE File Offset: 0x004AC7BE
		// (set) Token: 0x0600A65E RID: 42590 RVA: 0x004AC6BB File Offset: 0x004AA8BB
		public float CGFLAIMHHOO
		{
			get
			{
				return this._alpha;
			}
			set
			{
				if (value != this._alpha)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._alpha = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600A693 RID: 42643 RVA: 0x004AE4CB File Offset: 0x004AC6CB
		// (set) Token: 0x0600A661 RID: 42593 RVA: 0x004ACA7E File Offset: 0x004AAC7E
		public float IPDLHEEIIHD
		{
			get
			{
				return this._skyNoiseStrength;
			}
			set
			{
				if (value != this._skyNoiseStrength)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._skyNoiseStrength = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A662 RID: 42594 RVA: 0x004ACAA8 File Offset: 0x004AACA8
		private void OFKDCOJNMFE()
		{
			IBFDPDLGLBC preset = this._preset;
			if (preset <= IBFDPDLGLBC.SeaClouds)
			{
				if (preset <= IBFDPDLGLBC.Mist)
				{
					if (preset != IBFDPDLGLBC.Clear)
					{
						if (preset == IBFDPDLGLBC.Mist)
						{
							this._skySpeed = 0.3f;
							this._skyHaze = 15f;
							this._skyNoiseStrength = 0.1f;
							this._skyAlpha = 0.8f;
							this._density = 0.3f;
							this._noiseStrength = 0.6f;
							this._noiseScale = 1f;
							this._distance = 0f;
							this._distanceFallOff = 0f;
							this._height = 6f;
							this._stepping = 8f;
							this._steppingNear = 0f;
							this._alpha = 1f;
							this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
							this._skyColor = this._color;
							this._specularColor = new Color(1f, 1f, 0.8f, 1f);
							this._specularIntensity = 0.1f;
							this._specularThreshold = 0.6f;
							this._lightColor = Color.white;
							this._lightIntensity = 0.12f;
							this._speed = 0.01f;
							this._fogOfWarEnabled = false;
							this._downsampling = 1;
							this._baselineRelativeToCamera = false;
							this.CheckWaterLevel(false);
							this._fogVoidRadius = 0f;
						}
					}
					else
					{
						this._density = 0f;
						this._fogOfWarEnabled = false;
						this._fogVoidRadius = 0f;
					}
				}
				else if (preset != IBFDPDLGLBC.WindyMist)
				{
					if (preset != IBFDPDLGLBC.LowClouds)
					{
						if (preset == IBFDPDLGLBC.SeaClouds)
						{
							this._skySpeed = 0.3f;
							this._skyHaze = 60f;
							this._skyNoiseStrength = 1f;
							this._skyAlpha = 0.96f;
							this._density = 1f;
							this._noiseStrength = 1f;
							this._noiseScale = 1.5f;
							this._distance = 0f;
							this._distanceFallOff = 0f;
							this._height = 12.4f;
							this._stepping = 6f;
							this._alpha = 0.98f;
							this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
							this._skyColor = this._color;
							this._specularColor = new Color(1f, 1f, 0.8f, 1f);
							this._specularIntensity = 0.259f;
							this._specularThreshold = 0.6f;
							this._lightColor = Color.white;
							this._lightIntensity = 0.15f;
							this._speed = 0.008f;
							this._fogOfWarEnabled = false;
							this._downsampling = 1;
							this._baselineRelativeToCamera = false;
							this.CheckWaterLevel(false);
							this._fogVoidRadius = 0f;
						}
					}
					else
					{
						this._skySpeed = 0.3f;
						this._skyHaze = 60f;
						this._skyNoiseStrength = 1f;
						this._skyAlpha = 0.96f;
						this._density = 1f;
						this._noiseStrength = 0.7f;
						this._noiseScale = 1f;
						this._distance = 0f;
						this._distanceFallOff = 0f;
						this._height = 4f;
						this._stepping = 12f;
						this._steppingNear = 0f;
						this._alpha = 0.98f;
						this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
						this._skyColor = this._color;
						this._specularColor = new Color(1f, 1f, 0.8f, 1f);
						this._specularIntensity = 0.15f;
						this._specularThreshold = 0.6f;
						this._lightColor = Color.white;
						this._lightIntensity = 0.15f;
						this._speed = 0.008f;
						this._fogOfWarEnabled = false;
						this._downsampling = 1;
						this._baselineRelativeToCamera = false;
						this.CheckWaterLevel(false);
						this._fogVoidRadius = 0f;
					}
				}
				else
				{
					this._skySpeed = 0.3f;
					this._skyHaze = 25f;
					this._skyNoiseStrength = 0.1f;
					this._skyAlpha = 0.85f;
					this._density = 0.3f;
					this._noiseStrength = 0.5f;
					this._noiseScale = 1.15f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 6.5f;
					this._stepping = 10f;
					this._steppingNear = 0f;
					this._alpha = 1f;
					this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(1f, 1f, 0.8f, 1f);
					this._specularIntensity = 0.1f;
					this._specularThreshold = 0.6f;
					this._lightColor = Color.white;
					this._lightIntensity = 0f;
					this._speed = 0.15f;
					this._fogOfWarEnabled = false;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
				}
			}
			else if (preset <= IBFDPDLGLBC.Fog)
			{
				switch (preset)
				{
				case IBFDPDLGLBC.GroundFog:
					this._skySpeed = 0.3f;
					this._skyHaze = 0f;
					this._skyNoiseStrength = 0.1f;
					this._skyAlpha = 0.85f;
					this._density = 0.6f;
					this._noiseStrength = 0.479f;
					this._noiseScale = 1.15f;
					this._distance = 5f;
					this._distanceFallOff = 1f;
					this._height = 1.5f;
					this._stepping = 8f;
					this._steppingNear = 0f;
					this._alpha = 0.95f;
					this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(1f, 1f, 0.8f, 1f);
					this._specularIntensity = 0.2f;
					this._specularThreshold = 0.6f;
					this._lightColor = Color.white;
					this._lightIntensity = 0.2f;
					this._speed = 0.01f;
					this._fogOfWarEnabled = false;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					break;
				case IBFDPDLGLBC.FrostedGround:
					this._skySpeed = 0f;
					this._skyHaze = 0f;
					this._skyNoiseStrength = 0.729f;
					this._skyAlpha = 0.55f;
					this._density = 1f;
					this._noiseStrength = 0.164f;
					this._noiseScale = 1.81f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 0.5f;
					this._stepping = 20f;
					this._steppingNear = 50f;
					this._alpha = 0.97f;
					this._color = new Color(0.546f, 0.648f, 0.71f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(0.792f, 0.792f, 0.792f, 1f);
					this._specularIntensity = 1f;
					this._specularThreshold = 0.866f;
					this._lightColor = new Color(0.972f, 0.972f, 0.972f, 1f);
					this._lightIntensity = 0.743f;
					this._speed = 0f;
					this._fogOfWarEnabled = false;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					break;
				case IBFDPDLGLBC.FoggyLake:
					this._skySpeed = 0.3f;
					this._skyHaze = 40f;
					this._skyNoiseStrength = 0.574f;
					this._skyAlpha = 0.827f;
					this._density = 1f;
					this._noiseStrength = 0.03f;
					this._noiseScale = 5.77f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 4f;
					this._stepping = 6f;
					this._steppingNear = 14.4f;
					this._alpha = 1f;
					this._color = new Color(0f, 0.96f, 1f, 1f);
					this._skyColor = this._color;
					this._specularColor = Color.white;
					this._lightColor = Color.white;
					this._specularIntensity = 0.861f;
					this._specularThreshold = 0.907f;
					this._lightIntensity = 0.126f;
					this._speed = 0f;
					this._fogOfWarEnabled = false;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					break;
				default:
					if (preset == IBFDPDLGLBC.Fog)
					{
						this._skySpeed = 0.3f;
						this._skyHaze = 144f;
						this._skyNoiseStrength = 0.7f;
						this._skyAlpha = 0.9f;
						this._density = 0.35f;
						this._noiseStrength = 0.3f;
						this._noiseScale = 1f;
						this._distance = 20f;
						this._distanceFallOff = 0.7f;
						this._height = 8f;
						this._stepping = 8f;
						this._steppingNear = 0f;
						this._alpha = 0.97f;
						this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
						this._skyColor = this._color;
						this._specularColor = new Color(1f, 1f, 0.8f, 1f);
						this._specularIntensity = 0f;
						this._specularThreshold = 0.6f;
						this._lightColor = Color.white;
						this._lightIntensity = 0f;
						this._speed = 0.05f;
						this._fogOfWarEnabled = false;
						this._downsampling = 1;
						this._baselineRelativeToCamera = false;
						this.CheckWaterLevel(false);
						this._fogVoidRadius = 0f;
					}
					break;
				}
			}
			else if (preset != IBFDPDLGLBC.HeavyFog)
			{
				switch (preset)
				{
				case IBFDPDLGLBC.SandStorm1:
					this._skySpeed = 0.35f;
					this._skyHaze = 388f;
					this._skyNoiseStrength = 0.847f;
					this._skyAlpha = 1f;
					this._density = 0.487f;
					this._noiseStrength = 0.758f;
					this._noiseScale = 1.71f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 16f;
					this._stepping = 6f;
					this._steppingNear = 0f;
					this._alpha = 1f;
					this._color = new Color(0.505f, 0.505f, 0.505f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(1f, 1f, 0.8f, 1f);
					this._specularIntensity = 0f;
					this._specularThreshold = 0.6f;
					this._lightColor = Color.white;
					this._lightIntensity = 0f;
					this._speed = 0.3f;
					this._windDirection = Vector3.right;
					this._fogOfWarEnabled = false;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					break;
				case IBFDPDLGLBC.Smoke:
					this._skySpeed = 0.109f;
					this._skyHaze = 10f;
					this._skyNoiseStrength = 0.119f;
					this._skyAlpha = 1f;
					this._density = 1f;
					this._noiseStrength = 0.767f;
					this._noiseScale = 1.6f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 8f;
					this._stepping = 12f;
					this._steppingNear = 25f;
					this._alpha = 1f;
					this._color = new Color(0.125f, 0.125f, 0.125f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(1f, 1f, 1f, 1f);
					this._specularIntensity = 0.575f;
					this._specularThreshold = 0.6f;
					this._lightColor = Color.white;
					this._lightIntensity = 1f;
					this._speed = 0.075f;
					this._windDirection = Vector3.right;
					this._fogOfWarEnabled = false;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._baselineHeight += 8f;
					this._fogVoidRadius = 0f;
					break;
				case IBFDPDLGLBC.ToxicSwamp:
					this._skySpeed = 0.062f;
					this._skyHaze = 22f;
					this._skyNoiseStrength = 0.694f;
					this._skyAlpha = 1f;
					this._density = 1f;
					this._noiseStrength = 1f;
					this._noiseScale = 1f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 2.5f;
					this._stepping = 20f;
					this._steppingNear = 50f;
					this._alpha = 0.95f;
					this._color = new Color(0.0238f, 0.175f, 0.109f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(0.593f, 0.625f, 0.207f, 1f);
					this._specularIntensity = 0.735f;
					this._specularThreshold = 0.6f;
					this._lightColor = new Color(0.73f, 0.746f, 0.511f, 1f);
					this._lightIntensity = 0.492f;
					this._speed = 0.0003f;
					this._windDirection = Vector3.right;
					this._fogOfWarEnabled = false;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					break;
				case IBFDPDLGLBC.SandStorm2:
					this._skySpeed = 0f;
					this._skyHaze = 0f;
					this._skyNoiseStrength = 0.729f;
					this._skyAlpha = 0.55f;
					this._density = 0.545f;
					this._noiseStrength = 1f;
					this._noiseScale = 3f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 12f;
					this._stepping = 5f;
					this._steppingNear = 19.6f;
					this._alpha = 0.96f;
					this._color = new Color(0.609f, 0.609f, 0.609f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(0.589f, 0.621f, 0.207f, 1f);
					this._specularIntensity = 0.505f;
					this._specularThreshold = 0.6f;
					this._lightColor = new Color(0.726f, 0.742f, 0.507f, 1f);
					this._lightIntensity = 0.581f;
					this._speed = 0.168f;
					this._windDirection = Vector3.right;
					this._fogOfWarEnabled = false;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					break;
				default:
					if (preset == IBFDPDLGLBC.WorldEdge)
					{
						this._skySpeed = 0.3f;
						this._skyHaze = 60f;
						this._skyNoiseStrength = 1f;
						this._skyAlpha = 0.96f;
						this._density = 1f;
						this._noiseStrength = 1f;
						this._noiseScale = 3f;
						this._distance = 0f;
						this._distanceFallOff = 0f;
						this._height = 20f;
						this._stepping = 6f;
						this._alpha = 0.98f;
						this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
						this._skyColor = this._color;
						this._specularColor = new Color(1f, 1f, 0.8f, 1f);
						this._specularIntensity = 0.259f;
						this._specularThreshold = 0.6f;
						this._lightColor = Color.white;
						this._lightIntensity = 0.15f;
						this._speed = 0.03f;
						this._fogOfWarEnabled = false;
						this._downsampling = 2;
						this._baselineRelativeToCamera = false;
						this.CheckWaterLevel(false);
						Terrain activeTerrain = VolumetricFog.GetActiveTerrain();
						if (activeTerrain != null)
						{
							this._fogVoidPosition = activeTerrain.transform.position + activeTerrain.terrainData.size * 0.5f;
							this._fogVoidRadius = activeTerrain.terrainData.size.x * 0.45f;
							this._fogVoidHeight = activeTerrain.terrainData.size.y;
							this._fogVoidDepth = activeTerrain.terrainData.size.z * 0.45f;
							this._fogVoidFallOff = 6f;
							this._fogAreaRadius = 0f;
							this._character = null;
							this._fogAreaCenter = null;
							float x = activeTerrain.terrainData.size.x;
							if (this.CDCBEKBHMMM.farClipPlane < x)
							{
								this.CDCBEKBHMMM.farClipPlane = x;
							}
							if (this._maxFogLength < x * 0.6f)
							{
								this._maxFogLength = x * 0.6f;
							}
						}
					}
					break;
				}
			}
			else
			{
				this._skySpeed = 0.05f;
				this._skyHaze = 500f;
				this._skyNoiseStrength = 0.96f;
				this._skyAlpha = 1f;
				this._density = 0.35f;
				this._noiseStrength = 0.1f;
				this._noiseScale = 1f;
				this._distance = 20f;
				this._distanceFallOff = 0.8f;
				this._height = 18f;
				this._stepping = 6f;
				this._steppingNear = 0f;
				this._alpha = 1f;
				this._color = new Color(0.91f, 0.91f, 0.91f, 1f);
				this._skyColor = this._color;
				this._specularColor = new Color(1f, 1f, 0.8f, 1f);
				this._specularIntensity = 0f;
				this._specularThreshold = 0.6f;
				this._lightColor = Color.white;
				this._lightIntensity = 0f;
				this._speed = 0.015f;
				this._fogOfWarEnabled = false;
				this._downsampling = 1;
				this._baselineRelativeToCamera = false;
				this.CheckWaterLevel(false);
				this._fogVoidRadius = 0f;
			}
			this.KMOMODPDMHI();
			this.DGLHMGDJMMM();
			this.BBMDGCFBGGP();
			this.NJAEHIDBCOA();
			this.MBIKOFABHKN();
		}

		// Token: 0x0600A663 RID: 42595 RVA: 0x004ADE0C File Offset: 0x004AC00C
		private void KMOMODPDMHI()
		{
			if (!this._fogOfWarEnabled)
			{
				return;
			}
			int num = this.OAANPCIKMNF(this._fogOfWarTextureSize, 1f);
			this.GMDLHIFDCAK = new Texture2D(num, num, TextureFormat.Alpha8, false);
			this.GMDLHIFDCAK.hideFlags = HideFlags.DontSave;
			this.GMDLHIFDCAK.filterMode = FilterMode.Bilinear;
			this.GMDLHIFDCAK.wrapMode = TextureWrapMode.Clamp;
			this.ResetFogOfWar();
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600A667 RID: 42599 RVA: 0x004AC1BF File Offset: 0x004AA3BF
		// (set) Token: 0x0600A666 RID: 42598 RVA: 0x004ADE7E File Offset: 0x004AC07E
		public bool IKKACJEEEHG
		{
			get
			{
				return this._renderOpaque;
			}
			set
			{
				if (value != this._renderOpaque)
				{
					this._renderOpaque = value;
					if (!this._renderOpaque)
					{
						this._improveTransparency = false;
					}
					this.BBMDGCFBGGP();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x004ADEAC File Offset: 0x004AC0AC
		public void BKJJMHLKKNA()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int height = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num = height * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num)
			{
				this.GNGCEOOOGJG = new Color32[num];
			}
			Color32 color = new Color32((byte)-167, (byte)-186, 147, (byte)-57);
			for (int i = 0; i < num; i += 0)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
			this.isDirty = true;
		}

		// Token: 0x0600A66A RID: 42602 RVA: 0x004ADF82 File Offset: 0x004AC182
		public float LPDBHJECMMP()
		{
			return this._skySpeed;
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x004ADF8A File Offset: 0x004AC18A
		public static VolumetricFog CreateFogArea(Vector3 MGALEAJOGPL, float AEIAFIIMHEL)
		{
			return VolumetricFog.CreateFogArea(Camera.main.gameObject, MGALEAJOGPL, AEIAFIIMHEL);
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x004ADF9D File Offset: 0x004AC19D
		private void BBMDGCFBGGP()
		{
			if (this._renderOpaque)
			{
				this.ANHIEPCDMCI<VolumetricFogPosT>();
				this.EONEODPEJCJ<VolumetricFogPreT>();
				return;
			}
			this.ANHIEPCDMCI<VolumetricFogPreT>();
			this.EONEODPEJCJ<VolumetricFogPosT>();
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x004ADFC0 File Offset: 0x004AC1C0
		public void ResetFogOfWarAlpha(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this._fogOfWarCenter.x) / this._fogOfWarSize.x + 0.5f;
			if (num < 0f || num > 1f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this._fogOfWarCenter.z) / this._fogOfWarSize.z + 0.5f;
			if (num2 < 0f || num2 > 1f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int height = this.GMDLHIFDCAK.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			float num6 = AEIAFIIMHEL / this._fogOfWarSize.z;
			int num7 = Mathf.FloorToInt((float)height * num6);
			for (int i = num4 - num7; i <= num4 + num7; i++)
			{
				if (i > 0 && i < height - 1)
				{
					for (int j = num3 - num7; j <= num3 + num7; j++)
					{
						if (j > 0 && j < width - 1 && Mathf.FloorToInt(Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)))) <= num7)
						{
							num5 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num5];
							color.a = byte.MaxValue;
							this.GNGCEOOOGJG[num5] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600A66F RID: 42607 RVA: 0x004AE16E File Offset: 0x004AC36E
		// (set) Token: 0x0600A6A8 RID: 42664 RVA: 0x004AE722 File Offset: 0x004AC922
		public float KNKNDOFLNMP
		{
			get
			{
				return this._fogAreaRadius;
			}
			set
			{
				if (value != this._fogAreaRadius)
				{
					this._fogAreaRadius = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600A678 RID: 42616 RVA: 0x004AE210 File Offset: 0x004AC410
		// (set) Token: 0x0600A671 RID: 42609 RVA: 0x004AE1A0 File Offset: 0x004AC3A0
		public float PKJPDLKCDJE
		{
			get
			{
				return this._skyDepth;
			}
			set
			{
				if (value != this._skyDepth)
				{
					this._skyDepth = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A672 RID: 42610 RVA: 0x004AC061 File Offset: 0x004AA261
		public float IAIGEBOGEFI()
		{
			return this._skyAlpha;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600A689 RID: 42633 RVA: 0x004AB425 File Offset: 0x004A9625
		// (set) Token: 0x0600A673 RID: 42611 RVA: 0x004AE1BF File Offset: 0x004AC3BF
		public bool GCGOFNOLIMJ
		{
			get
			{
				return this._fogOfWarEnabled;
			}
			set
			{
				if (value != this._fogOfWarEnabled)
				{
					this._fogOfWarEnabled = value;
					this.KMOMODPDMHI();
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600A674 RID: 42612 RVA: 0x004ADF82 File Offset: 0x004AC182
		// (set) Token: 0x0600A68B RID: 42635 RVA: 0x004AE44B File Offset: 0x004AC64B
		public float AAFHPHAMEHC
		{
			get
			{
				return this._skySpeed;
			}
			set
			{
				if (value != this._skySpeed)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._skySpeed = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600A67F RID: 42623 RVA: 0x004AE309 File Offset: 0x004AC509
		// (set) Token: 0x0600A675 RID: 42613 RVA: 0x004AA19A File Offset: 0x004A839A
		public bool MDJKLNALBLD
		{
			get
			{
				return this._jitter;
			}
			set
			{
				if (value != this._jitter)
				{
					this._jitter = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A677 RID: 42615 RVA: 0x004AE1EC File Offset: 0x004AC3EC
		public void LPFHNIFAAMC(int DCCPCBLODIG)
		{
			if (DCCPCBLODIG != this._downsampling)
			{
				this._preset = (IBFDPDLGLBC)(-43);
				this._downsampling = DCCPCBLODIG;
				this.isDirty = true;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600A679 RID: 42617 RVA: 0x004AE218 File Offset: 0x004AC418
		// (set) Token: 0x0600A696 RID: 42646 RVA: 0x004AE511 File Offset: 0x004AC711
		public float HGABMLKLEPE
		{
			get
			{
				return this._noiseScale;
			}
			set
			{
				if (value != this._noiseScale)
				{
					this._preset = IBFDPDLGLBC.Custom;
					this._noiseScale = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x004AE220 File Offset: 0x004AC420
		private void ANHIEPCDMCI<T>() where T : HPLMICNEDGL
		{
			T[] componentsInChildren = base.GetComponentsInChildren<T>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].ANCIMKLOHFH == this || componentsInChildren[i].ANCIMKLOHFH == null)
				{
					componentsInChildren[i].DestroySelf();
				}
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600A67B RID: 42619 RVA: 0x004AE28F File Offset: 0x004AC48F
		// (set) Token: 0x0600A697 RID: 42647 RVA: 0x004AE53B File Offset: 0x004AC73B
		public GameObject PBALDAEFJEK
		{
			get
			{
				return this._fogAreaCenter;
			}
			set
			{
				if (value != this._character)
				{
					this._fogAreaCenter = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A67D RID: 42621 RVA: 0x004AE2C1 File Offset: 0x004AC4C1
		public void SetPointLightColor(int CLBPBJGLHEE, Color LBCGACKJCJB)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLightColors.Length)
			{
				return;
			}
			if (LBCGACKJCJB != this._pointLightColors[CLBPBJGLHEE])
			{
				this._pointLightColors[CLBPBJGLHEE] = LBCGACKJCJB;
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A680 RID: 42624 RVA: 0x004AE314 File Offset: 0x004AC514
		private static void FOKHHHJJMCE(bool GMGCKCCNBLF, Vector3 MGALEAJOGPL, float AEIAFIIMHEL, float ILLKFNCFGMP, float OLIDKPCNOMC, VolumetricFog ANCIMKLOHFH)
		{
			FogAreaCullingManager component = UnityEngine.Object.Instantiate<GameObject>(GMGCKCCNBLF ? Resources.Load<GameObject>("Prefabs/FogSphereArea") : Resources.Load<GameObject>("Prefabs/FogBoxArea")).GetComponent<FogAreaCullingManager>();
			if (component == null)
			{
				Debug.Log("FogAreaCullingManager missing script.");
				return;
			}
			component.fog = ANCIMKLOHFH;
			component.transform.position = MGALEAJOGPL;
			component.transform.localScale = new Vector3(AEIAFIIMHEL, ILLKFNCFGMP, OLIDKPCNOMC);
			component.UpdateFogAreaExtents();
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600A682 RID: 42626 RVA: 0x004AE3A6 File Offset: 0x004AC5A6
		// (set) Token: 0x0600A692 RID: 42642 RVA: 0x004AE4AC File Offset: 0x004AC6AC
		public float AGLFEEHFCHB
		{
			get
			{
				return this._fogVoidRadius;
			}
			set
			{
				if (value != this._fogVoidRadius)
				{
					this._fogVoidRadius = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x004AE3BE File Offset: 0x004AC5BE
		private void Start()
		{
			this.CPDLIPDNIBP = this._alpha;
			this.ILOCCABDDMI = this._skyAlpha;
		}

		// Token: 0x0600A687 RID: 42631 RVA: 0x004AA8E6 File Offset: 0x004A8AE6
		public GameObject CKPBJAKMBNF()
		{
			return this._sun;
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x004AE40D File Offset: 0x004AC60D
		public void SetPointLight(int CLBPBJGLHEE, GameObject OHCKLJMGNHC)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE > this._pointLights.Length)
			{
				return;
			}
			if (this._pointLights[CLBPBJGLHEE] != OHCKLJMGNHC)
			{
				this._pointLights[CLBPBJGLHEE] = OHCKLJMGNHC;
				this.KLADJJFCPND();
				this.DGLHMGDJMMM();
				this.isDirty = true;
			}
		}

		// Token: 0x0600A68D RID: 42637 RVA: 0x004AE28F File Offset: 0x004AC48F
		public GameObject CBAHGICEKCL()
		{
			return this._fogAreaCenter;
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x004ADF9D File Offset: 0x004AC19D
		private void DKFICBGPKML()
		{
			if (this._renderOpaque)
			{
				this.ANHIEPCDMCI<VolumetricFogPosT>();
				this.EONEODPEJCJ<VolumetricFogPreT>();
				return;
			}
			this.ANHIEPCDMCI<VolumetricFogPreT>();
			this.EONEODPEJCJ<VolumetricFogPosT>();
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x004AE576 File Offset: 0x004AC776
		private void HEFFDDEHNDO()
		{
			if (this._sun != null)
			{
				this.HLGMMNEANMP = this._sun.GetComponent<Light>();
				return;
			}
			this.HLGMMNEANMP = null;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600A69E RID: 42654 RVA: 0x004AE5D6 File Offset: 0x004AC7D6
		// (set) Token: 0x0600A6A6 RID: 42662 RVA: 0x004AE6FB File Offset: 0x004AC8FB
		public float FIOHBANNBEC
		{
			get
			{
				return this._fogAreaFallOff;
			}
			set
			{
				if (value != this._fogAreaFallOff)
				{
					this._fogAreaFallOff = value;
					this.DGLHMGDJMMM();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x0600A6A0 RID: 42656 RVA: 0x004AE5E8 File Offset: 0x004AC7E8
		private void DIDICIMKFCK(int OCNGPCPMCPM, int ADMFAEOOOHD, byte LFLNBKCDOFJ)
		{
			int count = this.LECEDJIHNOF.Count;
			VolumetricFog.JLDHOIEEOID jldhoieeoid = null;
			for (int i = 0; i < count; i++)
			{
				VolumetricFog.JLDHOIEEOID jldhoieeoid2 = this.LECEDJIHNOF[i];
				if (jldhoieeoid2.OCNGPCPMCPM == OCNGPCPMCPM && jldhoieeoid2.ADMFAEOOOHD == ADMFAEOOOHD)
				{
					jldhoieeoid = jldhoieeoid2;
					break;
				}
				if (!jldhoieeoid2.PMPMAALNEBO)
				{
					jldhoieeoid = jldhoieeoid2;
				}
			}
			if (jldhoieeoid == null)
			{
				jldhoieeoid = new VolumetricFog.JLDHOIEEOID();
				this.LECEDJIHNOF.Add(jldhoieeoid);
			}
			jldhoieeoid.OCNGPCPMCPM = OCNGPCPMCPM;
			jldhoieeoid.ADMFAEOOOHD = ADMFAEOOOHD;
			jldhoieeoid.JOJHMMFOPPJ = Time.time;
			jldhoieeoid.LFLNBKCDOFJ = LFLNBKCDOFJ;
			jldhoieeoid.PMPMAALNEBO = true;
		}

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x004AE680 File Offset: 0x004AC880
		public void AMMCECOEGDF(bool DCCPCBLODIG)
		{
			if (DCCPCBLODIG != this._sunCopyColor)
			{
				this._sunCopyColor = DCCPCBLODIG;
				this.DGLHMGDJMMM();
				this.isDirty = false;
			}
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x004AE5C6 File Offset: 0x004AC7C6
		public bool JPABCNKJGOA()
		{
			return this._baselineRelativeToCamera;
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x004AE76C File Offset: 0x004AC96C
		private void OnEnable()
		{
			if (this._fogVoidInverted)
			{
				this._fogVoidInverted = false;
				this._fogAreaCenter = this._character;
				this._fogAreaDepth = this._fogVoidDepth;
				this._fogAreaFallOff = this._fogVoidFallOff;
				this._fogAreaHeight = this._fogVoidHeight;
				this._fogAreaPosition = this._fogVoidPosition;
				this._fogAreaRadius = this._fogVoidRadius;
				this._fogVoidRadius = 0f;
				this._character = null;
			}
			if (this.ANFNPKEGGGH == null)
			{
				this.PINLMCCKKNA();
			}
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x004AE7F8 File Offset: 0x004AC9F8
		private void PMJHCJIOPKN(float CGFLAIMHHOO)
		{
			if (this.ANFNPKEGGGH == null)
			{
				return;
			}
			if (this._sun != null)
			{
				if (this._sun.transform.forward != this._lightDirection)
				{
					this._lightDirection = this._sun.transform.forward;
				}
				if (this.HLGMMNEANMP != null)
				{
					if (this.HLGMMNEANMP.color != this._lightColor && this._sunCopyColor)
					{
						this._lightColor = this.HLGMMNEANMP.color;
					}
					this.CNDIJMEHMDB = this.HLGMMNEANMP.intensity;
				}
			}
			else
			{
				this.CNDIJMEHMDB = 1f;
			}
			float b = (this._lightIntensity + this.CNDIJMEHMDB) * Mathf.Clamp01(1f - this._lightDirection.y);
			this._skyColor.a = CGFLAIMHHOO;
			Color value = b * this._skyColor;
			this.ANFNPKEGGGH.SetColor("_FogSkyColor", value);
		}

		// Token: 0x0400152B RID: 5419
		private const float NOJNOEENGIP = 0.2f;

		// Token: 0x0400152C RID: 5420
		private static VolumetricFog BOKKCFIFEED;

		// Token: 0x0400152D RID: 5421
		[HideInInspector]
		public bool isDirty;

		// Token: 0x0400152E RID: 5422
		[SerializeField]
		private IBFDPDLGLBC _preset = IBFDPDLGLBC.Mist;

		// Token: 0x0400152F RID: 5423
		[SerializeField]
		private bool _useFogVolumes;

		// Token: 0x04001530 RID: 5424
		[SerializeField]
		private bool _improveTransparency;

		// Token: 0x04001531 RID: 5425
		[SerializeField]
		private bool _renderOpaque = true;

		// Token: 0x04001532 RID: 5426
		[SerializeField]
		private GameObject _sun;

		// Token: 0x04001533 RID: 5427
		[SerializeField]
		private bool _sunCopyColor = true;

		// Token: 0x04001534 RID: 5428
		[SerializeField]
		private float _density = 1f;

		// Token: 0x04001535 RID: 5429
		[SerializeField]
		private float _noiseStrength = 0.8f;

		// Token: 0x04001536 RID: 5430
		[SerializeField]
		private float _distance;

		// Token: 0x04001537 RID: 5431
		[SerializeField]
		private float _maxFogLength = 1000f;

		// Token: 0x04001538 RID: 5432
		[SerializeField]
		private float _distanceFallOff;

		// Token: 0x04001539 RID: 5433
		[SerializeField]
		private float _height = 4f;

		// Token: 0x0400153A RID: 5434
		[SerializeField]
		private float _baselineHeight;

		// Token: 0x0400153B RID: 5435
		[SerializeField]
		private bool _baselineRelativeToCamera;

		// Token: 0x0400153C RID: 5436
		[SerializeField]
		private float _baselineRelativeToCameraDelay;

		// Token: 0x0400153D RID: 5437
		[SerializeField]
		private float _noiseScale = 1f;

		// Token: 0x0400153E RID: 5438
		[SerializeField]
		private float _alpha = 1f;

		// Token: 0x0400153F RID: 5439
		[SerializeField]
		private Color _color = new Color(0.89f, 0.89f, 0.89f, 1f);

		// Token: 0x04001540 RID: 5440
		[SerializeField]
		private Color _specularColor = new Color(1f, 1f, 0.8f, 1f);

		// Token: 0x04001541 RID: 5441
		[SerializeField]
		private float _specularThreshold = 0.6f;

		// Token: 0x04001542 RID: 5442
		[SerializeField]
		private float _specularIntensity = 0.2f;

		// Token: 0x04001543 RID: 5443
		[SerializeField]
		private Vector3 _lightDirection = new Vector3(1f, 0f, -1f);

		// Token: 0x04001544 RID: 5444
		[SerializeField]
		private float _lightIntensity = 0.2f;

		// Token: 0x04001545 RID: 5445
		[SerializeField]
		private Color _lightColor = Color.white;

		// Token: 0x04001546 RID: 5446
		[SerializeField]
		private float _speed = 0.01f;

		// Token: 0x04001547 RID: 5447
		[SerializeField]
		private Vector3 _windDirection = new Vector3(-1f, 0f, 0f);

		// Token: 0x04001548 RID: 5448
		[SerializeField]
		private Color _skyColor = new Color(0.89f, 0.89f, 0.89f, 1f);

		// Token: 0x04001549 RID: 5449
		[SerializeField]
		private float _skyHaze = 50f;

		// Token: 0x0400154A RID: 5450
		[SerializeField]
		private float _skySpeed = 0.3f;

		// Token: 0x0400154B RID: 5451
		[SerializeField]
		private float _skyNoiseStrength = 0.1f;

		// Token: 0x0400154C RID: 5452
		[SerializeField]
		private float _skyAlpha = 1f;

		// Token: 0x0400154D RID: 5453
		[SerializeField]
		private float _skyDepth = 0.999f;

		// Token: 0x0400154E RID: 5454
		[SerializeField]
		private GameObject _character;

		// Token: 0x0400154F RID: 5455
		[SerializeField]
		private float _fogVoidFallOff = 1f;

		// Token: 0x04001550 RID: 5456
		[SerializeField]
		private float _fogVoidRadius;

		// Token: 0x04001551 RID: 5457
		[SerializeField]
		private Vector3 _fogVoidPosition = Vector3.zero;

		// Token: 0x04001552 RID: 5458
		[SerializeField]
		private float _fogVoidDepth;

		// Token: 0x04001553 RID: 5459
		[SerializeField]
		private float _fogVoidHeight;

		// Token: 0x04001554 RID: 5460
		[SerializeField]
		private bool _fogVoidInverted;

		// Token: 0x04001555 RID: 5461
		[SerializeField]
		private GameObject _fogAreaCenter;

		// Token: 0x04001556 RID: 5462
		[SerializeField]
		private float _fogAreaFallOff = 1f;

		// Token: 0x04001557 RID: 5463
		[SerializeField]
		private float _fogAreaRadius;

		// Token: 0x04001558 RID: 5464
		[SerializeField]
		private Vector3 _fogAreaPosition = Vector3.zero;

		// Token: 0x04001559 RID: 5465
		[SerializeField]
		private float _fogAreaDepth;

		// Token: 0x0400155A RID: 5466
		[SerializeField]
		private float _fogAreaHeight;

		// Token: 0x0400155B RID: 5467
		public const int MAX_POINT_LIGHTS = 6;

		// Token: 0x0400155C RID: 5468
		[SerializeField]
		private GameObject[] _pointLights = new GameObject[6];

		// Token: 0x0400155D RID: 5469
		[SerializeField]
		private float[] _pointLightRanges = new float[6];

		// Token: 0x0400155E RID: 5470
		[SerializeField]
		private float[] _pointLightIntensities = new float[]
		{
			1f,
			1f,
			1f,
			1f,
			1f,
			1f
		};

		// Token: 0x0400155F RID: 5471
		[SerializeField]
		private float[] _pointLightIntensitiesMultiplier = new float[]
		{
			1f,
			1f,
			1f,
			1f,
			1f,
			1f
		};

		// Token: 0x04001560 RID: 5472
		[SerializeField]
		private Vector3[] _pointLightPositions = new Vector3[6];

		// Token: 0x04001561 RID: 5473
		[SerializeField]
		private Color[] _pointLightColors = new Color[]
		{
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f)
		};

		// Token: 0x04001562 RID: 5474
		[SerializeField]
		private bool _pointLightTrackingAuto;

		// Token: 0x04001563 RID: 5475
		[SerializeField]
		private int _pointLightTrackingCount;

		// Token: 0x04001564 RID: 5476
		[SerializeField]
		private int _downsampling = 1;

		// Token: 0x04001565 RID: 5477
		[SerializeField]
		private bool _edgeImprove;

		// Token: 0x04001566 RID: 5478
		[SerializeField]
		private float _edgeThreshold = 0.0005f;

		// Token: 0x04001567 RID: 5479
		[SerializeField]
		private float _stepping = 12f;

		// Token: 0x04001568 RID: 5480
		[SerializeField]
		private float _steppingNear = 1f;

		// Token: 0x04001569 RID: 5481
		[SerializeField]
		private bool _dithering;

		// Token: 0x0400156A RID: 5482
		[SerializeField]
		private float _ditherStrength = 0.75f;

		// Token: 0x0400156B RID: 5483
		[SerializeField]
		private bool _jitter;

		// Token: 0x0400156C RID: 5484
		[SerializeField]
		private float _jitterrStrength = 3f;

		// Token: 0x0400156D RID: 5485
		[SerializeField]
		private bool _lightScatteringEnabled;

		// Token: 0x0400156E RID: 5486
		[SerializeField]
		private float _lightScatteringSpread = 0.686f;

		// Token: 0x0400156F RID: 5487
		[SerializeField]
		private int _lightScatteringSamples = 16;

		// Token: 0x04001570 RID: 5488
		[SerializeField]
		private float _lightScatteringWeight = 2.3f;

		// Token: 0x04001571 RID: 5489
		[SerializeField]
		private float _lightScatteringIllumination = 18f;

		// Token: 0x04001572 RID: 5490
		[SerializeField]
		private float _lightScatteringDecay = 0.986f;

		// Token: 0x04001573 RID: 5491
		[SerializeField]
		private float _lightScatteringExposure = 0.02f;

		// Token: 0x04001574 RID: 5492
		[SerializeField]
		private float _lightScatteringJittering = 0.5f;

		// Token: 0x04001575 RID: 5493
		private Material ANFNPKEGGGH;

		// Token: 0x04001576 RID: 5494
		private float OBNAEMGBELP;

		// Token: 0x04001577 RID: 5495
		private float OIOFPBCMMDL;

		// Token: 0x04001578 RID: 5496
		private float MJJGCIOECLI;

		// Token: 0x04001579 RID: 5497
		private float NHNKDLKINKG;

		// Token: 0x0400157A RID: 5498
		private float NBLMJMBBOIP;

		// Token: 0x0400157B RID: 5499
		private float MDFOLPEMPNK;

		// Token: 0x0400157C RID: 5500
		private float CPDLIPDNIBP;

		// Token: 0x0400157D RID: 5501
		private float ILOCCABDDMI;

		// Token: 0x0400157E RID: 5502
		private RenderTexture EPLJMFAGBBL;

		// Token: 0x0400157F RID: 5503
		private RenderTexture DEAKJILOFJD;

		// Token: 0x04001580 RID: 5504
		private RenderTexture KJCLHCFDPEP;

		// Token: 0x04001581 RID: 5505
		private GameObject AABLBMICILO;

		// Token: 0x04001582 RID: 5506
		private Camera CDCBEKBHMMM;

		// Token: 0x04001583 RID: 5507
		private Light HLGMMNEANMP;

		// Token: 0x04001584 RID: 5508
		private Light[] EIAFEHFANLH = new Light[6];

		// Token: 0x04001585 RID: 5509
		private Texture2D NIBGOBNJCDH;

		// Token: 0x04001586 RID: 5510
		private int HOLBLGOEFBK;

		// Token: 0x04001587 RID: 5511
		private Color[] APBCGMJLEFB;

		// Token: 0x04001588 RID: 5512
		private Color[] DKOLLEMPAIC;

		// Token: 0x04001589 RID: 5513
		private float CNDIJMEHMDB = 1f;

		// Token: 0x0400158A RID: 5514
		private Vector2 FFELAGLIGFM;

		// Token: 0x0400158B RID: 5515
		private float BGOIMEOBLLF = 1f;

		// Token: 0x0400158C RID: 5516
		private float FHIEKJBFGKI;

		// Token: 0x0400158D RID: 5517
		private List<string> ABEHHDIGHFJ;

		// Token: 0x0400158E RID: 5518
		private float KLDEEGLHHID;

		// Token: 0x0400158F RID: 5519
		[SerializeField]
		private bool _fogOfWarEnabled;

		// Token: 0x04001590 RID: 5520
		[SerializeField]
		private Vector3 _fogOfWarCenter;

		// Token: 0x04001591 RID: 5521
		[SerializeField]
		private Vector3 _fogOfWarSize = new Vector3(1024f, 0f, 1024f);

		// Token: 0x04001592 RID: 5522
		[SerializeField]
		private int _fogOfWarTextureSize = 256;

		// Token: 0x04001593 RID: 5523
		[SerializeField]
		private float _fogOfWarRestoreDelay;

		// Token: 0x04001594 RID: 5524
		[SerializeField]
		private float _fogOfWarRestoreDuration = 2f;

		// Token: 0x04001595 RID: 5525
		private Texture2D GMDLHIFDCAK;

		// Token: 0x04001596 RID: 5526
		private Color32[] GNGCEOOOGJG;

		// Token: 0x04001597 RID: 5527
		private List<VolumetricFog.JLDHOIEEOID> LECEDJIHNOF;

		// Token: 0x04001598 RID: 5528
		public static string SKW_FOG_DISTANCE_ON = "FOG_DISTANCE_ON";

		// Token: 0x04001599 RID: 5529
		public static string SKW_LIGHT_SCATTERING = "FOG_SCATTERING_ON";

		// Token: 0x0400159A RID: 5530
		public static string SKW_FOG_AREA_BOX = "FOG_AREA_BOX";

		// Token: 0x0400159B RID: 5531
		public static string SKW_FOG_AREA_SPHERE = "FOG_AREA_SPHERE";

		// Token: 0x0400159C RID: 5532
		public static string SKW_FOG_VOID_BOX = "FOG_VOID_BOX";

		// Token: 0x0400159D RID: 5533
		public static string SKW_FOG_VOID_SPHERE = "FOG_VOID_SPHERE";

		// Token: 0x0400159E RID: 5534
		public static string SKW_FOG_HAZE_ON = "FOG_HAZE_ON";

		// Token: 0x0400159F RID: 5535
		public static string SKW_FOG_OF_WAR_ON = "FOG_OF_WAR_ON";

		// Token: 0x020002C3 RID: 707
		private class JLDHOIEEOID
		{
			// Token: 0x040015A0 RID: 5536
			public bool PMPMAALNEBO;

			// Token: 0x040015A1 RID: 5537
			public int OCNGPCPMCPM;

			// Token: 0x040015A2 RID: 5538
			public int ADMFAEOOOHD;

			// Token: 0x040015A3 RID: 5539
			public float JOJHMMFOPPJ;

			// Token: 0x040015A4 RID: 5540
			public byte LFLNBKCDOFJ;
		}
	}
}
