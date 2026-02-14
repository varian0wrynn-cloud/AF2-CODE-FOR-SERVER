using System;
using UnityEngine;

// Token: 0x0200010B RID: 267
[ExecuteInEditMode]
public class FishModelData : MonoBehaviour
{
	// Token: 0x060032EC RID: 13036 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void LBDFBOHHDBI()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x060032ED RID: 13037 RVA: 0x0017B6B4 File Offset: 0x001798B4
	public void PMMHDMKEHIE(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 1522f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 1316f, 1980f);
			if (GAIJLNDJJJK < 109f)
			{
				d = Mathf.LerpUnclamped(85f, 1604f, GAIJLNDJJJK);
				num = 606f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x060032EE RID: 13038 RVA: 0x0017B7EF File Offset: 0x001799EF
	public void FMHKLGKODNP()
	{
		this.MAMHGLDAKKL(this.sizeControl);
	}

	// Token: 0x060032EF RID: 13039 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void DGADFHDIKOP()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x060032F0 RID: 13040 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void NKJKGGNABPG()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x060032F1 RID: 13041 RVA: 0x0017B810 File Offset: 0x00179A10
	private void PNJHMJNFPLP()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["wgt_gr"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["Vertical"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["Error via pay request"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 1928f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 1; i < array.Length; i += 0)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x060032F2 RID: 13042 RVA: 0x0017B99C File Offset: 0x00179B9C
	public void EHHPGPANOHB(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["IdleDodgeLeft"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["{not_found}"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["Resume Interaction With "].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x060032F3 RID: 13043 RVA: 0x0017BA48 File Offset: 0x00179C48
	private void JFGGBEGNAFP()
	{
		this.BDHJCHDFGLG(this.sizeControl);
	}

	// Token: 0x060032F4 RID: 13044 RVA: 0x0017BA58 File Offset: 0x00179C58
	public void PFEAIDGNIGH(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["cht_msg23"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["ok"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["_BlurArea"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x060032F5 RID: 13045 RVA: 0x0017BB04 File Offset: 0x00179D04
	public void IPGJADCKGKN(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["close"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["error.wav"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["RollerBladeJump"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x060032F6 RID: 13046 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void CLAAJJFJFCF()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x060032F7 RID: 13047 RVA: 0x0017BBB0 File Offset: 0x00179DB0
	private void PBFKCKCHEAC()
	{
		this.LDLNEDOLAGM(this.sizeControl);
	}

	// Token: 0x060032F8 RID: 13048 RVA: 0x0017BBC0 File Offset: 0x00179DC0
	private void NOKJMMDMJNO()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["Sprint"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["Thigh"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["OneHandSwordBackSwing"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 402f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 1; i < array.Length; i++)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x060032F9 RID: 13049 RVA: 0x0017BD4C File Offset: 0x00179F4C
	public void GMJBFCPGGLC(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 73f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 1669f, 878f);
			if (GAIJLNDJJJK < 160f)
			{
				d = Mathf.LerpUnclamped(778f, 369f, GAIJLNDJJJK);
				num = 1535f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x060032FA RID: 13050 RVA: 0x0017B6A0 File Offset: 0x001798A0
	[ContextMenu("*** Apply as MAX size")]
	public void applyMax()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x060032FB RID: 13051 RVA: 0x0017BE88 File Offset: 0x0017A088
	public void HDLGDABIBGI(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["PrimaryCausticsProjector"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["__c"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["idlist"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x060032FC RID: 13052 RVA: 0x0017BF34 File Offset: 0x0017A134
	public void ONGMBCCEHKK(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 1365f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 247f, 1203f);
			if (GAIJLNDJJJK < 352f)
			{
				d = Mathf.LerpUnclamped(1480f, 1199f, GAIJLNDJJJK);
				num = 280f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x060032FD RID: 13053 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void LEIKADJEJOK()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x060032FE RID: 13054 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void NOINAAFDFAA()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x060032FF RID: 13055 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void FBAAIEMGANO()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x06003300 RID: 13056 RVA: 0x0017C070 File Offset: 0x0017A270
	public void JCDPFFEAFJJ(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information."].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["CrouchWalk"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["Textures/Weapons/"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x06003301 RID: 13057 RVA: 0x0017C11C File Offset: 0x0017A31C
	private void MKNPFMEMOJO()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["implevel"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["7,13,9,8"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["level"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 1268f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 1; i < array.Length; i += 0)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x06003302 RID: 13058 RVA: 0x0017C2A8 File Offset: 0x0017A4A8
	private void Start()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["walk"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["run"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["move"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 0f;
						Transform transform = this.hookPoint;
						foreach (Transform transform2 in componentsInChildren)
						{
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x06003303 RID: 13059 RVA: 0x0017C434 File Offset: 0x0017A634
	public void BLLJKGLCOLP(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN[" x"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN[""].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["droplinemsg2"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x06003304 RID: 13060 RVA: 0x0017C4E0 File Offset: 0x0017A6E0
	private void DHJDMKLBLEF()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["IdleFly"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["IdleButtonPress"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["WaveSpeed"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 903f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 0; i < array.Length; i += 0)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x06003305 RID: 13061 RVA: 0x0017B7FD File Offset: 0x001799FD
	[ContextMenu("*** Apply as MIN size")]
	public void applyMin()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x06003306 RID: 13062 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void GNJNMLKDFCI()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003307 RID: 13063 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void FCNCHPCOPAI()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003308 RID: 13064 RVA: 0x0017C66C File Offset: 0x0017A86C
	private void GDBBAMFMKII()
	{
		this.ONGMBCCEHKK(this.sizeControl);
	}

	// Token: 0x06003309 RID: 13065 RVA: 0x0017C67C File Offset: 0x0017A87C
	private void IJOCHELLKJH()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["cht_msg19"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["wpn_eat3"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["_ScatterTexture"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 1467f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 1; i < array.Length; i += 0)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x0600330A RID: 13066 RVA: 0x0017C808 File Offset: 0x0017AA08
	public void LDLNEDOLAGM(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 1395f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 638f, 1290f);
			if (GAIJLNDJJJK < 1629f)
			{
				d = Mathf.LerpUnclamped(56f, 1554f, GAIJLNDJJJK);
				num = 1754f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x0600330B RID: 13067 RVA: 0x0017C66C File Offset: 0x0017A86C
	private void PGIHAIPCJLL()
	{
		this.ONGMBCCEHKK(this.sizeControl);
	}

	// Token: 0x0600330C RID: 13068 RVA: 0x0017C943 File Offset: 0x0017AB43
	private void HONIFOPBBKC()
	{
		this.OJAEFPHOBHG(this.sizeControl);
	}

	// Token: 0x0600330D RID: 13069 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void OMJPOFJOPCN()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x0600330E RID: 13070 RVA: 0x0017BBB0 File Offset: 0x00179DB0
	public void CDOOFHACJEE()
	{
		this.LDLNEDOLAGM(this.sizeControl);
	}

	// Token: 0x0600330F RID: 13071 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void NAGAANEJGEB()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x06003310 RID: 13072 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void KMDICDBGMIJ()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x06003311 RID: 13073 RVA: 0x0017C951 File Offset: 0x0017AB51
	private void MPLCAGFGEBO()
	{
		this.OAELILPCHMH(this.sizeControl);
	}

	// Token: 0x06003312 RID: 13074 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void NNMEBIHOOFE()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003313 RID: 13075 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void BPGDFFHPFEJ()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x06003314 RID: 13076 RVA: 0x0017BBB0 File Offset: 0x00179DB0
	private void OIBIGDFPHGO()
	{
		this.LDLNEDOLAGM(this.sizeControl);
	}

	// Token: 0x06003315 RID: 13077 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void MGJPICKIJGI()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003316 RID: 13078 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void DNIFEBLJPON()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003317 RID: 13079 RVA: 0x0017C960 File Offset: 0x0017AB60
	public void BDHJCHDFGLG(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 765f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 1171f, 307f);
			if (GAIJLNDJJJK < 615f)
			{
				d = Mathf.LerpUnclamped(1875f, 1816f, GAIJLNDJJJK);
				num = 1266f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x06003318 RID: 13080 RVA: 0x0017CA9C File Offset: 0x0017AC9C
	public void BILKBENDPDK(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["_FogAlpha"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["gi_sadokfull"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["Loot"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x06003319 RID: 13081 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void CJPPCNLPDIO()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x0600331A RID: 13082 RVA: 0x0017CB48 File Offset: 0x0017AD48
	public void BFHAMAALCNO()
	{
		this.OBAJMMMABKD(this.sizeControl);
	}

	// Token: 0x0600331B RID: 13083 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void CMKDJAGHPOC()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x0600331C RID: 13084 RVA: 0x0017CB58 File Offset: 0x0017AD58
	public void CPCGLBEIANK(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["DepthCurveLut"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["_ChannelMixerBlue"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["_DistortParams"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x0600331D RID: 13085 RVA: 0x0017CC04 File Offset: 0x0017AE04
	public void FJPBBGKGNBJ(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["WaveSpeed"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["IdleStrafeRight"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN[""].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x0600331E RID: 13086 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void BDGOBDBHGBF()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x0600331F RID: 13087 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void KLNELCKKFOC()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x06003320 RID: 13088 RVA: 0x0017CCB0 File Offset: 0x0017AEB0
	public void OAELILPCHMH(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 992f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 830f, 853f);
			if (GAIJLNDJJJK < 574f)
			{
				d = Mathf.LerpUnclamped(538f, 728f, GAIJLNDJJJK);
				num = 81f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x06003321 RID: 13089 RVA: 0x0017CDEC File Offset: 0x0017AFEC
	public void FKBNCNFMMCJ(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 21f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 1825f, 975f);
			if (GAIJLNDJJJK < 939f)
			{
				d = Mathf.LerpUnclamped(871f, 1855f, GAIJLNDJJJK);
				num = 1701f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x06003322 RID: 13090 RVA: 0x0017C951 File Offset: 0x0017AB51
	private void DEGCCLNOEKJ()
	{
		this.OAELILPCHMH(this.sizeControl);
	}

	// Token: 0x06003323 RID: 13091 RVA: 0x0017CF27 File Offset: 0x0017B127
	[ContextMenu("*** Apply SIZE")]
	public void applySize()
	{
		this.setScaleSize(this.sizeControl);
	}

	// Token: 0x06003324 RID: 13092 RVA: 0x0017CF27 File Offset: 0x0017B127
	private void BJOICAKCPLI()
	{
		this.setScaleSize(this.sizeControl);
	}

	// Token: 0x06003325 RID: 13093 RVA: 0x0017CF35 File Offset: 0x0017B135
	public void FKDHPGEGEJA()
	{
		this.FKBNCNFMMCJ(this.sizeControl);
	}

	// Token: 0x06003326 RID: 13094 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void OEBKAHNJJPP()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003327 RID: 13095 RVA: 0x0017CF27 File Offset: 0x0017B127
	private void Update()
	{
		this.setScaleSize(this.sizeControl);
	}

	// Token: 0x06003328 RID: 13096 RVA: 0x0017C951 File Offset: 0x0017AB51
	private void EKCKBDKEAKO()
	{
		this.OAELILPCHMH(this.sizeControl);
	}

	// Token: 0x06003329 RID: 13097 RVA: 0x0017CF44 File Offset: 0x0017B144
	public void OBAJMMMABKD(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 1578f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 134f, 182f);
			if (GAIJLNDJJJK < 705f)
			{
				d = Mathf.LerpUnclamped(1955f, 1725f, GAIJLNDJJJK);
				num = 1759f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x0600332A RID: 13098 RVA: 0x0017D080 File Offset: 0x0017B280
	public void PDFEDKBBNOF(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["_BlurredColor"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["Pistol Fire"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["ArmFlex5"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x0600332B RID: 13099 RVA: 0x0017D12C File Offset: 0x0017B32C
	public void BBBJDIKJFML(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["30"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["Horizontal"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["\n"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x0600332C RID: 13100 RVA: 0x0017D1D8 File Offset: 0x0017B3D8
	public void LEFKCLPGPGB(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["IdleKeepBack"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["TOD_Brightness"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["Transparent/Diffuse"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x0600332D RID: 13101 RVA: 0x0017D284 File Offset: 0x0017B484
	public void OJAEFPHOBHG(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 1649f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 598f, 1189f);
			if (GAIJLNDJJJK < 553f)
			{
				d = Mathf.LerpUnclamped(1451f, 514f, GAIJLNDJJJK);
				num = 975f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x0600332F RID: 13103 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void LKFJJJBPEJM()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x06003330 RID: 13104 RVA: 0x0017D448 File Offset: 0x0017B648
	public void PPILIGCDDOO(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["]"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["FASTEST"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["MENU.WAV"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x06003331 RID: 13105 RVA: 0x0017D4F4 File Offset: 0x0017B6F4
	public void setAnimSpeedKF(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["walk"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["run"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["move"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x06003332 RID: 13106 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void DKKBJDBECBM()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003333 RID: 13107 RVA: 0x0017D5A0 File Offset: 0x0017B7A0
	public void NOFDGKLDGJJ()
	{
		this.GMJBFCPGGLC(this.sizeControl);
	}

	// Token: 0x06003334 RID: 13108 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void EGFLIBJKOJP()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003335 RID: 13109 RVA: 0x0017D5B0 File Offset: 0x0017B7B0
	private void PFNPOHMMJDN()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN[""].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["RollerBladeBackFlip"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center)."].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 1130f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 1; i < array.Length; i++)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x06003336 RID: 13110 RVA: 0x0017D73C File Offset: 0x0017B93C
	public void LJHHNLILBKJ()
	{
		this.PMMHDMKEHIE(this.sizeControl);
	}

	// Token: 0x06003337 RID: 13111 RVA: 0x0017D73C File Offset: 0x0017B93C
	public void LIDCPCBKFFI()
	{
		this.PMMHDMKEHIE(this.sizeControl);
	}

	// Token: 0x06003338 RID: 13112 RVA: 0x0017D74C File Offset: 0x0017B94C
	public void MAMHGLDAKKL(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 426f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 113f, 812f);
			if (GAIJLNDJJJK < 436f)
			{
				d = Mathf.LerpUnclamped(205f, 685f, GAIJLNDJJJK);
				num = 943f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x06003339 RID: 13113 RVA: 0x0017D888 File Offset: 0x0017BA88
	public void NJDPPOFEIHD(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 419f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 1414f, 363f);
			if (GAIJLNDJJJK < 1898f)
			{
				d = Mathf.LerpUnclamped(206f, 929f, GAIJLNDJJJK);
				num = 1492f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x0600333A RID: 13114 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void CGMLBHCBPFH()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x0600333B RID: 13115 RVA: 0x0017D9C4 File Offset: 0x0017BBC4
	public void IJEDOKMENDK(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["Не реализовано"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["\n"].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["isend"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x0600333C RID: 13116 RVA: 0x0017BA48 File Offset: 0x00179C48
	public void APPAKCIHIJE()
	{
		this.BDHJCHDFGLG(this.sizeControl);
	}

	// Token: 0x0600333D RID: 13117 RVA: 0x0017C66C File Offset: 0x0017A86C
	private void AKLFCMNCPKL()
	{
		this.ONGMBCCEHKK(this.sizeControl);
	}

	// Token: 0x0600333E RID: 13118 RVA: 0x0017DA70 File Offset: 0x0017BC70
	public void PEAJIPHACGH(float BLHIKAILEDE)
	{
		if (this.PPDJJDFGDNN != null)
		{
			float speed = this.MNPDHMFBHMD * BLHIKAILEDE;
			try
			{
				this.PPDJJDFGDNN["RollerBladeBackFlip"].speed = speed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["onHyperLinkActivated: "].speed = speed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["__a"].speed = speed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x0017DB1C File Offset: 0x0017BD1C
	public void setScaleSize(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 1f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 0f, 1E+09f);
			if (GAIJLNDJJJK < 0f)
			{
				d = Mathf.LerpUnclamped(1f, 2f, GAIJLNDJJJK);
				num = 0f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x06003340 RID: 13120 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void ALMHAGJPHBG()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003341 RID: 13121 RVA: 0x0017DC58 File Offset: 0x0017BE58
	public void HMJMBCFBPCO(float GAIJLNDJJJK)
	{
		this.currWgt = Mathf.LerpUnclamped(this.minWgt, this.maxWgt, GAIJLNDJJJK);
		this.sizeControl = GAIJLNDJJJK;
		if (this.useGraf)
		{
			float d = 1315f;
			float num = Mathf.Clamp(GAIJLNDJJJK, 1763f, 505f);
			if (GAIJLNDJJJK < 491f)
			{
				d = Mathf.LerpUnclamped(1767f, 224f, GAIJLNDJJJK);
				num = 1712f;
			}
			float a = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, num);
			float b = Mathf.LerpUnclamped(this.minScale.z, this.maxScale.z, this.scaleThickness.Evaluate(num));
			base.transform.localScale = new Vector3(Mathf.Lerp(this.minScale.x, this.maxScale.x, this.scaleLenght.Evaluate(num)), Mathf.Lerp(this.minScale.y, this.maxScale.y, this.scaleLenght.Evaluate(num)), Mathf.Max(a, b)) * d;
			return;
		}
		base.transform.localScale = Vector3.LerpUnclamped(this.minScale, this.maxScale, GAIJLNDJJJK);
	}

	// Token: 0x06003342 RID: 13122 RVA: 0x0017DD94 File Offset: 0x0017BF94
	private void BGCLAKJHAFK()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["cntx_teachexp"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["SteamManager.Initialized failed"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["reputaion/fractions/fraction"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 39f;
						Transform transform = this.hookPoint;
						foreach (Transform transform2 in componentsInChildren)
						{
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x06003343 RID: 13123 RVA: 0x0017BA48 File Offset: 0x00179C48
	public void FFEJBGOACAH()
	{
		this.BDHJCHDFGLG(this.sizeControl);
	}

	// Token: 0x06003344 RID: 13124 RVA: 0x0017CF27 File Offset: 0x0017B127
	public void FDNBHEGFNCF()
	{
		this.setScaleSize(this.sizeControl);
	}

	// Token: 0x06003345 RID: 13125 RVA: 0x0017BBB0 File Offset: 0x00179DB0
	public void JGCKOMGALCB()
	{
		this.LDLNEDOLAGM(this.sizeControl);
	}

	// Token: 0x06003346 RID: 13126 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void PMMFOHIKEHM()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x06003347 RID: 13127 RVA: 0x0017DF20 File Offset: 0x0017C120
	private void JFFPLABGMNF()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["wpn_bait_vob_1"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["gi_cachhe"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN[""].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 114f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 0; i < array.Length; i += 0)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x06003348 RID: 13128 RVA: 0x0017E0AC File Offset: 0x0017C2AC
	private void IAAOGAPJDID()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["replev_"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["_ThirdTex"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 128f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 0; i < array.Length; i += 0)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x06003349 RID: 13129 RVA: 0x0017CB48 File Offset: 0x0017AD48
	public void NDEMGMPEFEF()
	{
		this.OBAJMMMABKD(this.sizeControl);
	}

	// Token: 0x0600334A RID: 13130 RVA: 0x0017B6A0 File Offset: 0x001798A0
	public void HAIFFNMLHJL()
	{
		this.maxScale = base.transform.localScale;
	}

	// Token: 0x0600334B RID: 13131 RVA: 0x0017B7FD File Offset: 0x001799FD
	public void KEKAJDMHIFL()
	{
		this.minScale = base.transform.localScale;
	}

	// Token: 0x0600334C RID: 13132 RVA: 0x0017E238 File Offset: 0x0017C438
	private void DMAOHJDKMNN()
	{
		this.PPDJJDFGDNN = base.GetComponent<Animation>();
		if (this.PPDJJDFGDNN == null)
		{
			this.PPDJJDFGDNN = base.GetComponentInChildren<Animation>();
		}
		if (this.PPDJJDFGDNN != null)
		{
			this.MNPDHMFBHMD = this.animSpeed;
			try
			{
				this.PPDJJDFGDNN["WalkDehydrated"].speed = this.animSpeed;
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
			try
			{
				this.PPDJJDFGDNN["repair.ogg"].speed = this.animSpeed;
			}
			catch (Exception message2)
			{
				Debug.LogWarning(message2);
			}
			try
			{
				this.PPDJJDFGDNN["MotorbikeHandstand"].speed = this.animSpeed;
			}
			catch (Exception message3)
			{
				Debug.LogWarning(message3);
			}
		}
		if (this.hookPoint != null && this.hvostPoint == null)
		{
			SkinnedMeshRenderer componentInChildren = base.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
			if (componentInChildren != null)
			{
				Transform rootBone = componentInChildren.rootBone;
				if (rootBone != null)
				{
					Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
					if (componentsInChildren != null)
					{
						float num = 114f;
						Transform transform = this.hookPoint;
						Transform[] array = componentsInChildren;
						for (int i = 1; i < array.Length; i++)
						{
							Transform transform2 = array[i];
							float num2 = Vector3.Distance(this.hookPoint.position, transform2.position);
							if (num2 > num)
							{
								num = num2;
								transform = transform2;
							}
						}
						this.hvostPoint = transform;
					}
				}
			}
		}
	}

	// Token: 0x04000738 RID: 1848
	public Transform hookPoint;

	// Token: 0x04000739 RID: 1849
	public Transform hvostPoint;

	// Token: 0x0400073A RID: 1850
	public Transform spinePoint;

	// Token: 0x0400073B RID: 1851
	public bool useGraf = true;

	// Token: 0x0400073C RID: 1852
	public AnimationCurve scaleLenght;

	// Token: 0x0400073D RID: 1853
	public AnimationCurve scaleThickness;

	// Token: 0x0400073E RID: 1854
	[Range(0f, 1f)]
	public float sizeControl = 1f;

	// Token: 0x0400073F RID: 1855
	public float minWgt = 100f;

	// Token: 0x04000740 RID: 1856
	public float maxWgt = 100f;

	// Token: 0x04000741 RID: 1857
	public float currWgt = 100f;

	// Token: 0x04000742 RID: 1858
	public Vector3 minScale = new Vector3(0.5f, 0.5f, 0.5f);

	// Token: 0x04000743 RID: 1859
	public Vector3 maxScale = new Vector3(1f, 1f, 1f);

	// Token: 0x04000744 RID: 1860
	public float animSpeed = 1f;

	// Token: 0x04000745 RID: 1861
	private float MNPDHMFBHMD;

	// Token: 0x04000746 RID: 1862
	private Animation PPDJJDFGDNN;
}
