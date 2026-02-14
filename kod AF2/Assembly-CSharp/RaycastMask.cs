using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200024B RID: 587
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(Image))]
public class RaycastMask : MonoBehaviour, ICanvasRaycastFilter
{
	// Token: 0x060086C0 RID: 34496 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void PFNPOHMMJDN()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086C1 RID: 34497 RVA: 0x003EDAE8 File Offset: 0x003EBCE8
	public bool MDIDKPAHILO(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1407f);
		}
		catch (UnityException)
		{
			Debug.LogError("Sprint");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086C2 RID: 34498 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void ELFLOPJDAKK()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086C3 RID: 34499 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void AFFAJKPPMHF()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086C4 RID: 34500 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void OFGMIEJKMGC()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086C5 RID: 34501 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void EHFPLKEINFO()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086C6 RID: 34502 RVA: 0x003EDDCC File Offset: 0x003EBFCC
	public bool LMNELAIDCDM(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1719f);
		}
		catch (UnityException)
		{
			Debug.LogError("WorkerShovel");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086C7 RID: 34503 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void DHJDMKLBLEF()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086C8 RID: 34504 RVA: 0x003EE0B0 File Offset: 0x003EC2B0
	public bool CGAICIHKFBG(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1519f);
		}
		catch (UnityException)
		{
			Debug.LogError("_Intensity");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086C9 RID: 34505 RVA: 0x003EE394 File Offset: 0x003EC594
	public bool OAOHKHCPPGG(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 702f);
		}
		catch (UnityException)
		{
			Debug.LogError("");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086CA RID: 34506 RVA: 0x003EE678 File Offset: 0x003EC878
	public bool KHKDMBCJGHH(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1777f);
		}
		catch (UnityException)
		{
			Debug.LogError("cht_msg38");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086CB RID: 34507 RVA: 0x003EE95C File Offset: 0x003ECB5C
	public bool NCLAJCDEJLN(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 684f);
		}
		catch (UnityException)
		{
			Debug.LogError("crft_unl");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086CC RID: 34508 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void AOCDDBNBADJ()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086CD RID: 34509 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void CBLGFOFHNPJ()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086CE RID: 34510 RVA: 0x003EEC40 File Offset: 0x003ECE40
	public bool ODFNNPBDMHK(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1317f);
		}
		catch (UnityException)
		{
			Debug.LogError("RollerBladeSkateFwd");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086CF RID: 34511 RVA: 0x003EEF24 File Offset: 0x003ED124
	public bool PBIEHJICCIB(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1743f);
		}
		catch (UnityException)
		{
			Debug.LogError("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086D0 RID: 34512 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void CAJLCEPLKJG()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086D1 RID: 34513 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void ELADFDNPOOI()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086D2 RID: 34514 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void ONIHHFLOJMN()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086D3 RID: 34515 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void KKCFKEDABLB()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086D4 RID: 34516 RVA: 0x003EF208 File Offset: 0x003ED408
	public bool FOOGEAJECMJ(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1804f);
		}
		catch (UnityException)
		{
			Debug.LogError("OnTriggerExit");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086D5 RID: 34517 RVA: 0x003EF4EC File Offset: 0x003ED6EC
	public bool JLOACEEEDHI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 694f);
		}
		catch (UnityException)
		{
			Debug.LogError("PaperTurn.wav");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086D6 RID: 34518 RVA: 0x003EF7D0 File Offset: 0x003ED9D0
	public bool FJBLEFFELHJ(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1725f);
		}
		catch (UnityException)
		{
			Debug.LogError("inv already open");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086D7 RID: 34519 RVA: 0x003EFAB4 File Offset: 0x003EDCB4
	public bool OCCJBAPBAHN(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 271f);
		}
		catch (UnityException)
		{
			Debug.LogError(" <b>®</b></color> ");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086D8 RID: 34520 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void Start()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086D9 RID: 34521 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void FIJKDFIMELM()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086DA RID: 34522 RVA: 0x003EFD98 File Offset: 0x003EDF98
	public bool IGGNBDOOBPM(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1390f);
		}
		catch (UnityException)
		{
			Debug.LogError("BowFire");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086DB RID: 34523 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void IJOCHELLKJH()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086DC RID: 34524 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void BJHGPFGBFKF()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086DD RID: 34525 RVA: 0x003F007C File Offset: 0x003EE27C
	public bool DIDIDJADFHN(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1898f);
		}
		catch (UnityException)
		{
			Debug.LogError("How your lives count is stored in memory when obscured:\n");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086DE RID: 34526 RVA: 0x003F0360 File Offset: 0x003EE560
	public bool HGABOJJPPPL(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 447f);
		}
		catch (UnityException)
		{
			Debug.LogError("CrouchStrafeLeft");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086DF RID: 34527 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void DGGMJCMLLED()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086E0 RID: 34528 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void MCHAAIIHOKD()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086E1 RID: 34529 RVA: 0x003F0644 File Offset: 0x003EE844
	public bool DEMAHBJHJLF(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 162f);
		}
		catch (UnityException)
		{
			Debug.LogError("Cloth_05_00.wav");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086E2 RID: 34530 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void CPNOBMNKPNC()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086E3 RID: 34531 RVA: 0x003F0928 File Offset: 0x003EEB28
	public bool JBFKNAIODAA(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 823f);
		}
		catch (UnityException)
		{
			Debug.LogError("UnityEngine.Vector3");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086E4 RID: 34532 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void FFIGGPHAIBP()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086E5 RID: 34533 RVA: 0x003F0C0C File Offset: 0x003EEE0C
	public bool MAIAMPEPBNP(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1517f);
		}
		catch (UnityException)
		{
			Debug.LogError("money2.wav");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086E6 RID: 34534 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void JFFPLABGMNF()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086E7 RID: 34535 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void KFGKKLAKFGH()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086E8 RID: 34536 RVA: 0x003F0EF0 File Offset: 0x003EF0F0
	public bool AJOIFNMAIDI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1475f);
		}
		catch (UnityException)
		{
			Debug.LogError("KatanaReady");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086E9 RID: 34537 RVA: 0x003F11D4 File Offset: 0x003EF3D4
	public bool NCBMCKELDHK(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 342f);
		}
		catch (UnityException)
		{
			Debug.LogError("");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086EA RID: 34538 RVA: 0x003F14B8 File Offset: 0x003EF6B8
	public bool INANOMGEIEI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1385f);
		}
		catch (UnityException)
		{
			Debug.LogError("cht_msg18");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086EB RID: 34539 RVA: 0x003F179C File Offset: 0x003EF99C
	public bool AOBILOAHIAC(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 471f);
		}
		catch (UnityException)
		{
			Debug.LogError("wpn_wgt");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086EC RID: 34540 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void LMEJKAEIDCO()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086ED RID: 34541 RVA: 0x003F1A80 File Offset: 0x003EFC80
	public bool HIHOLNAMAMO(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1364f);
		}
		catch (UnityException)
		{
			Debug.LogError("Jump");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086EE RID: 34542 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void NCALLFHEAGJ()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086EF RID: 34543 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void EDGALMCHPPH()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086F0 RID: 34544 RVA: 0x003F1D64 File Offset: 0x003EFF64
	public bool ENBAOLIHIEA(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 51f);
		}
		catch (UnityException)
		{
			Debug.LogError("wpn_add/base");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x060086F2 RID: 34546 RVA: 0x003EDAD8 File Offset: 0x003EBCD8
	private void DGEIACONKCJ()
	{
		this.DOADLDOILHN = base.GetComponent<Image>();
	}

	// Token: 0x060086F3 RID: 34547 RVA: 0x003F2048 File Offset: 0x003F0248
	public bool IAOJHLHCKLE(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 1969f);
		}
		catch (UnityException)
		{
			Debug.LogError("PistolInstant");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086F4 RID: 34548 RVA: 0x003F232C File Offset: 0x003F052C
	public bool DNJPOEJOBJA(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Simple)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 74f);
		}
		catch (UnityException)
		{
			Debug.LogError("IdleSad");
			UnityEngine.Object.Destroy(this);
			result = true;
		}
		return result;
	}

	// Token: 0x060086F5 RID: 34549 RVA: 0x003F2610 File Offset: 0x003F0810
	public bool IsRaycastLocationValid(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		this.AFEKHBBLCGL = this.DOADLDOILHN.sprite;
		RectTransform rectTransform = (RectTransform)base.transform;
		Vector2 vector;
		RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, FOMHLOJALEC, IEBEDADFNCE, out vector);
		Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
		Rect textureRect = this.AFEKHBBLCGL.textureRect;
		Rect rect = rectTransform.rect;
		Image.Type type = this.DOADLDOILHN.type;
		int x;
		int y;
		if (type != Image.Type.Simple && type == Image.Type.Sliced)
		{
			Vector4 border = this.AFEKHBBLCGL.border;
			if (vector2.x < border.x)
			{
				x = Mathf.FloorToInt(textureRect.x + vector2.x);
			}
			else if (vector2.x > rect.width - border.z)
			{
				x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
			}
			else
			{
				x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
			}
			if (vector2.y < border.y)
			{
				y = Mathf.FloorToInt(textureRect.y + vector2.y);
			}
			else if (vector2.y > rect.height - border.w)
			{
				y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
			}
			else
			{
				y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
			}
		}
		else
		{
			x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
			y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
		}
		bool result;
		try
		{
			result = (this.AFEKHBBLCGL.texture.GetPixel(x, y).a > 0f);
		}
		catch (UnityException)
		{
			Debug.LogError("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'");
			UnityEngine.Object.Destroy(this);
			result = false;
		}
		return result;
	}

	// Token: 0x040012D9 RID: 4825
	private Image DOADLDOILHN;

	// Token: 0x040012DA RID: 4826
	private Sprite AFEKHBBLCGL;
}
