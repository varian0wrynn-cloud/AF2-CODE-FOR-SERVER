using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002D0 RID: 720
	public class DragRigidbody : MonoBehaviour
	{
		// Token: 0x0600A8E6 RID: 43238 RVA: 0x004B3820 File Offset: 0x004B1A20
		private void EHDFKHHOHAD()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.GFJBFIILJON();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 772f, 119))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 425f;
			this.AOLJFAMMAFO.damper = 1187f;
			this.AOLJFAMMAFO.maxDistance = 370f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("cond", raycastHit.distance);
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera LGOGBABLBAL()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator PBMCDOEGJPI(float DKIHDOELFEH)
		{
			float drag = this.AOLJFAMMAFO.connectedBody.drag;
			float angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			Camera camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A8E9 RID: 43241 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera FKPCDJFKEML()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A8EA RID: 43242 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator LHBDAAAKKCI(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A8EB RID: 43243 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator LPKFCLFDPIF(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator AAFCJFCBEED(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera GPNODDJMKIH()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A8EE RID: 43246 RVA: 0x004B3994 File Offset: 0x004B1B94
		private void AFHBOLFGJNE()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.FAFLPAMNLEA();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 706f, 108))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("showUsersInChat");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1806f;
			this.AOLJFAMMAFO.damper = 1130f;
			this.AOLJFAMMAFO.maxDistance = 621f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("{0}/{1}", raycastHit.distance);
		}

		// Token: 0x0600A8EF RID: 43247 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera KDCFHCEDIKH()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A8F0 RID: 43248 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera CBKCADBKDNL()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x004B3AC0 File Offset: 0x004B1CC0
		private void NFPFDOEENLA()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.BEALGBKLEGA();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 814f, 63))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject(" ");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 518f;
			this.AOLJFAMMAFO.damper = 1106f;
			this.AOLJFAMMAFO.maxDistance = 1580f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("Add random value", raycastHit.distance);
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator HAILIMAIHFK(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x004B3BEC File Offset: 0x004B1DEC
		private void JPHLMNIMDHH()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.FKMBDMLLKDK();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 214f, 121))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1533f;
			this.AOLJFAMMAFO.damper = 1537f;
			this.AOLJFAMMAFO.maxDistance = 663f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("_1.png", raycastHit.distance);
		}

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator OGMININMBBM(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x004B3D18 File Offset: 0x004B1F18
		private void GCCAPOHGAHA()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.BEALGBKLEGA();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 345f, -20))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 952f;
			this.AOLJFAMMAFO.damper = 1570f;
			this.AOLJFAMMAFO.maxDistance = 1019f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("Hip", raycastHit.distance);
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera EHMFHCOOBDN()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator BFGNPHDENMK(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A8F8 RID: 43256 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera HAOMFGCNGKB()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator PODAMCAMINN(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera FGLOIHAIGEM()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator MMIJDIOHABO(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator GKCGLGLHDBE(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x004B3E44 File Offset: 0x004B2044
		private void KMLNBHIIGKH()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.MMHHIEIANGO();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1071f, -110))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("PistolLeftHandStab");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 729f;
			this.AOLJFAMMAFO.damper = 412f;
			this.AOLJFAMMAFO.maxDistance = 1871f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("ragulaFider", raycastHit.distance);
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator EFIOLGKPLMB(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator LDJOCOKHHCG(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x004B3F70 File Offset: 0x004B2170
		private void BEDAJLJFAFO()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.MGBFJDFEOAK();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1303f, 12))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("OfficeSittingHandRestFingerTap");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1938f;
			this.AOLJFAMMAFO.damper = 946f;
			this.AOLJFAMMAFO.maxDistance = 1670f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("ClimbLeft", raycastHit.distance);
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera LOHOJFJMKFD()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera NLAOGIGBMHF()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera JHOMJMMJLLI()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera GDDKFBMADDC()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator OEBLEECFODM(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera GFJBFIILJON()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera MCEMLMNGKPG()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera EOPLLPFCGKH()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x004B409C File Offset: 0x004B229C
		private void OPDCJCFMIPE()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.KDCFHCEDIKH();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1758f, -93))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("Mouse X");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 815f;
			this.AOLJFAMMAFO.damper = 1074f;
			this.AOLJFAMMAFO.maxDistance = 22f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("Horizontal", raycastHit.distance);
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera GMEIDLKDNKM()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera GPDGPBFHKKF()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x004B41C8 File Offset: 0x004B23C8
		private void MFHGOLNLAAF()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.LONGNHHFDCA();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1499f, 41))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("help");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 738f;
			this.AOLJFAMMAFO.damper = 931f;
			this.AOLJFAMMAFO.maxDistance = 1618f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("IdleSlide", raycastHit.distance);
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x004B42F4 File Offset: 0x004B24F4
		private void DAFJMNMFOON()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.FKPCDJFKEML();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 904f, 82))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject(",");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 441f;
			this.AOLJFAMMAFO.damper = 854f;
			this.AOLJFAMMAFO.maxDistance = 1103f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("WireframeFore", raycastHit.distance);
		}

		// Token: 0x0600A90F RID: 43279 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator MDNLCLHHFMH(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A910 RID: 43280 RVA: 0x004B4420 File Offset: 0x004B2620
		private void PGIHAIPCJLL()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.MNKJFANPLJE();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1514f, 85))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("demoVector2");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 684f;
			this.AOLJFAMMAFO.damper = 1639f;
			this.AOLJFAMMAFO.maxDistance = 104f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("_BlurVector", raycastHit.distance);
		}

		// Token: 0x0600A911 RID: 43281 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator NBAAJBBGCMC(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A912 RID: 43282 RVA: 0x004B454C File Offset: 0x004B274C
		private void NMMGHFDLNOE()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.IBONLANHNAP();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1245f, 84))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("1 Hand Sword Strafe Right");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 937f;
			this.AOLJFAMMAFO.damper = 531f;
			this.AOLJFAMMAFO.maxDistance = 807f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("RHandPunch", raycastHit.distance);
		}

		// Token: 0x0600A913 RID: 43283 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera MKBNAGNLGCB()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A914 RID: 43284 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera KPGGLOOGELG()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A915 RID: 43285 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera AJEGKCKKBAG()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A916 RID: 43286 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera KHDELCJBEEP()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A917 RID: 43287 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera KBGONJOGJHF()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A918 RID: 43288 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera EIKGIJDPNMH()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera BILDKPHNOBF()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x004B4678 File Offset: 0x004B2878
		private void CDLDCKAHLHC()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.MNKJFANPLJE();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1160f, 59))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("DITHERING");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 535f;
			this.AOLJFAMMAFO.damper = 3f;
			this.AOLJFAMMAFO.maxDistance = 567f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("---", raycastHit.distance);
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator LGDKMNGJAHD(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator OLEECGECFKK(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A91D RID: 43293 RVA: 0x004B47A4 File Offset: 0x004B29A4
		private void CIBBPIIDHJH()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.BDJOPPNPNCM();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 49f, 107))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("<color='#804020'>");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 353f;
			this.AOLJFAMMAFO.damper = 1096f;
			this.AOLJFAMMAFO.maxDistance = 37f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine(" ", raycastHit.distance);
		}

		// Token: 0x0600A91E RID: 43294 RVA: 0x004B48D0 File Offset: 0x004B2AD0
		private void IOGAKGCADBL()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.GPNODDJMKIH();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1452f, -64))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("206000");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1934f;
			this.AOLJFAMMAFO.damper = 938f;
			this.AOLJFAMMAFO.maxDistance = 1730f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("WizardEyeBeam", raycastHit.distance);
		}

		// Token: 0x0600A91F RID: 43295 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator KAJDCNCEJNJ(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A920 RID: 43296 RVA: 0x004B49FC File Offset: 0x004B2BFC
		private void HABONMJNDAL()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.MKBNAGNLGCB();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1383f, -12))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("Shotgun Reload Chamber");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 825f;
			this.AOLJFAMMAFO.damper = 413f;
			this.AOLJFAMMAFO.maxDistance = 1817f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("MotorbikeSeatStand", raycastHit.distance);
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera MGBFJDFEOAK()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator IBMDEIPLHIO(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A923 RID: 43299 RVA: 0x004B4B28 File Offset: 0x004B2D28
		private void IANJLHIIGLN()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.KDCFHCEDIKH();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 96f, -128))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("{0}.{1}.{2}");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1128f;
			this.AOLJFAMMAFO.damper = 1219f;
			this.AOLJFAMMAFO.maxDistance = 1090f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("OneHandSwordReady", raycastHit.distance);
		}

		// Token: 0x0600A924 RID: 43300 RVA: 0x004B4C54 File Offset: 0x004B2E54
		private void LACNPNKHCAA()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.JHOMJMMJLLI();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1727f, -56))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("iOS");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1738f;
			this.AOLJFAMMAFO.damper = 677f;
			this.AOLJFAMMAFO.maxDistance = 327f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("IdleKeepBack", raycastHit.distance);
		}

		// Token: 0x0600A925 RID: 43301 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator IEBGIJHAMKN(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A926 RID: 43302 RVA: 0x004B4D80 File Offset: 0x004B2F80
		private void HAIMGCDKPDC()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.MMHHIEIANGO();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 276f, -17))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("BEREG!");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1678f;
			this.AOLJFAMMAFO.damper = 641f;
			this.AOLJFAMMAFO.maxDistance = 707f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("ComeHere", raycastHit.distance);
		}

		// Token: 0x0600A927 RID: 43303 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator FAAKFODIKEE(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera KAFKODLKJBD()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera BKOHNDIAAFB()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A92A RID: 43306 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera AOCHEIIDKOA()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A92B RID: 43307 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator HABLMMIBMAF(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A92C RID: 43308 RVA: 0x004B4EAC File Offset: 0x004B30AC
		private void KOLCEBEIHKP()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.KDCFHCEDIKH();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1405f, 57))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("http://j.mp/1gxg1tf");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1467f;
			this.AOLJFAMMAFO.damper = 17f;
			this.AOLJFAMMAFO.maxDistance = 659f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine(" is null.", raycastHit.distance);
		}

		// Token: 0x0600A92D RID: 43309 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera BHJACPMFHFK()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A92E RID: 43310 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera LNAEHOGJIAK()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x004B4FD8 File Offset: 0x004B31D8
		private void BLMBPFIJJBP()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.NHNICKJCALH();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 110f, -103))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("The given 2D texture ");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1351f;
			this.AOLJFAMMAFO.damper = 687f;
			this.AOLJFAMMAFO.maxDistance = 697f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("Worker Pickaxe 2", raycastHit.distance);
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera MOMLKGHPCEE()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator OJCPDKKJIGG(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x004B5104 File Offset: 0x004B3304
		private void OKMAHGAAMHA()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.MNKJFANPLJE();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1255f, 95))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("SwimFreestyle");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 503f;
			this.AOLJFAMMAFO.damper = 1414f;
			this.AOLJFAMMAFO.maxDistance = 3f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("", raycastHit.distance);
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera BDJOPPNPNCM()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator KABCMBFFCME(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A935 RID: 43317 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator EFAOHFGFCME(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A936 RID: 43318 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator KHCCCBODHMK(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x004B5230 File Offset: 0x004B3430
		private void IEOICHPKEMD()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.BKOHNDIAAFB();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 429f, 82))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("crft_norec2");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 844f;
			this.AOLJFAMMAFO.damper = 1087f;
			this.AOLJFAMMAFO.maxDistance = 193f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("Directional", raycastHit.distance);
		}

		// Token: 0x0600A938 RID: 43320 RVA: 0x004B535C File Offset: 0x004B355C
		private void AAEFACEGJMB()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.HJEIEKFKOAH();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1218f, 13))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("RollerBladeGrindRoyale");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 592f;
			this.AOLJFAMMAFO.damper = 1157f;
			this.AOLJFAMMAFO.maxDistance = 83f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("_BumpMap", raycastHit.distance);
		}

		// Token: 0x0600A939 RID: 43321 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera FIIDODFPPAF()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A93A RID: 43322 RVA: 0x004B5488 File Offset: 0x004B3688
		private void OIBIGDFPHGO()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.LGOGBABLBAL();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 938f, 96))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("Cloth_07.wav");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1191f;
			this.AOLJFAMMAFO.damper = 722f;
			this.AOLJFAMMAFO.maxDistance = 1463f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine(" path=", raycastHit.distance);
		}

		// Token: 0x0600A93B RID: 43323 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera FNNJPLNDIKC()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A93C RID: 43324 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera LONGNHHFDCA()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A93D RID: 43325 RVA: 0x004B55B4 File Offset: 0x004B37B4
		private void KJJBBLDJHPD()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.GMEIDLKDNKM();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1751f, 112))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("\n");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1322f;
			this.AOLJFAMMAFO.damper = 644f;
			this.AOLJFAMMAFO.maxDistance = 1564f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("_Phase", raycastHit.distance);
		}

		// Token: 0x0600A93E RID: 43326 RVA: 0x004B56E0 File Offset: 0x004B38E0
		private void KBMKHLDOIKP()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.GPDGPBFHKKF();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 967f, 14))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("_Offsets");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 178f;
			this.AOLJFAMMAFO.damper = 1096f;
			this.AOLJFAMMAFO.maxDistance = 133f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("demoLong", raycastHit.distance);
		}

		// Token: 0x0600A93F RID: 43327 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator FJOKOPDCBFC(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera FKMBDMLLKDK()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera IBONLANHNAP()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A942 RID: 43330 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera FAFLPAMNLEA()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A943 RID: 43331 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator BMGJCMFAEOP(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A944 RID: 43332 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera BCACFHLCDFK()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A945 RID: 43333 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera HNCJIMJDLCN()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x004B580C File Offset: 0x004B3A0C
		private void HMEAENGBFKC()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.HJKPAHPDEFJ();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1135f, 100))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 217f;
			this.AOLJFAMMAFO.damper = 1071f;
			this.AOLJFAMMAFO.maxDistance = 27f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("OfficeSitting1LegStraight", raycastHit.distance);
		}

		// Token: 0x0600A947 RID: 43335 RVA: 0x004B5938 File Offset: 0x004B3B38
		private void HJCLNJLADKL()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.IBONLANHNAP();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1766f, 21))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("\n");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 79f;
			this.AOLJFAMMAFO.damper = 327f;
			this.AOLJFAMMAFO.maxDistance = 797f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("_InverseProj", raycastHit.distance);
		}

		// Token: 0x0600A948 RID: 43336 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator JHCEIKOIADJ(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A949 RID: 43337 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera BEALGBKLEGA()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A94A RID: 43338 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator OMNABFLLDNA(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A94B RID: 43339 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator JADJNHCKCJL(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A94C RID: 43340 RVA: 0x004B397B File Offset: 0x004B1B7B
		private IEnumerator CICIKFAMEMP(float DKIHDOELFEH)
		{
			DragRigidbody.JBIIEALHPKP jbiiealhpkp = new DragRigidbody.JBIIEALHPKP(1);
			jbiiealhpkp.AENJLLPLILM = this;
			jbiiealhpkp.DKIHDOELFEH = DKIHDOELFEH;
			return jbiiealhpkp;
		}

		// Token: 0x0600A94D RID: 43341 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera MMHHIEIANGO()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A94E RID: 43342 RVA: 0x004B5A64 File Offset: 0x004B3C64
		private void PAKOHKKBKHD()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.BEALGBKLEGA();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1111f, 2))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("\n");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 361f;
			this.AOLJFAMMAFO.damper = 833f;
			this.AOLJFAMMAFO.maxDistance = 670f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("isRodInWater", raycastHit.distance);
		}

		// Token: 0x0600A94F RID: 43343 RVA: 0x004B5B90 File Offset: 0x004B3D90
		private void JIBKGOFOPHJ()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.JHOMJMMJLLI();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 919f, 57))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("RodParams not found!");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1781f;
			this.AOLJFAMMAFO.damper = 949f;
			this.AOLJFAMMAFO.maxDistance = 834f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine(" ", raycastHit.distance);
		}

		// Token: 0x0600A950 RID: 43344 RVA: 0x004B5CBC File Offset: 0x004B3EBC
		private void JIFOELPAEHG()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.JNPPCOHGLIK();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 413f, -5))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("repair.ogg");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1379f;
			this.AOLJFAMMAFO.damper = 1192f;
			this.AOLJFAMMAFO.maxDistance = 1214f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("_NeutralTonemapperParams1", raycastHit.distance);
		}

		// Token: 0x0600A951 RID: 43345 RVA: 0x004B5DE8 File Offset: 0x004B3FE8
		private void MEIOHFKFEME()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.KHDELCJBEEP();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 447f, -127))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("&");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1836f;
			this.AOLJFAMMAFO.damper = 1480f;
			this.AOLJFAMMAFO.maxDistance = 1738f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("post_21", raycastHit.distance);
		}

		// Token: 0x0600A952 RID: 43346 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera NHOKLGNGODN()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A953 RID: 43347 RVA: 0x004B5F14 File Offset: 0x004B4114
		private void EDANNBFJHIK()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.FNNJPLNDIKC();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1444f, -50))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("ObscuredString vs string, ");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1320f;
			this.AOLJFAMMAFO.damper = 1962f;
			this.AOLJFAMMAFO.maxDistance = 1597f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("", raycastHit.distance);
		}

		// Token: 0x0600A954 RID: 43348 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera AHGOEOKLGFA()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A955 RID: 43349 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator AGEGDDCKHJJ(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator NKFOOKGHEPP(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A957 RID: 43351 RVA: 0x004B6040 File Offset: 0x004B4240
		private void FJIGNBOFFOJ()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.KAFKODLKJBD();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1681f, -9))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("move");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1888f;
			this.AOLJFAMMAFO.damper = 533f;
			this.AOLJFAMMAFO.maxDistance = 887f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("qd_week", raycastHit.distance);
		}

		// Token: 0x0600A958 RID: 43352 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera HAIONPECEOC()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A959 RID: 43353 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator ANMBHHHGKKJ(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A95A RID: 43354 RVA: 0x004B616C File Offset: 0x004B436C
		private void LBOONMDONCF()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.MCEMLMNGKPG();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 670f, 17))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("Idle Stun");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 276f;
			this.AOLJFAMMAFO.damper = 1097f;
			this.AOLJFAMMAFO.maxDistance = 1342f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("", raycastHit.distance);
		}

		// Token: 0x0600A95B RID: 43355 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator EMACENGFPEB(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A95C RID: 43356 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera NHNICKJCALH()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A95D RID: 43357 RVA: 0x004B6298 File Offset: 0x004B4498
		private void EINLCOFCLLC()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.LGOGBABLBAL();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 624f, -111))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("_CoCTex");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 1890f;
			this.AOLJFAMMAFO.damper = 396f;
			this.AOLJFAMMAFO.maxDistance = 1144f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine(", ", raycastHit.distance);
		}

		// Token: 0x0600A95E RID: 43358 RVA: 0x004B63C4 File Offset: 0x004B45C4
		private void Update()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.EOPLLPFCGKH();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 100f, -5))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("Rigidbody dragger");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 50f;
			this.AOLJFAMMAFO.damper = 5f;
			this.AOLJFAMMAFO.maxDistance = 0.2f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("OMNABFLLDNA", raycastHit.distance);
		}

		// Token: 0x0600A95F RID: 43359 RVA: 0x004B64F0 File Offset: 0x004B46F0
		private void KFNOEOIIBOI()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.JHOMJMMJLLI();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1651f, 64))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("mask=");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 739f;
			this.AOLJFAMMAFO.damper = 95f;
			this.AOLJFAMMAFO.maxDistance = 852f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("[WH Detector Service]", raycastHit.distance);
		}

		// Token: 0x0600A960 RID: 43360 RVA: 0x004B661C File Offset: 0x004B481C
		private void IDMCOLDDNCF()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.AAMDBPJNGIE();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1235f, -112))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 69f;
			this.AOLJFAMMAFO.damper = 308f;
			this.AOLJFAMMAFO.maxDistance = 1678f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("https://www.youtube.com/watch?v=r5jiZnsDH3M", raycastHit.distance);
		}

		// Token: 0x0600A961 RID: 43361 RVA: 0x004B6748 File Offset: 0x004B4948
		private void OFPGMNGFLNH()
		{
			if (!Input.GetMouseButtonDown(1))
			{
				return;
			}
			Camera camera = this.KBGONJOGJHF();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1347f, 111))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("innerPerk");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = false;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 477f;
			this.AOLJFAMMAFO.damper = 1879f;
			this.AOLJFAMMAFO.maxDistance = 1799f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("start load ", raycastHit.distance);
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x004B6874 File Offset: 0x004B4A74
		private void JIKGIJEHGAP()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = this.FIIDODFPPAF();
			RaycastHit raycastHit = default(RaycastHit);
			if (!Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out raycastHit, 1705f, 72))
			{
				return;
			}
			if (!raycastHit.rigidbody || raycastHit.rigidbody.isKinematic)
			{
				return;
			}
			if (!this.AOLJFAMMAFO)
			{
				GameObject gameObject = new GameObject("");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				this.AOLJFAMMAFO = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			this.AOLJFAMMAFO.transform.position = raycastHit.point;
			this.AOLJFAMMAFO.anchor = Vector3.zero;
			this.AOLJFAMMAFO.spring = 893f;
			this.AOLJFAMMAFO.damper = 815f;
			this.AOLJFAMMAFO.maxDistance = 11f;
			this.AOLJFAMMAFO.connectedBody = raycastHit.rigidbody;
			base.StartCoroutine("OpenRecords", raycastHit.distance);
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera HJKPAHPDEFJ()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera MNKJFANPLJE()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A965 RID: 43365 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator NNFFPKDKEDK(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A966 RID: 43366 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera AAMDBPJNGIE()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A967 RID: 43367 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera JNPPCOHGLIK()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x0600A968 RID: 43368 RVA: 0x004B3965 File Offset: 0x004B1B65
		private IEnumerator HANKGBKFKFB(float DKIHDOELFEH)
		{
			drag = this.AOLJFAMMAFO.connectedBody.drag;
			angularDrag = this.AOLJFAMMAFO.connectedBody.angularDrag;
			this.AOLJFAMMAFO.connectedBody.drag = 10f;
			this.AOLJFAMMAFO.connectedBody.angularDrag = 5f;
			camera = this.EOPLLPFCGKH();
			while (Input.GetMouseButton(0))
			{
				Ray ray = camera.ScreenPointToRay(Input.mousePosition);
				this.AOLJFAMMAFO.transform.position = ray.GetPoint(DKIHDOELFEH);
				yield return null;
			}
			if (this.AOLJFAMMAFO.connectedBody)
			{
				this.AOLJFAMMAFO.connectedBody.drag = drag;
				this.AOLJFAMMAFO.connectedBody.angularDrag = angularDrag;
				this.AOLJFAMMAFO.connectedBody = null;
			}
			yield break;
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x004B394A File Offset: 0x004B1B4A
		private Camera HJEIEKFKOAH()
		{
			if (base.GetComponent<Camera>())
			{
				return base.GetComponent<Camera>();
			}
			return Camera.main;
		}

		// Token: 0x040015CE RID: 5582
		private const float KMKAINPJLOL = 50f;

		// Token: 0x040015CF RID: 5583
		private const float DHPPFCCLEOK = 5f;

		// Token: 0x040015D0 RID: 5584
		private const float EOLIJNNAIFI = 10f;

		// Token: 0x040015D1 RID: 5585
		private const float KKBHDABKCPK = 5f;

		// Token: 0x040015D2 RID: 5586
		private const float PJGBMAHPOJF = 0.2f;

		// Token: 0x040015D3 RID: 5587
		private const bool AFPECNDLKEO = false;

		// Token: 0x040015D4 RID: 5588
		private SpringJoint AOLJFAMMAFO;
	}
}
