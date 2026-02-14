using System;
using UnityEngine;

// Token: 0x02000283 RID: 643
public class PhysBait : MonoBehaviour
{
	// Token: 0x06009667 RID: 38503 RVA: 0x00431CD8 File Offset: 0x0042FED8
	public void EIJDBGEKPMM(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1888f;
		this.GNBBJHCDBNA();
	}

	// Token: 0x06009668 RID: 38504 RVA: 0x00431D3C File Offset: 0x0042FF3C
	public void FCAANONLIPF()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1870f;
		this.limitSpring.damper = 84f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x06009669 RID: 38505 RVA: 0x00431F10 File Offset: 0x00430110
	public void JOBPOICGMMH()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 714f;
		this.limitSpring.damper = 612f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600966A RID: 38506 RVA: 0x004320E1 File Offset: 0x004302E1
	private void LKNJKBIOBEM()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x0600966B RID: 38507 RVA: 0x00432118 File Offset: 0x00430318
	private void OnDestroy()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x0600966C RID: 38508 RVA: 0x00432144 File Offset: 0x00430344
	public void IJIFGCNHABA()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1707f;
		this.limitSpring.damper = 823f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600966D RID: 38509 RVA: 0x004320E1 File Offset: 0x004302E1
	private void APHJJJHNFNP()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x0600966E RID: 38510 RVA: 0x00432318 File Offset: 0x00430518
	public void DOENHEHKBIK()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1227f;
		this.limitSpring.damper = 884f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600966F RID: 38511 RVA: 0x004324E9 File Offset: 0x004306E9
	private void INDPPKACFGC()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009670 RID: 38512 RVA: 0x00432118 File Offset: 0x00430318
	private void CHGHJOFGPGH()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x06009671 RID: 38513 RVA: 0x004320E1 File Offset: 0x004302E1
	private void NANEAKKPDBH()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x06009672 RID: 38514 RVA: 0x0043251C File Offset: 0x0043071C
	public void BLBAFAPODIP(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 295f;
		this.KGEJCDPEHJH();
	}

	// Token: 0x06009673 RID: 38515 RVA: 0x004324E9 File Offset: 0x004306E9
	private void EMNIFMFINFA()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009674 RID: 38516 RVA: 0x00432118 File Offset: 0x00430318
	private void DBBGHOPCOKE()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x06009675 RID: 38517 RVA: 0x004320E1 File Offset: 0x004302E1
	private void LateUpdate()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x06009676 RID: 38518 RVA: 0x00432580 File Offset: 0x00430780
	public void AHLPBPEAEGI()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 768f;
		this.limitSpring.damper = 599f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x06009677 RID: 38519 RVA: 0x004324E9 File Offset: 0x004306E9
	private void OKBCBGJNPOF()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009678 RID: 38520 RVA: 0x00432754 File Offset: 0x00430954
	public void HNKLAMNNGGG()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1319f;
		this.limitSpring.damper = 12f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x06009679 RID: 38521 RVA: 0x00432928 File Offset: 0x00430B28
	public void MMCAFCIMGBM()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 748f;
		this.limitSpring.damper = 1326f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600967A RID: 38522 RVA: 0x00432AFC File Offset: 0x00430CFC
	public void IJHEMFLCKOO()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 667f;
		this.limitSpring.damper = 1735f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600967B RID: 38523 RVA: 0x00432CD0 File Offset: 0x00430ED0
	[ContextMenu("== Init Joint ==")]
	public void initJoint()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 30000f;
		this.limitSpring.damper = 1000f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600967C RID: 38524 RVA: 0x004320E1 File Offset: 0x004302E1
	private void HJDEGPKFBNI()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x0600967D RID: 38525 RVA: 0x004324E9 File Offset: 0x004306E9
	private void JMPGFNNBIGO()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x0600967F RID: 38527 RVA: 0x00432EA4 File Offset: 0x004310A4
	public void BPOGJLNHPDP(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 689f;
		this.BLHMAJMPMAG();
	}

	// Token: 0x06009680 RID: 38528 RVA: 0x004324E9 File Offset: 0x004306E9
	private void DKOOGLPFPMI()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009681 RID: 38529 RVA: 0x00432F08 File Offset: 0x00431108
	public void KGEJCDPEHJH()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 933f;
		this.limitSpring.damper = 896f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x06009682 RID: 38530 RVA: 0x004330DC File Offset: 0x004312DC
	public void KACCFJLDECI(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 578f;
		this.JFEHEOKBFLO();
	}

