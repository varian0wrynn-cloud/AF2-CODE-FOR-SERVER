using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002E2 RID: 738
	public class SmoothFollow : MonoBehaviour
	{
		// Token: 0x0600AE04 RID: 44548 RVA: 0x00022FCC File Offset: 0x000211CC
		private void IAAOGAPJDID()
		{
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x00022FCC File Offset: 0x000211CC
		private void EDGALMCHPPH()
		{
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x00022FCC File Offset: 0x000211CC
		private void JLKBMEBFHBI()
		{
		}

		// Token: 0x0600AE07 RID: 44551 RVA: 0x00022FCC File Offset: 0x000211CC
		private void INDGOHJGCFN()
		{
		}

		// Token: 0x0600AE08 RID: 44552 RVA: 0x00022FCC File Offset: 0x000211CC
		private void MODJFGGIAHD()
		{
		}

		// Token: 0x0600AE09 RID: 44553 RVA: 0x00022FCC File Offset: 0x000211CC
		private void DHJDMKLBLEF()
		{
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x00022FCC File Offset: 0x000211CC
		private void Start()
		{
		}

		// Token: 0x0600AE0B RID: 44555 RVA: 0x00022FCC File Offset: 0x000211CC
		private void OBJCOJEHLBE()
		{
		}

		// Token: 0x0600AE0C RID: 44556 RVA: 0x004C6D90 File Offset: 0x004C4F90
		private void POMLHOHFIGA()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1089f, num, 1791f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE0D RID: 44557 RVA: 0x004C6EB8 File Offset: 0x004C50B8
		private void MJBLHNGLFOE()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(221f, num, 804f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE0E RID: 44558 RVA: 0x00022FCC File Offset: 0x000211CC
		private void KKCFKEDABLB()
		{
		}

		// Token: 0x0600AE0F RID: 44559 RVA: 0x00022FCC File Offset: 0x000211CC
		private void IIKDDILLGLF()
		{
		}

		// Token: 0x0600AE10 RID: 44560 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CLHGHANANNL()
		{
		}

		// Token: 0x0600AE11 RID: 44561 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CBLGFOFHNPJ()
		{
		}

		// Token: 0x0600AE12 RID: 44562 RVA: 0x004C6FE0 File Offset: 0x004C51E0
		private void KIMKOEBBFKJ()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(612f, num, 1716f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE13 RID: 44563 RVA: 0x004C7108 File Offset: 0x004C5308
		private void OKFONGOBMCC()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(610f, num, 399f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE14 RID: 44564 RVA: 0x00022FCC File Offset: 0x000211CC
		private void KIEIPFFEDHC()
		{
		}

		// Token: 0x0600AE15 RID: 44565 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CGMHGDEKDEP()
		{
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x004C7230 File Offset: 0x004C5430
		private void CMDJHGMGLCG()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(233f, num, 288f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE17 RID: 44567 RVA: 0x004C7358 File Offset: 0x004C5558
		private void BDALGHGNCPE()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1342f, num, 1912f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE18 RID: 44568 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CGNGBFFGGBP()
		{
		}

		// Token: 0x0600AE19 RID: 44569 RVA: 0x00022FCC File Offset: 0x000211CC
		private void EHDPACPIBNF()
		{
		}

		// Token: 0x0600AE1A RID: 44570 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CPNOBMNKPNC()
		{
		}

		// Token: 0x0600AE1B RID: 44571 RVA: 0x00022FCC File Offset: 0x000211CC
		private void BJHGPFGBFKF()
		{
		}

		// Token: 0x0600AE1C RID: 44572 RVA: 0x00022FCC File Offset: 0x000211CC
		private void FPLHODJCJDO()
		{
		}

		// Token: 0x0600AE1D RID: 44573 RVA: 0x004C7480 File Offset: 0x004C5680
		private void OEFDEEOHNJB()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(612f, num, 873f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE1E RID: 44574 RVA: 0x00022FCC File Offset: 0x000211CC
		private void DGGMJCMLLED()
		{
		}

		// Token: 0x0600AE1F RID: 44575 RVA: 0x00022FCC File Offset: 0x000211CC
		private void ELADFDNPOOI()
		{
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x00022FCC File Offset: 0x000211CC
		private void PFNPOHMMJDN()
		{
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x004C75A8 File Offset: 0x004C57A8
		private void HHJKBKLPLIM()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1614f, num, 1098f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x00022FCC File Offset: 0x000211CC
		private void GDIMBBBPIHI()
		{
		}

		// Token: 0x0600AE23 RID: 44579 RVA: 0x004C76D0 File Offset: 0x004C58D0
		private void MKNDDFMIGDN()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1995f, num, 879f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE24 RID: 44580 RVA: 0x004C77F8 File Offset: 0x004C59F8
		private void KCMJALIDEHB()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1174f, num, 815f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE25 RID: 44581 RVA: 0x00022FCC File Offset: 0x000211CC
		private void LPNDCJKAKEA()
		{
		}

		// Token: 0x0600AE26 RID: 44582 RVA: 0x00022FCC File Offset: 0x000211CC
		private void FFIGGPHAIBP()
		{
		}

		// Token: 0x0600AE27 RID: 44583 RVA: 0x00022FCC File Offset: 0x000211CC
		private void PBMPJPIMJBF()
		{
		}

		// Token: 0x0600AE28 RID: 44584 RVA: 0x004C7920 File Offset: 0x004C5B20
		private void LHFBEKCIKOI()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(496f, num, 1961f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE29 RID: 44585 RVA: 0x00022FCC File Offset: 0x000211CC
		private void NCALLFHEAGJ()
		{
		}

		// Token: 0x0600AE2A RID: 44586 RVA: 0x00022FCC File Offset: 0x000211CC
		private void NOKJMMDMJNO()
		{
		}

		// Token: 0x0600AE2B RID: 44587 RVA: 0x004C7A48 File Offset: 0x004C5C48
		private void HKJHIANMOPG()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(562f, num, 1969f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE2C RID: 44588 RVA: 0x004C7B70 File Offset: 0x004C5D70
		private void OEKHPJAEAAE()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1939f, num, 1258f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE2D RID: 44589 RVA: 0x004C7C98 File Offset: 0x004C5E98
		private void POCOKCJDCHK()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1903f, num, 692f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE2E RID: 44590 RVA: 0x004C7DC0 File Offset: 0x004C5FC0
		private void GHIJFOALMHM()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(937f, num, 1743f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE2F RID: 44591 RVA: 0x00022FCC File Offset: 0x000211CC
		private void AFFAJKPPMHF()
		{
		}

		// Token: 0x0600AE30 RID: 44592 RVA: 0x004C7EE8 File Offset: 0x004C60E8
		private void GFELHLPHCDN()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(897f, num, 228f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE31 RID: 44593 RVA: 0x00022FCC File Offset: 0x000211CC
		private void IMABGALEMBI()
		{
		}

		// Token: 0x0600AE32 RID: 44594 RVA: 0x004C8010 File Offset: 0x004C6210
		private void NCOJPBKLANI()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(224f, num, 661f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE33 RID: 44595 RVA: 0x004C8138 File Offset: 0x004C6338
		private void LOFKNDCJBMN()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1748f, num, 1545f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x004C8260 File Offset: 0x004C6460
		private void MDBPBJHACDA()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1299f, num, 1816f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE36 RID: 44598 RVA: 0x00022FCC File Offset: 0x000211CC
		private void KFGKKLAKFGH()
		{
		}

		// Token: 0x0600AE37 RID: 44599 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CAJLCEPLKJG()
		{
		}

		// Token: 0x0600AE38 RID: 44600 RVA: 0x004C83A4 File Offset: 0x004C65A4
		private void LBBGAADLMOM()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(763f, num, 354f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE39 RID: 44601 RVA: 0x004C84CC File Offset: 0x004C66CC
		private void BJILHFNDDKC()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(127f, num, 466f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE3A RID: 44602 RVA: 0x004C85F4 File Offset: 0x004C67F4
		private void OGFGENJAMAM()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1664f, num, 1576f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE3B RID: 44603 RVA: 0x004C871C File Offset: 0x004C691C
		private void LateUpdate()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(0f, num, 0f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE3C RID: 44604 RVA: 0x004C8844 File Offset: 0x004C6A44
		private void CGNFLAOBEFN()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(1720f, num, 1086f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x004C896C File Offset: 0x004C6B6C
		private void BOEFHGKGJMN()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(217f, num, 526f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x00022FCC File Offset: 0x000211CC
		private void EFJDBBDMPMC()
		{
		}

		// Token: 0x0600AE3F RID: 44607 RVA: 0x004C8A94 File Offset: 0x004C6C94
		private void PMIFCKJAFEB()
		{
			if (!this.target)
			{
				return;
			}
			float y = this.target.eulerAngles.y;
			float b = this.target.position.y + this.height;
			float num = base.transform.eulerAngles.y;
			float num2 = base.transform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(773f, num, 999f);
			base.transform.position = this.target.position;
			base.transform.position -= rotation * Vector3.forward * this.distance;
			base.transform.position = new Vector3(base.transform.position.x, num2, base.transform.position.z);
			base.transform.LookAt(this.target);
		}

		// Token: 0x04001628 RID: 5672
		[SerializeField]
		private Transform target;

		// Token: 0x04001629 RID: 5673
		[SerializeField]
		private float distance = 10f;

		// Token: 0x0400162A RID: 5674
		[SerializeField]
		private float height = 5f;

		// Token: 0x0400162B RID: 5675
		[SerializeField]
		private float rotationDamping;

		// Token: 0x0400162C RID: 5676
		[SerializeField]
		private float heightDamping;
	}
}
