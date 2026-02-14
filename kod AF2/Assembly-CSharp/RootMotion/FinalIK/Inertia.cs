using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004C2 RID: 1218
	public class Inertia : OffsetModifier
	{
		// Token: 0x0601099C RID: 67996 RVA: 0x00762F00 File Offset: 0x00761100
		public void KHKICNAEDLK()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].HIMMPNOPLNO();
			}
		}

		// Token: 0x0601099D RID: 67997 RVA: 0x00762F38 File Offset: 0x00761138
		protected virtual void GEJALLDIDKK()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GCNGEFBKMNC(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x0601099E RID: 67998 RVA: 0x00762F88 File Offset: 0x00761188
		protected virtual void GFGEFHBDIJO()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PAKOHKKBKHD(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x0601099F RID: 67999 RVA: 0x00762FD8 File Offset: 0x007611D8
		public void NHMGCBCEOHJ()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].Reset();
			}
		}

		// Token: 0x060109A0 RID: 68000 RVA: 0x00763010 File Offset: 0x00761210
		public void ABDDFMCILGN()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].BOMPGKHDOJE();
			}
		}

		// Token: 0x060109A1 RID: 68001 RVA: 0x00763048 File Offset: 0x00761248
		public void GFBLCHLLAME()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].COIGADPCLOB();
			}
		}

		// Token: 0x060109A2 RID: 68002 RVA: 0x00763080 File Offset: 0x00761280
		protected virtual void HALPFPKCLAP()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].JLFBDOPFDDJ(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109A3 RID: 68003 RVA: 0x007630D0 File Offset: 0x007612D0
		public void GJMMBDAEBHL()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].NJJOPILNLJN();
			}
		}

		// Token: 0x060109A4 RID: 68004 RVA: 0x00763108 File Offset: 0x00761308
		public void LGNNJBODNEH()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].AODNAGCNHNG();
			}
		}

		// Token: 0x060109A5 RID: 68005 RVA: 0x00763140 File Offset: 0x00761340
		public void LDMINLGHNGE()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DHDKACLFOOI();
			}
		}

		// Token: 0x060109A6 RID: 68006 RVA: 0x00763178 File Offset: 0x00761378
		public void PEALGKCINKL()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].KAKCPAJHCPN();
			}
		}

		// Token: 0x060109A7 RID: 68007 RVA: 0x007631B0 File Offset: 0x007613B0
		protected virtual void NECDDLFLEMF()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].HCDJABMBDFF(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109A8 RID: 68008 RVA: 0x00763200 File Offset: 0x00761400
		protected virtual void KGGMOGBDHDN()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].NMMGHFDLNOE(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109A9 RID: 68009 RVA: 0x00763250 File Offset: 0x00761450
		protected virtual void LONPIDHHHPA()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].FJEEADNCKAG(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109AA RID: 68010 RVA: 0x007632A0 File Offset: 0x007614A0
		public void CBLLGNAFHKD()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MMOGADAOALK();
			}
		}

		// Token: 0x060109AB RID: 68011 RVA: 0x007632D8 File Offset: 0x007614D8
		public void KANNGFPABAM()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DDFFBNBIACP();
			}
		}

		// Token: 0x060109AC RID: 68012 RVA: 0x00763310 File Offset: 0x00761510
		protected virtual void HNKCDCDLNJE()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].FPLNDDMFFKG(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109AD RID: 68013 RVA: 0x00763360 File Offset: 0x00761560
		protected virtual void LOJCEKNCAOD()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].HFPPENPGGAI(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109AE RID: 68014 RVA: 0x007633B0 File Offset: 0x007615B0
		protected virtual void BCFDBGIOMBL()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PMKOAHMNBBG(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109AF RID: 68015 RVA: 0x00763400 File Offset: 0x00761600
		protected virtual void HHBDJBJEFCJ()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].KBMKHLDOIKP(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109B0 RID: 68016 RVA: 0x00763450 File Offset: 0x00761650
		public void OKMCFLKCOED()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].Reset();
			}
		}

		// Token: 0x060109B1 RID: 68017 RVA: 0x00763488 File Offset: 0x00761688
		protected virtual void FOKIBJAGEED()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].OIBIGDFPHGO(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109B2 RID: 68018 RVA: 0x007634D8 File Offset: 0x007616D8
		public void OFEEFMPAPKI()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GFALEDNPNOE();
			}
		}

		// Token: 0x060109B3 RID: 68019 RVA: 0x00763510 File Offset: 0x00761710
		protected virtual void MOBMBODBBPH()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].BEDAJLJFAFO(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109B4 RID: 68020 RVA: 0x00763560 File Offset: 0x00761760
		protected virtual void ELMHLFFIOGL()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].NMMGHFDLNOE(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109B5 RID: 68021 RVA: 0x007635B0 File Offset: 0x007617B0
		public void ICGGHJDLMMK()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].MPJJBFNIHPK();
			}
		}

		// Token: 0x060109B6 RID: 68022 RVA: 0x007635E8 File Offset: 0x007617E8
		protected virtual void BOBCDLEPMAJ()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].NMMGHFDLNOE(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109B7 RID: 68023 RVA: 0x00763638 File Offset: 0x00761838
		protected virtual void IHLANBMIJCH()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].KOLCEBEIHKP(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109B8 RID: 68024 RVA: 0x00763688 File Offset: 0x00761888
		public void ACIHPBELCBE()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].ABHMIBGKGGM();
			}
		}

		// Token: 0x060109B9 RID: 68025 RVA: 0x007636C0 File Offset: 0x007618C0
		public void CGMMLHKLOFC()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].FKOENKDEHPB();
			}
		}

		// Token: 0x060109BA RID: 68026 RVA: 0x007636F8 File Offset: 0x007618F8
		protected virtual void JOKIOHMEIEN()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].PBFKCKCHEAC(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109BB RID: 68027 RVA: 0x00763748 File Offset: 0x00761948
		public void APPIPIDCLDB()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].CIBPJDHPIDH();
			}
		}

		// Token: 0x060109BC RID: 68028 RVA: 0x00763780 File Offset: 0x00761980
		protected virtual void MHKIHJKOJCE()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].FJEEADNCKAG(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109BD RID: 68029 RVA: 0x007637D0 File Offset: 0x007619D0
		public void FJGLLDHENLI()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].HIMMPNOPLNO();
			}
		}

		// Token: 0x060109BE RID: 68030 RVA: 0x00763808 File Offset: 0x00761A08
		protected virtual void DDLKLBMNIDM()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PAKOHKKBKHD(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109C0 RID: 68032 RVA: 0x00763858 File Offset: 0x00761A58
		protected virtual void CAEGFKACKIC()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].PBFKCKCHEAC(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109C1 RID: 68033 RVA: 0x007638A8 File Offset: 0x00761AA8
		public void BLCGHDMKPFH()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].BOMPGKHDOJE();
			}
		}

		// Token: 0x060109C2 RID: 68034 RVA: 0x007638E0 File Offset: 0x00761AE0
		public void KMCJDLLBGHL()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].AIHEKMKAIGM();
			}
		}

		// Token: 0x060109C3 RID: 68035 RVA: 0x00763918 File Offset: 0x00761B18
		protected virtual void DKHACOFGDLP()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].JLFBDOPFDDJ(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109C4 RID: 68036 RVA: 0x00763968 File Offset: 0x00761B68
		public void MGAMGKNBELL()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].COABEBLDMNF();
			}
		}

		// Token: 0x060109C5 RID: 68037 RVA: 0x007639A0 File Offset: 0x00761BA0
		public void GOCMEAACAEM()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].NJJOPILNLJN();
			}
		}

		// Token: 0x060109C6 RID: 68038 RVA: 0x007639D8 File Offset: 0x00761BD8
		public void NHJBDMEOOMG()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].BOMPGKHDOJE();
			}
		}

		// Token: 0x060109C7 RID: 68039 RVA: 0x00763A10 File Offset: 0x00761C10
		public void DOPPKNDFCGJ()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].PFCKAGAAGEA();
			}
		}

		// Token: 0x060109C8 RID: 68040 RVA: 0x00763A48 File Offset: 0x00761C48
		protected virtual void OJACOBAPJPK()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PGIHAIPCJLL(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109C9 RID: 68041 RVA: 0x00763A98 File Offset: 0x00761C98
		public void HCIBNMOMGGN()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MFFJBEGHNJL();
			}
		}

		// Token: 0x060109CA RID: 68042 RVA: 0x00763AD0 File Offset: 0x00761CD0
		public void ODBEIKMPKNE()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].NMMHIFFIFAL();
			}
		}

		// Token: 0x060109CB RID: 68043 RVA: 0x00763B08 File Offset: 0x00761D08
		public void FHGGNFIHFHG()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DFJPGJJKLDF();
			}
		}

		// Token: 0x060109CC RID: 68044 RVA: 0x00763B40 File Offset: 0x00761D40
		public void ABMCOCLFKBO()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].MFFJBEGHNJL();
			}
		}

		// Token: 0x060109CD RID: 68045 RVA: 0x00763B78 File Offset: 0x00761D78
		protected virtual void MMEDEBFOHPB()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].IDMCOLDDNCF(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109CE RID: 68046 RVA: 0x00763BC8 File Offset: 0x00761DC8
		public void HPFGBKOELFA()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].ENJPJEMDHAF();
			}
		}

		// Token: 0x060109CF RID: 68047 RVA: 0x00763C00 File Offset: 0x00761E00
		public void EHMJLNKNPDD()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].MIFKCBJPDDI();
			}
		}

		// Token: 0x060109D0 RID: 68048 RVA: 0x00763C38 File Offset: 0x00761E38
		protected virtual void GCMHJCAOIMF()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GDBBAMFMKII(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109D1 RID: 68049 RVA: 0x00763C88 File Offset: 0x00761E88
		public void MONGGGMCIML()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].NBIOABCKJBN();
			}
		}

		// Token: 0x060109D2 RID: 68050 RVA: 0x00763CC0 File Offset: 0x00761EC0
		public void CMAALLLPDDH()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DHDKACLFOOI();
			}
		}

		// Token: 0x060109D3 RID: 68051 RVA: 0x00763CF8 File Offset: 0x00761EF8
		public void FFCMJIHHDAO()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].CPAHJGBADMP();
			}
		}

		// Token: 0x060109D4 RID: 68052 RVA: 0x00763D30 File Offset: 0x00761F30
		public void FKJMNCHGNII()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].Reset();
			}
		}

		// Token: 0x060109D5 RID: 68053 RVA: 0x00763D68 File Offset: 0x00761F68
		protected virtual void CEOPNJGPACK()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].FPLNDDMFFKG(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109D6 RID: 68054 RVA: 0x00763DB8 File Offset: 0x00761FB8
		protected virtual void PKCAKBPNDGP()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].MNAHGMDDHCA(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109D7 RID: 68055 RVA: 0x00763E08 File Offset: 0x00762008
		public void EEGBAIKEDLE()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].FKOENKDEHPB();
			}
		}

		// Token: 0x060109D8 RID: 68056 RVA: 0x00763E40 File Offset: 0x00762040
		protected virtual void HHCGGNBDPMG()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].HAIMGCDKPDC(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109D9 RID: 68057 RVA: 0x00763E90 File Offset: 0x00762090
		protected virtual void GEAKAHAAGIC()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].KMLNBHIIGKH(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109DA RID: 68058 RVA: 0x00763EE0 File Offset: 0x007620E0
		protected virtual void FNBKENOCJKD()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].KJJBBLDJHPD(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109DB RID: 68059 RVA: 0x00763F30 File Offset: 0x00762130
		protected virtual void KLLBLFKGMLD()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].KEBDEJIAODF(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109DC RID: 68060 RVA: 0x00763F80 File Offset: 0x00762180
		public void PABNHBFJPPB()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].MIFKCBJPDDI();
			}
		}

		// Token: 0x060109DD RID: 68061 RVA: 0x00763FB8 File Offset: 0x007621B8
		protected override void HEHOBGDMLOK()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].FANPFKHEDPA(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109DE RID: 68062 RVA: 0x00764008 File Offset: 0x00762208
		public void HFLBBHKODAJ()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].LAAKOMDMBKK();
			}
		}

		// Token: 0x060109DF RID: 68063 RVA: 0x00764040 File Offset: 0x00762240
		protected virtual void EBFEGNHDGIN()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].OIBIGDFPHGO(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109E0 RID: 68064 RVA: 0x00764090 File Offset: 0x00762290
		protected virtual void MOEPIPIOMHL()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].HFPPENPGGAI(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109E1 RID: 68065 RVA: 0x007640E0 File Offset: 0x007622E0
		public void APODEFGNMOP()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].NJJOPILNLJN();
			}
		}

		// Token: 0x060109E2 RID: 68066 RVA: 0x00764118 File Offset: 0x00762318
		public void IGIMODEJKPM()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].EGADMJMBCCK();
			}
		}

		// Token: 0x060109E3 RID: 68067 RVA: 0x00764150 File Offset: 0x00762350
		protected virtual void JAFHAAOOBII()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PBFKCKCHEAC(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109E4 RID: 68068 RVA: 0x007641A0 File Offset: 0x007623A0
		protected virtual void EPKMABAIMFL()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].HJCLNJLADKL(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109E5 RID: 68069 RVA: 0x007641F0 File Offset: 0x007623F0
		public void EJDDNHCEAEO()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].AOEMHBKCBHA();
			}
		}

		// Token: 0x060109E6 RID: 68070 RVA: 0x00764228 File Offset: 0x00762428
		protected virtual void MEPOMFMNCDE()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].PBFKCKCHEAC(this.ik.solver, this.weight, base.ENLHBNBNPJN);
			}
			base.HPEMKHLDHFA(this.limits);
		}

		// Token: 0x060109E7 RID: 68071 RVA: 0x00764278 File Offset: 0x00762478
		public void ResetBodies()
		{
			this.EDCFDDLFAHG = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Reset();
			}
		}

		// Token: 0x04002299 RID: 8857
		[Tooltip("The array of Bodies")]
		public Inertia.Body[] bodies;

		// Token: 0x0400229A RID: 8858
		[Tooltip("The array of OffsetLimits")]
		public OffsetModifier.OffsetLimits[] limits;

		// Token: 0x020004C3 RID: 1219
		[Serializable]
		public class Body
		{
			// Token: 0x060109E8 RID: 68072 RVA: 0x007642B0 File Offset: 0x007624B0
			public void PGIHAIPCJLL(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NHPMLPGKKGD();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 406f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109E9 RID: 68073 RVA: 0x0076440C File Offset: 0x0076260C
			public void FJEEADNCKAG(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.APCPELACLGB();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1184f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109EA RID: 68074 RVA: 0x00764566 File Offset: 0x00762766
			public void BFDBCACMHNL()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109EB RID: 68075 RVA: 0x007645A4 File Offset: 0x007627A4
			public void KEBDEJIAODF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.BOMPGKHDOJE();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 925f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109EC RID: 68076 RVA: 0x00764700 File Offset: 0x00762900
			public void BEDAJLJFAFO(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.JFNAAHHHKIO();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1468f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109ED RID: 68077 RVA: 0x0076485C File Offset: 0x00762A5C
			public void PAKOHKKBKHD(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.HIMMPNOPLNO();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1395f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109EE RID: 68078 RVA: 0x007649B8 File Offset: 0x00762BB8
			public void LBGKAMLLACN(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.DHIOMPGHKJP();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1873f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109EF RID: 68079 RVA: 0x00764566 File Offset: 0x00762766
			public void EGODPDJLJCC()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109F0 RID: 68080 RVA: 0x00764B14 File Offset: 0x00762D14
			public void MEFOGCFJBNE(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.EPLEHFCNKDJ();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1350f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109F1 RID: 68081 RVA: 0x00764566 File Offset: 0x00762766
			public void MIFKCBJPDDI()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109F2 RID: 68082 RVA: 0x00764566 File Offset: 0x00762766
			public void AOEMHBKCBHA()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109F3 RID: 68083 RVA: 0x00764C70 File Offset: 0x00762E70
			public void NFPFDOEENLA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NBIOABCKJBN();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1649f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109F4 RID: 68084 RVA: 0x00764DCC File Offset: 0x00762FCC
			public void HFPPENPGGAI(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.AIHEKMKAIGM();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 425f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109F5 RID: 68085 RVA: 0x00764566 File Offset: 0x00762766
			public void JIPMONJNBOK()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109F6 RID: 68086 RVA: 0x00764F28 File Offset: 0x00763128
			public void MIFLHGMPLJD(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.GDICLOPBJKK();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 48f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109F7 RID: 68087 RVA: 0x00764566 File Offset: 0x00762766
			public void HIMMPNOPLNO()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109F8 RID: 68088 RVA: 0x00764566 File Offset: 0x00762766
			public void NMMHIFFIFAL()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109F9 RID: 68089 RVA: 0x00765084 File Offset: 0x00763284
			public void BBFCMCAFOMH(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.FKOENKDEHPB();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 321f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109FB RID: 68091 RVA: 0x00764566 File Offset: 0x00762766
			public void CPAHJGBADMP()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109FC RID: 68092 RVA: 0x00764566 File Offset: 0x00762766
			public void MMOGADAOALK()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060109FD RID: 68093 RVA: 0x00765204 File Offset: 0x00763404
			public void DKOIOBMMAGN(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.DHDKACLFOOI();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1092f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109FE RID: 68094 RVA: 0x00765360 File Offset: 0x00763560
			public void HCDJABMBDFF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.GDICLOPBJKK();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 827f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x060109FF RID: 68095 RVA: 0x007654BC File Offset: 0x007636BC
			public void DIAIKCBANBK(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NBIOABCKJBN();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 788f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A00 RID: 68096 RVA: 0x00764566 File Offset: 0x00762766
			public void GMADDBOCLNF()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A01 RID: 68097 RVA: 0x00765618 File Offset: 0x00763818
			public void OIBIGDFPHGO(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NHPMLPGKKGD();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1739f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A02 RID: 68098 RVA: 0x00764566 File Offset: 0x00762766
			public void AIHEKMKAIGM()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A03 RID: 68099 RVA: 0x00765774 File Offset: 0x00763974
			public void PBFKCKCHEAC(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.EPLEHFCNKDJ();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 351f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A04 RID: 68100 RVA: 0x007658D0 File Offset: 0x00763AD0
			public void HJCLNJLADKL(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.PFCKAGAAGEA();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1140f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A05 RID: 68101 RVA: 0x00765A2C File Offset: 0x00763C2C
			public void OHKHOAKCENL(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.MMOGADAOALK();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 697f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A06 RID: 68102 RVA: 0x00764566 File Offset: 0x00762766
			public void PFCKAGAAGEA()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A07 RID: 68103 RVA: 0x00764566 File Offset: 0x00762766
			public void COABEBLDMNF()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A08 RID: 68104 RVA: 0x00765B88 File Offset: 0x00763D88
			public void IGEICBNMPAD(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.FKOENKDEHPB();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 663f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A09 RID: 68105 RVA: 0x00765CE4 File Offset: 0x00763EE4
			public void DEGCCLNOEKJ(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.GLGAOEAJKOL();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1053f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A0A RID: 68106 RVA: 0x00764566 File Offset: 0x00762766
			public void LAAKOMDMBKK()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A0B RID: 68107 RVA: 0x00765E40 File Offset: 0x00764040
			public void BJOICAKCPLI(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.DHDKACLFOOI();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1088f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A0C RID: 68108 RVA: 0x00764566 File Offset: 0x00762766
			public void EPLEHFCNKDJ()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A0D RID: 68109 RVA: 0x00765F9C File Offset: 0x0076419C
			public void JLFBDOPFDDJ(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.AIHEKMKAIGM();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1129f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A0E RID: 68110 RVA: 0x00764566 File Offset: 0x00762766
			public void MPJJBFNIHPK()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A0F RID: 68111 RVA: 0x00764566 File Offset: 0x00762766
			public void CIBPJDHPIDH()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A10 RID: 68112 RVA: 0x007660F8 File Offset: 0x007642F8
			public void GDBBAMFMKII(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NBIOABCKJBN();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 229f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A11 RID: 68113 RVA: 0x00764566 File Offset: 0x00762766
			public void LPMNAMDNDDM()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A12 RID: 68114 RVA: 0x00766254 File Offset: 0x00764454
			public void EDANNBFJHIK(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NBILAGJFBGJ();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1825f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A13 RID: 68115 RVA: 0x00764566 File Offset: 0x00762766
			public void NBIOABCKJBN()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A14 RID: 68116 RVA: 0x00764566 File Offset: 0x00762766
			public void ENJPJEMDHAF()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A15 RID: 68117 RVA: 0x00764566 File Offset: 0x00762766
			public void NHPMLPGKKGD()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A16 RID: 68118 RVA: 0x00764566 File Offset: 0x00762766
			public void ABHMIBGKGGM()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A17 RID: 68119 RVA: 0x007663B0 File Offset: 0x007645B0
			public void PMKOAHMNBBG(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.AODNAGCNHNG();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1334f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A18 RID: 68120 RVA: 0x0076650C File Offset: 0x0076470C
			public void IOGAKGCADBL(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.MMOGADAOALK();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 691f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A19 RID: 68121 RVA: 0x00766668 File Offset: 0x00764868
			public void AIAMIFEPALP(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.PFCKAGAAGEA();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 927f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A1A RID: 68122 RVA: 0x007667C4 File Offset: 0x007649C4
			public void NMMGHFDLNOE(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.AIHEKMKAIGM();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1331f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A1B RID: 68123 RVA: 0x00764566 File Offset: 0x00762766
			public void NLOBKGBLNPO()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A1C RID: 68124 RVA: 0x00766920 File Offset: 0x00764B20
			public void KBMKHLDOIKP(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.ENJPJEMDHAF();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1721f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A1D RID: 68125 RVA: 0x00766A7C File Offset: 0x00764C7C
			public void JIFOELPAEHG(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.JIPMONJNBOK();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 303f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A1E RID: 68126 RVA: 0x00766BD8 File Offset: 0x00764DD8
			public void KJJEEMEHGBF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.AOEMHBKCBHA();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 918f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A1F RID: 68127 RVA: 0x00764566 File Offset: 0x00762766
			public void AODNAGCNHNG()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A20 RID: 68128 RVA: 0x00764566 File Offset: 0x00762766
			public void EGADMJMBCCK()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A21 RID: 68129 RVA: 0x00766D34 File Offset: 0x00764F34
			public void GCNGEFBKMNC(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.CIBPJDHPIDH();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1916f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A22 RID: 68130 RVA: 0x00764566 File Offset: 0x00762766
			public void AOGCKHNAOCI()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A23 RID: 68131 RVA: 0x00764566 File Offset: 0x00762766
			public void FKOENKDEHPB()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A24 RID: 68132 RVA: 0x00764566 File Offset: 0x00762766
			public void GFALEDNPNOE()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A25 RID: 68133 RVA: 0x00766E90 File Offset: 0x00765090
			public void JIKGIJEHGAP(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NBIOABCKJBN();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 194f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A26 RID: 68134 RVA: 0x00764566 File Offset: 0x00762766
			public void APCPELACLGB()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A27 RID: 68135 RVA: 0x00764566 File Offset: 0x00762766
			public void COIGADPCLOB()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A28 RID: 68136 RVA: 0x00766FEC File Offset: 0x007651EC
			public void CJHBCHBOLBI(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.CPAHJGBADMP();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 291f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A29 RID: 68137 RVA: 0x00767148 File Offset: 0x00765348
			public void LACNPNKHCAA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.PLMHLKJMKHP();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 81f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A2A RID: 68138 RVA: 0x007672A4 File Offset: 0x007654A4
			public void HNMODJBBKBI(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.PFCKAGAAGEA();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1613f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A2B RID: 68139 RVA: 0x00764566 File Offset: 0x00762766
			public void GLGAOEAJKOL()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A2C RID: 68140 RVA: 0x00767400 File Offset: 0x00765600
			public void KJJBBLDJHPD(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NLOBKGBLNPO();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 590f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A2D RID: 68141 RVA: 0x0076755C File Offset: 0x0076575C
			public void KOLCEBEIHKP(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.COABEBLDMNF();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 525f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A2E RID: 68142 RVA: 0x007676B8 File Offset: 0x007658B8
			public void MNAHGMDDHCA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NBILAGJFBGJ();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1669f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A2F RID: 68143 RVA: 0x00767814 File Offset: 0x00765A14
			public void FPLNDDMFFKG(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.DHDKACLFOOI();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 797f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A30 RID: 68144 RVA: 0x00764566 File Offset: 0x00762766
			public void JDGCKJJMDLF()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A31 RID: 68145 RVA: 0x00767970 File Offset: 0x00765B70
			public void LDDIGEMBDNF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.FNOPDEADJNE();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 5f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A32 RID: 68146 RVA: 0x00767ACC File Offset: 0x00765CCC
			public void EGAEDOHFAJE(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.NHPMLPGKKGD();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1829f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A33 RID: 68147 RVA: 0x00764566 File Offset: 0x00762766
			public void Reset()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A34 RID: 68148 RVA: 0x00764566 File Offset: 0x00762766
			public void DDFFBNBIACP()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A35 RID: 68149 RVA: 0x00764566 File Offset: 0x00762766
			public void KMPIPLFPFEI()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A36 RID: 68150 RVA: 0x00767C28 File Offset: 0x00765E28
			public void PNBGJBMJLFM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.AODNAGCNHNG();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1716f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A37 RID: 68151 RVA: 0x00764566 File Offset: 0x00762766
			public void GDICLOPBJKK()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A38 RID: 68152 RVA: 0x00764566 File Offset: 0x00762766
			public void MFFJBEGHNJL()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A39 RID: 68153 RVA: 0x00764566 File Offset: 0x00762766
			public void DHDKACLFOOI()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A3A RID: 68154 RVA: 0x00764566 File Offset: 0x00762766
			public void NJJOPILNLJN()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A3B RID: 68155 RVA: 0x00764566 File Offset: 0x00762766
			public void PLMHLKJMKHP()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A3C RID: 68156 RVA: 0x00767D84 File Offset: 0x00765F84
			public void KMLNBHIIGKH(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.BFDBCACMHNL();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1061f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A3D RID: 68157 RVA: 0x00764566 File Offset: 0x00762766
			public void DFJPGJJKLDF()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A3E RID: 68158 RVA: 0x00764566 File Offset: 0x00762766
			public void NBILAGJFBGJ()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A3F RID: 68159 RVA: 0x00764566 File Offset: 0x00762766
			public void JFNAAHHHKIO()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A40 RID: 68160 RVA: 0x00764566 File Offset: 0x00762766
			public void FNOPDEADJNE()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A41 RID: 68161 RVA: 0x00764566 File Offset: 0x00762766
			public void KAKCPAJHCPN()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A42 RID: 68162 RVA: 0x00767EE0 File Offset: 0x007660E0
			public void IDMCOLDDNCF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.APCPELACLGB();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1323f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A43 RID: 68163 RVA: 0x0076803C File Offset: 0x0076623C
			public void FANPFKHEDPA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.Reset();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 0.01f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A44 RID: 68164 RVA: 0x00764566 File Offset: 0x00762766
			public void MLOPPPBPHNJ()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A45 RID: 68165 RVA: 0x00764566 File Offset: 0x00762766
			public void BOMPGKHDOJE()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A46 RID: 68166 RVA: 0x00764566 File Offset: 0x00762766
			public void DHIOMPGHKJP()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x06010A47 RID: 68167 RVA: 0x00768198 File Offset: 0x00766398
			public void HAIMGCDKPDC(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.DHIOMPGHKJP();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 395f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				Inertia.Body.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Inertia.Body.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x06010A48 RID: 68168 RVA: 0x007682F4 File Offset: 0x007664F4
			public void OPDCJCFMIPE(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD, float ENLHBNBNPJN)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.ENJPJEMDHAF();
					this.firstUpdate = true;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / ENLHBNBNPJN * 1460f, ENLHBNBNPJN * this.acceleration);
				this.lazyPoint += this.direction * ENLHBNBNPJN * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * ENLHBNBNPJN;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * NKHBAJKMAGD;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x0400229B RID: 8859
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			// Token: 0x0400229C RID: 8860
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public Inertia.Body.EffectorLink[] effectorLinks;

			// Token: 0x0400229D RID: 8861
			[Tooltip("The speed to follow the Transform")]
			public float speed = 10f;

			// Token: 0x0400229E RID: 8862
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration = 3f;

			// Token: 0x0400229F RID: 8863
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity;

			// Token: 0x040022A0 RID: 8864
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			// Token: 0x040022A1 RID: 8865
			private Vector3 delta;

			// Token: 0x040022A2 RID: 8866
			private Vector3 lazyPoint;

			// Token: 0x040022A3 RID: 8867
			private Vector3 direction;

			// Token: 0x040022A4 RID: 8868
			private Vector3 lastPosition;

			// Token: 0x040022A5 RID: 8869
			private bool firstUpdate = true;

			// Token: 0x020004C4 RID: 1220
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040022A6 RID: 8870
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040022A7 RID: 8871
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
