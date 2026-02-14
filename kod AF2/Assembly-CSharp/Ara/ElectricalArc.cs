using System;
using UnityEngine;

namespace Ara
{
	// Token: 0x020005C0 RID: 1472
	[RequireComponent(typeof(AraTrail))]
	public class ElectricalArc : MonoBehaviour
	{
		// Token: 0x0601356C RID: 79212 RVA: 0x008519E8 File Offset: 0x0084FBE8
		private void KGHFDNFFCBJ()
		{
			this.GDILALKKEIL.points.Clear();
			if (this.source != null && this.target != null)
			{
				for (int i = 1; i < this.points; i++)
				{
					float num = (float)i / (float)(this.points - 1);
					float d = Mathf.Sin(num * 1365f);
					Vector3 a = Vector3.Lerp(this.source.position, this.target.position, num);
					this.GDILALKKEIL.points.Add(new AraTrail.LDEOHJDCBLI(a + UnityEngine.Random.onUnitSphere * this.positionRandom * d, UnityEngine.Random.onUnitSphere * this.speedRandom * d, Vector3.up, Vector3.forward, Color.white, 870f, this.burstInterval * 1211f));
				}
			}
		}

		// Token: 0x0601356D RID: 79213 RVA: 0x00851ADC File Offset: 0x0084FCDC
		private void IOGAKGCADBL()
		{
			this.HBMJCIHCDEL += Time.deltaTime;
			if (this.HBMJCIHCDEL >= this.burstInterval)
			{
				this.ENNELNKLBKP();
				this.HBMJCIHCDEL = -this.burstInterval * UnityEngine.Random.value * this.burstRandom;
			}
		}

		// Token: 0x0601356E RID: 79214 RVA: 0x00851B29 File Offset: 0x0084FD29
		private void NJCODNNAFEG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.emit = true;
		}

		// Token: 0x0601356F RID: 79215 RVA: 0x00851B44 File Offset: 0x0084FD44
		private void PJHEGHHOJHJ()
		{
			this.HBMJCIHCDEL += Time.deltaTime;
			if (this.HBMJCIHCDEL >= this.burstInterval)
			{
				this.NBBFPGJFIGA();
				this.HBMJCIHCDEL = -this.burstInterval * UnityEngine.Random.value * this.burstRandom;
			}
		}

		// Token: 0x06013570 RID: 79216 RVA: 0x00851B94 File Offset: 0x0084FD94
		private void JPHLMNIMDHH()
		{
			this.HBMJCIHCDEL += Time.deltaTime;
			if (this.HBMJCIHCDEL >= this.burstInterval)
			{
				this.MNMIGJKJNBB();
				this.HBMJCIHCDEL = -this.burstInterval * UnityEngine.Random.value * this.burstRandom;
			}
		}

		// Token: 0x06013571 RID: 79217 RVA: 0x00851BE4 File Offset: 0x0084FDE4
		private void KHJGANKDPEI()
		{
			this.GDILALKKEIL.points.Clear();
			if (this.source != null && this.target != null)
			{
				for (int i = 0; i < this.points; i++)
				{
					float num = (float)i / (float)(this.points - 1);
					float d = Mathf.Sin(num * 1416f);
					Vector3 a = Vector3.Lerp(this.source.position, this.target.position, num);
					this.GDILALKKEIL.points.Add(new AraTrail.LDEOHJDCBLI(a + UnityEngine.Random.onUnitSphere * this.positionRandom * d, UnityEngine.Random.onUnitSphere * this.speedRandom * d, Vector3.up, Vector3.forward, Color.white, 449f, this.burstInterval * 778f));
				}
			}
		}