	// Token: 0x06009683 RID: 38531 RVA: 0x00433140 File Offset: 0x00431340
	public void CEDDJJKMKAK()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 68f;
		this.limitSpring.damper = 1910f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x06009684 RID: 38532 RVA: 0x004320E1 File Offset: 0x004302E1
	private void POCOKCJDCHK()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x06009685 RID: 38533 RVA: 0x004320E1 File Offset: 0x004302E1
	private void GCJBBACOJJE()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x06009686 RID: 38534 RVA: 0x00433314 File Offset: 0x00431514
	public void FDOCEFLHFBP()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1326f;
		this.limitSpring.damper = 1685f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x06009687 RID: 38535 RVA: 0x004324E9 File Offset: 0x004306E9
	private void BOPHHDCKKLB()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009688 RID: 38536 RVA: 0x00432118 File Offset: 0x00430318
	private void FDEEGGAAOPL()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x06009689 RID: 38537 RVA: 0x00432118 File Offset: 0x00430318
	private void DNJOPHOLBNB()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x0600968A RID: 38538 RVA: 0x004334E8 File Offset: 0x004316E8
	public void APIHMCKNOCD()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 127f;
		this.limitSpring.damper = 696f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600968B RID: 38539 RVA: 0x004336BC File Offset: 0x004318BC
	public void MCBLBGHBKPI()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1369f;
		this.limitSpring.damper = 547f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600968C RID: 38540 RVA: 0x00433890 File Offset: 0x00431A90
	public void BMBCMOOGBGD()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 810f;
		this.limitSpring.damper = 1351f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600968D RID: 38541 RVA: 0x00432118 File Offset: 0x00430318
	private void KKCCGNNJAJE()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x0600968E RID: 38542 RVA: 0x004320E1 File Offset: 0x004302E1
	private void PCGMJEBLBLD()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x0600968F RID: 38543 RVA: 0x00432118 File Offset: 0x00430318
	private void PINOEKEMAHE()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x06009690 RID: 38544 RVA: 0x004324E9 File Offset: 0x004306E9
	private void DCKNNIMDPMP()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009691 RID: 38545 RVA: 0x00432118 File Offset: 0x00430318
	private void FLGGHNOABOA()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x06009692 RID: 38546 RVA: 0x00433A64 File Offset: 0x00431C64
	public void HGCFKEMKGPK(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 207f;
		this.BDPHKDFCFOC();
	}

	// Token: 0x06009693 RID: 38547 RVA: 0x004320E1 File Offset: 0x004302E1
	private void EMMMEIGNPCH()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x06009694 RID: 38548 RVA: 0x004324E9 File Offset: 0x004306E9
	private void EMGCKNECDNB()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009695 RID: 38549 RVA: 0x004324E9 File Offset: 0x004306E9
	private void DGEPHMCMPJO()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009696 RID: 38550 RVA: 0x004320E1 File Offset: 0x004302E1
	private void GIKJMPHFJKH()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x06009697 RID: 38551 RVA: 0x004320E1 File Offset: 0x004302E1
	private void BLOLJBHKGOH()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x06009698 RID: 38552 RVA: 0x004324E9 File Offset: 0x004306E9
	private void ACPCJLEKCPM()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x06009699 RID: 38553 RVA: 0x00433AC8 File Offset: 0x00431CC8
	public void IOMOMOLBPLH(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1448f;
		this.BDPHKDFCFOC();
	}

