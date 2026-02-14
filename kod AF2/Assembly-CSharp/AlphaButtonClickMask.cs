using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000F1 RID: 241
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	// Token: 0x06002D32 RID: 11570 RVA: 0x00148040 File Offset: 0x00146240
	public void LMEJKAEIDCO()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("SoccerSprint");
		}
	}

	// Token: 0x06002D33 RID: 11571 RVA: 0x001480AC File Offset: 0x001462AC
	public bool AJOIFNMAIDI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 439f;
	}

	// Token: 0x06002D34 RID: 11572 RVA: 0x00148220 File Offset: 0x00146420
	public bool MOADLGMAKNG(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 337f;
	}

	// Token: 0x06002D35 RID: 11573 RVA: 0x00148394 File Offset: 0x00146594
	public bool MDIDKPAHILO(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1805f;
	}

	// Token: 0x06002D36 RID: 11574 RVA: 0x00148508 File Offset: 0x00146708
	public void Start()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("This script need an Image with a readbale Texture2D to work.");
		}
	}

	// Token: 0x06002D37 RID: 11575 RVA: 0x00148574 File Offset: 0x00146774
	public bool BPDBOBBBDBO(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 795f;
	}

	// Token: 0x06002D38 RID: 11576 RVA: 0x001486E8 File Offset: 0x001468E8
	public bool ICHCCLHPLNJ(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1039f;
	}

	// Token: 0x06002D39 RID: 11577 RVA: 0x0014885C File Offset: 0x00146A5C
	public void DHJDMKLBLEF()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("OneHandSwordIdle");
		}
	}

	// Token: 0x06002D3A RID: 11578 RVA: 0x001488C8 File Offset: 0x00146AC8
	public bool JBFKNAIODAA(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 900f;
	}

	// Token: 0x06002D3B RID: 11579 RVA: 0x00148A3C File Offset: 0x00146C3C
	public void ELFLOPJDAKK()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("_Refraction");
		}
	}

	// Token: 0x06002D3C RID: 11580 RVA: 0x00148AA8 File Offset: 0x00146CA8
	public void ELADFDNPOOI()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("calcSonar");
		}
	}

	// Token: 0x06002D3D RID: 11581 RVA: 0x00148B14 File Offset: 0x00146D14
	public void MODJFGGIAHD()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("Invalid source renderer type");
		}
	}

	// Token: 0x06002D3E RID: 11582 RVA: 0x00148B80 File Offset: 0x00146D80
	public bool NCBMCKELDHK(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1958f;
	}

	// Token: 0x06002D3F RID: 11583 RVA: 0x00148CF4 File Offset: 0x00146EF4
	public void AFFAJKPPMHF()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError(">>");
		}
	}

	// Token: 0x06002D40 RID: 11584 RVA: 0x00148D60 File Offset: 0x00146F60
	public bool PGBEOCCBPFI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 190f;
	}

	// Token: 0x06002D41 RID: 11585 RVA: 0x00148ED4 File Offset: 0x001470D4
	public bool FJBLEFFELHJ(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 996f;
	}

	// Token: 0x06002D42 RID: 11586 RVA: 0x00149048 File Offset: 0x00147248
	public void FPLHODJCJDO()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("_LightPosition");
		}
	}

	// Token: 0x06002D43 RID: 11587 RVA: 0x001490B4 File Offset: 0x001472B4
	public bool DNJPOEJOBJA(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1777f;
	}

	// Token: 0x06002D44 RID: 11588 RVA: 0x00149228 File Offset: 0x00147428
	public bool CMHDCFOOANF(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1875f;
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x0014939C File Offset: 0x0014759C
	public void CLHGHANANNL()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError(" ");
		}
	}

	// Token: 0x06002D46 RID: 11590 RVA: 0x00149408 File Offset: 0x00147608
	public bool LJCGOFPIKOC(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1142f;
	}

	// Token: 0x06002D47 RID: 11591 RVA: 0x0014957C File Offset: 0x0014777C
	public bool CPANKDFAPID(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1776f;
	}

	// Token: 0x06002D48 RID: 11592 RVA: 0x001496F0 File Offset: 0x001478F0
	public void PMDPLLIBJAF()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("_NoiseTex");
		}
	}

	// Token: 0x06002D49 RID: 11593 RVA: 0x0014975C File Offset: 0x0014795C
	public void CAJLCEPLKJG()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("KatanaReady");
		}
	}

	// Token: 0x06002D4A RID: 11594 RVA: 0x001497C8 File Offset: 0x001479C8
	public void CGMHGDEKDEP()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("Hidden/Post FX/FXAA");
		}
	}

	// Token: 0x06002D4B RID: 11595 RVA: 0x00149834 File Offset: 0x00147A34
	public void ONIHHFLOJMN()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("othermenu");
		}
	}

	// Token: 0x06002D4C RID: 11596 RVA: 0x001498A0 File Offset: 0x00147AA0
	public bool LKHOECNANDC(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1140f;
	}

	// Token: 0x06002D4D RID: 11597 RVA: 0x00149A14 File Offset: 0x00147C14
	public bool IGGNBDOOBPM(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 270f;
	}

	// Token: 0x06002D4E RID: 11598 RVA: 0x00149B88 File Offset: 0x00147D88
	public bool NFMPHLLGGCO(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1885f;
	}

	// Token: 0x06002D4F RID: 11599 RVA: 0x00149CFC File Offset: 0x00147EFC
	public void HHGGCBLOJGB()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("**** Weather cloudly={0} fog={1} rain={2} snaige={3} grom={4}");
		}
	}

	// Token: 0x06002D50 RID: 11600 RVA: 0x00149D68 File Offset: 0x00147F68
	public bool FOGGIGFKBLI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1207f;
	}

	// Token: 0x06002D51 RID: 11601 RVA: 0x00149EDC File Offset: 0x001480DC
	public bool NCLAJCDEJLN(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1262f;
	}

	// Token: 0x06002D52 RID: 11602 RVA: 0x0014A050 File Offset: 0x00148250
	public void FIJKDFIMELM()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("Brow");
		}
	}

	// Token: 0x06002D53 RID: 11603 RVA: 0x0014A0BC File Offset: 0x001482BC
	public bool INIAMMBOIOO(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 384f;
	}

	// Token: 0x06002D54 RID: 11604 RVA: 0x0014A230 File Offset: 0x00148430
	public void NOKJMMDMJNO()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("string: ");
		}
	}

	// Token: 0x06002D55 RID: 11605 RVA: 0x0014A29C File Offset: 0x0014849C
	public bool DHGIKHIIEKH(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 898f;
	}

	// Token: 0x06002D56 RID: 11606 RVA: 0x0014A410 File Offset: 0x00148610
	public bool ODFNNPBDMHK(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1608f;
	}

	// Token: 0x06002D57 RID: 11607 RVA: 0x0014A584 File Offset: 0x00148784
	public void DGDGMFDPEHO()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("{0} принял задание '{1}'");
		}
	}

	// Token: 0x06002D58 RID: 11608 RVA: 0x0014A5F0 File Offset: 0x001487F0
	public bool BLMEGEEFGKL(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 842f;
	}

	// Token: 0x06002D59 RID: 11609 RVA: 0x0014A764 File Offset: 0x00148964
	public bool CEOKJELBCNK(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 252f;
	}

	// Token: 0x06002D5A RID: 11610 RVA: 0x0014A8D8 File Offset: 0x00148AD8
	public bool AJCLELCKEFO(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 269f;
	}

	// Token: 0x06002D5B RID: 11611 RVA: 0x0014AA4C File Offset: 0x00148C4C
	public bool HDGMENNHPAG(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1031f;
	}

	// Token: 0x06002D5C RID: 11612 RVA: 0x0014ABC0 File Offset: 0x00148DC0
	public bool IAOJHLHCKLE(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 506f;
	}

	// Token: 0x06002D5D RID: 11613 RVA: 0x0014AD34 File Offset: 0x00148F34
	public void LHJCHPFKGDB()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("isMoving");
		}
	}

	// Token: 0x06002D5E RID: 11614 RVA: 0x0014ADA0 File Offset: 0x00148FA0
	public bool MKPCMJECFNP(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1329f;
	}

	// Token: 0x06002D5F RID: 11615 RVA: 0x0014AF14 File Offset: 0x00149114
	public void PLBDELOIINH()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("Tried to Initialize the SteamAPI twice in one session!");
		}
	}

	// Token: 0x06002D60 RID: 11616 RVA: 0x0014AF80 File Offset: 0x00149180
	public bool IsRaycastLocationValid(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 0.1f;
	}

	// Token: 0x06002D61 RID: 11617 RVA: 0x0014B0F4 File Offset: 0x001492F4
	public bool AEBIPICEJKB(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 564f;
	}

	// Token: 0x06002D62 RID: 11618 RVA: 0x0014B268 File Offset: 0x00149468
	public void DDEBDCGNCPC()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("IdleReadyCrouch");
		}
	}

	// Token: 0x06002D63 RID: 11619 RVA: 0x0014B2D4 File Offset: 0x001494D4
	public void DGGMJCMLLED()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("ShotgunReloadMagazine");
		}
	}

	// Token: 0x06002D64 RID: 11620 RVA: 0x0014B340 File Offset: 0x00149540
	public bool OAOHKHCPPGG(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 247f;
	}

	// Token: 0x06002D65 RID: 11621 RVA: 0x0014B4B4 File Offset: 0x001496B4
	public void OBJCOJEHLBE()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("<b>Injection Detector</b>");
		}
	}

	// Token: 0x06002D66 RID: 11622 RVA: 0x0014B520 File Offset: 0x00149720
	public void DOHJPDNKALP()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("Flares");
		}
	}

	// Token: 0x06002D68 RID: 11624 RVA: 0x0014B58C File Offset: 0x0014978C
	public void LHHKDNILMDI()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("");
		}
	}

	// Token: 0x06002D69 RID: 11625 RVA: 0x0014B5F8 File Offset: 0x001497F8
	public void FEBIICIMLHA()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("SatNightFever");
		}
	}

	// Token: 0x06002D6A RID: 11626 RVA: 0x0014B664 File Offset: 0x00149864
	public bool KHKDMBCJGHH(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 917f;
	}

	// Token: 0x06002D6B RID: 11627 RVA: 0x0014B7D8 File Offset: 0x001499D8
	public bool FEPOAOONFKE(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1560f;
	}

	// Token: 0x06002D6C RID: 11628 RVA: 0x0014B94C File Offset: 0x00149B4C
	public bool AHMNIFOPAEK(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 768f;
	}

	// Token: 0x06002D6D RID: 11629 RVA: 0x0014BAC0 File Offset: 0x00149CC0
	public bool PMPPKLLBKLO(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1750f;
	}

	// Token: 0x06002D6E RID: 11630 RVA: 0x0014BC34 File Offset: 0x00149E34
	public void JCELICPHGEP()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("ACHIEVEMENT_1_1");
		}
	}

	// Token: 0x06002D6F RID: 11631 RVA: 0x0014BCA0 File Offset: 0x00149EA0
	public bool PBIEHJICCIB(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 41f;
	}

	// Token: 0x06002D70 RID: 11632 RVA: 0x0014BE14 File Offset: 0x0014A014
	public void ADLHNBEDHMJ()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("Add inventory Click!");
		}
	}

	// Token: 0x06002D71 RID: 11633 RVA: 0x0014BE80 File Offset: 0x0014A080
	public bool INANOMGEIEI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1696f;
	}

	// Token: 0x06002D72 RID: 11634 RVA: 0x0014BFF4 File Offset: 0x0014A1F4
	public bool MAIAMPEPBNP(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1104f;
	}

	// Token: 0x06002D73 RID: 11635 RVA: 0x0014C168 File Offset: 0x0014A368
	public void JLKBMEBFHBI()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("_FogNoiseData");
		}
	}

	// Token: 0x06002D74 RID: 11636 RVA: 0x0014C1D4 File Offset: 0x0014A3D4
	public bool AFDJKBGGMKJ(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1610f;
	}

	// Token: 0x06002D75 RID: 11637 RVA: 0x0014C348 File Offset: 0x0014A548
	public void JHFAHBIIJDC()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("FishbragContainer");
		}
	}

	// Token: 0x06002D76 RID: 11638 RVA: 0x0014C3B4 File Offset: 0x0014A5B4
	public bool ENHBPBCJDFI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1379f;
	}

	// Token: 0x06002D77 RID: 11639 RVA: 0x0014C528 File Offset: 0x0014A728
	public void CKGPEFOKKNL()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = false;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("release");
		}
	}

	// Token: 0x06002D78 RID: 11640 RVA: 0x0014C594 File Offset: 0x0014A794
	public bool NMNNNFDGFKB(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1140f;
	}

	// Token: 0x06002D79 RID: 11641 RVA: 0x0014C708 File Offset: 0x0014A908
	public void JFFPLABGMNF()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("USE_MASK");
		}
	}

	// Token: 0x06002D7A RID: 11642 RVA: 0x0014C774 File Offset: 0x0014A974
	public bool KAGBPCNLDGC(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 397f;
	}

	// Token: 0x06002D7B RID: 11643 RVA: 0x0014C8E8 File Offset: 0x0014AAE8
	public void ELFALPCLKIE()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = true;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("The shader ");
		}
	}

	// Token: 0x06002D7C RID: 11644 RVA: 0x0014C954 File Offset: 0x0014AB54
	public bool AOBILOAHIAC(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 537f;
	}

	// Token: 0x06002D7D RID: 11645 RVA: 0x0014CAC8 File Offset: 0x0014ACC8
	public bool FLLMNNIKAMB(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1589f;
	}

	// Token: 0x06002D7E RID: 11646 RVA: 0x0014CC3C File Offset: 0x0014AE3C
	public void FJGIBCHABIG()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("AssetBundleManager");
		}
	}

	// Token: 0x06002D7F RID: 11647 RVA: 0x0014CCA8 File Offset: 0x0014AEA8
	public void FECFLBMPAAL()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("FacePalm");
		}
	}

	// Token: 0x06002D80 RID: 11648 RVA: 0x0014CD14 File Offset: 0x0014AF14
	public bool MGNNFMJFCOM(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 1306f;
	}

	// Token: 0x06002D81 RID: 11649 RVA: 0x0014CE88 File Offset: 0x0014B088
	public void AOCDDBNBADJ()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = true;
		IL_41:
		if (flag)
		{
			Debug.LogError("{{{{{0},{1}}}}}");
		}
	}

	// Token: 0x06002D82 RID: 11650 RVA: 0x0014CEF4 File Offset: 0x0014B0F4
	public bool DEMAHBJHJLF(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DOADLDOILHN.rectTransform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 pivot = this.DOADLDOILHN.rectTransform.pivot;
		Vector2 vector2 = new Vector2(pivot.x + vector.x / this.DOADLDOILHN.rectTransform.rect.width, pivot.y + vector.y / this.DOADLDOILHN.rectTransform.rect.height);
		Vector2 vector3 = new Vector2(this.DOADLDOILHN.sprite.rect.x + vector2.x * this.DOADLDOILHN.sprite.rect.width, this.DOADLDOILHN.sprite.rect.y + vector2.y * this.DOADLDOILHN.sprite.rect.height);
		vector3.x /= (float)this.DOADLDOILHN.sprite.texture.width;
		vector3.y /= (float)this.DOADLDOILHN.sprite.texture.height;
		return this.DOADLDOILHN.sprite.texture.GetPixelBilinear(vector3.x, vector3.y).a > 898f;
	}

	// Token: 0x06002D83 RID: 11651 RVA: 0x0014D068 File Offset: 0x0014B268
	public void EFCCCKGCOCB()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
		Texture2D texture = this.DOADLDOILHN.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
				goto IL_41;
			}
			catch (UnityException ex)
			{
				Debug.LogError(ex.Message);
				flag = true;
				goto IL_41;
			}
		}
		flag = false;
		IL_41:
		if (flag)
		{
			Debug.LogError("");
		}
	}

	// Token: 0x0400061B RID: 1563
	protected Image DOADLDOILHN;
}
