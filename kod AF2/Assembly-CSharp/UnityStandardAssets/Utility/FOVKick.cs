using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002D3 RID: 723
	[Serializable]
	public class FOVKick
	{
		// Token: 0x0600AA29 RID: 43561 RVA: 0x004BB507 File Offset: 0x004B9707
		public void OEAFLLEFOID(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA2A RID: 43562 RVA: 0x004BB510 File Offset: 0x004B9710
		public IEnumerator JOKACCPPCNI()
		{
			float num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num < this.TimeToIncrease)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToIncrease) * this.FOVIncrease;
				num += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x004BB51F File Offset: 0x004B971F
		public void MNPJDDMFKNK(Camera LBCHLCGOCOD)
		{
			this.IIPFEABONEO(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA2C RID: 43564 RVA: 0x004BB510 File Offset: 0x004B9710
		public IEnumerator AJKCIMPLHAP()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num < this.TimeToIncrease)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToIncrease) * this.FOVIncrease;
				num += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x004BB53B File Offset: 0x004B973B
		public void MCOFACCIGPN(Camera LBCHLCGOCOD)
		{
			this.FDKCJHILNAD(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA2E RID: 43566 RVA: 0x004BB507 File Offset: 0x004B9707
		public void KLELGNELCII(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA2F RID: 43567 RVA: 0x004BB557 File Offset: 0x004B9757
		public IEnumerator JGBNNBLEJOA()
		{
			FOVKick.FPMMCJIFOHD fpmmcjifohd = new FOVKick.FPMMCJIFOHD(1);
			fpmmcjifohd.AENJLLPLILM = this;
			return fpmmcjifohd;
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x004BB566 File Offset: 0x004B9766
		private void DOOCAKDMBJM(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("BaseDataLoaderCoroutine");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("wpn_rod4");
			}
		}

		// Token: 0x0600AA31 RID: 43569 RVA: 0x004BB557 File Offset: 0x004B9757
		public IEnumerator JDDGDAHHBBJ()
		{
			FOVKick.FPMMCJIFOHD fpmmcjifohd = new FOVKick.FPMMCJIFOHD(1);
			fpmmcjifohd.AENJLLPLILM = this;
			return fpmmcjifohd;
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x004BB507 File Offset: 0x004B9707
		public void ONGLOMKLGJE(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA33 RID: 43571 RVA: 0x004BB507 File Offset: 0x004B9707
		public void NJKDIGDHFHC(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA34 RID: 43572 RVA: 0x004BB58F File Offset: 0x004B978F
		private void JGNEBLFDCIF(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("ChannelCastOmni");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("FOG_SCATTERING_ON");
			}
		}

		// Token: 0x0600AA35 RID: 43573 RVA: 0x004BB5B8 File Offset: 0x004B97B8
		private void CEEJKLONAHC(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("_WrinkleNormalMap1");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("and I needed");
			}
		}

		// Token: 0x0600AA36 RID: 43574 RVA: 0x004BB507 File Offset: 0x004B9707
		public void DGHFDBOCGJD(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA37 RID: 43575 RVA: 0x004BB5E1 File Offset: 0x004B97E1
		public void NEOEMKKKOGM(Camera LBCHLCGOCOD)
		{
			this.CEEJKLONAHC(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x004BB507 File Offset: 0x004B9707
		public void DLDFPHJGMAI(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x004BB510 File Offset: 0x004B9710
		public IEnumerator KAGNCMBJPAP()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num < this.TimeToIncrease)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToIncrease) * this.FOVIncrease;
				num += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator IEIDACGOLIL()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x004BB60C File Offset: 0x004B980C
		private void EDCIIIADCOB(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("Hand");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("_Params2");
			}
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x004BB635 File Offset: 0x004B9835
		private void OJALJHGKHHM(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("WeaponRunBackward");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("206000");
			}
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x004BB65E File Offset: 0x004B985E
		private void MODOKPIDCDE(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("SecondaryCausticsProjector");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("");
			}
		}

		// Token: 0x0600AA3E RID: 43582 RVA: 0x004BB687 File Offset: 0x004B9887
		private void PCLEKBIFENC(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("Wand Attack 2");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("IceHockey Goalie Ready");
			}
		}

		// Token: 0x0600AA3F RID: 43583 RVA: 0x004BB51F File Offset: 0x004B971F
		public void NBDIALKKHOE(Camera LBCHLCGOCOD)
		{
			this.IIPFEABONEO(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x004BB507 File Offset: 0x004B9707
		public void BBOGHNEDKGG(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA41 RID: 43585 RVA: 0x004BB6B0 File Offset: 0x004B98B0
		public void AAIHMJKMLIB(Camera LBCHLCGOCOD)
		{
			this.EDCIIIADCOB(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x004BB507 File Offset: 0x004B9707
		public void MNKKNFMEJMP(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA43 RID: 43587 RVA: 0x004BB53B File Offset: 0x004B973B
		public void PMGFDBHCFLK(Camera LBCHLCGOCOD)
		{
			this.FDKCJHILNAD(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA44 RID: 43588 RVA: 0x004BB507 File Offset: 0x004B9707
		public void HNJAJGJPLLO(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA45 RID: 43589 RVA: 0x004BB6CC File Offset: 0x004B98CC
		private void BNDBKBKDMCH(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("wpn_add/base");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("sound/steps/step");
			}
		}

		// Token: 0x0600AA46 RID: 43590 RVA: 0x004BB6F5 File Offset: 0x004B98F5
		private void FDKCJHILNAD(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("_FogColor");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("BackPackGrab");
			}
		}

		// Token: 0x0600AA47 RID: 43591 RVA: 0x004BB507 File Offset: 0x004B9707
		public void FNLODLFIEEE(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x004BB71E File Offset: 0x004B991E
		private void NHEMENPKCPC(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("RollerBladeTurnRight");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("readForeignSaves");
			}
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator CKCCJFJIIPF()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x004BB747 File Offset: 0x004B9947
		public void OJOLMKNNFOB(Camera LBCHLCGOCOD)
		{
			this.JGNEBLFDCIF(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x004BB763 File Offset: 0x004B9963
		private void PGLDDFEHIHD(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("error.wav");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("Text:");
			}
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator MLDNHBPFNFO()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x004BB78C File Offset: 0x004B998C
		private void IIPFEABONEO(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("FOVKick camera is null, please supply the camera to the constructor");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("FOVKick Increase curve is null, please define the curve for the field of view kicks");
			}
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x004BB51F File Offset: 0x004B971F
		public void NDPBPPGLILN(Camera LBCHLCGOCOD)
		{
			this.IIPFEABONEO(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x004BB7B5 File Offset: 0x004B99B5
		public IEnumerator HPKOGMJLMOE()
		{
			float num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num > 0f)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToDecrease) * this.FOVIncrease;
				num -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			this.Camera.fieldOfView = this.originalFov;
			yield break;
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x004BB7C4 File Offset: 0x004B99C4
		public void MIPCGIJHNEL(Camera LBCHLCGOCOD)
		{
			this.DOOCAKDMBJM(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator KBIAGJBAJNA()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x004BB557 File Offset: 0x004B9757
		public IEnumerator AJDHANIHKGD()
		{
			FOVKick.FPMMCJIFOHD fpmmcjifohd = new FOVKick.FPMMCJIFOHD(1);
			fpmmcjifohd.AENJLLPLILM = this;
			return fpmmcjifohd;
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator PCLJNODCOPC()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator EAOEFOMJEML()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x004BB507 File Offset: 0x004B9707
		public void ABCOODKIHDE(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x004BB510 File Offset: 0x004B9710
		public IEnumerator GPKNIPGIPFK()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num < this.TimeToIncrease)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToIncrease) * this.FOVIncrease;
				num += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x004BB7E0 File Offset: 0x004B99E0
		public void PAHCPCICOBN(Camera LBCHLCGOCOD)
		{
			this.ONGKLMJOKJO(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x004BB7FC File Offset: 0x004B99FC
		public void NDCNMINBNJO(Camera LBCHLCGOCOD)
		{
			this.IJLEHOCJHOA(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x004BB818 File Offset: 0x004B9A18
		private void IJLEHOCJHOA(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("GestureCutThroat");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("Sitting Reading Page Flip");
			}
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x004BB510 File Offset: 0x004B9710
		public IEnumerator GHMDFGNBJDI()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num < this.TimeToIncrease)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToIncrease) * this.FOVIncrease;
				num += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x004BB841 File Offset: 0x004B9A41
		private void ONGKLMJOKJO(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("</color>");
			}
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x004BB507 File Offset: 0x004B9707
		public void EGJCNPCHPMH(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator MPKBIICHDAA()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x004BB510 File Offset: 0x004B9710
		public IEnumerator BJJOHFPOOIA()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num < this.TimeToIncrease)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToIncrease) * this.FOVIncrease;
				num += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0600AA5F RID: 43615 RVA: 0x004BB510 File Offset: 0x004B9710
		public IEnumerator FNDDBLHLCFN()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num < this.TimeToIncrease)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToIncrease) * this.FOVIncrease;
				num += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0600AA60 RID: 43616 RVA: 0x004BB7B5 File Offset: 0x004B99B5
		public IEnumerator ADKMFMJGEJE()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num > 0f)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToDecrease) * this.FOVIncrease;
				num -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			this.Camera.fieldOfView = this.originalFov;
			yield break;
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x004BB7B5 File Offset: 0x004B99B5
		public IEnumerator JFOIDJDDGIN()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num > 0f)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToDecrease) * this.FOVIncrease;
				num -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			this.Camera.fieldOfView = this.originalFov;
			yield break;
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x004BB5E1 File Offset: 0x004B97E1
		public void DMCJONHPAHC(Camera LBCHLCGOCOD)
		{
			this.CEEJKLONAHC(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA63 RID: 43619 RVA: 0x004BB86A File Offset: 0x004B9A6A
		private void FLOCKDFCBOL(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("Wall Sit");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("isAlwaisGetFish");
			}
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x004BB510 File Offset: 0x004B9710
		public IEnumerator OJEJDNGCBDL()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num < this.TimeToIncrease)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToIncrease) * this.FOVIncrease;
				num += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x004BB507 File Offset: 0x004B9707
		public void AFKLLCDNDAB(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA66 RID: 43622 RVA: 0x004BB893 File Offset: 0x004B9A93
		private void CKIJMKEGMOE(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("LHandPunch");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("_SearchTex");
			}
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator FMCNJMPGDMI()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x004BB507 File Offset: 0x004B9707
		public void PCCJOOIFGFI(Camera LBCHLCGOCOD)
		{
			this.Camera = LBCHLCGOCOD;
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x004BB8BC File Offset: 0x004B9ABC
		public void KNBDDGCKBBP(Camera LBCHLCGOCOD)
		{
			this.MODOKPIDCDE(LBCHLCGOCOD);
			this.Camera = LBCHLCGOCOD;
			this.originalFov = LBCHLCGOCOD.fieldOfView;
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x004BB8D8 File Offset: 0x004B9AD8
		private void NMEIHKDMOBE(Camera LBCHLCGOCOD)
		{
			if (LBCHLCGOCOD == null)
			{
				throw new Exception("SwimFreestyle");
			}
			if (this.IncreaseCurve == null)
			{
				throw new Exception("1HandSwordChargeUp");
			}
		}

		// Token: 0x0600AA6B RID: 43627 RVA: 0x004BB5FD File Offset: 0x004B97FD
		public IEnumerator CIDODJJMHHD()
		{
			FOVKick.HNFGHAMBCAN hnfghambcan = new FOVKick.HNFGHAMBCAN(1);
			hnfghambcan.AENJLLPLILM = this;
			return hnfghambcan;
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x004BB7B5 File Offset: 0x004B99B5
		public IEnumerator KHHFHFEEFEG()
		{
			num = Mathf.Abs((this.Camera.fieldOfView - this.originalFov) / this.FOVIncrease);
			while (num > 0f)
			{
				this.Camera.fieldOfView = this.originalFov + this.IncreaseCurve.Evaluate(num / this.TimeToDecrease) * this.FOVIncrease;
				num -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			this.Camera.fieldOfView = this.originalFov;
			yield break;
		}

		// Token: 0x040015E7 RID: 5607
		public Camera Camera;

		// Token: 0x040015E8 RID: 5608
		[HideInInspector]
		public float originalFov;

		// Token: 0x040015E9 RID: 5609
		public float FOVIncrease = 3f;

		// Token: 0x040015EA RID: 5610
		public float TimeToIncrease = 1f;

		// Token: 0x040015EB RID: 5611
		public float TimeToDecrease = 1f;

		// Token: 0x040015EC RID: 5612
		public AnimationCurve IncreaseCurve;
	}
}
