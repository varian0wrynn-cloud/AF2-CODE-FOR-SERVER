using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Ball
{
	// Token: 0x0200039E RID: 926
	public class Ball : MonoBehaviour
	{
		// Token: 0x0600C768 RID: 51048 RVA: 0x005940C8 File Offset: 0x005922C8
		public void JLKKPPGJJDB(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 533f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1556f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C769 RID: 51049 RVA: 0x00594164 File Offset: 0x00592364
		public void CGHECDAJCCP(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 514f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1801f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C76A RID: 51050 RVA: 0x00594200 File Offset: 0x00592400
		public void KCJKCNNNNCK(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1761f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1223f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C76B RID: 51051 RVA: 0x0059429A File Offset: 0x0059249A
		private void AFFAJKPPMHF()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C76C RID: 51052 RVA: 0x005942BC File Offset: 0x005924BC
		public void OGFBDGOAMOP(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 261f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 149f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C76D RID: 51053 RVA: 0x0059429A File Offset: 0x0059249A
		private void BJHGPFGBFKF()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C76E RID: 51054 RVA: 0x00594358 File Offset: 0x00592558
		public void FMHDIGGEPPM(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 661f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 454f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C76F RID: 51055 RVA: 0x005943F4 File Offset: 0x005925F4
		public void DCANDLOECBI(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1612f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 43f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x00594490 File Offset: 0x00592690
		public void OBOOFACBDHO(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1613f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 382f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C771 RID: 51057 RVA: 0x0059452C File Offset: 0x0059272C
		public void JLFBLPKNCMO(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1898f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1941f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C772 RID: 51058 RVA: 0x005945C8 File Offset: 0x005927C8
		public void HBILENOGLNG(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 412f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 263f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C773 RID: 51059 RVA: 0x0059429A File Offset: 0x0059249A
		private void CGMHGDEKDEP()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C774 RID: 51060 RVA: 0x00594664 File Offset: 0x00592864
		public void HPMLKNJGKLA(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 18f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1238f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C775 RID: 51061 RVA: 0x0059429A File Offset: 0x0059249A
		private void KFGKKLAKFGH()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C776 RID: 51062 RVA: 0x00594700 File Offset: 0x00592900
		public void Move(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 0f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C777 RID: 51063 RVA: 0x0059429A File Offset: 0x0059249A
		private void Start()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C778 RID: 51064 RVA: 0x0059479C File Offset: 0x0059299C
		public void BCBPAJDGBJD(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1932f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 313f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C779 RID: 51065 RVA: 0x0059429A File Offset: 0x0059249A
		private void IAAOGAPJDID()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C77A RID: 51066 RVA: 0x00594838 File Offset: 0x00592A38
		public void EEIHMCHIKEF(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1150f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1332f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C77B RID: 51067 RVA: 0x005948D4 File Offset: 0x00592AD4
		public void PMHGPIPFOHI(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 784f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 308f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C77C RID: 51068 RVA: 0x00594970 File Offset: 0x00592B70
		public void LOIHEBEJOMI(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 479f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1605f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C77D RID: 51069 RVA: 0x00594A0C File Offset: 0x00592C0C
		public void JCNINPAECIP(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 903f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 240f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C77E RID: 51070 RVA: 0x00594AA8 File Offset: 0x00592CA8
		public void MIHHHMBMANO(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1702f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 30f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C780 RID: 51072 RVA: 0x00594B74 File Offset: 0x00592D74
		public void BPEBBBCBIPC(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1027f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1196f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C781 RID: 51073 RVA: 0x00594C10 File Offset: 0x00592E10
		public void EFMOPJGJKBO(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 357f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1234f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C782 RID: 51074 RVA: 0x0059429A File Offset: 0x0059249A
		private void LMEJKAEIDCO()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C783 RID: 51075 RVA: 0x00594CAC File Offset: 0x00592EAC
		public void PEGCCIJGGDP(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1745f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 297f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C784 RID: 51076 RVA: 0x0059429A File Offset: 0x0059249A
		private void INDGOHJGCFN()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C785 RID: 51077 RVA: 0x00594D48 File Offset: 0x00592F48
		public void DKGDIFHEHJP(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1792f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1115f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C786 RID: 51078 RVA: 0x0059429A File Offset: 0x0059249A
		private void ELFLOPJDAKK()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x0600C787 RID: 51079 RVA: 0x00594DE4 File Offset: 0x00592FE4
		public void LHEMPEOIAPP(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1866f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1746f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C788 RID: 51080 RVA: 0x00594E80 File Offset: 0x00593080
		public void DJHCIHACNAA(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 1864f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 760f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C789 RID: 51081 RVA: 0x00594F1C File Offset: 0x0059311C
		public void FJILBBHGIIK(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 398f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1318f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C78A RID: 51082 RVA: 0x00594FB8 File Offset: 0x005931B8
		public void BDELIICPHEA(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 436f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1861f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Force);
			}
		}

		// Token: 0x0600C78B RID: 51083 RVA: 0x00595054 File Offset: 0x00593254
		public void MOPCGHIELAO(Vector3 JDFLHKMFHBJ, bool IELMDLPINAH)
		{
			if (this.m_UseTorque)
			{
				this.JMKPNAOICPE.AddTorque(new Vector3(JDFLHKMFHBJ.z, 516f, -JDFLHKMFHBJ.x) * this.m_MovePower);
			}
			else
			{
				this.JMKPNAOICPE.AddForce(JDFLHKMFHBJ * this.m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 623f) && IELMDLPINAH)
			{
				this.JMKPNAOICPE.AddForce(Vector3.up * this.m_JumpPower, ForceMode.Impulse);
			}
		}

		// Token: 0x0600C78C RID: 51084 RVA: 0x0059429A File Offset: 0x0059249A
		private void HHGGCBLOJGB()
		{
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			base.GetComponent<Rigidbody>().maxAngularVelocity = this.m_MaxAngularVelocity;
		}

		// Token: 0x04001A7C RID: 6780
		[SerializeField]
		private float m_MovePower = 5f;

		// Token: 0x04001A7D RID: 6781
		[SerializeField]
		private bool m_UseTorque = true;

		// Token: 0x04001A7E RID: 6782
		[SerializeField]
		private float m_MaxAngularVelocity = 25f;

		// Token: 0x04001A7F RID: 6783
		[SerializeField]
		private float m_JumpPower = 2f;

		// Token: 0x04001A80 RID: 6784
		private const float BBKIMLIFEGC = 1f;

		// Token: 0x04001A81 RID: 6785
		private Rigidbody JMKPNAOICPE;
	}
}
