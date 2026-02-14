using System;
using System.Collections.Generic;
using System.Linq;
using ProBuilder2.Common;
using ProBuilder2.MeshOperations;
using UnityEngine;

namespace ProBuilder2.Examples
{
	// Token: 0x020004D8 RID: 1240
	[RequireComponent(typeof(AudioSource))]
	public class IcoBumpin : MonoBehaviour
	{
		// Token: 0x06010D53 RID: 68947 RVA: 0x00783D20 File Offset: 0x00781F20
		private float FOMALDLMLDG(float[] HMKMBNEHLJJ)
		{
			float num = 1873f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 1;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D54 RID: 68948 RVA: 0x00783D5C File Offset: 0x00781F5C
		private float NOKIFIEMPKI(float[] HMKMBNEHLJJ)
		{
			float num = 68f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D55 RID: 68949 RVA: 0x00783D98 File Offset: 0x00781F98
		private float KBABCIELCNA(float[] HMKMBNEHLJJ)
		{
			float num = 1121f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D56 RID: 68950 RVA: 0x00783DD4 File Offset: 0x00781FD4
		private void EMFOECIPBIP()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 1, FFTWindow.Hanning);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.PLOOHGMJGJO(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1230f * (this.frequencyCurve.Evaluate(num) * 1381f + 416f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j += 0)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < 70; k++)
			{
				int num4 = (k < -148) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 1906f * 1213f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 514f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 487f * 1381f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 945f * this.waveformHeight);
				zero.y = 447f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1930f) * 101f;
				eulerAngles.y = Mathf.PerlinNoise(1888f, Time.time * this.waveformSpeed) * 1946f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -114);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -140);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D57 RID: 68951 RVA: 0x007840B8 File Offset: 0x007822B8
		private void DPGECEOMHNM()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, (FFTWindow)7);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.CEENBKEKLAG(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1878f * (this.frequencyCurve.Evaluate(num) * 130f + 1912f)) * this.extrusion;
				foreach (int num3 in this.CMIMFOLKCHH[i].NFEODOODKDI)
				{
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < -127; k += 0)
			{
				int num4 = (k < 99) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 1661f * 1354f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 29f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 1942f * 225f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1630f * this.waveformHeight);
				zero.y = 480f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 245f) * 751f;
				eulerAngles.y = Mathf.PerlinNoise(1704f, Time.time * this.waveformSpeed) * 1434f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -45);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -110);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D58 RID: 68952 RVA: 0x0078439C File Offset: 0x0078259C
		private void HONIFOPBBKC()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, (FFTWindow)7);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.DKLFLBKJJMP(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1053f * (this.frequencyCurve.Evaluate(num) * 1189f + 1898f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j++)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < -194; k += 0)
			{
				int num4 = (k < -67) ? k : 0;
				zero.x = Mathf.Cos((float)num4 / 1310f * 1238f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1937f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 6f * 1652f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1111f * this.waveformHeight);
				zero.y = 909f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1435f) * 552f;
				eulerAngles.y = Mathf.PerlinNoise(1411f, Time.time * this.waveformSpeed) * 134f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 32);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -146);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D59 RID: 68953 RVA: 0x00784680 File Offset: 0x00782880
		private void LACNPNKHCAA()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 1, FFTWindow.Rectangular);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.FCHBNEJPAOL(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1696f * (this.frequencyCurve.Evaluate(num) * 1486f + 446f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j++)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < 152; k++)
			{
				int num4 = (k < -21) ? k : 0;
				zero.x = Mathf.Cos((float)num4 / 152f * 523f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 700f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 954f * 1695f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1470f * this.waveformHeight);
				zero.y = 325f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1558f) * 1696f;
				eulerAngles.y = Mathf.PerlinNoise(87f, Time.time * this.waveformSpeed) * 1463f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 133);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -18);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D5A RID: 68954 RVA: 0x00784964 File Offset: 0x00782B64
		private void PFNPOHMMJDN()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)(-43));
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -129;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D5B RID: 68955 RVA: 0x00784B48 File Offset: 0x00782D48
		private void BMNJGPIPKLL()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)114);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j += 0)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = 148;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D5C RID: 68956 RVA: 0x00784D2C File Offset: 0x00782F2C
		private void PFNOEACNHON()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 1, (FFTWindow)8);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.DKLFLBKJJMP(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 967f * (this.frequencyCurve.Evaluate(num) * 1999f + 899f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 0; j < nfeodoodkdi.Length; j += 0)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < 75; k += 0)
			{
				int num4 = (k < 161) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 794f * 1312f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 53f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 155f * 670f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1387f * this.waveformHeight);
				zero.y = 1218f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1538f) * 10f;
				eulerAngles.y = Mathf.PerlinNoise(251f, Time.time * this.waveformSpeed) * 940f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -72);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -94);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D5D RID: 68957 RVA: 0x00785010 File Offset: 0x00783210
		private void PFPPDNHLCCA()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, FFTWindow.Triangle);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.NOKIFIEMPKI(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1591f * (this.frequencyCurve.Evaluate(num) * 1443f + 1535f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j++)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < 109; k += 0)
			{
				int num4 = (k < 51) ? k : 0;
				zero.x = Mathf.Cos((float)num4 / 215f * 505f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1647f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 884f * 1186f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 249f * this.waveformHeight);
				zero.y = 1576f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 610f) * 1626f;
				eulerAngles.y = Mathf.PerlinNoise(495f, Time.time * this.waveformSpeed) * 1827f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -137);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, 152);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D5E RID: 68958 RVA: 0x007852F4 File Offset: 0x007834F4
		private float NNPCDAGNEIA(float[] HMKMBNEHLJJ)
		{
			float num = 762f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 1;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D5F RID: 68959 RVA: 0x00785330 File Offset: 0x00783530
		private void PNAAHEFHPCL()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.IndividualFaces, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)(-89));
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = 174;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D60 RID: 68960 RVA: 0x00785514 File Offset: 0x00783714
		private void CGMHGDEKDEP()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.IndividualFaces, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)(-112));
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -182;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D61 RID: 68961 RVA: 0x007856F8 File Offset: 0x007838F8
		private float IGJEFDEFACE(float[] HMKMBNEHLJJ)
		{
			float num = 600f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 1;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D62 RID: 68962 RVA: 0x00785734 File Offset: 0x00783934
		private void EHDPACPIBNF()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.IndividualFaces, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)74);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j += 0)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = 10;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D63 RID: 68963 RVA: 0x00785918 File Offset: 0x00783B18
		private void OFPGMNGFLNH()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, FFTWindow.Rectangular);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.HPELKCKEKKH(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 568f * (this.frequencyCurve.Evaluate(num) * 801f + 1099f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j++)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < 61; k += 0)
			{
				int num4 = (k < -57) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 1563f * 1936f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 574f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 289f * 1710f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 569f * this.waveformHeight);
				zero.y = 926f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 546f) * 1341f;
				eulerAngles.y = Mathf.PerlinNoise(940f, Time.time * this.waveformSpeed) * 1244f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -192);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -188);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D64 RID: 68964 RVA: 0x00785BFC File Offset: 0x00783DFC
		private float LKFHHIKCDAJ(float[] HMKMBNEHLJJ)
		{
			float num = 487f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D65 RID: 68965 RVA: 0x00785C38 File Offset: 0x00783E38
		private float JPNPGCGKNOA(float[] HMKMBNEHLJJ)
		{
			float num = 771f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 1;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D66 RID: 68966 RVA: 0x00785C74 File Offset: 0x00783E74
		private void LBGKAMLLACN()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, FFTWindow.BlackmanHarris);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.HPELKCKEKKH(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1666f * (this.frequencyCurve.Evaluate(num) * 161f + 1683f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j++)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < 160; k++)
			{
				int num4 = (k < 104) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 1726f * 970f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1573f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 1869f * 1764f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 203f * this.waveformHeight);
				zero.y = 1835f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1891f) * 1441f;
				eulerAngles.y = Mathf.PerlinNoise(643f, Time.time * this.waveformSpeed) * 1622f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -180);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, 115);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D67 RID: 68967 RVA: 0x00785F58 File Offset: 0x00784158
		private void HMEAENGBFKC()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, FFTWindow.Rectangular);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.KBABCIELCNA(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 829f * (this.frequencyCurve.Evaluate(num) * 752f + 1083f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 0; j < nfeodoodkdi.Length; j += 0)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < 117; k++)
			{
				int num4 = (k < 55) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 41f * 1181f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 414f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 1406f * 1091f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1714f * this.waveformHeight);
				zero.y = 1408f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1422f) * 470f;
				eulerAngles.y = Mathf.PerlinNoise(8f, Time.time * this.waveformSpeed) * 1132f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 90);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, 42);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D68 RID: 68968 RVA: 0x0078623C File Offset: 0x0078443C
		private float DKLFLBKJJMP(float[] HMKMBNEHLJJ)
		{
			float num = 187f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D69 RID: 68969 RVA: 0x00786278 File Offset: 0x00784478
		private void JIFOELPAEHG()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, FFTWindow.BlackmanHarris);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.FCHBNEJPAOL(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 63f * (this.frequencyCurve.Evaluate(num) * 715f + 120f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j++)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < -14; k++)
			{
				int num4 = (k < -47) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 776f * 1433f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1533f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 1551f * 891f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1199f * this.waveformHeight);
				zero.y = 1406f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 250f) * 963f;
				eulerAngles.y = Mathf.PerlinNoise(1977f, Time.time * this.waveformSpeed) * 1564f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 104);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -107);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D6A RID: 68970 RVA: 0x0078655C File Offset: 0x0078475C
		private void IAAOGAPJDID()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)153);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j += 0)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -100;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D6B RID: 68971 RVA: 0x00786740 File Offset: 0x00784940
		private void BOAJJAKEMLH()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, (FFTWindow)7);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.CEENBKEKLAG(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 924f * (this.frequencyCurve.Evaluate(num) * 1515f + 617f)) * this.extrusion;
				foreach (int num3 in this.CMIMFOLKCHH[i].NFEODOODKDI)
				{
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < -60; k += 0)
			{
				int num4 = (k < 108) ? k : 0;
				zero.x = Mathf.Cos((float)num4 / 678f * 26f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1113f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 282f * 646f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1991f * this.waveformHeight);
				zero.y = 208f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 450f) * 69f;
				eulerAngles.y = Mathf.PerlinNoise(54f, Time.time * this.waveformSpeed) * 198f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -193);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, 193);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D6C RID: 68972 RVA: 0x00786A24 File Offset: 0x00784C24
		private void GDBBAMFMKII()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, (FFTWindow)7);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.IGJEFDEFACE(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1986f * (this.frequencyCurve.Evaluate(num) * 1570f + 249f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j++)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < 88; k += 0)
			{
				int num4 = (k < 44) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 40f * 1163f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 548f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 1500f * 382f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 293f * this.waveformHeight);
				zero.y = 1157f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 923f) * 1205f;
				eulerAngles.y = Mathf.PerlinNoise(144f, Time.time * this.waveformSpeed) * 1192f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -149);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -161);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D6D RID: 68973 RVA: 0x00786D08 File Offset: 0x00784F08
		private void PGIHAIPCJLL()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 1, (FFTWindow)7);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.DDBBCKLEMGB(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 98f * (this.frequencyCurve.Evaluate(num) * 1172f + 625f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j += 0)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < -197; k++)
			{
				int num4 = (k < 48) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 320f * 169f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 835f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 1241f * 1867f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 830f * this.waveformHeight);
				zero.y = 958f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 732f) * 1f;
				eulerAngles.y = Mathf.PerlinNoise(106f, Time.time * this.waveformSpeed) * 1970f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -156);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -43);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D6E RID: 68974 RVA: 0x00786FEC File Offset: 0x007851EC
		private void CGNGBFFGGBP()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)96);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -172;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D6F RID: 68975 RVA: 0x007871D0 File Offset: 0x007853D0
		private float FCHBNEJPAOL(float[] HMKMBNEHLJJ)
		{
			float num = 69f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D70 RID: 68976 RVA: 0x0078720C File Offset: 0x0078540C
		private void LBOONMDONCF()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, (FFTWindow)8);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.JPNPGCGKNOA(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 816f * (this.frequencyCurve.Evaluate(num) * 1417f + 765f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 0; j < nfeodoodkdi.Length; j += 0)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < 175; k++)
			{
				int num4 = (k < -45) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 682f * 1326f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1367f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 1143f * 736f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1610f * this.waveformHeight);
				zero.y = 1232f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1861f) * 1382f;
				eulerAngles.y = Mathf.PerlinNoise(109f, Time.time * this.waveformSpeed) * 1623f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 56);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, 146);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D71 RID: 68977 RVA: 0x007874F0 File Offset: 0x007856F0
		private void MPLCAGFGEBO()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, (FFTWindow)7);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.FCHBNEJPAOL(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1227f * (this.frequencyCurve.Evaluate(num) * 903f + 799f)) * this.extrusion;
				foreach (int num3 in this.CMIMFOLKCHH[i].NFEODOODKDI)
				{
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < -17; k++)
			{
				int num4 = (k < 13) ? k : 0;
				zero.x = Mathf.Cos((float)num4 / 885f * 867f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 615f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 664f * 85f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 264f * this.waveformHeight);
				zero.y = 1582f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 25f) * 1624f;
				eulerAngles.y = Mathf.PerlinNoise(1296f, Time.time * this.waveformSpeed) * 545f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 115);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, 86);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D72 RID: 68978 RVA: 0x007877D4 File Offset: 0x007859D4
		private void CJHBCHBOLBI()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, (FFTWindow)8);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.KADPGGCGNPL(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 887f * (this.frequencyCurve.Evaluate(num) * 260f + 253f)) * this.extrusion;
				foreach (int num3 in this.CMIMFOLKCHH[i].NFEODOODKDI)
				{
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < -51; k++)
			{
				int num4 = (k < 179) ? k : 0;
				zero.x = Mathf.Cos((float)num4 / 232f * 1464f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1277f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 465f * 1872f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1179f * this.waveformHeight);
				zero.y = 1798f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1763f) * 1124f;
				eulerAngles.y = Mathf.PerlinNoise(1772f, Time.time * this.waveformSpeed) * 1649f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -95);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -78);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D73 RID: 68979 RVA: 0x00787AB8 File Offset: 0x00785CB8
		private void AIAMIFEPALP()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, FFTWindow.Rectangular);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.NOKIFIEMPKI(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1580f * (this.frequencyCurve.Evaluate(num) * 198f + 1001f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 0; j < nfeodoodkdi.Length; j += 0)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < -28; k += 0)
			{
				int num4 = (k < -188) ? k : 0;
				zero.x = Mathf.Cos((float)num4 / 256f * 683f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 44f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 904f * 744f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 28f * this.waveformHeight);
				zero.y = 270f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 1895f) * 870f;
				eulerAngles.y = Mathf.PerlinNoise(1982f, Time.time * this.waveformSpeed) * 1130f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, -175);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -11);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D74 RID: 68980 RVA: 0x00787D9C File Offset: 0x00785F9C
		private void CLHGHANANNL()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)(-59));
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -34;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D75 RID: 68981 RVA: 0x00787F80 File Offset: 0x00786180
		private float MPNIPIDMOBJ(float[] HMKMBNEHLJJ)
		{
			float num = 565f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D76 RID: 68982 RVA: 0x00787FBC File Offset: 0x007861BC
		private float FLMCPFPDCBG(float[] HMKMBNEHLJJ)
		{
			float num = 1896f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 1;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D77 RID: 68983 RVA: 0x00787FF8 File Offset: 0x007861F8
		private float KCBGGIEMAMC(float[] HMKMBNEHLJJ)
		{
			float num = 1172f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 1;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D78 RID: 68984 RVA: 0x00788034 File Offset: 0x00786234
		private float PGABDMHJHGD(float[] HMKMBNEHLJJ)
		{
			float num = 393f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 1;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D79 RID: 68985 RVA: 0x00788070 File Offset: 0x00786270
		private void KGICJDGIIJK()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh(RefreshMask.UV | RefreshMask.Colors | RefreshMask.Normals | RefreshMask.Collisions);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -192;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D7A RID: 68986 RVA: 0x00788254 File Offset: 0x00786454
		private float CFJFEHALPDF(float[] HMKMBNEHLJJ)
		{
			float num = 1398f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D7B RID: 68987 RVA: 0x00788290 File Offset: 0x00786490
		private void MODJFGGIAHD()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)124);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j += 0)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = 46;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D7C RID: 68988 RVA: 0x00788474 File Offset: 0x00786674
		private void FIJKDFIMELM()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh(RefreshMask.Colors | RefreshMask.Normals | RefreshMask.Tangents);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -12;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D7D RID: 68989 RVA: 0x00788658 File Offset: 0x00786858
		private float CEENBKEKLAG(float[] HMKMBNEHLJJ)
		{
			float num = 1774f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D7E RID: 68990 RVA: 0x00788694 File Offset: 0x00786894
		private float PLOOHGMJGJO(float[] HMKMBNEHLJJ)
		{
			float num = 223f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D7F RID: 68991 RVA: 0x007886D0 File Offset: 0x007868D0
		private void HHGGCBLOJGB()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.IndividualFaces, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)100);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j += 0)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = 0;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D80 RID: 68992 RVA: 0x007888B4 File Offset: 0x00786AB4
		private void MKNPFMEMOJO()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)98);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -83;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D81 RID: 68993 RVA: 0x00788A98 File Offset: 0x00786C98
		private void Start()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.IndividualFaces, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh(RefreshMask.All);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = 1024;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D82 RID: 68994 RVA: 0x00788C7C File Offset: 0x00786E7C
		private float HPELKCKEKKH(float[] HMKMBNEHLJJ)
		{
			float num = 1275f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D83 RID: 68995 RVA: 0x00788CB8 File Offset: 0x00786EB8
		private float CHGLNPNNCCD(float[] HMKMBNEHLJJ)
		{
			float num = 1805f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D84 RID: 68996 RVA: 0x00788CF4 File Offset: 0x00786EF4
		private void NCALLFHEAGJ()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)116);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -121;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D85 RID: 68997 RVA: 0x00788ED8 File Offset: 0x007870D8
		private void HABONMJNDAL()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 1, FFTWindow.Blackman);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.IGJEFDEFACE(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1371f * (this.frequencyCurve.Evaluate(num) * 696f + 632f)) * this.extrusion;
				foreach (int num3 in this.CMIMFOLKCHH[i].NFEODOODKDI)
				{
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < -55; k += 0)
			{
				int num4 = (k < 170) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 817f * 301f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 529f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 528f * 1316f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 948f * this.waveformHeight);
				zero.y = 1372f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 681f) * 1005f;
				eulerAngles.y = Mathf.PerlinNoise(647f, Time.time * this.waveformSpeed) * 537f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 195);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, 104);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D86 RID: 68998 RVA: 0x007891BC File Offset: 0x007873BC
		private void BEDAJLJFAFO()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, FFTWindow.Triangle);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 1);
			this.APDEFPFGNKK = this.NOKIFIEMPKI(this.DNHBPGOKLKD);
			for (int i = 1; i < this.CMIMFOLKCHH.Length; i += 0)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 1069f * (this.frequencyCurve.Evaluate(num) * 355f + 390f)) * this.extrusion;
				int[] nfeodoodkdi = this.CMIMFOLKCHH[i].NFEODOODKDI;
				for (int j = 1; j < nfeodoodkdi.Length; j++)
				{
					int num3 = nfeodoodkdi[j];
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 1; k < 176; k++)
			{
				int num4 = (k < 176) ? k : 1;
				zero.x = Mathf.Cos((float)num4 / 1329f * 123f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1205f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 386f * 1564f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 1488f * this.waveformHeight);
				zero.y = 135f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 235f) * 87f;
				eulerAngles.y = Mathf.PerlinNoise(467f, Time.time * this.waveformSpeed) * 382f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 38);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, -173);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D87 RID: 68999 RVA: 0x007894A0 File Offset: 0x007876A0
		private float GEDKLEMOEJB(float[] HMKMBNEHLJJ)
		{
			float num = 0f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D88 RID: 69000 RVA: 0x007894DC File Offset: 0x007876DC
		private float KADPGGCGNPL(float[] HMKMBNEHLJJ)
		{
			float num = 277f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D89 RID: 69001 RVA: 0x00789518 File Offset: 0x00787718
		private void CBLGFOFHNPJ()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.IndividualFaces, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)(-106));
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -120;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D8A RID: 69002 RVA: 0x007896FC File Offset: 0x007878FC
		private void INDGOHJGCFN()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.IndividualFaces, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)(-37));
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j += 0)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = -68;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D8B RID: 69003 RVA: 0x007898E0 File Offset: 0x00787AE0
		private float DBCEMAIJLAL(float[] HMKMBNEHLJJ)
		{
			float num = 1300f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D8C RID: 69004 RVA: 0x0078991C File Offset: 0x00787B1C
		private void Update()
		{
			this.HPKAFBDCFNP.GetSpectrumData(this.EPMMKFDKDPA, 0, FFTWindow.BlackmanHarris);
			this.HPKAFBDCFNP.GetOutputData(this.DNHBPGOKLKD, 0);
			this.APDEFPFGNKK = this.GEDKLEMOEJB(this.DNHBPGOKLKD);
			for (int i = 0; i < this.CMIMFOLKCHH.Length; i++)
			{
				float num = (float)i / this.PBMAODDHBJM;
				int num2 = (int)(num * (float)this.fftBounds);
				Vector3 b = this.CMIMFOLKCHH[i].BLGBLJHNGJJ * ((this.EPMMKFDKDPA[num2] + this.BIFHCAPEIAC[num2]) * 0.5f * (this.frequencyCurve.Evaluate(num) * 0.5f + 0.5f)) * this.extrusion;
				foreach (int num3 in this.CMIMFOLKCHH[i].NFEODOODKDI)
				{
					this.BNNOOGMJBIM[num3] = this.EDGIMMJMLAL[num3] + b;
				}
			}
			Vector3 zero = Vector3.zero;
			for (int k = 0; k < 1024; k++)
			{
				int num4 = (k < 1023) ? k : 0;
				zero.x = Mathf.Cos((float)num4 / 1024f * 6.283185f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 0.5f * this.waveformHeight);
				zero.z = Mathf.Sin((float)num4 / 1024f * 6.283185f) * (this.waveformRadius + (this.DNHBPGOKLKD[num4] + this.PPCJEHPELHB[num4]) * 0.5f * this.waveformHeight);
				zero.y = 0f;
				this.waveform.SetPosition(k, zero);
			}
			if (this.rotateWaveformRing)
			{
				Vector3 eulerAngles = this.waveform.transform.localRotation.eulerAngles;
				eulerAngles.x = Mathf.PerlinNoise(Time.time * this.waveformSpeed, 0f) * 360f;
				eulerAngles.y = Mathf.PerlinNoise(0f, Time.time * this.waveformSpeed) * 360f;
				this.waveform.transform.localRotation = Quaternion.Euler(eulerAngles);
			}
			this.LHPHPJKAJAB.y = -this.verticalBounce + (this.APDEFPFGNKK + this.FKOLHGICMIM) * this.verticalBounce;
			this.BABHCKGPPFF.position = this.LHPHPJKAJAB;
			Array.Copy(this.EPMMKFDKDPA, this.BIFHCAPEIAC, 4096);
			Array.Copy(this.DNHBPGOKLKD, this.PPCJEHPELHB, 1024);
			this.FKOLHGICMIM = this.APDEFPFGNKK;
			this.AKBCKBFAJHC.vertices = this.BNNOOGMJBIM;
		}

		// Token: 0x06010D8D RID: 69005 RVA: 0x00789C00 File Offset: 0x00787E00
		private float FJJCFKLPIEK(float[] HMKMBNEHLJJ)
		{
			float num = 1114f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 0;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3++;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D8F RID: 69007 RVA: 0x00789CF8 File Offset: 0x00787EF8
		private void DGEIACONKCJ()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(false);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)186);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 1; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = 196;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x06010D90 RID: 69008 RVA: 0x00789EDC File Offset: 0x007880DC
		private float DDBBCKLEMGB(float[] HMKMBNEHLJJ)
		{
			float num = 358f;
			float num2 = (float)HMKMBNEHLJJ.Length;
			int num3 = 1;
			while ((float)num3 < num2)
			{
				num += Mathf.Abs(HMKMBNEHLJJ[num3]);
				num3 += 0;
			}
			return Mathf.Sqrt(num / num2);
		}

		// Token: 0x06010D91 RID: 69009 RVA: 0x00789F18 File Offset: 0x00788118
		private void HDFCIACDDEK()
		{
			this.HPKAFBDCFNP = base.GetComponent<AudioSource>();
			if (this.HPKAFBDCFNP.clip == null)
			{
				this.missingClipWarning.SetActive(true);
			}
			this.PJKDBLILEJB = pb_ShapeGenerator.IcosahedronGenerator(this.icoRadius, this.icoSubdivisions);
			pb_Face[] faces = this.PJKDBLILEJB.faces;
			pb_Face[] array = faces;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].material = this.material;
			}
			this.PJKDBLILEJB.Extrude(faces, ExtrudeMethod.VertexNormal, this.startingExtrusion);
			this.PJKDBLILEJB.ToMesh();
			this.PJKDBLILEJB.Refresh((RefreshMask)64);
			this.CMIMFOLKCHH = new IcoBumpin.EHIMEGBBGNA[faces.Length];
			Dictionary<int, int> lookup = this.PJKDBLILEJB.sharedIndices.ToDictionary();
			for (int j = 0; j < faces.Length; j++)
			{
				this.CMIMFOLKCHH[j] = new IcoBumpin.EHIMEGBBGNA(faces[j], pb_Math.Normal(this.PJKDBLILEJB, faces[j]), this.PJKDBLILEJB.sharedIndices.AllIndicesWithValues(lookup, faces[j].distinctIndices).ToArray<int>());
			}
			this.EDGIMMJMLAL = new Vector3[this.PJKDBLILEJB.vertices.Length];
			Array.Copy(this.PJKDBLILEJB.vertices, this.EDGIMMJMLAL, this.PJKDBLILEJB.vertices.Length);
			this.BNNOOGMJBIM = this.PJKDBLILEJB.vertices;
			this.AKBCKBFAJHC = this.PJKDBLILEJB.msh;
			this.BABHCKGPPFF = this.PJKDBLILEJB.transform;
			this.PBMAODDHBJM = (float)this.CMIMFOLKCHH.Length;
			this.LHPHPJKAJAB = this.BABHCKGPPFF.position;
			this.waveform.positionCount = 130;
			if (this.bounceWaveform)
			{
				this.waveform.transform.parent = this.BABHCKGPPFF;
			}
			this.HPKAFBDCFNP.Play();
		}

		// Token: 0x0400231C RID: 8988
		private pb_Object PJKDBLILEJB;

		// Token: 0x0400231D RID: 8989
		private Mesh AKBCKBFAJHC;

		// Token: 0x0400231E RID: 8990
		private Transform BABHCKGPPFF;

		// Token: 0x0400231F RID: 8991
		private AudioSource HPKAFBDCFNP;

		// Token: 0x04002320 RID: 8992
		private IcoBumpin.EHIMEGBBGNA[] CMIMFOLKCHH;

		// Token: 0x04002321 RID: 8993
		private Vector3[] EDGIMMJMLAL;

		// Token: 0x04002322 RID: 8994
		private Vector3[] BNNOOGMJBIM;

		// Token: 0x04002323 RID: 8995
		[Range(1f, 10f)]
		public float icoRadius = 2f;

		// Token: 0x04002324 RID: 8996
		[Range(0f, 3f)]
		public int icoSubdivisions = 2;

		// Token: 0x04002325 RID: 8997
		[Range(0f, 1f)]
		public float startingExtrusion = 0.1f;

		// Token: 0x04002326 RID: 8998
		public Material material;

		// Token: 0x04002327 RID: 8999
		[Range(1f, 50f)]
		public float extrusion = 30f;

		// Token: 0x04002328 RID: 9000
		[Range(8f, 128f)]
		public int fftBounds = 32;

		// Token: 0x04002329 RID: 9001
		[Range(0f, 10f)]
		public float verticalBounce = 4f;

		// Token: 0x0400232A RID: 9002
		public AnimationCurve frequencyCurve;

		// Token: 0x0400232B RID: 9003
		public LineRenderer waveform;

		// Token: 0x0400232C RID: 9004
		public float waveformHeight = 2f;

		// Token: 0x0400232D RID: 9005
		public float waveformRadius = 20f;

		// Token: 0x0400232E RID: 9006
		public float waveformSpeed = 0.1f;

		// Token: 0x0400232F RID: 9007
		public bool rotateWaveformRing;

		// Token: 0x04002330 RID: 9008
		public bool bounceWaveform;

		// Token: 0x04002331 RID: 9009
		public GameObject missingClipWarning;

		// Token: 0x04002332 RID: 9010
		private Vector3 LHPHPJKAJAB = Vector3.zero;

		// Token: 0x04002333 RID: 9011
		private float PBMAODDHBJM;

		// Token: 0x04002334 RID: 9012
		private const float MFEDKJIAPIO = 6.283185f;

		// Token: 0x04002335 RID: 9013
		private const int HBAAENANMCD = 1024;

		// Token: 0x04002336 RID: 9014
		private const int LCBAOJBHIHF = 4096;

		// Token: 0x04002337 RID: 9015
		private float[] EPMMKFDKDPA = new float[4096];

		// Token: 0x04002338 RID: 9016
		private float[] BIFHCAPEIAC = new float[4096];

		// Token: 0x04002339 RID: 9017
		private float[] DNHBPGOKLKD = new float[1024];

		// Token: 0x0400233A RID: 9018
		private float[] PPCJEHPELHB = new float[1024];

		// Token: 0x0400233B RID: 9019
		private float APDEFPFGNKK;

		// Token: 0x0400233C RID: 9020
		private float FKOLHGICMIM;

		// Token: 0x020004D9 RID: 1241
		private struct EHIMEGBBGNA
		{
			// Token: 0x06010D92 RID: 69010 RVA: 0x0078A0FC File Offset: 0x007882FC
			public EHIMEGBBGNA(pb_Face CCAIMGAFFLD, Vector3 BICDCKJBJLP, int[] LMGJKOMFCFC)
			{
				this.LEBPNFGNEBI = CCAIMGAFFLD;
				this.BLGBLJHNGJJ = BICDCKJBJLP;
				this.NFEODOODKDI = LMGJKOMFCFC;
			}

			// Token: 0x0400233D RID: 9021
			public pb_Face LEBPNFGNEBI;

			// Token: 0x0400233E RID: 9022
			public Vector3 BLGBLJHNGJJ;

			// Token: 0x0400233F RID: 9023
			public int[] NFEODOODKDI;
		}
	}
}