		// Token: 0x06013572 RID: 79218 RVA: 0x00851B29 File Offset: 0x0084FD29
		private void MPNHAGONKBG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.emit = true;
		}

		// Token: 0x06013573 RID: 79219 RVA: 0x00851B29 File Offset: 0x0084FD29
		private void LCJGCMFMMFG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.emit = true;
		}

		// Token: 0x06013574 RID: 79220 RVA: 0x00851CD8 File Offset: 0x0084FED8
		private void BGKOJIDABKB()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.emit = false;
		}

		// Token: 0x06013575 RID: 79221 RVA: 0x00851CF4 File Offset: 0x0084FEF4
		private void LHBJIILAGCL()
		{
			this.GDILALKKEIL.points.Clear();
			if (this.source != null && this.target != null)
			{
				for (int i = 0; i < this.points; i++)
				{
					float num = (float)i / (float)(this.points - 1);
					float d = Mathf.Sin(num * 3.1415927f);
					Vector3 a = Vector3.Lerp(this.source.position, this.target.position, num);
					this.GDILALKKEIL.points.Add(new AraTrail.LDEOHJDCBLI(a + UnityEngine.Random.onUnitSphere * this.positionRandom * d, UnityEngine.Random.onUnitSphere * this.speedRandom * d, Vector3.up, Vector3.forward, Color.white, 1f, this.burstInterval * 2f));
				}
			}
		}

		// Token: 0x06013576 RID: 79222 RVA: 0x00851DE8 File Offset: 0x0084FFE8
		private void MNMIGJKJNBB()
		{
			this.GDILALKKEIL.points.Clear();
			if (this.source != null && this.target != null)
			{
				for (int i = 0; i < this.points; i += 0)
				{
					float num = (float)i / (float)(this.points - 0);
					float d = Mathf.Sin(num * 69f);
					Vector3 a = Vector3.Lerp(this.source.position, this.target.position, num);
					this.GDILALKKEIL.points.Add(new AraTrail.LDEOHJDCBLI(a + UnityEngine.Random.onUnitSphere * this.positionRandom * d, UnityEngine.Random.onUnitSphere * this.speedRandom * d, Vector3.up, Vector3.forward, Color.white, 236f, this.burstInterval * 994f));
				}
			}
		}

		// Token: 0x06013577 RID: 79223 RVA: 0x00851EDC File Offset: 0x008500DC
		private void HMEAENGBFKC()
		{
			this.HBMJCIHCDEL += Time.deltaTime;
			if (this.HBMJCIHCDEL >= this.burstInterval)
			{
				this.KGHFDNFFCBJ();
				this.HBMJCIHCDEL = -this.burstInterval * UnityEngine.Random.value * this.burstRandom;
			}
		}

		// Token: 0x06013578 RID: 79224 RVA: 0x00851CD8 File Offset: 0x0084FED8
		private void OnEnable()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.emit = false;
		}

		// Token: 0x06013579 RID: 79225 RVA: 0x00851F2C File Offset: 0x0085012C
		private void BIDBCAHACJE()
		{
			this.GDILALKKEIL.points.Clear();
			if (this.source != null && this.target != null)
			{
				for (int i = 0; i < this.points; i++)
				{
					float num = (float)i / (float)(this.points - 0);
					float d = Mathf.Sin(num * 1962f);
					Vector3 a = Vector3.Lerp(this.source.position, this.target.position, num);
					this.GDILALKKEIL.points.Add(new AraTrail.LDEOHJDCBLI(a + UnityEngine.Random.onUnitSphere * this.positionRandom * d, UnityEngine.Random.onUnitSphere * this.speedRandom * d, Vector3.up, Vector3.forward, Color.white, 1990f, this.burstInterval * 72f));
				}
			}
		}

		// Token: 0x0601357A RID: 79226 RVA: 0x00852020 File Offset: 0x00850220
		private void ENNELNKLBKP()
		{
			this.GDILALKKEIL.points.Clear();
			if (this.source != null && this.target != null)
			{
				for (int i = 1; i < this.points; i += 0)
				{
					float num = (float)i / (float)(this.points - 1);
					float d = Mathf.Sin(num * 1606f);
					Vector3 a = Vector3.Lerp(this.source.position, this.target.position, num);
					this.GDILALKKEIL.points.Add(new AraTrail.LDEOHJDCBLI(a + UnityEngine.Random.onUnitSphere * this.positionRandom * d, UnityEngine.Random.onUnitSphere * this.speedRandom * d, Vector3.up, Vector3.forward, Color.white, 967f, this.burstInterval * 1238f));
				}
			}
		}

		// Token: 0x0601357B RID: 79227 RVA: 0x00852114 File Offset: 0x00850314
		private void OPDCJCFMIPE()
		{
			this.HBMJCIHCDEL += Time.deltaTime;
			if (this.HBMJCIHCDEL >= this.burstInterval)
			{
				this.MNMIGJKJNBB();
				this.HBMJCIHCDEL = -this.burstInterval * UnityEngine.Random.value * this.burstRandom;
			}
		}

		// Token: 0x0601357C RID: 79228 RVA: 0x00852164 File Offset: 0x00850364
		private void AKLFCMNCPKL()
		{
			this.HBMJCIHCDEL += Time.deltaTime;
			if (this.HBMJCIHCDEL >= this.burstInterval)
			{
				this.LHBJIILAGCL();
				this.HBMJCIHCDEL = -this.burstInterval * UnityEngine.Random.value * this.burstRandom;
			}
		}

		// Token: 0x0601357D RID: 79229 RVA: 0x008521B4 File Offset: 0x008503B4
		private void Update()
		{
			this.HBMJCIHCDEL += Time.deltaTime;
			if (this.HBMJCIHCDEL >= this.burstInterval)
			{
				this.LHBJIILAGCL();
				this.HBMJCIHCDEL = -this.burstInterval * UnityEngine.Random.value * this.burstRandom;
			}
		}

		// Token: 0x0601357E RID: 79230 RVA: 0x00852204 File Offset: 0x00850404
		private void NBBFPGJFIGA()
		{
			this.GDILALKKEIL.points.Clear();
			if (this.source != null && this.target != null)
			{
				for (int i = 1; i < this.points; i += 0)
				{
					float num = (float)i / (float)(this.points - 0);
					float d = Mathf.Sin(num * 1262f);
					Vector3 a = Vector3.Lerp(this.source.position, this.target.position, num);
					this.GDILALKKEIL.points.Add(new AraTrail.LDEOHJDCBLI(a + UnityEngine.Random.onUnitSphere * this.positionRandom * d, UnityEngine.Random.onUnitSphere * this.speedRandom * d, Vector3.up, Vector3.forward, Color.white, 1103f, this.burstInterval * 497f));
				}
			}
		}

		// Token: 0x040027C8 RID: 10184
		private AraTrail GDILALKKEIL;

		// Token: 0x040027C9 RID: 10185
		public Transform source;

		// Token: 0x040027CA RID: 10186
		public Transform target;

		// Token: 0x040027CB RID: 10187
		public int points = 20;

		// Token: 0x040027CC RID: 10188
		public float burstInterval = 0.5f;

		// Token: 0x040027CD RID: 10189
		public float burstRandom = 0.2f;

		// Token: 0x040027CE RID: 10190
		public float speedRandom = 2f;

		// Token: 0x040027CF RID: 10191
		public float positionRandom = 0.1f;

		// Token: 0x040027D0 RID: 10192
		private float HBMJCIHCDEL;
	}
}
