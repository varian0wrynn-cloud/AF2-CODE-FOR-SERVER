using System;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
	// Token: 0x020003B2 RID: 946
	public class TargetFieldOfView : AbstractTargetFollower
	{
		// Token: 0x0600CCAC RID: 52396 RVA: 0x005C24BD File Offset: 0x005C06BD
		protected virtual void OBJCOJEHLBE()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.NLOGLMIOKNN(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCAD RID: 52397 RVA: 0x005C24E8 File Offset: 0x005C06E8
		protected virtual void PNJHMJNFPLP()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.KAGEEBIADBJ(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCAE RID: 52398 RVA: 0x005C2513 File Offset: 0x005C0713
		protected virtual void FGJCIEDDFGN()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.NOMKENBOKNF(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCAF RID: 52399 RVA: 0x005C253E File Offset: 0x005C073E
		protected virtual void IMABGALEMBI()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.FBCCGHJAMIB(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCB0 RID: 52400 RVA: 0x005C256C File Offset: 0x005C076C
		protected virtual void JFFMHFKNLFH(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 461f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCB1 RID: 52401 RVA: 0x005C25E0 File Offset: 0x005C07E0
		public static float KADBKLHKPOD(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			float[] array2 = new float[0];
			array2[1] = bounds.extents.x;
			array2[0] = bounds.extents.y;
			array2[4] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCB2 RID: 52402 RVA: 0x005C2648 File Offset: 0x005C0848
		public static float DKNCGAMNIPO(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[]
			{
				0f,
				bounds.extents.x
			};
			array2[1] = bounds.extents.y;
			array2[0] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCB3 RID: 52403 RVA: 0x005C26B0 File Offset: 0x005C08B0
		public static float KAGEEBIADBJ(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[]
			{
				0f,
				bounds.extents.x
			};
			array2[0] = bounds.extents.y;
			array2[8] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCB4 RID: 52404 RVA: 0x005C24E8 File Offset: 0x005C06E8
		protected virtual void IIKDDILLGLF()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.KAGEEBIADBJ(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCB5 RID: 52405 RVA: 0x005C2716 File Offset: 0x005C0916
		protected virtual void CPNOBMNKPNC()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.DKNCGAMNIPO(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x005C2744 File Offset: 0x005C0944
		protected virtual void KFNLMJJFBDJ(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 831f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCB7 RID: 52407 RVA: 0x005C27B8 File Offset: 0x005C09B8
		public static float CDIKCIBBHMK(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[]
			{
				bounds.extents.x
			};
			array2[0] = bounds.extents.y;
			array2[0] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCB8 RID: 52408 RVA: 0x005C281E File Offset: 0x005C0A1E
		protected virtual void IAAOGAPJDID()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.FFCIPECLHBI(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCB9 RID: 52409 RVA: 0x005C2849 File Offset: 0x005C0A49
		protected virtual void HDFCIACDDEK()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.KADBKLHKPOD(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCBA RID: 52410 RVA: 0x005C2874 File Offset: 0x005C0A74
		public virtual void JJGMBMLKBNF(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.NLFNOELBEOD(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCBB RID: 52411 RVA: 0x005C2890 File Offset: 0x005C0A90
		protected virtual void HIPIBFHHFIH(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 339f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCBC RID: 52412 RVA: 0x005C2903 File Offset: 0x005C0B03
		public virtual void OGNALPBANIJ(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.FBCCGHJAMIB(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCBD RID: 52413 RVA: 0x005C291E File Offset: 0x005C0B1E
		protected override void Start()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.MaxBoundsExtent(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCBE RID: 52414 RVA: 0x005C294C File Offset: 0x005C0B4C
		public static float FFCIPECLHBI(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			float[] array2 = new float[4];
			array2[1] = bounds.extents.x;
			array2[0] = bounds.extents.y;
			array2[7] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCBF RID: 52415 RVA: 0x005C29B4 File Offset: 0x005C0BB4
		protected virtual void IAANLELAAKP(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 43f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x005C2A28 File Offset: 0x005C0C28
		protected virtual void IEGBHBKFCOM(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 970f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x005C2A9C File Offset: 0x005C0C9C
		protected virtual void MKJJKGGFIDP(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 211f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCC2 RID: 52418 RVA: 0x005C2B0F File Offset: 0x005C0D0F
		public virtual void KIAIAELKEND(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.EFAFMNMMEPG(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCC4 RID: 52420 RVA: 0x005C2B48 File Offset: 0x005C0D48
		public static float JNHNEGHIKBN(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[0];
			array2[1] = bounds.extents.x;
			array2[0] = bounds.extents.y;
			array2[0] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCC5 RID: 52421 RVA: 0x005C2BB0 File Offset: 0x005C0DB0
		protected virtual void CHPGNJEEGOC(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 11f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCC6 RID: 52422 RVA: 0x005C2C24 File Offset: 0x005C0E24
		public static float HCFFHNEEKDK(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			float[] array2 = new float[6];
			array2[0] = bounds.extents.x;
			array2[0] = bounds.extents.y;
			array2[7] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCC7 RID: 52423 RVA: 0x005C2C8C File Offset: 0x005C0E8C
		public static float FKNPMNDEINL(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			float[] array2 = new float[5];
			array2[1] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[5] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCC8 RID: 52424 RVA: 0x005C2CF4 File Offset: 0x005C0EF4
		public static float OPOGGMPBCHF(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[1];
			array2[0] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[3] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCC9 RID: 52425 RVA: 0x005C2D5C File Offset: 0x005C0F5C
		protected virtual void EMBFHJFCOAF(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 380f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCCA RID: 52426 RVA: 0x005C2DCF File Offset: 0x005C0FCF
		public virtual void ELLLJBEDJDL(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.GCBNIKCALAF(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCCB RID: 52427 RVA: 0x005C2DEC File Offset: 0x005C0FEC
		public static float KBGNDHNBGKJ(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[1];
			array2[1] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[5] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCCC RID: 52428 RVA: 0x005C2E54 File Offset: 0x005C1054
		protected virtual void BFDJDKHIDLO(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 1643f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCCD RID: 52429 RVA: 0x005C2EC8 File Offset: 0x005C10C8
		public static float NLFNOELBEOD(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			return Mathf.Max(new float[]
			{
				bounds.extents.x,
				bounds.extents.y,
				0f,
				0f,
				bounds.extents.z
			});
		}

		// Token: 0x0600CCCE RID: 52430 RVA: 0x005C2F30 File Offset: 0x005C1130
		protected virtual void JFLDEFDICKI(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 1242f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCCF RID: 52431 RVA: 0x005C2FA3 File Offset: 0x005C11A3
		public virtual void PLOBOGHJCBM(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.JBGNCLPDBMO(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCD0 RID: 52432 RVA: 0x005C2FC0 File Offset: 0x005C11C0
		public static float MaxBoundsExtent(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			return Mathf.Max(new float[]
			{
				bounds.extents.x,
				bounds.extents.y,
				bounds.extents.z
			});
		}

		// Token: 0x0600CCD1 RID: 52433 RVA: 0x005C3028 File Offset: 0x005C1228
		public static float HAKNGOCDOKM(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[6];
			array2[1] = bounds.extents.x;
			array2[0] = bounds.extents.y;
			array2[8] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCD2 RID: 52434 RVA: 0x005C3090 File Offset: 0x005C1290
		protected virtual void BGNACIJEBON(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 4f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCD3 RID: 52435 RVA: 0x005C3103 File Offset: 0x005C1303
		protected virtual void CGMHGDEKDEP()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.JNHNEGHIKBN(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCD4 RID: 52436 RVA: 0x005C312E File Offset: 0x005C132E
		protected virtual void FPLHODJCJDO()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.GCBNIKCALAF(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCD5 RID: 52437 RVA: 0x005C315C File Offset: 0x005C135C
		public static float EFAFMNMMEPG(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[1];
			array2[0] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[6] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCD6 RID: 52438 RVA: 0x005C31C4 File Offset: 0x005C13C4
		protected virtual void APDONJBOLOG(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 1750f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCD7 RID: 52439 RVA: 0x005C3237 File Offset: 0x005C1437
		protected virtual void FJGIBCHABIG()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.FKNPMNDEINL(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCD8 RID: 52440 RVA: 0x005C3264 File Offset: 0x005C1464
		protected virtual void CNKBLOGMGMO(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 1837f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCD9 RID: 52441 RVA: 0x005C32D7 File Offset: 0x005C14D7
		protected virtual void GDIMBBBPIHI()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.OPOGGMPBCHF(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCDA RID: 52442 RVA: 0x005C3302 File Offset: 0x005C1502
		public virtual void HBGMLNNHBOK(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.FKNPMNDEINL(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x005C3320 File Offset: 0x005C1520
		protected virtual void EAEHBBPJAJP(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 727f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCDC RID: 52444 RVA: 0x005C3394 File Offset: 0x005C1594
		public static float JBGNCLPDBMO(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			float[] array2 = new float[0];
			array2[1] = bounds.extents.x;
			array2[0] = bounds.extents.y;
			array2[4] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCDD RID: 52445 RVA: 0x005C33FC File Offset: 0x005C15FC
		public static float GCBNIKCALAF(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[0];
			array2[1] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[0] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCDE RID: 52446 RVA: 0x005C3464 File Offset: 0x005C1664
		public static float NOMKENBOKNF(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			float[] array2 = new float[8];
			array2[0] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[0] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCDF RID: 52447 RVA: 0x005C34CA File Offset: 0x005C16CA
		public virtual void KBANKFGAFOB(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.NOMKENBOKNF(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCE0 RID: 52448 RVA: 0x005C34E8 File Offset: 0x005C16E8
		protected virtual void LMOGGCEDOJN(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 575f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCE1 RID: 52449 RVA: 0x005C355B File Offset: 0x005C175B
		protected virtual void KJJNMNKPNCH()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.HCFFHNEEKDK(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCE2 RID: 52450 RVA: 0x005C3586 File Offset: 0x005C1786
		protected virtual void IJOCHELLKJH()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.DAKKEEKEKBI(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x005C35B4 File Offset: 0x005C17B4
		protected virtual void AHMDIINPJKD(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 490f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x005C355B File Offset: 0x005C175B
		protected virtual void AIFIEAGFIMM()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.HCFFHNEEKDK(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x005C3628 File Offset: 0x005C1828
		public static float LAECFPILCLM(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[5];
			array2[0] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[1] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x005C3690 File Offset: 0x005C1890
		protected override void IJLMPHHOJIH(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 57.29578f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x005C3704 File Offset: 0x005C1904
		protected virtual void OOPNPDBDNLJ(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 1171f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCE8 RID: 52456 RVA: 0x005C3778 File Offset: 0x005C1978
		protected virtual void FMADKNDMOGB(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 995f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x005C37EC File Offset: 0x005C19EC
		public static float NLOGLMIOKNN(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			float[] array2 = new float[]
			{
				0f,
				bounds.extents.x
			};
			array2[1] = bounds.extents.y;
			array2[2] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCEA RID: 52458 RVA: 0x005C3852 File Offset: 0x005C1A52
		protected virtual void KFGKKLAKFGH()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.NLFNOELBEOD(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCEB RID: 52459 RVA: 0x005C3880 File Offset: 0x005C1A80
		protected virtual void NGHOHEIHFNE(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 1850f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCEC RID: 52460 RVA: 0x005C38F4 File Offset: 0x005C1AF4
		public static float DAKKEEKEKBI(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[3];
			array2[1] = bounds.extents.x;
			array2[0] = bounds.extents.y;
			array2[5] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCED RID: 52461 RVA: 0x005C2716 File Offset: 0x005C0916
		protected virtual void FEBIICIMLHA()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.DKNCGAMNIPO(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCEE RID: 52462 RVA: 0x005C3237 File Offset: 0x005C1437
		protected virtual void EFCCCKGCOCB()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.FKNPMNDEINL(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCEF RID: 52463 RVA: 0x005C395A File Offset: 0x005C1B5A
		protected virtual void LHHKDNILMDI()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.OFBMKIBNLDI(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x005C3103 File Offset: 0x005C1303
		protected virtual void AOCDDBNBADJ()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.JNHNEGHIKBN(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x005C3988 File Offset: 0x005C1B88
		protected virtual void PLGOJCGELOK(float ENLHBNBNPJN)
		{
			float magnitude = (this.m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(this.GADGNFHBEGH, magnitude) * 1556f * this.m_ZoomAmountMultiplier;
			this.JGKJBAJLKLI.fieldOfView = Mathf.SmoothDamp(this.JGKJBAJLKLI.fieldOfView, target, ref this.EDMDNNIFIHM, this.m_FovAdjustTime);
		}

		// Token: 0x0600CCF2 RID: 52466 RVA: 0x005C39FB File Offset: 0x005C1BFB
		protected virtual void MMACLBBMDLA()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.HAKNGOCDOKM(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCF3 RID: 52467 RVA: 0x005C3103 File Offset: 0x005C1303
		protected virtual void DNLFEOECBKI()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.JNHNEGHIKBN(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCF4 RID: 52468 RVA: 0x005C395A File Offset: 0x005C1B5A
		protected virtual void KIEIPFFEDHC()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.OFBMKIBNLDI(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCF5 RID: 52469 RVA: 0x005C3A26 File Offset: 0x005C1C26
		protected virtual void KKCFKEDABLB()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.IPBCPJBAANF(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCF6 RID: 52470 RVA: 0x005C3A51 File Offset: 0x005C1C51
		protected virtual void ELADFDNPOOI()
		{
			base.Start();
			this.GADGNFHBEGH = TargetFieldOfView.JBGNCLPDBMO(this.m_Target, this.m_IncludeEffectsInSize);
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>();
		}

		// Token: 0x0600CCF7 RID: 52471 RVA: 0x005C3A7C File Offset: 0x005C1C7C
		public override void SetTarget(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.MaxBoundsExtent(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCF8 RID: 52472 RVA: 0x005C3A98 File Offset: 0x005C1C98
		public static float IPBCPJBAANF(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[4];
			array2[1] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[7] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCF9 RID: 52473 RVA: 0x005C3AFE File Offset: 0x005C1CFE
		public virtual void LAPHFDBCHCI(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.HAKNGOCDOKM(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x005C3B1C File Offset: 0x005C1D1C
		public static float OFBMKIBNLDI(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			foreach (Renderer renderer in componentsInChildren)
			{
			}
			float[] array2 = new float[0];
			array2[1] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[7] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x005C3B84 File Offset: 0x005C1D84
		public static float LPDPDNLNEDD(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[8];
			array2[0] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[0] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x0600CCFC RID: 52476 RVA: 0x005C3BEA File Offset: 0x005C1DEA
		public virtual void ICLFOBKELND(Transform BDDKPGKJACO)
		{
			base.SetTarget(BDDKPGKJACO);
			this.GADGNFHBEGH = TargetFieldOfView.OFBMKIBNLDI(BDDKPGKJACO, this.m_IncludeEffectsInSize);
		}

		// Token: 0x0600CCFD RID: 52477 RVA: 0x005C3C08 File Offset: 0x005C1E08
		public static float FBCCGHJAMIB(Transform MBKPMBPLIJN, bool KMHOCGKDBLA)
		{
			Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			Renderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
			}
			float[] array2 = new float[4];
			array2[0] = bounds.extents.x;
			array2[1] = bounds.extents.y;
			array2[2] = bounds.extents.z;
			return Mathf.Max(array2);
		}

		// Token: 0x04001B27 RID: 6951
		[SerializeField]
		private float m_FovAdjustTime = 1f;

		// Token: 0x04001B28 RID: 6952
		[SerializeField]
		private float m_ZoomAmountMultiplier = 2f;

		// Token: 0x04001B29 RID: 6953
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		// Token: 0x04001B2A RID: 6954
		private float GADGNFHBEGH;

		// Token: 0x04001B2B RID: 6955
		private float EDMDNNIFIHM;

		// Token: 0x04001B2C RID: 6956
		private Camera JGKJBAJLKLI;

		// Token: 0x04001B2D RID: 6957
		private Transform KALFMILLLIN;
	}
}
