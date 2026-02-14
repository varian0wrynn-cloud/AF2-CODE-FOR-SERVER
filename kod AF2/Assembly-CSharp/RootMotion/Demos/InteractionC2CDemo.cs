using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003FC RID: 1020
	public class InteractionC2CDemo : MonoBehaviour
	{
		// Token: 0x0600DB1E RID: 56094 RVA: 0x00645834 File Offset: 0x00643A34
		private void OEKHPJAEAAE()
		{
			Vector3 position = Vector3.Lerp(this.character1.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, this.character2.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position, 241f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB1F RID: 56095 RVA: 0x0064589B File Offset: 0x00643A9B
		private void BGJFLKLBOPK()
		{
			if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
			{
				this.character1.HCILLNOMHNJ(FullBodyBipedEffector.RightShoulder, this.handShake, false);
				this.character2.HCILLNOMHNJ(FullBodyBipedEffector.LeftShoulder, this.handShake, false);
			}
		}

		// Token: 0x0600DB20 RID: 56096 RVA: 0x006458D8 File Offset: 0x00643AD8
		private void OIKMLNIPLIA()
		{
			Vector3 position = Vector3.Lerp(this.character1.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, this.character2.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position, 1168f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x00645940 File Offset: 0x00643B40
		private void CMDJHGMGLCG()
		{
			Vector3 position = Vector3.Lerp(this.character1.GFHDNCHMCJI().solver.rightHandEffector.bone.position, this.character2.OJMBOCNNLMI.solver.rightHandEffector.bone.position, 1386f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x006459A8 File Offset: 0x00643BA8
		private void PIEDGJCBCBO()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, this.character2.GFHDNCHMCJI().solver.rightHandEffector.bone.position, 527f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB23 RID: 56099 RVA: 0x00645A0F File Offset: 0x00643C0F
		private void LPNFGGAKGID()
		{
			if (GUILayout.Button("UNIQUE_SHADOW_LIGHT_COOKIE", Array.Empty<GUILayoutOption>()))
			{
				this.character1.DOJCIIDNKNI(FullBodyBipedEffector.LeftFoot, this.handShake, false);
				this.character2.HCILLNOMHNJ(FullBodyBipedEffector.Body, this.handShake, true);
			}
		}

		// Token: 0x0600DB24 RID: 56100 RVA: 0x00645A4A File Offset: 0x00643C4A
		private void BCJFDHBDAHD()
		{
			if (GUILayout.Button("Mouse Y", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.LeftFoot, this.handShake, false);
				this.character2.StartInteraction(FullBodyBipedEffector.RightFoot, this.handShake, false);
			}
		}

		// Token: 0x0600DB25 RID: 56101 RVA: 0x00645A85 File Offset: 0x00643C85
		private void KBEOAOKBHEK()
		{
			if (GUILayout.Button("UnityEngine.Vector3", Array.Empty<GUILayoutOption>()))
			{
				this.character1.DOJCIIDNKNI(FullBodyBipedEffector.RightFoot, this.handShake, false);
				this.character2.HCILLNOMHNJ(FullBodyBipedEffector.LeftHand, this.handShake, true);
			}
		}

		// Token: 0x0600DB26 RID: 56102 RVA: 0x00645AC0 File Offset: 0x00643CC0
		private void GGOKNBBPLHB()
		{
			if (GUILayout.Button("u_UniqueShadowBlockerWidth", Array.Empty<GUILayoutOption>()))
			{
				this.character1.HCILLNOMHNJ(FullBodyBipedEffector.LeftFoot, this.handShake, false);
				this.character2.StartInteraction(FullBodyBipedEffector.LeftFoot, this.handShake, false);
			}
		}

		// Token: 0x0600DB27 RID: 56103 RVA: 0x00645AFC File Offset: 0x00643CFC
		private void OGFGENJAMAM()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.rightHandEffector.bone.position, this.character2.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position, 1857f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB28 RID: 56104 RVA: 0x00645B63 File Offset: 0x00643D63
		private void AHEAJPNHBBB()
		{
			if (GUILayout.Button("isbroken", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.RightThigh, this.handShake, false);
				this.character2.HCILLNOMHNJ(FullBodyBipedEffector.LeftThigh, this.handShake, false);
			}
		}

		// Token: 0x0600DB29 RID: 56105 RVA: 0x00645BA0 File Offset: 0x00643DA0
		private void BLOLJBHKGOH()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.rightHandEffector.bone.position, this.character2.GFHDNCHMCJI().solver.IANMIEDIJPJ().bone.position, 1137f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB2A RID: 56106 RVA: 0x00645C08 File Offset: 0x00643E08
		private void IKEBNJAMNDB()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.rightHandEffector.bone.position, this.character2.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, 1810f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB2B RID: 56107 RVA: 0x00645C70 File Offset: 0x00643E70
		private void POCOKCJDCHK()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, this.character2.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position, 461f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB2C RID: 56108 RVA: 0x00645CD8 File Offset: 0x00643ED8
		private void BHDPDDHLPOI()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position, this.character2.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, 488f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB2D RID: 56109 RVA: 0x00645D40 File Offset: 0x00643F40
		private void JPGFHBACEGG()
		{
			Vector3 position = Vector3.Lerp(this.character1.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, this.character2.GFHDNCHMCJI().solver.IANMIEDIJPJ().bone.position, 1970f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB2E RID: 56110 RVA: 0x00645DA7 File Offset: 0x00643FA7
		private void JGDDEOALNOG()
		{
			if (GUILayout.Button(" x", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.RightShoulder, this.handShake, false);
				this.character2.DOJCIIDNKNI(FullBodyBipedEffector.RightShoulder, this.handShake, false);
			}
		}

		// Token: 0x0600DB2F RID: 56111 RVA: 0x00645DE4 File Offset: 0x00643FE4
		private void AIKJPMIHCFP()
		{
			Vector3 position = Vector3.Lerp(this.character1.GFHDNCHMCJI().solver.IANMIEDIJPJ().bone.position, this.character2.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position, 646f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB30 RID: 56112 RVA: 0x00645E4B File Offset: 0x0064404B
		private void CGBKGPPNMNM()
		{
			if (GUILayout.Button("Mouse ScrollWheel", Array.Empty<GUILayoutOption>()))
			{
				this.character1.DOJCIIDNKNI(FullBodyBipedEffector.RightThigh, this.handShake, true);
				this.character2.HCILLNOMHNJ(FullBodyBipedEffector.Body, this.handShake, false);
			}
		}

		// Token: 0x0600DB32 RID: 56114 RVA: 0x00645E86 File Offset: 0x00644086
		private void OBDAPPLCPMD()
		{
			if (GUILayout.Button("sunshine_CascadeNearRatiosSq", Array.Empty<GUILayoutOption>()))
			{
				this.character1.DOJCIIDNKNI(FullBodyBipedEffector.LeftShoulder, this.handShake, true);
				this.character2.StartInteraction(FullBodyBipedEffector.RightHand, this.handShake, false);
			}
		}

		// Token: 0x0600DB33 RID: 56115 RVA: 0x00645EC4 File Offset: 0x006440C4
		private void MDBPBJHACDA()
		{
			Vector3 position = Vector3.Lerp(this.character1.GFHDNCHMCJI().solver.rightHandEffector.bone.position, this.character2.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, 1058f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB34 RID: 56116 RVA: 0x00645F2B File Offset: 0x0064412B
		private void EILPHLEBEJP()
		{
			if (GUILayout.Button("Sitting Hand Rest Finger Tap", Array.Empty<GUILayoutOption>()))
			{
				this.character1.HCILLNOMHNJ(FullBodyBipedEffector.Body, this.handShake, false);
				this.character2.HCILLNOMHNJ(FullBodyBipedEffector.RightThigh, this.handShake, false);
			}
		}

		// Token: 0x0600DB35 RID: 56117 RVA: 0x00645F66 File Offset: 0x00644166
		private void JEJGFDBHABC()
		{
			if (GUILayout.Button("MotorbikeSeatStandWheely", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.RightFoot, this.handShake, false);
				this.character2.DOJCIIDNKNI(FullBodyBipedEffector.RightHand, this.handShake, false);
			}
		}

		// Token: 0x0600DB36 RID: 56118 RVA: 0x00645FA1 File Offset: 0x006441A1
		private void PNJNNNJEBGA()
		{
			if (GUILayout.Button("signal_enable", Array.Empty<GUILayoutOption>()))
			{
				this.character1.HCILLNOMHNJ(FullBodyBipedEffector.LeftThigh, this.handShake, true);
				this.character2.StartInteraction(FullBodyBipedEffector.LeftFoot, this.handShake, false);
			}
		}

		// Token: 0x0600DB37 RID: 56119 RVA: 0x00645FDC File Offset: 0x006441DC
		private void MJDKGMEPMHK()
		{
			if (GUILayout.Button("Seat Stand", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.LeftHand, this.handShake, false);
				this.character2.StartInteraction(FullBodyBipedEffector.Body, this.handShake, true);
			}
		}

		// Token: 0x0600DB38 RID: 56120 RVA: 0x00646017 File Offset: 0x00644217
		private void NCFLINGBFJG()
		{
			if (GUILayout.Button("' that does not excist in the Node Chain.", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.RightFoot, this.handShake, false);
				this.character2.HCILLNOMHNJ(FullBodyBipedEffector.RightHand, this.handShake, false);
			}
		}

		// Token: 0x0600DB39 RID: 56121 RVA: 0x00646052 File Offset: 0x00644252
		private void OnGUI()
		{
			if (GUILayout.Button("Shake Hands", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.RightHand, this.handShake, true);
				this.character2.StartInteraction(FullBodyBipedEffector.RightHand, this.handShake, true);
			}
		}

		// Token: 0x0600DB3A RID: 56122 RVA: 0x00646090 File Offset: 0x00644290
		private void HKJHIANMOPG()
		{
			Vector3 position = Vector3.Lerp(this.character1.GFHDNCHMCJI().solver.rightHandEffector.bone.position, this.character2.OJMBOCNNLMI.solver.rightHandEffector.bone.position, 1279f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB3B RID: 56123 RVA: 0x006460F7 File Offset: 0x006442F7
		private void BBGAONKBIPJ()
		{
			if (GUILayout.Button("lifeBar", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.Body, this.handShake, true);
				this.character2.DOJCIIDNKNI(FullBodyBipedEffector.RightThigh, this.handShake, false);
			}
		}

		// Token: 0x0600DB3C RID: 56124 RVA: 0x00646134 File Offset: 0x00644334
		private void BOEFHGKGJMN()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.rightHandEffector.bone.position, this.character2.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 849f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB3D RID: 56125 RVA: 0x0064619C File Offset: 0x0064439C
		private void LHFBEKCIKOI()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.rightHandEffector.bone.position, this.character2.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position, 295f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB3E RID: 56126 RVA: 0x00646204 File Offset: 0x00644404
		private void HHJKBKLPLIM()
		{
			Vector3 position = Vector3.Lerp(this.character1.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, this.character2.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, 1826f);
			this.handShake.transform.position = position;
		}

		// Token: 0x0600DB3F RID: 56127 RVA: 0x0064626C File Offset: 0x0064446C
		private void LateUpdate()
		{
			Vector3 position = Vector3.Lerp(this.character1.OJMBOCNNLMI.solver.rightHandEffector.bone.position, this.character2.OJMBOCNNLMI.solver.rightHandEffector.bone.position, 0.5f);
			this.handShake.transform.position = position;
		}

		// Token: 0x04001D0E RID: 7438
		public InteractionSystem character1;

		// Token: 0x04001D0F RID: 7439
		public InteractionSystem character2;

		// Token: 0x04001D10 RID: 7440
		public InteractionObject handShake;
	}
}
