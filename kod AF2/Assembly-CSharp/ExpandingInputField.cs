using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200023D RID: 573
public class ExpandingInputField : UIBehaviour
{
	// Token: 0x06008262 RID: 33378 RVA: 0x003D84C0 File Offset: 0x003D66C0
	public void AGGJAPOLMMO(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "OnChatMessage");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "1HandSwordChargeUp");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "[sysname]");
		if (this.CFBBONPJONO() != null)
		{
			this.JLIPDFEGHFN.text = this.JMELFGAFJJN().Replace(this.JLIPDFEGHFN.text, "WorkerPickaxe");
		}
		this.JLIPDFEGHFN.MoveTextEnd(true);
	}

	// Token: 0x06008263 RID: 33379 RVA: 0x003D857C File Offset: 0x003D677C
	public void highlight(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "<color=blue>$&</color>");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "<color=red>$&</color>");
		if (this.MAHHCGBBEMN != null)
		{
			this.JLIPDFEGHFN.text = this.MAHHCGBBEMN.Replace(this.JLIPDFEGHFN.text, "<color=green>$&</color>");
		}
		this.JLIPDFEGHFN.MoveTextEnd(false);
	}

	// Token: 0x06008264 RID: 33380 RVA: 0x003D8638 File Offset: 0x003D6838
	public void FCBMPHPAJHL(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "SpinReel.ogg");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "FOVKick camera is null, please supply the camera to the constructor");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "RIGHT");
		if (this.HJNBEBBJLDA() != null)
		{
			this.JLIPDFEGHFN.text = this.HAGNPAPGBPF().Replace(this.JLIPDFEGHFN.text, "BipedReferences spine hierarchy is invalid. Bone transforms in the spine do not belong to the same ancestry. Please make sure the bones are parented to each other.");
		}
		this.JLIPDFEGHFN.MoveTextEnd(true);
	}

	// Token: 0x06008265 RID: 33381 RVA: 0x003D86F1 File Offset: 0x003D68F1
	private void AHFFKFHIIBH(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "PLANE_REFLECTION");
	}

	// Token: 0x06008266 RID: 33382 RVA: 0x003D871C File Offset: 0x003D691C
	protected virtual void INDGOHJGCFN()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.EALECLIBHIG));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.BMAGNMFOCIL));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.KELDOEAFEPI));
	}

	// Token: 0x06008267 RID: 33383 RVA: 0x003D8790 File Offset: 0x003D6990
	private void MHNFPDNLIJO(string FPIHOPOCAHA)
	{
		Debug.Log("</color>");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = true;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 1701f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 265f)
		{
			object[] array = new object[6];
			array[0] = "ExceptionOnConnect PROCEDURE ";
			array[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[2] = "deltext";
			array[5] = num;
			array[3] = "Sexy Dance 3";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1439f)
		{
			object[] array2 = new object[7];
			array2[1] = "crft_norec";
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[0] = "auc_wcstc";
			array2[7] = num;
			array2[8] = "Crate Pull";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x06008268 RID: 33384 RVA: 0x003D8914 File Offset: 0x003D6B14
	private void LFGEKMICPDI(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "RepFractions.xml");
	}

	// Token: 0x06008269 RID: 33385 RVA: 0x003D893C File Offset: 0x003D6B3C
	public void GFJJNEKNPAI(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "no_adm");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "_NeutralTonemapperParams1");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "<b>ObscuredString:</b> ");
		if (this.IJBPHAIECNJ() != null)
		{
			this.JLIPDFEGHFN.text = this.IJBPHAIECNJ().Replace(this.JLIPDFEGHFN.text, "Kernel");
		}
		this.JLIPDFEGHFN.MoveTextEnd(true);
	}

	// Token: 0x0600826A RID: 33386 RVA: 0x003D89F8 File Offset: 0x003D6BF8
	protected virtual void DDEBDCGNCPC()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.MBIFEMGEFCD));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.GFJJNEKNPAI));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.AMDCNHDPHHA));
	}

	// Token: 0x0600826B RID: 33387 RVA: 0x003D8A6A File Offset: 0x003D6C6A
	private void OMABDKGFPLM(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "end load ");
	}

	// Token: 0x0600826C RID: 33388 RVA: 0x003D8A94 File Offset: 0x003D6C94
	public void BMAGNMFOCIL(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "Level: ");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "");
		if (this.HAGNPAPGBPF() != null)
		{
			this.JLIPDFEGHFN.text = this.BDELHOHMPJH().Replace(this.JLIPDFEGHFN.text, "RollerBladeFrontFlip");
		}
		this.JLIPDFEGHFN.MoveTextEnd(true);
	}

	// Token: 0x0600826D RID: 33389 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex JMELFGAFJJN()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x0600826E RID: 33390 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex CMPNPJMGOFL()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x0600826F RID: 33391 RVA: 0x003D8B58 File Offset: 0x003D6D58
	public void FMKJMAIDKCK(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "Whistle");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "BACKCOLOR");
		if (this.BLKJGFEDHLC() != null)
		{
			this.JLIPDFEGHFN.text = this.MAHHCGBBEMN.Replace(this.JLIPDFEGHFN.text, "WorkerHammer2");
		}
		this.JLIPDFEGHFN.MoveTextEnd(false);
	}

	// Token: 0x06008270 RID: 33392 RVA: 0x003D8C14 File Offset: 0x003D6E14
	protected virtual void LHJCHPFKGDB()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.FAHIHEBENCD));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.GLGEMIOJKMI));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.FHBOFPPOCGJ));
	}

	// Token: 0x06008271 RID: 33393 RVA: 0x003D8C88 File Offset: 0x003D6E88
	public void HFFFDFLCIKA(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "wpn_dress2");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "Attached object");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "ClimbLeft");
		if (this.BLKJGFEDHLC() != null)
		{
			this.JLIPDFEGHFN.text = this.IEGAMAKPAPM().Replace(this.JLIPDFEGHFN.text, "");
		}
		this.JLIPDFEGHFN.MoveTextEnd(false);
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06008272 RID: 33394 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	// (set) Token: 0x06008281 RID: 33409 RVA: 0x003D96EC File Offset: 0x003D78EC
	public Regex MAHHCGBBEMN { get; set; }

	// Token: 0x06008273 RID: 33395 RVA: 0x003D8D44 File Offset: 0x003D6F44
	private void HCPNDGBPNCB(string FPIHOPOCAHA)
	{
		Debug.Log("***Lots ");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 596f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1145f)
		{
			object[] array = new object[7];
			array[1] = "holes_min";
			array[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[8] = "wpn_hookf";
			array[6] = num;
			array[6] = "CrawlIdle";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1605f)
		{
			object[] array2 = new object[2];
			array2[0] = "IdleWalk";
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[7] = "_GrainOffsetScale";
			array2[6] = num;
			array2[3] = "auk_wcnt";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x06008274 RID: 33396 RVA: 0x003D8EC8 File Offset: 0x003D70C8
	private void ONHEMGBLILH(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "wpn_bait_vob_1");
	}

	// Token: 0x06008275 RID: 33397 RVA: 0x003D8EF0 File Offset: 0x003D70F0
	private void EMJJPLJNFMD(string FPIHOPOCAHA)
	{
		Debug.Log("FlyDown");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 233f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 125f)
		{
			object[] array = new object[4];
			array[0] = "musicVolume";
			array[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[6] = "IdleReadyCrouch";
			array[2] = num;
			array[0] = "name";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1087f)
		{
			object[] array2 = new object[0];
			array2[1] = "MotorbikeWheelyNoHands";
			array2[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[6] = "Cheating detectors";
			array2[0] = num;
			array2[3] = "FlyUp";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x06008276 RID: 33398 RVA: 0x003D9074 File Offset: 0x003D7274
	private void EALECLIBHIG(string FPIHOPOCAHA)
	{
		Debug.Log("[LH &]");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = true;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 204f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1760f)
		{
			object[] array = new object[6];
			array[0] = "Thigh";
			array[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[1] = "IdleStandingJump";
			array[0] = num;
			array[5] = "Chain number ";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 724f)
		{
			object[] array2 = new object[5];
			array2[1] = "KatanaReadyHigh";
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[1] = "LMB to shoot the Dummy, RMB to rotate the camera.";
			array2[6] = num;
			array2[4] = "Down Index:";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x06008277 RID: 33399 RVA: 0x003D91F8 File Offset: 0x003D73F8
	public void ELFOFGCLDPE(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "Windows/");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "Bip");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "_TrStartYou.ogg");
		if (this.BDELHOHMPJH() != null)
		{
			this.JLIPDFEGHFN.text = this.IEGAMAKPAPM().Replace(this.JLIPDFEGHFN.text, "SoccerPassHeavy");
		}
		this.JLIPDFEGHFN.MoveTextEnd(false);
	}

	// Token: 0x06008278 RID: 33400 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex MAGNGBNODCA()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x06008279 RID: 33401 RVA: 0x003D92B4 File Offset: 0x003D74B4
	private void JBKHMCKBAPI(string FPIHOPOCAHA)
	{
		Debug.Log("Hidden/Amplify Color/Mask");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 797f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1001f)
		{
			object[] array = new object[2];
			array[0] = "\\n";
			array[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[7] = "Idle Mouth Wipe";
			array[6] = num;
			array[0] = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1164f)
		{
			object[] array2 = new object[8];
			array2[0] = "MotorbikeLassoLeft";
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[3] = "WateringCanWatering";
			array2[4] = num;
			array2[5] = "Flap_02.wav";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x0600827A RID: 33402 RVA: 0x003D9438 File Offset: 0x003D7638
	public void OKJEONDHCPP(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "Shoot Left");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "trn_end");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "MotorbikeIdle");
		if (this.CFBBONPJONO() != null)
		{
			this.JLIPDFEGHFN.text = this.JMELFGAFJJN().Replace(this.JLIPDFEGHFN.text, "focus :D");
		}
		this.JLIPDFEGHFN.MoveTextEnd(false);
	}

	// Token: 0x0600827B RID: 33403 RVA: 0x003D94F4 File Offset: 0x003D76F4
	protected virtual void FIJKDFIMELM()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.NEMNOHFOGIK));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.BMAGNMFOCIL));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.FHBOFPPOCGJ));
	}

	// Token: 0x0600827C RID: 33404 RVA: 0x003D9568 File Offset: 0x003D7768
	private void AJKJELNAJGB(string FPIHOPOCAHA)
	{
		Debug.Log("holes_min");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = true;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 1747f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1591f)
		{
			object[] array = new object[8];
			array[0] = "musicVolume";
			array[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[6] = "cellicon";
			array[6] = num;
			array[8] = "{x}";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 33f)
		{
			object[] array2 = new object[2];
			array2[0] = "SkateboardKickPush";
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[0] = "**********  dropPrikormEvnt";
			array2[8] = num;
			array2[4] = "wpn_wgt";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x0600827D RID: 33405 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void MIBJKHFKCCB(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600827E RID: 33406 RVA: 0x003D96F5 File Offset: 0x003D78F5
	private void GDLJFPKOIFO(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "_ReflectionBlur");
	}

	// Token: 0x0600827F RID: 33407 RVA: 0x003D9720 File Offset: 0x003D7920
	public void KPELDPLILOA(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "lineOverDistanc=");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "Eye");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "error baseid: ");
		if (this.HJNBEBBJLDA() != null)
		{
			this.JLIPDFEGHFN.text = this.JKKFFLAPFMG().Replace(this.JLIPDFEGHFN.text, "knopje.wav");
		}
		this.JLIPDFEGHFN.MoveTextEnd(true);
	}

	// Token: 0x06008280 RID: 33408 RVA: 0x003D97DC File Offset: 0x003D79DC
	protected virtual void PBMPJPIMJBF()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.EBDCMHOPGNJ));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.HFFFDFLCIKA));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.AHFFKFHIIBH));
	}

	// Token: 0x06008282 RID: 33410 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void KEDDNEJCGCL(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008283 RID: 33411 RVA: 0x003D9850 File Offset: 0x003D7A50
	private void EBDCMHOPGNJ(string FPIHOPOCAHA)
	{
		Debug.Log("wpn_add/base");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 1284f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 144f)
		{
			object[] array = new object[8];
			array[1] = "</color>";
			array[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[1] = ".lng";
			array[6] = num;
			array[8] = "EventSystem";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1254f)
		{
			object[] array2 = new object[0];
			array2[0] = "choldposx";
			array2[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[4] = "MotorbikeWheelyNoHands";
			array2[6] = num;
			array2[3] = "SexyDance2";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x06008284 RID: 33412 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex PEOJMLPGJFL()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x06008285 RID: 33413 RVA: 0x003D99D4 File Offset: 0x003D7BD4
	private void KELDOEAFEPI(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "IdleMonster");
	}

	// Token: 0x06008286 RID: 33414 RVA: 0x003D99FC File Offset: 0x003D7BFC
	public void HNIBALBMHBP(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "LeftSplashPause");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "UpHillWalk");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "StaffStand");
		if (this.IEGAMAKPAPM() != null)
		{
			this.JLIPDFEGHFN.text = this.JMELFGAFJJN().Replace(this.JLIPDFEGHFN.text, "OneHandSwordRun");
		}
		this.JLIPDFEGHFN.MoveTextEnd(true);
	}

	// Token: 0x06008287 RID: 33415 RVA: 0x003D9AB8 File Offset: 0x003D7CB8
	protected virtual void OBJCOJEHLBE()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.FNLJINHKOOI));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.KPELDPLILOA));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.GDLJFPKOIFO));
	}

	// Token: 0x06008288 RID: 33416 RVA: 0x003D9B2C File Offset: 0x003D7D2C
	protected virtual void BBFPILBIMKC()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.MHNFPDNLIJO));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.BMAGNMFOCIL));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.OMABDKGFPLM));
	}

	// Token: 0x06008289 RID: 33417 RVA: 0x003D9BA0 File Offset: 0x003D7DA0
	protected virtual void LPNDCJKAKEA()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.JBKHMCKBAPI));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.highlight));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.EIDNIDHCEJN));
	}

	// Token: 0x0600828A RID: 33418 RVA: 0x003D9C12 File Offset: 0x003D7E12
	private void FHBOFPPOCGJ(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "_ScatterTexture");
	}

	// Token: 0x0600828B RID: 33419 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void AOOPGHMIFGL(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600828C RID: 33420 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex OBAJNNANIFG()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x0600828D RID: 33421 RVA: 0x003D9C3C File Offset: 0x003D7E3C
	private void FAHIHEBENCD(string FPIHOPOCAHA)
	{
		Debug.Log("StartPhysPoint");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = true;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 442f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1043f)
		{
			object[] array = new object[5];
			array[0] = "Turn Right";
			array[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[1] = "Fonts/";
			array[1] = num;
			array[6] = "Elephant";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1437f)
		{
			object[] array2 = new object[1];
			array2[0] = "DEPTH_OF_FIELD_COC_VIEW";
			array2[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[2] = "1.6.2";
			array2[1] = num;
			array2[8] = "WATER_SIMPLE";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x0600828E RID: 33422 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex CFBBONPJONO()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x06008290 RID: 33424 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void CPHALNEIMGC(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008291 RID: 33425 RVA: 0x003D9DF8 File Offset: 0x003D7FF8
	protected virtual void PNAAHEFHPCL()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.IBBHBMNJCIG));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.FEEHDECEEMJ));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.AHFFKFHIIBH));
	}

	// Token: 0x06008292 RID: 33426 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex JKKFFLAPFMG()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x06008293 RID: 33427 RVA: 0x003D9E6C File Offset: 0x003D806C
	public void BKIHJFPINEF(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "wgt_gr");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "_rcIn.ogg");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "Idle Walk");
		if (this.MAHHCGBBEMN != null)
		{
			this.JLIPDFEGHFN.text = this.DCNAOOJAJBD().Replace(this.JLIPDFEGHFN.text, "WizardNeoBlock");
		}
		this.JLIPDFEGHFN.MoveTextEnd(false);
	}

	// Token: 0x06008294 RID: 33428 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex DCNAOOJAJBD()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x06008295 RID: 33429 RVA: 0x003D9F25 File Offset: 0x003D8125
	private void HKKEGFMOBCG(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "rodUpDelta=");
	}

	// Token: 0x06008296 RID: 33430 RVA: 0x003D9F50 File Offset: 0x003D8150
	protected virtual void GDIMBBBPIHI()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.IBBHBMNJCIG));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.KPELDPLILOA));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.LFGEKMICPDI));
	}

	// Token: 0x06008297 RID: 33431 RVA: 0x003D9FC2 File Offset: 0x003D81C2
	private void CJADBOJDOCG(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "full");
	}

	// Token: 0x06008298 RID: 33432 RVA: 0x003D9FEC File Offset: 0x003D81EC
	public void GLGEMIOJKMI(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "#a02000");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "_MidGrey");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "'");
		if (this.DCNAOOJAJBD() != null)
		{
			this.JLIPDFEGHFN.text = this.IEGAMAKPAPM().Replace(this.JLIPDFEGHFN.text, "11");
		}
		this.JLIPDFEGHFN.MoveTextEnd(true);
	}

	// Token: 0x06008299 RID: 33433 RVA: 0x003DA0A8 File Offset: 0x003D82A8
	private void MNBFJAFFFBK(string FPIHOPOCAHA)
	{
		Debug.Log(" cannot be used as a 3D LUT.");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 914f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1552f)
		{
			object[] array = new object[]
			{
				null,
				"ClimbRight"
			};
			array[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[6] = "none";
			array[0] = num;
			array[3] = "fishSPEED=";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1888f)
		{
			object[] array2 = new object[0];
			array2[1] = "cht_tofrendmsg";
			array2[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[5] = "Hidden/ACTk/WallHackTexture";
			array2[5] = num;
			array2[3] = "Hidden/Post FX/Fog";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x0600829A RID: 33434 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void CMMFNBILKIF(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600829B RID: 33435 RVA: 0x003DA22C File Offset: 0x003D842C
	private void OHJNMJJDHEB(string FPIHOPOCAHA)
	{
		Debug.Log("isMoving");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = true;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 1608f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1758f)
		{
			object[] array = new object[0];
			array[1] = "";
			array[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[5] = " ";
			array[6] = num;
			array[4] = "_PixelsPerMeterAtOneMeter";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1334f)
		{
			object[] array2 = new object[0];
			array2[0] = "white";
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[3] = "SexyDance";
			array2[2] = num;
			array2[8] = "QTask.xml";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x0600829C RID: 33436 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex DILENPKAAHK()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x0600829D RID: 33437 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex IJBPHAIECNJ()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x0600829E RID: 33438 RVA: 0x003DA3B0 File Offset: 0x003D85B0
	private void FNLJINHKOOI(string FPIHOPOCAHA)
	{
		Debug.Log("<color='#300000'>{0} {1}</color>");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = true;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 1230f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1916f)
		{
			object[] array = new object[6];
			array[0] = "IdleMouthWipe";
			array[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[6] = "<color='{0}'> {1} ур {2}</color>\n";
			array[2] = num;
			array[6] = "WateringCan";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 19f)
		{
			object[] array2 = new object[5];
			array2[1] = "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.";
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[8] = "addpar";
			array2[8] = num;
			array2[7] = "WeaponRun";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x0600829F RID: 33439 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void HBBNBMJPNFE(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060082A0 RID: 33440 RVA: 0x003DA534 File Offset: 0x003D8734
	protected virtual void JHFAHBIIJDC()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.EALECLIBHIG));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.BKIHJFPINEF));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.NDJHGOKMGHG));
	}

	// Token: 0x060082A1 RID: 33441 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void OKHOOLFPJKA(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060082A2 RID: 33442 RVA: 0x003DA5A8 File Offset: 0x003D87A8
	private void MBIFEMGEFCD(string FPIHOPOCAHA)
	{
		Debug.Log("Crouch180");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 1510f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1875f)
		{
			object[] array = new object[5];
			array[1] = "effects";
			array[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[1] = "UpHillWalkHandGrab";
			array[6] = num;
			array[6] = "selColor";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 135f)
		{
			object[] array2 = new object[]
			{
				"USE_DEPTH"
			};
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[8] = "name";
			array2[5] = num;
			array2[3] = "\n";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x060082A3 RID: 33443 RVA: 0x003DA72C File Offset: 0x003D892C
	protected virtual void EHFPLKEINFO()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.EMJJPLJNFMD));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.HNIBALBMHBP));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.PIMMBKOPMAL));
	}

	// Token: 0x060082A4 RID: 33444 RVA: 0x003DA79E File Offset: 0x003D899E
	private void AMDCNHDPHHA(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "F3");
	}

	// Token: 0x060082A5 RID: 33445 RVA: 0x003DA7C8 File Offset: 0x003D89C8
	protected virtual void AFFAJKPPMHF()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.MBIFEMGEFCD));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.AGGJAPOLMMO));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.CJADBOJDOCG));
	}

	// Token: 0x060082A6 RID: 33446 RVA: 0x003DA83A File Offset: 0x003D8A3A
	private void MPKAJAFAHEL(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "lifeBar");
	}

	// Token: 0x060082A7 RID: 33447 RVA: 0x003DA864 File Offset: 0x003D8A64
	protected virtual void CGMHGDEKDEP()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.EALECLIBHIG));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.FCBMPHPAJHL));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.FAEKLGIBEDP));
	}

	// Token: 0x060082A8 RID: 33448 RVA: 0x003DA8D8 File Offset: 0x003D8AD8
	protected virtual void EFCCCKGCOCB()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.OHJNMJJDHEB));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.FMKJMAIDKCK));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.GDLJFPKOIFO));
	}

	// Token: 0x060082A9 RID: 33449 RVA: 0x003DA94C File Offset: 0x003D8B4C
	private void FGHBFGDGEOD(string FPIHOPOCAHA)
	{
		Debug.Log("some kind of resizing horror");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 10f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 10f)
		{
			Debug.Log(string.Concat(new object[]
			{
				"i grew because the inputfield was only this big",
				this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height,
				"and I needed",
				num,
				"space"
			}));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 10f)
		{
			Debug.Log(string.Concat(new object[]
			{
				"i shrank because the inputfield was this big",
				this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height,
				"and I needed",
				num,
				"space"
			}));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x060082AA RID: 33450 RVA: 0x003DAAD0 File Offset: 0x003D8CD0
	public void LOLNJEBEEOD(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "Watering Can Idle");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "_InvRenderTargetSize");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "SoccerPassHeavy");
		if (this.BDELHOHMPJH() != null)
		{
			this.JLIPDFEGHFN.text = this.DILENPKAAHK().Replace(this.JLIPDFEGHFN.text, "TOD_MoonSkyColor");
		}
		this.JLIPDFEGHFN.MoveTextEnd(false);
	}

	// Token: 0x060082AB RID: 33451 RVA: 0x003DAB89 File Offset: 0x003D8D89
	private void NDJHGOKMGHG(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "UnityEngine.Vector3");
	}

	// Token: 0x060082AC RID: 33452 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void HGPAJHPGFEK(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060082AD RID: 33453 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex IEGAMAKPAPM()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x060082AE RID: 33454 RVA: 0x003DABB1 File Offset: 0x003D8DB1
	private void HEJNIJHGLME(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "ObscuredUInt vs uint, ");
	}

	// Token: 0x060082AF RID: 33455 RVA: 0x003DABD9 File Offset: 0x003D8DD9
	private void FAEKLGIBEDP(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "Missing shader in ");
	}

	// Token: 0x060082B0 RID: 33456 RVA: 0x003DAC04 File Offset: 0x003D8E04
	protected virtual void KEMGOLACEHI()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.EALECLIBHIG));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.ELFOFGCLDPE));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.ONHEMGBLILH));
	}

	// Token: 0x060082B1 RID: 33457 RVA: 0x003DAC78 File Offset: 0x003D8E78
	protected virtual void IAAOGAPJDID()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.IBBHBMNJCIG));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.HFFFDFLCIKA));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.ONHEMGBLILH));
	}

	// Token: 0x060082B2 RID: 33458 RVA: 0x003DACEA File Offset: 0x003D8EEA
	private void EIDNIDHCEJN(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "_NoiseTex");
	}

	// Token: 0x060082B3 RID: 33459 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex BLKJGFEDHLC()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x060082B4 RID: 33460 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex HJNBEBBJLDA()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x060082B5 RID: 33461 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex BDELHOHMPJH()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x060082B6 RID: 33462 RVA: 0x003DAD14 File Offset: 0x003D8F14
	private void NEMNOHFOGIK(string FPIHOPOCAHA)
	{
		Debug.Log("_Parameter");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 676f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 1800f)
		{
			object[] array = new object[0];
			array[1] = "error";
			array[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[8] = "base_{0}";
			array[6] = num;
			array[3] = "sound/allmusic/music";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 482f)
		{
			object[] array2 = new object[7];
			array2[0] = "_camScale";
			array2[0] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[6] = "The shader ";
			array2[3] = num;
			array2[0] = "Bases/{0}/";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x060082B7 RID: 33463 RVA: 0x003DAE98 File Offset: 0x003D9098
	private void KFDINKDFPMP(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "**********  158 pointid=");
	}

	// Token: 0x060082B8 RID: 33464 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void APHEMILFFFP(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060082B9 RID: 33465 RVA: 0x003DAEC0 File Offset: 0x003D90C0
	private void PIMMBKOPMAL(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "");
	}

	// Token: 0x060082BA RID: 33466 RVA: 0x003DAEE8 File Offset: 0x003D90E8
	private void IBBHBMNJCIG(string FPIHOPOCAHA)
	{
		Debug.Log("Injection detected!");
		string text = this.JLIPDFEGHFN.text;
		Vector2 size = this.JLIPDFEGHFN.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = this.JLIPDFEGHFN.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = true;
		float num = new TextGenerator().GetPreferredHeight(text, generationSettings) + 883f;
		if (num > this.JLIPDFEGHFN.textComponent.rectTransform.rect.height - 771f)
		{
			object[] array = new object[4];
			array[0] = "#> _Planar Reflection Camera < ";
			array[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array[8] = "chest";
			array[7] = num;
			array[4] = "Hidden/Post FX/FXAA";
			Debug.Log(string.Concat(array));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
			return;
		}
		if (num < this.JLIPDFEGHFN.textComponent.rectTransform.rect.height + 1314f)
		{
			object[] array2 = new object[4];
			array2[1] = "Vertical";
			array2[1] = this.JLIPDFEGHFN.GetComponent<RectTransform>().rect.height;
			array2[4] = "{0:F2}, {1:F2}, {2:F2}, {3:F2}";
			array2[7] = num;
			array2[3] = "]";
			Debug.Log(string.Concat(array2));
			this.inputparent.GetComponent<LayoutElement>().preferredHeight = num;
		}
	}

	// Token: 0x060082BB RID: 33467 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void FKFAJJIBJOJ(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060082BC RID: 33468 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void EIAJCCKJJCE(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060082BD RID: 33469 RVA: 0x003DB06C File Offset: 0x003D926C
	protected override void Start()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.FGHBFGDGEOD));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.highlight));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.PIMMBKOPMAL));
	}

	// Token: 0x060082BE RID: 33470 RVA: 0x003DB0E0 File Offset: 0x003D92E0
	protected virtual void GGBMJFNGHMC()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.NEMNOHFOGIK));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.ELFOFGCLDPE));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.HKKEGFMOBCG));
	}

	// Token: 0x060082BF RID: 33471 RVA: 0x003D96EC File Offset: 0x003D78EC
	public void GAGNECJADEF(Regex DCCPCBLODIG)
	{
		this.<ILPPMCAKOJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060082C0 RID: 33472 RVA: 0x003DB154 File Offset: 0x003D9354
	protected virtual void JPHBPEAMNHB()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.NEMNOHFOGIK));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.HNIBALBMHBP));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.MPKAJAFAHEL));
	}

	// Token: 0x060082C1 RID: 33473 RVA: 0x003DB1C8 File Offset: 0x003D93C8
	protected virtual void BHFMGBNIAMC()
	{
		this.JLIPDFEGHFN = base.gameObject.GetComponent<InputField>();
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.MHNFPDNLIJO));
		this.JLIPDFEGHFN.onEndEdit.AddListener(new UnityAction<string>(this.AGGJAPOLMMO));
		this.JLIPDFEGHFN.onValueChange.AddListener(new UnityAction<string>(this.FHBOFPPOCGJ));
	}

	// Token: 0x060082C2 RID: 33474 RVA: 0x003D8B4D File Offset: 0x003D6D4D
	public Regex HAGNPAPGBPF()
	{
		return this.<ILPPMCAKOJP>k__BackingField;
	}

	// Token: 0x060082C3 RID: 33475 RVA: 0x003DB23C File Offset: 0x003D943C
	public void FEEHDECEEMJ(string FPIHOPOCAHA)
	{
		this.JLIPDFEGHFN.text = this.CJMHJLHABIH.Replace(this.JLIPDFEGHFN.text, "white");
		this.JLIPDFEGHFN.text = this.NGEGMBHNPGP.Replace(this.JLIPDFEGHFN.text, "OneHandSwordSwing");
		this.JLIPDFEGHFN.text = this.GFJCMNOGDFL.Replace(this.JLIPDFEGHFN.text, "invn_rec33");
		if (this.CFBBONPJONO() != null)
		{
			this.JLIPDFEGHFN.text = this.HAGNPAPGBPF().Replace(this.JLIPDFEGHFN.text, "cht_msg28");
		}
		this.JLIPDFEGHFN.MoveTextEnd(true);
	}

	// Token: 0x04001296 RID: 4758
	public GameObject inputparent;

	// Token: 0x04001297 RID: 4759
	private InputField JLIPDFEGHFN;

	// Token: 0x04001298 RID: 4760
	private Regex CJMHJLHABIH = new Regex("<[^>]*>");

	// Token: 0x04001299 RID: 4761
	private Regex NGEGMBHNPGP = new Regex("and |assert |break |class |continue |def |del |elif |else |except |exec |finally |for |from |global |if |import |in |is |lambda |not |or |pass |print |raise |return |try |while |yield |None |True |False ");

	// Token: 0x0400129A RID: 4762
	private Regex GFJCMNOGDFL = new Regex("<=|>=|!=");
}
