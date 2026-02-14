using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002D8 RID: 728
	[Serializable]
	public class LerpControlledBob
	{
		// Token: 0x0600AB55 RID: 43861 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float GLCJECIKMFB()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float AKAEDICLMEN()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator OEMAMJIMLOP()
		{
			float num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float CAAIOAFPDLA()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float MIGMJOCAELM()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator FEPGJMLCHAN()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB5B RID: 43867 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator NILJIJJPHNK()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB5C RID: 43868 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator MKNLNBEEACC()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB5D RID: 43869 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float EDANCOOIPNB()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB5E RID: 43870 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator FOMPFMIEGBJ()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB5F RID: 43871 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float PKOKGKOHLAH()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB60 RID: 43872 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float MILKIPIIHPA()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float FEBPOHAHJPB()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB62 RID: 43874 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float PIHFBJMMAIL()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB63 RID: 43875 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float CJIKHNEOMFD()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator DDJDDGJJFCG()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float IHLOCDJDEKJ()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float JGKNHPONEFA()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator HHOGGHKFEEH()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float BGEEIEHJJKE()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float FEHLBEIOPJJ()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator JBOCINLBOLN()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator HDLGPPKNFFB()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float IAJDIAPFDPN()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float MMCOMDPKBLN()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB6E RID: 43886 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator ACOCAHDKDGJ()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB6F RID: 43887 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float HHCOPPICJDB()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB70 RID: 43888 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float MCFCOGJOBNK()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB71 RID: 43889 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float LCGJOEHEAOO()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB72 RID: 43890 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator OFCICBGKJEE()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB73 RID: 43891 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator ACJCAPIIAME()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB74 RID: 43892 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator NKEPDOHLINM()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB75 RID: 43893 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator LIHGOMGIIBE()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB76 RID: 43894 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float NNMNFBACNEN()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB77 RID: 43895 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float NOFJGAPNINK()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB78 RID: 43896 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator JLAJDPEPHHN()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float ODJMDDKBJHA()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB7A RID: 43898 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator LJNFDFHAHBI()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB7B RID: 43899 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator EMOCPAKAMGP()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float FHFNNJIIIKP()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float LMBLMIJPEBA()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator ODCGEKBDEKG()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float FBPMDMLOCGD()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator GCGPKEAJLGD()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator JPAEEEFLPDE()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float AAHPOBCGKKD()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB83 RID: 43907 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float LIACKFEKDKC()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB84 RID: 43908 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator JIFNBACMKND()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB85 RID: 43909 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float ABKKODINNNB()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB86 RID: 43910 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator PAEHDHEDBLN()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator OHJFJDALFAG()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator IBFJKGBNJHK()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB89 RID: 43913 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator NNNJLODDHKK()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB8A RID: 43914 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float MLEBPLJPFJE()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB8B RID: 43915 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator JICCNBDCINH()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB8C RID: 43916 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float PPOLOKFLGGN()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB8D RID: 43917 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator GGEEAJEKCNP()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB8E RID: 43918 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float MFHOGHFEPAN()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB8F RID: 43919 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float NACADKBKKDD()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB90 RID: 43920 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator PBJMIBMPCCM()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x004BDDC1 File Offset: 0x004BBFC1
		public IEnumerator BEDJFMLOMOP()
		{
			LerpControlledBob.CGGEGADAFOO cggegadafoo = new LerpControlledBob.CGGEGADAFOO(1);
			cggegadafoo.AENJLLPLILM = this;
			return cggegadafoo;
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float NEDLIEPEJEI()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB93 RID: 43923 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator FNOPJLIAFKO()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB94 RID: 43924 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator OHAFMHAFJOG()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator NHDPBLAEDIJ()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x004BDDAA File Offset: 0x004BBFAA
		public float IIHEGGEALAM()
		{
			return this.m_Offset;
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x004BDDB2 File Offset: 0x004BBFB2
		public IEnumerator GHFEELIGDGE()
		{
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(0f, this.BobAmount, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			num = 0f;
			while (num < this.BobDuration)
			{
				this.m_Offset = Mathf.Lerp(this.BobAmount, 0f, num / this.BobDuration);
				num += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			this.m_Offset = 0f;
			yield break;
		}

		// Token: 0x040015FD RID: 5629
		public float BobDuration;

		// Token: 0x040015FE RID: 5630
		public float BobAmount;

		// Token: 0x040015FF RID: 5631
		private float m_Offset;
	}
}
