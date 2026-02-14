using System;
using UnityEngine;

// Token: 0x0200001A RID: 26
[AddComponentMenu("Image Effects/Amplify Color Volume 2D")]
[RequireComponent(typeof(BoxCollider2D))]
public class AmplifyColorVolume2D : AmplifyColorVolumeBase
{
	// Token: 0x06000451 RID: 1105 RVA: 0x0003696C File Offset: 0x00034B6C
	private void PMELFAJBDFD(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -43)) != 0)
		{
			component.OwnerEffect.EICIDPKGOGA(this);
		}
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x000369C8 File Offset: 0x00034BC8
	private void OnTriggerEnter2D(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << base.gameObject.layer) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00036A24 File Offset: 0x00034C24
	private void GGNFHOBDGFJ(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -83)) != 0)
		{
			component.OwnerEffect.DJHCJIADHFJ(this);
		}
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00036A80 File Offset: 0x00034C80
	private void CMKFMLPANEK(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 37)) != 0)
		{
			component.OwnerEffect.DJHCJIADHFJ(this);
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00036ADC File Offset: 0x00034CDC
	private void FPEPKIADOHK(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 92)) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00036B38 File Offset: 0x00034D38
	private void BEIHFMMFBHM(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 11)) != 0)
		{
			component.OwnerEffect.CNBNEJJNLGP(this);
		}
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00036B94 File Offset: 0x00034D94
	private void BFEPKCOPNFH(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -98)) != 0)
		{
			component.OwnerEffect.CNBNEJJNLGP(this);
		}
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00036BF0 File Offset: 0x00034DF0
	private void CAOGJNKMJKL(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -49)) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00036C4C File Offset: 0x00034E4C
	private void IOFJOHPABHH(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 28)) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00036CA8 File Offset: 0x00034EA8
	private void DDFMKMMBBKI(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -99)) != 0)
		{
			component.OwnerEffect.ExitVolume(this);
		}
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00036D04 File Offset: 0x00034F04
	private void HMBAFMLCLFC(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -33)) != 0)
		{
			component.OwnerEffect.CNBNEJJNLGP(this);
		}
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00036D60 File Offset: 0x00034F60
	private void OHPKLDLHAPN(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 114)) != 0)
		{
			component.OwnerEffect.CNBNEJJNLGP(this);
		}
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00036DBC File Offset: 0x00034FBC
	private void GHIOMMJAKAO(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 5)) != 0)
		{
			component.OwnerEffect.GOHJCNGJNMP(this);
		}
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00036E18 File Offset: 0x00035018
	private void OGHIBNMJHIG(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 15)) != 0)
		{
			component.OwnerEffect.EICIDPKGOGA(this);
		}
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00036E74 File Offset: 0x00035074
	private void ABJMFHBANFA(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 7)) != 0)
		{
			component.OwnerEffect.CNBNEJJNLGP(this);
		}
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00036ED0 File Offset: 0x000350D0
	private void NHIFGDBBMDF(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -18)) != 0)
		{
			component.OwnerEffect.EHHFMNNLDOF(this);
		}
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00036F2C File Offset: 0x0003512C
	private void DIIHEEJLEIC(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -11)) != 0)
		{
			component.OwnerEffect.EHHFMNNLDOF(this);
		}
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00036F88 File Offset: 0x00035188
	private void HDEGIHGOJJB(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -116)) != 0)
		{
			component.OwnerEffect.GOHJCNGJNMP(this);
		}
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00036FE4 File Offset: 0x000351E4
	private void FIEDKGACOJL(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 75)) != 0)
		{
			component.OwnerEffect.EHHFMNNLDOF(this);
		}
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00037040 File Offset: 0x00035240
	private void PFHPNJJHCPL(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -111)) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x0003709C File Offset: 0x0003529C
	private void PHBBOFNBPFM(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -115)) != 0)
		{
			component.OwnerEffect.EHHFMNNLDOF(this);
		}
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x000370F8 File Offset: 0x000352F8
	private void NKFDHFHDNNF(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -66)) != 0)
		{
			component.OwnerEffect.GOHJCNGJNMP(this);
		}
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00037154 File Offset: 0x00035354
	private void EMMPCCGDAKM(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -4)) != 0)
		{
			component.OwnerEffect.DJHCJIADHFJ(this);
		}
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x000371B0 File Offset: 0x000353B0
	private void CHMEPLALBAN(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 96)) != 0)
		{
			component.OwnerEffect.EHHFMNNLDOF(this);
		}
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x0003720C File Offset: 0x0003540C
	private void GFMKNHPNDKL(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -121)) != 0)
		{
			component.OwnerEffect.CNBNEJJNLGP(this);
		}
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00037268 File Offset: 0x00035468
	private void JCDLEFLHHIA(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 91)) != 0)
		{
			component.OwnerEffect.CNBNEJJNLGP(this);
		}
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x000372C4 File Offset: 0x000354C4
	private void HLGNFLPAPIH(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 29)) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00037320 File Offset: 0x00035520
	private void EOKGLPBJIMC(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 46)) != 0)
		{
			component.OwnerEffect.EICIDPKGOGA(this);
		}
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x0003737C File Offset: 0x0003557C
	private void MAFLJJOCKFA(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 117)) != 0)
		{
			component.OwnerEffect.EHHFMNNLDOF(this);
		}
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x000373D8 File Offset: 0x000355D8
	private void ENICLAFOPAB(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -23)) != 0)
		{
			component.OwnerEffect.ExitVolume(this);
		}
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00037434 File Offset: 0x00035634
	private void MCCFMDLHMHM(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -93)) != 0)
		{
			component.OwnerEffect.EICIDPKGOGA(this);
		}
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00037490 File Offset: 0x00035690
	private void KEFENHNJDHP(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 48)) != 0)
		{
			component.OwnerEffect.EICIDPKGOGA(this);
		}
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x000374EC File Offset: 0x000356EC
	private void FFIJADLDGHE(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -8)) != 0)
		{
			component.OwnerEffect.GOHJCNGJNMP(this);
		}
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00037548 File Offset: 0x00035748
	private void OIPJEMNHIFA(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -66)) != 0)
		{
			component.OwnerEffect.CNBNEJJNLGP(this);
		}
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x000375A4 File Offset: 0x000357A4
	private void BJBFLLMABIP(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 108)) != 0)
		{
			component.OwnerEffect.ExitVolume(this);
		}
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00037600 File Offset: 0x00035800
	private void AJCKILLCCHK(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -93)) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x0003765C File Offset: 0x0003585C
	private void AHFGNHFALPM(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -39)) != 0)
		{
			component.OwnerEffect.EICIDPKGOGA(this);
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x000376B8 File Offset: 0x000358B8
	private void JLHHHABFACB(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -85)) != 0)
		{
			component.OwnerEffect.DJHCJIADHFJ(this);
		}
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00037714 File Offset: 0x00035914
	private void ACNIMNOMNGN(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 54)) != 0)
		{
			component.OwnerEffect.DJHCJIADHFJ(this);
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00037770 File Offset: 0x00035970
	private void CCKPPNAANEL(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -28)) != 0)
		{
			component.OwnerEffect.ExitVolume(this);
		}
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x000377CC File Offset: 0x000359CC
	private void HPFGDAFFFNO(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 77)) != 0)
		{
			component.OwnerEffect.DJHCJIADHFJ(this);
		}
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00037828 File Offset: 0x00035A28
	private void EHOOIJPLFFO(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 56)) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00037884 File Offset: 0x00035A84
	private void PELAFBENPGD(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -38)) != 0)
		{
			component.OwnerEffect.ExitVolume(this);
		}
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x000378E0 File Offset: 0x00035AE0
	private void HCOHFPGBNNJ(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & -26)) != 0)
		{
			component.OwnerEffect.EnterVolume(this);
		}
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x0003793C File Offset: 0x00035B3C
	private void OnTriggerExit2D(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << base.gameObject.layer) != 0)
		{
			component.OwnerEffect.ExitVolume(this);
		}
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00037998 File Offset: 0x00035B98
	private void OEGPPOABJAA(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & 15)) != 0)
		{
			component.OwnerEffect.EHHFMNNLDOF(this);
		}
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000379F4 File Offset: 0x00035BF4
	private void AACGIEMJBCI(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 0 << (base.gameObject.layer & -54)) != 0)
		{
			component.OwnerEffect.EHHFMNNLDOF(this);
		}
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00037A50 File Offset: 0x00035C50
	private void PNMPPAHEBBK(Collider2D INDANOPGHCN)
	{
		AmplifyColorTriggerProxy2D component = INDANOPGHCN.GetComponent<AmplifyColorTriggerProxy2D>();
		if (component != null && component.OwnerEffect.UseVolumes && (component.OwnerEffect.VolumeCollisionMask & 1 << (base.gameObject.layer & 75)) != 0)
		{
			component.OwnerEffect.DJHCJIADHFJ(this);
		}
	}
}
