using System;
using UnityEngine;

// Token: 0x02000124 RID: 292
public class PetPlayer : MonoBehaviour
{
	// Token: 0x06003C28 RID: 15400 RVA: 0x001B180C File Offset: 0x001AFA0C
	private void AKLFCMNCPKL()
	{
		this.toMovePoint = Fisherman.getI.LFCLAFABKKE() + Fisherman.getI.transform.right * 1431f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) >= 1464f;
		if (flag)
		{
			if (a.magnitude > 1257f && Vector3.Distance(a, base.transform.position) > 1308f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1437f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(782f, 361f, 780f), vector + new Vector3(460f, 1955f, 1359f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 1596f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 281f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "дней")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 249f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1836f, 1140f, 245f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 685f);
				if (Physics.Raycast(ray2, out raycastHit, 1910f, Fisherman.getI.moveLayerCollision))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("UIChat_alfa", this.isMoveState);
		}
	}

	// Token: 0x06003C29 RID: 15401 RVA: 0x001B1AF0 File Offset: 0x001AFCF0
	private void LBGKAMLLACN()
	{
		this.toMovePoint = Fisherman.getI.LFCLAFABKKE() + Fisherman.getI.transform.right * 852f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) < 1999f;
		if (flag)
		{
			if (a.magnitude > 1641f && Vector3.Distance(a, base.transform.position) > 1787f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1654f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(180f, 130f, 1452f), vector + new Vector3(874f, 357f, 199f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 516f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1614f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "_")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 441f)
				{
					flag = true;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1249f, 1871f, 501f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 1653f);
				if (Physics.Raycast(ray2, out raycastHit, 711f, Fisherman.getI.moveLayerCollision))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("gi_fs_itm", this.isMoveState);
		}
	}

	// Token: 0x06003C2B RID: 15403 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void EHFPLKEINFO()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C2C RID: 15404 RVA: 0x001B1E04 File Offset: 0x001B0004
	private void PMKOAHMNBBG()
	{
		this.toMovePoint = Fisherman.getI.EGHPOBMBIBC() + Fisherman.getI.transform.right * 1117f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) < 198f;
		if (flag)
		{
			if (a.magnitude > 907f && Vector3.Distance(a, base.transform.position) > 1798f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 798f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(1797f, 1086f, 1657f), vector + new Vector3(1019f, 1716f, 825f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 1130f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 610f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == " POSITION not found")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1246f)
				{
					flag = true;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(510f, 929f, 1578f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 560f);
				if (Physics.Raycast(ray2, out raycastHit, 1042f, Fisherman.getI.moveLayerCollision))
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("MotorbikeWheelyNoHands", this.isMoveState);
		}
	}

	// Token: 0x06003C2D RID: 15405 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void KKCFKEDABLB()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C2E RID: 15406 RVA: 0x001B20E8 File Offset: 0x001B02E8
	private void JPHLMNIMDHH()
	{
		this.toMovePoint = Fisherman.getI.EGHPOBMBIBC() + Fisherman.getI.transform.right * 1287f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) >= 1858f;
		if (flag)
		{
			if (a.magnitude > 1524f && Vector3.Distance(a, base.transform.position) > 686f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 961f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(62f, 1776f, 1993f), vector + new Vector3(523f, 1576f, 1018f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 960f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 921f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "isBreak")
				{
					flag = true;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1792f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1504f, 1853f, 1320f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 406f);
				if (Physics.Raycast(ray2, out raycastHit, 693f, Fisherman.getI.moveLayerCollision))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("Far", this.isMoveState);
		}
	}

	// Token: 0x06003C2F RID: 15407 RVA: 0x001B23CC File Offset: 0x001B05CC
	private void MFHGOLNLAAF()
	{
		this.toMovePoint = Fisherman.getI.LFCLAFABKKE() + Fisherman.getI.transform.right * 1894f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) >= 486f;
		if (flag)
		{
			if (a.magnitude > 891f && Vector3.Distance(a, base.transform.position) > 816f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 548f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(1712f, 852f, 1985f), vector + new Vector3(918f, 1538f, 878f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 449f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 542f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "wpn_iwgt")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 105f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(501f, 109f, 1303f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 1676f);
				if (Physics.Raycast(ray2, out raycastHit, 1938f, Fisherman.getI.moveLayerCollision))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("wpn_add/base", this.isMoveState);
		}
	}

	// Token: 0x06003C30 RID: 15408 RVA: 0x001B26B0 File Offset: 0x001B08B0
	private void PGIHAIPCJLL()
	{
		this.toMovePoint = Fisherman.getI.LFCLAFABKKE() + Fisherman.getI.transform.right * 880f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) < 1164f;
		if (flag)
		{
			if (a.magnitude > 912f && Vector3.Distance(a, base.transform.position) > 29f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1683f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(1768f, 1874f, 1343f), vector + new Vector3(760f, 1410f, 85f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 1507f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1298f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "maxdeep")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1664f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(99f, 1267f, 764f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 94f);
				if (Physics.Raycast(ray2, out raycastHit, 154f, Fisherman.getI.moveLayerCollision))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("__c", this.isMoveState);
		}
	}

	// Token: 0x06003C31 RID: 15409 RVA: 0x001B2994 File Offset: 0x001B0B94
	private void AIAMIFEPALP()
	{
		this.toMovePoint = Fisherman.getI.EGHPOBMBIBC() + Fisherman.getI.transform.right * 852f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) < 1442f;
		if (flag)
		{
			if (a.magnitude > 786f && Vector3.Distance(a, base.transform.position) > 1010f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1660f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(934f, 721f, 1424f), vector + new Vector3(566f, 584f, 1132f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 638f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 196f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "_Phase")
				{
					flag = true;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 557f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1372f, 449f, 199f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 378f);
				if (Physics.Raycast(ray2, out raycastHit, 451f, Fisherman.getI.moveLayerCollision))
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("", this.isMoveState);
		}
	}

	// Token: 0x06003C32 RID: 15410 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void AOCDDBNBADJ()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C33 RID: 15411 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void ONIHHFLOJMN()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C34 RID: 15412 RVA: 0x001B2C78 File Offset: 0x001B0E78
	private void OHKHOAKCENL()
	{
		this.toMovePoint = Fisherman.getI.PAGFNACCBON + Fisherman.getI.transform.right * 259f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) < 1202f;
		if (flag)
		{
			if (a.magnitude > 211f && Vector3.Distance(a, base.transform.position) > 122f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1213f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(223f, 1574f, 741f), vector + new Vector3(369f, 1256f, 1215f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 101f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1721f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "wpn_wgt")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 968f)
				{
					flag = true;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(441f, 547f, 1842f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 1719f);
				if (Physics.Raycast(ray2, out raycastHit, 1944f, Fisherman.getI.moveLayerCollision))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("wpn_add/base", this.isMoveState);
		}
	}

	// Token: 0x06003C35 RID: 15413 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void HDFCIACDDEK()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C36 RID: 15414 RVA: 0x001B2F5C File Offset: 0x001B115C
	private void AMDMCKIFBPA()
	{
		this.toMovePoint = Fisherman.getI.EGHPOBMBIBC() + Fisherman.getI.transform.right * 790f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) >= 166f;
		if (flag)
		{
			if (a.magnitude > 547f && Vector3.Distance(a, base.transform.position) > 1169f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 46f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(1345f, 1430f, 1513f), vector + new Vector3(1152f, 1078f, 1120f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 739f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1081f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "ok")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1721f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1279f, 1439f, 1891f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 1175f);
				if (Physics.Raycast(ray2, out raycastHit, 524f, Fisherman.getI.moveLayerCollision))
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("<color='#200080'>", this.isMoveState);
		}
	}

	// Token: 0x06003C37 RID: 15415 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void PMDPLLIBJAF()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C38 RID: 15416 RVA: 0x001B3240 File Offset: 0x001B1440
	private void Update()
	{
		this.toMovePoint = Fisherman.getI.PAGFNACCBON + Fisherman.getI.transform.right * 0.8f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) >= 0.4f;
		if (flag)
		{
			if (a.magnitude > 0.1f && Vector3.Distance(a, base.transform.position) > 0.1f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 3f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(0f, 0.5f, 0f), vector + new Vector3(0f, -1.5f, 0f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 3f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 5f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "Water")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 0.7f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(0f, 0.5f, 0f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 0.7f);
				if (Physics.Raycast(ray2, out raycastHit, 0.7f, Fisherman.getI.moveLayerCollision))
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("isMove", this.isMoveState);
		}
	}

	// Token: 0x06003C39 RID: 15417 RVA: 0x001B3524 File Offset: 0x001B1724
	private void JLFBDOPFDDJ()
	{
		this.toMovePoint = Fisherman.getI.PAGFNACCBON + Fisherman.getI.transform.right * 928f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) < 745f;
		if (flag)
		{
			if (a.magnitude > 1376f && Vector3.Distance(a, base.transform.position) > 89f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 699f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(1113f, 1642f, 1886f), vector + new Vector3(1789f, 1428f, 295f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 724f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1110f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "no result template ")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1412f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(821f, 141f, 1284f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 410f);
				if (Physics.Raycast(ray2, out raycastHit, 1604f, Fisherman.getI.moveLayerCollision))
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("Wizard1HandThrow", this.isMoveState);
		}
	}

	// Token: 0x06003C3A RID: 15418 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void BMNJGPIPKLL()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C3B RID: 15419 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void Start()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C3C RID: 15420 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void KGICJDGIIJK()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C3D RID: 15421 RVA: 0x001B3808 File Offset: 0x001B1A08
	private void CBBLGEDCJBF()
	{
		this.toMovePoint = Fisherman.getI.LFCLAFABKKE() + Fisherman.getI.transform.right * 67f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) >= 1676f;
		if (flag)
		{
			if (a.magnitude > 1834f && Vector3.Distance(a, base.transform.position) > 623f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1497f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(653f, 909f, 1392f), vector + new Vector3(1278f, 1652f, 817f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 366f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 648f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "WorkerShovel")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1062f)
				{
					flag = true;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1651f, 310f, 1940f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 1773f);
				if (Physics.Raycast(ray2, out raycastHit, 1774f, Fisherman.getI.moveLayerCollision))
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("_ZTest", this.isMoveState);
		}
	}

	// Token: 0x06003C3E RID: 15422 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void CPNOBMNKPNC()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C3F RID: 15423 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void KEMGOLACEHI()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C40 RID: 15424 RVA: 0x001B3AEC File Offset: 0x001B1CEC
	private void IGEICBNMPAD()
	{
		this.toMovePoint = Fisherman.getI.EGHPOBMBIBC() + Fisherman.getI.transform.right * 1892f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) < 556f;
		if (flag)
		{
			if (a.magnitude > 952f && Vector3.Distance(a, base.transform.position) > 562f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1506f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(908f, 1007f, 920f), vector + new Vector3(1439f, 471f, 547f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 778f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1785f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "")
				{
					flag = true;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1627f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1925f, 1771f, 1847f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 216f);
				if (Physics.Raycast(ray2, out raycastHit, 1675f, Fisherman.getI.moveLayerCollision))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("IdleMouthWipe", this.isMoveState);
		}
	}

	// Token: 0x06003C41 RID: 15425 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void HHGGCBLOJGB()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C42 RID: 15426 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void MCHAAIIHOKD()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C43 RID: 15427 RVA: 0x001B3DD0 File Offset: 0x001B1FD0
	private void IOGAKGCADBL()
	{
		this.toMovePoint = Fisherman.getI.LFCLAFABKKE() + Fisherman.getI.transform.right * 294f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) >= 1901f;
		if (flag)
		{
			if (a.magnitude > 1762f && Vector3.Distance(a, base.transform.position) > 166f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 933f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(1453f, 1622f, 1534f), vector + new Vector3(533f, 128f, 130f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 1405f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 585f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "FrontKick")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 539f)
				{
					flag = true;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(632f, 1349f, 1018f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 1092f);
				if (Physics.Raycast(ray2, out raycastHit, 611f, Fisherman.getI.moveLayerCollision))
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("_RayStepSize", this.isMoveState);
		}
	}

	// Token: 0x06003C44 RID: 15428 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void EDGALMCHPPH()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C45 RID: 15429 RVA: 0x001B40B4 File Offset: 0x001B22B4
	private void KJJBBLDJHPD()
	{
		this.toMovePoint = Fisherman.getI.PAGFNACCBON + Fisherman.getI.transform.right * 474f;
		Vector3 a = this.toMovePoint;
		a.y = base.transform.position.y;
		bool flag = Vector3.Distance(a, base.transform.position) < 990f;
		if (flag)
		{
			if (a.magnitude > 1660f && Vector3.Distance(a, base.transform.position) > 634f)
			{
				Vector3 a2 = this.toMovePoint;
				a2.y = base.transform.position.y;
				Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 485f);
			}
			else
			{
				this.toMovePoint = base.transform.position;
			}
			Vector3 vector = (this.toMovePoint - base.transform.position).normalized;
			Ray ray = new Ray(base.transform.position + new Vector3(1502f, 1257f, 885f), vector + new Vector3(1309f, 1275f, 1694f));
			Debug.DrawRay(ray.origin, ray.direction, Color.green, 1855f);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1835f, Fisherman.getI.clickLayerCollision))
			{
				if (raycastHit.collider.gameObject.tag == "Sonar_pos")
				{
					flag = true;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 601f)
				{
					flag = true;
				}
			}
			if (flag)
			{
				vector = this.toMovePoint - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1776f, 168f, 819f), vector);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 80f);
				if (Physics.Raycast(ray2, out raycastHit, 201f, Fisherman.getI.moveLayerCollision))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OALKKDMBILM.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		this.isMoveState = flag;
		if (this.PPDJJDFGDNN != null)
		{
			this.PPDJJDFGDNN.SetBool("fshop_hd2", this.isMoveState);
		}
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void CGMHGDEKDEP()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x06003C47 RID: 15431 RVA: 0x001B1DE7 File Offset: 0x001AFFE7
	private void PFNPOHMMJDN()
	{
		this.OALKKDMBILM = base.GetComponent<CharacterController>();
		this.PPDJJDFGDNN = base.GetComponentInChildren<Animator>();
	}

	// Token: 0x0400086D RID: 2157
	public EKBAPCMPANI petWpn;

	// Token: 0x0400086E RID: 2158
	public Vector3 toMovePoint;

	// Token: 0x0400086F RID: 2159
	public bool isMoveState;

	// Token: 0x04000870 RID: 2160
	public const float mrotSmoothing = 3f;

	// Token: 0x04000871 RID: 2161
	public const float minDistance = 0.4f;

	// Token: 0x04000872 RID: 2162
	public float moveSpeed = 2f;

	// Token: 0x04000873 RID: 2163
	private CharacterController OALKKDMBILM;

	// Token: 0x04000874 RID: 2164
	private Animator PPDJJDFGDNN;
}
