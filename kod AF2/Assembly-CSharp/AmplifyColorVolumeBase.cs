using System;
using AmplifyColor;
using UnityEngine;

// Token: 0x0200001B RID: 27
[AddComponentMenu("")]
public class AmplifyColorVolumeBase : MonoBehaviour
{
	// Token: 0x06000482 RID: 1154 RVA: 0x00037AAC File Offset: 0x00035CAC
	private void EFGLJPLCHFD()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "---", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00037B4C File Offset: 0x00035D4C
	private void JGEGPBPCNGH()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 71f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00037BDC File Offset: 0x00035DDC
	private void MLIOJIOLEDD()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "Reset", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00037C7C File Offset: 0x00035E7C
	private void GCDDCLFPHMP()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1582f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00037D0C File Offset: 0x00035F0C
	private void APMMLNFKDOI()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "ElvisLegsLoop", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00037DAC File Offset: 0x00035FAC
	private void JGEEOOIBLLK()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 348f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00037E3C File Offset: 0x0003603C
	private void JMHHGOCOJDI()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1940f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00037ECC File Offset: 0x000360CC
	private void LPJPLBFHBFJ()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "category", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00037F6C File Offset: 0x0003616C
	private void JFEHMGNFCJI()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "_RandomTexture", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x0003800C File Offset: 0x0003620C
	private void BDLEPAINNJG()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1259f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x0003809C File Offset: 0x0003629C
	private void POABHAMOODL()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 120f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x0003812C File Offset: 0x0003632C
	private void LBDKJFMAABD()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 210f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000381BC File Offset: 0x000363BC
	private void FBDGJNEGLFL()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "<color='#20a000'> Требований нет </color>", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x0003825C File Offset: 0x0003645C
	private void GMHPFCFIJBM()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "</color>", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x000382FC File Offset: 0x000364FC
	private void BDHBHOMDEKP()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "Horizontal", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x0003839C File Offset: 0x0003659C
	private void PGANLMGHFPC()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 551f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x0003842C File Offset: 0x0003662C
	private void EAFHDBPBCLC()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "1 Hand Heavy Swing", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x000384CC File Offset: 0x000366CC
	private void KOOGKIDFNOH()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 792f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x0003855C File Offset: 0x0003675C
	private void MOEIJLLMMKB()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 889f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x000385EC File Offset: 0x000367EC
	private void HKEDIBDABJL()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "System.Boolean", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x0003868C File Offset: 0x0003688C
	private void GMIKLNIEBBL()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "SoccerKeeperJump", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x0003872C File Offset: 0x0003692C
	private void BDLHEOIHAGC()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "SoccerPassLight", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x000387CC File Offset: 0x000369CC
	private void PBLFEHDLGIH()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "<color='#000030'>", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x0003886C File Offset: 0x00036A6C
	private void DJBJJBNHGND()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 805f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x000388FC File Offset: 0x00036AFC
	private void LGCKHPFEGNM()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 689f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x0003898C File Offset: 0x00036B8C
	private void OKEPNKLIHCF()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1498f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00038A1C File Offset: 0x00036C1C
	private void FFLGFFNMIDO()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "wpn_bait1", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00038ABC File Offset: 0x00036CBC
	private void CKEMPAMKDBG()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 962f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00038B4C File Offset: 0x00036D4C
	private void DIFAAKNLLML()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1393f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00038BDC File Offset: 0x00036DDC
	private void DBBFBFEOJMO()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 885f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00038C6C File Offset: 0x00036E6C
	private void HKNPOBKFDPC()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "gi_um_5", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00038D0C File Offset: 0x00036F0C
	private void LAKMDMLKDOM()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 559f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00038D9C File Offset: 0x00036F9C
	private void ELPPFIJBDEE()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 997f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00038E2C File Offset: 0x0003702C
	private void OIIEBIKKFJJ()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "_SoftZDistance", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00038ECC File Offset: 0x000370CC
	private void HKPALJNKAJA()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 815f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00038F5C File Offset: 0x0003715C
	private void ILCANFHIPGG()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 575f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00038FEC File Offset: 0x000371EC
	private void DMDDMCHJFPO()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "_Sensitivity", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x0003908C File Offset: 0x0003728C
	private void OKJAOLDGCED()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 508f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x0003911C File Offset: 0x0003731C
	private void FDOONECGOGD()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "button.wav", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x000391BC File Offset: 0x000373BC
	private void FDOOJGGIBDO()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "oldvermsg", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x0003925C File Offset: 0x0003745C
	private void EOAHBGCPKHA()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "SoccerSprint", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x000392FC File Offset: 0x000374FC
	private void KDEBKFLEEBI()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "GRAIN", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x0003939C File Offset: 0x0003759C
	private void MJGFLHJHJCC()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 880f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x0003942C File Offset: 0x0003762C
	private void EDHABNGFLGF()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "post_12", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x000394CC File Offset: 0x000376CC
	private void GNBIEJEDMOA()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 879f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x0003955C File Offset: 0x0003775C
	private void JPEJEPAJNBH()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "wpnlang/wpntypes/type DUBLICATE ", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x000395FC File Offset: 0x000377FC
	private void ABEAADDBHGF()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1659f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x0003968C File Offset: 0x0003788C
	private void EINDDAMBIND()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_limb_i_k.html", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x0003972C File Offset: 0x0003792C
	private void DFLLGKDFPJP()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "bag", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x000397CC File Offset: 0x000379CC
	private void EGEAIHBOHKO()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 950f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x0003985C File Offset: 0x00037A5C
	private void PGPABHJDGOD()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1797f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x000398EC File Offset: 0x00037AEC
	private void CDMMMLKJEAA()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1165f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x0003997C File Offset: 0x00037B7C
	private void AMGGPBPDKLK()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1299f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00039A3C File Offset: 0x00037C3C
	private void LONIIHOJLPM()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 571f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00039ACC File Offset: 0x00037CCC
	private void IBIEHLPOPBA()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "walk", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00039B6C File Offset: 0x00037D6C
	private void FKHOOIMOLMF()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "_WaveScale4", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00039C0C File Offset: 0x00037E0C
	private void JEGAEKMDCGD()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "WATER_EDGEBLEND_ON", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00039CAC File Offset: 0x00037EAC
	private void OBIFKDOIEID()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00039D4C File Offset: 0x00037F4C
	private void DNLGMGAHEAG()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "OfficeSittingLegCross", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00039DEC File Offset: 0x00037FEC
	private void EBHDNEKIOKJ()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "RollerBladeJump", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00039E8C File Offset: 0x0003808C
	private void FOPJAOLMOPH()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "_FogAreaPosition", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00039F2C File Offset: 0x0003812C
	private void HHCLACFFEEJ()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, " rep.repa=", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00039FCC File Offset: 0x000381CC
	private void FKGFBMCJOAJ()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1470f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0003A05C File Offset: 0x0003825C
	private void HGKONIKJJJP()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 399f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0003A0EC File Offset: 0x000382EC
	private void EJKCCLFEKOM()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "\n<color='#{0}'>{1}</color> ", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x0003A18C File Offset: 0x0003838C
	private void JMHOKNALKPJ()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "thumb", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x0003A22C File Offset: 0x0003842C
	private void EBOMBBOHBMK()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x0003A2CC File Offset: 0x000384CC
	private void EIMDEHPKDBL()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "OneHandSwordRun", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x0003A36C File Offset: 0x0003856C
	private void FIPILFMIPJH()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "Block", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x0003A40C File Offset: 0x0003860C
	private void BBOEPAFNDAJ()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1693f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x0003A49C File Offset: 0x0003869C
	private void IIKIMEMCCFN()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "wpn_hook1", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x0003A53C File Offset: 0x0003873C
	private void PEABEDAILHP()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "wpn_rod4", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x0003A5DC File Offset: 0x000387DC
	private void GAPPNCHHCAI()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1646f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x0003A66C File Offset: 0x0003886C
	private void MNIJMLEDKLD()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 691f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x0003A6FC File Offset: 0x000388FC
	private void FBHKHDCEFFO()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1081f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x0003A78C File Offset: 0x0003898C
	private void OnDrawGizmos()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "lut-volume.png", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x0003A82C File Offset: 0x00038A2C
	private void EENHGLBOOCN()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, " iterations for read and write", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x0003A8CC File Offset: 0x00038ACC
	private void NMKNPDJBIIK()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "ingredients", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x0003A96C File Offset: 0x00038B6C
	private void OnDrawGizmosSelected()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 0.2f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x0003A9FC File Offset: 0x00038BFC
	private void ALHINAPDCMI()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "Mouse X", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x0003AA9C File Offset: 0x00038C9C
	private void BNGKJLDIBAA()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "error", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x0003AB3C File Offset: 0x00038D3C
	private void DLFKHFBDLPB()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "SoccerKeeperDiveStrafeFarRight", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x0003ABDC File Offset: 0x00038DDC
	private void EBCPEGLOBAB()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1782f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x0003AC6C File Offset: 0x00038E6C
	private void HKBNKIJJEIG()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1040f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0003ACFC File Offset: 0x00038EFC
	private void MFAEHNKGPDN()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 430f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x0003AD8C File Offset: 0x00038F8C
	private void ECKGFMENAKF()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 86f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0003AE1C File Offset: 0x0003901C
	private void MMEPKEHPGNB()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "ZombieCrawl", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x0003AEBC File Offset: 0x000390BC
	private void HFAJEDGJFHD()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, ",", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x0003AF5C File Offset: 0x0003915C
	private void KIDHDJEBION()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "RenderType", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x0003AFFC File Offset: 0x000391FC
	private void CLGABJAPFGE()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1822f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0003B08C File Offset: 0x0003928C
	private void JLJCDMKEFDD()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "KatanaReadyLow", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0003B12C File Offset: 0x0003932C
	private void GJJJGGDDJGM()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1970f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x0003B1BC File Offset: 0x000393BC
	private void KGLDFKEDLEH()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, " ", true);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x0003B25C File Offset: 0x0003945C
	private void LBANIBHDMMO()
	{
		if (this.ShowInSceneView)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			if (component != null || component2 != null)
			{
				Vector3 center;
				Vector3 size;
				if (component != null)
				{
					center = component.center;
					size = component.size;
				}
				else
				{
					center = component2.offset;
					size = component2.size;
				}
				Gizmos.color = Color.green;
				Gizmos.DrawIcon(base.transform.position, "Eyes", false);
				Gizmos.matrix = base.transform.localToWorldMatrix;
				Gizmos.DrawWireCube(center, size);
			}
		}
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x0003B2FC File Offset: 0x000394FC
	private void LMNGJGPBAGN()
	{
		BoxCollider component = base.GetComponent<BoxCollider>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		if (component != null || component2 != null)
		{
			Color green = Color.green;
			green.a = 1218f;
			Gizmos.color = green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Vector3 center;
			Vector3 size;
			if (component != null)
			{
				center = component.center;
				size = component.size;
			}
			else
			{
				center = component2.offset;
				size = component2.size;
			}
			Gizmos.DrawCube(center, size);
		}
	}

	// Token: 0x040000D2 RID: 210
	public Texture2D LutTexture;

	// Token: 0x040000D3 RID: 211
	public float Exposure = 1f;

	// Token: 0x040000D4 RID: 212
	public float EnterBlendTime = 1f;

	// Token: 0x040000D5 RID: 213
	public int Priority;

	// Token: 0x040000D6 RID: 214
	public bool ShowInSceneView = true;

	// Token: 0x040000D7 RID: 215
	[HideInInspector]
	public VolumeEffectContainer EffectContainer = new VolumeEffectContainer();
}
