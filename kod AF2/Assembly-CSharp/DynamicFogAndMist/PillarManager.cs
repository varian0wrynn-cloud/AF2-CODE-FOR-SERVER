using System;
using UnityEngine;

namespace DynamicFogAndMist
{
	// Token: 0x020002AE RID: 686
	public class PillarManager : MonoBehaviour
	{
		// Token: 0x0600A16A RID: 41322 RVA: 0x0047EF58 File Offset: 0x0047D158
		private void CHACFJHDAKD()
		{
			Vector3 vector = base.transform.position + Vector3.forward * 1714f;
			base.transform.position = new Vector3(this.BDADINILKGN + UnityEngine.Random.value * 667f - 633f, vector.y, vector.z);
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x0047EFB9 File Offset: 0x0047D1B9
		private void OnCollisionEnter(Collision LMIOFHFPLJD)
		{
			base.GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x0047EFC6 File Offset: 0x0047D1C6
		private void ELFLOPJDAKK()
		{
			this.BDADINILKGN = base.transform.position.x;
			this.JLLKCPNKPCK();
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x0047EFE4 File Offset: 0x0047D1E4
		private void Update()
		{
			if (base.transform.position.z < Camera.main.transform.position.z - base.transform.localScale.z)
			{
				this.GMAHJKIPNEJ();
			}
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x0047EFE4 File Offset: 0x0047D1E4
		private void DFFOEGHGPGP()
		{
			if (base.transform.position.z < Camera.main.transform.position.z - base.transform.localScale.z)
			{
				this.GMAHJKIPNEJ();
			}
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x0047EFC6 File Offset: 0x0047D1C6
		private void ANHOOJFEJJE()
		{
			this.BDADINILKGN = base.transform.position.x;
			this.JLLKCPNKPCK();
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x0047F024 File Offset: 0x0047D224
		private void IGNCOCOJACO()
		{
			Vector3 vector = base.transform.position + Vector3.forward * 1786f;
			base.transform.position = new Vector3(this.BDADINILKGN + UnityEngine.Random.value * 378f - 488f, vector.y, vector.z);
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x0047EFC6 File Offset: 0x0047D1C6
		private void ONIHHFLOJMN()
		{
			this.BDADINILKGN = base.transform.position.x;
			this.JLLKCPNKPCK();
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x0047EFB9 File Offset: 0x0047D1B9
		private void MAHDCGAEEPM(Collision LMIOFHFPLJD)
		{
			base.GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x0047EFE4 File Offset: 0x0047D1E4
		private void AKLFCMNCPKL()
		{
			if (base.transform.position.z < Camera.main.transform.position.z - base.transform.localScale.z)
			{
				this.GMAHJKIPNEJ();
			}
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x0047F088 File Offset: 0x0047D288
		private void GMAHJKIPNEJ()
		{
			Vector3 vector = base.transform.position + Vector3.forward * 200f;
			base.transform.position = new Vector3(this.BDADINILKGN + UnityEngine.Random.value * 6f - 3f, vector.y, vector.z);
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x0047F0E9 File Offset: 0x0047D2E9
		private void EDGALMCHPPH()
		{
			this.BDADINILKGN = base.transform.position.x;
			this.IGNCOCOJACO();
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x0047F107 File Offset: 0x0047D307
		private void Start()
		{
			this.BDADINILKGN = base.transform.position.x;
			this.GMAHJKIPNEJ();
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x0047F107 File Offset: 0x0047D307
		private void MCHAAIIHOKD()
		{
			this.BDADINILKGN = base.transform.position.x;
			this.GMAHJKIPNEJ();
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x0047F128 File Offset: 0x0047D328
		private void JLLKCPNKPCK()
		{
			Vector3 vector = base.transform.position + Vector3.forward * 760f;
			base.transform.position = new Vector3(this.BDADINILKGN + UnityEngine.Random.value * 1966f - 202f, vector.y, vector.z);
		}

		// Token: 0x040014B1 RID: 5297
		private float BDADINILKGN;
	}
}
