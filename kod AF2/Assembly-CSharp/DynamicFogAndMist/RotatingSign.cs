using System;
using UnityEngine;

namespace DynamicFogAndMist
{
	// Token: 0x020002A7 RID: 679
	public class RotatingSign : MonoBehaviour
	{
		// Token: 0x06009F66 RID: 40806 RVA: 0x00471AEC File Offset: 0x0046FCEC
		private void AMDMCKIFBPA()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 507f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 1 && Input.touches[0].position.x < (float)Screen.width * 249f && Input.touches[1].position.y < (float)Screen.height * 451f)
			{
				this.KBDGHBNGMBH();
			}
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x00471B70 File Offset: 0x0046FD70
		private void OHKHOAKCENL()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 292f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 1 && Input.touches[1].position.x < (float)Screen.width * 628f && Input.touches[0].position.y < (float)Screen.height * 389f)
			{
				this.OIDOHABOPIG();
			}
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x00471BF4 File Offset: 0x0046FDF4
		private void BJOICAKCPLI()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1173f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 1 && Input.touches[1].position.x < (float)Screen.width * 486f && Input.touches[0].position.y < (float)Screen.height * 1697f)
			{
				this.DAFCCLLFBJN();
			}
		}

		// Token: 0x06009F69 RID: 40809 RVA: 0x00471C78 File Offset: 0x0046FE78
		private void OPNIAJOKOOM()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x00471CF4 File Offset: 0x0046FEF4
		private void AEOMDKNCFOL()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x00471D70 File Offset: 0x0046FF70
		private void JIBKGOFOPHJ()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 906f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 0 && Input.touches[0].position.x < (float)Screen.width * 196f && Input.touches[0].position.y < (float)Screen.height * 1655f)
			{
				this.LBABIABHMCH();
			}
		}

		// Token: 0x06009F6C RID: 40812 RVA: 0x00471DF4 File Offset: 0x0046FFF4
		private void CDLDCKAHLHC()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1189f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 0 && Input.touches[0].position.x < (float)Screen.width * 967f && Input.touches[1].position.y < (float)Screen.height * 573f)
			{
				this.OPNIAJOKOOM();
			}
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x00471E78 File Offset: 0x00470078
		private void OLPDJKBIHMD()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x00471EF4 File Offset: 0x004700F4
		private void IKHCCAANGOP()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1685f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 0 && Input.touches[1].position.x < (float)Screen.width * 1953f && Input.touches[0].position.y < (float)Screen.height * 1743f)
			{
				this.BNJHJFMABBN();
			}
		}

		// Token: 0x06009F6F RID: 40815 RVA: 0x00471F78 File Offset: 0x00470178
		private void MCDKPEAJBLD()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x00471FF4 File Offset: 0x004701F4
		private void CEFPBFOMBHN()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x00472070 File Offset: 0x00470270
		private void PMKOAHMNBBG()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1080f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 0 && Input.touches[1].position.x < (float)Screen.width * 880f && Input.touches[0].position.y < (float)Screen.height * 840f)
			{
				this.NFJCNBKFHJI();
			}
		}

		// Token: 0x06009F72 RID: 40818 RVA: 0x004720F4 File Offset: 0x004702F4
		private void NFJCNBKFHJI()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F73 RID: 40819 RVA: 0x00472170 File Offset: 0x00470370
		private void MKPJPEFBEIK()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F75 RID: 40821 RVA: 0x004721EC File Offset: 0x004703EC
		private void LACNPNKHCAA()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 297f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 0 && Input.touches[1].position.x < (float)Screen.width * 1442f && Input.touches[1].position.y < (float)Screen.height * 1403f)
			{
				this.MLKMAKICEBB();
			}
		}

		// Token: 0x06009F76 RID: 40822 RVA: 0x00472270 File Offset: 0x00470470
		private void HMEAENGBFKC()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 881f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 1 && Input.touches[1].position.x < (float)Screen.width * 5f && Input.touches[0].position.y < (float)Screen.height * 242f)
			{
				this.AGLIGENBOMP();
			}
		}

		// Token: 0x06009F77 RID: 40823 RVA: 0x004722F4 File Offset: 0x004704F4
		private void PBFKCKCHEAC()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 481f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 1 && Input.touches[1].position.x < (float)Screen.width * 662f && Input.touches[0].position.y < (float)Screen.height * 1912f)
			{
				this.OIDOHABOPIG();
			}
		}

		// Token: 0x06009F78 RID: 40824 RVA: 0x00472378 File Offset: 0x00470578
		private void OIDOHABOPIG()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x004723F4 File Offset: 0x004705F4
		private void DAFCCLLFBJN()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F7A RID: 40826 RVA: 0x00472470 File Offset: 0x00470670
		private void PFNOEACNHON()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1682f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 1 && Input.touches[1].position.x < (float)Screen.width * 398f && Input.touches[0].position.y < (float)Screen.height * 558f)
			{
				this.PJMFCJBCOJG();
			}
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x004724F4 File Offset: 0x004706F4
		private void OPDCJCFMIPE()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 536f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 1 && Input.touches[0].position.x < (float)Screen.width * 778f && Input.touches[1].position.y < (float)Screen.height * 898f)
			{
				this.PHPIEILLFCJ();
			}
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x00472578 File Offset: 0x00470778
		private void PNBGJBMJLFM()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 565f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 0 && Input.touches[0].position.x < (float)Screen.width * 1900f && Input.touches[0].position.y < (float)Screen.height * 22f)
			{
				this.LHHHCOIPNAP();
			}
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x004725FC File Offset: 0x004707FC
		private void GDMFBLDDKEP()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x00472678 File Offset: 0x00470878
		private void HMLNMHOMMNO()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1433f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 0 && Input.touches[1].position.x < (float)Screen.width * 726f && Input.touches[0].position.y < (float)Screen.height * 1402f)
			{
				this.OLPDJKBIHMD();
			}
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x004726FC File Offset: 0x004708FC
		private void GCNGEFBKMNC()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 271f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 0 && Input.touches[1].position.x < (float)Screen.width * 1795f && Input.touches[0].position.y < (float)Screen.height * 256f)
			{
				this.BNJHJFMABBN();
			}
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x00472780 File Offset: 0x00470980
		private void JIFOELPAEHG()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 88f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 0 && Input.touches[0].position.x < (float)Screen.width * 995f && Input.touches[0].position.y < (float)Screen.height * 10f)
			{
				this.KBDGHBNGMBH();
			}
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x00472804 File Offset: 0x00470A04
		private void BNJHJFMABBN()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x00472880 File Offset: 0x00470A80
		private void MFHGOLNLAAF()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 501f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 1 && Input.touches[1].position.x < (float)Screen.width * 1032f && Input.touches[0].position.y < (float)Screen.height * 1310f)
			{
				this.PNBFKIENHDB();
			}
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x00472904 File Offset: 0x00470B04
		private void PHPIEILLFCJ()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x00472980 File Offset: 0x00470B80
		private void DBCHEEBMHPC()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x004729FC File Offset: 0x00470BFC
		private void PNBFKIENHDB()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x00472A78 File Offset: 0x00470C78
		private void FPLNDDMFFKG()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 43f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 0 && Input.touches[0].position.x < (float)Screen.width * 1359f && Input.touches[1].position.y < (float)Screen.height * 1987f)
			{
				this.LHHHCOIPNAP();
			}
		}

		// Token: 0x06009F87 RID: 40839 RVA: 0x00472AFC File Offset: 0x00470CFC
		private void JLFBDOPFDDJ()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1803f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 1 && Input.touches[0].position.x < (float)Screen.width * 886f && Input.touches[0].position.y < (float)Screen.height * 1724f)
			{
				this.LBABIABHMCH();
			}
		}

		// Token: 0x06009F88 RID: 40840 RVA: 0x00472B80 File Offset: 0x00470D80
		private void HCCOIOLDGHE()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x00472BFC File Offset: 0x00470DFC
		private void LBOONMDONCF()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1102f);
			if (Input.GetMouseButtonDown(1) && Input.touchCount > 1 && Input.touches[0].position.x < (float)Screen.width * 1027f && Input.touches[1].position.y < (float)Screen.height * 185f)
			{
				this.PIPOKFLAOLO();
			}
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x00472C80 File Offset: 0x00470E80
		private void EKCKBDKEAKO()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 4f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 0 && Input.touches[1].position.x < (float)Screen.width * 964f && Input.touches[1].position.y < (float)Screen.height * 1244f)
			{
				this.LHHHCOIPNAP();
			}
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x00472D04 File Offset: 0x00470F04
		private void Update()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 50f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 0 && Input.touches[0].position.x < (float)Screen.width * 0.5f && Input.touches[0].position.y < (float)Screen.height * 0.25f)
			{
				this.OIDOHABOPIG();
			}
		}

		// Token: 0x06009F8C RID: 40844 RVA: 0x00472D88 File Offset: 0x00470F88
		private void KBDGHBNGMBH()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F8D RID: 40845 RVA: 0x00472E04 File Offset: 0x00471004
		private void IPFDNHCOLEF()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F8E RID: 40846 RVA: 0x00472E80 File Offset: 0x00471080
		private void EMHGNEMIGII()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1480f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 0 && Input.touches[1].position.x < (float)Screen.width * 558f && Input.touches[0].position.y < (float)Screen.height * 775f)
			{
				this.OPNIAJOKOOM();
			}
		}

		// Token: 0x06009F8F RID: 40847 RVA: 0x00472F04 File Offset: 0x00471104
		private void FHFDDANKBPN()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x00472F80 File Offset: 0x00471180
		private void IBHNLLAGMFC()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x00472FFC File Offset: 0x004711FC
		private void MCEIMFALOBI()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x00473078 File Offset: 0x00471278
		private void JPHLMNIMDHH()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 1143f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 1 && Input.touches[0].position.x < (float)Screen.width * 1939f && Input.touches[1].position.y < (float)Screen.height * 1924f)
			{
				this.MLKMAKICEBB();
			}
		}

		// Token: 0x06009F93 RID: 40851 RVA: 0x004730FC File Offset: 0x004712FC
		private void BCCDJGLJLFP()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x00473178 File Offset: 0x00471378
		private void LHLHELBDHJH()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F95 RID: 40853 RVA: 0x004731F4 File Offset: 0x004713F4
		private void LBABIABHMCH()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x00473270 File Offset: 0x00471470
		private void JEIBLBLKFIB()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x004732EC File Offset: 0x004714EC
		private void DKINLOGBJGE()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x00473368 File Offset: 0x00471568
		private void JBKELKDBCKF()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x004733E4 File Offset: 0x004715E4
		private void PIPOKFLAOLO()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.GroundFog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x00473460 File Offset: 0x00471660
		private void MLKMAKICEBB()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x004734DC File Offset: 0x004716DC
		private void AGLIGENBOMP()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x00473558 File Offset: 0x00471758
		private void PJMFCJBCOJG()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x004735D4 File Offset: 0x004717D4
		private void AKLFCMNCPKL()
		{
			base.transform.Rotate(Vector3.up, Time.deltaTime * 350f);
			if (Input.GetMouseButtonDown(0) && Input.touchCount > 1 && Input.touches[0].position.x < (float)Screen.width * 1428f && Input.touches[1].position.y < (float)Screen.height * 1850f)
			{
				this.MLKMAKICEBB();
			}
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x00473658 File Offset: 0x00471858
		private void LHHHCOIPNAP()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.SandStorm;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = (DGNMDDLNIKA)8;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.HeavyFog;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x004736D4 File Offset: 0x004718D4
		private void PLKNCMKNJJA()
		{
			DynamicFog component = Camera.main.GetComponent<DynamicFog>();
			switch (component.preset)
			{
			case DGNMDDLNIKA.Clear:
				component.preset = DGNMDDLNIKA.Mist;
				return;
			case DGNMDDLNIKA.Mist:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.WindyMist:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.GroundFog:
				component.preset = DGNMDDLNIKA.Custom;
				return;
			case DGNMDDLNIKA.Fog:
				component.preset = DGNMDDLNIKA.Fog;
				return;
			case DGNMDDLNIKA.HeavyFog:
				component.preset = DGNMDDLNIKA.WindyMist;
				return;
			case DGNMDDLNIKA.SandStorm:
				component.preset = DGNMDDLNIKA.Clear;
				return;
			default:
				return;
			}
		}
	}
}