	// Token: 0x0600969A RID: 38554 RVA: 0x00432118 File Offset: 0x00430318
	private void NJHJLHBNPOM()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x0600969B RID: 38555 RVA: 0x00433B2C File Offset: 0x00431D2C
	public void ELEOFNPCKHG()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1727f;
		this.limitSpring.damper = 1612f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600969C RID: 38556 RVA: 0x00432118 File Offset: 0x00430318
	private void KDKONDIFHHK()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x0600969D RID: 38557 RVA: 0x00433D00 File Offset: 0x00431F00
	public void ADCCMOBALNP()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 530f;
		this.limitSpring.damper = 1168f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x0600969E RID: 38558 RVA: 0x004324E9 File Offset: 0x004306E9
	private void KMHBOLLCJHO()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x0600969F RID: 38559 RVA: 0x004320E1 File Offset: 0x004302E1
	private void JFKCLOJNBJJ()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096A0 RID: 38560 RVA: 0x004324E9 File Offset: 0x004306E9
	private void EMOFBHIJHLL()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096A1 RID: 38561 RVA: 0x00432118 File Offset: 0x00430318
	private void JIIMDDDEDEA()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096A2 RID: 38562 RVA: 0x004320E1 File Offset: 0x004302E1
	private void JIFIMFCJDHL()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096A3 RID: 38563 RVA: 0x004320E1 File Offset: 0x004302E1
	private void LCMMGLMJPOK()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096A4 RID: 38564 RVA: 0x004324E9 File Offset: 0x004306E9
	private void MNEBLODGADC()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096A5 RID: 38565 RVA: 0x00432118 File Offset: 0x00430318
	private void DJBHIJCGLDB()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096A6 RID: 38566 RVA: 0x004320E1 File Offset: 0x004302E1
	private void IOJAKOAKEHD()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096A7 RID: 38567 RVA: 0x00432118 File Offset: 0x00430318
	private void GBANNFDMGDD()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096A8 RID: 38568 RVA: 0x00433ED4 File Offset: 0x004320D4
	public void CPHCEIJDPGH()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 49f;
		this.limitSpring.damper = 1f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096A9 RID: 38569 RVA: 0x004340A8 File Offset: 0x004322A8
	public void BLHMAJMPMAG()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1738f;
		this.limitSpring.damper = 881f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096AA RID: 38570 RVA: 0x00432118 File Offset: 0x00430318
	private void JOPKEFJOKIM()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096AB RID: 38571 RVA: 0x0043427C File Offset: 0x0043247C
	public void NMEFCGAJPGN(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1352f;
		this.ELEOFNPCKHG();
	}

	// Token: 0x060096AC RID: 38572 RVA: 0x00432118 File Offset: 0x00430318
	private void LPNHJCGGBPH()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096AD RID: 38573 RVA: 0x004324E9 File Offset: 0x004306E9
	private void NLJAKIHPKPM()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096AE RID: 38574 RVA: 0x00432118 File Offset: 0x00430318
	private void KCFKCLCADGM()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096AF RID: 38575 RVA: 0x004320E1 File Offset: 0x004302E1
	private void IGADEOFAIOF()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096B0 RID: 38576 RVA: 0x00432118 File Offset: 0x00430318
	private void CNBHLAOJGIA()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096B1 RID: 38577 RVA: 0x004324E9 File Offset: 0x004306E9
	private void JHOPAKGPBAJ()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096B2 RID: 38578 RVA: 0x004320E1 File Offset: 0x004302E1
	private void NLPHGJJOLOO()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096B3 RID: 38579 RVA: 0x004342E0 File Offset: 0x004324E0
	public void PCLDLHEEAGO()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 930f;
		this.limitSpring.damper = 296f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096B4 RID: 38580 RVA: 0x004324E9 File Offset: 0x004306E9
	private void FixedUpdate()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096B5 RID: 38581 RVA: 0x004320E1 File Offset: 0x004302E1
	private void EIEKEPGNGPL()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096B6 RID: 38582 RVA: 0x00432118 File Offset: 0x00430318
	private void FHPOOMAIJIC()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096B7 RID: 38583 RVA: 0x004320E1 File Offset: 0x004302E1
	private void IHMNBABLJLF()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096B8 RID: 38584 RVA: 0x004344B4 File Offset: 0x004326B4
	public void FMKFMLKGKFC()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1734f;
		this.limitSpring.damper = 112f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096B9 RID: 38585 RVA: 0x00434688 File Offset: 0x00432888
	public void CKMJNHBNCEI(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1256f;
		this.JOBPOICGMMH();
	}

	// Token: 0x060096BA RID: 38586 RVA: 0x004346EC File Offset: 0x004328EC
	public void OJKPACEFPHK(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1335f;
		this.JOBPOICGMMH();
	}

	// Token: 0x060096BB RID: 38587 RVA: 0x004324E9 File Offset: 0x004306E9
	private void CIJDJLHJHHC()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096BC RID: 38588 RVA: 0x00434750 File Offset: 0x00432950
	public void GDEGPEEPKNK(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1231f;
		this.CEDDJJKMKAK();
	}

	// Token: 0x060096BD RID: 38589 RVA: 0x004347B4 File Offset: 0x004329B4
	public void KAJJIMDHOEO(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 310f;
		this.IFJFAIFCKNF();
	}

	// Token: 0x060096BE RID: 38590 RVA: 0x00434818 File Offset: 0x00432A18
	public void NEJGJLIAOID(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 500f;
		this.IJHEMFLCKOO();
	}

