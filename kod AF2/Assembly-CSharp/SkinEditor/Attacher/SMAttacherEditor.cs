using System;
using System.Collections.Generic;
using UnityEngine;

namespace SkinEditor.Attacher
{
	// Token: 0x020002A2 RID: 674
	public class SMAttacherEditor : MonoBehaviour
	{
		// Token: 0x06009E50 RID: 40528 RVA: 0x0046D7B0 File Offset: 0x0046B9B0
		public void IFKHCAOIDMM()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "isMoving";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x0046D8E4 File Offset: 0x0046BAE4
		public void JLAPJAFHAEJ()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x0046DA18 File Offset: 0x0046BC18
		public void MDOHOCBOHGG()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "\n";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x0046DB4C File Offset: 0x0046BD4C
		public void HIJKLHHDDFK()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "VaderChoke";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x0046DC80 File Offset: 0x0046BE80
		public void MCGENLKPFNA()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "UIChat_pos";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x0046DDB4 File Offset: 0x0046BFB4
		public void MIEFHJIGKKG()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "_FoamContrast";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x0046DEE8 File Offset: 0x0046C0E8
		public void BAFBDMCLLLB()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "Failed parsing rotationPlacement.  Setting to \"Fixed\"";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E57 RID: 40535 RVA: 0x0046E01C File Offset: 0x0046C21C
		public void JBEAIMHJKIF()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "_Cull";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x0046E150 File Offset: 0x0046C350
		public void DLDMPLENAHK()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "inv_pcs1";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x0046E284 File Offset: 0x0046C484
		public void MAKLCKFBKMM()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "cntx_drop";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x0046E3B8 File Offset: 0x0046C5B8
		public void EFHGEAMDGMB()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "Down Index:";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x0046E4EC File Offset: 0x0046C6EC
		public void MFBEENODPCA()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x0046E620 File Offset: 0x0046C820
		public void APBHHFNPDAA()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "Hidden/Amplify Color/Blend";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E5D RID: 40541 RVA: 0x0046E754 File Offset: 0x0046C954
		public void PDFGMNGIEEK()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "Null";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x0046E888 File Offset: 0x0046CA88
		public void FBKIJAJNNEL()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "DISTORT";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E5F RID: 40543 RVA: 0x0046E9BC File Offset: 0x0046CBBC
		public void FJKBCJGFDBI()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "PaperTurn.wav";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x0046EAF0 File Offset: 0x0046CCF0
		public void PLNNCPNECKF()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x0046EC24 File Offset: 0x0046CE24
		public void JBKMHNCPGGG()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "CP0";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E62 RID: 40546 RVA: 0x0046ED58 File Offset: 0x0046CF58
		public void GPIPNJMCDME()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "\n";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x0046EE8C File Offset: 0x0046D08C
		public void PLPPNEMPFBM()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "</color>\n";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E64 RID: 40548 RVA: 0x0046EFC0 File Offset: 0x0046D1C0
		public void HOOIBHMCEDD()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "ShotgunReloadMagazine";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E66 RID: 40550 RVA: 0x0046F0F4 File Offset: 0x0046D2F4
		public void AKBICNNNLBA()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = " already has ";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E67 RID: 40551 RVA: 0x0046F228 File Offset: 0x0046D428
		public void KBDHHCENCIC()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "[maxcnt]";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E68 RID: 40552 RVA: 0x0046F35C File Offset: 0x0046D55C
		public void FHLKPDDABFE()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "_VelocityTex";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x0046F490 File Offset: 0x0046D690
		[ContextMenu("*** Attach")]
		public void Attach()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "Attached object";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x0046F5C4 File Offset: 0x0046D7C4
		public void MJKNGDILDEA()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "Sitting Reading";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x0046F6F8 File Offset: 0x0046D8F8
		public void DCJAFIHMBOA()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "Giant2HandSlamIdle";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x0046F82C File Offset: 0x0046DA2C
		public void LDCCHKKLGFJ()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "Item_Sell.ogg";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E6D RID: 40557 RVA: 0x0046F960 File Offset: 0x0046DB60
		public void PHKOBPEGNIL()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "hand";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x0046FA94 File Offset: 0x0046DC94
		public void DICKADALDLH()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "_Lift";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E6F RID: 40559 RVA: 0x0046FBC8 File Offset: 0x0046DDC8
		public void KMOEIGMLGKF()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = "t_hair";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E70 RID: 40560 RVA: 0x0046FCFC File Offset: 0x0046DEFC
		public void KGPLMGAHIDF()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "close";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E71 RID: 40561 RVA: 0x0046FE30 File Offset: 0x0046E030
		public void OCLBBKPOMOP()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 0)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "WeaponStab";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = false;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x0046FF64 File Offset: 0x0046E164
		public void BOADKGGPMIC()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, false);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[1];
			this.dress.name = ": ";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = false;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x00470098 File Offset: 0x0046E298
		public void OBLAGFIPJNB()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attachedPrefab, default(Vector3), default(Quaternion));
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.rootBone, true);
			if (this.dress != null)
			{
				UnityEngine.Object.DestroyImmediate(this.dress);
			}
			if (list.Count <= 1)
			{
				return;
			}
			this.dress = list[0];
			this.dress.name = "Climbing Idle";
			SkinnedMeshRenderer component = this.dress.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				component.rootBone = this.rootBone;
				component.updateWhenOffscreen = true;
			}
			if (this.catalog != null)
			{
				this.dress.transform.parent = this.catalog.transform;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].transform.parent = this.dress.transform;
				SkinnedMeshRenderer component2 = list[i].GetComponent<SkinnedMeshRenderer>();
				if (component2 != null)
				{
					component2.rootBone = this.rootBone;
					component2.updateWhenOffscreen = true;
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
		}

		// Token: 0x04001490 RID: 5264
		public GameObject catalog;

		// Token: 0x04001491 RID: 5265
		public Transform rootBone;

		// Token: 0x04001492 RID: 5266
		public GameObject attachedPrefab;

		// Token: 0x04001493 RID: 5267
		public GameObject dress;
	}
}
