using System;
using UnityEngine;

// Token: 0x020000F2 RID: 242
public class CameraSubControl : MonoBehaviour
{
	// Token: 0x06002D84 RID: 11652 RVA: 0x0014D0D4 File Offset: 0x0014B2D4
	private void DFFOEGHGPGP()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(1))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = false;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("OfficeSittingEyesRub") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = true;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 1221f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D85 RID: 11653 RVA: 0x0014D3D0 File Offset: 0x0014B5D0
	private void OHKHOAKCENL()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(1))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = true;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("SoccerKeeperStrafeLeft") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = true;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 1876f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D86 RID: 11654 RVA: 0x0014D6CC File Offset: 0x0014B8CC
	private void IIKDDILLGLF()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = true;
			}
		}
	}

	// Token: 0x06002D87 RID: 11655 RVA: 0x0014D720 File Offset: 0x0014B920
	private void HDFCIACDDEK()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
	}

	// Token: 0x06002D88 RID: 11656 RVA: 0x0014D774 File Offset: 0x0014B974
	private void CBBLGEDCJBF()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(1))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = true;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("_Lift") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = true;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 813f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D89 RID: 11657 RVA: 0x0014DA70 File Offset: 0x0014BC70
	private void HMEAENGBFKC()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(1))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = false;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("StrafeRunLeft") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = true;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 1446f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D8A RID: 11658 RVA: 0x0014DD6C File Offset: 0x0014BF6C
	private void OFGMIEJKMGC()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
	}

	// Token: 0x06002D8B RID: 11659 RVA: 0x0014DDC0 File Offset: 0x0014BFC0
	private void Start()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
	}

	// Token: 0x06002D8C RID: 11660 RVA: 0x0014DE14 File Offset: 0x0014C014
	private void PGIHAIPCJLL()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(0))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = true;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("'>Стоимость: </color>") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = true;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 1515f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D8D RID: 11661 RVA: 0x0014E110 File Offset: 0x0014C310
	private void IOGAKGCADBL()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(1))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = false;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("BlurDepthTollerance") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = false;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 1673f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D8E RID: 11662 RVA: 0x0014E40C File Offset: 0x0014C60C
	private void Update()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(1))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = false;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("Mouse ScrollWheel") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(1))
			{
				flag = true;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 0f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D8F RID: 11663 RVA: 0x0014E708 File Offset: 0x0014C908
	private void ELFLOPJDAKK()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
	}

	// Token: 0x06002D90 RID: 11664 RVA: 0x0014E75C File Offset: 0x0014C95C
	private void MCHAAIIHOKD()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
	}

	// Token: 0x06002D91 RID: 11665 RVA: 0x0014E7B0 File Offset: 0x0014C9B0
	private void JLFBDOPFDDJ()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(1))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = true;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("_WaveScale") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = true;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 715f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D92 RID: 11666 RVA: 0x0014EAAC File Offset: 0x0014CCAC
	private void BJOICAKCPLI()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(1))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = true;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("Variables protection") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = false;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 279f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D93 RID: 11667 RVA: 0x0014EDA8 File Offset: 0x0014CFA8
	private void LPNDCJKAKEA()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
	}

	// Token: 0x06002D94 RID: 11668 RVA: 0x0014EDFC File Offset: 0x0014CFFC
	private void OFPGMNGFLNH()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(0))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = false;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("invn_rec15") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(1))
			{
				flag = false;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 510f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x06002D96 RID: 11670 RVA: 0x0014F114 File Offset: 0x0014D314
	private void BMNJGPIPKLL()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
	}

	// Token: 0x06002D97 RID: 11671 RVA: 0x0014F168 File Offset: 0x0014D368
	private void CPNOBMNKPNC()
	{
		this.toPos = this.target.transform.position;
		if (this.target != null)
		{
			MeshRenderer component = this.target.gameObject.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = true;
			}
		}
	}

	// Token: 0x06002D98 RID: 11672 RVA: 0x0014F1BC File Offset: 0x0014D3BC
	private void BOAJJAKEMLH()
	{
		if (this.target != null)
		{
			if (!Input.GetMouseButton(0))
			{
				this.toPos = this.target.transform.position;
			}
			bool flag = true;
			Vector3 zero = Vector3.zero;
			zero.y = this.target.transform.position.y + this.ay * this.dst;
			zero.x = this.target.transform.position.x + this.ax * this.dst;
			zero.z = this.target.transform.position.z + this.az * this.dst;
			this.dst -= Input.GetAxis("SkateboardKickPush") * this.dSpeed;
			this.dst = Mathf.Clamp(this.dst, this.minMaxDst.x, this.minMaxDst.y);
			base.transform.position = zero;
			base.transform.LookAt(this.target.position);
			Vector2 vector = Input.mousePosition;
			if (Input.GetMouseButton(0))
			{
				flag = false;
				Vector2 vector2 = this.KEONIMIOEHE - vector;
				if (Mathf.Abs(vector2.x) > this.maxMovingSpeed)
				{
					vector2.x = this.maxMovingSpeed * Mathf.Sign(vector2.x);
				}
				if (Mathf.Abs(vector2.y) > this.maxMovingSpeed)
				{
					vector2.y = this.maxMovingSpeed * Mathf.Sign(vector2.y);
				}
				Vector3 b = new Vector3(vector2.y, 1846f, -vector2.x) * Time.deltaTime * this.mouseSpeedMultipier;
				this.toPos += b;
				this.toPos.x = Mathf.Clamp(this.toPos.x, this.xWall.x, this.xWall.y);
				this.toPos.z = Mathf.Clamp(this.toPos.z, this.zWall.x, this.zWall.y);
			}
			this.toPos.y = this.target.transform.position.y;
			Vector3 vector3 = this.toPos - this.target.position;
			if (!flag && vector3.magnitude > this.maxMovingSpeed)
			{
				vector3 = vector3.normalized * this.maxMovingSpeed;
			}
			vector3 = vector3 * this.movingSpeed * Time.deltaTime;
			this.target.Translate(vector3);
			this.KEONIMIOEHE = vector;
			if (this.toPosGO != null)
			{
				this.toPosGO.transform.position = this.toPos;
			}
		}
	}

	// Token: 0x0400061C RID: 1564
	public Transform target;

	// Token: 0x0400061D RID: 1565
	public Vector3 toPos;

	// Token: 0x0400061E RID: 1566
	public GameObject toPosGO;

	// Token: 0x0400061F RID: 1567
	public float ay;

	// Token: 0x04000620 RID: 1568
	public float ax;

	// Token: 0x04000621 RID: 1569
	public float az;

	// Token: 0x04000622 RID: 1570
	public float dst = 1f;

	// Token: 0x04000623 RID: 1571
	public float dSpeed = 1f;

	// Token: 0x04000624 RID: 1572
	public Vector2 minMaxDst;

	// Token: 0x04000625 RID: 1573
	public Vector2 xWall;

	// Token: 0x04000626 RID: 1574
	public Vector2 zWall;

	// Token: 0x04000627 RID: 1575
	public float movingSpeed;

	// Token: 0x04000628 RID: 1576
	public float maxMovingSpeed;

	// Token: 0x04000629 RID: 1577
	public float mouseSpeedMultipier;

	// Token: 0x0400062A RID: 1578
	private Vector2 KEONIMIOEHE;
}
