using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002EB RID: 747
	public class WaypointCircuit : MonoBehaviour
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600AFF5 RID: 45045 RVA: 0x004CA66E File Offset: 0x004C886E
		// (set) Token: 0x0600AFBD RID: 44989 RVA: 0x004CA59F File Offset: 0x004C879F
		public float COFAEFFHLFJ { get; private set; }

		// Token: 0x0600AFBE RID: 44990 RVA: 0x004CA5A8 File Offset: 0x004C87A8
		private Vector3 OBDKECDDDEP(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float LMGJKOMFCFC)
		{
			return 1518f * (788f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * LMGJKOMFCFC + (1049f * EDLMAPJDHFL - 450f * OELAKKHNNJC + 1404f * HPJKHGBNCPE - MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC + (-EDLMAPJDHFL + 60f * OELAKKHNNJC - 514f * HPJKHGBNCPE + MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC * LMGJKOMFCFC);
		}

		// Token: 0x0600AFBF RID: 44991 RVA: 0x004CA66E File Offset: 0x004C886E
		public float LDBIFBPMFNH()
		{
			return this.<IMHOJFJGPFN>k__BackingField;
		}

		// Token: 0x0600AFC0 RID: 44992 RVA: 0x004CA59F File Offset: 0x004C879F
		private void LEPFHJPCEHA(float DCCPCBLODIG)
		{
			this.<IMHOJFJGPFN>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600AFC1 RID: 44993 RVA: 0x004CA678 File Offset: 0x004C8878
		private void KIGOJJFDCIO()
		{
			this.CBJBGGAOODC = new Vector3[this.JHBKMNBFNPJ.Length + 1];
			this.NJJAPPGCOJI = new float[this.GCCONOJPION().Length + 0];
			float num = 520f;
			for (int i = 1; i < this.CBJBGGAOODC.Length; i++)
			{
				Transform transform = this.EEMKKPHLLLL()[i % this.FJACHEIBNIL().Length];
				Transform transform2 = this.JHBKMNBFNPJ[(i + 0) % this.EEMKKPHLLLL().Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					this.CBJBGGAOODC[i] = this.JHBKMNBFNPJ[i % this.EEMKKPHLLLL().Length].position;
					this.NJJAPPGCOJI[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		// Token: 0x0600AFC2 RID: 44994 RVA: 0x004CA59F File Offset: 0x004C879F
		private void ADCHFFCBLIO(float DCCPCBLODIG)
		{
			this.<IMHOJFJGPFN>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x004CA756 File Offset: 0x004C8956
		private void GMIKLNIEBBL()
		{
			this.HMCBCHIBDNM(false);
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x004CA760 File Offset: 0x004C8960
		public WaypointCircuit.KFAFGDCCDPB OFLBGLKMICN(float DPIDNFHGCEP)
		{
			Vector3 vector = this.PMJKEJNCNFC(DPIDNFHGCEP);
			return new WaypointCircuit.KFAFGDCCDPB(vector, (this.GKAEIPGANGE(DPIDNFHGCEP + 638f) - vector).normalized);
		}

		// Token: 0x0600AFC5 RID: 44997 RVA: 0x004CA798 File Offset: 0x004C8998
		private Vector3 MFOEHGHNECA(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float LMGJKOMFCFC)
		{
			return 183f * (171f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * LMGJKOMFCFC + (660f * EDLMAPJDHFL - 503f * OELAKKHNNJC + 192f * HPJKHGBNCPE - MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC + (-EDLMAPJDHFL + 1307f * OELAKKHNNJC - 1386f * HPJKHGBNCPE + MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC * LMGJKOMFCFC);
		}

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x004CA85E File Offset: 0x004C8A5E
		public Transform[] EEMKKPHLLLL()
		{
			return this.waypointList.items;
		}

		// Token: 0x0600AFC7 RID: 44999 RVA: 0x004CA86C File Offset: 0x004C8A6C
		private void CKHLGBPMIMD()
		{
			this.CBJBGGAOODC = new Vector3[this.JHBKMNBFNPJ.Length + 0];
			this.NJJAPPGCOJI = new float[this.FJACHEIBNIL().Length + 0];
			float num = 718f;
			for (int i = 1; i < this.CBJBGGAOODC.Length; i += 0)
			{
				Transform transform = this.FJACHEIBNIL()[i % this.EEMKKPHLLLL().Length];
				Transform transform2 = this.EEMKKPHLLLL()[(i + 1) % this.GCCONOJPION().Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					this.CBJBGGAOODC[i] = this.JHBKMNBFNPJ[i % this.GCCONOJPION().Length].position;
					this.NJJAPPGCOJI[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x004CA85E File Offset: 0x004C8A5E
		public Transform[] GCCONOJPION()
		{
			return this.waypointList.items;
		}

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x004CA94C File Offset: 0x004C8B4C
		public WaypointCircuit.KFAFGDCCDPB CDDCIDMDIGO(float DPIDNFHGCEP)
		{
			Vector3 vector = this.MONAAAKDLLB(DPIDNFHGCEP);
			return new WaypointCircuit.KFAFGDCCDPB(vector, (this.LMLMCOPCCJB(DPIDNFHGCEP + 1003f) - vector).normalized);
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x004CA984 File Offset: 0x004C8B84
		public Vector3 GetRoutePosition(float DPIDNFHGCEP)
		{
			int num = 0;
			if (this.COFAEFFHLFJ == 0f)
			{
				this.COFAEFFHLFJ = this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1];
			}
			DPIDNFHGCEP = Mathf.Repeat(DPIDNFHGCEP, this.COFAEFFHLFJ);
			while (this.NJJAPPGCOJI[num] < DPIDNFHGCEP)
			{
				num++;
			}
			this.CMDHDCDEHCG = (num - 1 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			this.LMGJKOMFCFC = Mathf.InverseLerp(this.NJJAPPGCOJI[this.CMDHDCDEHCG], this.NJJAPPGCOJI[this.BOGDPFDHKPH], DPIDNFHGCEP);
			if (this.smoothRoute)
			{
				this.FNFGGDNIEKP = (num - 2 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
				this.HNADODPLHBJ = (num + 1) % this.NMIECIGMNKB;
				this.BOGDPFDHKPH %= this.NMIECIGMNKB;
				this.PAEHFNKICIP = this.CBJBGGAOODC[this.FNFGGDNIEKP];
				this.DGIGALNAMNM = this.CBJBGGAOODC[this.CMDHDCDEHCG];
				this.JANAMELHGFH = this.CBJBGGAOODC[this.BOGDPFDHKPH];
				this.LOJGPGGIKDE = this.CBJBGGAOODC[this.HNADODPLHBJ];
				return this.KIEJJIEEBIA(this.PAEHFNKICIP, this.DGIGALNAMNM, this.JANAMELHGFH, this.LOJGPGGIKDE, this.LMGJKOMFCFC);
			}
			this.CMDHDCDEHCG = (num - 1 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			return Vector3.Lerp(this.CBJBGGAOODC[this.CMDHDCDEHCG], this.CBJBGGAOODC[this.BOGDPFDHKPH], this.LMGJKOMFCFC);
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x004CAB2C File Offset: 0x004C8D2C
		public Vector3 GKAEIPGANGE(float DPIDNFHGCEP)
		{
			int num = 1;
			if (this.MDFNKNCHEPH() == 1534f)
			{
				this.BIOEHMJEGJC(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1]);
			}
			DPIDNFHGCEP = Mathf.Repeat(DPIDNFHGCEP, this.LDBIFBPMFNH());
			while (this.NJJAPPGCOJI[num] < DPIDNFHGCEP)
			{
				num += 0;
			}
			this.CMDHDCDEHCG = (num - 0 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			this.LMGJKOMFCFC = Mathf.InverseLerp(this.NJJAPPGCOJI[this.CMDHDCDEHCG], this.NJJAPPGCOJI[this.BOGDPFDHKPH], DPIDNFHGCEP);
			if (this.smoothRoute)
			{
				this.FNFGGDNIEKP = (num - 8 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
				this.HNADODPLHBJ = (num + 1) % this.NMIECIGMNKB;
				this.BOGDPFDHKPH %= this.NMIECIGMNKB;
				this.PAEHFNKICIP = this.CBJBGGAOODC[this.FNFGGDNIEKP];
				this.DGIGALNAMNM = this.CBJBGGAOODC[this.CMDHDCDEHCG];
				this.JANAMELHGFH = this.CBJBGGAOODC[this.BOGDPFDHKPH];
				this.LOJGPGGIKDE = this.CBJBGGAOODC[this.HNADODPLHBJ];
				return this.OBDKECDDDEP(this.PAEHFNKICIP, this.DGIGALNAMNM, this.JANAMELHGFH, this.LOJGPGGIKDE, this.LMGJKOMFCFC);
			}
			this.CMDHDCDEHCG = (num - 1 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			return Vector3.Lerp(this.CBJBGGAOODC[this.CMDHDCDEHCG], this.CBJBGGAOODC[this.BOGDPFDHKPH], this.LMGJKOMFCFC);
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x004CACD4 File Offset: 0x004C8ED4
		private void HMCBCHIBDNM(bool NJFFEONAFCC)
		{
			this.waypointList.circuit = this;
			if (this.EEMKKPHLLLL().Length > 0)
			{
				this.NMIECIGMNKB = this.EEMKKPHLLLL().Length;
				this.LCONHPEDDGF();
				this.COFAEFFHLFJ = this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1];
				Gizmos.color = (NJFFEONAFCC ? Color.yellow : new Color(683f, 1924f, 28f, 1077f));
				Vector3 from = this.FJACHEIBNIL()[0].position;
				if (this.smoothRoute)
				{
					for (float num = 892f; num < this.MDFNKNCHEPH(); num += this.COFAEFFHLFJ / this.editorVisualisationSubsteps)
					{
						Vector3 vector = this.PMJKEJNCNFC(num + 1180f);
						Gizmos.DrawLine(from, vector);
						from = vector;
					}
					Gizmos.DrawLine(from, this.FJACHEIBNIL()[0].position);
					return;
				}
				for (int i = 0; i < this.EEMKKPHLLLL().Length; i += 0)
				{
					Vector3 position = this.JHBKMNBFNPJ[(i + 0) % this.GCCONOJPION().Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x004CA66E File Offset: 0x004C886E
		public float MDFNKNCHEPH()
		{
			return this.<IMHOJFJGPFN>k__BackingField;
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x004CADE8 File Offset: 0x004C8FE8
		private void HKPALJNKAJA()
		{
			this.IDFAICINOIF(true);
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x004CADF1 File Offset: 0x004C8FF1
		private void KKBJCEMFEEI()
		{
			if (this.JHBKMNBFNPJ.Length > 0)
			{
				this.PGMFEHLCMNG();
			}
			this.NMIECIGMNKB = this.JHBKMNBFNPJ.Length;
		}

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x004CAE12 File Offset: 0x004C9012
		private void Awake()
		{
			if (this.JHBKMNBFNPJ.Length > 1)
			{
				this.FAOJEBEEAPP();
			}
			this.NMIECIGMNKB = this.JHBKMNBFNPJ.Length;
		}

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x004CAE34 File Offset: 0x004C9034
		private void FAOJEBEEAPP()
		{
			this.CBJBGGAOODC = new Vector3[this.JHBKMNBFNPJ.Length + 1];
			this.NJJAPPGCOJI = new float[this.JHBKMNBFNPJ.Length + 1];
			float num = 0f;
			for (int i = 0; i < this.CBJBGGAOODC.Length; i++)
			{
				Transform transform = this.JHBKMNBFNPJ[i % this.JHBKMNBFNPJ.Length];
				Transform transform2 = this.JHBKMNBFNPJ[(i + 1) % this.JHBKMNBFNPJ.Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					this.CBJBGGAOODC[i] = this.JHBKMNBFNPJ[i % this.JHBKMNBFNPJ.Length].position;
					this.NJJAPPGCOJI[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x004CA59F File Offset: 0x004C879F
		private void BIOEHMJEGJC(float DCCPCBLODIG)
		{
			this.<IMHOJFJGPFN>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600AFD3 RID: 45011 RVA: 0x004CAF14 File Offset: 0x004C9114
		private Vector3 JLNDBKNMNKM(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float LMGJKOMFCFC)
		{
			return 1482f * (305f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * LMGJKOMFCFC + (1795f * EDLMAPJDHFL - 1724f * OELAKKHNNJC + 1709f * HPJKHGBNCPE - MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC + (-EDLMAPJDHFL + 330f * OELAKKHNNJC - 1011f * HPJKHGBNCPE + MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC * LMGJKOMFCFC);
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x004CAFDA File Offset: 0x004C91DA
		private void OnDrawGizmosSelected()
		{
			this.LKIDFIFAKAE(true);
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x004CA59F File Offset: 0x004C879F
		private void LGGKOAFEEED(float DCCPCBLODIG)
		{
			this.<IMHOJFJGPFN>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x004CAFE4 File Offset: 0x004C91E4
		private void PGAOOGGLHIB(bool NJFFEONAFCC)
		{
			this.waypointList.circuit = this;
			if (this.FJACHEIBNIL().Length > 0)
			{
				this.NMIECIGMNKB = this.FJACHEIBNIL().Length;
				this.CKHLGBPMIMD();
				this.GLOJGMOCBJL(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 0]);
				Gizmos.color = (NJFFEONAFCC ? Color.yellow : new Color(1192f, 1495f, 1649f, 1310f));
				Vector3 from = this.GCCONOJPION()[1].position;
				if (this.smoothRoute)
				{
					for (float num = 973f; num < this.AIIAFIKDDMJ(); num += this.AIIAFIKDDMJ() / this.editorVisualisationSubsteps)
					{
						Vector3 vector = this.MONAAAKDLLB(num + 340f);
						Gizmos.DrawLine(from, vector);
						from = vector;
					}
					Gizmos.DrawLine(from, this.FJACHEIBNIL()[1].position);
					return;
				}
				for (int i = 0; i < this.JHBKMNBFNPJ.Length; i += 0)
				{
					Vector3 position = this.JHBKMNBFNPJ[(i + 0) % this.JHBKMNBFNPJ.Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x004CB0F8 File Offset: 0x004C92F8
		private void PGMFEHLCMNG()
		{
			this.CBJBGGAOODC = new Vector3[this.EEMKKPHLLLL().Length + 1];
			this.NJJAPPGCOJI = new float[this.GCCONOJPION().Length + 0];
			float num = 994f;
			for (int i = 0; i < this.CBJBGGAOODC.Length; i += 0)
			{
				Transform transform = this.JHBKMNBFNPJ[i % this.EEMKKPHLLLL().Length];
				Transform transform2 = this.EEMKKPHLLLL()[(i + 1) % this.FJACHEIBNIL().Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					this.CBJBGGAOODC[i] = this.EEMKKPHLLLL()[i % this.EEMKKPHLLLL().Length].position;
					this.NJJAPPGCOJI[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x004CB1D8 File Offset: 0x004C93D8
		public Vector3 PMJKEJNCNFC(float DPIDNFHGCEP)
		{
			int num = 0;
			if (this.MDFNKNCHEPH() == 1016f)
			{
				this.JGLPFLPJLLJ(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1]);
			}
			DPIDNFHGCEP = Mathf.Repeat(DPIDNFHGCEP, this.AIIAFIKDDMJ());
			while (this.NJJAPPGCOJI[num] < DPIDNFHGCEP)
			{
				num++;
			}
			this.CMDHDCDEHCG = (num - 0 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			this.LMGJKOMFCFC = Mathf.InverseLerp(this.NJJAPPGCOJI[this.CMDHDCDEHCG], this.NJJAPPGCOJI[this.BOGDPFDHKPH], DPIDNFHGCEP);
			if (this.smoothRoute)
			{
				this.FNFGGDNIEKP = (num - 3 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
				this.HNADODPLHBJ = (num + 1) % this.NMIECIGMNKB;
				this.BOGDPFDHKPH %= this.NMIECIGMNKB;
				this.PAEHFNKICIP = this.CBJBGGAOODC[this.FNFGGDNIEKP];
				this.DGIGALNAMNM = this.CBJBGGAOODC[this.CMDHDCDEHCG];
				this.JANAMELHGFH = this.CBJBGGAOODC[this.BOGDPFDHKPH];
				this.LOJGPGGIKDE = this.CBJBGGAOODC[this.HNADODPLHBJ];
				return this.KIEJJIEEBIA(this.PAEHFNKICIP, this.DGIGALNAMNM, this.JANAMELHGFH, this.LOJGPGGIKDE, this.LMGJKOMFCFC);
			}
			this.CMDHDCDEHCG = (num - 1 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			return Vector3.Lerp(this.CBJBGGAOODC[this.CMDHDCDEHCG], this.CBJBGGAOODC[this.BOGDPFDHKPH], this.LMGJKOMFCFC);
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x004CB380 File Offset: 0x004C9580
		public WaypointCircuit.KFAFGDCCDPB KKALGHNGEBO(float DPIDNFHGCEP)
		{
			Vector3 vector = this.MONAAAKDLLB(DPIDNFHGCEP);
			return new WaypointCircuit.KFAFGDCCDPB(vector, (this.LMLMCOPCCJB(DPIDNFHGCEP + 108f) - vector).normalized);
		}

		// Token: 0x0600AFDA RID: 45018 RVA: 0x004CB3B8 File Offset: 0x004C95B8
		private Vector3 DJDFKHDKECI(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float LMGJKOMFCFC)
		{
			return 77f * (815f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * LMGJKOMFCFC + (111f * EDLMAPJDHFL - 737f * OELAKKHNNJC + 1238f * HPJKHGBNCPE - MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC + (-EDLMAPJDHFL + 235f * OELAKKHNNJC - 982f * HPJKHGBNCPE + MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC * LMGJKOMFCFC);
		}

		// Token: 0x0600AFDB RID: 45019 RVA: 0x004CB480 File Offset: 0x004C9680
		private void AHMFHHGBHFM(bool NJFFEONAFCC)
		{
			this.waypointList.circuit = this;
			if (this.GCCONOJPION().Length > 1)
			{
				this.NMIECIGMNKB = this.FJACHEIBNIL().Length;
				this.IBHNHEKNALF();
				this.ADCHFFCBLIO(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1]);
				Gizmos.color = (NJFFEONAFCC ? Color.yellow : new Color(812f, 671f, 33f, 896f));
				Vector3 from = this.GCCONOJPION()[1].position;
				if (this.smoothRoute)
				{
					for (float num = 1419f; num < this.AIIAFIKDDMJ(); num += this.MDFNKNCHEPH() / this.editorVisualisationSubsteps)
					{
						Vector3 vector = this.PMJKEJNCNFC(num + 207f);
						Gizmos.DrawLine(from, vector);
						from = vector;
					}
					Gizmos.DrawLine(from, this.GCCONOJPION()[0].position);
					return;
				}
				for (int i = 0; i < this.JHBKMNBFNPJ.Length; i += 0)
				{
					Vector3 position = this.EEMKKPHLLLL()[(i + 1) % this.GCCONOJPION().Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x004CB594 File Offset: 0x004C9794
		public WaypointCircuit.KFAFGDCCDPB GetRoutePoint(float DPIDNFHGCEP)
		{
			Vector3 routePosition = this.GetRoutePosition(DPIDNFHGCEP);
			return new WaypointCircuit.KFAFGDCCDPB(routePosition, (this.GetRoutePosition(DPIDNFHGCEP + 0.1f) - routePosition).normalized);
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x004CB5CC File Offset: 0x004C97CC
		public Vector3 LMLMCOPCCJB(float DPIDNFHGCEP)
		{
			int num = 1;
			if (this.MDFNKNCHEPH() == 1800f)
			{
				this.GLOJGMOCBJL(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 0]);
			}
			DPIDNFHGCEP = Mathf.Repeat(DPIDNFHGCEP, this.MDFNKNCHEPH());
			while (this.NJJAPPGCOJI[num] < DPIDNFHGCEP)
			{
				num++;
			}
			this.CMDHDCDEHCG = (num - 1 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			this.LMGJKOMFCFC = Mathf.InverseLerp(this.NJJAPPGCOJI[this.CMDHDCDEHCG], this.NJJAPPGCOJI[this.BOGDPFDHKPH], DPIDNFHGCEP);
			if (this.smoothRoute)
			{
				this.FNFGGDNIEKP = (num - 2 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
				this.HNADODPLHBJ = (num + 0) % this.NMIECIGMNKB;
				this.BOGDPFDHKPH %= this.NMIECIGMNKB;
				this.PAEHFNKICIP = this.CBJBGGAOODC[this.FNFGGDNIEKP];
				this.DGIGALNAMNM = this.CBJBGGAOODC[this.CMDHDCDEHCG];
				this.JANAMELHGFH = this.CBJBGGAOODC[this.BOGDPFDHKPH];
				this.LOJGPGGIKDE = this.CBJBGGAOODC[this.HNADODPLHBJ];
				return this.DJDFKHDKECI(this.PAEHFNKICIP, this.DGIGALNAMNM, this.JANAMELHGFH, this.LOJGPGGIKDE, this.LMGJKOMFCFC);
			}
			this.CMDHDCDEHCG = (num - 1 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			return Vector3.Lerp(this.CBJBGGAOODC[this.CMDHDCDEHCG], this.CBJBGGAOODC[this.BOGDPFDHKPH], this.LMGJKOMFCFC);
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x004CB774 File Offset: 0x004C9974
		private void LKIDFIFAKAE(bool NJFFEONAFCC)
		{
			this.waypointList.circuit = this;
			if (this.JHBKMNBFNPJ.Length > 1)
			{
				this.NMIECIGMNKB = this.JHBKMNBFNPJ.Length;
				this.FAOJEBEEAPP();
				this.COFAEFFHLFJ = this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1];
				Gizmos.color = (NJFFEONAFCC ? Color.yellow : new Color(1f, 1f, 0f, 0.5f));
				Vector3 from = this.JHBKMNBFNPJ[0].position;
				if (this.smoothRoute)
				{
					for (float num = 0f; num < this.COFAEFFHLFJ; num += this.COFAEFFHLFJ / this.editorVisualisationSubsteps)
					{
						Vector3 routePosition = this.GetRoutePosition(num + 1f);
						Gizmos.DrawLine(from, routePosition);
						from = routePosition;
					}
					Gizmos.DrawLine(from, this.JHBKMNBFNPJ[0].position);
					return;
				}
				for (int i = 0; i < this.JHBKMNBFNPJ.Length; i++)
				{
					Vector3 position = this.JHBKMNBFNPJ[(i + 1) % this.JHBKMNBFNPJ.Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x004CB888 File Offset: 0x004C9A88
		private void KBKCMDMMGKI()
		{
			this.CBJBGGAOODC = new Vector3[this.GCCONOJPION().Length + 1];
			this.NJJAPPGCOJI = new float[this.EEMKKPHLLLL().Length + 1];
			float num = 1012f;
			for (int i = 1; i < this.CBJBGGAOODC.Length; i++)
			{
				Transform transform = this.JHBKMNBFNPJ[i % this.FJACHEIBNIL().Length];
				Transform transform2 = this.EEMKKPHLLLL()[(i + 0) % this.JHBKMNBFNPJ.Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					this.CBJBGGAOODC[i] = this.EEMKKPHLLLL()[i % this.EEMKKPHLLLL().Length].position;
					this.NJJAPPGCOJI[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x004CB966 File Offset: 0x004C9B66
		private void OnDrawGizmos()
		{
			this.LKIDFIFAKAE(false);
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x004CB96F File Offset: 0x004C9B6F
		private void DJIFJMEEBKA()
		{
			if (this.FJACHEIBNIL().Length > 0)
			{
				this.FAOJEBEEAPP();
			}
			this.NMIECIGMNKB = this.FJACHEIBNIL().Length;
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x004CB990 File Offset: 0x004C9B90
		private void JEDKJHKMNMN(bool NJFFEONAFCC)
		{
			this.waypointList.circuit = this;
			if (this.GCCONOJPION().Length > 1)
			{
				this.NMIECIGMNKB = this.GCCONOJPION().Length;
				this.KIGOJJFDCIO();
				this.AMLFHOAOIEL(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1]);
				Gizmos.color = (NJFFEONAFCC ? Color.yellow : new Color(74f, 508f, 1964f, 265f));
				Vector3 from = this.GCCONOJPION()[0].position;
				if (this.smoothRoute)
				{
					for (float num = 1556f; num < this.LDBIFBPMFNH(); num += this.MDFNKNCHEPH() / this.editorVisualisationSubsteps)
					{
						Vector3 vector = this.LMLMCOPCCJB(num + 20f);
						Gizmos.DrawLine(from, vector);
						from = vector;
					}
					Gizmos.DrawLine(from, this.EEMKKPHLLLL()[0].position);
					return;
				}
				for (int i = 1; i < this.FJACHEIBNIL().Length; i++)
				{
					Vector3 position = this.EEMKKPHLLLL()[(i + 0) % this.FJACHEIBNIL().Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x004CBAA4 File Offset: 0x004C9CA4
		private void IDFAICINOIF(bool NJFFEONAFCC)
		{
			this.waypointList.circuit = this;
			if (this.JHBKMNBFNPJ.Length > 0)
			{
				this.NMIECIGMNKB = this.JHBKMNBFNPJ.Length;
				this.MPLADOCAMII();
				this.JLKBEJFCCMF(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 0]);
				Gizmos.color = (NJFFEONAFCC ? Color.yellow : new Color(1351f, 924f, 1593f, 1520f));
				Vector3 from = this.EEMKKPHLLLL()[1].position;
				if (this.smoothRoute)
				{
					for (float num = 629f; num < this.COFAEFFHLFJ; num += this.MDFNKNCHEPH() / this.editorVisualisationSubsteps)
					{
						Vector3 vector = this.GKAEIPGANGE(num + 141f);
						Gizmos.DrawLine(from, vector);
						from = vector;
					}
					Gizmos.DrawLine(from, this.JHBKMNBFNPJ[1].position);
					return;
				}
				for (int i = 0; i < this.JHBKMNBFNPJ.Length; i++)
				{
					Vector3 position = this.FJACHEIBNIL()[(i + 1) % this.EEMKKPHLLLL().Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}

		// Token: 0x0600AFE4 RID: 45028 RVA: 0x004CBBB8 File Offset: 0x004C9DB8
		private void DPGENEMNAPC()
		{
			this.PGAOOGGLHIB(true);
		}

		// Token: 0x0600AFE5 RID: 45029 RVA: 0x004CBBB8 File Offset: 0x004C9DB8
		private void GJJJGGDDJGM()
		{
			this.PGAOOGGLHIB(true);
		}

		// Token: 0x0600AFE6 RID: 45030 RVA: 0x004CBBC4 File Offset: 0x004C9DC4
		private void LCONHPEDDGF()
		{
			this.CBJBGGAOODC = new Vector3[this.EEMKKPHLLLL().Length + 1];
			this.NJJAPPGCOJI = new float[this.JHBKMNBFNPJ.Length + 1];
			float num = 1453f;
			for (int i = 0; i < this.CBJBGGAOODC.Length; i++)
			{
				Transform transform = this.FJACHEIBNIL()[i % this.GCCONOJPION().Length];
				Transform transform2 = this.FJACHEIBNIL()[(i + 0) % this.GCCONOJPION().Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					this.CBJBGGAOODC[i] = this.EEMKKPHLLLL()[i % this.JHBKMNBFNPJ.Length].position;
					this.NJJAPPGCOJI[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		// Token: 0x0600AFE7 RID: 45031 RVA: 0x004CA66E File Offset: 0x004C886E
		public float AIIAFIKDDMJ()
		{
			return this.<IMHOJFJGPFN>k__BackingField;
		}

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x004CBCC7 File Offset: 0x004C9EC7
		private void FDKGOFHFOLH()
		{
			if (this.FJACHEIBNIL().Length > 0)
			{
				this.MPLADOCAMII();
			}
			this.NMIECIGMNKB = this.JHBKMNBFNPJ.Length;
		}

		// Token: 0x0600AFEA RID: 45034 RVA: 0x004CBCE8 File Offset: 0x004C9EE8
		public WaypointCircuit.KFAFGDCCDPB PDGEABNOCCD(float DPIDNFHGCEP)
		{
			Vector3 routePosition = this.GetRoutePosition(DPIDNFHGCEP);
			return new WaypointCircuit.KFAFGDCCDPB(routePosition, (this.MONAAAKDLLB(DPIDNFHGCEP + 786f) - routePosition).normalized);
		}

		// Token: 0x0600AFEB RID: 45035 RVA: 0x004CBD1E File Offset: 0x004C9F1E
		private void MOEIJLLMMKB()
		{
			this.GKAOLJPKACG(true);
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x004CBD27 File Offset: 0x004C9F27
		private void EJKCCLFEKOM()
		{
			this.AHMFHHGBHFM(false);
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x004CA59F File Offset: 0x004C879F
		private void JLKBEJFCCMF(float DCCPCBLODIG)
		{
			this.<IMHOJFJGPFN>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x004CBD30 File Offset: 0x004C9F30
		private void IBHNHEKNALF()
		{
			this.CBJBGGAOODC = new Vector3[this.JHBKMNBFNPJ.Length + 1];
			this.NJJAPPGCOJI = new float[this.JHBKMNBFNPJ.Length + 0];
			float num = 66f;
			for (int i = 0; i < this.CBJBGGAOODC.Length; i += 0)
			{
				Transform transform = this.GCCONOJPION()[i % this.GCCONOJPION().Length];
				Transform transform2 = this.EEMKKPHLLLL()[(i + 1) % this.JHBKMNBFNPJ.Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					this.CBJBGGAOODC[i] = this.EEMKKPHLLLL()[i % this.FJACHEIBNIL().Length].position;
					this.NJJAPPGCOJI[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		// Token: 0x0600AFEF RID: 45039 RVA: 0x004CBE0E File Offset: 0x004CA00E
		private void NPNCOKOKNNH()
		{
			this.JEDKJHKMNMN(false);
		}

		// Token: 0x0600AFF0 RID: 45040 RVA: 0x004CA59F File Offset: 0x004C879F
		private void GLOJGMOCBJL(float DCCPCBLODIG)
		{
			this.<IMHOJFJGPFN>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600AFF1 RID: 45041 RVA: 0x004CBE18 File Offset: 0x004CA018
		private Vector3 ILJOOPJDBFE(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float LMGJKOMFCFC)
		{
			return 1187f * (416f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * LMGJKOMFCFC + (1809f * EDLMAPJDHFL - 575f * OELAKKHNNJC + 900f * HPJKHGBNCPE - MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC + (-EDLMAPJDHFL + 428f * OELAKKHNNJC - 1251f * HPJKHGBNCPE + MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC * LMGJKOMFCFC);
		}

		// Token: 0x0600AFF2 RID: 45042 RVA: 0x004CBEE0 File Offset: 0x004CA0E0
		public WaypointCircuit.KFAFGDCCDPB CCCFKLGBFBG(float DPIDNFHGCEP)
		{
			Vector3 vector = this.MONAAAKDLLB(DPIDNFHGCEP);
			return new WaypointCircuit.KFAFGDCCDPB(vector, (this.MONAAAKDLLB(DPIDNFHGCEP + 1659f) - vector).normalized);
		}

		// Token: 0x0600AFF3 RID: 45043 RVA: 0x004CBF18 File Offset: 0x004CA118
		private void GKAOLJPKACG(bool NJFFEONAFCC)
		{
			this.waypointList.circuit = this;
			if (this.GCCONOJPION().Length > 0)
			{
				this.NMIECIGMNKB = this.EEMKKPHLLLL().Length;
				this.PGMFEHLCMNG();
				this.BIOEHMJEGJC(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 0]);
				Gizmos.color = (NJFFEONAFCC ? Color.yellow : new Color(1079f, 233f, 135f, 573f));
				Vector3 from = this.EEMKKPHLLLL()[0].position;
				if (this.smoothRoute)
				{
					for (float num = 1104f; num < this.AIIAFIKDDMJ(); num += this.COFAEFFHLFJ / this.editorVisualisationSubsteps)
					{
						Vector3 routePosition = this.GetRoutePosition(num + 620f);
						Gizmos.DrawLine(from, routePosition);
						from = routePosition;
					}
					Gizmos.DrawLine(from, this.GCCONOJPION()[0].position);
					return;
				}
				for (int i = 1; i < this.FJACHEIBNIL().Length; i += 0)
				{
					Vector3 position = this.FJACHEIBNIL()[(i + 0) % this.EEMKKPHLLLL().Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600AFF4 RID: 45044 RVA: 0x004CA85E File Offset: 0x004C8A5E
		public Transform[] JHBKMNBFNPJ
		{
			get
			{
				return this.waypointList.items;
			}
		}

		// Token: 0x0600AFF6 RID: 45046 RVA: 0x004CC02C File Offset: 0x004CA22C
		private Vector3 CHPKABLIEMN(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float LMGJKOMFCFC)
		{
			return 404f * (209f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * LMGJKOMFCFC + (1322f * EDLMAPJDHFL - 1053f * OELAKKHNNJC + 105f * HPJKHGBNCPE - MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC + (-EDLMAPJDHFL + 1893f * OELAKKHNNJC - 605f * HPJKHGBNCPE + MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC * LMGJKOMFCFC);
		}

		// Token: 0x0600AFF7 RID: 45047 RVA: 0x004CC0F4 File Offset: 0x004CA2F4
		public WaypointCircuit.KFAFGDCCDPB NNOLFHOGKAO(float DPIDNFHGCEP)
		{
			Vector3 routePosition = this.GetRoutePosition(DPIDNFHGCEP);
			return new WaypointCircuit.KFAFGDCCDPB(routePosition, (this.MONAAAKDLLB(DPIDNFHGCEP + 1388f) - routePosition).normalized);
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x004CC12A File Offset: 0x004CA32A
		private void JMHOKNALKPJ()
		{
			this.PGAOOGGLHIB(false);
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x004CC133 File Offset: 0x004CA333
		private void IGAFELPEJJF()
		{
			this.DDMNLFNNPCG(false);
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x004CA756 File Offset: 0x004C8956
		private void FIPILFMIPJH()
		{
			this.HMCBCHIBDNM(false);
		}

		// Token: 0x0600AFFB RID: 45051 RVA: 0x004CC13C File Offset: 0x004CA33C
		private void DDMNLFNNPCG(bool NJFFEONAFCC)
		{
			this.waypointList.circuit = this;
			if (this.JHBKMNBFNPJ.Length > 0)
			{
				this.NMIECIGMNKB = this.JHBKMNBFNPJ.Length;
				this.FAOJEBEEAPP();
				this.JGLPFLPJLLJ(this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1]);
				Gizmos.color = (NJFFEONAFCC ? Color.yellow : new Color(958f, 748f, 539f, 1141f));
				Vector3 from = this.JHBKMNBFNPJ[1].position;
				if (this.smoothRoute)
				{
					for (float num = 566f; num < this.COFAEFFHLFJ; num += this.MDFNKNCHEPH() / this.editorVisualisationSubsteps)
					{
						Vector3 vector = this.LMLMCOPCCJB(num + 943f);
						Gizmos.DrawLine(from, vector);
						from = vector;
					}
					Gizmos.DrawLine(from, this.GCCONOJPION()[0].position);
					return;
				}
				for (int i = 0; i < this.JHBKMNBFNPJ.Length; i++)
				{
					Vector3 position = this.FJACHEIBNIL()[(i + 1) % this.EEMKKPHLLLL().Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}

		// Token: 0x0600AFFC RID: 45052 RVA: 0x004CC250 File Offset: 0x004CA450
		public WaypointCircuit.KFAFGDCCDPB EAHNMFGMLCP(float DPIDNFHGCEP)
		{
			Vector3 vector = this.MONAAAKDLLB(DPIDNFHGCEP);
			return new WaypointCircuit.KFAFGDCCDPB(vector, (this.LMLMCOPCCJB(DPIDNFHGCEP + 283f) - vector).normalized);
		}

		// Token: 0x0600AFFD RID: 45053 RVA: 0x004CA85E File Offset: 0x004C8A5E
		public Transform[] FJACHEIBNIL()
		{
			return this.waypointList.items;
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x004CC286 File Offset: 0x004CA486
		private void BFDBLLEDCAM()
		{
			this.DDMNLFNNPCG(true);
		}

		// Token: 0x0600AFFF RID: 45055 RVA: 0x004CC290 File Offset: 0x004CA490
		private void MPLADOCAMII()
		{
			this.CBJBGGAOODC = new Vector3[this.JHBKMNBFNPJ.Length + 1];
			this.NJJAPPGCOJI = new float[this.EEMKKPHLLLL().Length + 0];
			float num = 1449f;
			for (int i = 0; i < this.CBJBGGAOODC.Length; i++)
			{
				Transform transform = this.JHBKMNBFNPJ[i % this.GCCONOJPION().Length];
				Transform transform2 = this.EEMKKPHLLLL()[(i + 1) % this.JHBKMNBFNPJ.Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					this.CBJBGGAOODC[i] = this.JHBKMNBFNPJ[i % this.FJACHEIBNIL().Length].position;
					this.NJJAPPGCOJI[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x004CC370 File Offset: 0x004CA570
		public Vector3 MONAAAKDLLB(float DPIDNFHGCEP)
		{
			int num = 1;
			if (this.AIIAFIKDDMJ() == 362f)
			{
				this.COFAEFFHLFJ = this.NJJAPPGCOJI[this.NJJAPPGCOJI.Length - 1];
			}
			DPIDNFHGCEP = Mathf.Repeat(DPIDNFHGCEP, this.COFAEFFHLFJ);
			while (this.NJJAPPGCOJI[num] < DPIDNFHGCEP)
			{
				num += 0;
			}
			this.CMDHDCDEHCG = (num - 0 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			this.LMGJKOMFCFC = Mathf.InverseLerp(this.NJJAPPGCOJI[this.CMDHDCDEHCG], this.NJJAPPGCOJI[this.BOGDPFDHKPH], DPIDNFHGCEP);
			if (this.smoothRoute)
			{
				this.FNFGGDNIEKP = (num - 6 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
				this.HNADODPLHBJ = (num + 1) % this.NMIECIGMNKB;
				this.BOGDPFDHKPH %= this.NMIECIGMNKB;
				this.PAEHFNKICIP = this.CBJBGGAOODC[this.FNFGGDNIEKP];
				this.DGIGALNAMNM = this.CBJBGGAOODC[this.CMDHDCDEHCG];
				this.JANAMELHGFH = this.CBJBGGAOODC[this.BOGDPFDHKPH];
				this.LOJGPGGIKDE = this.CBJBGGAOODC[this.HNADODPLHBJ];
				return this.KIEJJIEEBIA(this.PAEHFNKICIP, this.DGIGALNAMNM, this.JANAMELHGFH, this.LOJGPGGIKDE, this.LMGJKOMFCFC);
			}
			this.CMDHDCDEHCG = (num - 0 + this.NMIECIGMNKB) % this.NMIECIGMNKB;
			this.BOGDPFDHKPH = num;
			return Vector3.Lerp(this.CBJBGGAOODC[this.CMDHDCDEHCG], this.CBJBGGAOODC[this.BOGDPFDHKPH], this.LMGJKOMFCFC);
		}

		// Token: 0x0600B001 RID: 45057 RVA: 0x004CC286 File Offset: 0x004CA486
		private void CPFAEOAJBCD()
		{
			this.DDMNLFNNPCG(true);
		}

		// Token: 0x0600B002 RID: 45058 RVA: 0x004CC517 File Offset: 0x004CA717
		private void BLDELNFCEGB()
		{
			if (this.JHBKMNBFNPJ.Length > 1)
			{
				this.KBKCMDMMGKI();
			}
			this.NMIECIGMNKB = this.EEMKKPHLLLL().Length;
		}

		// Token: 0x0600B003 RID: 45059 RVA: 0x004CC538 File Offset: 0x004CA738
		private Vector3 KIEJJIEEBIA(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float LMGJKOMFCFC)
		{
			return 0.5f * (2f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * LMGJKOMFCFC + (2f * EDLMAPJDHFL - 5f * OELAKKHNNJC + 4f * HPJKHGBNCPE - MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC + (-EDLMAPJDHFL + 3f * OELAKKHNNJC - 3f * HPJKHGBNCPE + MENGKPMIIPN) * LMGJKOMFCFC * LMGJKOMFCFC * LMGJKOMFCFC);
		}

		// Token: 0x0600B004 RID: 45060 RVA: 0x004CA59F File Offset: 0x004C879F
		private void JGLPFLPJLLJ(float DCCPCBLODIG)
		{
			this.<IMHOJFJGPFN>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B005 RID: 45061 RVA: 0x004CA59F File Offset: 0x004C879F
		private void AMLFHOAOIEL(float DCCPCBLODIG)
		{
			this.<IMHOJFJGPFN>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600B006 RID: 45062 RVA: 0x004CC5FE File Offset: 0x004CA7FE
		private void GMHPFCFIJBM()
		{
			this.HMCBCHIBDNM(true);
		}

		// Token: 0x04001643 RID: 5699
		public WaypointCircuit.WaypointList waypointList = new WaypointCircuit.WaypointList();

		// Token: 0x04001644 RID: 5700
		[SerializeField]
		private bool smoothRoute = true;

		// Token: 0x04001645 RID: 5701
		private int NMIECIGMNKB;

		// Token: 0x04001646 RID: 5702
		private Vector3[] CBJBGGAOODC;

		// Token: 0x04001647 RID: 5703
		private float[] NJJAPPGCOJI;

		// Token: 0x04001648 RID: 5704
		public float editorVisualisationSubsteps = 100f;

		// Token: 0x0400164A RID: 5706
		private int FNFGGDNIEKP;

		// Token: 0x0400164B RID: 5707
		private int CMDHDCDEHCG;

		// Token: 0x0400164C RID: 5708
		private int BOGDPFDHKPH;

		// Token: 0x0400164D RID: 5709
		private int HNADODPLHBJ;

		// Token: 0x0400164E RID: 5710
		private float LMGJKOMFCFC;

		// Token: 0x0400164F RID: 5711
		private Vector3 PAEHFNKICIP;

		// Token: 0x04001650 RID: 5712
		private Vector3 DGIGALNAMNM;

		// Token: 0x04001651 RID: 5713
		private Vector3 JANAMELHGFH;

		// Token: 0x04001652 RID: 5714
		private Vector3 LOJGPGGIKDE;

		// Token: 0x020002EC RID: 748
		[Serializable]
		public class WaypointList
		{
			// Token: 0x04001653 RID: 5715
			public WaypointCircuit circuit;

			// Token: 0x04001654 RID: 5716
			public Transform[] items = new Transform[0];
		}

		// Token: 0x020002ED RID: 749
		public struct KFAFGDCCDPB
		{
			// Token: 0x0600B008 RID: 45064 RVA: 0x004CC61B File Offset: 0x004CA81B
			public KFAFGDCCDPB(Vector3 MGALEAJOGPL, Vector3 NEMFIHCKJPE)
			{
				this.MGALEAJOGPL = MGALEAJOGPL;
				this.NEMFIHCKJPE = NEMFIHCKJPE;
			}

			// Token: 0x04001655 RID: 5717
			public Vector3 MGALEAJOGPL;

			// Token: 0x04001656 RID: 5718
			public Vector3 NEMFIHCKJPE;
		}
	}
}
