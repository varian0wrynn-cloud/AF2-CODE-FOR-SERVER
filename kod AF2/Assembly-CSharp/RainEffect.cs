using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000284 RID: 644
public class RainEffect : MonoBehaviour
{
	// Token: 0x060096E2 RID: 38626 RVA: 0x004355CC File Offset: 0x004337CC
	private void Update()
	{
		if (TimeController.IKGFHGKKCPG != null)
		{
			this.rainForce = TimeController.IKGFHGKKCPG.currentWeather.rain;
		}
		if (LocNewLogic.getI != null)
		{
			float waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * 1f;
			if (Fisherman.getI != null)
			{
				position = Fisherman.getI.transform.position + Fisherman.getI.transform.up * 10f;
				this.part.transform.position = position;
			}
			position.y = waterLevel + 0.02f;
			this.rainCircles.transform.position = position;
			int num = Mathf.RoundToInt(this.MKPLPAJPDEK * 200f);
			num = Mathf.Clamp(num, 0, 1000);
			ParticleSystem.EmissionModule emission = this.rainCircles.emission;
			ParticleSystem.MinMaxCurve rateOverTime = emission.rateOverTime;
			rateOverTime.constant = (float)num;
			emission.rateOverTime = rateOverTime;
		}
		this.MKPLPAJPDEK = Mathf.Lerp(this.MKPLPAJPDEK, this.rainForce, Time.deltaTime);
		int num2 = Mathf.RoundToInt(this.MKPLPAJPDEK * 200f);
		num2 = Mathf.Clamp(num2, 0, 2000);
		ParticleSystem.EmissionModule emission2 = this.part.emission;
		ParticleSystem.MinMaxCurve rateOverTime2 = emission2.rateOverTime;
		rateOverTime2.constantMax = (float)num2;
		emission2.rateOverTime = rateOverTime2;
		float num3 = Mathf.Clamp(this.rainForce / 5f, 0f, 1f);
		this.rainSrc.volume = num3 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		if (num3 < 0.1f)
		{
			if (this.rainSrc.isPlaying)
			{
				this.rainSrc.Stop();
				return;
			}
		}
		else if (!this.rainSrc.isPlaying)
		{
			this.rainSrc.Play();
		}
	}

	// Token: 0x060096E3 RID: 38627 RVA: 0x004357CC File Offset: 0x004339CC
	private IEnumerator JGCCGMDICPG()
	{
		return new RainEffect.JPFIADMNBHC(1);
	}

	// Token: 0x060096E4 RID: 38628 RVA: 0x004357D4 File Offset: 0x004339D4
	private IEnumerator NOJJBIODEEM()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060096E6 RID: 38630 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LPNDCJKAKEA()
	{
	}

	// Token: 0x060096E7 RID: 38631 RVA: 0x004357DC File Offset: 0x004339DC
	private void LDDIGEMBDNF()
	{
		if (TimeController.IKGFHGKKCPG != null)
		{
			this.rainForce = TimeController.IKGFHGKKCPG.currentWeather.rain;
		}
		if (LocNewLogic.getI != null)
		{
			float num = LocNewLogic.getI.CDBIEPGNONF();
			Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * 570f;
			if (Fisherman.getI != null)
			{
				position = Fisherman.getI.transform.position + Fisherman.getI.transform.up * 277f;
				this.part.transform.position = position;
			}
			position.y = num + 408f;
			this.rainCircles.transform.position = position;
			int num2 = Mathf.RoundToInt(this.MKPLPAJPDEK * 1258f);
			num2 = Mathf.Clamp(num2, 1, 45);
			ParticleSystem.EmissionModule emission = this.rainCircles.emission;
			ParticleSystem.MinMaxCurve rateOverTime = emission.rateOverTime;
			rateOverTime.constant = (float)num2;
			emission.rateOverTime = rateOverTime;
		}
		this.MKPLPAJPDEK = Mathf.Lerp(this.MKPLPAJPDEK, this.rainForce, Time.deltaTime);
		int num3 = Mathf.RoundToInt(this.MKPLPAJPDEK * 1263f);
		num3 = Mathf.Clamp(num3, 1, -92);
		ParticleSystem.EmissionModule emission2 = this.part.emission;
		ParticleSystem.MinMaxCurve rateOverTime2 = emission2.rateOverTime;
		rateOverTime2.constantMax = (float)num3;
		emission2.rateOverTime = rateOverTime2;
		float num4 = Mathf.Clamp(this.rainForce / 1299f, 330f, 1835f);
		this.rainSrc.volume = num4 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		if (num4 < 1914f)
		{
			if (this.rainSrc.isPlaying)
			{
				this.rainSrc.Stop();
				return;
			}
		}
		else if (!this.rainSrc.isPlaying)
		{
			this.rainSrc.Play();
		}
	}

	// Token: 0x060096E8 RID: 38632 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ONIHHFLOJMN()
	{
	}

