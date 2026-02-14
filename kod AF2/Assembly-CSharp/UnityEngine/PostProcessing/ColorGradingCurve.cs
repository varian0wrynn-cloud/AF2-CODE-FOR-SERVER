using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000576 RID: 1398
	[Serializable]
	public sealed class ColorGradingCurve
	{
		// Token: 0x06012438 RID: 74808 RVA: 0x00803610 File Offset: 0x00801810
		public float NLGOPKBCLEM(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012439 RID: 74809 RVA: 0x00803660 File Offset: 0x00801860
		public void OEDBHMCFDIM()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601243A RID: 74810 RVA: 0x00803710 File Offset: 0x00801910
		public float LLCOGEEGAMA(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601243B RID: 74811 RVA: 0x00803760 File Offset: 0x00801960
		public float CPMJFMKFJOO(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601243C RID: 74812 RVA: 0x008037B0 File Offset: 0x008019B0
		public void AGPNJPDFFOF()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 6)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601243D RID: 74813 RVA: 0x00803860 File Offset: 0x00801A60
		public float CPINCMBMCBJ(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601243E RID: 74814 RVA: 0x008038B0 File Offset: 0x00801AB0
		public void CHGEHCKIKIP()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 4)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601243F RID: 74815 RVA: 0x00803960 File Offset: 0x00801B60
		public float NHKEFHIAAFL(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012440 RID: 74816 RVA: 0x008039B0 File Offset: 0x00801BB0
		public float HEMDLJEHPKP(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012441 RID: 74817 RVA: 0x00803A00 File Offset: 0x00801C00
		public float ADBJINNEOFN(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012442 RID: 74818 RVA: 0x00803A50 File Offset: 0x00801C50
		public float JOMFIOOICGE(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012443 RID: 74819 RVA: 0x00803AA0 File Offset: 0x00801CA0
		public float JIIGMLNAEBG(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012444 RID: 74820 RVA: 0x00803AF0 File Offset: 0x00801CF0
		public void CDHLDIEMMBG()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 1)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012445 RID: 74821 RVA: 0x00803BA0 File Offset: 0x00801DA0
		public void LHJMEAAEPMJ()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 0)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012446 RID: 74822 RVA: 0x00803C50 File Offset: 0x00801E50
		public float KLFMDKBFILF(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012447 RID: 74823 RVA: 0x00803CA0 File Offset: 0x00801EA0
		public float LJLNAHHJDDE(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012448 RID: 74824 RVA: 0x00803CF0 File Offset: 0x00801EF0
		public float OBBIAFJHFGM(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012449 RID: 74825 RVA: 0x00803D40 File Offset: 0x00801F40
		public float CIPIGIDDNGF(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601244A RID: 74826 RVA: 0x00803D90 File Offset: 0x00801F90
		public void OIPGFANGDLC()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 4)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601244B RID: 74827 RVA: 0x00803E40 File Offset: 0x00802040
		public void ECKDCCMIIMJ()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 4)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601244C RID: 74828 RVA: 0x00803EF0 File Offset: 0x008020F0
		public float PIOBEHBJMEH(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601244D RID: 74829 RVA: 0x00803F40 File Offset: 0x00802140
		public float PFDIPJBEFAO(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601244E RID: 74830 RVA: 0x00803F90 File Offset: 0x00802190
		public float KNFAACNOAEF(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601244F RID: 74831 RVA: 0x00803FE0 File Offset: 0x008021E0
		public float ELFIIJNELLB(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012450 RID: 74832 RVA: 0x00804030 File Offset: 0x00802230
		public void OFIBLHCNMBD()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 3)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012451 RID: 74833 RVA: 0x008040E0 File Offset: 0x008022E0
		public float DBHINDKNBDN(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012452 RID: 74834 RVA: 0x00804130 File Offset: 0x00802330
		public void EMBFGOOLNHK()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 5)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012453 RID: 74835 RVA: 0x008041E0 File Offset: 0x008023E0
		public float AKNPGAELGKD(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012454 RID: 74836 RVA: 0x00804230 File Offset: 0x00802430
		public void IPILDKAIDED()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012455 RID: 74837 RVA: 0x008042E0 File Offset: 0x008024E0
		public float KJCECNDPKBG(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012456 RID: 74838 RVA: 0x00804330 File Offset: 0x00802530
		public float NMPEBODFNEL(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012457 RID: 74839 RVA: 0x00804380 File Offset: 0x00802580
		public float FCELNCLKJMH(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012458 RID: 74840 RVA: 0x008043D0 File Offset: 0x008025D0
		public float INGKEBPPAOA(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012459 RID: 74841 RVA: 0x00804420 File Offset: 0x00802620
		public void OFLGNBNPAJB()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 4)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601245A RID: 74842 RVA: 0x008044D0 File Offset: 0x008026D0
		public void LODMPFEKHMN()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 8)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601245B RID: 74843 RVA: 0x00804580 File Offset: 0x00802780
		public float MAAEIIKAMAI(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601245C RID: 74844 RVA: 0x008045D0 File Offset: 0x008027D0
		public float COHBEELLHAG(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601245D RID: 74845 RVA: 0x00804620 File Offset: 0x00802820
		public float OPEHAHFPHNK(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601245E RID: 74846 RVA: 0x00804670 File Offset: 0x00802870
		public void APMLMAJHGNF()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 5)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601245F RID: 74847 RVA: 0x00804720 File Offset: 0x00802920
		public void JLDPEPGENKC()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012460 RID: 74848 RVA: 0x008047D0 File Offset: 0x008029D0
		public void DMOLOJGADMK()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 1)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012461 RID: 74849 RVA: 0x00804880 File Offset: 0x00802A80
		public float FEGBMOMBIPK(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012462 RID: 74850 RVA: 0x008048D0 File Offset: 0x00802AD0
		public void COBCNKHEKGD()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012463 RID: 74851 RVA: 0x00804980 File Offset: 0x00802B80
		public void JPJIHGKHKFH()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 1)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012464 RID: 74852 RVA: 0x00804A30 File Offset: 0x00802C30
		public float ENOFINEJJMJ(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012465 RID: 74853 RVA: 0x00804A80 File Offset: 0x00802C80
		public void LNFOKNOOELA()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 5)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012466 RID: 74854 RVA: 0x00804B30 File Offset: 0x00802D30
		public float PJEPGKFDOHC(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012467 RID: 74855 RVA: 0x00804B80 File Offset: 0x00802D80
		public float DOJNNIDNOKL(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012468 RID: 74856 RVA: 0x00804BD0 File Offset: 0x00802DD0
		public float OJPNKGFHBKC(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012469 RID: 74857 RVA: 0x00804C20 File Offset: 0x00802E20
		public void PLAKNLNAHIJ()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 8)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601246A RID: 74858 RVA: 0x00804CD0 File Offset: 0x00802ED0
		public void NBDLKGOEPPM()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 6)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601246B RID: 74859 RVA: 0x00804D80 File Offset: 0x00802F80
		public float NALPGFCBCME(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601246C RID: 74860 RVA: 0x00804DD0 File Offset: 0x00802FD0
		public void IDOANNONNPA()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 5)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601246D RID: 74861 RVA: 0x00804E80 File Offset: 0x00803080
		public void GPCPFOMJGEP()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601246E RID: 74862 RVA: 0x00804F30 File Offset: 0x00803130
		public void KMDKNLJDHOH()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 4)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601246F RID: 74863 RVA: 0x00804FE0 File Offset: 0x008031E0
		public float LNEILCHFMHI(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012470 RID: 74864 RVA: 0x00805030 File Offset: 0x00803230
		public float GABOFIMLOIJ(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012471 RID: 74865 RVA: 0x00805080 File Offset: 0x00803280
		public void EGAODFEJEPK()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 0)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012472 RID: 74866 RVA: 0x00805130 File Offset: 0x00803330
		public void ACKEKMJLOJF()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 7)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012473 RID: 74867 RVA: 0x008051E0 File Offset: 0x008033E0
		public void DDBHAOEFDCC()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 6)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012474 RID: 74868 RVA: 0x00805290 File Offset: 0x00803490
		public float JOHFBEBFMAA(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012475 RID: 74869 RVA: 0x008052E0 File Offset: 0x008034E0
		public void BIAOGKHPJFO()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 1)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012476 RID: 74870 RVA: 0x00805390 File Offset: 0x00803590
		public float MJGAHBGIMAA(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012477 RID: 74871 RVA: 0x008053E0 File Offset: 0x008035E0
		public void CGKJLEPBOEI()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 5)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06012478 RID: 74872 RVA: 0x00805490 File Offset: 0x00803690
		public float KFJOJKDKJFN(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x06012479 RID: 74873 RVA: 0x008054E0 File Offset: 0x008036E0
		public ColorGradingCurve(AnimationCurve HAPKPCKIPJK, float HEEDONJCENL, bool FJLBPBFIBJN, Vector2 DDCAPDEHFGC)
		{
			this.curve = HAPKPCKIPJK;
			this.m_ZeroValue = HEEDONJCENL;
			this.m_Loop = FJLBPBFIBJN;
			this.m_Range = DDCAPDEHFGC.magnitude;
		}

		// Token: 0x0601247A RID: 74874 RVA: 0x0080550C File Offset: 0x0080370C
		public float IJAEACFDBMK(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601247B RID: 74875 RVA: 0x0080555C File Offset: 0x0080375C
		public float EPHOCAPNIKM(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601247C RID: 74876 RVA: 0x008055AC File Offset: 0x008037AC
		public float IFECILPFELM(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 0)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x0601247D RID: 74877 RVA: 0x008055FC File Offset: 0x008037FC
		public void ODLMCBHHNEJ()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 1)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0601247E RID: 74878 RVA: 0x008056AC File Offset: 0x008038AC
		public float DACMEEPLHBJ(float JAHNHOCNJGM)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(JAHNHOCNJGM);
			}
			return this.m_InternalLoopingCurve.Evaluate(JAHNHOCNJGM);
		}

		// Token: 0x040025D7 RID: 9687
		public AnimationCurve curve;

		// Token: 0x040025D8 RID: 9688
		[SerializeField]
		private bool m_Loop;

		// Token: 0x040025D9 RID: 9689
		[SerializeField]
		private float m_ZeroValue;

		// Token: 0x040025DA RID: 9690
		[SerializeField]
		private float m_Range;

		// Token: 0x040025DB RID: 9691
		private AnimationCurve m_InternalLoopingCurve;
	}
}
