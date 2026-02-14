using System;
using UnityEngine;

// Token: 0x02000288 RID: 648
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(LineRenderer))]
public class RopeScript : MonoBehaviour
{
	// Token: 0x060097B0 RID: 38832 RVA: 0x00438440 File Offset: 0x00436640
	public void CMHCLDFHLMO()
	{
		this.rope = true;
		GameObject[] array = this.joints;
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[1];
		this.joints = new GameObject[1];
		this.segments = 0;
	}

	// Token: 0x060097B1 RID: 38833 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PHONLBCOJEG()
	{
	}

	// Token: 0x060097B2 RID: 38834 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LateUpdate()
	{
	}

	// Token: 0x060097B3 RID: 38835 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JOHDLNOKCOK()
	{
	}

	// Token: 0x060097B4 RID: 38836 RVA: 0x0043849B File Offset: 0x0043669B
	private void EMNIFMFINFA()
	{
		this.ELDPILKNKBA();
	}

	// Token: 0x060097B5 RID: 38837 RVA: 0x004384A4 File Offset: 0x004366A4
	public void MDIEOMOCHNC()
	{
		this.rope = true;
		GameObject[] array = this.joints;
		for (int i = 1; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[1];
		this.joints = new GameObject[1];
		this.segments = 1;
	}

	// Token: 0x060097B6 RID: 38838 RVA: 0x00438500 File Offset: 0x00436700
	private void MCOGNGICDKI(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("wpn_add/addoptions/klevprop" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(313f, 386f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = true;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097B7 RID: 38839 RVA: 0x00438684 File Offset: 0x00436884
	private void BAFLKIAOLFK()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[0].isKinematic)
			{
				this.joints[1].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097B8 RID: 38840 RVA: 0x00438718 File Offset: 0x00436918
	public void BuildRope()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 1;
		Debug.Log("ROPE dst=" + num);
		Debug.Log("ROPE segments=" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[0] = base.transform.position;
		this.segmentPos[this.segments - 1] = this.target.position;
		int num2 = this.segments - 1;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i++)
		{
			Vector3 vector = a * (float)(i - 1) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 1)
			{
				this.NNIIGGGJIHG(i, a.magnitude, false);
			}
			else
			{
				this.NNIIGGGJIHG(i, a.magnitude, false);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = false;
		characterJoint.connectedBody = this.joints[this.joints.Length - 1].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(0f, 0f, 0.001f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = true;
	}

	// Token: 0x060097B9 RID: 38841 RVA: 0x00438984 File Offset: 0x00436B84
	private void NCAPIDNNCLP()
	{
		if (this.rope)
		{
			if (this.joints[0] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 0] != null)
			{
				this.joints[this.segments - 0].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097BA RID: 38842 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JLFBDOPFDDJ()
	{
	}

	// Token: 0x060097BB RID: 38843 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CKPNKKFIINO()
	{
	}

	// Token: 0x060097BC RID: 38844 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OAKCEHBONIP()
	{
	}

	// Token: 0x060097BD RID: 38845 RVA: 0x00438A18 File Offset: 0x00436C18
	public void HMGKCGFONPO()
	{
		this.rope = false;
		GameObject[] array = this.joints;
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[1];
		this.joints = new GameObject[1];
		this.segments = 1;
	}

	// Token: 0x060097BE RID: 38846 RVA: 0x00438A74 File Offset: 0x00436C74
	private void PHAFHEJJKOO(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("error" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(1590f, 1805f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = true;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = true;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097BF RID: 38847 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GCNGEFBKMNC()
	{
	}

	// Token: 0x060097C0 RID: 38848 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BNKJNBIDPME()
	{
	}

	// Token: 0x060097C1 RID: 38849 RVA: 0x00438BF8 File Offset: 0x00436DF8
	public void JHOJKKMHMAF()
	{
		this.rope = false;
		foreach (GameObject gameObject in this.joints)
		{
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[1];
		this.joints = new GameObject[1];
		this.segments = 0;
	}

	// Token: 0x060097C2 RID: 38850 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JBFJPNKLLKI()
	{
	}

	// Token: 0x060097C3 RID: 38851 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AIAMIFEPALP()
	{
	}

	// Token: 0x060097C4 RID: 38852 RVA: 0x00438C54 File Offset: 0x00436E54
	private void JABKJENCEME(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("https://www.youtube.com/watch?v=eP9-zycoHLk" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(75f, 1878f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = false;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = true;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097C5 RID: 38853 RVA: 0x00438DD8 File Offset: 0x00436FD8
	private void FHNNNFLFFJN(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("MotorbikeLassoBack" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(670f, 883f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = true;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 1) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 1].GetComponent<Rigidbody>());
	}

	// Token: 0x060097C6 RID: 38854 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FDGKDLHLIPC()
	{
	}

	// Token: 0x060097C7 RID: 38855 RVA: 0x00438F5C File Offset: 0x0043715C
	private void DJFOLELBLGB()
	{
		if (this.rope)
		{
			if (this.joints[0] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[1].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097C8 RID: 38856 RVA: 0x00438FED File Offset: 0x004371ED
	private void ILKILNGAEKK()
	{
		this.AIFNIJCACKP();
	}

	// Token: 0x060097C9 RID: 38857 RVA: 0x00438FF8 File Offset: 0x004371F8
	private void PBLEIIOEHFN()
	{
		if (this.rope)
		{
			if (this.joints[0] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 0] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097CA RID: 38858 RVA: 0x0043908C File Offset: 0x0043728C
	private void ELDPILKNKBA()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 0].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097CB RID: 38859 RVA: 0x00439120 File Offset: 0x00437320
	private void LCMENBIFHNC()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[1].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 0] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097CC RID: 38860 RVA: 0x004391B4 File Offset: 0x004373B4
	public void LJGLNDDJFPO()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 0;
		Debug.Log("post_8" + num);
		Debug.Log(", " + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[0] = base.transform.position;
		this.segmentPos[this.segments - 1] = this.target.position;
		int num2 = this.segments - 0;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i += 0)
		{
			Vector3 vector = a * (float)(i - 0) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 1)
			{
				this.DNMJJJMFLGH(i, a.magnitude, false);
			}
			else
			{
				this.BOMODOCEKPM(i, a.magnitude, false);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = false;
		characterJoint.connectedBody = this.joints[this.joints.Length - 1].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(729f, 192f, 1650f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = false;
	}

	// Token: 0x060097CD RID: 38861 RVA: 0x00439420 File Offset: 0x00437620
	public void CILKDHPEFEE()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 1;
		Debug.Log(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package." + num);
		Debug.Log("Giant2HandSlamSwing" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[1] = base.transform.position;
		this.segmentPos[this.segments - 0] = this.target.position;
		int num2 = this.segments - 1;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i += 0)
		{
			Vector3 vector = a * (float)(i - 1) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 0)
			{
				this.PHAFHEJJKOO(i, a.magnitude, false);
			}
			else
			{
				this.FHNNNFLFFJN(i, a.magnitude, false);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = true;
		characterJoint.connectedBody = this.joints[this.joints.Length - 1].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(1198f, 299f, 733f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = true;
	}

	// Token: 0x060097CE RID: 38862 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JDICIPNCLGJ()
	{
	}

	// Token: 0x060097CF RID: 38863 RVA: 0x0043968C File Offset: 0x0043788C
	private void FJDNHAEHFID()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[0].isKinematic)
			{
				this.joints[1].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 0].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097D0 RID: 38864 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GFELHLPHCDN()
	{
	}

	// Token: 0x060097D1 RID: 38865 RVA: 0x00439720 File Offset: 0x00437920
	private void NNIIGGGJIHG(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("Joint_" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(0f, 0f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = true;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = true;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 1) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 1].GetComponent<Rigidbody>());
	}

	// Token: 0x060097D2 RID: 38866 RVA: 0x004398A4 File Offset: 0x00437AA4
	public void BILJPCOBEHG()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 1;
		Debug.Log("Assets/Weapons/baseLegs.unity3d" + num);
		Debug.Log("Giant3HitCombo2" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[0] = base.transform.position;
		this.segmentPos[this.segments - 1] = this.target.position;
		int num2 = this.segments - 1;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i += 0)
		{
			Vector3 vector = a * (float)(i - 1) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 1)
			{
				this.MCAPNPCIOLP(i, a.magnitude, false);
			}
			else
			{
				this.FHNNNFLFFJN(i, a.magnitude, true);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = false;
		characterJoint.connectedBody = this.joints[this.joints.Length - 0].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(1536f, 58f, 226f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = true;
	}

	// Token: 0x060097D3 RID: 38867 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IAJCKOGDIMM()
	{
	}

	// Token: 0x060097D4 RID: 38868 RVA: 0x00439B10 File Offset: 0x00437D10
	private void BOFFDHKNKEP(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("http://www.root-motion.com/finalikdox/html/page5.html" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(881f, 72f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = false;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = true;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097D5 RID: 38869 RVA: 0x00022FCC File Offset: 0x000211CC
	private void POMLHOHFIGA()
	{
	}

	// Token: 0x060097D6 RID: 38870 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AKLFCMNCPKL()
	{
	}

	// Token: 0x060097D7 RID: 38871 RVA: 0x00439C94 File Offset: 0x00437E94
	private void ACDHFDDHHLG(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("CardPlayerLook" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(875f, 108f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = true;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = true;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097D8 RID: 38872 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DHIJGNHBMFJ()
	{
	}

	// Token: 0x060097D9 RID: 38873 RVA: 0x00439E18 File Offset: 0x00438018
	private void JMPGFNNBIGO()
	{
		this.PBLEIIOEHFN();
	}

	// Token: 0x060097DA RID: 38874 RVA: 0x00439E20 File Offset: 0x00438020
	private void MEAJKAFIIMP(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("_Parameter" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(815f, 1206f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = false;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 1) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097DB RID: 38875 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KJJEEMEHGBF()
	{
	}

	// Token: 0x060097DC RID: 38876 RVA: 0x00438FED File Offset: 0x004371ED
	private void FixedUpdate()
	{
		this.AIFNIJCACKP();
	}

	// Token: 0x060097DD RID: 38877 RVA: 0x00439FA4 File Offset: 0x004381A4
	private void LBKABAKGHCB(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("3" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(193f, 1147f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = true;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097DE RID: 38878 RVA: 0x0043A128 File Offset: 0x00438328
	private void AIFNIJCACKP()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[1].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097DF RID: 38879 RVA: 0x0043A1BC File Offset: 0x004383BC
	private void BOPPOEMPHHJ()
	{
		if (this.rope)
		{
			if (this.joints[0] != null && !this.rbodies[0].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 0].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097E0 RID: 38880 RVA: 0x0043A250 File Offset: 0x00438450
	private void BOMODOCEKPM(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("_Cull" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(131f, 1712f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = false;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097E1 RID: 38881 RVA: 0x0043A3D4 File Offset: 0x004385D4
	public void DDPIFHIJIJD()
	{
		this.rope = false;
		foreach (GameObject gameObject in this.joints)
		{
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[1];
		this.joints = new GameObject[1];
		this.segments = 1;
	}

	// Token: 0x060097E2 RID: 38882 RVA: 0x0043A430 File Offset: 0x00438630
	private void LDOLEFLLIDN()
	{
		if (this.rope)
		{
			if (this.joints[0] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 0] != null)
			{
				this.joints[this.segments - 0].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097E3 RID: 38883 RVA: 0x0043A4C4 File Offset: 0x004386C4
	public void PBGLOGLEEBA()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 0;
		Debug.Log("[LH &]" + num);
		Debug.Log("WeaponReady" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[1] = base.transform.position;
		this.segmentPos[this.segments - 0] = this.target.position;
		int num2 = this.segments - 1;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i++)
		{
			Vector3 vector = a * (float)(i - 1) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 0)
			{
				this.BOFFDHKNKEP(i, a.magnitude, true);
			}
			else
			{
				this.EOCMHMCCMEN(i, a.magnitude, true);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = false;
		characterJoint.connectedBody = this.joints[this.joints.Length - 0].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(495f, 1286f, 243f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = true;
	}

	// Token: 0x060097E4 RID: 38884 RVA: 0x0043A730 File Offset: 0x00438930
	private void EOCMHMCCMEN(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("VIGNETTE_FILMIC" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(643f, 1784f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = true;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 1) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 1].GetComponent<Rigidbody>());
	}

	// Token: 0x060097E5 RID: 38885 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Awake()
	{
	}

	// Token: 0x060097E6 RID: 38886 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MPLCAGFGEBO()
	{
	}

	// Token: 0x060097E7 RID: 38887 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ONMFGDAKHHC()
	{
	}

	// Token: 0x060097E8 RID: 38888 RVA: 0x0043A8B4 File Offset: 0x00438AB4
	public void OLFGEKFIJIE()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 0;
		Debug.Log("BackPackSearch" + num);
		Debug.Log("RollerBladeFrontFlip" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[0] = base.transform.position;
		this.segmentPos[this.segments - 1] = this.target.position;
		int num2 = this.segments - 0;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i++)
		{
			Vector3 vector = a * (float)(i - 1) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 0)
			{
				this.FHNNNFLFFJN(i, a.magnitude, true);
			}
			else
			{
				this.JABKJENCEME(i, a.magnitude, false);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = true;
		characterJoint.connectedBody = this.joints[this.joints.Length - 1].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(1326f, 659f, 582f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = true;
	}

	// Token: 0x060097E9 RID: 38889 RVA: 0x0043AB20 File Offset: 0x00438D20
	public void DestroyRope()
	{
		this.rope = false;
		foreach (GameObject gameObject in this.joints)
		{
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[0];
		this.joints = new GameObject[0];
		this.segments = 0;
	}

	// Token: 0x060097EA RID: 38890 RVA: 0x0043AB7B File Offset: 0x00438D7B
	private void NMLBOIJFMMB()
	{
		this.NCAPIDNNCLP();
	}

	// Token: 0x060097EB RID: 38891 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DFFOEGHGPGP()
	{
	}

	// Token: 0x060097EC RID: 38892 RVA: 0x0043AB84 File Offset: 0x00438D84
	private void GKNDGCJKNLN()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 0] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097ED RID: 38893 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JMNLEBAPHNJ()
	{
	}

	// Token: 0x060097EE RID: 38894 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x060097EF RID: 38895 RVA: 0x0043AC15 File Offset: 0x00438E15
	private void JMHIGAEEMCH()
	{
		this.BOPPOEMPHHJ();
	}

	// Token: 0x060097F0 RID: 38896 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OGKOHLPFBED()
	{
	}

	// Token: 0x060097F2 RID: 38898 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FAKMOCKLLHF()
	{
	}

	// Token: 0x060097F3 RID: 38899 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GCJBBACOJJE()
	{
	}

	// Token: 0x060097F4 RID: 38900 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIKGIJEHGAP()
	{
	}

	// Token: 0x060097F5 RID: 38901 RVA: 0x0043ACA4 File Offset: 0x00438EA4
	private void DNMJJJMFLGH(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("_WhiteBalance" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(1339f, 476f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = false;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 1].GetComponent<Rigidbody>());
	}

	// Token: 0x060097F6 RID: 38902 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CFHDJOKLHDB()
	{
	}

	// Token: 0x060097F7 RID: 38903 RVA: 0x0043AE28 File Offset: 0x00439028
	public void EKGGKPEOPBO()
	{
		this.rope = true;
		GameObject[] array = this.joints;
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[0];
		this.joints = new GameObject[0];
		this.segments = 1;
	}

	// Token: 0x060097F8 RID: 38904 RVA: 0x0043AE84 File Offset: 0x00439084
	public void KFBBGGNCACB()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 0;
		Debug.Log("rollTENSION=" + num);
		Debug.Log("isMoving" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[1] = base.transform.position;
		this.segmentPos[this.segments - 0] = this.target.position;
		int num2 = this.segments - 1;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 0; i < this.segments; i += 0)
		{
			Vector3 vector = a * (float)(i - 1) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 1)
			{
				this.EOCMHMCCMEN(i, a.magnitude, false);
			}
			else
			{
				this.EOCMHMCCMEN(i, a.magnitude, true);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = false;
		characterJoint.connectedBody = this.joints[this.joints.Length - 0].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(1294f, 1787f, 871f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = true;
	}

	// Token: 0x060097F9 RID: 38905 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PBFKCKCHEAC()
	{
	}

	// Token: 0x060097FA RID: 38906 RVA: 0x0043B0F0 File Offset: 0x004392F0
	private void DOBMFIJLDIG()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[0].isKinematic)
			{
				this.joints[1].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097FB RID: 38907 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MBKLIKGAKJB()
	{
	}

	// Token: 0x060097FC RID: 38908 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DKOIOBMMAGN()
	{
	}

	// Token: 0x060097FD RID: 38909 RVA: 0x0043B184 File Offset: 0x00439384
	private void KFKGJFMAPBP(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("Staff Heal" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(337f, 1329f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = false;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x060097FE RID: 38910 RVA: 0x0043B308 File Offset: 0x00439508
	private void BNOFHHJLIHN()
	{
		if (this.rope)
		{
			if (this.joints[0] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[1].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x060097FF RID: 38911 RVA: 0x0043B39C File Offset: 0x0043959C
	private void AOEAKAAJIFB()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[0].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 0] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x06009800 RID: 38912 RVA: 0x0043B42D File Offset: 0x0043962D
	private void NODEIKKHMDB()
	{
		this.CJEMOCDNALN();
	}

	// Token: 0x06009801 RID: 38913 RVA: 0x0043B438 File Offset: 0x00439638
	private void BLBAFFNBOEE()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[1].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 1] != null)
			{
				this.joints[this.segments - 0].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x06009802 RID: 38914 RVA: 0x0043B4CC File Offset: 0x004396CC
	private void CJEMOCDNALN()
	{
		if (this.rope)
		{
			if (this.joints[1] != null && !this.rbodies[0].isKinematic)
			{
				this.joints[0].transform.position = base.transform.position;
			}
			if (this.joints[this.segments - 0] != null)
			{
				this.joints[this.segments - 1].transform.position = this.target.transform.position;
			}
		}
	}

	// Token: 0x06009803 RID: 38915 RVA: 0x0043B560 File Offset: 0x00439760
	public void AFGNADBMEMG()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 0;
		Debug.Log("Hand stand" + num);
		Debug.Log("\n" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[1] = base.transform.position;
		this.segmentPos[this.segments - 0] = this.target.position;
		int num2 = this.segments - 1;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i++)
		{
			Vector3 vector = a * (float)(i - 0) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 1)
			{
				this.JABKJENCEME(i, a.magnitude, true);
			}
			else
			{
				this.EOCMHMCCMEN(i, a.magnitude, false);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = true;
		characterJoint.connectedBody = this.joints[this.joints.Length - 0].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(650f, 1082f, 1128f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = true;
	}

	// Token: 0x06009804 RID: 38916 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OEFDEEOHNJB()
	{
	}

	// Token: 0x06009805 RID: 38917 RVA: 0x0043B7CC File Offset: 0x004399CC
	private void JONDNFFIGLJ(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("Couldn't get avatar." + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(190f, 1483f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = false;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = false;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 1) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x06009806 RID: 38918 RVA: 0x0043B950 File Offset: 0x00439B50
	private void PHNCOOACJEA()
	{
		this.LDOLEFLLIDN();
	}

	// Token: 0x06009807 RID: 38919 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PFPPDNHLCCA()
	{
	}

	// Token: 0x06009808 RID: 38920 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GPEFDPEAMNE()
	{
	}

	// Token: 0x06009809 RID: 38921 RVA: 0x0043B958 File Offset: 0x00439B58
	public void JIHLNCGMGAE()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 0;
		Debug.Log("OfficeSittingReadingLeanBack" + num);
		Debug.Log("RollerBladeRoll" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[1] = base.transform.position;
		this.segmentPos[this.segments - 1] = this.target.position;
		int num2 = this.segments - 0;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i += 0)
		{
			Vector3 vector = a * (float)(i - 0) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 1)
			{
				this.PHAFHEJJKOO(i, a.magnitude, true);
			}
			else
			{
				this.MCAPNPCIOLP(i, a.magnitude, true);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = true;
		characterJoint.connectedBody = this.joints[this.joints.Length - 0].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(1707f, 1945f, 1656f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = false;
	}

	// Token: 0x0600980A RID: 38922 RVA: 0x0043BBC4 File Offset: 0x00439DC4
	private void HLKJKCKBELP()
	{
		this.DJFOLELBLGB();
	}

	// Token: 0x0600980B RID: 38923 RVA: 0x0043BBCC File Offset: 0x00439DCC
	public void FBBFFKDKBFL()
	{
		this.rope = true;
		GameObject[] array = this.joints;
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[1];
		this.joints = new GameObject[0];
		this.segments = 0;
	}

	// Token: 0x0600980C RID: 38924 RVA: 0x00022FCC File Offset: 0x000211CC
	private void APHJJJHNFNP()
	{
	}

	// Token: 0x0600980D RID: 38925 RVA: 0x0043BC28 File Offset: 0x00439E28
	private void LFOICEKDLIG(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("<color=blue>$&</color>" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(971f, 1770f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = true;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = true;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x0600980E RID: 38926 RVA: 0x0043BDAC File Offset: 0x00439FAC
	private void MCAPNPCIOLP(int BICDCKJBJLP, float GADFHLLJKOH, bool PJNBHFIKLMM)
	{
		this.joints[BICDCKJBJLP] = new GameObject("MotorbikeShootFwd" + BICDCKJBJLP);
		if (this.catalog != null)
		{
			this.joints[BICDCKJBJLP].transform.parent = this.catalog.transform;
		}
		else
		{
			this.joints[BICDCKJBJLP].transform.parent = base.transform;
		}
		Rigidbody rigidbody = this.joints[BICDCKJBJLP].AddComponent<Rigidbody>();
		this.rbodies[BICDCKJBJLP] = rigidbody;
		CharacterJoint characterJoint = this.joints[BICDCKJBJLP].AddComponent<CharacterJoint>();
		this.jntsc[BICDCKJBJLP] = characterJoint;
		characterJoint.autoConfigureConnectedAnchor = PJNBHFIKLMM;
		if (!PJNBHFIKLMM)
		{
			characterJoint.connectedAnchor = new Vector3(1819f, 58f, GADFHLLJKOH);
		}
		characterJoint.swingAxis = this.swingAxis;
		characterJoint.enableProjection = false;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.joints[BICDCKJBJLP].transform.position = this.segmentPos[BICDCKJBJLP];
		rigidbody.useGravity = true;
		rigidbody.drag = this.ropeDrag;
		rigidbody.mass = this.ropeMass;
		characterJoint.connectedBody = ((BICDCKJBJLP == 0) ? base.transform.GetComponent<Rigidbody>() : this.joints[BICDCKJBJLP - 0].GetComponent<Rigidbody>());
	}

	// Token: 0x0600980F RID: 38927 RVA: 0x0043BF30 File Offset: 0x0043A130
	public void KMFGAINGIOE()
	{
		this.rope = false;
		foreach (GameObject gameObject in this.joints)
		{
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.segmentPos = new Vector3[0];
		this.joints = new GameObject[1];
		this.segments = 1;
	}

	// Token: 0x06009810 RID: 38928 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GJKCGGCCIAJ()
	{
	}

	// Token: 0x06009811 RID: 38929 RVA: 0x0043BF8C File Offset: 0x0043A18C
	public void LCGNPOIOINN()
	{
		this.line = base.gameObject.GetComponent<LineRenderer>();
		float num = Vector3.Distance(base.transform.position, this.target.position);
		this.segments = this.basesegmets;
		this.line.positionCount = this.segments + 0;
		Debug.Log("UnityEngine.Vector2" + num);
		Debug.Log("Cowboy1HandDraw" + this.segments);
		this.segmentPos = new Vector3[this.segments];
		this.joints = new GameObject[this.segments];
		this.rbodies = new Rigidbody[this.segments];
		this.jntsc = new CharacterJoint[this.segments];
		this.segmentPos[1] = base.transform.position;
		this.segmentPos[this.segments - 0] = this.target.position;
		int num2 = this.segments - 0;
		Vector3 a = (this.target.position - base.transform.position) / (float)num2;
		for (int i = 1; i < this.segments; i++)
		{
			Vector3 vector = a * (float)(i - 1) + base.transform.position;
			this.segmentPos[i] = vector;
			if (i == 1)
			{
				this.DNMJJJMFLGH(i, a.magnitude, false);
			}
			else
			{
				this.MEAJKAFIIMP(i, a.magnitude, false);
			}
		}
		CharacterJoint characterJoint = this.target.gameObject.GetComponent<CharacterJoint>();
		if (characterJoint == null)
		{
			characterJoint = this.target.gameObject.AddComponent<CharacterJoint>();
		}
		characterJoint.autoConfigureConnectedAnchor = true;
		characterJoint.connectedBody = this.joints[this.joints.Length - 0].transform.GetComponent<Rigidbody>();
		characterJoint.connectedAnchor = new Vector3(1615f, 370f, 802f);
		characterJoint.swingAxis = this.swingAxis;
		SoftJointLimit softJointLimit = characterJoint.lowTwistLimit;
		softJointLimit.limit = this.lowTwistLimit;
		characterJoint.lowTwistLimit = softJointLimit;
		softJointLimit = characterJoint.highTwistLimit;
		softJointLimit.limit = this.highTwistLimit;
		characterJoint.highTwistLimit = softJointLimit;
		softJointLimit = characterJoint.swing1Limit;
		softJointLimit.limit = this.swing1Limit;
		characterJoint.swing1Limit = softJointLimit;
		this.rope = true;
	}

	// Token: 0x06009812 RID: 38930 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CBBLGEDCJBF()
	{
	}

	// Token: 0x040013C8 RID: 5064
	public Transform target;

	// Token: 0x040013C9 RID: 5065
	public Transform catalog;

	// Token: 0x040013CA RID: 5066
	public float waterLevel;

	// Token: 0x040013CB RID: 5067
	public int basesegmets = 100;

	// Token: 0x040013CC RID: 5068
	public float resolution = 0.5f;

	// Token: 0x040013CD RID: 5069
	public float ropeDrag = 0.1f;

	// Token: 0x040013CE RID: 5070
	public float ropeMass = 0.1f;

	// Token: 0x040013CF RID: 5071
	public float ropeColRadius = 0.5f;

	// Token: 0x040013D0 RID: 5072
	public Vector3[] segmentPos;

	// Token: 0x040013D1 RID: 5073
	public GameObject[] joints;

	// Token: 0x040013D2 RID: 5074
	public Rigidbody[] rbodies;

	// Token: 0x040013D3 RID: 5075
	public CharacterJoint[] jntsc;

	// Token: 0x040013D4 RID: 5076
	public LineRenderer line;

	// Token: 0x040013D5 RID: 5077
	public int segments;

	// Token: 0x040013D6 RID: 5078
	public bool rope;

	// Token: 0x040013D7 RID: 5079
	public Vector3 swingAxis = new Vector3(1f, 1f, 1f);

	// Token: 0x040013D8 RID: 5080
	public float lowTwistLimit = -100f;

	// Token: 0x040013D9 RID: 5081
	public float highTwistLimit = 100f;

	// Token: 0x040013DA RID: 5082
	public float swing1Limit = 20f;
}
