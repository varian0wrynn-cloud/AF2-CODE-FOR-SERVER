using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200042A RID: 1066
	public class WeaponRifle : WeaponBase
	{
		// Token: 0x0600E663 RID: 58979 RVA: 0x00688FE8 File Offset: 0x006871E8
		private void KJJBBLDJHPD()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1933f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1192f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E664 RID: 58980 RVA: 0x0068904C File Offset: 0x0068724C
		private void OPDCJCFMIPE()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 156f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 717f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E665 RID: 58981 RVA: 0x006890B0 File Offset: 0x006872B0
		private void PGIHAIPCJLL()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1131f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 560f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E666 RID: 58982 RVA: 0x00689114 File Offset: 0x00687314
		private void JLFBDOPFDDJ()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1620f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 861f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E667 RID: 58983 RVA: 0x00689178 File Offset: 0x00687378
		public virtual void FBGKOMBOIPI()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 716f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(85);
		}

		// Token: 0x0600E668 RID: 58984 RVA: 0x00689228 File Offset: 0x00687428
		public override void Fire()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 10f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 0.01f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(20);
		}

		// Token: 0x0600E669 RID: 58985 RVA: 0x006892D8 File Offset: 0x006874D8
		private void JPHLMNIMDHH()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 892f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 555f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E66A RID: 58986 RVA: 0x0068933C File Offset: 0x0068753C
		private void EKCKBDKEAKO()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1533f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1796f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E66B RID: 58987 RVA: 0x006893A0 File Offset: 0x006875A0
		private void PJHEGHHOJHJ()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 719f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 196f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E66C RID: 58988 RVA: 0x00689404 File Offset: 0x00687604
		public virtual void IIFBGNJAEIC()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1251f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 934f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-93);
		}

		// Token: 0x0600E66D RID: 58989 RVA: 0x006894B4 File Offset: 0x006876B4
		public virtual void IFCHCLDEFKE()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1879f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1786f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-100);
		}

		// Token: 0x0600E66E RID: 58990 RVA: 0x00689564 File Offset: 0x00687764
		private void PMKOAHMNBBG()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1837f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1823f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E66F RID: 58991 RVA: 0x006895C8 File Offset: 0x006877C8
		public virtual void MDNJDFCMJDE()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1793f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1541f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-20);
		}

		// Token: 0x0600E670 RID: 58992 RVA: 0x00689678 File Offset: 0x00687878
		private void JOHDLNOKCOK()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1049f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1579f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E671 RID: 58993 RVA: 0x006896DC File Offset: 0x006878DC
		public virtual void GLAAFEDJCNH()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1490f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1147f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-37);
		}

		// Token: 0x0600E673 RID: 58995 RVA: 0x006897AC File Offset: 0x006879AC
		public virtual void GMJEPIFKFJM()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1742f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1526f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-8);
		}

		// Token: 0x0600E674 RID: 58996 RVA: 0x0068985C File Offset: 0x00687A5C
		public virtual void DKMNCDJENGP()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 707f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 170f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-38);
		}

		// Token: 0x0600E675 RID: 58997 RVA: 0x0068990C File Offset: 0x00687B0C
		public virtual void JBFNPHALLDI()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 105f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1147f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-83);
		}

		// Token: 0x0600E676 RID: 58998 RVA: 0x006899BC File Offset: 0x00687BBC
		public virtual void FBOHLDDINDD()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1984f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 970f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-103);
		}

		// Token: 0x0600E677 RID: 58999 RVA: 0x00689A6C File Offset: 0x00687C6C
		private void JIFOELPAEHG()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 923f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1833f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E678 RID: 59000 RVA: 0x00689AD0 File Offset: 0x00687CD0
		public virtual void PBPJFNMIAPM()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1974f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 987f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-1);
		}

		// Token: 0x0600E679 RID: 59001 RVA: 0x00689B80 File Offset: 0x00687D80
		private void BNKJNBIDPME()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1891f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1369f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E67A RID: 59002 RVA: 0x00689BE4 File Offset: 0x00687DE4
		public virtual void IFBJBBEEEJM()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1074f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 11f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(95);
		}

		// Token: 0x0600E67B RID: 59003 RVA: 0x00689C94 File Offset: 0x00687E94
		public virtual void DIEJIMPDNCN()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 259f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1744f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(66);
		}

		// Token: 0x0600E67C RID: 59004 RVA: 0x00689D44 File Offset: 0x00687F44
		private void AIAMIFEPALP()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 442f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1167f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E67D RID: 59005 RVA: 0x00689DA8 File Offset: 0x00687FA8
		private void LMMDHJJJNJO()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 402f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1926f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E67E RID: 59006 RVA: 0x00689E0C File Offset: 0x0068800C
		public virtual void KHHBDMGMPKO()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 91f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1248f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-94);
		}

		// Token: 0x0600E67F RID: 59007 RVA: 0x00689EBC File Offset: 0x006880BC
		public virtual void INPDDECHAFM()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 383f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1702f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(70);
		}

		// Token: 0x0600E680 RID: 59008 RVA: 0x00689F6C File Offset: 0x0068816C
		public virtual void MGGMEEHLLJF()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1580f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1922f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-31);
		}

		// Token: 0x0600E681 RID: 59009 RVA: 0x0068A01C File Offset: 0x0068821C
		public virtual void GBLLCHAJFKO()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1994f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1138f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(69);
		}

		// Token: 0x0600E682 RID: 59010 RVA: 0x0068A0CC File Offset: 0x006882CC
		private void EMHGNEMIGII()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 423f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 256f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E683 RID: 59011 RVA: 0x0068A130 File Offset: 0x00688330
		public virtual void FOJDHFHGMAB()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1986f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 133f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(9);
		}

		// Token: 0x0600E684 RID: 59012 RVA: 0x0068A1E0 File Offset: 0x006883E0
		private void KMLNBHIIGKH()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1504f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 286f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E685 RID: 59013 RVA: 0x0068A244 File Offset: 0x00688444
		private void AAEFACEGJMB()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1471f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 247f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E686 RID: 59014 RVA: 0x0068A2A8 File Offset: 0x006884A8
		public virtual void ELOOHMOMIEJ()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1303f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1953f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(38);
		}

		// Token: 0x0600E687 RID: 59015 RVA: 0x0068A358 File Offset: 0x00688558
		public virtual void PEPECOHDHLG()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1582f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 467f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-18);
		}

		// Token: 0x0600E688 RID: 59016 RVA: 0x0068A408 File Offset: 0x00688608
		private void LACNPNKHCAA()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1899f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1848f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E689 RID: 59017 RVA: 0x0068A46C File Offset: 0x0068866C
		private void MPLCAGFGEBO()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 325f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 374f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E68A RID: 59018 RVA: 0x0068A4D0 File Offset: 0x006886D0
		private void MFHGOLNLAAF()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 463f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 650f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E68B RID: 59019 RVA: 0x0068A534 File Offset: 0x00688734
		private void HMLNMHOMMNO()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1069f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1807f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E68C RID: 59020 RVA: 0x0068A598 File Offset: 0x00688798
		private void FOHLAIIMNFB()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 229f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 231f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E68D RID: 59021 RVA: 0x0068A5FC File Offset: 0x006887FC
		private void GPCKACGEILI()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1183f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1547f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E68E RID: 59022 RVA: 0x0068A660 File Offset: 0x00688860
		private void JIBKGOFOPHJ()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1647f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1511f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E68F RID: 59023 RVA: 0x0068A6C4 File Offset: 0x006888C4
		private void IGEICBNMPAD()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1212f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1715f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E690 RID: 59024 RVA: 0x0068A728 File Offset: 0x00688928
		private void BOAJJAKEMLH()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1870f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 249f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E691 RID: 59025 RVA: 0x0068A78C File Offset: 0x0068898C
		public virtual void MKMCFEDNGIA()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1693f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1552f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(41);
		}

		// Token: 0x0600E692 RID: 59026 RVA: 0x0068A83C File Offset: 0x00688A3C
		public virtual void ONJBILAACLA()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1565f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1206f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-46);
		}

		// Token: 0x0600E693 RID: 59027 RVA: 0x0068A8EC File Offset: 0x00688AEC
		public virtual void AEEGNKLHBDJ()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 932f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 302f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-94);
		}

		// Token: 0x0600E694 RID: 59028 RVA: 0x0068A99C File Offset: 0x00688B9C
		private void OHKHOAKCENL()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 704f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 156f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E695 RID: 59029 RVA: 0x0068AA00 File Offset: 0x00688C00
		private void BJOICAKCPLI()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1580f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 152f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E696 RID: 59030 RVA: 0x0068AA64 File Offset: 0x00688C64
		public virtual void AOMPHDFCOOC()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1175f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 964f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-29);
		}

		// Token: 0x0600E697 RID: 59031 RVA: 0x0068AB14 File Offset: 0x00688D14
		public virtual void KOFDPHPMFML()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 179f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1550f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(119);
		}

		// Token: 0x0600E698 RID: 59032 RVA: 0x0068ABC4 File Offset: 0x00688DC4
		private void PBFKCKCHEAC()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 232f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 596f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E699 RID: 59033 RVA: 0x0068AC28 File Offset: 0x00688E28
		public virtual void LPFDBKFMIFH()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 134f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1059f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-41);
		}

		// Token: 0x0600E69A RID: 59034 RVA: 0x0068ACD8 File Offset: 0x00688ED8
		private void LBGKAMLLACN()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1725f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1327f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E69B RID: 59035 RVA: 0x0068AD3C File Offset: 0x00688F3C
		private void JFGGBEGNAFP()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 898f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1202f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E69C RID: 59036 RVA: 0x0068ADA0 File Offset: 0x00688FA0
		private void CDLDCKAHLHC()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 651f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1155f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E69D RID: 59037 RVA: 0x0068AE04 File Offset: 0x00689004
		public virtual void GDNDBEDKBLC()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1063f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1061f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(103);
		}

		// Token: 0x0600E69E RID: 59038 RVA: 0x0068AEB4 File Offset: 0x006890B4
		private void DPGECEOMHNM()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1710f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 1161f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E69F RID: 59039 RVA: 0x0068AF18 File Offset: 0x00689118
		public virtual void CIKAKKPDKKI()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 137f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1238f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(85);
		}

		// Token: 0x0600E6A0 RID: 59040 RVA: 0x0068AFC8 File Offset: 0x006891C8
		public virtual void GODPKGCHMOI()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 857f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 648f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(81);
		}

		// Token: 0x0600E6A1 RID: 59041 RVA: 0x0068B078 File Offset: 0x00689278
		public virtual void KNHGNDGDFIJ()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1413f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 1654f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-73);
		}

		// Token: 0x0600E6A2 RID: 59042 RVA: 0x0068B128 File Offset: 0x00689328
		private void GCNGEFBKMNC()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 763f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 77f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E6A3 RID: 59043 RVA: 0x0068B18C File Offset: 0x0068938C
		public virtual void AECOANNDLKM()
		{
			this.muzzleFlash.Emit(0);
			this.BKJLHLCNCOJ = 1809f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 185f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-99);
		}

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x0068B23C File Offset: 0x0068943C
		private void JMNNAPNJDNK()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 1817f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 61f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x0600E6A5 RID: 59045 RVA: 0x0068B2A0 File Offset: 0x006894A0
		public virtual void HAFJHPFNNAO()
		{
			this.muzzleFlash.Emit(1);
			this.BKJLHLCNCOJ = 1698f;
			RaycastHit raycastHit;
			if (!Physics.Raycast(this.shootFrom.position, this.shootFrom.forward, out raycastHit, this.range, this.hitLayers))
			{
				return;
			}
			Vector3 position = raycastHit.point + raycastHit.normal * 975f;
			UnityEngine.Object.Instantiate<Transform>(this.bulletHole, position, Quaternion.LookRotation(-raycastHit.normal));
			this.bulletHit.transform.position = position;
			this.bulletHit.Emit(-72);
		}

		// Token: 0x0600E6A6 RID: 59046 RVA: 0x0068B350 File Offset: 0x00689550
		private void Update()
		{
			this.BKJLHLCNCOJ = Mathf.Max(this.BKJLHLCNCOJ - Time.deltaTime * this.smokeFadeOutSpeed, 0f);
			ParticleSystem.EmissionModule emission = this.muzzleSmoke.emission;
			emission.enabled = (this.BKJLHLCNCOJ > 0f);
			emission.rate = new ParticleSystem.MinMaxCurve(this.BKJLHLCNCOJ);
		}

		// Token: 0x04001E0E RID: 7694
		[Header("Shooting")]
		public Transform shootFrom;

		// Token: 0x04001E0F RID: 7695
		public float range = 300f;

		// Token: 0x04001E10 RID: 7696
		public LayerMask hitLayers;

		// Token: 0x04001E11 RID: 7697
		[Header("FX")]
		public ParticleSystem muzzleFlash;

		// Token: 0x04001E12 RID: 7698
		public ParticleSystem muzzleSmoke;

		// Token: 0x04001E13 RID: 7699
		public Transform bulletHole;

		// Token: 0x04001E14 RID: 7700
		public ParticleSystem bulletHit;

		// Token: 0x04001E15 RID: 7701
		public float smokeFadeOutSpeed = 5f;

		// Token: 0x04001E16 RID: 7702
		private float BKJLHLCNCOJ;
	}
}