	// Token: 0x060096BF RID: 38591 RVA: 0x00432118 File Offset: 0x00430318
	private void DNFMEMNJADK()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096C0 RID: 38592 RVA: 0x004320E1 File Offset: 0x004302E1
	private void GEOHKEPJFCJ()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096C1 RID: 38593 RVA: 0x0043487C File Offset: 0x00432A7C
	public void IFJFAIFCKNF()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 36f;
		this.limitSpring.damper = 1177f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096C2 RID: 38594 RVA: 0x00434A50 File Offset: 0x00432C50
	public void init(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1f;
		this.initJoint();
	}

	// Token: 0x060096C3 RID: 38595 RVA: 0x00434AB4 File Offset: 0x00432CB4
	public void EKIMGMNKPCL(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1367f;
		this.FCAANONLIPF();
	}

	// Token: 0x060096C4 RID: 38596 RVA: 0x004320E1 File Offset: 0x004302E1
	private void CGNFLAOBEFN()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096C5 RID: 38597 RVA: 0x00432118 File Offset: 0x00430318
	private void KOGGLIAMEAH()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096C6 RID: 38598 RVA: 0x00434B18 File Offset: 0x00432D18
	public void BDPHKDFCFOC()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 364f;
		this.limitSpring.damper = 1620f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096C7 RID: 38599 RVA: 0x004324E9 File Offset: 0x004306E9
	private void INFDDDBIPAB()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096C8 RID: 38600 RVA: 0x00432118 File Offset: 0x00430318
	private void ILBHBGFAKPN()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096C9 RID: 38601 RVA: 0x004320E1 File Offset: 0x004302E1
	private void MLKCOBKDPCK()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096CA RID: 38602 RVA: 0x00434CEC File Offset: 0x00432EEC
	public void HGGHHHDIOAP()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.None;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = true;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 625f;
		this.limitSpring.damper = 1930f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Limited;
		this.SJoint.zMotion = ConfigurableJointMotion.Locked;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096CB RID: 38603 RVA: 0x004320E1 File Offset: 0x004302E1
	private void OIKMLNIPLIA()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096CC RID: 38604 RVA: 0x00434EC0 File Offset: 0x004330C0
	public void DPLGFGBEHOH(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 783f;
		this.CPHCEIJDPGH();
	}

	// Token: 0x060096CD RID: 38605 RVA: 0x00434F24 File Offset: 0x00433124
	public void MEHNJFNPHFP()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 1082f;
		this.limitSpring.damper = 632f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096CE RID: 38606 RVA: 0x004324E9 File Offset: 0x004306E9
	private void NCNDIACEGEO()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096CF RID: 38607 RVA: 0x00432118 File Offset: 0x00430318
	private void GNPJEGPCBOD()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096D0 RID: 38608 RVA: 0x004324E9 File Offset: 0x004306E9
	private void GPNKIPJNFNF()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096D1 RID: 38609 RVA: 0x004350F8 File Offset: 0x004332F8
	public void DKKCACOMDDD(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1921f;
		this.BDPHKDFCFOC();
	}

	// Token: 0x060096D2 RID: 38610 RVA: 0x0043515C File Offset: 0x0043335C
	public void JFEHEOKBFLO()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 862f;
		this.limitSpring.damper = 381f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Locked;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096D3 RID: 38611 RVA: 0x00435330 File Offset: 0x00433530
	public void IJDNNNOFGBI(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1280f;
		this.CEDDJJKMKAK();
	}

	// Token: 0x060096D4 RID: 38612 RVA: 0x00432118 File Offset: 0x00430318
	private void HGNHAGCHGLA()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096D5 RID: 38613 RVA: 0x004320E1 File Offset: 0x004302E1
	private void MKNDDFMIGDN()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096D6 RID: 38614 RVA: 0x004324E9 File Offset: 0x004306E9
	private void KGFCEEKCLHE()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096D7 RID: 38615 RVA: 0x004324E9 File Offset: 0x004306E9
	private void JFNOIJPDNDP()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096D8 RID: 38616 RVA: 0x004324E9 File Offset: 0x004306E9
	private void OHGNKFGBOJL()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096D9 RID: 38617 RVA: 0x004324E9 File Offset: 0x004306E9
	private void NEHOCLNFDHP()
	{
		if (this.SJoint == null)
		{
			return;
		}
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
	}

