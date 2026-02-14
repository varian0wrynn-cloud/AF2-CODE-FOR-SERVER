using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002EE RID: 750
	public class WaypointProgressTracker : MonoBehaviour
	{
		// Token: 0x0600B009 RID: 45065 RVA: 0x004CC62C File Offset: 0x004CA82C
		public void MPJJBFNIHPK()
		{
			this.JLBBAPFDGMM = 1340f;
			this.KFAGNMFJFML = 0;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				this.target.position = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.JHBKMNBFNPJ[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B00A RID: 45066 RVA: 0x004CC698 File Offset: 0x004CA898
		private void DHFFKFEJCDE(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<DLBPOLALFNL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B00B RID: 45067 RVA: 0x004CC6A4 File Offset: 0x004CA8A4
		public void HHKNFJGHLAD()
		{
			this.JLBBAPFDGMM = 594f;
			this.KFAGNMFJFML = 1;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				this.target.position = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.FJACHEIBNIL()[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600B00C RID: 45068 RVA: 0x004CC710 File Offset: 0x004CA910
		// (set) Token: 0x0600B051 RID: 45137 RVA: 0x004CC698 File Offset: 0x004CA898
		public WaypointCircuit.KFAFGDCCDPB MHPLNELCPAK { get; private set; }

		// Token: 0x0600B00D RID: 45069 RVA: 0x004CC698 File Offset: 0x004CA898
		private void IAMDNGBIPBH(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<DLBPOLALFNL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB NEGPJDINIJC()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B00F RID: 45071 RVA: 0x004CC718 File Offset: 0x004CA918
		private void PHGIDKFLGHH(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B010 RID: 45072 RVA: 0x004CC724 File Offset: 0x004CA924
		private void DKOIOBMMAGN()
		{
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				if (Time.deltaTime > 1564f)
				{
					this.AIFIJJADKHN = Mathf.Lerp(this.AIFIJJADKHN, (this.IABMNPENOFE - base.transform.position).magnitude / Time.deltaTime, Time.deltaTime);
				}
				this.target.position = this.circuit.EAHNMFGMLCP(this.JLBBAPFDGMM + this.lookAheadForTargetOffset + this.lookAheadForTargetFactor * this.AIFIJJADKHN).MGALEAJOGPL;
				this.target.rotation = Quaternion.LookRotation(this.circuit.CCCFKLGBFBG(this.JLBBAPFDGMM + this.lookAheadForSpeedOffset + this.lookAheadForSpeedFactor * this.AIFIJJADKHN).NEMFIHCKJPE);
				this.MHPLNELCPAK = this.circuit.PDGEABNOCCD(this.JLBBAPFDGMM);
				Vector3 lhs = this.NEGPJDINIJC().MGALEAJOGPL - base.transform.position;
				if (Vector3.Dot(lhs, this.GJIFMLCHGBI().NEMFIHCKJPE) < 130f)
				{
					this.JLBBAPFDGMM += lhs.magnitude * 642f;
				}
				this.IABMNPENOFE = base.transform.position;
				return;
			}
			if ((this.target.position - base.transform.position).magnitude < this.pointToPointThreshold)
			{
				this.KFAGNMFJFML = (this.KFAGNMFJFML + 0) % this.circuit.GCCONOJPION().Length;
			}
			this.target.position = this.circuit.EEMKKPHLLLL()[this.KFAGNMFJFML].position;
			this.target.rotation = this.circuit.FJACHEIBNIL()[this.KFAGNMFJFML].rotation;
			this.NDACEICCNNO(this.circuit.EAHNMFGMLCP(this.JLBBAPFDGMM));
			Vector3 lhs2 = this.MNCOJPIBFFI().MGALEAJOGPL - base.transform.position;
			if (Vector3.Dot(lhs2, this.LAIINICKFEA().NEMFIHCKJPE) < 832f)
			{
				this.JLBBAPFDGMM += lhs2.magnitude;
			}
			this.IABMNPENOFE = base.transform.position;
		}

		// Token: 0x0600B011 RID: 45073 RVA: 0x004CC968 File Offset: 0x004CAB68
		private void EENHGLBOOCN()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.GetRoutePosition(this.JLBBAPFDGMM), 72f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B012 RID: 45074 RVA: 0x004CC9F4 File Offset: 0x004CABF4
		private void JPHLMNIMDHH()
		{
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				if (Time.deltaTime > 1727f)
				{
					this.AIFIJJADKHN = Mathf.Lerp(this.AIFIJJADKHN, (this.IABMNPENOFE - base.transform.position).magnitude / Time.deltaTime, Time.deltaTime);
				}
				this.target.position = this.circuit.EAHNMFGMLCP(this.JLBBAPFDGMM + this.lookAheadForTargetOffset + this.lookAheadForTargetFactor * this.AIFIJJADKHN).MGALEAJOGPL;
				this.target.rotation = Quaternion.LookRotation(this.circuit.NNOLFHOGKAO(this.JLBBAPFDGMM + this.lookAheadForSpeedOffset + this.lookAheadForSpeedFactor * this.AIFIJJADKHN).NEMFIHCKJPE);
				this.NDACEICCNNO(this.circuit.KKALGHNGEBO(this.JLBBAPFDGMM));
				Vector3 lhs = this.GHIFIHILJMF().MGALEAJOGPL - base.transform.position;
				if (Vector3.Dot(lhs, this.MHPLNELCPAK.NEMFIHCKJPE) < 1360f)
				{
					this.JLBBAPFDGMM += lhs.magnitude * 483f;
				}
				this.IABMNPENOFE = base.transform.position;
				return;
			}
			if ((this.target.position - base.transform.position).magnitude < this.pointToPointThreshold)
			{
				this.KFAGNMFJFML = (this.KFAGNMFJFML + 1) % this.circuit.EEMKKPHLLLL().Length;
			}
			this.target.position = this.circuit.FJACHEIBNIL()[this.KFAGNMFJFML].position;
			this.target.rotation = this.circuit.EEMKKPHLLLL()[this.KFAGNMFJFML].rotation;
			this.MHPLNELCPAK = this.circuit.OFLBGLKMICN(this.JLBBAPFDGMM);
			Vector3 lhs2 = this.ABECEKKFHIP().MGALEAJOGPL - base.transform.position;
			if (Vector3.Dot(lhs2, this.GJIFMLCHGBI().NEMFIHCKJPE) < 965f)
			{
				this.JLBBAPFDGMM += lhs2.magnitude;
			}
			this.IABMNPENOFE = base.transform.position;
		}

		// Token: 0x0600B013 RID: 45075 RVA: 0x004CCC35 File Offset: 0x004CAE35
		private void EFJDBBDMPMC()
		{
			if (this.target == null)
			{
				this.target = new GameObject(base.name + "DepthMaskBlendMaterial").transform;
			}
			this.PAGNCBCACKL();
		}

		// Token: 0x0600B014 RID: 45076 RVA: 0x004CC718 File Offset: 0x004CA918
		private void HJEKOCGJJPH(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x004CCC6B File Offset: 0x004CAE6B
		public WaypointCircuit.KFAFGDCCDPB CMEHGJCAGDL()
		{
			return this.<APODEJEIHLO>k__BackingField;
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x004CCC74 File Offset: 0x004CAE74
		private void OnDrawGizmos()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.GetRoutePosition(this.JLBBAPFDGMM), 1f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B017 RID: 45079 RVA: 0x004CCD00 File Offset: 0x004CAF00
		private void FKHOOIMOLMF()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.GetRoutePosition(this.JLBBAPFDGMM), 1274f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B018 RID: 45080 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB AIMPEOGBNIJ()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x004CCD8C File Offset: 0x004CAF8C
		private void IIKIMEMCCFN()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.GetRoutePosition(this.JLBBAPFDGMM), 158f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x004CCE18 File Offset: 0x004CB018
		public void DDFFBNBIACP()
		{
			this.JLBBAPFDGMM = 1976f;
			this.KFAGNMFJFML = 1;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				this.target.position = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.EEMKKPHLLLL()[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x004CCE84 File Offset: 0x004CB084
		public void Reset()
		{
			this.JLBBAPFDGMM = 0f;
			this.KFAGNMFJFML = 0;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.PointToPoint)
			{
				this.target.position = this.circuit.JHBKMNBFNPJ[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.JHBKMNBFNPJ[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB MNCOJPIBFFI()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x004CCEF0 File Offset: 0x004CB0F0
		private void EOAHBGCPKHA()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.PMJKEJNCNFC(this.JLBBAPFDGMM), 1017f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x004CCC6B File Offset: 0x004CAE6B
		public WaypointCircuit.KFAFGDCCDPB GKODJIBMPHN()
		{
			return this.<APODEJEIHLO>k__BackingField;
		}

		// Token: 0x0600B01F RID: 45087 RVA: 0x004CCC6B File Offset: 0x004CAE6B
		public WaypointCircuit.KFAFGDCCDPB DBOOKCDNCFF()
		{
			return this.<APODEJEIHLO>k__BackingField;
		}

		// Token: 0x0600B020 RID: 45088 RVA: 0x004CC718 File Offset: 0x004CA918
		private void EGLDHCNDNEC(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B021 RID: 45089 RVA: 0x004CC698 File Offset: 0x004CA898
		private void NDACEICCNNO(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<DLBPOLALFNL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x004CCF79 File Offset: 0x004CB179
		private void JLKBMEBFHBI()
		{
			if (this.target == null)
			{
				this.target = new GameObject(base.name + "gi_uinf_6").transform;
			}
			this.Reset();
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x004CCFAF File Offset: 0x004CB1AF
		private void KJJNMNKPNCH()
		{
			if (this.target == null)
			{
				this.target = new GameObject(base.name + "****** locid=").transform;
			}
			this.PAGNCBCACKL();
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x004CCFE8 File Offset: 0x004CB1E8
		private void FOHLAIIMNFB()
		{
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				if (Time.deltaTime > 1726f)
				{
					this.AIFIJJADKHN = Mathf.Lerp(this.AIFIJJADKHN, (this.IABMNPENOFE - base.transform.position).magnitude / Time.deltaTime, Time.deltaTime);
				}
				this.target.position = this.circuit.CCCFKLGBFBG(this.JLBBAPFDGMM + this.lookAheadForTargetOffset + this.lookAheadForTargetFactor * this.AIFIJJADKHN).MGALEAJOGPL;
				this.target.rotation = Quaternion.LookRotation(this.circuit.EAHNMFGMLCP(this.JLBBAPFDGMM + this.lookAheadForSpeedOffset + this.lookAheadForSpeedFactor * this.AIFIJJADKHN).NEMFIHCKJPE);
				this.IAMDNGBIPBH(this.circuit.CCCFKLGBFBG(this.JLBBAPFDGMM));
				Vector3 lhs = this.ABECEKKFHIP().MGALEAJOGPL - base.transform.position;
				if (Vector3.Dot(lhs, this.KGFLAOFGGNJ().NEMFIHCKJPE) < 1030f)
				{
					this.JLBBAPFDGMM += lhs.magnitude * 1606f;
				}
				this.IABMNPENOFE = base.transform.position;
				return;
			}
			if ((this.target.position - base.transform.position).magnitude < this.pointToPointThreshold)
			{
				this.KFAGNMFJFML = (this.KFAGNMFJFML + 1) % this.circuit.FJACHEIBNIL().Length;
			}
			this.target.position = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].position;
			this.target.rotation = this.circuit.FJACHEIBNIL()[this.KFAGNMFJFML].rotation;
			this.MHPLNELCPAK = this.circuit.CDDCIDMDIGO(this.JLBBAPFDGMM);
			Vector3 lhs2 = this.PBDKKPLBOIF().MGALEAJOGPL - base.transform.position;
			if (Vector3.Dot(lhs2, this.KGFLAOFGGNJ().NEMFIHCKJPE) < 552f)
			{
				this.JLBBAPFDGMM += lhs2.magnitude;
			}
			this.IABMNPENOFE = base.transform.position;
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x004CD229 File Offset: 0x004CB429
		public WaypointCircuit.KFAFGDCCDPB HFKKECDPIHO()
		{
			return this.<JFMCBPAGEOM>k__BackingField;
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x004CD229 File Offset: 0x004CB429
		public WaypointCircuit.KFAFGDCCDPB LIJCMAMGEPN()
		{
			return this.<JFMCBPAGEOM>k__BackingField;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600B038 RID: 45112 RVA: 0x004CD229 File Offset: 0x004CB429
		// (set) Token: 0x0600B027 RID: 45095 RVA: 0x004CD231 File Offset: 0x004CB431
		public WaypointCircuit.KFAFGDCCDPB MNPLNBLDFDG { get; private set; }

		// Token: 0x0600B028 RID: 45096 RVA: 0x004CD23C File Offset: 0x004CB43C
		public void KHLFNAKOLAC()
		{
			this.JLBBAPFDGMM = 1452f;
			this.KFAGNMFJFML = 1;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				this.target.position = this.circuit.EEMKKPHLLLL()[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B029 RID: 45097 RVA: 0x004CCC6B File Offset: 0x004CAE6B
		public WaypointCircuit.KFAFGDCCDPB ALALAGPBCJG()
		{
			return this.<APODEJEIHLO>k__BackingField;
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x004CD2A8 File Offset: 0x004CB4A8
		private void GDDNNAOKOII()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.GKAEIPGANGE(this.JLBBAPFDGMM), 3f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B02B RID: 45099 RVA: 0x004CD334 File Offset: 0x004CB534
		private void PEABEDAILHP()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.PMJKEJNCNFC(this.JLBBAPFDGMM), 1681f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B02C RID: 45100 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB GHIFIHILJMF()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x004CD3BD File Offset: 0x004CB5BD
		private void Start()
		{
			if (this.target == null)
			{
				this.target = new GameObject(base.name + " Waypoint Target").transform;
			}
			this.Reset();
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x004CC718 File Offset: 0x004CA918
		private void ALEMOHKANHM(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B02F RID: 45103 RVA: 0x004CD229 File Offset: 0x004CB429
		public WaypointCircuit.KFAFGDCCDPB NBBGEOGGPCD()
		{
			return this.<JFMCBPAGEOM>k__BackingField;
		}

		// Token: 0x0600B030 RID: 45104 RVA: 0x004CD3F4 File Offset: 0x004CB5F4
		public void PAGNCBCACKL()
		{
			this.JLBBAPFDGMM = 210f;
			this.KFAGNMFJFML = 1;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				this.target.position = this.circuit.JHBKMNBFNPJ[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B031 RID: 45105 RVA: 0x004CD231 File Offset: 0x004CB431
		private void BCPLHHPEONL(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<JFMCBPAGEOM>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x004CC718 File Offset: 0x004CA918
		private void BBBBHDLBCOM(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B033 RID: 45107 RVA: 0x004CD229 File Offset: 0x004CB429
		public WaypointCircuit.KFAFGDCCDPB EBIGDBEAALM()
		{
			return this.<JFMCBPAGEOM>k__BackingField;
		}

		// Token: 0x0600B034 RID: 45108 RVA: 0x004CD460 File Offset: 0x004CB660
		public void OEOGICNBLPP()
		{
			this.JLBBAPFDGMM = 1025f;
			this.KFAGNMFJFML = 0;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.PointToPoint)
			{
				this.target.position = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B035 RID: 45109 RVA: 0x004CD4CC File Offset: 0x004CB6CC
		private void MCHAAIIHOKD()
		{
			if (this.target == null)
			{
				this.target = new GameObject(base.name + "Heart Attack").transform;
			}
			this.MLOPPPBPHNJ();
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600B03F RID: 45119 RVA: 0x004CCC6B File Offset: 0x004CAE6B
		// (set) Token: 0x0600B036 RID: 45110 RVA: 0x004CC718 File Offset: 0x004CA918
		public WaypointCircuit.KFAFGDCCDPB EIBCKLPJKNK { get; private set; }

		// Token: 0x0600B037 RID: 45111 RVA: 0x004CD504 File Offset: 0x004CB704
		private void HKEDIBDABJL()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.GetRoutePosition(this.JLBBAPFDGMM), 1861f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B039 RID: 45113 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB PBDKKPLBOIF()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB KGFLAOFGGNJ()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B03B RID: 45115 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB ABECEKKFHIP()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x004CC718 File Offset: 0x004CA918
		private void AJMKMMBOLEG(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x004CD229 File Offset: 0x004CB429
		public WaypointCircuit.KFAFGDCCDPB LIAJHAHKPKD()
		{
			return this.<JFMCBPAGEOM>k__BackingField;
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x004CC718 File Offset: 0x004CA918
		private void IHOEDBJOOFN(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB GJIFMLCHGBI()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x004CD58D File Offset: 0x004CB78D
		private void CGFDDFHECLJ()
		{
			if (this.target == null)
			{
				this.target = new GameObject(base.name + "Label").transform;
			}
			this.DDFFBNBIACP();
		}

		// Token: 0x0600B042 RID: 45122 RVA: 0x004CCC6B File Offset: 0x004CAE6B
		public WaypointCircuit.KFAFGDCCDPB IJMOMEHPMNC()
		{
			return this.<APODEJEIHLO>k__BackingField;
		}

		// Token: 0x0600B043 RID: 45123 RVA: 0x004CD231 File Offset: 0x004CB431
		private void ABEGFAAKJNO(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<JFMCBPAGEOM>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x004CCC6B File Offset: 0x004CAE6B
		public WaypointCircuit.KFAFGDCCDPB MAJECGLIHLF()
		{
			return this.<APODEJEIHLO>k__BackingField;
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x004CD231 File Offset: 0x004CB431
		private void KMDKLFBJLJG(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<JFMCBPAGEOM>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x004CC698 File Offset: 0x004CA898
		private void AHNJKJIBMAB(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<DLBPOLALFNL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x004CD231 File Offset: 0x004CB431
		private void EILFGMNFFAG(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<JFMCBPAGEOM>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB LAIINICKFEA()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x004CD5C3 File Offset: 0x004CB7C3
		private void PMDPLLIBJAF()
		{
			if (this.target == null)
			{
				this.target = new GameObject(base.name + "null").transform;
			}
			this.DDFFBNBIACP();
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x004CC718 File Offset: 0x004CA918
		private void CNLDIKNAKCC(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B04B RID: 45131 RVA: 0x004CCC6B File Offset: 0x004CAE6B
		public WaypointCircuit.KFAFGDCCDPB OLFNICPKAIO()
		{
			return this.<APODEJEIHLO>k__BackingField;
		}

		// Token: 0x0600B04C RID: 45132 RVA: 0x004CD229 File Offset: 0x004CB429
		public WaypointCircuit.KFAFGDCCDPB OFEDCOCHKBK()
		{
			return this.<JFMCBPAGEOM>k__BackingField;
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x004CD5FC File Offset: 0x004CB7FC
		public void MLOPPPBPHNJ()
		{
			this.JLBBAPFDGMM = 1959f;
			this.KFAGNMFJFML = 1;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.PointToPoint)
			{
				this.target.position = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.JHBKMNBFNPJ[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B04E RID: 45134 RVA: 0x004CD668 File Offset: 0x004CB868
		private void Update()
		{
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.SmoothAlongRoute)
			{
				if (Time.deltaTime > 0f)
				{
					this.AIFIJJADKHN = Mathf.Lerp(this.AIFIJJADKHN, (this.IABMNPENOFE - base.transform.position).magnitude / Time.deltaTime, Time.deltaTime);
				}
				this.target.position = this.circuit.GetRoutePoint(this.JLBBAPFDGMM + this.lookAheadForTargetOffset + this.lookAheadForTargetFactor * this.AIFIJJADKHN).MGALEAJOGPL;
				this.target.rotation = Quaternion.LookRotation(this.circuit.GetRoutePoint(this.JLBBAPFDGMM + this.lookAheadForSpeedOffset + this.lookAheadForSpeedFactor * this.AIFIJJADKHN).NEMFIHCKJPE);
				this.MHPLNELCPAK = this.circuit.GetRoutePoint(this.JLBBAPFDGMM);
				Vector3 lhs = this.MHPLNELCPAK.MGALEAJOGPL - base.transform.position;
				if (Vector3.Dot(lhs, this.MHPLNELCPAK.NEMFIHCKJPE) < 0f)
				{
					this.JLBBAPFDGMM += lhs.magnitude * 0.5f;
				}
				this.IABMNPENOFE = base.transform.position;
				return;
			}
			if ((this.target.position - base.transform.position).magnitude < this.pointToPointThreshold)
			{
				this.KFAGNMFJFML = (this.KFAGNMFJFML + 1) % this.circuit.JHBKMNBFNPJ.Length;
			}
			this.target.position = this.circuit.JHBKMNBFNPJ[this.KFAGNMFJFML].position;
			this.target.rotation = this.circuit.JHBKMNBFNPJ[this.KFAGNMFJFML].rotation;
			this.MHPLNELCPAK = this.circuit.GetRoutePoint(this.JLBBAPFDGMM);
			Vector3 lhs2 = this.MHPLNELCPAK.MGALEAJOGPL - base.transform.position;
			if (Vector3.Dot(lhs2, this.MHPLNELCPAK.NEMFIHCKJPE) < 0f)
			{
				this.JLBBAPFDGMM += lhs2.magnitude;
			}
			this.IABMNPENOFE = base.transform.position;
		}

		// Token: 0x0600B04F RID: 45135 RVA: 0x004CD8AC File Offset: 0x004CBAAC
		public void LPMNAMDNDDM()
		{
			this.JLBBAPFDGMM = 1365f;
			this.KFAGNMFJFML = 0;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.PointToPoint)
			{
				this.target.position = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.EEMKKPHLLLL()[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B052 RID: 45138 RVA: 0x004CD958 File Offset: 0x004CBB58
		public void BEOEJEGGCII()
		{
			this.JLBBAPFDGMM = 1208f;
			this.KFAGNMFJFML = 0;
			if (this.progressStyle == WaypointProgressTracker.KPGLKFJEOLG.PointToPoint)
			{
				this.target.position = this.circuit.GCCONOJPION()[this.KFAGNMFJFML].position;
				this.target.rotation = this.circuit.JHBKMNBFNPJ[this.KFAGNMFJFML].rotation;
			}
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x004CC718 File Offset: 0x004CA918
		private void KPPEIKGBBND(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x004CD9C4 File Offset: 0x004CBBC4
		private void FBDGJNEGLFL()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, this.target.position);
				Gizmos.DrawWireSphere(this.circuit.LMLMCOPCCJB(this.JLBBAPFDGMM), 690f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.target.position, this.target.position + this.target.forward);
			}
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x004CD229 File Offset: 0x004CB429
		public WaypointCircuit.KFAFGDCCDPB BOJLJFLBPJE()
		{
			return this.<JFMCBPAGEOM>k__BackingField;
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x004CD229 File Offset: 0x004CB429
		public WaypointCircuit.KFAFGDCCDPB GDDGIDKHAEO()
		{
			return this.<JFMCBPAGEOM>k__BackingField;
		}

		// Token: 0x0600B057 RID: 45143 RVA: 0x004CC718 File Offset: 0x004CA918
		private void GGOMLCIMLIF(WaypointCircuit.KFAFGDCCDPB DCCPCBLODIG)
		{
			this.<APODEJEIHLO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x004CC710 File Offset: 0x004CA910
		public WaypointCircuit.KFAFGDCCDPB ADNONPCKMCI()
		{
			return this.<DLBPOLALFNL>k__BackingField;
		}

		// Token: 0x04001657 RID: 5719
		[SerializeField]
		private WaypointCircuit circuit;

		// Token: 0x04001658 RID: 5720
		[SerializeField]
		private float lookAheadForTargetOffset = 5f;

		// Token: 0x04001659 RID: 5721
		[SerializeField]
		private float lookAheadForTargetFactor = 0.1f;

		// Token: 0x0400165A RID: 5722
		[SerializeField]
		private float lookAheadForSpeedOffset = 10f;

		// Token: 0x0400165B RID: 5723
		[SerializeField]
		private float lookAheadForSpeedFactor = 0.2f;

		// Token: 0x0400165C RID: 5724
		[SerializeField]
		private WaypointProgressTracker.KPGLKFJEOLG progressStyle;

		// Token: 0x0400165D RID: 5725
		[SerializeField]
		private float pointToPointThreshold = 4f;

		// Token: 0x04001661 RID: 5729
		public Transform target;

		// Token: 0x04001662 RID: 5730
		private float JLBBAPFDGMM;

		// Token: 0x04001663 RID: 5731
		private int KFAGNMFJFML;

		// Token: 0x04001664 RID: 5732
		private Vector3 IABMNPENOFE;

		// Token: 0x04001665 RID: 5733
		private float AIFIJJADKHN;

		// Token: 0x020002EF RID: 751
		public enum KPGLKFJEOLG
		{
			// Token: 0x04001667 RID: 5735
			SmoothAlongRoute,
			// Token: 0x04001668 RID: 5736
			PointToPoint
		}
	}
}
