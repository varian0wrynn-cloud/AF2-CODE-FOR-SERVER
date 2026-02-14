using System;
using Ara;
using UnityEngine;

namespace AraSamples
{
	// Token: 0x020005B8 RID: 1464
	[RequireComponent(typeof(AraTrail))]
	public class WallPlayerController : MonoBehaviour
	{
		// Token: 0x060133E3 RID: 78819 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void LPDIHACCGKK()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133E4 RID: 78820 RVA: 0x00842D4C File Offset: 0x00840F4C
		private void DPGECEOMHNM()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-113)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.Question))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)79))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)3))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x060133E5 RID: 78821 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void BHMKAOBHAII()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133E6 RID: 78822 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void OAKCEHBONIP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133E7 RID: 78823 RVA: 0x00842F50 File Offset: 0x00841150
		private void IKHCCAANGOP()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Hash))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey((KeyCode)(-99)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-88)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-51)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x060133E8 RID: 78824 RVA: 0x00843154 File Offset: 0x00841354
		private void OFPGMNGFLNH()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-125)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey(KeyCode.Alpha9))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey(KeyCode.K))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey(KeyCode.LeftParen))
				{
					this.GDILALKKEIL.initialColor = this.colors[7];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x060133E9 RID: 78825 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void CFNLKNOKAGC()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133EA RID: 78826 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void MBKLIKGAKJB()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133EB RID: 78827 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void FDGKKBGHNIN()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133EC RID: 78828 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void PPNOJNBFHAP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133ED RID: 78829 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void FJBJDFDJAMI()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133EE RID: 78830 RVA: 0x00843358 File Offset: 0x00841558
		private void LACNPNKHCAA()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)80))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-104)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey(KeyCode.Alpha7))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)7))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x060133EF RID: 78831 RVA: 0x0084355C File Offset: 0x0084175C
		private void EMHGNEMIGII()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.EmitPoint(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-108)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-55)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-11)))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.Exclaim))
				{
					this.GDILALKKEIL.initialColor = this.colors[3];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x060133F0 RID: 78832 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void IOIJGMFNBMC()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133F1 RID: 78833 RVA: 0x00843760 File Offset: 0x00841960
		private void PFPPDNHLCCA()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-82)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-17)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-102)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)(-6)))
				{
					this.GDILALKKEIL.initialColor = this.colors[7];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x060133F2 RID: 78834 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void PHONLBCOJEG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133F3 RID: 78835 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void HCMHMFHMPHN()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133F4 RID: 78836 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void DPNNENHAGOE()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133F5 RID: 78837 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void MGNGNBMMAAD()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133F6 RID: 78838 RVA: 0x00843964 File Offset: 0x00841B64
		private void JIBKGOFOPHJ()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Alpha5))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey((KeyCode)(-124)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-42)))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)(-27)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x060133F7 RID: 78839 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void HNAEALCDLFJ()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133F8 RID: 78840 RVA: 0x00843B68 File Offset: 0x00841D68
		private void JPHLMNIMDHH()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Clear))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-127)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-48)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)83))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x060133F9 RID: 78841 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void CCPOIOJPKIF()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133FA RID: 78842 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void PFKOLCOAPCN()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133FB RID: 78843 RVA: 0x00843D6C File Offset: 0x00841F6C
		private void FPLNDDMFFKG()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.EmitPoint(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-19)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-124)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-126)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.Alpha7))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x060133FC RID: 78844 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void FKLDKPEDDDM()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x060133FD RID: 78845 RVA: 0x00843F70 File Offset: 0x00842170
		private void HMEAENGBFKC()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)90))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-111)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-73)))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-3)))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x060133FE RID: 78846 RVA: 0x00844174 File Offset: 0x00842374
		private void BNKJNBIDPME()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-56)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.A))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-49)))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.Alpha4))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x060133FF RID: 78847 RVA: 0x00844378 File Offset: 0x00842578
		private void EDANNBFJHIK()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.ECDMCHBFGBN(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-74)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey((KeyCode)(-11)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey(KeyCode.E))
				{
					this.GDILALKKEIL.initialColor = this.colors[3];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)(-82)))
				{
					this.GDILALKKEIL.initialColor = this.colors[2];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013400 RID: 78848 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void GDMEEIBDKLP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013401 RID: 78849 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void BLDELNFCEGB()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013402 RID: 78850 RVA: 0x0084457C File Offset: 0x0084277C
		private void OHKHOAKCENL()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.ECDMCHBFGBN(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)81))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)74))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-93)))
				{
					this.GDILALKKEIL.initialColor = this.colors[3];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.Tilde))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013403 RID: 78851 RVA: 0x00844780 File Offset: 0x00842980
		private void KJJEEMEHGBF()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Alpha1))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.Question))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-56)))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-72)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013404 RID: 78852 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void OGKKCIOKGJE()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013405 RID: 78853 RVA: 0x00844984 File Offset: 0x00842B84
		private void BEDAJLJFAFO()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.EmitPoint(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-94)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.P))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey(KeyCode.Comma))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)(-84)))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013406 RID: 78854 RVA: 0x00844B88 File Offset: 0x00842D88
		private void PFNOEACNHON()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-30)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)5))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey(KeyCode.G))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-33)))
				{
					this.GDILALKKEIL.initialColor = this.colors[2];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013407 RID: 78855 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void ONBJLCJMLJH()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013408 RID: 78856 RVA: 0x00844D8C File Offset: 0x00842F8C
		private void CJHBCHBOLBI()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Minus))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey(KeyCode.Equals))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-15)))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.C))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x06013409 RID: 78857 RVA: 0x00844F90 File Offset: 0x00843190
		private void LBOONMDONCF()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.P))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)69))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-41)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)(-86)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601340A RID: 78858 RVA: 0x00845194 File Offset: 0x00843394
		private void BOAJJAKEMLH()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.ECDMCHBFGBN(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.H))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.Question))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-124)))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.Alpha0))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601340B RID: 78859 RVA: 0x00845398 File Offset: 0x00843598
		private void INKGAFANFIB()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-122)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey((KeyCode)(-90)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-12)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-75)))
				{
					this.GDILALKKEIL.initialColor = this.colors[6];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601340C RID: 78860 RVA: 0x0084559C File Offset: 0x0084379C
		private void JLFBDOPFDDJ()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.ECDMCHBFGBN(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-104)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.T))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey(KeyCode.None))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.Y))
				{
					this.GDILALKKEIL.initialColor = this.colors[7];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601340D RID: 78861 RVA: 0x008457A0 File Offset: 0x008439A0
		private void HMLNMHOMMNO()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-27)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)15))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-38)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)30))
				{
					this.GDILALKKEIL.initialColor = this.colors[3];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x0601340E RID: 78862 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void AEJLGHDKHHE()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x0601340F RID: 78863 RVA: 0x008459A4 File Offset: 0x00843BA4
		private void Update()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.EmitPoint(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.W))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.S))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey(KeyCode.A))
				{
					this.GDILALKKEIL.initialColor = this.colors[2];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey(KeyCode.D))
				{
					this.GDILALKKEIL.initialColor = this.colors[3];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013410 RID: 78864 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void DKBGMIPBHNM()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013411 RID: 78865 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void OBGHAEMCKCP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013412 RID: 78866 RVA: 0x00845BA8 File Offset: 0x00843DA8
		private void HABONMJNDAL()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.EmitPoint(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-101)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-47)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-94)))
				{
					this.GDILALKKEIL.initialColor = this.colors[7];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-99)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013413 RID: 78867 RVA: 0x00845DAC File Offset: 0x00843FAC
		private void FJEEADNCKAG()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Semicolon))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey(KeyCode.K))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-4)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.RightCurlyBracket))
				{
					this.GDILALKKEIL.initialColor = this.colors[3];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x06013414 RID: 78868 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void ENJFBODNKHO()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013415 RID: 78869 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void NLMBBNDHPLJ()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013416 RID: 78870 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void Awake()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013417 RID: 78871 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void CNKLGMCHEBM()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013418 RID: 78872 RVA: 0x00845FB0 File Offset: 0x008441B0
		private void FKHAKIKPFFO()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.ECDMCHBFGBN(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-115)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey((KeyCode)65))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)29))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)70))
				{
					this.GDILALKKEIL.initialColor = this.colors[6];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013419 RID: 78873 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void GAOCGDLONBN()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x0601341A RID: 78874 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void EEININLNBKJ()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x0601341B RID: 78875 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void BHPGDKJHKKG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x0601341C RID: 78876 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void DJIFJMEEBKA()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x0601341D RID: 78877 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void JIGAFDHOFKL()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x0601341E RID: 78878 RVA: 0x008461B4 File Offset: 0x008443B4
		private void PGIHAIPCJLL()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.ECDMCHBFGBN(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-73)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-2)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-68)))
				{
					this.GDILALKKEIL.initialColor = this.colors[6];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-25)))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601341F RID: 78879 RVA: 0x008463B8 File Offset: 0x008445B8
		private void LMMDHJJJNJO()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Ampersand))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)76))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey(KeyCode.Escape))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey(KeyCode.LeftBracket))
				{
					this.GDILALKKEIL.initialColor = this.colors[7];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013420 RID: 78880 RVA: 0x008465BC File Offset: 0x008447BC
		private void JIKGIJEHGAP()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-92)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey((KeyCode)10))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-18)))
				{
					this.GDILALKKEIL.initialColor = this.colors[2];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)(-14)))
				{
					this.GDILALKKEIL.initialColor = this.colors[3];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x06013421 RID: 78881 RVA: 0x008467C0 File Offset: 0x008449C0
		private void FOHLAIIMNFB()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.ECDMCHBFGBN(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-106)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)28))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC--;
				}
				else if (Input.GetKey((KeyCode)(-118)))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)(-31)))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x06013422 RID: 78882 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void KKBJCEMFEEI()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013424 RID: 78884 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void JIIBCGJJLND()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013425 RID: 78885 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void KKFKFGPMCND()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013426 RID: 78886 RVA: 0x008469F4 File Offset: 0x00844BF4
		private void PNBGJBMJLFM()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)83))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.Alpha1))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-74)))
				{
					this.GDILALKKEIL.initialColor = this.colors[6];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey(KeyCode.Y))
				{
					this.GDILALKKEIL.initialColor = this.colors[2];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(1, num2);
			}
		}

		// Token: 0x06013427 RID: 78887 RVA: 0x00846BF8 File Offset: 0x00844DF8
		private void AAEFACEGJMB()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[1];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-55)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)78))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-33)))
				{
					this.GDILALKKEIL.initialColor = this.colors[5];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)75))
				{
					this.GDILALKKEIL.initialColor = this.colors[7];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x06013428 RID: 78888 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void BBEIKJGNAAA()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x06013429 RID: 78889 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void NKHMBEDDFAJ()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x0601342A RID: 78890 RVA: 0x00846DFC File Offset: 0x00844FFC
		private void GPCKACGEILI()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.EmitPoint(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Alpha0))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.B))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey(KeyCode.Quote))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-101)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.EmitPoint(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601342B RID: 78891 RVA: 0x00847000 File Offset: 0x00845200
		private void IOGAKGCADBL()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-27)))
				{
					this.GDILALKKEIL.initialColor = this.colors[1];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey((KeyCode)(-41)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)75))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey(KeyCode.C))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601342C RID: 78892 RVA: 0x00847204 File Offset: 0x00845404
		private void MEFOGCFJBNE()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.GDGGHNEKOJI(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey((KeyCode)(-105)))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey(KeyCode.V))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)85))
				{
					this.GDILALKKEIL.initialColor = this.colors[8];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)(-108)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP -= 0;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(0, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601342D RID: 78893 RVA: 0x00847408 File Offset: 0x00845608
		private void HONIFOPBBKC()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.ECDMCHBFGBN(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.Q))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.FGFEIJPEDKC += 0;
				}
				else if (Input.GetKey(KeyCode.LeftBracket))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-20)))
				{
					this.GDILALKKEIL.initialColor = this.colors[4];
					this.GDILALKKEIL.ECDMCHBFGBN(position);
					this.HGGOPHOAJNP++;
				}
				else if (Input.GetKey((KeyCode)(-88)))
				{
					this.GDILALKKEIL.initialColor = this.colors[7];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 1)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x0601342E RID: 78894 RVA: 0x00842D3E File Offset: 0x00840F3E
		private void OJDLGCFKCEJ()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
		}

		// Token: 0x0601342F RID: 78895 RVA: 0x0084760C File Offset: 0x0084580C
		private void PJHEGHHOJHJ()
		{
			float num = Time.deltaTime * this.speed;
			Vector3 position = base.transform.position;
			Vector3 vector = new Vector3((float)this.FGFEIJPEDKC, position.y, (float)this.HGGOPHOAJNP);
			base.transform.position = Vector3.MoveTowards(position, vector, num);
			if (this.GDILALKKEIL.points.Count == 0)
			{
				this.GDILALKKEIL.initialColor = this.colors[0];
				this.GDILALKKEIL.JBGOMCPHNFL(position);
			}
			if (Vector3.Distance(position, vector) < num)
			{
				base.transform.position = vector;
				if (Input.GetKey(KeyCode.LeftParen))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC++;
				}
				else if (Input.GetKey((KeyCode)26))
				{
					this.GDILALKKEIL.initialColor = this.colors[0];
					this.GDILALKKEIL.EmitPoint(position);
					this.FGFEIJPEDKC -= 0;
				}
				else if (Input.GetKey((KeyCode)(-76)))
				{
					this.GDILALKKEIL.initialColor = this.colors[6];
					this.GDILALKKEIL.JBGOMCPHNFL(position);
					this.HGGOPHOAJNP += 0;
				}
				else if (Input.GetKey((KeyCode)77))
				{
					this.GDILALKKEIL.initialColor = this.colors[7];
					this.GDILALKKEIL.GDGGHNEKOJI(position);
					this.HGGOPHOAJNP--;
				}
				this.FGFEIJPEDKC = Mathf.Clamp(this.FGFEIJPEDKC, -this.boardSize, this.boardSize);
				this.HGGOPHOAJNP = Mathf.Clamp(this.HGGOPHOAJNP, -this.boardSize, this.boardSize);
			}
			int num2 = Mathf.Max(1, this.GDILALKKEIL.points.Count - this.maxTrailLenght);
			if (num2 > 0)
			{
				this.GDILALKKEIL.points.RemoveRange(0, num2);
			}
		}

		// Token: 0x04002778 RID: 10104
		public float speed = 10f;

		// Token: 0x04002779 RID: 10105
		public int boardSize = 5;

		// Token: 0x0400277A RID: 10106
		public int maxTrailLenght = 10;

		// Token: 0x0400277B RID: 10107
		public Color[] colors = new Color[4];

		// Token: 0x0400277C RID: 10108
		private int FGFEIJPEDKC;

		// Token: 0x0400277D RID: 10109
		private int HGGOPHOAJNP;

		// Token: 0x0400277E RID: 10110
		private AraTrail GDILALKKEIL;
	}
}
