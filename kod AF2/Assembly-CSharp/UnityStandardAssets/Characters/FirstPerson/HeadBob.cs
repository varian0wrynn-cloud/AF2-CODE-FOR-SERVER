using System;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	// Token: 0x020003A4 RID: 932
	public class HeadBob : MonoBehaviour
	{
		// Token: 0x0600C99C RID: 51612 RVA: 0x005A2CF8 File Offset: 0x005A0EF8
		private void CDLDCKAHLHC()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.KBKJBOEGGEM.magnitude > 1855f && this.rigidbodyFirstPersonController.MPJCOANBFOG())
			{
				this.Camera.transform.localPosition = this.motionBob.PEJBDDGKGMO(this.rigidbodyFirstPersonController.NEKOHBMFNPN().magnitude * (this.rigidbodyFirstPersonController.PEPELEHPMJJ() ? this.RunningStrideLengthen : 1898f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.LIACKFEKDKC();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.NEDLIEPEJEI();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.PKKLAFDHJCB())
			{
				base.StartCoroutine(this.jumpAndLandingBob.NKEPDOHLINM());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.HNEAIHHCBHF();
		}

		// Token: 0x0600C99D RID: 51613 RVA: 0x005A2E30 File Offset: 0x005A1030
		private void DFFOEGHGPGP()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.JJPMBBLHNML().magnitude > 236f && this.rigidbodyFirstPersonController.ELODMHNIPCF())
			{
				this.Camera.transform.localPosition = this.motionBob.HMHGHNBEGNC(this.rigidbodyFirstPersonController.MIGPEFMOJAD().magnitude * (this.rigidbodyFirstPersonController.OINAFHGLNEG ? this.RunningStrideLengthen : 286f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.JGKNHPONEFA();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.MILKIPIIHPA();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.GEOPIGHCMAO())
			{
				base.StartCoroutine(this.jumpAndLandingBob.OHAFMHAFJOG());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.OBMNCNDFOBG();
		}

		// Token: 0x0600C99E RID: 51614 RVA: 0x005A2F66 File Offset: 0x005A1166
		private void DGEIACONKCJ()
		{
			this.motionBob.BGKLIGMBHFO(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C99F RID: 51615 RVA: 0x005A2F95 File Offset: 0x005A1195
		private void Start()
		{
			this.motionBob.NBDIALKKHOE(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9A0 RID: 51616 RVA: 0x005A2FC4 File Offset: 0x005A11C4
		private void PFNOEACNHON()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.EKOLAGAJOOA().magnitude > 44f && this.rigidbodyFirstPersonController.JHFINANLCEC())
			{
				this.Camera.transform.localPosition = this.motionBob.CMCKNLNPEFA(this.rigidbodyFirstPersonController.JJPMBBLHNML().magnitude * (this.rigidbodyFirstPersonController.BBFBGIGALHP() ? this.RunningStrideLengthen : 789f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.NEDLIEPEJEI();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.ODJMDDKBJHA();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.MPJCOANBFOG())
			{
				base.StartCoroutine(this.jumpAndLandingBob.NNNJLODDHKK());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.NDIAEBCMKFA();
		}

		// Token: 0x0600C9A1 RID: 51617 RVA: 0x005A30FC File Offset: 0x005A12FC
		private void JOHDLNOKCOK()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.CICNMKHCHMF().magnitude > 1285f && this.rigidbodyFirstPersonController.DHBAFPCCLIK())
			{
				this.Camera.transform.localPosition = this.motionBob.ODJEKBLNNMG(this.rigidbodyFirstPersonController.CICNMKHCHMF().magnitude * (this.rigidbodyFirstPersonController.IBKHAHBGCLP() ? this.RunningStrideLengthen : 1897f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.FEBPOHAHJPB();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.FEHLBEIOPJJ();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.DLGJBAFGCFI())
			{
				base.StartCoroutine(this.jumpAndLandingBob.ODCGEKBDEKG());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.FMDLJFIKPKB;
		}

		// Token: 0x0600C9A2 RID: 51618 RVA: 0x005A3232 File Offset: 0x005A1432
		private void JLKBMEBFHBI()
		{
			this.motionBob.IHINGJEEHID(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9A3 RID: 51619 RVA: 0x005A3261 File Offset: 0x005A1461
		private void MODJFGGIAHD()
		{
			this.motionBob.JAACHGMDGPI(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9A4 RID: 51620 RVA: 0x005A3290 File Offset: 0x005A1490
		private void CBBLGEDCJBF()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.CICNMKHCHMF().magnitude > 1644f && this.rigidbodyFirstPersonController.JHCLBAFPIGL())
			{
				this.Camera.transform.localPosition = this.motionBob.NFNFKKJNPHD(this.rigidbodyFirstPersonController.MMPMODKGDDC().magnitude * (this.rigidbodyFirstPersonController.HKJIMAFEEHN() ? this.RunningStrideLengthen : 1943f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.MMCOMDPKBLN();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.LCGJOEHEAOO();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.ELODMHNIPCF())
			{
				base.StartCoroutine(this.jumpAndLandingBob.JPAEEEFLPDE());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.PKKLAFDHJCB();
		}

		// Token: 0x0600C9A5 RID: 51621 RVA: 0x005A33C8 File Offset: 0x005A15C8
		private void EKCKBDKEAKO()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.ABGICPOBPDC().magnitude > 138f && this.rigidbodyFirstPersonController.ACEBLDAKKOK())
			{
				this.Camera.transform.localPosition = this.motionBob.ANEEAONDHCF(this.rigidbodyFirstPersonController.KBKJBOEGGEM.magnitude * (this.rigidbodyFirstPersonController.HKJIMAFEEHN() ? this.RunningStrideLengthen : 1904f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.PIHFBJMMAIL();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.ABKKODINNNB();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.EBEHIJDMDBM())
			{
				base.StartCoroutine(this.jumpAndLandingBob.JLAJDPEPHHN());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.JHFINANLCEC();
		}

		// Token: 0x0600C9A6 RID: 51622 RVA: 0x005A34FE File Offset: 0x005A16FE
		private void ONIHHFLOJMN()
		{
			this.motionBob.LBADAIEMHGF(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9A7 RID: 51623 RVA: 0x005A3530 File Offset: 0x005A1730
		private void JPHLMNIMDHH()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.JJPMBBLHNML().magnitude > 1097f && this.rigidbodyFirstPersonController.DLGJBAFGCFI())
			{
				this.Camera.transform.localPosition = this.motionBob.MFEJNAMNELL(this.rigidbodyFirstPersonController.LIBCKAONFEB().magnitude * (this.rigidbodyFirstPersonController.HKJIMAFEEHN() ? this.RunningStrideLengthen : 916f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.LCGJOEHEAOO();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.NOFJGAPNINK();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.OBMNCNDFOBG())
			{
				base.StartCoroutine(this.jumpAndLandingBob.NILJIJJPHNK());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.PKKLAFDHJCB();
		}

		// Token: 0x0600C9A8 RID: 51624 RVA: 0x005A3666 File Offset: 0x005A1866
		private void FPLHODJCJDO()
		{
			this.motionBob.LLGMFFDPIHI(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9A9 RID: 51625 RVA: 0x005A3695 File Offset: 0x005A1895
		private void EFJDBBDMPMC()
		{
			this.motionBob.EFJJOGCGNAM(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9AA RID: 51626 RVA: 0x005A3232 File Offset: 0x005A1432
		private void JFFPLABGMNF()
		{
			this.motionBob.IHINGJEEHID(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9AB RID: 51627 RVA: 0x005A36C4 File Offset: 0x005A18C4
		private void OPDCJCFMIPE()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.EENLEHMJMDA().magnitude > 11f && this.rigidbodyFirstPersonController.ACEBLDAKKOK())
			{
				this.Camera.transform.localPosition = this.motionBob.CMCKNLNPEFA(this.rigidbodyFirstPersonController.MIGPEFMOJAD().magnitude * (this.rigidbodyFirstPersonController.KHKODMIBJMF() ? this.RunningStrideLengthen : 1231f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.AAHPOBCGKKD();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.MMCOMDPKBLN();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.EBEHIJDMDBM())
			{
				base.StartCoroutine(this.jumpAndLandingBob.BEDJFMLOMOP());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.HNEAIHHCBHF();
		}

		// Token: 0x0600C9AC RID: 51628 RVA: 0x005A37FC File Offset: 0x005A19FC
		private void PJHEGHHOJHJ()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.MIGPEFMOJAD().magnitude > 567f && this.rigidbodyFirstPersonController.OBMNCNDFOBG())
			{
				this.Camera.transform.localPosition = this.motionBob.FKNMNOKJCEN(this.rigidbodyFirstPersonController.NEKOHBMFNPN().magnitude * (this.rigidbodyFirstPersonController.BBFBGIGALHP() ? this.RunningStrideLengthen : 939f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.MFHOGHFEPAN();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.ODJMDDKBJHA();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.DLGJBAFGCFI())
			{
				base.StartCoroutine(this.jumpAndLandingBob.GHFEELIGDGE());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.EBEHIJDMDBM();
		}

		// Token: 0x0600C9AD RID: 51629 RVA: 0x005A3934 File Offset: 0x005A1B34
		private void KJJBBLDJHPD()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.EENLEHMJMDA().magnitude > 1222f && this.rigidbodyFirstPersonController.GEOPIGHCMAO())
			{
				this.Camera.transform.localPosition = this.motionBob.CPMBPCCKDDI(this.rigidbodyFirstPersonController.ABGICPOBPDC().magnitude * (this.rigidbodyFirstPersonController.KHKODMIBJMF() ? this.RunningStrideLengthen : 312f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.NEDLIEPEJEI();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.AAHPOBCGKKD();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.JHFINANLCEC())
			{
				base.StartCoroutine(this.jumpAndLandingBob.JPAEEEFLPDE());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.ELODMHNIPCF();
		}

		// Token: 0x0600C9AE RID: 51630 RVA: 0x005A3A6A File Offset: 0x005A1C6A
		private void HDFCIACDDEK()
		{
			this.motionBob.EJCDJLGPIDI(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9AF RID: 51631 RVA: 0x005A3A9C File Offset: 0x005A1C9C
		private void BJOICAKCPLI()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.EKOLAGAJOOA().magnitude > 1987f && this.rigidbodyFirstPersonController.ELODMHNIPCF())
			{
				this.Camera.transform.localPosition = this.motionBob.IMFOEDDDIMK(this.rigidbodyFirstPersonController.NEKOHBMFNPN().magnitude * (this.rigidbodyFirstPersonController.MFBDMNPCJMK() ? this.RunningStrideLengthen : 1378f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.AKAEDICLMEN();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.AKAEDICLMEN();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.ELODMHNIPCF())
			{
				base.StartCoroutine(this.jumpAndLandingBob.HDLGPPKNFFB());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.ELODMHNIPCF();
		}

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x005A3BD4 File Offset: 0x005A1DD4
		private void FJEEADNCKAG()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.ABGICPOBPDC().magnitude > 698f && this.rigidbodyFirstPersonController.ACEBLDAKKOK())
			{
				this.Camera.transform.localPosition = this.motionBob.IMFOEDDDIMK(this.rigidbodyFirstPersonController.ABGICPOBPDC().magnitude * (this.rigidbodyFirstPersonController.BBFBGIGALHP() ? this.RunningStrideLengthen : 1231f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.HHCOPPICJDB();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.FEHLBEIOPJJ();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.JHCLBAFPIGL())
			{
				base.StartCoroutine(this.jumpAndLandingBob.OEMAMJIMLOP());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.DHBAFPCCLIK();
		}

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x005A3D0C File Offset: 0x005A1F0C
		private void KBMKHLDOIKP()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.MMPMODKGDDC().magnitude > 1429f && this.rigidbodyFirstPersonController.EBEHIJDMDBM())
			{
				this.Camera.transform.localPosition = this.motionBob.ODJEKBLNNMG(this.rigidbodyFirstPersonController.NEKOHBMFNPN().magnitude * (this.rigidbodyFirstPersonController.IBKHAHBGCLP() ? this.RunningStrideLengthen : 283f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.NNMNFBACNEN();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.MLEBPLJPFJE();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.DHBAFPCCLIK())
			{
				base.StartCoroutine(this.jumpAndLandingBob.ACOCAHDKDGJ());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.EBEHIJDMDBM();
		}

		// Token: 0x0600C9B2 RID: 51634 RVA: 0x005A3E44 File Offset: 0x005A2044
		private void PFPPDNHLCCA()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.ABGICPOBPDC().magnitude > 1323f && this.rigidbodyFirstPersonController.EBEHIJDMDBM())
			{
				this.Camera.transform.localPosition = this.motionBob.NFNFKKJNPHD(this.rigidbodyFirstPersonController.EENLEHMJMDA().magnitude * (this.rigidbodyFirstPersonController.BBFBGIGALHP() ? this.RunningStrideLengthen : 212f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.HHCOPPICJDB();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.PPOLOKFLGGN();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.EBEHIJDMDBM())
			{
				base.StartCoroutine(this.jumpAndLandingBob.FOMPFMIEGBJ());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.FMDLJFIKPKB;
		}

		// Token: 0x0600C9B3 RID: 51635 RVA: 0x005A3F7A File Offset: 0x005A217A
		private void AOCDDBNBADJ()
		{
			this.motionBob.MDNHIOEIBKO(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9B4 RID: 51636 RVA: 0x005A3FAC File Offset: 0x005A21AC
		private void JIFOELPAEHG()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.MMPMODKGDDC().magnitude > 517f && this.rigidbodyFirstPersonController.DHBAFPCCLIK())
			{
				this.Camera.transform.localPosition = this.motionBob.MKLOILLONGN(this.rigidbodyFirstPersonController.MIGPEFMOJAD().magnitude * (this.rigidbodyFirstPersonController.NGAFIECHICL() ? this.RunningStrideLengthen : 1180f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.ABKKODINNNB();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.FEBPOHAHJPB();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.JHFINANLCEC())
			{
				base.StartCoroutine(this.jumpAndLandingBob.OEMAMJIMLOP());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.GEOPIGHCMAO();
		}

		// Token: 0x0600C9B5 RID: 51637 RVA: 0x005A40E2 File Offset: 0x005A22E2
		private void OBJCOJEHLBE()
		{
			this.motionBob.KGLONDNGAHE(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9B6 RID: 51638 RVA: 0x005A4111 File Offset: 0x005A2311
		private void ELFLOPJDAKK()
		{
			this.motionBob.JPMIPIAFAIA(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9B7 RID: 51639 RVA: 0x005A4140 File Offset: 0x005A2340
		private void IAAOGAPJDID()
		{
			this.motionBob.NDPBPPGLILN(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9B8 RID: 51640 RVA: 0x005A4170 File Offset: 0x005A2370
		private void BNKJNBIDPME()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.EKOLAGAJOOA().magnitude > 117f && this.rigidbodyFirstPersonController.ELODMHNIPCF())
			{
				this.Camera.transform.localPosition = this.motionBob.PCFFEELPMND(this.rigidbodyFirstPersonController.NEKOHBMFNPN().magnitude * (this.rigidbodyFirstPersonController.HKJIMAFEEHN() ? this.RunningStrideLengthen : 373f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.ODJMDDKBJHA();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.MLEBPLJPFJE();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.FMDLJFIKPKB)
			{
				base.StartCoroutine(this.jumpAndLandingBob.LIHGOMGIIBE());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.JHCLBAFPIGL();
		}

		// Token: 0x0600C9B9 RID: 51641 RVA: 0x005A42A6 File Offset: 0x005A24A6
		private void ANHOOJFEJJE()
		{
			this.motionBob.BPOMBPLNIBD(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9BA RID: 51642 RVA: 0x005A40E2 File Offset: 0x005A22E2
		private void FIJKDFIMELM()
		{
			this.motionBob.KGLONDNGAHE(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9BB RID: 51643 RVA: 0x005A42D8 File Offset: 0x005A24D8
		private void LIOCDEICIFD()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.NEKOHBMFNPN().magnitude > 1940f && this.rigidbodyFirstPersonController.OBMNCNDFOBG())
			{
				this.Camera.transform.localPosition = this.motionBob.KBCHCKLLFCC(this.rigidbodyFirstPersonController.EKOLAGAJOOA().magnitude * (this.rigidbodyFirstPersonController.KGEBCMFLOOB() ? this.RunningStrideLengthen : 113f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.PKOKGKOHLAH();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.IHLOCDJDEKJ();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.FMDLJFIKPKB)
			{
				base.StartCoroutine(this.jumpAndLandingBob.IBFJKGBNJHK());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.JHCLBAFPIGL();
		}

		// Token: 0x0600C9BC RID: 51644 RVA: 0x005A4410 File Offset: 0x005A2610
		private void MEFOGCFJBNE()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.KBKJBOEGGEM.magnitude > 1499f && this.rigidbodyFirstPersonController.GEOPIGHCMAO())
			{
				this.Camera.transform.localPosition = this.motionBob.MFEJNAMNELL(this.rigidbodyFirstPersonController.EKOLAGAJOOA().magnitude * (this.rigidbodyFirstPersonController.OINAFHGLNEG ? this.RunningStrideLengthen : 219f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.MLEBPLJPFJE();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.BGEEIEHJJKE();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.NDIAEBCMKFA())
			{
				base.StartCoroutine(this.jumpAndLandingBob.OHAFMHAFJOG());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.ACEBLDAKKOK();
		}

		// Token: 0x0600C9BE RID: 51646 RVA: 0x005A4564 File Offset: 0x005A2764
		private void Update()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.KBKJBOEGGEM.magnitude > 0f && this.rigidbodyFirstPersonController.FMDLJFIKPKB)
			{
				this.Camera.transform.localPosition = this.motionBob.CMCKNLNPEFA(this.rigidbodyFirstPersonController.KBKJBOEGGEM.magnitude * (this.rigidbodyFirstPersonController.OINAFHGLNEG ? this.RunningStrideLengthen : 1f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.MFHOGHFEPAN();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.MFHOGHFEPAN();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.FMDLJFIKPKB)
			{
				base.StartCoroutine(this.jumpAndLandingBob.FNOPJLIAFKO());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.FMDLJFIKPKB;
		}

		// Token: 0x0600C9BF RID: 51647 RVA: 0x005A469A File Offset: 0x005A289A
		private void CGMHGDEKDEP()
		{
			this.motionBob.NDCNMINBNJO(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x005A46CC File Offset: 0x005A28CC
		private void IGEICBNMPAD()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.JJPMBBLHNML().magnitude > 49f && this.rigidbodyFirstPersonController.DHBAFPCCLIK())
			{
				this.Camera.transform.localPosition = this.motionBob.ANEEAONDHCF(this.rigidbodyFirstPersonController.JJPMBBLHNML().magnitude * (this.rigidbodyFirstPersonController.PEPELEHPMJJ() ? this.RunningStrideLengthen : 997f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.IAJDIAPFDPN();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.LCGJOEHEAOO();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.PKKLAFDHJCB())
			{
				base.StartCoroutine(this.jumpAndLandingBob.JLAJDPEPHHN());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.PKKLAFDHJCB();
		}

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x005A40E2 File Offset: 0x005A22E2
		private void EDGALMCHPPH()
		{
			this.motionBob.KGLONDNGAHE(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x005A4802 File Offset: 0x005A2A02
		private void OFGMIEJKMGC()
		{
			this.motionBob.OJOLMKNNFOB(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x005A3695 File Offset: 0x005A1895
		private void IMABGALEMBI()
		{
			this.motionBob.EFJJOGCGNAM(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x005A3A6A File Offset: 0x005A1C6A
		private void ELADFDNPOOI()
		{
			this.motionBob.EJCDJLGPIDI(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9C5 RID: 51653 RVA: 0x005A4834 File Offset: 0x005A2A34
		private void HMLNMHOMMNO()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.EKOLAGAJOOA().magnitude > 878f && this.rigidbodyFirstPersonController.FMDLJFIKPKB)
			{
				this.Camera.transform.localPosition = this.motionBob.ODJEKBLNNMG(this.rigidbodyFirstPersonController.MMPMODKGDDC().magnitude * (this.rigidbodyFirstPersonController.MFBDMNPCJMK() ? this.RunningStrideLengthen : 1224f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.ODJMDDKBJHA();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.PKOKGKOHLAH();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.JHCLBAFPIGL())
			{
				base.StartCoroutine(this.jumpAndLandingBob.JPAEEEFLPDE());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.FMDLJFIKPKB;
		}

		// Token: 0x0600C9C6 RID: 51654 RVA: 0x005A3261 File Offset: 0x005A1461
		private void CAJLCEPLKJG()
		{
			this.motionBob.JAACHGMDGPI(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9C7 RID: 51655 RVA: 0x005A496C File Offset: 0x005A2B6C
		private void FOHLAIIMNFB()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.ABGICPOBPDC().magnitude > 301f && this.rigidbodyFirstPersonController.JHFINANLCEC())
			{
				this.Camera.transform.localPosition = this.motionBob.CPMBPCCKDDI(this.rigidbodyFirstPersonController.EENLEHMJMDA().magnitude * (this.rigidbodyFirstPersonController.KGEBCMFLOOB() ? this.RunningStrideLengthen : 909f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.PIHFBJMMAIL();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.BGEEIEHJJKE();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.ELODMHNIPCF())
			{
				base.StartCoroutine(this.jumpAndLandingBob.BEDJFMLOMOP());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.HNEAIHHCBHF();
		}

		// Token: 0x0600C9C8 RID: 51656 RVA: 0x005A40E2 File Offset: 0x005A22E2
		private void KGICJDGIIJK()
		{
			this.motionBob.KGLONDNGAHE(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9C9 RID: 51657 RVA: 0x005A3F7A File Offset: 0x005A217A
		private void NOKJMMDMJNO()
		{
			this.motionBob.MDNHIOEIBKO(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9CA RID: 51658 RVA: 0x005A4AA4 File Offset: 0x005A2CA4
		private void CJHBCHBOLBI()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.EKOLAGAJOOA().magnitude > 824f && this.rigidbodyFirstPersonController.DHBAFPCCLIK())
			{
				this.Camera.transform.localPosition = this.motionBob.ODJEKBLNNMG(this.rigidbodyFirstPersonController.EKOLAGAJOOA().magnitude * (this.rigidbodyFirstPersonController.NGAFIECHICL() ? this.RunningStrideLengthen : 547f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.IAJDIAPFDPN();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.EDANCOOIPNB();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.JHFINANLCEC())
			{
				base.StartCoroutine(this.jumpAndLandingBob.JLAJDPEPHHN());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.DLGJBAFGCFI();
		}

		// Token: 0x0600C9CB RID: 51659 RVA: 0x005A4BDA File Offset: 0x005A2DDA
		private void INDGOHJGCFN()
		{
			this.motionBob.BNKHIEFMPEH(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9CC RID: 51660 RVA: 0x005A4C0C File Offset: 0x005A2E0C
		private void MFHGOLNLAAF()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.MMPMODKGDDC().magnitude > 120f && this.rigidbodyFirstPersonController.GEOPIGHCMAO())
			{
				this.Camera.transform.localPosition = this.motionBob.PEJBDDGKGMO(this.rigidbodyFirstPersonController.ABGICPOBPDC().magnitude * (this.rigidbodyFirstPersonController.KHKODMIBJMF() ? this.RunningStrideLengthen : 730f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.FBPMDMLOCGD();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.AAHPOBCGKKD();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.HNEAIHHCBHF())
			{
				base.StartCoroutine(this.jumpAndLandingBob.PBJMIBMPCCM());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.PKKLAFDHJCB();
		}

		// Token: 0x0600C9CD RID: 51661 RVA: 0x005A4D42 File Offset: 0x005A2F42
		private void KKCFKEDABLB()
		{
			this.motionBob.OLEOIIBMIBK(this.Camera, this.StrideInterval);
			this.MIOLLFJGDOH = this.Camera.transform.localPosition;
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x005A4D74 File Offset: 0x005A2F74
		private void PMKOAHMNBBG()
		{
			Vector3 localPosition;
			if (this.rigidbodyFirstPersonController.NEKOHBMFNPN().magnitude > 1779f && this.rigidbodyFirstPersonController.NDIAEBCMKFA())
			{
				this.Camera.transform.localPosition = this.motionBob.KMPEPHLMLAH(this.rigidbodyFirstPersonController.MMPMODKGDDC().magnitude * (this.rigidbodyFirstPersonController.KHKODMIBJMF() ? this.RunningStrideLengthen : 1279f));
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.Camera.transform.localPosition.y - this.jumpAndLandingBob.LCGJOEHEAOO();
			}
			else
			{
				localPosition = this.Camera.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.jumpAndLandingBob.IHLOCDJDEKJ();
			}
			this.Camera.transform.localPosition = localPosition;
			if (!this.LFMADIAIKDM && this.rigidbodyFirstPersonController.ELODMHNIPCF())
			{
				base.StartCoroutine(this.jumpAndLandingBob.ODCGEKBDEKG());
			}
			this.LFMADIAIKDM = this.rigidbodyFirstPersonController.JHCLBAFPIGL();
		}

		// Token: 0x04001AC1 RID: 6849
		public Camera Camera;

		// Token: 0x04001AC2 RID: 6850
		public CurveControlledBob motionBob = new CurveControlledBob();

		// Token: 0x04001AC3 RID: 6851
		public LerpControlledBob jumpAndLandingBob = new LerpControlledBob();

		// Token: 0x04001AC4 RID: 6852
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		// Token: 0x04001AC5 RID: 6853
		public float StrideInterval;

		// Token: 0x04001AC6 RID: 6854
		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		// Token: 0x04001AC7 RID: 6855
		private bool LFMADIAIKDM;

		// Token: 0x04001AC8 RID: 6856
		private Vector3 MIOLLFJGDOH;
	}
}