	// Token: 0x060096E9 RID: 38633 RVA: 0x004357D4 File Offset: 0x004339D4
	private IEnumerator LMNLFMFBCMO()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060096EA RID: 38634 RVA: 0x004359DC File Offset: 0x00433BDC
	private void JLFBDOPFDDJ()
	{
		if (TimeController.BOBNPEAEECC() != null)
		{
			this.rainForce = TimeController.BOBNPEAEECC().currentWeather.rain;
		}
		if (LocNewLogic.getI != null)
		{
			float waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * 724f;
			if (Fisherman.getI != null)
			{
				position = Fisherman.getI.transform.position + Fisherman.getI.transform.up * 915f;
				this.part.transform.position = position;
			}
			position.y = waterLevel + 353f;
			this.rainCircles.transform.position = position;
			int num = Mathf.RoundToInt(this.MKPLPAJPDEK * 66f);
			num = Mathf.Clamp(num, 0, -88);
			ParticleSystem.EmissionModule emission = this.rainCircles.emission;
			ParticleSystem.MinMaxCurve rateOverTime = emission.rateOverTime;
			rateOverTime.constant = (float)num;
			emission.rateOverTime = rateOverTime;
		}
		this.MKPLPAJPDEK = Mathf.Lerp(this.MKPLPAJPDEK, this.rainForce, Time.deltaTime);
		int num2 = Mathf.RoundToInt(this.MKPLPAJPDEK * 262f);
		num2 = Mathf.Clamp(num2, 1, -83);
		ParticleSystem.EmissionModule emission2 = this.part.emission;
		ParticleSystem.MinMaxCurve rateOverTime2 = emission2.rateOverTime;
		rateOverTime2.constantMax = (float)num2;
		emission2.rateOverTime = rateOverTime2;
		float num3 = Mathf.Clamp(this.rainForce / 1769f, 129f, 1474f);
		this.rainSrc.volume = num3 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		if (num3 < 642f)
		{
			if (this.rainSrc.isPlaying)
			{
				this.rainSrc.Stop();
				return;
			}
		}
		else if (!this.rainSrc.isPlaying)
		{
			this.rainSrc.Play();
		}
	}

	// Token: 0x060096EB RID: 38635 RVA: 0x004357D4 File Offset: 0x004339D4
	private IEnumerator CMEEIOFMKHO()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060096EC RID: 38636 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OFGMIEJKMGC()
	{
	}

	// Token: 0x060096ED RID: 38637 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ELFLOPJDAKK()
	{
	}

	// Token: 0x060096EE RID: 38638 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x060096EF RID: 38639 RVA: 0x00435BDC File Offset: 0x00433DDC
	private void PJHEGHHOJHJ()
	{
		if (TimeController.KOJCECHBHLO() != null)
		{
			this.rainForce = TimeController.EKEBHIJMEML().currentWeather.rain;
		}
		if (LocNewLogic.getI != null)
		{
			float num = LocNewLogic.getI.IGHOGONIKLC();
			Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * 370f;
			if (Fisherman.getI != null)
			{
				position = Fisherman.getI.transform.position + Fisherman.getI.transform.up * 693f;
				this.part.transform.position = position;
			}
			position.y = num + 578f;
			this.rainCircles.transform.position = position;
			int num2 = Mathf.RoundToInt(this.MKPLPAJPDEK * 1856f);
			num2 = Mathf.Clamp(num2, 1, -79);
			ParticleSystem.EmissionModule emission = this.rainCircles.emission;
			ParticleSystem.MinMaxCurve rateOverTime = emission.rateOverTime;
			rateOverTime.constant = (float)num2;
			emission.rateOverTime = rateOverTime;
		}
		this.MKPLPAJPDEK = Mathf.Lerp(this.MKPLPAJPDEK, this.rainForce, Time.deltaTime);
		int num3 = Mathf.RoundToInt(this.MKPLPAJPDEK * 1771f);
		num3 = Mathf.Clamp(num3, 0, 109);
		ParticleSystem.EmissionModule emission2 = this.part.emission;
		ParticleSystem.MinMaxCurve rateOverTime2 = emission2.rateOverTime;
		rateOverTime2.constantMax = (float)num3;
		emission2.rateOverTime = rateOverTime2;
		float num4 = Mathf.Clamp(this.rainForce / 1618f, 912f, 537f);
		this.rainSrc.volume = num4 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		if (num4 < 704f)
		{
			if (this.rainSrc.isPlaying)
			{
				this.rainSrc.Stop();
				return;
			}
		}
		else if (!this.rainSrc.isPlaying)
		{
			this.rainSrc.Play();
		}
	}

