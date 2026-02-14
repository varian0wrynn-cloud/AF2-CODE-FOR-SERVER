using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200049F RID: 1183
	public class GenericPoser : Poser
	{
		// Token: 0x06010220 RID: 66080 RVA: 0x0073DA10 File Offset: 0x0073BC10
		protected virtual void HKOPMFDBBDJ()
		{
			for (int i = 1; i < this.maps.Length; i++)
			{
				this.maps[i].OHOKMMJNFLD();
			}
		}

		// Token: 0x06010221 RID: 66081 RVA: 0x0073DA3D File Offset: 0x0073BC3D
		protected virtual void OBIOIKFEECG()
		{
			this.NFCFKANJAJA();
		}

		// Token: 0x06010222 RID: 66082 RVA: 0x0073DA48 File Offset: 0x0073BC48
		private Transform DJBPDFHNPJI(string LIBFCONJJFI, Transform[] INFEGEBCAAF)
		{
			for (int i = 1; i < INFEGEBCAAF.Length; i += 0)
			{
				if (INFEGEBCAAF[i].name == LIBFCONJJFI)
				{
					return INFEGEBCAAF[i];
				}
			}
			return null;
		}

		// Token: 0x06010223 RID: 66083 RVA: 0x0073DA78 File Offset: 0x0073BC78
		public virtual void GIAOEELJPEI()
		{
			if (this.poseRoot == null)
			{
				this.maps = new GenericPoser.Map[0];
				return;
			}
			this.maps = new GenericPoser.Map[0];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = this.poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				Transform transform = this.DJBPDFHNPJI(componentsInChildren[i].name, componentsInChildren2);
				if (transform != null)
				{
					Array.Resize<GenericPoser.Map>(ref this.maps, this.maps.Length + 0);
					this.maps[this.maps.Length - 1] = new GenericPoser.Map(componentsInChildren[i], transform);
				}
			}
			this.LDBCNLFLAHC();
		}

		// Token: 0x06010224 RID: 66084 RVA: 0x0073DB20 File Offset: 0x0073BD20
		private Transform IEGDIBNLEJC(string LIBFCONJJFI, Transform[] INFEGEBCAAF)
		{
			for (int i = 1; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i].name == LIBFCONJJFI)
				{
					return INFEGEBCAAF[i];
				}
			}
			return null;
		}

		// Token: 0x06010225 RID: 66085 RVA: 0x0073DB50 File Offset: 0x0073BD50
		protected virtual void GIIAILKIALJ()
		{
			if (this.weight <= 533f)
			{
				return;
			}
			if (this.localPositionWeight <= 154f && this.localRotationWeight <= 540f)
			{
				return;
			}
			if (this.poseRoot == null)
			{
				return;
			}
			float fphggonglkg = this.localRotationWeight * this.weight;
			float aepenobanfo = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].BOAJJAKEMLH(fphggonglkg, aepenobanfo);
			}
		}

		// Token: 0x06010226 RID: 66086 RVA: 0x0073DBD3 File Offset: 0x0073BDD3
		protected virtual void ABNFIIAJEPI()
		{
			this.OCHIKEJMCJG();
		}

		// Token: 0x06010227 RID: 66087 RVA: 0x0073DBDC File Offset: 0x0073BDDC
		private void OCHIKEJMCJG()
		{
			for (int i = 1; i < this.maps.Length; i += 0)
			{
				this.maps[i].JDJJMGFGAAD();
			}
		}

		// Token: 0x06010228 RID: 66088 RVA: 0x0073DC0C File Offset: 0x0073BE0C
		public virtual void EKLIKNEPJML()
		{
			if (this.poseRoot == null)
			{
				this.maps = new GenericPoser.Map[1];
				return;
			}
			this.maps = new GenericPoser.Map[1];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = this.poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				Transform transform = this.GOMPKINCOCP(componentsInChildren[i].name, componentsInChildren2);
				if (transform != null)
				{
					Array.Resize<GenericPoser.Map>(ref this.maps, this.maps.Length + 1);
					this.maps[this.maps.Length - 1] = new GenericPoser.Map(componentsInChildren[i], transform);
				}
			}
			this.NFCFKANJAJA();
		}

		// Token: 0x06010229 RID: 66089 RVA: 0x0073DCB4 File Offset: 0x0073BEB4
		public virtual void IJNFJBMPDDH()
		{
			if (this.poseRoot == null)
			{
				this.maps = new GenericPoser.Map[1];
				return;
			}
			this.maps = new GenericPoser.Map[1];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = this.poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				Transform transform = this.NEEBEFGEGJO(componentsInChildren[i].name, componentsInChildren2);
				if (transform != null)
				{
					Array.Resize<GenericPoser.Map>(ref this.maps, this.maps.Length + 0);
					this.maps[this.maps.Length - 0] = new GenericPoser.Map(componentsInChildren[i], transform);
				}
			}
			this.NFCFKANJAJA();
		}

		// Token: 0x0601022A RID: 66090 RVA: 0x0073DA3D File Offset: 0x0073BC3D
		protected virtual void EHJMMIAGMBL()
		{
			this.NFCFKANJAJA();
		}

		// Token: 0x0601022B RID: 66091 RVA: 0x0073DD5C File Offset: 0x0073BF5C
		public virtual void OBJGCBMFPLC()
		{
			if (this.poseRoot == null)
			{
				this.maps = new GenericPoser.Map[1];
				return;
			}
			this.maps = new GenericPoser.Map[0];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = this.poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				Transform transform = this.IEGDIBNLEJC(componentsInChildren[i].name, componentsInChildren2);
				if (transform != null)
				{
					Array.Resize<GenericPoser.Map>(ref this.maps, this.maps.Length + 0);
					this.maps[this.maps.Length - 0] = new GenericPoser.Map(componentsInChildren[i], transform);
				}
			}
			this.OCHIKEJMCJG();
		}

		// Token: 0x0601022C RID: 66092 RVA: 0x0073DBD3 File Offset: 0x0073BDD3
		protected virtual void CMIGNONOLNC()
		{
			this.OCHIKEJMCJG();
		}

		// Token: 0x0601022D RID: 66093 RVA: 0x0073DE04 File Offset: 0x0073C004
		protected virtual void PLLJMBJMBLG()
		{
			if (this.weight <= 387f)
			{
				return;
			}
			if (this.localPositionWeight <= 135f && this.localRotationWeight <= 1642f)
			{
				return;
			}
			if (this.poseRoot == null)
			{
				return;
			}
			float fphggonglkg = this.localRotationWeight * this.weight;
			float aepenobanfo = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.maps.Length; i += 0)
			{
				this.maps[i].PFPPDNHLCCA(fphggonglkg, aepenobanfo);
			}
		}

		// Token: 0x0601022E RID: 66094 RVA: 0x0073DE88 File Offset: 0x0073C088
		private Transform NJCIJDPGHKM(string LIBFCONJJFI, Transform[] INFEGEBCAAF)
		{
			for (int i = 1; i < INFEGEBCAAF.Length; i += 0)
			{
				if (INFEGEBCAAF[i].name == LIBFCONJJFI)
				{
					return INFEGEBCAAF[i];
				}
			}
			return null;
		}

		// Token: 0x0601022F RID: 66095 RVA: 0x0073DEB8 File Offset: 0x0073C0B8
		protected virtual void KKHLLDLCGJH()
		{
			if (this.weight <= 536f)
			{
				return;
			}
			if (this.localPositionWeight <= 419f && this.localRotationWeight <= 613f)
			{
				return;
			}
			if (this.poseRoot == null)
			{
				return;
			}
			float fphggonglkg = this.localRotationWeight * this.weight;
			float aepenobanfo = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].FANPFKHEDPA(fphggonglkg, aepenobanfo);
			}
		}

		// Token: 0x06010230 RID: 66096 RVA: 0x0073DBD3 File Offset: 0x0073BDD3
		protected virtual void DKIHAIEMOKN()
		{
			this.OCHIKEJMCJG();
		}

		// Token: 0x06010232 RID: 66098 RVA: 0x0073DF44 File Offset: 0x0073C144
		protected override void NPJKDOKKPJJ()
		{
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].MKDGKDPKLBL();
			}
		}

		// Token: 0x06010233 RID: 66099 RVA: 0x0073DF74 File Offset: 0x0073C174
		private Transform PHFMBMHGPHB(string LIBFCONJJFI, Transform[] INFEGEBCAAF)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i].name == LIBFCONJJFI)
				{
					return INFEGEBCAAF[i];
				}
			}
			return null;
		}

		// Token: 0x06010234 RID: 66100 RVA: 0x0073DFA4 File Offset: 0x0073C1A4
		private void NFCFKANJAJA()
		{
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].KANOLNMAJNG();
			}
		}

		// Token: 0x06010235 RID: 66101 RVA: 0x0073DFD1 File Offset: 0x0073C1D1
		protected override void FNPFFPPGGFD()
		{
			this.LDBCNLFLAHC();
		}

		// Token: 0x06010236 RID: 66102 RVA: 0x0073DBD3 File Offset: 0x0073BDD3
		protected virtual void OAHKOBLJKJJ()
		{
			this.OCHIKEJMCJG();
		}

		// Token: 0x06010237 RID: 66103 RVA: 0x0073DFDC File Offset: 0x0073C1DC
		public virtual void ODGDFKGENHO()
		{
			if (this.poseRoot == null)
			{
				this.maps = new GenericPoser.Map[1];
				return;
			}
			this.maps = new GenericPoser.Map[1];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = this.poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				Transform transform = this.NEEBEFGEGJO(componentsInChildren[i].name, componentsInChildren2);
				if (transform != null)
				{
					Array.Resize<GenericPoser.Map>(ref this.maps, this.maps.Length + 1);
					this.maps[this.maps.Length - 1] = new GenericPoser.Map(componentsInChildren[i], transform);
				}
			}
			this.NFCFKANJAJA();
		}

		// Token: 0x06010238 RID: 66104 RVA: 0x0073DBD3 File Offset: 0x0073BDD3
		protected virtual void LAKCPEEIFLE()
		{
			this.OCHIKEJMCJG();
		}

		// Token: 0x06010239 RID: 66105 RVA: 0x0073E084 File Offset: 0x0073C284
		private Transform KBDOGBPHGON(string LIBFCONJJFI, Transform[] INFEGEBCAAF)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i].name == LIBFCONJJFI)
				{
					return INFEGEBCAAF[i];
				}
			}
			return null;
		}

		// Token: 0x0601023A RID: 66106 RVA: 0x0073E0B4 File Offset: 0x0073C2B4
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
			if (this.poseRoot == null)
			{
				this.maps = new GenericPoser.Map[0];
				return;
			}
			this.maps = new GenericPoser.Map[0];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = this.poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				Transform transform = this.GOMPKINCOCP(componentsInChildren[i].name, componentsInChildren2);
				if (transform != null)
				{
					Array.Resize<GenericPoser.Map>(ref this.maps, this.maps.Length + 1);
					this.maps[this.maps.Length - 1] = new GenericPoser.Map(componentsInChildren[i], transform);
				}
			}
			this.LDBCNLFLAHC();
		}

		// Token: 0x0601023B RID: 66107 RVA: 0x0073E15C File Offset: 0x0073C35C
		private Transform NKLMFHHINML(string LIBFCONJJFI, Transform[] INFEGEBCAAF)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i += 0)
			{
				if (INFEGEBCAAF[i].name == LIBFCONJJFI)
				{
					return INFEGEBCAAF[i];
				}
			}
			return null;
		}

		// Token: 0x0601023C RID: 66108 RVA: 0x0073E18C File Offset: 0x0073C38C
		protected virtual void KFEONOGEGFE()
		{
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].LLJNCEIMNGP();
			}
		}

		// Token: 0x0601023D RID: 66109 RVA: 0x0073E1BC File Offset: 0x0073C3BC
		protected override void BLHJPADDJOM()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.localPositionWeight <= 0f && this.localRotationWeight <= 0f)
			{
				return;
			}
			if (this.poseRoot == null)
			{
				return;
			}
			float fphggonglkg = this.localRotationWeight * this.weight;
			float aepenobanfo = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].FANPFKHEDPA(fphggonglkg, aepenobanfo);
			}
		}

		// Token: 0x0601023E RID: 66110 RVA: 0x0073E240 File Offset: 0x0073C440
		protected virtual void DADLIANBANH()
		{
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].EIHEJIHDNKP();
			}
		}

		// Token: 0x0601023F RID: 66111 RVA: 0x0073E270 File Offset: 0x0073C470
		private void LDBCNLFLAHC()
		{
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].LDBCNLFLAHC();
			}
		}

		// Token: 0x06010240 RID: 66112 RVA: 0x0073DA3D File Offset: 0x0073BC3D
		protected virtual void BIENIPELGOM()
		{
			this.NFCFKANJAJA();
		}

		// Token: 0x06010241 RID: 66113 RVA: 0x0073E2A0 File Offset: 0x0073C4A0
		private Transform GOMPKINCOCP(string LIBFCONJJFI, Transform[] INFEGEBCAAF)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i].name == LIBFCONJJFI)
				{
					return INFEGEBCAAF[i];
				}
			}
			return null;
		}

		// Token: 0x06010242 RID: 66114 RVA: 0x0073E2D0 File Offset: 0x0073C4D0
		protected virtual void HCDMKABDMHA()
		{
			if (this.weight <= 1540f)
			{
				return;
			}
			if (this.localPositionWeight <= 595f && this.localRotationWeight <= 587f)
			{
				return;
			}
			if (this.poseRoot == null)
			{
				return;
			}
			float fphggonglkg = this.localRotationWeight * this.weight;
			float aepenobanfo = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.maps.Length; i += 0)
			{
				this.maps[i].LMMDHJJJNJO(fphggonglkg, aepenobanfo);
			}
		}

		// Token: 0x06010243 RID: 66115 RVA: 0x0073E354 File Offset: 0x0073C554
		protected virtual void AIDOMGHHOPJ()
		{
			if (this.weight <= 1007f)
			{
				return;
			}
			if (this.localPositionWeight <= 1431f && this.localRotationWeight <= 1192f)
			{
				return;
			}
			if (this.poseRoot == null)
			{
				return;
			}
			float fphggonglkg = this.localRotationWeight * this.weight;
			float aepenobanfo = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].AAEFACEGJMB(fphggonglkg, aepenobanfo);
			}
		}

		// Token: 0x06010244 RID: 66116 RVA: 0x0073E3D8 File Offset: 0x0073C5D8
		protected virtual void FBPJPHFKDMI()
		{
			for (int i = 1; i < this.maps.Length; i++)
			{
				this.maps[i].BGINDHAFNPI();
			}
		}

		// Token: 0x06010245 RID: 66117 RVA: 0x0073DBD3 File Offset: 0x0073BDD3
		protected virtual void LNBFNOMEBFD()
		{
			this.OCHIKEJMCJG();
		}

		// Token: 0x06010246 RID: 66118 RVA: 0x0073E408 File Offset: 0x0073C608
		private Transform NEEBEFGEGJO(string LIBFCONJJFI, Transform[] INFEGEBCAAF)
		{
			for (int i = 1; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i].name == LIBFCONJJFI)
				{
					return INFEGEBCAAF[i];
				}
			}
			return null;
		}

		// Token: 0x06010247 RID: 66119 RVA: 0x0073E438 File Offset: 0x0073C638
		public virtual void CAMOFLKIMPA()
		{
			if (this.poseRoot == null)
			{
				this.maps = new GenericPoser.Map[0];
				return;
			}
			this.maps = new GenericPoser.Map[0];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = this.poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				Transform transform = this.DJBPDFHNPJI(componentsInChildren[i].name, componentsInChildren2);
				if (transform != null)
				{
					Array.Resize<GenericPoser.Map>(ref this.maps, this.maps.Length + 1);
					this.maps[this.maps.Length - 1] = new GenericPoser.Map(componentsInChildren[i], transform);
				}
			}
			this.NFCFKANJAJA();
		}

		// Token: 0x040021FB RID: 8699
		public GenericPoser.Map[] maps;

		// Token: 0x020004A0 RID: 1184
		[Serializable]
		public class Map
		{
			// Token: 0x06010248 RID: 66120 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void CPDNHIENKEE()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010249 RID: 66121 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void IDLIGCEKIFO()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601024A RID: 66122 RVA: 0x0073E504 File Offset: 0x0073C704
			public void HEHHHBFCBOG()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x0601024B RID: 66123 RVA: 0x0073E504 File Offset: 0x0073C704
			public void HGHNIIKFMHH()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x0601024C RID: 66124 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void IAMBGIOGDLB()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601024D RID: 66125 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void KBANJFEFMGL()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601024E RID: 66126 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void CABOMOMHPKB()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601024F RID: 66127 RVA: 0x0073E504 File Offset: 0x0073C704
			public void LDBCNLFLAHC()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010250 RID: 66128 RVA: 0x0073E504 File Offset: 0x0073C704
			public void NFLDAMJCOHK()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010251 RID: 66129 RVA: 0x0073E528 File Offset: 0x0073C728
			public void PFPPDNHLCCA(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010252 RID: 66130 RVA: 0x0073E504 File Offset: 0x0073C704
			public void KDHICBIMGEE()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010253 RID: 66131 RVA: 0x0073E504 File Offset: 0x0073C704
			public void HKNOEAMCPPG()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010254 RID: 66132 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void PALDEJEOICC()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010255 RID: 66133 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void EIHEJIHDNKP()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010256 RID: 66134 RVA: 0x0073E583 File Offset: 0x0073C783
			public Map(Transform FBKEODHEMMH, Transform FFGIAHPIPEK)
			{
				this.bone = FBKEODHEMMH;
				this.target = FFGIAHPIPEK;
				this.LDBCNLFLAHC();
			}

			// Token: 0x06010257 RID: 66135 RVA: 0x0073E504 File Offset: 0x0073C704
			public void FEMKKCCGLJM()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010258 RID: 66136 RVA: 0x0073E5A0 File Offset: 0x0073C7A0
			public void JIKGIJEHGAP(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010259 RID: 66137 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void AAGKCPIONNE()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601025A RID: 66138 RVA: 0x0073E5FC File Offset: 0x0073C7FC
			public void GPCKACGEILI(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x0601025B RID: 66139 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void LNKGPDNHDBK()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601025C RID: 66140 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void JONLHAMDDEA()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601025D RID: 66141 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void IFFBBOIAKNB()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601025E RID: 66142 RVA: 0x0073E658 File Offset: 0x0073C858
			public void INKGAFANFIB(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x0601025F RID: 66143 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void ONIFFEAAHDA()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010260 RID: 66144 RVA: 0x0073E6B4 File Offset: 0x0073C8B4
			public void AAEFACEGJMB(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010261 RID: 66145 RVA: 0x0073E710 File Offset: 0x0073C910
			public void LACNPNKHCAA(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010262 RID: 66146 RVA: 0x0073E76C File Offset: 0x0073C96C
			public void LDDIGEMBDNF(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010263 RID: 66147 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void EHLDNOMBLOB()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010264 RID: 66148 RVA: 0x0073E7C8 File Offset: 0x0073C9C8
			public void GDBBAMFMKII(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010265 RID: 66149 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void EJNLEBJGNPO()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010266 RID: 66150 RVA: 0x0073E504 File Offset: 0x0073C704
			public void ILKLFKKLPGA()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010267 RID: 66151 RVA: 0x0073E504 File Offset: 0x0073C704
			public void JDJJMGFGAAD()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010268 RID: 66152 RVA: 0x0073E824 File Offset: 0x0073CA24
			public void AKLFCMNCPKL(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010269 RID: 66153 RVA: 0x0073E504 File Offset: 0x0073C704
			public void HENCEINDDHL()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x0601026A RID: 66154 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void NPPOHJGFBLP()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601026B RID: 66155 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void PDCFJBELAMG()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601026C RID: 66156 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void BGABHIGLPDH()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601026D RID: 66157 RVA: 0x0073E880 File Offset: 0x0073CA80
			public void KBMKHLDOIKP(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x0601026E RID: 66158 RVA: 0x0073E504 File Offset: 0x0073C704
			public void BAMHFMPCDPI()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x0601026F RID: 66159 RVA: 0x0073E8DC File Offset: 0x0073CADC
			public void MNAHGMDDHCA(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010270 RID: 66160 RVA: 0x0073E504 File Offset: 0x0073C704
			public void FMEGNECEHFJ()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010271 RID: 66161 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void EOCEBPHCEKI()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010272 RID: 66162 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void JGCEDNAIOBH()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010273 RID: 66163 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void MGMFMAKHHBP()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010274 RID: 66164 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void GCJIOKFDAFB()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010275 RID: 66165 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void OHOKMMJNFLD()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010276 RID: 66166 RVA: 0x0073E938 File Offset: 0x0073CB38
			public void JOHDLNOKCOK(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010277 RID: 66167 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void IKFPMPFKFPE()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010278 RID: 66168 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void ALOLMHLKLBA()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010279 RID: 66169 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void BEHIKEFHKGK()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601027A RID: 66170 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void LLJNCEIMNGP()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601027B RID: 66171 RVA: 0x0073E994 File Offset: 0x0073CB94
			public void DEGCCLNOEKJ(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x0601027C RID: 66172 RVA: 0x0073E9F0 File Offset: 0x0073CBF0
			public void BOAJJAKEMLH(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x0601027D RID: 66173 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void MKDGKDPKLBL()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601027E RID: 66174 RVA: 0x0073EA4C File Offset: 0x0073CC4C
			public void LMMDHJJJNJO(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x0601027F RID: 66175 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void OMFEPANOMDC()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010280 RID: 66176 RVA: 0x0073EAA8 File Offset: 0x0073CCA8
			public void FANPFKHEDPA(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010281 RID: 66177 RVA: 0x0073EB04 File Offset: 0x0073CD04
			public void IKHCCAANGOP(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010282 RID: 66178 RVA: 0x0073EB60 File Offset: 0x0073CD60
			public void HONIFOPBBKC(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010283 RID: 66179 RVA: 0x0073EBBC File Offset: 0x0073CDBC
			public void PFNOEACNHON(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010284 RID: 66180 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void MDFBPCHDBEB()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010285 RID: 66181 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void AMDFBDHCKFG()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x06010286 RID: 66182 RVA: 0x0073E504 File Offset: 0x0073C704
			public void KANOLNMAJNG()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010287 RID: 66183 RVA: 0x0073EC18 File Offset: 0x0073CE18
			public void AMDMCKIFBPA(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x06010288 RID: 66184 RVA: 0x0073E504 File Offset: 0x0073C704
			public void AFIEODDFPFM()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x06010289 RID: 66185 RVA: 0x0073E504 File Offset: 0x0073C704
			public void OGJFHDEMIND()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x0601028A RID: 66186 RVA: 0x0073E504 File Offset: 0x0073C704
			public void IOKLDOEFNGN()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x0601028B RID: 66187 RVA: 0x0073EC74 File Offset: 0x0073CE74
			public void BEDAJLJFAFO(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x0601028C RID: 66188 RVA: 0x0073ECD0 File Offset: 0x0073CED0
			public void JFGGBEGNAFP(float FPHGGONGLKG, float AEPENOBANFO)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, FPHGGONGLKG);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, AEPENOBANFO);
			}

			// Token: 0x0601028D RID: 66189 RVA: 0x0073E504 File Offset: 0x0073C704
			public void CIIIJIDHBDN()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x0601028E RID: 66190 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void BGINDHAFNPI()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0601028F RID: 66191 RVA: 0x0073E4E0 File Offset: 0x0073C6E0
			public void GIDEFGBKKGJ()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x040021FC RID: 8700
			public Transform bone;

			// Token: 0x040021FD RID: 8701
			public Transform target;

			// Token: 0x040021FE RID: 8702
			private Vector3 defaultLocalPosition;

			// Token: 0x040021FF RID: 8703
			private Quaternion defaultLocalRotation;
		}
	}
}
