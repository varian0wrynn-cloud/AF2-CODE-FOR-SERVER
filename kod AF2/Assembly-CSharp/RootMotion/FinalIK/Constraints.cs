using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000440 RID: 1088
	[Serializable]
	public class Constraints
	{
		// Token: 0x0600EA03 RID: 59907 RVA: 0x006A0728 File Offset: 0x0069E928
		public void JFGGBEGNAFP()
		{
			if (!this.GJJLJBMDACK())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1486f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1033f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA04 RID: 59908 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void LJFOOMNMMJK(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA05 RID: 59909 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void HNBMMLMAGMG(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA06 RID: 59910 RVA: 0x006A0810 File Offset: 0x0069EA10
		public void IKHCCAANGOP()
		{
			if (!this.EGKCHKFNAPG())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 988f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 396f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA07 RID: 59911 RVA: 0x006A08D8 File Offset: 0x0069EAD8
		public void JIFOELPAEHG()
		{
			if (!this.FAICDEHKLNO())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 915f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 279f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA08 RID: 59912 RVA: 0x006A09A0 File Offset: 0x0069EBA0
		public void PNBGJBMJLFM()
		{
			if (!this.JJFAPBPDIMO())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1651f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 339f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA09 RID: 59913 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool CEHHFHPKPCH()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA0A RID: 59914 RVA: 0x006A0A74 File Offset: 0x0069EC74
		public void MEIOHFKFEME()
		{
			if (!this.IJBNGDMCBLI())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1099f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 646f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA0B RID: 59915 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool FAICDEHKLNO()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA0C RID: 59916 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void PAAKDJIEPOI(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA0D RID: 59917 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool JAFLIDGPMPJ()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA0E RID: 59918 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool CHJAMEPPEOI()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA0F RID: 59919 RVA: 0x006A0B3C File Offset: 0x0069ED3C
		public void GPCKACGEILI()
		{
			if (!this.EPGDIOJNLBF())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1737f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 497f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA10 RID: 59920 RVA: 0x006A0C04 File Offset: 0x0069EE04
		public void INKGAFANFIB()
		{
			if (!this.LCJIEECEFBL())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 400f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1362f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA11 RID: 59921 RVA: 0x006A0CCC File Offset: 0x0069EECC
		public void GDBBAMFMKII()
		{
			if (!this.GJNJIAMOFOM())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1107f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1278f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA12 RID: 59922 RVA: 0x006A0D94 File Offset: 0x0069EF94
		public void FANPFKHEDPA()
		{
			if (!this.CHFHJDFDIGB())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 0f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 0f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA13 RID: 59923 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void FONNAJPJEIL(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA14 RID: 59924 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool MMDGNPAEAFP()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA15 RID: 59925 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool LCFLKPJJLOG()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA16 RID: 59926 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void CIPOOAEKLCF(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA17 RID: 59927 RVA: 0x006A0E5C File Offset: 0x0069F05C
		public void EMHGNEMIGII()
		{
			if (!this.JKBIGIDILLI())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1023f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1851f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA18 RID: 59928 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void GJNIFEMNGML(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA19 RID: 59929 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void HIIINMHFCHH(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA1A RID: 59930 RVA: 0x006A0F24 File Offset: 0x0069F124
		public void MIFLHGMPLJD()
		{
			if (!this.CKHNENDFKFF())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 426f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 976f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA1B RID: 59931 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool HNNGOIJIDFK()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA1C RID: 59932 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool KGGCPLPHBPN()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA1D RID: 59933 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void BPPOKGJMLIH(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA1E RID: 59934 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void ENLPEHMBNJC(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA1F RID: 59935 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool PEFCPOAGLGE()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA20 RID: 59936 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool GJNJIAMOFOM()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA21 RID: 59937 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool DMLMBHKJBME()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA22 RID: 59938 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool GJJLJBMDACK()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA23 RID: 59939 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void KECFBCFMAFM(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA24 RID: 59940 RVA: 0x006A0FEC File Offset: 0x0069F1EC
		public void BAIKCLKJPAA()
		{
			if (!this.MJJNKICHLFA())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1220f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 462f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA25 RID: 59941 RVA: 0x006A10B4 File Offset: 0x0069F2B4
		public void ECPECFPNLKP()
		{
			if (!this.OFAJMCPOKJH())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1150f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 303f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA26 RID: 59942 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void KNEEBLNAGLM(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA27 RID: 59943 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool EGKCHKFNAPG()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA28 RID: 59944 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool ANBOFFNPNCP()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA29 RID: 59945 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool LEDFEHFJIPB()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA2A RID: 59946 RVA: 0x006A117C File Offset: 0x0069F37C
		public void KMLNBHIIGKH()
		{
			if (!this.GGCHLAAAHEJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 908f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 678f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA2B RID: 59947 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void CKHKJOHKMEE(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA2C RID: 59948 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool OMFLINGGNGK()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA2D RID: 59949 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool ONJNHIMOOFJ()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA2E RID: 59950 RVA: 0x006A1244 File Offset: 0x0069F444
		public void HAIMGCDKPDC()
		{
			if (!this.ONJNHIMOOFJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1347f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 112f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA2F RID: 59951 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool JJCLDJGHEHJ()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA30 RID: 59952 RVA: 0x006A130C File Offset: 0x0069F50C
		public void CJHBCHBOLBI()
		{
			if (!this.LEDFEHFJIPB())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 397f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1238f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA31 RID: 59953 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool LEPMMKDHENG()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA32 RID: 59954 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool JJFAPBPDIMO()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA34 RID: 59956 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void PLDPNLLOANG(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA35 RID: 59957 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool GFCMLDEKNOJ()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA36 RID: 59958 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool EPGDIOJNLBF()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA37 RID: 59959 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool CKHNENDFKFF()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA38 RID: 59960 RVA: 0x006A13D4 File Offset: 0x0069F5D4
		public void AAEFACEGJMB()
		{
			if (!this.IJBNGDMCBLI())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 710f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 39f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA39 RID: 59961 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool BGKDELKAGJI()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA3A RID: 59962 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void NOMNCNAABEL(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA3B RID: 59963 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool GOGPDCPCIBN()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA3C RID: 59964 RVA: 0x006A149C File Offset: 0x0069F69C
		public void KJJEEMEHGBF()
		{
			if (!this.ONJNHIMOOFJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 75f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 794f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA3D RID: 59965 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool IJBNGDMCBLI()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA3E RID: 59966 RVA: 0x006A1564 File Offset: 0x0069F764
		public void MEFOGCFJBNE()
		{
			if (!this.CHFHJDFDIGB())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 663f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 770f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA3F RID: 59967 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void NKFBJHDBLEG(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA40 RID: 59968 RVA: 0x006A162C File Offset: 0x0069F82C
		public void MPLCAGFGEBO()
		{
			if (!this.ONJNHIMOOFJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1969f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1108f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA41 RID: 59969 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void BHALELINNDJ(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA42 RID: 59970 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void OGOHEHIMLHP(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA43 RID: 59971 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool DLEFMIGHFON()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA44 RID: 59972 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool PLBBJKKDJKN()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA45 RID: 59973 RVA: 0x006A16F4 File Offset: 0x0069F8F4
		public void LDDIGEMBDNF()
		{
			if (!this.CKHNENDFKFF())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 95f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1908f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA46 RID: 59974 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void DMOINNLLGBO(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA47 RID: 59975 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool JKBIGIDILLI()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA48 RID: 59976 RVA: 0x006A17BC File Offset: 0x0069F9BC
		public void NOLKOIHEICD()
		{
			if (!this.EPGDIOJNLBF())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1657f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 239f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA49 RID: 59977 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void LLPMNHOBPAJ(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA4A RID: 59978 RVA: 0x006A1884 File Offset: 0x0069FA84
		public void ACFEBEDDIAI()
		{
			if (!this.ONJNHIMOOFJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 524f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1727f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA4B RID: 59979 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool KOJLPEJJFLO()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA4C RID: 59980 RVA: 0x006A194C File Offset: 0x0069FB4C
		public void MFHGOLNLAAF()
		{
			if (!this.JAFLIDGPMPJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1150f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1319f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA4D RID: 59981 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool BEJJCJCLIOE()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA4E RID: 59982 RVA: 0x006A1A14 File Offset: 0x0069FC14
		public void PMKOAHMNBBG()
		{
			if (!this.DLEFMIGHFON())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1216f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1241f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA4F RID: 59983 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void JPGOKPACOIC(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA50 RID: 59984 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void FFNJMJHPDGF(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA51 RID: 59985 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void MLFAABAPOHI(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA52 RID: 59986 RVA: 0x006A1ADC File Offset: 0x0069FCDC
		public void LACNPNKHCAA()
		{
			if (!this.LCFLKPJJLOG())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1335f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 130f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA53 RID: 59987 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool MJJNKICHLFA()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA54 RID: 59988 RVA: 0x006A1BA4 File Offset: 0x0069FDA4
		public void JLFBDOPFDDJ()
		{
			if (!this.EPGDIOJNLBF())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1943f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 357f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA55 RID: 59989 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool EHBFINLIBOP()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA56 RID: 59990 RVA: 0x006A1C6C File Offset: 0x0069FE6C
		public void DAFJMNMFOON()
		{
			if (!this.CHFHJDFDIGB())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 868f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 192f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA57 RID: 59991 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool CJNMLDPCFKB()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA58 RID: 59992 RVA: 0x006A1D34 File Offset: 0x0069FF34
		public void DPGECEOMHNM()
		{
			if (!this.CHFHJDFDIGB())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1159f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1598f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA59 RID: 59993 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool GGCHLAAAHEJ()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA5A RID: 59994 RVA: 0x006A1DFC File Offset: 0x0069FFFC
		public void PAKOHKKBKHD()
		{
			if (!this.LEDFEHFJIPB())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1198f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 571f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA5B RID: 59995 RVA: 0x006A1EC4 File Offset: 0x006A00C4
		public void NMMGHFDLNOE()
		{
			if (!this.JJFAPBPDIMO())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 679f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1147f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA5C RID: 59996 RVA: 0x006A1F8C File Offset: 0x006A018C
		public void DFFOEGHGPGP()
		{
			if (!this.JAFLIDGPMPJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1562f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 208f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA5D RID: 59997 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void HMNPKENDIPF(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA5E RID: 59998 RVA: 0x006A2054 File Offset: 0x006A0254
		public void FJEEADNCKAG()
		{
			if (!this.JAFLIDGPMPJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1408f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1100f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA5F RID: 59999 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void IPEKLMKGKKB(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA60 RID: 60000 RVA: 0x006A211C File Offset: 0x006A031C
		public void DEGCCLNOEKJ()
		{
			if (!this.CKHNENDFKFF())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 370f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1805f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA61 RID: 60001 RVA: 0x006A21E4 File Offset: 0x006A03E4
		public void HMLNMHOMMNO()
		{
			if (!this.KGGCPLPHBPN())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 571f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1499f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA62 RID: 60002 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool LCJIEECEFBL()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA63 RID: 60003 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool OFAJMCPOKJH()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void HGFMPHNJAJJ(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA65 RID: 60005 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void DJPDNBPIIKE(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA66 RID: 60006 RVA: 0x006A22AC File Offset: 0x006A04AC
		public void IEOICHPKEMD()
		{
			if (!this.GFCMLDEKNOJ())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1556f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 90f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA67 RID: 60007 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool OIDMJAPOEPD()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA68 RID: 60008 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void AMGIJEGCAEG(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA69 RID: 60009 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool JCLOIKEEAFO()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA6A RID: 60010 RVA: 0x006A2374 File Offset: 0x006A0574
		public void PFPPDNHLCCA()
		{
			if (!this.EGKCHKFNAPG())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 187f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 1829f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA6B RID: 60011 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool CHFHJDFDIGB()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA6C RID: 60012 RVA: 0x006A0A65 File Offset: 0x0069EC65
		public bool INBJOJBHHJN()
		{
			return this.transform != null;
		}

		// Token: 0x0600EA6D RID: 60013 RVA: 0x006A243C File Offset: 0x006A063C
		public void GCCAPOHGAHA()
		{
			if (!this.KGGCPLPHBPN())
			{
				return;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 1559f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 393f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x0600EA6E RID: 60014 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void ADIOIHCOCPA(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA6F RID: 60015 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void GAHOJAIMGOG(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA70 RID: 60016 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void DAAHJFNPBIF(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x0600EA71 RID: 60017 RVA: 0x006A07ED File Offset: 0x0069E9ED
		public void EODKOKCBABD(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
			this.position = LPBDALAMAEM.position;
			this.rotation = LPBDALAMAEM.eulerAngles;
		}

		// Token: 0x04001EAF RID: 7855
		public Transform transform;

		// Token: 0x04001EB0 RID: 7856
		public Vector3 positionOffset;

		// Token: 0x04001EB1 RID: 7857
		public Vector3 position;

		// Token: 0x04001EB2 RID: 7858
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x04001EB3 RID: 7859
		public Vector3 rotationOffset;

		// Token: 0x04001EB4 RID: 7860
		public Vector3 rotation;

		// Token: 0x04001EB5 RID: 7861
		[Range(0f, 1f)]
		public float rotationWeight;
	}
}
