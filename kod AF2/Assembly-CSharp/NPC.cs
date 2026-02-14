using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200027E RID: 638
public class NPC : MonoBehaviour
{
	// Token: 0x060094CF RID: 38095 RVA: 0x004298F4 File Offset: 0x00427AF4
	private void DGGMJCMLLED()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.DPNONOCLJJC());
	}

	// Token: 0x060094D0 RID: 38096 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator FAGENBDNPBK()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094D1 RID: 38097 RVA: 0x00429954 File Offset: 0x00427B54
	private void DEGCCLNOEKJ()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(591f, 677f, 957f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 110f);
		}
	}

	// Token: 0x060094D2 RID: 38098 RVA: 0x00429A0C File Offset: 0x00427C0C
	private void KOLCEBEIHKP()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1461f, 325f, 1621f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1732f);
		}
	}

	// Token: 0x060094D3 RID: 38099 RVA: 0x00429AC4 File Offset: 0x00427CC4
	private void PNBGJBMJLFM()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(585f, 184f, 184f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1574f);
		}
	}

	// Token: 0x060094D4 RID: 38100 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator GLKMMNMLJMK()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094D5 RID: 38101 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator AEBPPPKEHHE()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094D6 RID: 38102 RVA: 0x00429B7C File Offset: 0x00427D7C
	private void CKGPEFOKKNL()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.NPCAKEGNBHD() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		}
		base.StartCoroutine(this.PFNFJFAFFPC());
	}

	// Token: 0x060094D7 RID: 38103 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator AMPMKCGIEFL()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094D8 RID: 38104 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator DPNONOCLJJC()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094D9 RID: 38105 RVA: 0x00429BCC File Offset: 0x00427DCC
	private void EKCKBDKEAKO()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(217f, 149f, 1290f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1139f);
		}
	}

	// Token: 0x060094DA RID: 38106 RVA: 0x00429C84 File Offset: 0x00427E84
	private void JIBKGOFOPHJ()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1547f, 230f, 1009f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1730f);
		}
	}

	// Token: 0x060094DB RID: 38107 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator GKALHCMBEHG()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094DC RID: 38108 RVA: 0x00429D3C File Offset: 0x00427F3C
	private void NMMGHFDLNOE()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(766f, 442f, 1661f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1398f);
		}
	}

	// Token: 0x060094DD RID: 38109 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator JGGHNLNMCIF()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094DE RID: 38110 RVA: 0x00429DF4 File Offset: 0x00427FF4
	private void Start()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		}
		base.StartCoroutine(this.ALFPGAOOBBB());
	}

	// Token: 0x060094DF RID: 38111 RVA: 0x00429E44 File Offset: 0x00428044
	private void CGMHGDEKDEP()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PLGADNLAEGN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.ILKKLBNIMMJ());
	}

	// Token: 0x060094E0 RID: 38112 RVA: 0x00429E94 File Offset: 0x00428094
	private void DDEBDCGNCPC()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		}
		base.StartCoroutine(this.DPNONOCLJJC());
	}

	// Token: 0x060094E1 RID: 38113 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator EHJGEONCDBF()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094E2 RID: 38114 RVA: 0x00429EE4 File Offset: 0x004280E4
	private void ADLHNBEDHMJ()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.NPCAKEGNBHD() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		}
		base.StartCoroutine(this.AFGILBAJPMN());
	}

	// Token: 0x060094E4 RID: 38116 RVA: 0x00429F44 File Offset: 0x00428144
	private void OLBDJCFPKFG()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.CHADOJMIDCM());
	}

	// Token: 0x060094E5 RID: 38117 RVA: 0x00429F94 File Offset: 0x00428194
	private void EHDFKHHOHAD()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(321f, 1515f, 392f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 291f);
		}
	}

	// Token: 0x060094E6 RID: 38118 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator BGKJPONKLPN()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094E7 RID: 38119 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator PFNFJFAFFPC()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094E8 RID: 38120 RVA: 0x0042A04C File Offset: 0x0042824C
	private void NCALLFHEAGJ()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.EAJHPOJPPFA() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.HBDFFOAECPK());
	}

	// Token: 0x060094E9 RID: 38121 RVA: 0x0042A09C File Offset: 0x0042829C
	private void GIADAJFBIOP()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		}
		base.StartCoroutine(this.DAEJDAIEIEI());
	}

	// Token: 0x060094EA RID: 38122 RVA: 0x0042A0EC File Offset: 0x004282EC
	private void FECFLBMPAAL()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BPPFAOOCENN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.AEBPPPKEHHE());
	}

	// Token: 0x060094EB RID: 38123 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator KBBGGCNNACL()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094EC RID: 38124 RVA: 0x0042A13C File Offset: 0x0042833C
	private void HCDJABMBDFF()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(657f, 782f, 1359f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1402f);
		}
	}

	// Token: 0x060094ED RID: 38125 RVA: 0x0042A1F4 File Offset: 0x004283F4
	private void DAFJMNMFOON()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(409f, 1847f, 1445f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1509f);
		}
	}

	// Token: 0x060094EE RID: 38126 RVA: 0x0042A2AC File Offset: 0x004284AC
	private void MNAHGMDDHCA()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(275f, 1079f, 744f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1239f);
		}
	}

	// Token: 0x060094EF RID: 38127 RVA: 0x0042A364 File Offset: 0x00428564
	private void IOGAKGCADBL()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1677f, 487f, 1111f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1123f);
		}
	}

	// Token: 0x060094F0 RID: 38128 RVA: 0x0042A419 File Offset: 0x00428619
	private IEnumerator HBDFFOAECPK()
	{
		NPC.LGAAALGIDLJ lgaaalgidlj = new NPC.LGAAALGIDLJ(1);
		lgaaalgidlj.AENJLLPLILM = this;
		return lgaaalgidlj;
	}

	// Token: 0x060094F1 RID: 38129 RVA: 0x0042A428 File Offset: 0x00428628
	private void LACNPNKHCAA()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(144f, 1789f, 189f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 444f);
		}
	}

	// Token: 0x060094F2 RID: 38130 RVA: 0x0042A4E0 File Offset: 0x004286E0
	private void KECMAHFJBCD()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.AOKDJJPECLH());
	}

	// Token: 0x060094F3 RID: 38131 RVA: 0x0042A530 File Offset: 0x00428730
	private void EMFOECIPBIP()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1475f, 680f, 1869f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1429f);
		}
	}

	// Token: 0x060094F4 RID: 38132 RVA: 0x0042A5E8 File Offset: 0x004287E8
	private void NFPFDOEENLA()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1583f, 910f, 1589f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1630f);
		}
	}

	// Token: 0x060094F5 RID: 38133 RVA: 0x0042A419 File Offset: 0x00428619
	private IEnumerator DAEJDAIEIEI()
	{
		NPC.LGAAALGIDLJ lgaaalgidlj = new NPC.LGAAALGIDLJ(1);
		lgaaalgidlj.AENJLLPLILM = this;
		return lgaaalgidlj;
	}

	// Token: 0x060094F6 RID: 38134 RVA: 0x0042A6A0 File Offset: 0x004288A0
	private void DMAOHJDKMNN()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BPPFAOOCENN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.LENLBGPOHLO());
	}

	// Token: 0x060094F7 RID: 38135 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator AFGILBAJPMN()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094F8 RID: 38136 RVA: 0x0042A6F0 File Offset: 0x004288F0
	private void HEMEEOGJDOE()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BPPFAOOCENN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
		}
		base.StartCoroutine(this.ILKKLBNIMMJ());
	}

	// Token: 0x060094F9 RID: 38137 RVA: 0x0042A740 File Offset: 0x00428940
	private void BOAJJAKEMLH()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(260f, 860f, 300f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 404f);
		}
	}

	// Token: 0x060094FA RID: 38138 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator BKFKLJAFAGO()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094FB RID: 38139 RVA: 0x0042A7F8 File Offset: 0x004289F8
	private void JLFBDOPFDDJ()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1003f, 569f, 142f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1057f);
		}
	}

	// Token: 0x060094FC RID: 38140 RVA: 0x0042A8B0 File Offset: 0x00428AB0
	private void AAEFACEGJMB()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1104f, 843f, 777f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1216f);
		}
	}

	// Token: 0x060094FD RID: 38141 RVA: 0x0042A968 File Offset: 0x00428B68
	private void KJJEEMEHGBF()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1538f, 65f, 1473f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 713f);
		}
	}

	// Token: 0x060094FE RID: 38142 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator ALFPGAOOBBB()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060094FF RID: 38143 RVA: 0x0042AA20 File Offset: 0x00428C20
	private void PNJHMJNFPLP()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		}
		base.StartCoroutine(this.HBDFFOAECPK());
	}

	// Token: 0x06009500 RID: 38144 RVA: 0x0042AA70 File Offset: 0x00428C70
	private void PMDPLLIBJAF()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		}
		base.StartCoroutine(this.ONJPBNLEPPF());
	}

	// Token: 0x06009501 RID: 38145 RVA: 0x0042AAC0 File Offset: 0x00428CC0
	private void FPLHODJCJDO()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.ALFPGAOOBBB());
	}

	// Token: 0x06009502 RID: 38146 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator IFMONOCCGAH()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009503 RID: 38147 RVA: 0x0042AB10 File Offset: 0x00428D10
	private void HABONMJNDAL()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1084f, 297f, 1603f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1578f);
		}
	}

	// Token: 0x06009504 RID: 38148 RVA: 0x0042ABC8 File Offset: 0x00428DC8
	private void CHDJGEOFHEE()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.FDADPMILMJD());
	}

	// Token: 0x06009505 RID: 38149 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator CAJOOBJALAL()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009506 RID: 38150 RVA: 0x0042A419 File Offset: 0x00428619
	private IEnumerator ONJPBNLEPPF()
	{
		NPC.LGAAALGIDLJ lgaaalgidlj = new NPC.LGAAALGIDLJ(1);
		lgaaalgidlj.AENJLLPLILM = this;
		return lgaaalgidlj;
	}

	// Token: 0x06009507 RID: 38151 RVA: 0x0042AC18 File Offset: 0x00428E18
	private void KBMKHLDOIKP()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(465f, 320f, 884f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1817f);
		}
	}

	// Token: 0x06009508 RID: 38152 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator OPBGNMHGEPA()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009509 RID: 38153 RVA: 0x0042ACD0 File Offset: 0x00428ED0
	private void Update()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(0f, 180f, 0f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 25f);
		}
	}

	// Token: 0x0600950A RID: 38154 RVA: 0x0042AD88 File Offset: 0x00428F88
	private void BJOICAKCPLI()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1355f, 940f, 857f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 29f);
		}
	}

	// Token: 0x0600950B RID: 38155 RVA: 0x0042AE40 File Offset: 0x00429040
	private void CBBLGEDCJBF()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1716f, 336f, 1831f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1277f);
		}
	}

	// Token: 0x0600950C RID: 38156 RVA: 0x0042AEF8 File Offset: 0x004290F8
	private void OPDCJCFMIPE()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1544f, 1020f, 268f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 982f);
		}
	}

	// Token: 0x0600950D RID: 38157 RVA: 0x0042AFB0 File Offset: 0x004291B0
	private void KJJNMNKPNCH()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BPPFAOOCENN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.LENLBGPOHLO());
	}

	// Token: 0x0600950E RID: 38158 RVA: 0x0042B000 File Offset: 0x00429200
	private void LMMDHJJJNJO()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1345f, 745f, 1084f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 181f);
		}
	}

	// Token: 0x0600950F RID: 38159 RVA: 0x0042B0B8 File Offset: 0x004292B8
	private void KEIILPMCFEO()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
		}
		base.StartCoroutine(this.ILKKLBNIMMJ());
	}

	// Token: 0x06009510 RID: 38160 RVA: 0x0042B108 File Offset: 0x00429308
	private void LFJHDHPJOPE()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(158f, 134f, 826f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 937f);
		}
	}

	// Token: 0x06009511 RID: 38161 RVA: 0x0042B1C0 File Offset: 0x004293C0
	private void OPNPODKLOJK()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PLGADNLAEGN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.BKFKLJAFAGO());
	}

	// Token: 0x06009512 RID: 38162 RVA: 0x0042B210 File Offset: 0x00429410
	private void IIHNDJOIMAH()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BPPFAOOCENN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.MGENPGFPKDN());
	}

	// Token: 0x06009513 RID: 38163 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator AOKDJJPECLH()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009514 RID: 38164 RVA: 0x0042B260 File Offset: 0x00429460
	private void JMNNAPNJDNK()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1693f, 526f, 664f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 135f);
		}
	}

	// Token: 0x06009515 RID: 38165 RVA: 0x0042B318 File Offset: 0x00429518
	private void JIKGIJEHGAP()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1396f, 851f, 908f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1618f);
		}
	}

	// Token: 0x06009516 RID: 38166 RVA: 0x0042B3D0 File Offset: 0x004295D0
	private void EMHGNEMIGII()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1893f, 330f, 1796f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1249f);
		}
	}

	// Token: 0x06009517 RID: 38167 RVA: 0x0042B488 File Offset: 0x00429688
	private void BLMBPFIJJBP()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(220f, 550f, 446f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 588f);
		}
	}

	// Token: 0x06009518 RID: 38168 RVA: 0x0042B540 File Offset: 0x00429740
	private void LMGBKHCHPHO()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(711f, 663f, 651f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 637f);
		}
	}

	// Token: 0x06009519 RID: 38169 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator LENLBGPOHLO()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x0600951A RID: 38170 RVA: 0x0042B5F8 File Offset: 0x004297F8
	private void MCHAAIIHOKD()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.EAJHPOJPPFA() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		}
		base.StartCoroutine(this.DPNONOCLJJC());
	}

	// Token: 0x0600951B RID: 38171 RVA: 0x0042B648 File Offset: 0x00429848
	private void FGJCIEDDFGN()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		}
		base.StartCoroutine(this.CDCKLGNAFFI());
	}

	// Token: 0x0600951C RID: 38172 RVA: 0x0042B698 File Offset: 0x00429898
	private void ELFALPCLKIE()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.AMPMKCGIEFL());
	}

	// Token: 0x0600951D RID: 38173 RVA: 0x0042B6E8 File Offset: 0x004298E8
	private void LDDIGEMBDNF()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1504f, 1003f, 459f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 278f);
		}
	}

	// Token: 0x0600951E RID: 38174 RVA: 0x0042B7A0 File Offset: 0x004299A0
	private void IAAOGAPJDID()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.JKIFIBEPICO() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.AOKDJJPECLH());
	}

	// Token: 0x0600951F RID: 38175 RVA: 0x0042A419 File Offset: 0x00428619
	private IEnumerator OJGJCJEPIBG()
	{
		NPC.LGAAALGIDLJ lgaaalgidlj = new NPC.LGAAALGIDLJ(1);
		lgaaalgidlj.AENJLLPLILM = this;
		return lgaaalgidlj;
	}

	// Token: 0x06009520 RID: 38176 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator JPOBKOPDBPD()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009521 RID: 38177 RVA: 0x0042B7F0 File Offset: 0x004299F0
	private void OFGMIEJKMGC()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PLGADNLAEGN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.JPOBKOPDBPD());
	}

	// Token: 0x06009522 RID: 38178 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator ILKKLBNIMMJ()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009523 RID: 38179 RVA: 0x0042B840 File Offset: 0x00429A40
	private void BEDAJLJFAFO()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1687f, 661f, 1515f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1604f);
		}
	}

	// Token: 0x06009524 RID: 38180 RVA: 0x0042B8F8 File Offset: 0x00429AF8
	private void DKOIOBMMAGN()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1894f, 677f, 1402f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 1133f);
		}
	}

	// Token: 0x06009525 RID: 38181 RVA: 0x0042A419 File Offset: 0x00428619
	private IEnumerator FDADPMILMJD()
	{
		NPC.LGAAALGIDLJ lgaaalgidlj = new NPC.LGAAALGIDLJ(1);
		lgaaalgidlj.AENJLLPLILM = this;
		return lgaaalgidlj;
	}

	// Token: 0x06009526 RID: 38182 RVA: 0x0042B9B0 File Offset: 0x00429BB0
	private void EFJDBBDMPMC()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.CAJOOBJALAL());
	}

	// Token: 0x06009527 RID: 38183 RVA: 0x0042BA00 File Offset: 0x00429C00
	private void KJJBBLDJHPD()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1202f, 214f, 460f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 713f);
		}
	}

	// Token: 0x06009528 RID: 38184 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator LFKFCLMKABJ()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009529 RID: 38185 RVA: 0x0042BAB8 File Offset: 0x00429CB8
	private void KIEIPFFEDHC()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BPPFAOOCENN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
		}
		base.StartCoroutine(this.AEBPPPKEHHE());
	}

	// Token: 0x0600952A RID: 38186 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator CHADOJMIDCM()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x0600952B RID: 38187 RVA: 0x0042BB08 File Offset: 0x00429D08
	private void CKIGGCAHAFD()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		}
		base.StartCoroutine(this.CHADOJMIDCM());
	}

	// Token: 0x0600952C RID: 38188 RVA: 0x0042BB58 File Offset: 0x00429D58
	private void IKHCCAANGOP()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1979f, 204f, 1358f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1656f);
		}
	}

	// Token: 0x0600952D RID: 38189 RVA: 0x0042BC10 File Offset: 0x00429E10
	private void BBFPILBIMKC()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PLGADNLAEGN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.EHJGEONCDBF());
	}

	// Token: 0x0600952E RID: 38190 RVA: 0x0042A419 File Offset: 0x00428619
	private IEnumerator JOCPMDFIBDF()
	{
		NPC.LGAAALGIDLJ lgaaalgidlj = new NPC.LGAAALGIDLJ(1);
		lgaaalgidlj.AENJLLPLILM = this;
		return lgaaalgidlj;
	}

	// Token: 0x0600952F RID: 38191 RVA: 0x0042A419 File Offset: 0x00428619
	private IEnumerator CDCKLGNAFFI()
	{
		NPC.LGAAALGIDLJ lgaaalgidlj = new NPC.LGAAALGIDLJ(1);
		lgaaalgidlj.AENJLLPLILM = this;
		return lgaaalgidlj;
	}

	// Token: 0x06009530 RID: 38192 RVA: 0x0042BC60 File Offset: 0x00429E60
	private void AIILFFCEKKM()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1833f, 454f, 794f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num > 1568f);
		}
	}

	// Token: 0x06009531 RID: 38193 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator MGENPGFPKDN()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009532 RID: 38194 RVA: 0x0042A419 File Offset: 0x00428619
	private IEnumerator FMGFOGCAOII()
	{
		NPC.LGAAALGIDLJ lgaaalgidlj = new NPC.LGAAALGIDLJ(1);
		lgaaalgidlj.AENJLLPLILM = this;
		return lgaaalgidlj;
	}

	// Token: 0x06009533 RID: 38195 RVA: 0x0042BD18 File Offset: 0x00429F18
	private void PFNPOHMMJDN()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.PLGADNLAEGN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		}
		base.StartCoroutine(this.DPNONOCLJJC());
	}

	// Token: 0x06009534 RID: 38196 RVA: 0x0042BD68 File Offset: 0x00429F68
	private void BHFMGBNIAMC()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.EAJHPOJPPFA() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		}
		base.StartCoroutine(this.AFGILBAJPMN());
	}

	// Token: 0x06009535 RID: 38197 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator JLEBLOKBNCK()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009536 RID: 38198 RVA: 0x00429943 File Offset: 0x00427B43
	private IEnumerator NKNIELAMAJG()
	{
		for (;;)
		{
			if (this.EEPNACDOOBF != null)
			{
				this.BLNEBDEOOBD = 2;
				this.CLPBNMHDDLA = false;
				if (this.Icon_QVar.Trim() != "" && this.EEPNACDOOBF.MHIIBKILGBL(this.Icon_QVar) == (long)this.Icon_QVarValue)
				{
					this.BLNEBDEOOBD = 0;
					this.CLPBNMHDDLA = true;
				}
				foreach (Vector2 vector in this.qTaskInteres)
				{
					int pcpmjedbdko = Mathf.RoundToInt(vector.x);
					int jookailkhkb = Mathf.RoundToInt(vector.y);
					if (this.EEPNACDOOBF.OIKOCJOOPDP.JFLEPMJFHDA(pcpmjedbdko, jookailkhkb))
					{
						this.BLNEBDEOOBD = 1;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				foreach (Vector2 vector2 in this.qWeaponInteres)
				{
					int lffgphdlpme = Mathf.RoundToInt(vector2.x);
					int num = Mathf.RoundToInt(vector2.y);
					if (this.EEPNACDOOBF.BJDIEKNHGLJ(lffgphdlpme, false, 0) >= num)
					{
						this.BLNEBDEOOBD = 3;
						this.CLPBNMHDDLA = true;
						break;
					}
				}
				if (this.showQIcon && this.icon != null)
				{
					this.icon.SetActive(this.CLPBNMHDDLA);
				}
				if (this.npc_icon != null)
				{
					this.npc_icon.texture = GameInterface.getI.npcIcons[this.BLNEBDEOOBD];
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06009537 RID: 38199 RVA: 0x0042BDB8 File Offset: 0x00429FB8
	private void MIFLHGMPLJD()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1267f, 1769f, 1625f);
			float num = Vector3.Distance(base.transform.position, Camera.main.transform.position);
			this.canvas.gameObject.SetActive(num <= 167f);
		}
	}

	// Token: 0x06009538 RID: 38200 RVA: 0x0042BE70 File Offset: 0x0042A070
	private void FCCAIANLEFE()
	{
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
		}
		if (JBEHMPDDMME.BPPFAOOCENN() != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		}
		base.StartCoroutine(this.JGGHNLNMCIF());
	}

	// Token: 0x0400139E RID: 5022
	public Canvas canvas;

	// Token: 0x0400139F RID: 5023
	public Text npc_name;

	// Token: 0x040013A0 RID: 5024
	public RawImage npc_icon;

	// Token: 0x040013A1 RID: 5025
	public bool showQIcon;

	// Token: 0x040013A2 RID: 5026
	public string Icon_QVar;

	// Token: 0x040013A3 RID: 5027
	public int Icon_QVarValue;

	// Token: 0x040013A4 RID: 5028
	public GameObject icon;

	// Token: 0x040013A5 RID: 5029
	public List<Vector2> qTaskInteres;

	// Token: 0x040013A6 RID: 5030
	public List<Vector2> qWeaponInteres;

	// Token: 0x040013A7 RID: 5031
	private NEBJANKNJOG EEPNACDOOBF;

	// Token: 0x040013A8 RID: 5032
	private bool CLPBNMHDDLA;

	// Token: 0x040013A9 RID: 5033
	private int BLNEBDEOOBD = 2;
}