	// Token: 0x060096DA RID: 38618 RVA: 0x00435394 File Offset: 0x00433594
	public void GNBBJHCDBNA()
	{
		if (this.SJoint == null)
		{
			this.SJoint = this.endRodPointConnector.gameObject.GetComponent<ConfigurableJoint>();
			if (this.SJoint == null)
			{
				Rigidbody rigidbody = this.endRodPointConnector.gameObject.GetComponent<Rigidbody>();
				if (rigidbody == null)
				{
					rigidbody = this.endRodPointConnector.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.isKinematic = false;
				rigidbody.useGravity = true;
				rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
				this.SJoint = this.endRodPointConnector.gameObject.AddComponent<ConfigurableJoint>();
			}
		}
		Vector3 position = this.endRodPointConnector.position;
		Quaternion rotation = this.endRodPointConnector.rotation;
		Vector3 localScale = this.endRodPointConnector.localScale;
		this.endRodPointConnector.position = this.baitConnector.transform.position;
		this.endRodPointConnector.rotation = this.baitConnector.transform.rotation;
		this.endRodPointConnector.localScale = this.baitConnector.transform.localScale;
		this.SJoint.autoConfigureConnectedAnchor = false;
		this.SJoint.connectedBody = this.baitConnector;
		this.SJoint.anchor = Vector3.zero;
		this.SJoint.connectedAnchor = Vector3.zero;
		this.limitSpring.spring = 509f;
		this.limitSpring.damper = 1099f;
		this.JKCLLPDKDDI.limit = this.lineCountMetr;
		this.SJoint.linearLimit = this.JKCLLPDKDDI;
		this.SJoint.xMotion = ConfigurableJointMotion.Limited;
		this.SJoint.yMotion = ConfigurableJointMotion.Locked;
		this.SJoint.zMotion = ConfigurableJointMotion.Limited;
		this.endRodPointConnector.position = position;
		this.endRodPointConnector.rotation = rotation;
		this.endRodPointConnector.localScale = localScale;
	}

	// Token: 0x060096DB RID: 38619 RVA: 0x00432118 File Offset: 0x00430318
	private void DMPJOEHFABC()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096DC RID: 38620 RVA: 0x00432118 File Offset: 0x00430318
	private void PCJIEHPPNMH()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096DD RID: 38621 RVA: 0x00435568 File Offset: 0x00433768
	public void JGEMMPHEMGC(Transform DIHIIKLGNCG, bool IKKPFPJLPOL)
	{
		this.endRodPointConnector = DIHIIKLGNCG;
		if (!IKKPFPJLPOL)
		{
			if (this.SJoint != null)
			{
				this.SJoint.connectedBody = null;
			}
			return;
		}
		this.lineCountMetr = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position) + 1599f;
		this.AHLPBPEAEGI();
	}

	// Token: 0x060096DE RID: 38622 RVA: 0x00432118 File Offset: 0x00430318
	private void CKDNIBCJIMM()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096DF RID: 38623 RVA: 0x00432118 File Offset: 0x00430318
	private void NLHMPJAIJKD()
	{
		if (this.SJoint != null)
		{
			UnityEngine.Object.Destroy(this.SJoint);
		}
		UnityEngine.Object.Destroy(this.baitConnector.gameObject);
	}

	// Token: 0x060096E0 RID: 38624 RVA: 0x004320E1 File Offset: 0x004302E1
	private void NGHOJBOHIBA()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x060096E1 RID: 38625 RVA: 0x004320E1 File Offset: 0x004302E1
	private void AIKJPMIHCFP()
	{
		if (this.endRodPointConnector == null)
		{
			return;
		}
		this.curentDistance = Vector3.Distance(this.endRodPointConnector.position, this.baitConnector.transform.position);
	}

	// Token: 0x040013B4 RID: 5044
	public Rigidbody baitConnector;

	// Token: 0x040013B5 RID: 5045
	public PoplDrop drop;

	// Token: 0x040013B6 RID: 5046
	public Transform endRodPointConnector;

	// Token: 0x040013B7 RID: 5047
	public ConfigurableJoint SJoint;

	// Token: 0x040013B8 RID: 5048
	public float lineCountMetr;

	// Token: 0x040013B9 RID: 5049
	public float curentDistance;

	// Token: 0x040013BA RID: 5050
	private SoftJointLimit JKCLLPDKDDI;

	// Token: 0x040013BB RID: 5051
	public SoftJointLimitSpring limitSpring;
}