	// Token: 0x060096F0 RID: 38640 RVA: 0x00435DDC File Offset: 0x00433FDC
	private void KJJBBLDJHPD()
	{
		if (TimeController.IKGFHGKKCPG != null)
		{
			this.rainForce = TimeController.EKEBHIJMEML().currentWeather.rain;
		}
		if (LocNewLogic.getI != null)
		{
			float num = LocNewLogic.getI.HKBNODJBGEL();
			Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * 1615f;
			if (Fisherman.getI != null)
			{
				position = Fisherman.getI.transform.position + Fisherman.getI.transform.up * 606f;
				this.part.transform.position = position;
			}
			position.y = num + 1669f;
			this.rainCircles.transform.position = position;
			int num2 = Mathf.RoundToInt(this.MKPLPAJPDEK * 637f);
			num2 = Mathf.Clamp(num2, 0, -173);
			ParticleSystem.EmissionModule emission = this.rainCircles.emission;
			ParticleSystem.MinMaxCurve rateOverTime = emission.rateOverTime;
			rateOverTime.constant = (float)num2;
			emission.rateOverTime = rateOverTime;
		}
		this.MKPLPAJPDEK = Mathf.Lerp(this.MKPLPAJPDEK, this.rainForce, Time.deltaTime);
		int num3 = Mathf.RoundToInt(this.MKPLPAJPDEK * 1606f);
		num3 = Mathf.Clamp(num3, 0, -65);
		ParticleSystem.EmissionModule emission2 = this.part.emission;
		ParticleSystem.MinMaxCurve rateOverTime2 = emission2.rateOverTime;
		rateOverTime2.constantMax = (float)num3;
		emission2.rateOverTime = rateOverTime2;
		float num4 = Mathf.Clamp(this.rainForce / 1838f, 272f, 538f);
		this.rainSrc.volume = num4 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		if (num4 < 519f)
		{
			if (this.rainSrc.isPlaying)
			{
				this.rainSrc.Stop();
				return;
			}
		}
		else if (!this.rainSrc.isPlaying)
		{
			this.rainSrc.Play();
		}
	}

	// Token: 0x060096F1 RID: 38641 RVA: 0x00435FDC File Offset: 0x004341DC
	private void DFFOEGHGPGP()
	{
		if (TimeController.IKGFHGKKCPG != null)
		{
			this.rainForce = TimeController.IKGFHGKKCPG.currentWeather.rain;
		}
		if (LocNewLogic.getI != null)
		{
			float num = LocNewLogic.getI.CDBIEPGNONF();
			Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * 8f;
			if (Fisherman.getI != null)
			{
				position = Fisherman.getI.transform.position + Fisherman.getI.transform.up * 1588f;
				this.part.transform.position = position;
			}
			position.y = num + 356f;
			this.rainCircles.transform.position = position;
			int num2 = Mathf.RoundToInt(this.MKPLPAJPDEK * 132f);
			num2 = Mathf.Clamp(num2, 0, 191);
			ParticleSystem.EmissionModule emission = this.rainCircles.emission;
			ParticleSystem.MinMaxCurve rateOverTime = emission.rateOverTime;
			rateOverTime.constant = (float)num2;
			emission.rateOverTime = rateOverTime;
		}
		this.MKPLPAJPDEK = Mathf.Lerp(this.MKPLPAJPDEK, this.rainForce, Time.deltaTime);
		int num3 = Mathf.RoundToInt(this.MKPLPAJPDEK * 1375f);
		num3 = Mathf.Clamp(num3, 0, 128);
		ParticleSystem.EmissionModule emission2 = this.part.emission;
		ParticleSystem.MinMaxCurve rateOverTime2 = emission2.rateOverTime;
		rateOverTime2.constantMax = (float)num3;
		emission2.rateOverTime = rateOverTime2;
		float num4 = Mathf.Clamp(this.rainForce / 1288f, 904f, 1307f);
		this.rainSrc.volume = num4 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		if (num4 < 1813f)
		{
			if (this.rainSrc.isPlaying)
			{
				this.rainSrc.Stop();
				return;
			}
		}
		else if (!this.rainSrc.isPlaying)
		{
			this.rainSrc.Play();
		}
	}

	// Token: 0x060096F2 RID: 38642 RVA: 0x004357CC File Offset: 0x004339CC
	private IEnumerator GMFJOCCAKFK()
	{
		return new RainEffect.JPFIADMNBHC(1);
	}

	// Token: 0x060096F3 RID: 38643 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BMNJGPIPKLL()
	{
	}

	// Token: 0x060096F4 RID: 38644 RVA: 0x004357CC File Offset: 0x004339CC
	private IEnumerator GJCNEIIECFK()
	{
		return new RainEffect.JPFIADMNBHC(1);
	}

	// Token: 0x040013BC RID: 5052
	public float rainForce;

	// Token: 0x040013BD RID: 5053
	public ParticleSystem part;

	// Token: 0x040013BE RID: 5054
	public ParticleSystem rainCircles;

	// Token: 0x040013BF RID: 5055
	public AudioSource rainSrc;

	// Token: 0x040013C0 RID: 5056
	private float MKPLPAJPDEK;
}
