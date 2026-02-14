using System;
using UnityEngine;

namespace ProBuilder2.Examples
{
	// Token: 0x020004D7 RID: 1239
	public class CameraControls : MonoBehaviour
	{
		// Token: 0x06010D0D RID: 68877 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void AOCDDBNBADJ()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D0E RID: 68878 RVA: 0x007804C0 File Offset: 0x0077E6C0
		private void LOFKNDCJBMN()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 616f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("ShotgunFire");
				float num = -Input.GetAxis("IdleSadHips");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1470f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("ChannelCastDirected") != 1487f)
			{
				float axis2 = Input.GetAxis("Sewing");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 70f) * (this.zoomSpeed * 1156f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1847f, 1869f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D0F RID: 68879 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void KJJNMNKPNCH()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D10 RID: 68880 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void EHFPLKEINFO()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D11 RID: 68881 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void MKNPFMEMOJO()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D12 RID: 68882 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void DGDGMFDPEHO()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D13 RID: 68883 RVA: 0x00780680 File Offset: 0x0077E880
		private void IMEDKJNAHKK()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 992f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("error.wav");
				float num = -Input.GetAxis("IdleStun");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 482f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("MotorbikeTurnRight") != 1539f)
			{
				float axis2 = Input.GetAxis("Crouch Walk");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1995f) * (this.zoomSpeed * 824f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1715f, 114f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D14 RID: 68884 RVA: 0x00780840 File Offset: 0x0077EA40
		private void LCMMGLMJPOK()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 436f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("knopje.wav");
				float num = -Input.GetAxis("USE_MASK");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 959f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("Speed hack Detected!") != 626f)
			{
				float axis2 = Input.GetAxis("Manifest: ");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 900f) * (this.zoomSpeed * 595f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 155f, 118f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D15 RID: 68885 RVA: 0x00780A00 File Offset: 0x0077EC00
		private void CMDJHGMGLCG()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 961f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("PER_PIXEL");
				float num = -Input.GetAxis("UI_ArtWindow");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1186f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("Vector3: ") != 367f)
			{
				float axis2 = Input.GetAxis("file://");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 339f) * (this.zoomSpeed * 1629f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1979f, 537f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D16 RID: 68886 RVA: 0x00780BC0 File Offset: 0x0077EDC0
		private void MKNDDFMIGDN()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 290f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("PaperTurn.wav");
				float num = -Input.GetAxis("MotorbikeShootBack");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1468f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis(">") != 1634f)
			{
				float axis2 = Input.GetAxis("MotorbikeWheelyNoHands");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1992f) * (this.zoomSpeed * 1509f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 878f, 1626f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D17 RID: 68887 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void OFGMIEJKMGC()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D18 RID: 68888 RVA: 0x00780D80 File Offset: 0x0077EF80
		private void BJILHFNDDKC()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1482f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("demoLong");
				float num = -Input.GetAxis(" ");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1034f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("MotorbikeHeadstand") != 700f)
			{
				float axis2 = Input.GetAxis("perks/rperk");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 434f) * (this.zoomSpeed * 326f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 787f, 698f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D19 RID: 68889 RVA: 0x00780F40 File Offset: 0x0077F140
		private void LHFBEKCIKOI()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1486f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("BowReady2");
				float num = -Input.GetAxis("M");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1645f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("Lash") != 1086f)
			{
				float axis2 = Input.GetAxis("_History1LumaTex");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1005f) * (this.zoomSpeed * 115f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 913f, 1791f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D1A RID: 68890 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void AFFAJKPPMHF()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D1B RID: 68891 RVA: 0x00781100 File Offset: 0x0077F300
		private void BLOLJBHKGOH()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1629f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("");
				float num = -Input.GetAxis("[wtemplid]");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 570f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("offsets") != 384f)
			{
				float axis2 = Input.GetAxis("_TintColor");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 413f) * (this.zoomSpeed * 1824f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 785f, 813f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D1D RID: 68893 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void CPNOBMNKPNC()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D1E RID: 68894 RVA: 0x00781300 File Offset: 0x0077F500
		private void GHIJFOALMHM()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 620f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("MotorbikeShootRight");
				float num = -Input.GetAxis("shop_t1");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1182f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/") != 1775f)
			{
				float axis2 = Input.GetAxis("004000");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1611f) * (this.zoomSpeed * 1708f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1743f, 97f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D1F RID: 68895 RVA: 0x007814C0 File Offset: 0x0077F6C0
		private void CKCBGFMFNFK()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1419f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("System.Boolean");
				float num = -Input.GetAxis("MotorbikeLassoBack");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1039f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("teech_perk") != 939f)
			{
				float axis2 = Input.GetAxis("shop_t19");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1369f) * (this.zoomSpeed * 443f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1273f, 919f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D20 RID: 68896 RVA: 0x00781680 File Offset: 0x0077F880
		private void DFNJNCCPKJF()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 538f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("MotorbikeHeadstand");
				float num = -Input.GetAxis("_PrefilterOffs");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 127f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("Textures/FlyIcons/{0}.png") != 1341f)
			{
				float axis2 = Input.GetAxis("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 893f) * (this.zoomSpeed * 1799f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1351f, 1601f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D21 RID: 68897 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void KFGKKLAKFGH()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D22 RID: 68898 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void CGFDDFHECLJ()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D23 RID: 68899 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void PMDPLLIBJAF()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D24 RID: 68900 RVA: 0x00781840 File Offset: 0x0077FA40
		private void OIKMLNIPLIA()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 777f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("Money: ");
				float num = -Input.GetAxis("System.Boolean");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 292f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("citates/citate") != 310f)
			{
				float axis2 = Input.GetAxis("KatanaReady");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1287f) * (this.zoomSpeed * 22f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 148f, 1209f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D25 RID: 68901 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void LHHKDNILMDI()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D26 RID: 68902 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void IMABGALEMBI()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D27 RID: 68903 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void IIKDDILLGLF()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D28 RID: 68904 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void IAAOGAPJDID()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D29 RID: 68905 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void CAJLCEPLKJG()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D2A RID: 68906 RVA: 0x00781A00 File Offset: 0x0077FC00
		private void BOEFHGKGJMN()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 448f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("128");
				float num = -Input.GetAxis("Shader \"GUI/BackImage\" {Properties {_MainTex (\"Base (RGB) Trans (A)\", 2D) = \"white\" {}_Color (\" color\", color) = (1,1,1,1)}SubShader {\t\tTags { \"Queue\"=\"Background\" \"IgnoreProjector\"=\"True\" \"RenderType\"=\"Background\" }\tLighting Off Cull Off ZTest Always ZWrite Off Fog { Mode Off }\tZWrite Off\tBlend SrcAlpha OneMinusSrcAlpha\tPass {\t\tLighting Off\t\tcolor [_Color]   \t\tSetTexture [_MainTex] {combine texture * primary }\t\t\t}}}");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1885f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("MotorbikeLassoLeft") != 471f)
			{
				float axis2 = Input.GetAxis("LINEAR");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 771f) * (this.zoomSpeed * 1484f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 843f, 88f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D2B RID: 68907 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void JLKBMEBFHBI()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D2C RID: 68908 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void EFJDBBDMPMC()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D2D RID: 68909 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void DGEIACONKCJ()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D2E RID: 68910 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void OPNPODKLOJK()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D2F RID: 68911 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void BMNJGPIPKLL()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D30 RID: 68912 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void AIFIEAGFIMM()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D31 RID: 68913 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void LMEJKAEIDCO()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D32 RID: 68914 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void LPNDCJKAKEA()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D33 RID: 68915 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void CLHGHANANNL()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D34 RID: 68916 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void EHDPACPIBNF()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D35 RID: 68917 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void JCELICPHGEP()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D36 RID: 68918 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void OBJCOJEHLBE()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D37 RID: 68919 RVA: 0x00781BC0 File Offset: 0x0077FDC0
		private void NCOJPBKLANI()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1840f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("Swim");
				float num = -Input.GetAxis("Sunshine {0}: {1}");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 447f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("colorC") != 118f)
			{
				float axis2 = Input.GetAxis("isFishOnRod");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1767f) * (this.zoomSpeed * 310f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1734f, 988f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D38 RID: 68920 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void IJOCHELLKJH()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D39 RID: 68921 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void MODJFGGIAHD()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D3A RID: 68922 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void KIEIPFFEDHC()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D3B RID: 68923 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void PNJHMJNFPLP()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D3C RID: 68924 RVA: 0x00781D80 File Offset: 0x0077FF80
		private void HJDEGPKFBNI()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1473f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("pointBuffer");
				float num = -Input.GetAxis("FireBreath");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 50f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("isRun") != 446f)
			{
				float axis2 = Input.GetAxis("demoLong");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1558f) * (this.zoomSpeed * 846f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 461f, 325f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D3D RID: 68925 RVA: 0x00781F40 File Offset: 0x00780140
		private void AIKJPMIHCFP()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1439f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("MotorbikeAirWalk");
				float num = -Input.GetAxis("isPaint");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 791f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("_NeutralTonemapperParams1") != 1189f)
			{
				float axis2 = Input.GetAxis("");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1373f) * (this.zoomSpeed * 860f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1704f, 173f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D3E RID: 68926 RVA: 0x00782100 File Offset: 0x00780300
		private void LBBGAADLMOM()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1683f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("invn_rec11");
				float num = -Input.GetAxis("RepFractions.xml");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 244f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("KatanaReadyLow") != 1706f)
			{
				float axis2 = Input.GetAxis("");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 410f) * (this.zoomSpeed * 1496f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 239f, 700f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D3F RID: 68927 RVA: 0x007822C0 File Offset: 0x007804C0
		private void GFELHLPHCDN()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1379f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("LUX_LINEAR");
				float num = -Input.GetAxis(",");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1262f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("CrawlIdle") != 795f)
			{
				float axis2 = Input.GetAxis("MotorbikeLassoRight");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1025f) * (this.zoomSpeed * 1315f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 392f, 1162f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D40 RID: 68928 RVA: 0x00782480 File Offset: 0x00780680
		private void PCGMJEBLBLD()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 808f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("ShotgunFire");
				float num = -Input.GetAxis("1024");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1715f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("_HalfResolution") != 382f)
			{
				float axis2 = Input.GetAxis("WinVIP");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1420f) * (this.zoomSpeed * 995f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1313f, 78f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D41 RID: 68929 RVA: 0x00782640 File Offset: 0x00780840
		private void GJKCGGCCIAJ()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 71f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("<color='#001000'>+{0} {1}</color>");
				float num = -Input.GetAxis(".png");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 517f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("</color>\n") != 100f)
			{
				float axis2 = Input.GetAxis("-------------- capId=");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1608f) * (this.zoomSpeed * 1698f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1895f, 174f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D42 RID: 68930 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void OLBDJCFPKFG()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D43 RID: 68931 RVA: 0x00782800 File Offset: 0x00780A00
		private void OOGNHIIPHBH()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 876f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("shop_ycnt");
				float num = -Input.GetAxis("error");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1045f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("{0}.{1}.{2}") != 1466f)
			{
				float axis2 = Input.GetAxis("{0:F2}, {1:F2}, {2:F2}");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1582f) * (this.zoomSpeed * 1020f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1571f, 1279f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D44 RID: 68932 RVA: 0x007829C0 File Offset: 0x00780BC0
		private void MJFJPFJICDH()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1904f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("ChannelCastDirected");
				float num = -Input.GetAxis("Cloth_05_00.wav");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 680f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("wpn_wgt") != 1612f)
			{
				float axis2 = Input.GetAxis("UIChat_channel");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 856f) * (this.zoomSpeed * 1207f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 62f, 1008f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D45 RID: 68933 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void DHJDMKLBLEF()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D46 RID: 68934 RVA: 0x00782B80 File Offset: 0x00780D80
		private void GCJBBACOJJE()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 202f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("_NoiseAmount");
				float num = -Input.GetAxis("_BlurVector");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1971f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("_SubsampleIndices") != 1204f)
			{
				float axis2 = Input.GetAxis("Wizard Overhead");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 538f) * (this.zoomSpeed * 108f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 638f, 1630f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D47 RID: 68935 RVA: 0x00782D40 File Offset: 0x00780F40
		private void CGNFLAOBEFN()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1034f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("gi_uinf_7");
				float num = -Input.GetAxis("_Downsample");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 8f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("KatanaReady") != 1177f)
			{
				float axis2 = Input.GetAxis("gi_uinf_2i");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 616f) * (this.zoomSpeed * 1999f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1559f, 1238f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D48 RID: 68936 RVA: 0x00782F00 File Offset: 0x00781100
		private void OEKHPJAEAAE()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1103f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("RunBackRight");
				float num = -Input.GetAxis("OfficeSittingBack");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 929f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("isImproved") != 1855f)
			{
				float axis2 = Input.GetAxis("Mouse ScrollWheel");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 460f) * (this.zoomSpeed * 1201f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 607f, 1028f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D49 RID: 68937 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void Start()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D4A RID: 68938 RVA: 0x007830C0 File Offset: 0x007812C0
		private void BHDPDDHLPOI()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 678f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("_Intensity");
				float num = -Input.GetAxis("ProneIdle");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 545f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("Idle Typing") != 1431f)
			{
				float axis2 = Input.GetAxis("LHandPunch");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1070f) * (this.zoomSpeed * 1349f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 659f, 1232f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D4B RID: 68939 RVA: 0x00783280 File Offset: 0x00781480
		private void NGHOJBOHIBA()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1518f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("");
				float num = -Input.GetAxis("crft_none");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 297f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("****** locscount=") != 456f)
			{
				float axis2 = Input.GetAxis("BowInstant2");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 591f) * (this.zoomSpeed * 614f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1154f, 704f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D4C RID: 68940 RVA: 0x00783440 File Offset: 0x00781640
		private void KCJNJBEJHFA()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 1291f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("prov_sob_");
				float num = -Input.GetAxis("Ok");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1190f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("IceHockeyPassRight") != 1931f)
			{
				float axis2 = Input.GetAxis("#c0c0c0");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 46f) * (this.zoomSpeed * 1803f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1613f, 1573f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D4D RID: 68941 RVA: 0x00783600 File Offset: 0x00781800
		private void DBAELJBBKKF()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 65f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("-no info-");
				float num = -Input.GetAxis("ElvisLegsLoop");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 860f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("Wood Cut") != 954f)
			{
				float axis2 = Input.GetAxis("checkPet 2");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 644f) * (this.zoomSpeed * 1392f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 94f, 260f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D4E RID: 68942 RVA: 0x007804A3 File Offset: 0x0077E6A3
		private void FEBIICIMLHA()
		{
			this.DKIHDOELFEH = Vector3.Distance(base.transform.position, Vector3.zero);
		}

		// Token: 0x06010D4F RID: 68943 RVA: 0x007837C0 File Offset: 0x007819C0
		private void LateUpdate()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 0f;
			if (Input.GetMouseButton(0))
			{
				float axis = Input.GetAxis("Mouse X");
				float num = -Input.GetAxis("Mouse Y");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 0f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("Mouse ScrollWheel") != 0f)
			{
				float axis2 = Input.GetAxis("Mouse ScrollWheel");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 40f) * (this.zoomSpeed * 1000f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 10f, 40f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D50 RID: 68944 RVA: 0x00783980 File Offset: 0x00781B80
		private void KEACPNJHBIL()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 271f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("second bone position is the same as third bone position.");
				float num = -Input.GetAxis("Root");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 546f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("wpn_rod4") != 952f)
			{
				float axis2 = Input.GetAxis("; ");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 1597f) * (this.zoomSpeed * 730f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 1353f, 112f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x06010D51 RID: 68945 RVA: 0x00783B40 File Offset: 0x00781D40
		private void MJBLHNGLFOE()
		{
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			eulerAngles.z = 137f;
			if (Input.GetMouseButton(1))
			{
				float axis = Input.GetAxis("_OcclusionTexture");
				float num = -Input.GetAxis("repair.ogg");
				eulerAngles.x += num * this.orbitSpeed;
				eulerAngles.y += axis * this.orbitSpeed;
				this.GMDCCFLLCJA.x = axis;
				this.GMDCCFLLCJA.y = num;
				this.GMDCCFLLCJA.Normalize();
			}
			else
			{
				eulerAngles.y += Time.deltaTime * this.idleRotation * this.GMDCCFLLCJA.x;
				eulerAngles.x += Time.deltaTime * Mathf.PerlinNoise(Time.time, 1868f) * this.idleRotation * this.GMDCCFLLCJA.y;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			if (Input.GetAxis("USE_CORNER_DETECTION") != 81f)
			{
				float axis2 = Input.GetAxis(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
				this.DKIHDOELFEH -= axis2 * (this.DKIHDOELFEH / 229f) * (this.zoomSpeed * 1942f) * Time.deltaTime;
				this.DKIHDOELFEH = Mathf.Clamp(this.DKIHDOELFEH, 723f, 1920f);
				base.transform.position = base.transform.localRotation * (Vector3.forward * -this.DKIHDOELFEH);
			}
		}

		// Token: 0x04002312 RID: 8978
		private const float LOKLDEMPIHK = 10f;

		// Token: 0x04002313 RID: 8979
		private const float BHKLKPBLKED = 40f;

		// Token: 0x04002314 RID: 8980
		[Range(2f, 15f)]
		public float orbitSpeed = 6f;

		// Token: 0x04002315 RID: 8981
		[Range(0.3f, 2f)]
		public float zoomSpeed = 0.8f;

		// Token: 0x04002316 RID: 8982
		private float DKIHDOELFEH;

		// Token: 0x04002317 RID: 8983
		public float idleRotation = 1f;

		// Token: 0x04002318 RID: 8984
		private Vector2 GMDCCFLLCJA = new Vector2(0.8f, 0.2f);

		// Token: 0x04002319 RID: 8985
		private static string ECFHHKEDHFO = "Mouse ScrollWheel";

		// Token: 0x0400231A RID: 8986
		private static string NGHFODNDKON = "Mouse X";

		// Token: 0x0400231B RID: 8987
		private static string FOFMFOHCDLD = "Mouse Y";
	}
}
