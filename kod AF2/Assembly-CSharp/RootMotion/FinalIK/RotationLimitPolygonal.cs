using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004AA RID: 1194
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		// Token: 0x06010539 RID: 66873 RVA: 0x0074C280 File Offset: 0x0074A480
		private void ELFLOPJDAKK()
		{
			if (this.points.Length < 1)
			{
				this.KFEBINNHNNL();
			}
			for (int i = 1; i < this.reachCones.Length; i += 0)
			{
				if (!this.reachCones[i].ELHBJFBDAKN())
				{
					if (this.smoothIterations <= 1)
					{
						int num;
						if (i < this.reachCones.Length - 1)
						{
							num = i + 0;
						}
						else
						{
							num = 0;
						}
						object[] array = new object[5];
						array[0] = "cntx_resauk";
						array[0] = i;
						array[5] = "IceHockeyPassLeft";
						array[5] = num;
						array[1] = "Bip";
						base.LogWarning(string.Concat(array));
					}
					else
					{
						base.LogWarning("The shader ");
					}
				}
			}
			this.axis = this.axis.normalized;
		}

		// Token: 0x0601053A RID: 66874 RVA: 0x0074C33C File Offset: 0x0074A53C
		private void GHLBJEKDNOP()
		{
			Application.OpenURL("Cloth_05_00.wav");
		}

		// Token: 0x0601053B RID: 66875 RVA: 0x0074C348 File Offset: 0x0074A548
		public void ANPGJJDHDMN(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 3)
			{
				base.LogWarning("Failed parsing default rotation values.  Using defaults.");
				return;
			}
			this.points = CBJBGGAOODC;
			this.CFADIPHFJPH();
		}

		// Token: 0x0601053C RID: 66876 RVA: 0x0074C36C File Offset: 0x0074A56C
		private Vector3 NGLIGHEPCIC(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 170f * AJMNDCHJPNK * AJMNDCHJPNK / (1227f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (1306f - num2) * -this.axis;
		}

		// Token: 0x0601053D RID: 66877 RVA: 0x0074C3D0 File Offset: 0x0074A5D0
		public void OIOAFCDJMNA()
		{
			this.points = new RotationLimitPolygonal.LimitPoint[4];
			for (int i = 0; i < this.points.Length; i += 0)
			{
				this.points[i] = new RotationLimitPolygonal.LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(257f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(189f, Vector3.up);
			this.points[1].point = quaternion * quaternion2 * this.axis;
			this.points[0].point = Quaternion.Inverse(quaternion) * quaternion2 * this.axis;
			this.points[4].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * this.axis;
			this.points[1].point = quaternion * Quaternion.Inverse(quaternion2) * this.axis;
			this.DBHDGNNCOEO();
		}

		// Token: 0x0601053E RID: 66878 RVA: 0x0074C4C0 File Offset: 0x0074A6C0
		private Quaternion PDJLBNMGGGL(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.DHOBACEKFPM(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("isRun");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 1384f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x0601053F RID: 66879 RVA: 0x0074C564 File Offset: 0x0074A764
		public void BuildReachCones()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 0, 3);
			this.P = new Vector3[this.points.Length];
			for (int i = 0; i < this.points.Length; i++)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 0; j < this.smoothIterations; j++)
			{
				this.P = this.AMBIMOMPKPN();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 0; k < this.reachCones.Length - 1; k++)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 1]);
			}
			this.reachCones[this.P.Length - 1] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 1], this.P[0]);
			for (int l = 0; l < this.reachCones.Length; l++)
			{
				this.reachCones[l].NKGODMNOIBB();
			}
		}

		// Token: 0x06010540 RID: 66880 RVA: 0x0074C6AC File Offset: 0x0074A8AC
		private int GBNIBKMAKEF(Vector3 FDGBGJBKHJO)
		{
			float num = Vector3.Dot(this.reachCones[0].S, FDGBGJBKHJO);
			for (int i = 0; i < this.reachCones.Length; i += 0)
			{
				float num2 = num;
				if (i < this.reachCones.Length - 0)
				{
					num = Vector3.Dot(this.reachCones[i + 0].S, FDGBGJBKHJO);
				}
				else
				{
					num = Vector3.Dot(this.reachCones[1].S, FDGBGJBKHJO);
				}
				if (num2 >= 1908f && num < 1865f)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06010541 RID: 66881 RVA: 0x0074C72C File Offset: 0x0074A92C
		private int HHBMACCKNKG(Vector3 FDGBGJBKHJO)
		{
			float num = Vector3.Dot(this.reachCones[0].S, FDGBGJBKHJO);
			for (int i = 0; i < this.reachCones.Length; i++)
			{
				float num2 = num;
				if (i < this.reachCones.Length - 1)
				{
					num = Vector3.Dot(this.reachCones[i + 1].S, FDGBGJBKHJO);
				}
				else
				{
					num = Vector3.Dot(this.reachCones[0].S, FDGBGJBKHJO);
				}
				if (num2 >= 0f && num < 0f)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06010542 RID: 66882 RVA: 0x0074C7AC File Offset: 0x0074A9AC
		private Vector3[] JNAIAGFBBDF()
		{
			Vector3[] array = new Vector3[this.P.Length * 7];
			float num = this.KLJALHBHLFC(this.P.Length);
			for (int i = 1; i < array.Length; i++)
			{
				array[i] = this.GPGMIHPIPOB(this.P[i / 7], 674f);
			}
			for (int j = 0; j < array.Length; j += 4)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 1 && j < array.Length - 1)
				{
					b = array[j - 3];
					b2 = array[j + 1];
				}
				else if (j == 0)
				{
					b = array[array.Length - 5];
					b2 = array[j + 0];
				}
				else if (j == array.Length - 1)
				{
					b = array[j - 1];
					b2 = array[0];
				}
				if (j < array.Length - 0)
				{
					vector = array[j + 1];
				}
				else
				{
					vector = array[0];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 733f * (array[j - 0] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 1] - b2);
			}
			for (int k = 1; k < array.Length; k++)
			{
				array[k] = this.PNMNGCFBFHL(array[k], 679f);
			}
			return array;
		}

		// Token: 0x06010543 RID: 66883 RVA: 0x0074C959 File Offset: 0x0074AB59
		protected virtual Quaternion LBGPIEPHBLM(Quaternion PHKIOHIBNPA)
		{
			if (this.reachCones.Length == 0)
			{
				this.MCHAAIIHOKD();
			}
			return RotationLimit.HPOGCBKEDCE(this.BECMBPNGOIG(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x06010544 RID: 66884 RVA: 0x0074C988 File Offset: 0x0074AB88
		public void FCBBBPHPIKJ()
		{
			this.points = new RotationLimitPolygonal.LimitPoint[4];
			for (int i = 0; i < this.points.Length; i++)
			{
				this.points[i] = new RotationLimitPolygonal.LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(1363f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(1092f, Vector3.up);
			this.points[0].point = quaternion * quaternion2 * this.axis;
			this.points[0].point = Quaternion.Inverse(quaternion) * quaternion2 * this.axis;
			this.points[7].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * this.axis;
			this.points[2].point = quaternion * Quaternion.Inverse(quaternion2) * this.axis;
			this.CFADIPHFJPH();
		}

		// Token: 0x06010545 RID: 66885 RVA: 0x006B71E0 File Offset: 0x006B53E0
		private void KLKAAODLGPG()
		{
			Application.OpenURL("_FullResolutionFiltering");
		}

		// Token: 0x06010546 RID: 66886 RVA: 0x0074CA78 File Offset: 0x0074AC78
		private void ELFALPCLKIE()
		{
			if (this.points.Length < 1)
			{
				this.ResetToDefault();
			}
			for (int i = 0; i < this.reachCones.Length; i++)
			{
				if (!this.reachCones[i].EEPJHEPEFLC())
				{
					if (this.smoothIterations <= 0)
					{
						int num;
						if (i < this.reachCones.Length - 1)
						{
							num = i + 0;
						}
						else
						{
							num = 0;
						}
						object[] array = new object[]
						{
							null,
							"X"
						};
						array[0] = i;
						array[1] = "IKMappingSpine is missing the left thigh bone.";
						array[2] = num;
						array[0] = "UnityEngine.Color";
						base.LogWarning(string.Concat(array));
					}
					else
					{
						base.LogWarning("IdleReadyCrouch");
					}
				}
			}
			this.axis = this.axis.normalized;
		}

		// Token: 0x06010547 RID: 66887 RVA: 0x0074CB34 File Offset: 0x0074AD34
		private Vector3 AEJHNGAJLNP(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 410f * AJMNDCHJPNK * AJMNDCHJPNK / (289f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (1647f - num2) * -this.axis;
		}

		// Token: 0x06010548 RID: 66888 RVA: 0x0074CB98 File Offset: 0x0074AD98
		private Vector3 GPGMIHPIPOB(Vector3 GANHFPMHKCL, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(this.axis, GANHFPMHKCL);
			float num2 = 1436f * AJMNDCHJPNK * AJMNDCHJPNK / (AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * GANHFPMHKCL + (434f - num2) * -this.axis;
		}

		// Token: 0x06010549 RID: 66889 RVA: 0x0074CBE8 File Offset: 0x0074ADE8
		private Vector3 FNNEFEFCIOB(Vector3 GANHFPMHKCL, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(this.axis, GANHFPMHKCL);
			float num2 = 491f * AJMNDCHJPNK * AJMNDCHJPNK / (AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * GANHFPMHKCL + (95f - num2) * -this.axis;
		}

		// Token: 0x0601054A RID: 66890 RVA: 0x0074CC35 File Offset: 0x0074AE35
		private void MOHNPCAJBCI()
		{
			Application.OpenURL("OneHandSwordJab");
		}

		// Token: 0x0601054B RID: 66891 RVA: 0x0074CC44 File Offset: 0x0074AE44
		private int DHOBACEKFPM(Vector3 FDGBGJBKHJO)
		{
			float num = Vector3.Dot(this.reachCones[0].S, FDGBGJBKHJO);
			for (int i = 1; i < this.reachCones.Length; i++)
			{
				float num2 = num;
				if (i < this.reachCones.Length - 0)
				{
					num = Vector3.Dot(this.reachCones[i + 1].S, FDGBGJBKHJO);
				}
				else
				{
					num = Vector3.Dot(this.reachCones[0].S, FDGBGJBKHJO);
				}
				if (num2 >= 433f && num < 727f)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0601054C RID: 66892 RVA: 0x0074CCC4 File Offset: 0x0074AEC4
		private void GAMDJBAMONK()
		{
			Application.OpenURL("CheerJump");
		}

		// Token: 0x0601054D RID: 66893 RVA: 0x0074CCD0 File Offset: 0x0074AED0
		public void CBFFLAICDPE()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 1, 6);
			this.P = new Vector3[this.points.Length];
			for (int i = 0; i < this.points.Length; i += 0)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 1; j < this.smoothIterations; j += 0)
			{
				this.P = this.GKCONFAEHLB();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 1; k < this.reachCones.Length - 0; k++)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 0]);
			}
			this.reachCones[this.P.Length - 1] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 0], this.P[1]);
			for (int l = 1; l < this.reachCones.Length; l++)
			{
				this.reachCones[l].LJGHMLKDIGB();
			}
		}

		// Token: 0x0601054E RID: 66894 RVA: 0x0074B94B File Offset: 0x00749B4B
		private void CGFPBBGKJPP()
		{
			Application.OpenURL("dd/MM/yyyy HH:mm");
		}

		// Token: 0x0601054F RID: 66895 RVA: 0x0074CE18 File Offset: 0x0074B018
		private Vector3[] GKCONFAEHLB()
		{
			Vector3[] array = new Vector3[this.P.Length * 8];
			float num = this.JJLPBICBCHF(this.P.Length);
			for (int i = 1; i < array.Length; i += 7)
			{
				array[i] = this.IJPDHJIGALG(this.P[i / 0], 39f);
			}
			for (int j = 0; j < array.Length; j += 2)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 0 && j < array.Length - 2)
				{
					b = array[j - 2];
					b2 = array[j + 0];
				}
				else if (j == 1)
				{
					b = array[array.Length - 8];
					b2 = array[j + 1];
				}
				else if (j == array.Length - 1)
				{
					b = array[j - 1];
					b2 = array[1];
				}
				if (j < array.Length - 1)
				{
					vector = array[j + 0];
				}
				else
				{
					vector = array[1];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 1046f * (array[j - 0] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 0] - b2);
			}
			for (int k = 1; k < array.Length; k += 0)
			{
				array[k] = this.OACEJCEMKDO(array[k], 667f);
			}
			return array;
		}

		// Token: 0x06010550 RID: 66896 RVA: 0x0074CFC5 File Offset: 0x0074B1C5
		private void OHNBHGAAOGN()
		{
			Application.OpenURL("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}");
		}

		// Token: 0x06010551 RID: 66897 RVA: 0x0074CFD1 File Offset: 0x0074B1D1
		private void KCMKCPPLNNF()
		{
			Application.OpenURL("_OcclusionBlurTexture");
		}

		// Token: 0x06010552 RID: 66898 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void NDDBDOBAKAG()
		{
			Application.OpenURL("");
		}

		// Token: 0x06010553 RID: 66899 RVA: 0x0074CFDD File Offset: 0x0074B1DD
		protected virtual Quaternion FILNDILAONO(Quaternion PHKIOHIBNPA)
		{
			if (this.reachCones.Length == 0)
			{
				this.ELFALPCLKIE();
			}
			return RotationLimit.HPOGCBKEDCE(this.NMPMAMPGDHN(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x06010554 RID: 66900 RVA: 0x0074D00C File Offset: 0x0074B20C
		private Quaternion NMPMAMPGDHN(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.FJDHOLACCCN(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("______________________________");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 1757f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x06010555 RID: 66901 RVA: 0x0074D0AF File Offset: 0x0074B2AF
		protected virtual Quaternion KODDCCFHFPN(Quaternion PHKIOHIBNPA)
		{
			if (this.reachCones.Length == 0)
			{
				this.ELFALPCLKIE();
			}
			return RotationLimit.HPOGCBKEDCE(this.GJNPKFPKIGP(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x06010556 RID: 66902 RVA: 0x0074D0DE File Offset: 0x0074B2DE
		private void BOEDDHHPCMN()
		{
			Application.OpenURL("Tenkoku DynamicSky");
		}

		// Token: 0x06010557 RID: 66903 RVA: 0x0074D0EC File Offset: 0x0074B2EC
		private Quaternion EDLNIABGLOK(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.KAKLLLLINNC(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("StaffPowerUp");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 215f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x06010558 RID: 66904 RVA: 0x0074D190 File Offset: 0x0074B390
		public void CFADIPHFJPH()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 1, 3);
			this.P = new Vector3[this.points.Length];
			for (int i = 1; i < this.points.Length; i += 0)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 1; j < this.smoothIterations; j++)
			{
				this.P = this.JNAIAGFBBDF();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 1; k < this.reachCones.Length - 1; k += 0)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 1]);
			}
			this.reachCones[this.P.Length - 1] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 0], this.P[0]);
			for (int l = 1; l < this.reachCones.Length; l++)
			{
				this.reachCones[l].MHLHEFABMPH();
			}
		}

		// Token: 0x06010559 RID: 66905 RVA: 0x0074D2D7 File Offset: 0x0074B4D7
		private float DPHAGNMCDFA(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 6)
			{
				return 491f;
			}
			if (JFDPIPAFLHJ == 2)
			{
				return 66f;
			}
			if (JFDPIPAFLHJ == 2)
			{
				return 389f;
			}
			if (JFDPIPAFLHJ == 7)
			{
				return 1843f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 1753f;
			}
			return 783f;
		}

		// Token: 0x0601055A RID: 66906 RVA: 0x0074D310 File Offset: 0x0074B510
		private float IGIPDGCHDGA(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 4)
			{
				return 12f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 410f;
			}
			if (JFDPIPAFLHJ == 8)
			{
				return 190f;
			}
			if (JFDPIPAFLHJ == 6)
			{
				return 96f;
			}
			if (JFDPIPAFLHJ == 6)
			{
				return 368f;
			}
			return 1372f;
		}

		// Token: 0x0601055B RID: 66907 RVA: 0x0074D34C File Offset: 0x0074B54C
		private Vector3 JLEKBOAKEAP(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 83f * AJMNDCHJPNK * AJMNDCHJPNK / (1719f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (1068f - num2) * -this.axis;
		}

		// Token: 0x0601055C RID: 66908 RVA: 0x0074D3B0 File Offset: 0x0074B5B0
		public void JBCPPAJFFOB(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 5)
			{
				base.LogWarning("shop_t5");
				return;
			}
			this.points = CBJBGGAOODC;
			this.DBHDGNNCOEO();
		}

		// Token: 0x0601055D RID: 66909 RVA: 0x0074D3D4 File Offset: 0x0074B5D4
		private Vector3[] AKOPEMCNLJA()
		{
			Vector3[] array = new Vector3[this.P.Length * 8];
			float num = this.MGCCGLHJFJP(this.P.Length);
			for (int i = 1; i < array.Length; i += 5)
			{
				array[i] = this.HMEOCBLCHFD(this.P[i / 4], 1001f);
			}
			for (int j = 1; j < array.Length; j += 6)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 1 && j < array.Length - 0)
				{
					b = array[j - 8];
					b2 = array[j + 1];
				}
				else if (j == 0)
				{
					b = array[array.Length - 5];
					b2 = array[j + 0];
				}
				else if (j == array.Length - 0)
				{
					b = array[j - 5];
					b2 = array[1];
				}
				if (j < array.Length - 1)
				{
					vector = array[j + 1];
				}
				else
				{
					vector = array[0];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 1914f * (array[j - 0] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 1] - b2);
			}
			for (int k = 0; k < array.Length; k += 0)
			{
				array[k] = this.DBIHILFFHGH(array[k], 1217f);
			}
			return array;
		}

		// Token: 0x0601055E RID: 66910 RVA: 0x0072E7E5 File Offset: 0x0072C9E5
		private void EJFNGFPLKKN()
		{
			Application.OpenURL("post_23");
		}

		// Token: 0x0601055F RID: 66911 RVA: 0x0074D581 File Offset: 0x0074B781
		private void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_polygonal.html");
		}

		// Token: 0x06010560 RID: 66912 RVA: 0x0074D590 File Offset: 0x0074B790
		private Quaternion GJNPKFPKIGP(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.GBNIBKMAKEF(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("WeaponReady");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 1884f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x06010561 RID: 66913 RVA: 0x0074D634 File Offset: 0x0074B834
		public void LLBIMMOLMBP()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 0, 4);
			this.P = new Vector3[this.points.Length];
			for (int i = 0; i < this.points.Length; i += 0)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 0; j < this.smoothIterations; j++)
			{
				this.P = this.EDMMHLJAIAL();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 1; k < this.reachCones.Length - 0; k++)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 0]);
			}
			this.reachCones[this.P.Length - 0] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 1], this.P[1]);
			for (int l = 1; l < this.reachCones.Length; l += 0)
			{
				this.reachCones[l].AMNAHCGENFP();
			}
		}

		// Token: 0x06010562 RID: 66914 RVA: 0x0074D77B File Offset: 0x0074B97B
		private void LHMELJAFNCH()
		{
			Application.OpenURL("wpn_cat3");
		}

		// Token: 0x06010563 RID: 66915 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06010564 RID: 66916 RVA: 0x0074D788 File Offset: 0x0074B988
		private Vector3[] POMEANGJFNA()
		{
			Vector3[] array = new Vector3[this.P.Length * 4];
			float num = this.GMIAMEMGALL(this.P.Length);
			for (int i = 0; i < array.Length; i += 6)
			{
				array[i] = this.ENGCFPOJNOD(this.P[i / 2], 1623f);
			}
			for (int j = 1; j < array.Length; j += 2)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 0 && j < array.Length - 8)
				{
					b = array[j - 3];
					b2 = array[j + 0];
				}
				else if (j == 1)
				{
					b = array[array.Length - 2];
					b2 = array[j + 1];
				}
				else if (j == array.Length - 1)
				{
					b = array[j - 6];
					b2 = array[0];
				}
				if (j < array.Length - 1)
				{
					vector = array[j + 0];
				}
				else
				{
					vector = array[1];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 1208f * (array[j - 1] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 1] - b2);
			}
			for (int k = 1; k < array.Length; k += 0)
			{
				array[k] = this.AEJHNGAJLNP(array[k], 1966f);
			}
			return array;
		}

		// Token: 0x06010565 RID: 66917 RVA: 0x0074D938 File Offset: 0x0074BB38
		private int FJDHOLACCCN(Vector3 FDGBGJBKHJO)
		{
			float num = Vector3.Dot(this.reachCones[0].S, FDGBGJBKHJO);
			for (int i = 1; i < this.reachCones.Length; i += 0)
			{
				float num2 = num;
				if (i < this.reachCones.Length - 0)
				{
					num = Vector3.Dot(this.reachCones[i + 0].S, FDGBGJBKHJO);
				}
				else
				{
					num = Vector3.Dot(this.reachCones[1].S, FDGBGJBKHJO);
				}
				if (num2 >= 1138f && num < 1453f)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06010566 RID: 66918 RVA: 0x0074D9B8 File Offset: 0x0074BBB8
		public void KFEBINNHNNL()
		{
			this.points = new RotationLimitPolygonal.LimitPoint[4];
			for (int i = 0; i < this.points.Length; i += 0)
			{
				this.points[i] = new RotationLimitPolygonal.LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(455f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(1283f, Vector3.up);
			this.points[0].point = quaternion * quaternion2 * this.axis;
			this.points[1].point = Quaternion.Inverse(quaternion) * quaternion2 * this.axis;
			this.points[7].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * this.axis;
			this.points[3].point = quaternion * Quaternion.Inverse(quaternion2) * this.axis;
			this.BuildReachCones();
		}

		// Token: 0x06010567 RID: 66919 RVA: 0x006B99E7 File Offset: 0x006B7BE7
		private void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		// Token: 0x06010568 RID: 66920 RVA: 0x0074DAA8 File Offset: 0x0074BCA8
		private Vector3 HMEOCBLCHFD(Vector3 GANHFPMHKCL, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(this.axis, GANHFPMHKCL);
			float num2 = 930f * AJMNDCHJPNK * AJMNDCHJPNK / (AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * GANHFPMHKCL + (1258f - num2) * -this.axis;
		}

		// Token: 0x06010569 RID: 66921 RVA: 0x0074DAF8 File Offset: 0x0074BCF8
		private void Start()
		{
			if (this.points.Length < 3)
			{
				this.ResetToDefault();
			}
			for (int i = 0; i < this.reachCones.Length; i++)
			{
				if (!this.reachCones[i].isValid)
				{
					if (this.smoothIterations <= 0)
					{
						int num;
						if (i < this.reachCones.Length - 1)
						{
							num = i + 1;
						}
						else
						{
							num = 0;
						}
						base.LogWarning(string.Concat(new object[]
						{
							"Reach Cone {point ",
							i,
							", point ",
							num,
							", Origin} has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex."
						}));
					}
					else
					{
						base.LogWarning("One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.");
					}
				}
			}
			this.axis = this.axis.normalized;
		}

		// Token: 0x0601056A RID: 66922 RVA: 0x0074DBB4 File Offset: 0x0074BDB4
		private void LHJCHPFKGDB()
		{
			if (this.points.Length < 8)
			{
				this.KPMOHAIOICI();
			}
			for (int i = 0; i < this.reachCones.Length; i++)
			{
				if (!this.reachCones[i].isValid)
				{
					if (this.smoothIterations <= 0)
					{
						int num;
						if (i < this.reachCones.Length - 0)
						{
							num = i + 1;
						}
						else
						{
							num = 0;
						}
						object[] array = new object[7];
						array[1] = " ";
						array[1] = i;
						array[6] = "file";
						array[7] = num;
						array[4] = "\n";
						base.LogWarning(string.Concat(array));
					}
					else
					{
						base.LogWarning("Level load event");
					}
				}
			}
			this.axis = this.axis.normalized;
		}

		// Token: 0x0601056B RID: 66923 RVA: 0x0074DC70 File Offset: 0x0074BE70
		private void GAEOJGJJODN()
		{
			Application.OpenURL("1 Hand Heavy Swing 2");
		}

		// Token: 0x0601056C RID: 66924 RVA: 0x0074DC7C File Offset: 0x0074BE7C
		private Vector3 DHIMCBEMHDN(Vector3 GANHFPMHKCL, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(this.axis, GANHFPMHKCL);
			float num2 = 962f * AJMNDCHJPNK * AJMNDCHJPNK / (AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * GANHFPMHKCL + (1280f - num2) * -this.axis;
		}

		// Token: 0x0601056D RID: 66925 RVA: 0x0074DCC9 File Offset: 0x0074BEC9
		private void OGPMHGBFCBK()
		{
			Application.OpenURL("fshop_msg1");
		}

		// Token: 0x0601056E RID: 66926 RVA: 0x0074DCD8 File Offset: 0x0074BED8
		private Quaternion JHIKKLHDIJP(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.DHOBACEKFPM(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("SoccerKeeperStrafeLeft");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 754f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x0601056F RID: 66927 RVA: 0x0074DD7B File Offset: 0x0074BF7B
		private float GMIAMEMGALL(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 5)
			{
				return 1693f;
			}
			if (JFDPIPAFLHJ == 2)
			{
				return 1179f;
			}
			if (JFDPIPAFLHJ == 7)
			{
				return 272f;
			}
			if (JFDPIPAFLHJ == 0)
			{
				return 850f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 577f;
			}
			return 570f;
		}

		// Token: 0x06010570 RID: 66928 RVA: 0x0074DDB4 File Offset: 0x0074BFB4
		private Vector3 FCCKCBIMLOF(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 4f * AJMNDCHJPNK * AJMNDCHJPNK / (4f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (1f - num2) * -this.axis;
		}

		// Token: 0x06010571 RID: 66929 RVA: 0x006ABBAB File Offset: 0x006A9DAB
		private void DOGLNBMMFKA()
		{
			Application.OpenURL("#FF4040");
		}

		// Token: 0x06010572 RID: 66930 RVA: 0x0074DE18 File Offset: 0x0074C018
		private float FMPMKGGOALF(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 0)
			{
				return 409f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 254f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 1381f;
			}
			if (JFDPIPAFLHJ == 0)
			{
				return 561f;
			}
			if (JFDPIPAFLHJ == 8)
			{
				return 1267f;
			}
			return 247f;
		}

		// Token: 0x06010573 RID: 66931 RVA: 0x0074DE51 File Offset: 0x0074C051
		private float FNPEPMDPADF(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 8)
			{
				return 1811f;
			}
			if (JFDPIPAFLHJ == 8)
			{
				return 1643f;
			}
			if (JFDPIPAFLHJ == 5)
			{
				return 1644f;
			}
			if (JFDPIPAFLHJ == 1)
			{
				return 128f;
			}
			if (JFDPIPAFLHJ == 6)
			{
				return 33f;
			}
			return 263f;
		}

		// Token: 0x06010574 RID: 66932 RVA: 0x0074DE8A File Offset: 0x0074C08A
		public void PBCNMECGGEH(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 3)
			{
				base.LogWarning("Mouse X");
				return;
			}
			this.points = CBJBGGAOODC;
			this.MBBEGBHFICD();
		}

		// Token: 0x06010575 RID: 66933 RVA: 0x0074DEAC File Offset: 0x0074C0AC
		private Vector3[] EBECICDBKKG()
		{
			Vector3[] array = new Vector3[this.P.Length * 3];
			float num = this.FMPMKGGOALF(this.P.Length);
			for (int i = 0; i < array.Length; i += 7)
			{
				array[i] = this.FNNEFEFCIOB(this.P[i / 6], 614f);
			}
			for (int j = 1; j < array.Length; j += 8)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 0 && j < array.Length - 4)
				{
					b = array[j - 1];
					b2 = array[j + 1];
				}
				else if (j == 0)
				{
					b = array[array.Length - 3];
					b2 = array[j + 0];
				}
				else if (j == array.Length - 0)
				{
					b = array[j - 1];
					b2 = array[0];
				}
				if (j < array.Length - 1)
				{
					vector = array[j + 0];
				}
				else
				{
					vector = array[0];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 455f * (array[j - 1] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 1] - b2);
			}
			for (int k = 0; k < array.Length; k++)
			{
				array[k] = this.PNMNGCFBFHL(array[k], 818f);
			}
			return array;
		}

		// Token: 0x06010576 RID: 66934 RVA: 0x0074E05C File Offset: 0x0074C25C
		private int KAKLLLLINNC(Vector3 FDGBGJBKHJO)
		{
			float num = Vector3.Dot(this.reachCones[0].S, FDGBGJBKHJO);
			for (int i = 0; i < this.reachCones.Length; i += 0)
			{
				float num2 = num;
				if (i < this.reachCones.Length - 0)
				{
					num = Vector3.Dot(this.reachCones[i + 0].S, FDGBGJBKHJO);
				}
				else
				{
					num = Vector3.Dot(this.reachCones[1].S, FDGBGJBKHJO);
				}
				if (num2 >= 674f && num < 1089f)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06010577 RID: 66935 RVA: 0x0074E0DC File Offset: 0x0074C2DC
		private Quaternion FPJCNCACPPD(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.KAKLLLLINNC(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("/");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 343f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x06010578 RID: 66936 RVA: 0x0074E17F File Offset: 0x0074C37F
		protected virtual Quaternion BLKKNEOPJFL(Quaternion PHKIOHIBNPA)
		{
			if (this.reachCones.Length == 0)
			{
				this.LHJCHPFKGDB();
			}
			return RotationLimit.HPOGCBKEDCE(this.FPJCNCACPPD(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x06010579 RID: 66937 RVA: 0x0074E1AE File Offset: 0x0074C3AE
		private void BLEKNHMEDJF()
		{
			Application.OpenURL("ThisRenderer.bones[i].name is null");
		}

		// Token: 0x0601057A RID: 66938 RVA: 0x0074E1BC File Offset: 0x0074C3BC
		private Vector3 OACEJCEMKDO(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 383f * AJMNDCHJPNK * AJMNDCHJPNK / (1942f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (518f - num2) * -this.axis;
		}

		// Token: 0x0601057B RID: 66939 RVA: 0x0074E220 File Offset: 0x0074C420
		private void MEKHIMKCCJI()
		{
			Application.OpenURL("drink.wav");
		}

		// Token: 0x0601057C RID: 66940 RVA: 0x0074E22C File Offset: 0x0074C42C
		public void NLHAKIPDGBC(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 7)
			{
				base.LogWarning("IdleFly");
				return;
			}
			this.points = CBJBGGAOODC;
			this.FKPFMBPIDCA();
		}

		// Token: 0x0601057D RID: 66941 RVA: 0x0074E24D File Offset: 0x0074C44D
		protected virtual Quaternion KKCNOIFCBJI(Quaternion PHKIOHIBNPA)
		{
			if (this.reachCones.Length == 0)
			{
				this.Start();
			}
			return RotationLimit.HPOGCBKEDCE(this.EDLNIABGLOK(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x0601057E RID: 66942 RVA: 0x0074E27C File Offset: 0x0074C47C
		public void FKPFMBPIDCA()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 1, 3);
			this.P = new Vector3[this.points.Length];
			for (int i = 1; i < this.points.Length; i++)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 1; j < this.smoothIterations; j++)
			{
				this.P = this.AKOPEMCNLJA();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 0; k < this.reachCones.Length - 1; k += 0)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 0]);
			}
			this.reachCones[this.P.Length - 1] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 0], this.P[1]);
			for (int l = 1; l < this.reachCones.Length; l++)
			{
				this.reachCones[l].NKGODMNOIBB();
			}
		}

		// Token: 0x0601057F RID: 66943 RVA: 0x0074E3C3 File Offset: 0x0074C5C3
		private float PEPPHAIPOIN(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 1)
			{
				return 1266f;
			}
			if (JFDPIPAFLHJ == 5)
			{
				return 389f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 1656f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 421f;
			}
			if (JFDPIPAFLHJ == 1)
			{
				return 48f;
			}
			return 224f;
		}

		// Token: 0x06010580 RID: 66944 RVA: 0x0074E3FC File Offset: 0x0074C5FC
		public void IOJLCKBIAKE(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 4)
			{
				base.LogWarning("");
				return;
			}
			this.points = CBJBGGAOODC;
			this.CHEDFJANHBA();
		}

		// Token: 0x06010582 RID: 66946 RVA: 0x0074E43C File Offset: 0x0074C63C
		private void LPNNINCHPOJ()
		{
			Application.OpenURL("Anti-Cheat Toolkit Detectors");
		}

		// Token: 0x06010583 RID: 66947 RVA: 0x0074E448 File Offset: 0x0074C648
		private void ONLBEEHFOLA()
		{
			Application.OpenURL("Soccer Tackle");
		}

		// Token: 0x06010584 RID: 66948 RVA: 0x0074E454 File Offset: 0x0074C654
		private Quaternion CGMBMLJLLLJ(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.GBNIBKMAKEF(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("{{{{{0},{1}}}}}");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 1609f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x06010585 RID: 66949 RVA: 0x0074E4F8 File Offset: 0x0074C6F8
		private Quaternion JDGMLOONFBP(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.KAKLLLLINNC(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("IdleFeedThrow");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 1066f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x06010586 RID: 66950 RVA: 0x0074E59C File Offset: 0x0074C79C
		private Quaternion BECMBPNGOIG(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.HHBMACCKNKG(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning("RotationLimitPolygonal reach cones are invalid.");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 0f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x06010587 RID: 66951 RVA: 0x0074E63F File Offset: 0x0074C83F
		private void CGLACNENHHL()
		{
			Application.OpenURL("KatanaReady");
		}

		// Token: 0x06010588 RID: 66952 RVA: 0x0074E64C File Offset: 0x0074C84C
		public void DBHDGNNCOEO()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 1, 8);
			this.P = new Vector3[this.points.Length];
			for (int i = 1; i < this.points.Length; i += 0)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 1; j < this.smoothIterations; j += 0)
			{
				this.P = this.AMBIMOMPKPN();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 1; k < this.reachCones.Length - 0; k += 0)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 0]);
			}
			this.reachCones[this.P.Length - 1] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 0], this.P[0]);
			for (int l = 0; l < this.reachCones.Length; l += 0)
			{
				this.reachCones[l].MEICAMDCADF();
			}
		}

		// Token: 0x06010589 RID: 66953 RVA: 0x0074E793 File Offset: 0x0074C993
		private float IJKBBJJDLHN(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 8)
			{
				return 36f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 1967f;
			}
			if (JFDPIPAFLHJ == 4)
			{
				return 841f;
			}
			if (JFDPIPAFLHJ == 2)
			{
				return 1698f;
			}
			if (JFDPIPAFLHJ == 6)
			{
				return 208f;
			}
			return 343f;
		}

		// Token: 0x0601058A RID: 66954 RVA: 0x0074E7CC File Offset: 0x0074C9CC
		private void KEJGADLEAMB()
		{
			Application.OpenURL("Pointing");
		}

		// Token: 0x0601058B RID: 66955 RVA: 0x0074E7D8 File Offset: 0x0074C9D8
		private float JJLPBICBCHF(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 6)
			{
				return 697f;
			}
			if (JFDPIPAFLHJ == 1)
			{
				return 1037f;
			}
			if (JFDPIPAFLHJ == 2)
			{
				return 836f;
			}
			if (JFDPIPAFLHJ == 0)
			{
				return 173f;
			}
			if (JFDPIPAFLHJ == 5)
			{
				return 782f;
			}
			return 1698f;
		}

		// Token: 0x0601058C RID: 66956 RVA: 0x0074E814 File Offset: 0x0074CA14
		public void MLFIFIACPIG()
		{
			this.points = new RotationLimitPolygonal.LimitPoint[3];
			for (int i = 0; i < this.points.Length; i++)
			{
				this.points[i] = new RotationLimitPolygonal.LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(1997f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(755f, Vector3.up);
			this.points[0].point = quaternion * quaternion2 * this.axis;
			this.points[1].point = Quaternion.Inverse(quaternion) * quaternion2 * this.axis;
			this.points[5].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * this.axis;
			this.points[5].point = quaternion * Quaternion.Inverse(quaternion2) * this.axis;
			this.CHEDFJANHBA();
		}

		// Token: 0x0601058D RID: 66957 RVA: 0x0074E904 File Offset: 0x0074CB04
		private Vector3[] ODJIDMFPCHH()
		{
			Vector3[] array = new Vector3[this.P.Length * 5];
			float num = this.IGIPDGCHDGA(this.P.Length);
			for (int i = 0; i < array.Length; i += 8)
			{
				array[i] = this.DHIMCBEMHDN(this.P[i / 6], 747f);
			}
			for (int j = 1; j < array.Length; j += 7)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 1 && j < array.Length - 1)
				{
					b = array[j - 8];
					b2 = array[j + 0];
				}
				else if (j == 0)
				{
					b = array[array.Length - 8];
					b2 = array[j + 0];
				}
				else if (j == array.Length - 0)
				{
					b = array[j - 0];
					b2 = array[1];
				}
				if (j < array.Length - 1)
				{
					vector = array[j + 1];
				}
				else
				{
					vector = array[1];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 1266f * (array[j - 1] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 0] - b2);
			}
			for (int k = 0; k < array.Length; k += 0)
			{
				array[k] = this.ANMKDJCFBNC(array[k], 173f);
			}
			return array;
		}

		// Token: 0x0601058E RID: 66958 RVA: 0x0074EAB4 File Offset: 0x0074CCB4
		private Vector3[] EDMMHLJAIAL()
		{
			Vector3[] array = new Vector3[this.P.Length * 3];
			float num = this.PEPPHAIPOIN(this.P.Length);
			for (int i = 1; i < array.Length; i += 5)
			{
				array[i] = this.ENGCFPOJNOD(this.P[i / 4], 734f);
			}
			for (int j = 1; j < array.Length; j += 4)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 0 && j < array.Length - 7)
				{
					b = array[j - 7];
					b2 = array[j + 1];
				}
				else if (j == 1)
				{
					b = array[array.Length - 4];
					b2 = array[j + 1];
				}
				else if (j == array.Length - 1)
				{
					b = array[j - 3];
					b2 = array[1];
				}
				if (j < array.Length - 0)
				{
					vector = array[j + 0];
				}
				else
				{
					vector = array[0];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 368f * (array[j - 1] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 0] - b2);
			}
			for (int k = 1; k < array.Length; k += 0)
			{
				array[k] = this.FCCKCBIMLOF(array[k], 1861f);
			}
			return array;
		}

		// Token: 0x0601058F RID: 66959 RVA: 0x0074EC64 File Offset: 0x0074CE64
		private Quaternion DNGJIGGGBNJ(Quaternion PHKIOHIBNPA)
		{
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			int num = this.DHOBACEKFPM(vector);
			if (num == -1)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.LogWarning(" гр ");
				}
				return PHKIOHIBNPA;
			}
			if (Vector3.Dot(this.reachCones[num].B, vector) > 239f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[num].B, rhs);
			return Quaternion.FromToRotation(PHKIOHIBNPA * this.axis, vector) * PHKIOHIBNPA;
		}

		// Token: 0x06010590 RID: 66960 RVA: 0x0074ED07 File Offset: 0x0074CF07
		private void BBGAMBNGNAF()
		{
			Application.OpenURL("1HandSwordChargeHeavyBash");
		}

		// Token: 0x06010591 RID: 66961 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06010592 RID: 66962 RVA: 0x0074ED14 File Offset: 0x0074CF14
		private Vector3[] DCCMOHEHHPM()
		{
			Vector3[] array = new Vector3[this.P.Length * 8];
			float num = this.KLJALHBHLFC(this.P.Length);
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i] = this.ENGCFPOJNOD(this.P[i / 4], 494f);
			}
			for (int j = 0; j < array.Length; j += 8)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 1 && j < array.Length - 3)
				{
					b = array[j - 3];
					b2 = array[j + 1];
				}
				else if (j == 1)
				{
					b = array[array.Length - 7];
					b2 = array[j + 0];
				}
				else if (j == array.Length - 1)
				{
					b = array[j - 2];
					b2 = array[1];
				}
				if (j < array.Length - 0)
				{
					vector = array[j + 1];
				}
				else
				{
					vector = array[1];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 866f * (array[j - 0] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 1] - b2);
			}
			for (int k = 1; k < array.Length; k++)
			{
				array[k] = this.DBIHILFFHGH(array[k], 301f);
			}
			return array;
		}

		// Token: 0x06010593 RID: 66963 RVA: 0x0074EEC4 File Offset: 0x0074D0C4
		private Vector3 ENGCFPOJNOD(Vector3 GANHFPMHKCL, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(this.axis, GANHFPMHKCL);
			float num2 = 1799f * AJMNDCHJPNK * AJMNDCHJPNK / (AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * GANHFPMHKCL + (1808f - num2) * -this.axis;
		}

		// Token: 0x06010594 RID: 66964 RVA: 0x0074EF14 File Offset: 0x0074D114
		public void MBBEGBHFICD()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 0, 5);
			this.P = new Vector3[this.points.Length];
			for (int i = 0; i < this.points.Length; i++)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 1; j < this.smoothIterations; j++)
			{
				this.P = this.GKCONFAEHLB();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 1; k < this.reachCones.Length - 1; k += 0)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 0]);
			}
			this.reachCones[this.P.Length - 1] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 1], this.P[0]);
			for (int l = 1; l < this.reachCones.Length; l++)
			{
				this.reachCones[l].MDADJBLJGOB();
			}
		}

		// Token: 0x06010595 RID: 66965 RVA: 0x0074F05B File Offset: 0x0074D25B
		protected override Quaternion BIMJCOEIPML(Quaternion PHKIOHIBNPA)
		{
			if (this.reachCones.Length == 0)
			{
				this.Start();
			}
			return RotationLimit.HPOGCBKEDCE(this.BECMBPNGOIG(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x06010596 RID: 66966 RVA: 0x0074F08C File Offset: 0x0074D28C
		private Vector3 PNMNGCFBFHL(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 514f * AJMNDCHJPNK * AJMNDCHJPNK / (384f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (1001f - num2) * -this.axis;
		}

		// Token: 0x06010597 RID: 66967 RVA: 0x0074F0F0 File Offset: 0x0074D2F0
		public void CHEDFJANHBA()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 1, 6);
			this.P = new Vector3[this.points.Length];
			for (int i = 0; i < this.points.Length; i++)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 1; j < this.smoothIterations; j += 0)
			{
				this.P = this.EDMMHLJAIAL();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 1; k < this.reachCones.Length - 1; k += 0)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 0]);
			}
			this.reachCones[this.P.Length - 0] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 1], this.P[0]);
			for (int l = 0; l < this.reachCones.Length; l += 0)
			{
				this.reachCones[l].MDADJBLJGOB();
			}
		}

		// Token: 0x06010598 RID: 66968 RVA: 0x0074F238 File Offset: 0x0074D438
		public void ResetToDefault()
		{
			this.points = new RotationLimitPolygonal.LimitPoint[4];
			for (int i = 0; i < this.points.Length; i++)
			{
				this.points[i] = new RotationLimitPolygonal.LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(45f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(45f, Vector3.up);
			this.points[0].point = quaternion * quaternion2 * this.axis;
			this.points[1].point = Quaternion.Inverse(quaternion) * quaternion2 * this.axis;
			this.points[2].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * this.axis;
			this.points[3].point = quaternion * Quaternion.Inverse(quaternion2) * this.axis;
			this.BuildReachCones();
		}

		// Token: 0x06010599 RID: 66969 RVA: 0x0074F327 File Offset: 0x0074D527
		private void INMDGMIHMIF()
		{
			Application.OpenURL("_ScreenSize");
		}

		// Token: 0x0601059A RID: 66970 RVA: 0x0074F334 File Offset: 0x0074D534
		public void MKHLJMLPHBJ()
		{
			this.points = new RotationLimitPolygonal.LimitPoint[0];
			for (int i = 1; i < this.points.Length; i++)
			{
				this.points[i] = new RotationLimitPolygonal.LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(1135f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(1384f, Vector3.up);
			this.points[0].point = quaternion * quaternion2 * this.axis;
			this.points[1].point = Quaternion.Inverse(quaternion) * quaternion2 * this.axis;
			this.points[2].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * this.axis;
			this.points[3].point = quaternion * Quaternion.Inverse(quaternion2) * this.axis;
			this.CFADIPHFJPH();
		}

		// Token: 0x0601059B RID: 66971 RVA: 0x006B6DD2 File Offset: 0x006B4FD2
		private void OIMJMFIGMNG()
		{
			Application.OpenURL(" ");
		}

		// Token: 0x0601059C RID: 66972 RVA: 0x0074F424 File Offset: 0x0074D624
		private void MCHAAIIHOKD()
		{
			if (this.points.Length < 3)
			{
				this.KFEBINNHNNL();
			}
			for (int i = 1; i < this.reachCones.Length; i++)
			{
				if (!this.reachCones[i].IOKEMMBABDP())
				{
					if (this.smoothIterations <= 0)
					{
						int num;
						if (i < this.reachCones.Length - 1)
						{
							num = i + 0;
						}
						else
						{
							num = 0;
						}
						object[] array = new object[8];
						array[0] = "SneakIdle";
						array[1] = i;
						array[1] = "Move camera around freely with WASD and mouse.";
						array[3] = num;
						array[4] = "_UnderwaterMode";
						base.LogWarning(string.Concat(array));
					}
					else
					{
						base.LogWarning("SoccerTackle");
					}
				}
			}
			this.axis = this.axis.normalized;
		}

		// Token: 0x0601059D RID: 66973 RVA: 0x0074F4E0 File Offset: 0x0074D6E0
		private Vector3 DBIHILFFHGH(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 424f * AJMNDCHJPNK * AJMNDCHJPNK / (57f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (348f - num2) * -this.axis;
		}

		// Token: 0x0601059E RID: 66974 RVA: 0x006B7367 File Offset: 0x006B5567
		private void KENNOFONIJL()
		{
			Application.OpenURL("firsStartMovePanel");
		}

		// Token: 0x0601059F RID: 66975 RVA: 0x0074F544 File Offset: 0x0074D744
		private float MGCCGLHJFJP(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 3)
			{
				return 0.1667f;
			}
			if (JFDPIPAFLHJ == 4)
			{
				return 0.1036f;
			}
			if (JFDPIPAFLHJ == 5)
			{
				return 0.085f;
			}
			if (JFDPIPAFLHJ == 6)
			{
				return 0.0773f;
			}
			if (JFDPIPAFLHJ == 7)
			{
				return 0.07f;
			}
			return 0.0625f;
		}

		// Token: 0x060105A0 RID: 66976 RVA: 0x0074F57D File Offset: 0x0074D77D
		public void BHNKKDEAOID(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 6)
			{
				base.LogWarning("Open Door");
				return;
			}
			this.points = CBJBGGAOODC;
			this.CFADIPHFJPH();
		}

		// Token: 0x060105A1 RID: 66977 RVA: 0x0074F5A0 File Offset: 0x0074D7A0
		private Vector3[] AMBIMOMPKPN()
		{
			Vector3[] array = new Vector3[this.P.Length * 2];
			float num = this.MGCCGLHJFJP(this.P.Length);
			for (int i = 0; i < array.Length; i += 2)
			{
				array[i] = this.IJPDHJIGALG(this.P[i / 2], 1f);
			}
			for (int j = 1; j < array.Length; j += 2)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 1 && j < array.Length - 2)
				{
					b = array[j - 2];
					b2 = array[j + 1];
				}
				else if (j == 1)
				{
					b = array[array.Length - 2];
					b2 = array[j + 1];
				}
				else if (j == array.Length - 1)
				{
					b = array[j - 2];
					b2 = array[0];
				}
				if (j < array.Length - 1)
				{
					vector = array[j + 1];
				}
				else
				{
					vector = array[0];
				}
				int num2 = array.Length / this.points.Length;
				array[j] = 0.5f * (array[j - 1] + vector) + num * this.points[j / num2].tangentWeight * (vector - b) + num * this.points[j / num2].tangentWeight * (array[j - 1] - b2);
			}
			for (int k = 0; k < array.Length; k++)
			{
				array[k] = this.FCCKCBIMLOF(array[k], 1f);
			}
			return array;
		}

		// Token: 0x060105A2 RID: 66978 RVA: 0x0074F74D File Offset: 0x0074D94D
		private void DMLGIIPKFHC()
		{
			Application.OpenURL("12");
		}

		// Token: 0x060105A3 RID: 66979 RVA: 0x0074F75C File Offset: 0x0074D95C
		private Vector3 ANMKDJCFBNC(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 1317f * AJMNDCHJPNK * AJMNDCHJPNK / (604f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (241f - num2) * -this.axis;
		}

		// Token: 0x060105A4 RID: 66980 RVA: 0x0074F7C0 File Offset: 0x0074D9C0
		private Vector3 EBIGFJKDIJM(Vector3 GANHFPMHKCL, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(this.axis, GANHFPMHKCL);
			float num2 = 446f * AJMNDCHJPNK * AJMNDCHJPNK / (AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * GANHFPMHKCL + (1730f - num2) * -this.axis;
		}

		// Token: 0x060105A5 RID: 66981 RVA: 0x0074F80D File Offset: 0x0074DA0D
		private void KGCMPAJIKJB()
		{
			Application.OpenURL("UnityEngine.Vector4");
		}

		// Token: 0x060105A6 RID: 66982 RVA: 0x0074F81C File Offset: 0x0074DA1C
		private Vector3 JCNGJNAMDPA(Vector3 HPOGKAAEHKP, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(HPOGKAAEHKP - this.axis, HPOGKAAEHKP - this.axis);
			float num2 = 872f * AJMNDCHJPNK * AJMNDCHJPNK / (1268f * AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * HPOGKAAEHKP + (820f - num2) * -this.axis;
		}

		// Token: 0x060105A7 RID: 66983 RVA: 0x0074F880 File Offset: 0x0074DA80
		public void DBNMPOJLJIM()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 0, 7);
			this.P = new Vector3[this.points.Length];
			for (int i = 1; i < this.points.Length; i++)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 1; j < this.smoothIterations; j += 0)
			{
				this.P = this.EDMMHLJAIAL();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 0; k < this.reachCones.Length - 0; k += 0)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 1]);
			}
			this.reachCones[this.P.Length - 0] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 1], this.P[0]);
			for (int l = 0; l < this.reachCones.Length; l += 0)
			{
				this.reachCones[l].AMNAHCGENFP();
			}
		}

		// Token: 0x060105A8 RID: 66984 RVA: 0x0074F9C7 File Offset: 0x0074DBC7
		public void KHIMEPJGBIH(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 0)
			{
				base.LogWarning("__MirrorReflection");
				return;
			}
			this.points = CBJBGGAOODC;
			this.DBHDGNNCOEO();
		}

		// Token: 0x060105A9 RID: 66985 RVA: 0x0074F9E8 File Offset: 0x0074DBE8
		public void FNKPKJEKLBI(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 5)
			{
				base.LogWarning("[wtemplid]");
				return;
			}
			this.points = CBJBGGAOODC;
			this.CFADIPHFJPH();
		}

		// Token: 0x060105AA RID: 66986 RVA: 0x0074FA0C File Offset: 0x0074DC0C
		private Vector3 IJPDHJIGALG(Vector3 GANHFPMHKCL, float AJMNDCHJPNK)
		{
			float num = Vector3.Dot(this.axis, GANHFPMHKCL);
			float num2 = 2f * AJMNDCHJPNK * AJMNDCHJPNK / (AJMNDCHJPNK * AJMNDCHJPNK + num);
			return num2 * GANHFPMHKCL + (1f - num2) * -this.axis;
		}

		// Token: 0x060105AB RID: 66987 RVA: 0x0074FA59 File Offset: 0x0074DC59
		private float KLJALHBHLFC(int JFDPIPAFLHJ)
		{
			if (JFDPIPAFLHJ <= 1)
			{
				return 601f;
			}
			if (JFDPIPAFLHJ == 1)
			{
				return 153f;
			}
			if (JFDPIPAFLHJ == 5)
			{
				return 1878f;
			}
			if (JFDPIPAFLHJ == 3)
			{
				return 412f;
			}
			if (JFDPIPAFLHJ == 8)
			{
				return 1287f;
			}
			return 130f;
		}

		// Token: 0x060105AC RID: 66988 RVA: 0x0074FA92 File Offset: 0x0074DC92
		public void SetLimitPoints(RotationLimitPolygonal.LimitPoint[] CBJBGGAOODC)
		{
			if (CBJBGGAOODC.Length < 3)
			{
				base.LogWarning("The polygon must have at least 3 Limit Points.");
				return;
			}
			this.points = CBJBGGAOODC;
			this.BuildReachCones();
		}

		// Token: 0x060105AD RID: 66989 RVA: 0x0074FAB3 File Offset: 0x0074DCB3
		private void PHPHECAIDIH()
		{
			Application.OpenURL("ObscuredByte vs byte, ");
		}

		// Token: 0x060105AE RID: 66990 RVA: 0x0074FABF File Offset: 0x0074DCBF
		private void BONLOKHJKKB()
		{
			Application.OpenURL("RangeMarker");
		}

		// Token: 0x060105AF RID: 66991 RVA: 0x0074FACC File Offset: 0x0074DCCC
		public void KPMOHAIOICI()
		{
			this.points = new RotationLimitPolygonal.LimitPoint[1];
			for (int i = 1; i < this.points.Length; i++)
			{
				this.points[i] = new RotationLimitPolygonal.LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(1518f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(1738f, Vector3.up);
			this.points[1].point = quaternion * quaternion2 * this.axis;
			this.points[1].point = Quaternion.Inverse(quaternion) * quaternion2 * this.axis;
			this.points[6].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * this.axis;
			this.points[6].point = quaternion * Quaternion.Inverse(quaternion2) * this.axis;
			this.BuildReachCones();
		}

		// Token: 0x04002237 RID: 8759
		[Range(0f, 180f)]
		public float twistLimit = 180f;

		// Token: 0x04002238 RID: 8760
		[Range(0f, 3f)]
		public int smoothIterations;

		// Token: 0x04002239 RID: 8761
		[SerializeField]
		[HideInInspector]
		public RotationLimitPolygonal.LimitPoint[] points;

		// Token: 0x0400223A RID: 8762
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		// Token: 0x0400223B RID: 8763
		[HideInInspector]
		[SerializeField]
		public RotationLimitPolygonal.ReachCone[] reachCones = new RotationLimitPolygonal.ReachCone[0];

		// Token: 0x020004AB RID: 1195
		[Serializable]
		public class ReachCone
		{
			// Token: 0x060105B0 RID: 66992 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 FKDOOMHDIGD()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105B1 RID: 66993 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 APDGOLLOKBH()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105B2 RID: 66994 RVA: 0x0074FBC9 File Offset: 0x0074DDC9
			public Vector3 FPOEHFOPKMC()
			{
				return this.tetrahedron[5];
			}

			// Token: 0x060105B3 RID: 66995 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 GLAOKAGOEBL()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x17000399 RID: 921
			// (get) Token: 0x060105B4 RID: 66996 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 o
			{
				get
				{
					return this.tetrahedron[0];
				}
			}

			// Token: 0x060105B5 RID: 66997 RVA: 0x0074FBD7 File Offset: 0x0074DDD7
			public bool GJBOGOCLFCN()
			{
				return this.volume > 1339f;
			}

			// Token: 0x060105B6 RID: 66998 RVA: 0x0074FBE6 File Offset: 0x0074DDE6
			public Vector3 OGCLANIONLF()
			{
				return this.tetrahedron[8];
			}

			// Token: 0x060105B7 RID: 66999 RVA: 0x0074FBF4 File Offset: 0x0074DDF4
			public bool ONOIKBGMKPB()
			{
				return this.volume > 1519f;
			}

			// Token: 0x060105B8 RID: 67000 RVA: 0x0074FC03 File Offset: 0x0074DE03
			public bool ENCHDCOKMPL()
			{
				return this.volume > 1748f;
			}

			// Token: 0x060105B9 RID: 67001 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 EJIJCBHOFOC()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105BA RID: 67002 RVA: 0x0074FC20 File Offset: 0x0074DE20
			public void MHLHEFABMPH()
			{
				Vector3 lhs = Vector3.Cross(this.FCFMIMOBMHD(), this.DCHNGLBINIF());
				this.volume = Vector3.Dot(lhs, this.LLAOGBCFHLK()) / 1218f;
				this.S = Vector3.Cross(this.JPGBFMMILKP(), this.b).normalized;
				this.B = Vector3.Cross(this.DJFLKLGMPEK(), this.DMLDNANGNAM()).normalized;
			}

			// Token: 0x060105BB RID: 67003 RVA: 0x0074FBE6 File Offset: 0x0074DDE6
			public Vector3 JCGALFKMNFP()
			{
				return this.tetrahedron[8];
			}

			// Token: 0x060105BC RID: 67004 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 BODJPJDCMIC()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105BD RID: 67005 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 FCFMIMOBMHD()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105BE RID: 67006 RVA: 0x0074FC95 File Offset: 0x0074DE95
			public bool GANFBBKLOAF()
			{
				return this.volume > 1229f;
			}

			// Token: 0x1700039A RID: 922
			// (get) Token: 0x060105BF RID: 67007 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 a
			{
				get
				{
					return this.tetrahedron[1];
				}
			}

			// Token: 0x060105C0 RID: 67008 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 PKOPPBEINLH()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105C1 RID: 67009 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 LNKCLMKBDFD()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105C2 RID: 67010 RVA: 0x0074FCA4 File Offset: 0x0074DEA4
			public Vector3 LLAOGBCFHLK()
			{
				return this.tetrahedron[3];
			}

			// Token: 0x060105C3 RID: 67011 RVA: 0x0074FCB2 File Offset: 0x0074DEB2
			public bool CDCMJCINIMD()
			{
				return this.volume > 766f;
			}

			// Token: 0x060105C4 RID: 67012 RVA: 0x0074FCC4 File Offset: 0x0074DEC4
			public void ENPCMGHMMEE()
			{
				Vector3 lhs = Vector3.Cross(this.FCFMIMOBMHD(), this.PKKIEIHLJGP());
				this.volume = Vector3.Dot(lhs, this.AFHAPEIBDDB()) / 1543f;
				this.S = Vector3.Cross(this.CFMNLBCNEHB(), this.OMNHGEOFDFC()).normalized;
				this.B = Vector3.Cross(this.OGCLANIONLF(), this.PBDHENJPCLC()).normalized;
			}

			// Token: 0x060105C5 RID: 67013 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 DMNMOLPCCOP()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105C6 RID: 67014 RVA: 0x0074FD3C File Offset: 0x0074DF3C
			public void MEICAMDCADF()
			{
				Vector3 lhs = Vector3.Cross(this.IHLMKPLCJAJ(), this.PKKIEIHLJGP());
				this.volume = Vector3.Dot(lhs, this.GMNDPHHGBLH()) / 1226f;
				this.S = Vector3.Cross(this.FCFMIMOBMHD(), this.DBIFGFDBMJP()).normalized;
				this.B = Vector3.Cross(this.GOCNGHCEGFJ(), this.AFHAPEIBDDB()).normalized;
			}

			// Token: 0x060105C7 RID: 67015 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 AGACEOCGECB()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105C8 RID: 67016 RVA: 0x0074FDB4 File Offset: 0x0074DFB4
			public void GJBFBNJFACK()
			{
				Vector3 lhs = Vector3.Cross(this.LNKCLMKBDFD(), this.PKKIEIHLJGP());
				this.volume = Vector3.Dot(lhs, this.LLAOGBCFHLK()) / 1089f;
				this.S = Vector3.Cross(this.IHLMKPLCJAJ(), this.b).normalized;
				this.B = Vector3.Cross(this.GOCNGHCEGFJ(), this.JCGALFKMNFP()).normalized;
			}

			// Token: 0x060105C9 RID: 67017 RVA: 0x0074FE29 File Offset: 0x0074E029
			public Vector3 AFHAPEIBDDB()
			{
				return this.tetrahedron[6];
			}

			// Token: 0x060105CA RID: 67018 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 NPBDGHCNCNM()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105CB RID: 67019 RVA: 0x0074FE37 File Offset: 0x0074E037
			public Vector3 DIBBJKEDINL()
			{
				return this.tetrahedron[7];
			}

			// Token: 0x060105CC RID: 67020 RVA: 0x0074FE45 File Offset: 0x0074E045
			public bool IKOACIAAHIN()
			{
				return this.volume > 1172f;
			}

			// Token: 0x060105CD RID: 67021 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 NEBNBECGKFC()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105CE RID: 67022 RVA: 0x0074FE54 File Offset: 0x0074E054
			public bool EEHOGMHPPCF()
			{
				return this.volume > 1330f;
			}

			// Token: 0x060105CF RID: 67023 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 BPIKCMGGCMG()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105D0 RID: 67024 RVA: 0x0074FE63 File Offset: 0x0074E063
			public bool LJBPKIKBOHD()
			{
				return this.volume > 1730f;
			}

			// Token: 0x060105D1 RID: 67025 RVA: 0x0074FE72 File Offset: 0x0074E072
			public bool OCMMEMLJFEA()
			{
				return this.volume > 1182f;
			}

			// Token: 0x060105D2 RID: 67026 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 JNDANBHECAP()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105D3 RID: 67027 RVA: 0x0074FCA4 File Offset: 0x0074DEA4
			public Vector3 IAALIHONMBD()
			{
				return this.tetrahedron[3];
			}

			// Token: 0x060105D4 RID: 67028 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 LLKFCDDGNNN()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105D5 RID: 67029 RVA: 0x0074FE81 File Offset: 0x0074E081
			public bool GNDCNBMBOBF()
			{
				return this.volume > 1513f;
			}

			// Token: 0x060105D6 RID: 67030 RVA: 0x0074FE29 File Offset: 0x0074E029
			public Vector3 PBDHENJPCLC()
			{
				return this.tetrahedron[6];
			}

			// Token: 0x060105D7 RID: 67031 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 HIOGMCPINFN()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105D8 RID: 67032 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 CFMNLBCNEHB()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105D9 RID: 67033 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 CKEFGJDDHHH()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105DA RID: 67034 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 GJLLLIFCCCK()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105DB RID: 67035 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 DMLDNANGNAM()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105DC RID: 67036 RVA: 0x0074FE90 File Offset: 0x0074E090
			public bool FGFJKGGBDFC()
			{
				return this.volume > 441f;
			}

			// Token: 0x060105DD RID: 67037 RVA: 0x0074FBE6 File Offset: 0x0074DDE6
			public Vector3 DBIFGFDBMJP()
			{
				return this.tetrahedron[8];
			}

			// Token: 0x1700039B RID: 923
			// (get) Token: 0x060105DE RID: 67038 RVA: 0x0074FE9F File Offset: 0x0074E09F
			public Vector3 b
			{
				get
				{
					return this.tetrahedron[2];
				}
			}

			// Token: 0x060105DF RID: 67039 RVA: 0x0074FEB0 File Offset: 0x0074E0B0
			public void OMGEFIBJOKO()
			{
				Vector3 lhs = Vector3.Cross(this.CKEFGJDDHHH(), this.FDJFKNEDEGF());
				this.volume = Vector3.Dot(lhs, this.GMNDPHHGBLH()) / 1034f;
				this.S = Vector3.Cross(this.CFMNLBCNEHB(), this.OGCLANIONLF()).normalized;
				this.B = Vector3.Cross(this.NPBDGHCNCNM(), this.LLAOGBCFHLK()).normalized;
			}

			// Token: 0x060105E0 RID: 67040 RVA: 0x0074FF25 File Offset: 0x0074E125
			public bool PAOGPMKIOCJ()
			{
				return this.volume > 115f;
			}

			// Token: 0x060105E1 RID: 67041 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 INCPKLIDJBL()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105E2 RID: 67042 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 PODPKEHKKGP()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105E3 RID: 67043 RVA: 0x0074FE37 File Offset: 0x0074E037
			public Vector3 PKKIEIHLJGP()
			{
				return this.tetrahedron[7];
			}

			// Token: 0x060105E4 RID: 67044 RVA: 0x0074FF34 File Offset: 0x0074E134
			public void HJNKMNADGPC()
			{
				Vector3 lhs = Vector3.Cross(this.HHMALAODCDM(), this.PKKIEIHLJGP());
				this.volume = Vector3.Dot(lhs, this.DMLDNANGNAM()) / 1730f;
				this.S = Vector3.Cross(this.HHMALAODCDM(), this.LKGLEDDODNM()).normalized;
				this.B = Vector3.Cross(this.PKKIEIHLJGP(), this.AFHAPEIBDDB()).normalized;
			}

			// Token: 0x060105E5 RID: 67045 RVA: 0x0074FE9F File Offset: 0x0074E09F
			public Vector3 LKGLEDDODNM()
			{
				return this.tetrahedron[2];
			}

			// Token: 0x060105E6 RID: 67046 RVA: 0x0074FFA9 File Offset: 0x0074E1A9
			public Vector3 FDJFKNEDEGF()
			{
				return this.tetrahedron[4];
			}

			// Token: 0x060105E7 RID: 67047 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 OOCAKMJBINL()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105E8 RID: 67048 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 FICAGDNJKLA()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105E9 RID: 67049 RVA: 0x0074FFB7 File Offset: 0x0074E1B7
			public bool IOKEMMBABDP()
			{
				return this.volume > 1310f;
			}

			// Token: 0x060105EA RID: 67050 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 LLOHCOAKECM()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105EB RID: 67051 RVA: 0x0074FFC6 File Offset: 0x0074E1C6
			public bool OLPKLFOKIIF()
			{
				return this.volume > 1832f;
			}

			// Token: 0x060105EC RID: 67052 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 BMEBCHJILJO()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105ED RID: 67053 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 LMMKLMHJDFP()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105EE RID: 67054 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 NNBPCJMFMNK()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105EF RID: 67055 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 EPBLIOLELFL()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x060105F0 RID: 67056 RVA: 0x0074FFD5 File Offset: 0x0074E1D5
			public bool isValid
			{
				get
				{
					return this.volume > 0f;
				}
			}

			// Token: 0x060105F1 RID: 67057 RVA: 0x0074FFE4 File Offset: 0x0074E1E4
			public bool IOKKJFEHCGJ()
			{
				return this.volume > 1083f;
			}

			// Token: 0x060105F2 RID: 67058 RVA: 0x0074FBC9 File Offset: 0x0074DDC9
			public Vector3 GOCNGHCEGFJ()
			{
				return this.tetrahedron[5];
			}

			// Token: 0x060105F3 RID: 67059 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 HHMALAODCDM()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x060105F4 RID: 67060 RVA: 0x0074FFF3 File Offset: 0x0074E1F3
			public bool CPOGKENGNOF()
			{
				return this.volume > 1420f;
			}

			// Token: 0x060105F5 RID: 67061 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 DJFLKLGMPEK()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105F6 RID: 67062 RVA: 0x0074FFA9 File Offset: 0x0074E1A9
			public Vector3 OIPCJKKOCHL()
			{
				return this.tetrahedron[4];
			}

			// Token: 0x060105F7 RID: 67063 RVA: 0x00750004 File Offset: 0x0074E204
			public void LJGHMLKDIGB()
			{
				Vector3 lhs = Vector3.Cross(this.BPIKCMGGCMG(), this.NPBDGHCNCNM());
				this.volume = Vector3.Dot(lhs, this.DMLDNANGNAM()) / 65f;
				this.S = Vector3.Cross(this.FCFMIMOBMHD(), this.PKKIEIHLJGP()).normalized;
				this.B = Vector3.Cross(this.b, this.FPOEHFOPKMC()).normalized;
			}

			// Token: 0x060105F8 RID: 67064 RVA: 0x0075007C File Offset: 0x0074E27C
			public void IJLHAEEBBGG()
			{
				Vector3 lhs = Vector3.Cross(this.AGACEOCGECB(), this.OIPCJKKOCHL());
				this.volume = Vector3.Dot(lhs, this.IAALIHONMBD()) / 1096f;
				this.S = Vector3.Cross(this.BPIKCMGGCMG(), this.b).normalized;
				this.B = Vector3.Cross(this.LKGLEDDODNM(), this.GMNDPHHGBLH()).normalized;
			}

			// Token: 0x060105F9 RID: 67065 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 IIGMEMGNBBI()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105FA RID: 67066 RVA: 0x007500F4 File Offset: 0x0074E2F4
			public void NKGODMNOIBB()
			{
				Vector3 lhs = Vector3.Cross(this.a, this.b);
				this.volume = Vector3.Dot(lhs, this.c) / 6f;
				this.S = Vector3.Cross(this.a, this.b).normalized;
				this.B = Vector3.Cross(this.b, this.c).normalized;
			}

			// Token: 0x060105FB RID: 67067 RVA: 0x0075016C File Offset: 0x0074E36C
			public void MDADJBLJGOB()
			{
				Vector3 lhs = Vector3.Cross(this.a, this.DBIFGFDBMJP());
				this.volume = Vector3.Dot(lhs, this.LLAOGBCFHLK()) / 1593f;
				this.S = Vector3.Cross(this.INCPKLIDJBL(), this.DJFLKLGMPEK()).normalized;
				this.B = Vector3.Cross(this.DBIFGFDBMJP(), this.IAALIHONMBD()).normalized;
			}

			// Token: 0x060105FC RID: 67068 RVA: 0x007501E1 File Offset: 0x0074E3E1
			public bool JAGBIFIOHAL()
			{
				return this.volume > 1626f;
			}

			// Token: 0x060105FD RID: 67069 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 KLHPEEPMIEL()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x060105FE RID: 67070 RVA: 0x007501F0 File Offset: 0x0074E3F0
			public void AMNAHCGENFP()
			{
				Vector3 lhs = Vector3.Cross(this.AGACEOCGECB(), this.NPBDGHCNCNM());
				this.volume = Vector3.Dot(lhs, this.PBDHENJPCLC()) / 1808f;
				this.S = Vector3.Cross(this.CFMNLBCNEHB(), this.b).normalized;
				this.B = Vector3.Cross(this.b, this.HKKLLPJJDML()).normalized;
			}

			// Token: 0x060105FF RID: 67071 RVA: 0x0074FCA4 File Offset: 0x0074DEA4
			public Vector3 OMNHGEOFDFC()
			{
				return this.tetrahedron[3];
			}

			// Token: 0x06010600 RID: 67072 RVA: 0x0074FE29 File Offset: 0x0074E029
			public Vector3 DCHNGLBINIF()
			{
				return this.tetrahedron[6];
			}

			// Token: 0x06010601 RID: 67073 RVA: 0x0074FFA9 File Offset: 0x0074E1A9
			public Vector3 HKKLLPJJDML()
			{
				return this.tetrahedron[4];
			}

			// Token: 0x06010602 RID: 67074 RVA: 0x00750265 File Offset: 0x0074E465
			public bool EEPJHEPEFLC()
			{
				return this.volume > 634f;
			}

			// Token: 0x06010603 RID: 67075 RVA: 0x00750274 File Offset: 0x0074E474
			public bool FOJIHECBHJB()
			{
				return this.volume > 1985f;
			}

			// Token: 0x06010604 RID: 67076 RVA: 0x0074FBBB File Offset: 0x0074DDBB
			public Vector3 IHLMKPLCJAJ()
			{
				return this.tetrahedron[0];
			}

			// Token: 0x06010605 RID: 67077 RVA: 0x00750283 File Offset: 0x0074E483
			public bool CNDKFCILNNH()
			{
				return this.volume > 963f;
			}

			// Token: 0x06010606 RID: 67078 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 JPGBFMMILKP()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x06010607 RID: 67079 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 JAFEKMKMNAF()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x06010608 RID: 67080 RVA: 0x00750292 File Offset: 0x0074E492
			public bool ECOKEAIAKKG()
			{
				return this.volume > 1737f;
			}

			// Token: 0x06010609 RID: 67081 RVA: 0x0074FFA9 File Offset: 0x0074E1A9
			public Vector3 GMNDPHHGBLH()
			{
				return this.tetrahedron[4];
			}

			// Token: 0x0601060A RID: 67082 RVA: 0x007502A4 File Offset: 0x0074E4A4
			public ReachCone(Vector3 CAMDFCFANFL, Vector3 FPLJAFNDAGH, Vector3 EKINOPMODGC, Vector3 KLKFKMCHBKE)
			{
				this.tetrahedron = new Vector3[4];
				this.tetrahedron[0] = CAMDFCFANFL;
				this.tetrahedron[1] = FPLJAFNDAGH;
				this.tetrahedron[2] = EKINOPMODGC;
				this.tetrahedron[3] = KLKFKMCHBKE;
				this.volume = 0f;
				this.S = Vector3.zero;
				this.B = Vector3.zero;
			}

			// Token: 0x0601060B RID: 67083 RVA: 0x00750319 File Offset: 0x0074E519
			public bool ELHBJFBDAKN()
			{
				return this.volume > 549f;
			}

			// Token: 0x1700039C RID: 924
			// (get) Token: 0x0601060C RID: 67084 RVA: 0x0074FCA4 File Offset: 0x0074DEA4
			public Vector3 c
			{
				get
				{
					return this.tetrahedron[3];
				}
			}

			// Token: 0x0601060D RID: 67085 RVA: 0x00750328 File Offset: 0x0074E528
			public bool FFKKIDKIGFE()
			{
				return this.volume > 559f;
			}

			// Token: 0x0601060E RID: 67086 RVA: 0x0074FE37 File Offset: 0x0074E037
			public Vector3 MPFOOLLDPFG()
			{
				return this.tetrahedron[7];
			}

			// Token: 0x0601060F RID: 67087 RVA: 0x0074FC12 File Offset: 0x0074DE12
			public Vector3 FFFPPHKJFEP()
			{
				return this.tetrahedron[1];
			}

			// Token: 0x0400223C RID: 8764
			public Vector3[] tetrahedron;

			// Token: 0x0400223D RID: 8765
			public float volume;

			// Token: 0x0400223E RID: 8766
			public Vector3 S;

			// Token: 0x0400223F RID: 8767
			public Vector3 B;
		}

		// Token: 0x020004AC RID: 1196
		[Serializable]
		public class LimitPoint
		{
			// Token: 0x06010610 RID: 67088 RVA: 0x00750337 File Offset: 0x0074E537
			public LimitPoint()
			{
				this.point = Vector3.forward;
				this.tangentWeight = 1f;
			}

			// Token: 0x04002240 RID: 8768
			public Vector3 point;

			// Token: 0x04002241 RID: 8769
			public float tangentWeight;
		}
	}
}
