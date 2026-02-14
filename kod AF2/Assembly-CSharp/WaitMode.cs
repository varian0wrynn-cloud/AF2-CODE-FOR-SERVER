using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000252 RID: 594
public class WaitMode : MonoBehaviour
{
	// Token: 0x06008829 RID: 34857 RVA: 0x003F5EC4 File Offset: 0x003F40C4
	private void KOLCEBEIHKP()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 547f)
			{
				base.gameObject.SetActive(false);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x0600882A RID: 34858 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void DNBMNPKDPHC()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600882B RID: 34859 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void EKLDFELNMFP()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x0600882C RID: 34860 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void Off()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600882D RID: 34861 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void FKDGPHFONPB()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x0600882E RID: 34862 RVA: 0x003F5F68 File Offset: 0x003F4168
	private void ACCKEFCOBGN()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 509f;
		this.backImage.color = color;
	}

	// Token: 0x0600882F RID: 34863 RVA: 0x003F5FA0 File Offset: 0x003F41A0
	private void MFOGDJHDIDA()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 759f;
		this.backImage.color = color;
	}

	// Token: 0x06008830 RID: 34864 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void JKDCKHECHEJ()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008831 RID: 34865 RVA: 0x003F5FD8 File Offset: 0x003F41D8
	private void LMGBKHCHPHO()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 1471f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008832 RID: 34866 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void CPLDNPIDPPM()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008833 RID: 34867 RVA: 0x003F606C File Offset: 0x003F426C
	private void MIFLHGMPLJD()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 1490f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008834 RID: 34868 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void FLFFEJFEPHF()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008835 RID: 34869 RVA: 0x003F6100 File Offset: 0x003F4300
	private void BBFCMCAFOMH()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 410f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008836 RID: 34870 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void LOMMHCGDKKD()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008837 RID: 34871 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void ODPAJFHKDAD()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008838 RID: 34872 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void IICFAPMJLCN()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600883A RID: 34874 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void EACKHNENAML()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600883B RID: 34875 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void MKLCOEALFBI()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x0600883C RID: 34876 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void OMEOGFDIPKF()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600883D RID: 34877 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void FBBMIGDIAJO()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600883E RID: 34878 RVA: 0x003F61B0 File Offset: 0x003F43B0
	private void BGKOJIDABKB()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 1951f;
		this.backImage.color = color;
	}

	// Token: 0x0600883F RID: 34879 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void MFIMAOPLEGP()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008840 RID: 34880 RVA: 0x003F61E8 File Offset: 0x003F43E8
	private void IDMCOLDDNCF()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 1946f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008841 RID: 34881 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void LNNKANCIIFM()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008842 RID: 34882 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void LLFANOGKPKM()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008843 RID: 34883 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void DPDNFBONNOD()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008844 RID: 34884 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void EIENCEFMEHA()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008845 RID: 34885 RVA: 0x003F627C File Offset: 0x003F447C
	private void BKGHBKPDMDH()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 944f;
		this.backImage.color = color;
	}

	// Token: 0x06008846 RID: 34886 RVA: 0x003F62B4 File Offset: 0x003F44B4
	private void NFPFDOEENLA()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 1766f)
			{
				base.gameObject.SetActive(false);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008847 RID: 34887 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void NHHACFNCDCM()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008848 RID: 34888 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void DBEEJCDLMKD()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008849 RID: 34889 RVA: 0x003F6348 File Offset: 0x003F4548
	private void LBOONMDONCF()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 273f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x0600884A RID: 34890 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void GBLHONBMMMJ()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x0600884B RID: 34891 RVA: 0x003F63DC File Offset: 0x003F45DC
	private void AMGINIANPFJ()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 1954f;
		this.backImage.color = color;
	}

	// Token: 0x0600884C RID: 34892 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void PGJOCPPOGAI()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600884D RID: 34893 RVA: 0x003F6414 File Offset: 0x003F4614
	private void FJBPGBMDBBF()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 550f;
		this.backImage.color = color;
	}

	// Token: 0x0600884E RID: 34894 RVA: 0x003F644C File Offset: 0x003F464C
	private void JMFMOADCCIE()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 1658f;
		this.backImage.color = color;
	}

	// Token: 0x0600884F RID: 34895 RVA: 0x003F6484 File Offset: 0x003F4684
	private void ALHFPHHGIHK()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 562f;
		this.backImage.color = color;
	}

	// Token: 0x06008850 RID: 34896 RVA: 0x003F64BC File Offset: 0x003F46BC
	private void NFJKCBFCHBP()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 660f;
		this.backImage.color = color;
	}

	// Token: 0x06008851 RID: 34897 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void MLPCBOGCEEO()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008852 RID: 34898 RVA: 0x003F64F4 File Offset: 0x003F46F4
	private void KBMKHLDOIKP()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 1526f)
			{
				base.gameObject.SetActive(false);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008853 RID: 34899 RVA: 0x003F6588 File Offset: 0x003F4788
	private void Update()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 0f)
			{
				base.gameObject.SetActive(false);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008854 RID: 34900 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void OnDisable()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008855 RID: 34901 RVA: 0x003F661C File Offset: 0x003F481C
	private void DNPKJPPIHOO()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 1566f;
		this.backImage.color = color;
	}

	// Token: 0x06008856 RID: 34902 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void BLPEKOGDGCC()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008857 RID: 34903 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void AHMFIGNLJOB()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008858 RID: 34904 RVA: 0x003F6654 File Offset: 0x003F4854
	private void DKEFEKOLGFB()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 1130f;
		this.backImage.color = color;
	}

	// Token: 0x06008859 RID: 34905 RVA: 0x003F668C File Offset: 0x003F488C
	private void MEJAMIFNCGO()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 486f;
		this.backImage.color = color;
	}

	// Token: 0x0600885A RID: 34906 RVA: 0x003F66C4 File Offset: 0x003F48C4
	private void IEHEAJJALNG()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 1098f;
		this.backImage.color = color;
	}

	// Token: 0x0600885B RID: 34907 RVA: 0x003F66FC File Offset: 0x003F48FC
	private void OnEnable()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 0f;
		this.backImage.color = color;
	}

	// Token: 0x0600885C RID: 34908 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void HBHLANEHNBK()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600885D RID: 34909 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void CALFOKBIBIG()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x0600885E RID: 34910 RVA: 0x003F6734 File Offset: 0x003F4934
	private void AKPLEHHPKGC()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 760f;
		this.backImage.color = color;
	}

	// Token: 0x0600885F RID: 34911 RVA: 0x003F676C File Offset: 0x003F496C
	private void ECHEPDJBGLP()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 205f;
		this.backImage.color = color;
	}

	// Token: 0x06008860 RID: 34912 RVA: 0x003F67A4 File Offset: 0x003F49A4
	private void GPCKACGEILI()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 421f)
			{
				base.gameObject.SetActive(false);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008861 RID: 34913 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void IHGJDIFCPBB()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008862 RID: 34914 RVA: 0x003F6838 File Offset: 0x003F4A38
	private void EBLJKEAHIGD()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 1422f;
		this.backImage.color = color;
	}

	// Token: 0x06008863 RID: 34915 RVA: 0x003F6870 File Offset: 0x003F4A70
	private void BOIFJMFAOGK()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 479f;
		this.backImage.color = color;
	}

	// Token: 0x06008864 RID: 34916 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void FDLDBGENEKE()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008865 RID: 34917 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void JGHJOBDKDKM()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008866 RID: 34918 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void ILHJHPOOOHH()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008867 RID: 34919 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void FHIOAMNEADG()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008868 RID: 34920 RVA: 0x003F68A8 File Offset: 0x003F4AA8
	private void HNMODJBBKBI()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 315f)
			{
				base.gameObject.SetActive(false);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008869 RID: 34921 RVA: 0x003F693C File Offset: 0x003F4B3C
	private void PAKOHKKBKHD()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 640f)
			{
				base.gameObject.SetActive(false);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x0600886A RID: 34922 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void NHOELCKOMJN()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600886B RID: 34923 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void KIKJOCKPGJB()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x0600886C RID: 34924 RVA: 0x003F69D0 File Offset: 0x003F4BD0
	private void FALFMIAEIJC()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 818f;
		this.backImage.color = color;
	}

	// Token: 0x0600886D RID: 34925 RVA: 0x003F6A08 File Offset: 0x003F4C08
	private void CDLDCKAHLHC()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 1491f)
			{
				base.gameObject.SetActive(false);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x0600886E RID: 34926 RVA: 0x003F6A9C File Offset: 0x003F4C9C
	private void HMLNMHOMMNO()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 1864f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x0600886F RID: 34927 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void DGKMFIEGNNH()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008870 RID: 34928 RVA: 0x003F6B30 File Offset: 0x003F4D30
	private void DPGECEOMHNM()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 1903f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008871 RID: 34929 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void NKJPOCKDEDI()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008872 RID: 34930 RVA: 0x003F6BC4 File Offset: 0x003F4DC4
	private void HJCLNJLADKL()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 466f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008873 RID: 34931 RVA: 0x003F6C58 File Offset: 0x003F4E58
	private void NKEJKDGBPOP()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 1935f;
		this.backImage.color = color;
	}

	// Token: 0x06008874 RID: 34932 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void HCALCPFJBLL()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008875 RID: 34933 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void BNOLDFLILJA()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008876 RID: 34934 RVA: 0x003F6C90 File Offset: 0x003F4E90
	private void JOKAAEKICJK()
	{
		this.HKPAEGGJNGG = true;
		Color color = this.backImage.color;
		color.a = 72f;
		this.backImage.color = color;
	}

	// Token: 0x06008877 RID: 34935 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void PNDHIFCPBOL()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008878 RID: 34936 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void IAGCJNMNJEE()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008879 RID: 34937 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void LKGIJBLNANI()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x0600887A RID: 34938 RVA: 0x003F6CC8 File Offset: 0x003F4EC8
	private void MPLCAGFGEBO()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 931f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x0600887B RID: 34939 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void NJBEKBHCLIO()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600887C RID: 34940 RVA: 0x003F6D5C File Offset: 0x003F4F5C
	private void BBAGNFIALFG()
	{
		this.HKPAEGGJNGG = false;
		Color color = this.backImage.color;
		color.a = 603f;
		this.backImage.color = color;
	}

	// Token: 0x0600887D RID: 34941 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void OFLCJDPLHHD()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600887E RID: 34942 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void JIGLHJINLFH()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x0600887F RID: 34943 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void NJFOOJIADNH()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008880 RID: 34944 RVA: 0x003F6D94 File Offset: 0x003F4F94
	private void FPLNDDMFFKG()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 408f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008881 RID: 34945 RVA: 0x003F5F5E File Offset: 0x003F415E
	public void LKLIOCDJNLO()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008882 RID: 34946 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void GHFJKCONPIE()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008883 RID: 34947 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void IJPGOIBAEEF()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008884 RID: 34948 RVA: 0x003F5F5E File Offset: 0x003F415E
	private void JCEKLINBCDB()
	{
		this.HKPAEGGJNGG = true;
	}

	// Token: 0x06008885 RID: 34949 RVA: 0x003F6E28 File Offset: 0x003F5028
	private void AKLFCMNCPKL()
	{
		Color color = this.backImage.color;
		if (this.HKPAEGGJNGG)
		{
			color.a += Time.deltaTime * this.deltaSpeed;
			if (color.a > this.toAlfa)
			{
				color.a = this.toAlfa;
			}
		}
		else
		{
			color.a -= Time.deltaTime * this.deltaSpeed;
			if (color.a <= 808f)
			{
				base.gameObject.SetActive(true);
			}
		}
		this.backImage.color = color;
	}

	// Token: 0x06008886 RID: 34950 RVA: 0x003F5F55 File Offset: 0x003F4155
	private void LLLBNNNNFPJ()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x06008887 RID: 34951 RVA: 0x003F5F55 File Offset: 0x003F4155
	public void LNJDMFFCLEI()
	{
		this.HKPAEGGJNGG = false;
	}

	// Token: 0x040012F1 RID: 4849
	public Image backImage;

	// Token: 0x040012F2 RID: 4850
	public float toAlfa = 0.8f;

	// Token: 0x040012F3 RID: 4851
	public float deltaSpeed = 0.8f;

	// Token: 0x040012F4 RID: 4852
	private bool HKPAEGGJNGG;
}
