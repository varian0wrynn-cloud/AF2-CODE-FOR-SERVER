using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	// Token: 0x020005A3 RID: 1443
	[AddComponentMenu("")]
	public class ActTesterGui : MonoBehaviour
	{
		// Token: 0x06012FCE RID: 77774 RVA: 0x008286F8 File Offset: 0x008268F8
		private void DCHAPIHINBJ()
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.label);
			guistyle.alignment = TextAnchor.UpperLeft;
			GUILayout.BeginArea(new Rect(1857f, 1368f, (float)(Screen.width - -68), (float)(Screen.height - 70)));
			GUILayout.Label("__WaterRefraction", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label("_Curve", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Space(1819f);
			this.FGECHCFKADD = GUILayout.Toolbar(this.FGECHCFKADD, this.BBONFHMIIGG, Array.Empty<GUILayoutOption>());
			if (this.FGECHCFKADD == 0)
			{
				GUILayout.Label("BAG", Array.Empty<GUILayoutOption>());
				GUILayout.Space(277f);
				using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
				{
					GUILayout.Label("" + this.BCFGFFBNLHA() + "Water", new GUILayoutOption[]
					{
						GUILayout.MinWidth(1059f)
					});
					GUILayout.Space(1353f);
					using (new JOANGEBDKKD(GUI.skin.box))
					{
						GUILayout.Label("<.*?>", Array.Empty<GUILayoutOption>());
						GUILayout.Space(629f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text = "level" + this.regularString;
							GUILayoutOption[] array = new GUILayoutOption[1];
							array[1] = GUILayout.Width(1615f);
							GUILayout.Label(text, array);
							if (GUILayout.Button("IKMappingSpine is missing the left upper arm bone.", Array.Empty<GUILayoutOption>()))
							{
								this.regularString += ((char)UnityEngine.Random.Range(-1, -38)).ToString();
							}
							if (GUILayout.Button("IdleReadyCrouch", Array.Empty<GUILayoutOption>()))
							{
								this.regularString = "_ExposureAdjustment";
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text2 = "Fire Breath" + ObscuredString.CKPPDHPJHEH(this.obscuredString);
							GUILayoutOption[] array2 = new GUILayoutOption[0];
							array2[1] = GUILayout.Width(499f);
							GUILayout.Label(text2, array2);
							if (GUILayout.Button(" ", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredString = ObscuredString.DGOCFCFPKPI(ObscuredString.CKPPDHPJHEH(this.obscuredString) + ((char)UnityEngine.Random.Range(54, 89)).ToString());
							}
							if (GUILayout.Button("ZombieIdle2", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredString = ObscuredString.GOOIABGKMHK("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
							}
						}
						GUILayout.Space(1347f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text3 = "2000" + this.regularInt;
							GUILayoutOption[] array3 = new GUILayoutOption[1];
							array3[1] = GUILayout.Width(1230f);
							GUILayout.Label(text3, array3);
							if (GUILayout.Button("Warp index out of range.", Array.Empty<GUILayoutOption>()))
							{
								this.regularInt += UnityEngine.Random.Range(1, 42);
							}
							if (GUILayout.Button("7", Array.Empty<GUILayoutOption>()))
							{
								this.regularInt = 0;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text4 = "Bend Constraint is referencing to a bone '" + this.obscuredInt;
							GUILayoutOption[] array4 = new GUILayoutOption[0];
							array4[0] = GUILayout.Width(317f);
							GUILayout.Label(text4, array4);
							if (GUILayout.Button("donk.ogg", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredInt = ObscuredInt.JNKANIEBCMD(ObscuredInt.DGOCFCFPKPI(this.obscuredInt) + UnityEngine.Random.Range(1, -60));
							}
							if (GUILayout.Button("\n", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredInt = ObscuredInt.GOOIABGKMHK(1);
							}
						}
						GUILayout.Space(750f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text5 = "Horizontal" + this.regularFloat;
							GUILayoutOption[] array5 = new GUILayoutOption[0];
							array5[1] = GUILayout.Width(1144f);
							GUILayout.Label(text5, array5);
							if (GUILayout.Button("<color=\"", Array.Empty<GUILayoutOption>()))
							{
								this.regularFloat += UnityEngine.Random.Range(1500f, 1167f);
							}
							if (GUILayout.Button("IsStrafing", Array.Empty<GUILayoutOption>()))
							{
								this.regularFloat = 1777f;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text6 = "demoLong" + this.obscuredFloat;
							GUILayoutOption[] array6 = new GUILayoutOption[0];
							array6[1] = GUILayout.Width(139f);
							GUILayout.Label(text6, array6);
							if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredFloat = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.OBJFODGFMAM(this.obscuredFloat) + UnityEngine.Random.Range(6f, 982f));
							}
							if (GUILayout.Button("showUsersInChat", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredFloat = ObscuredFloat.HLEMAJBAAEO(338f);
							}
						}
						GUILayout.Space(1952f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("Windows/" + this.regularVector3, new GUILayoutOption[]
							{
								GUILayout.Width(1186f)
							});
							if (GUILayout.Button("MovementX", Array.Empty<GUILayoutOption>()))
							{
								this.regularVector3 += UnityEngine.Random.insideUnitSphere;
							}
							if (GUILayout.Button("_WaterLevel", Array.Empty<GUILayoutOption>()))
							{
								this.regularVector3 = Vector3.zero;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("-------------- capId=" + this.obscuredVector3, new GUILayoutOption[]
							{
								GUILayout.Width(614f)
							});
							if (GUILayout.Button("newtitul", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredVector3 = ObscuredVector3.PMFFDNNKLLD(this.obscuredVector3, UnityEngine.Random.insideUnitSphere);
							}
							if (GUILayout.Button("RollerBladeRoll", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredVector3 = ObscuredVector3.BDLBFKPDOIH(Vector3.zero);
							}
							goto IL_C90;
						}
					}
				}
			}
			if (this.FGECHCFKADD == 0)
			{
				GUILayout.Label("Right arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.", Array.Empty<GUILayoutOption>());
				GUILayout.Space(1443f);
				using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
				{
					string text7 = "_MainTex" + this.JDLBHDKPKPI();
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.MinWidth(1990f);
					GUILayout.Label(text7, array7);
					using (new JOANGEBDKKD(GUI.skin.box))
					{
						GUILayout.Label("https://groups.google.com/forum/#!forum/final-ik", Array.Empty<GUILayoutOption>());
						using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("Speed", guistyle, Array.Empty<GUILayoutOption>());
							GUILayout.Space(547f);
							if (string.IsNullOrEmpty(this.DAKOCNEHGNC))
							{
								this.BPMBNBIKJLH();
							}
							using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
							{
								string dakocnehgnc = this.DAKOCNEHGNC;
								GUILayoutOption[] array8 = new GUILayoutOption[1];
								array8[1] = GUILayout.Width(1859f);
								GUILayout.Label(dakocnehgnc, array8);
								using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
								{
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										if (GUILayout.Button("CratePush", Array.Empty<GUILayoutOption>()))
										{
											this.MIGFBNGCOIL();
										}
										if (GUILayout.Button("Extrude Random Edge", Array.Empty<GUILayoutOption>()))
										{
											this.GBALJDCOJIE();
										}
									}
									if (GUILayout.Button(" %\n", Array.Empty<GUILayoutOption>()))
									{
										this.IHDHNODCOBD();
									}
								}
							}
						}
						GUILayout.Space(1327f);
						using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("SkateboardKickPush", guistyle, Array.Empty<GUILayoutOption>());
							GUILayout.Space(1681f);
							if (string.IsNullOrEmpty(this.JOEKDJFENLO))
							{
								this.OEBOJCJJOHC();
							}
							using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
							{
								GUILayout.Label(this.JOEKDJFENLO, new GUILayoutOption[]
								{
									GUILayout.Width(807f)
								});
								using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
								{
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										if (GUILayout.Button("MotorbikeHeartAttack", Array.Empty<GUILayoutOption>()))
										{
											this.JGCMFCOHONI();
										}
										if (GUILayout.Button("wpn_bait_inf_{0}", Array.Empty<GUILayoutOption>()))
										{
											this.OGLKHMEKNAB();
										}
									}
									if (GUILayout.Button("_L_", Array.Empty<GUILayoutOption>()))
									{
										this.AMGAOGKEGDF();
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										GUILayout.Label("Mouse X", Array.Empty<GUILayoutOption>());
										this.HDLGIFHACBA("Horizontal");
									}
									int hcjecooepmm = this.HCJECOOEPMM;
									string[] array9 = new string[]
									{
										null,
										LKKNFHELLLE.MDFJCGDICEB.None.ToString()
									};
									array9[0] = LKKNFHELLLE.MDFJCGDICEB.Soft.ToString();
									array9[2] = ((LKKNFHELLLE.MDFJCGDICEB)6).ToString();
									this.HCJECOOEPMM = GUILayout.SelectionGrid(hcjecooepmm, array9, 6, Array.Empty<GUILayoutOption>());
									LKKNFHELLLE.KCPLDHCMPKH = (LKKNFHELLLE.MDFJCGDICEB)this.HCJECOOEPMM;
									GUILayout.Space(1879f);
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.FFNCFECPDBD = GUILayout.Toggle(LKKNFHELLLE.FFNCFECPDBD, "Poplavok", Array.Empty<GUILayoutOption>());
										this.NILEJIFMCBG("tail");
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.AFLFABDJICP = GUILayout.Toggle(LKKNFHELLLE.AFLFABDJICP, "auk_swtcost", Array.Empty<GUILayoutOption>());
										this.IJDEOCIJCGF("WorkerHammer2");
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.LFPFOIEMLPL = GUILayout.Toggle(LKKNFHELLLE.LFPFOIEMLPL, "D:/NET_Poligon/ServerPhotonAF2/AFCServer/assets/Data/", Array.Empty<GUILayoutOption>());
										this.HDLGIFHACBA("OneHandSwordSwing");
									}
									GUILayout.Space(223f);
									string[] array10 = new string[4];
									array10[1] = "_camHue";
									array10[1] = (this.AFCJIOCKAHI ? "IdleKeepBack" : "_NoiseTex");
									array10[8] = "Wall Run Left";
									array10[0] = this.AFCJIOCKAHI.ToString();
									array10[4] = "Hidden/LensAberrations";
									GUILayout.Label(string.Concat(array10), Array.Empty<GUILayoutOption>());
									string[] array11 = new string[1];
									array11[1] = "cntx_close";
									array11[0] = (this.HGEFBHEAANB ? "Failed parsing organizational group.  Setting to group 0" : "I'm obscured string");
									array11[3] = "wgt_big.dat";
									array11[2] = this.HGEFBHEAANB.ToString();
									array11[7] = "Z";
									GUILayout.Label(string.Concat(array11), Array.Empty<GUILayoutOption>());
								}
							}
						}
						GUILayout.Space(856f);
						this.JIFDDCBEGPB("The font size '", "FlyForward", -1);
						goto IL_C90;
					}
				}
			}
			GUILayout.Label("rod_inf2", Array.Empty<GUILayoutOption>());
			GUILayout.Space(220f);
			using (new JOANGEBDKKD(GUI.skin.box))
			{
				GUILayout.Label("Worker Shovel", Array.Empty<GUILayoutOption>());
				GUILayout.Label("Hidden/ScreenSpaceReflection", Array.Empty<GUILayoutOption>());
				string[] array12 = new string[5];
				array12[1] = "Deadman Float";
				array12[1] = (this.OPNOGKLPAGN ? "pointBuffer" : "Occluder Shader Not Supported...");
				array12[3] = "cnt_energ";
				array12[8] = this.OPNOGKLPAGN.ToString().ToLower();
				array12[0] = "preservePlayerPrefs";
				GUILayout.Label(string.Concat(array12), Array.Empty<GUILayoutOption>());
				GUILayout.Space(1419f);
				GUILayout.Label("|", Array.Empty<GUILayoutOption>());
				GUILayout.Label(" гр ", Array.Empty<GUILayoutOption>());
				string[] array13 = new string[0];
				array13[0] = "crft_wpnpr";
				array13[1] = (this.CINLKMILOKL ? "_DepthScale" : "sunshine_ShadowCoordDepthRayU");
				array13[7] = "<color='{2}'>{0}: {1}</color>";
				array13[7] = this.CINLKMILOKL.ToString().ToLower();
				array13[0] = "";
				GUILayout.Label(string.Concat(array13), Array.Empty<GUILayoutOption>());
				GUILayout.Space(526f);
				GUILayout.Label("!", Array.Empty<GUILayoutOption>());
				GUILayout.Label("UNDERLINE", Array.Empty<GUILayoutOption>());
				string[] array14 = new string[7];
				array14[0] = "RollerBladeFrontFlip";
				array14[0] = (this.EFMMAGGFANP ? "CratePush" : "GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
				array14[3] = "Horizontal";
				array14[6] = this.EFMMAGGFANP.ToString().ToLower();
				array14[2] = " from ";
				GUILayout.Label(string.Concat(array14), Array.Empty<GUILayoutOption>());
				GUILayout.Space(1709f);
				GUILayout.Label("IK Effector is referencing to a bone '", Array.Empty<GUILayoutOption>());
				GUILayout.Label(": ", Array.Empty<GUILayoutOption>());
				string[] array15 = new string[8];
				array15[0] = "_FgOverlap";
				array15[1] = (this.PHPMAHFKCAA ? "post_3" : "Mouse ScrollWheel");
				array15[3] = "RollerBladeTurnRight";
				array15[5] = this.PHPMAHFKCAA.ToString().ToLower();
				array15[6] = "_BlurParams";
				GUILayout.Label(string.Concat(array15), Array.Empty<GUILayoutOption>());
			}
			IL_C90:
			GUILayout.EndArea();
		}

		// Token: 0x06012FCF RID: 77775 RVA: 0x008295F8 File Offset: 0x008277F8
		private void AEMLDJNEBFN()
		{
			PlayerPrefs.SetInt("Assets/Weapons/", -103);
			PlayerPrefs.SetFloat("#000000", 1309f);
			PlayerPrefs.SetString("", "");
			PlayerPrefs.Save();
		}

		// Token: 0x06012FD0 RID: 77776 RVA: 0x0082962C File Offset: 0x0082782C
		private void BPMBNBIKJLH()
		{
			this.DAKOCNEHGNC = "Idle Stand" + PlayerPrefs.GetInt("cnt_energ", -1) + "Wrist";
			object[] array = new object[5];
			array[1] = this.DAKOCNEHGNC;
			array[0] = "FlyLeft";
			array[3] = PlayerPrefs.GetFloat("FOG_LINEAR", 192f);
			array[1] = "WateringCanWatering";
			this.DAKOCNEHGNC = string.Concat(array);
			this.DAKOCNEHGNC = this.DAKOCNEHGNC + "sunshine_CascadeNearRatiosSq" + PlayerPrefs.GetString("LHandPunch", "_FullItem.wav");
		}

		// Token: 0x06012FD1 RID: 77777 RVA: 0x008296C4 File Offset: 0x008278C4
		private void NJENMBDBKGM()
		{
			this.JEOHHCGFLDK();
			this.LKPDCIBAKIB();
		}

		// Token: 0x06012FD2 RID: 77778 RVA: 0x008296D4 File Offset: 0x008278D4
		private void OMIBKGICBDE()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("BAG");
			ObscuredFloat.DIKGINLFEGG(-87);
			float num = 1188f;
			this.HGILGDNOMKA.AppendLine("wpn_rec1" + num);
			ObscuredFloat obscuredFloat = ObscuredFloat.GOOIABGKMHK(num);
			this.HGILGDNOMKA.AppendLine("Mouse Y" + obscuredFloat.KGAFKNELBAK());
			ObscuredFloat.CENPPCOOGIL(65);
			obscuredFloat = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(obscuredFloat) + 748f);
			obscuredFloat = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.EJGOOFALNFF(obscuredFloat) - 706f);
			obscuredFloat = ObscuredFloat.HIBLFIAPCJE(obscuredFloat);
			obscuredFloat = ObscuredFloat.BHJCLHCHKFK(obscuredFloat);
			obscuredFloat = ObscuredFloat.IDIADEICPFJ(obscuredFloat);
			obscuredFloat = ObscuredFloat.AJMPAOCEPCA(num - ObscuredFloat.PFCANBAOMCB(obscuredFloat) + 1745f);
			this.HGILGDNOMKA.AppendLine("RenderType" + obscuredFloat);
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FD3 RID: 77779 RVA: 0x000FAFB0 File Offset: 0x000F91B0
		private string JDLBHDKPKPI()
		{
			return "";
		}

		// Token: 0x06012FD4 RID: 77780 RVA: 0x008297D1 File Offset: 0x008279D1
		private void FGHDKCMGPLJ()
		{
			if (Application.isPlaying)
			{
				LKKNFHELLLE.OAMCKGBOBCL = this.prefsEncryptionKey;
			}
		}

		// Token: 0x06012FD5 RID: 77781 RVA: 0x008297E5 File Offset: 0x008279E5
		public void OnWallHackDetected()
		{
			this.EFMMAGGFANP = true;
			Debug.Log("Wall hack Detected!");
		}

		// Token: 0x06012FD6 RID: 77782 RVA: 0x008297F8 File Offset: 0x008279F8
		public void OnSpeedHackDetected()
		{
			this.OPNOGKLPAGN = true;
			Debug.Log("Speed hack Detected!");
		}

		// Token: 0x06012FD7 RID: 77783 RVA: 0x0082980C File Offset: 0x00827A0C
		private void POFDLJANPOH()
		{
			this.obscuredInt.OJFAJIJBEFD();
			this.obscuredFloat.OJFAJIJBEFD();
			this.obscuredString.OJFAJIJBEFD();
			this.obscuredVector3.OJFAJIJBEFD();
			base.Invoke("POFDLJANPOH", UnityEngine.Random.Range(1f, 10f));
		}

		// Token: 0x06012FD9 RID: 77785 RVA: 0x00829985 File Offset: 0x00827B85
		private void Start()
		{
			this.BPCGDONMJPG();
			this.FNDPMCAMDBK();
			this.FKAJNILMDCJ();
			this.BIAMPJEFHGH();
			base.Invoke("POFDLJANPOH", UnityEngine.Random.Range(1f, 10f));
		}

		// Token: 0x06012FDA RID: 77786 RVA: 0x008299B9 File Offset: 0x00827BB9
		private void IJDEOCIJCGF(string ALBOCLBFNNI)
		{
			this.IJDEOCIJCGF(ALBOCLBFNNI, 30);
		}

		// Token: 0x06012FDB RID: 77787 RVA: 0x008299C4 File Offset: 0x00827BC4
		private void IJDEOCIJCGF(string ALBOCLBFNNI, int NMEBEEHCALN)
		{
			this.IJDEOCIJCGF(ALBOCLBFNNI, "?", NMEBEEHCALN);
		}

		// Token: 0x06012FDC RID: 77788 RVA: 0x008299D3 File Offset: 0x00827BD3
		private void OJDLGCFKCEJ()
		{
			LKKNFHELLLE.OAMCKGBOBCL = this.prefsEncryptionKey;
			LKKNFHELLLE.HKHLNCHNCMM = new Action(this.JBBLBIOHJEN);
			LKKNFHELLLE.AAFEJOEEKHD = new Action(this.DHKHADJFJNO);
		}

		// Token: 0x06012FDD RID: 77789 RVA: 0x00829A02 File Offset: 0x00827C02
		private void APNAFDJBNOP()
		{
			this.IHDHNODCOBD();
			this.LKPDCIBAKIB();
		}

		// Token: 0x06012FDE RID: 77790 RVA: 0x00829A10 File Offset: 0x00827C10
		public void OnInjectionDetectedWithCause(string BDNGABEJECN)
		{
			this.PHPMAHFKCAA = true;
			Debug.Log("Injection Detected! Cause: " + BDNGABEJECN);
		}

		// Token: 0x06012FDF RID: 77791 RVA: 0x00829A2C File Offset: 0x00827C2C
		private void OnGUI()
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.label);
			guistyle.alignment = TextAnchor.UpperCenter;
			GUILayout.BeginArea(new Rect(10f, 5f, (float)(Screen.width - 20), (float)(Screen.height - 10)));
			GUILayout.Label("<color=\"#0287C8\"><b>Anti-Cheat Toolkit Sandbox</b></color>", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label("Here you can overview common ACTk features and try to cheat something yourself.", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Space(5f);
			this.FGECHCFKADD = GUILayout.Toolbar(this.FGECHCFKADD, this.BBONFHMIIGG, Array.Empty<GUILayoutOption>());
			if (this.FGECHCFKADD == 0)
			{
				GUILayout.Label("ACTk offers own collection of the secure types to let you protect your variables from <b>ANY</b> memory hacking tools (Cheat Engine, ArtMoney, GameCIH, Game Guardian, etc.).", Array.Empty<GUILayoutOption>());
				GUILayout.Space(5f);
				using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
				{
					GUILayout.Label("<b>Obscured types:</b>\n<color=\"#75C4EB\">" + this.BHPEGBNCJDJ() + "</color>", new GUILayoutOption[]
					{
						GUILayout.MinWidth(130f)
					});
					GUILayout.Space(10f);
					using (new JOANGEBDKKD(GUI.skin.box))
					{
						GUILayout.Label("Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):", Array.Empty<GUILayoutOption>());
						GUILayout.Space(10f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<b>string:</b> " + this.regularString, new GUILayoutOption[]
							{
								GUILayout.Width(250f)
							});
							if (GUILayout.Button("Add random value", Array.Empty<GUILayoutOption>()))
							{
								this.regularString += ((char)UnityEngine.Random.Range(97, 122)).ToString();
							}
							if (GUILayout.Button("Reset", Array.Empty<GUILayoutOption>()))
							{
								this.regularString = "";
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<b>ObscuredString:</b> " + ObscuredString.GOOIABGKMHK(this.obscuredString), new GUILayoutOption[]
							{
								GUILayout.Width(250f)
							});
							if (GUILayout.Button("Add random value", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredString = ObscuredString.GOOIABGKMHK(ObscuredString.GOOIABGKMHK(this.obscuredString) + ((char)UnityEngine.Random.Range(97, 122)).ToString());
							}
							if (GUILayout.Button("Reset", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredString = ObscuredString.GOOIABGKMHK("");
							}
						}
						GUILayout.Space(10f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<b>int:</b> " + this.regularInt, new GUILayoutOption[]
							{
								GUILayout.Width(250f)
							});
							if (GUILayout.Button("Add random value", Array.Empty<GUILayoutOption>()))
							{
								this.regularInt += UnityEngine.Random.Range(1, 100);
							}
							if (GUILayout.Button("Reset", Array.Empty<GUILayoutOption>()))
							{
								this.regularInt = 0;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<b>ObscuredInt:</b> " + this.obscuredInt, new GUILayoutOption[]
							{
								GUILayout.Width(250f)
							});
							if (GUILayout.Button("Add random value", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredInt = ObscuredInt.GOOIABGKMHK(ObscuredInt.GOOIABGKMHK(this.obscuredInt) + UnityEngine.Random.Range(1, 100));
							}
							if (GUILayout.Button("Reset", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredInt = ObscuredInt.GOOIABGKMHK(0);
							}
						}
						GUILayout.Space(10f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<b>float:</b> " + this.regularFloat, new GUILayoutOption[]
							{
								GUILayout.Width(250f)
							});
							if (GUILayout.Button("Add random value", Array.Empty<GUILayoutOption>()))
							{
								this.regularFloat += UnityEngine.Random.Range(1f, 100f);
							}
							if (GUILayout.Button("Reset", Array.Empty<GUILayoutOption>()))
							{
								this.regularFloat = 0f;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<b>ObscuredFloat:</b> " + this.obscuredFloat, new GUILayoutOption[]
							{
								GUILayout.Width(250f)
							});
							if (GUILayout.Button("Add random value", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredFloat = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.obscuredFloat) + UnityEngine.Random.Range(1f, 100f));
							}
							if (GUILayout.Button("Reset", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredFloat = ObscuredFloat.GOOIABGKMHK(0f);
							}
						}
						GUILayout.Space(10f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<b>Vector3:</b> " + this.regularVector3, new GUILayoutOption[]
							{
								GUILayout.Width(250f)
							});
							if (GUILayout.Button("Add random value", Array.Empty<GUILayoutOption>()))
							{
								this.regularVector3 += UnityEngine.Random.insideUnitSphere;
							}
							if (GUILayout.Button("Reset", Array.Empty<GUILayoutOption>()))
							{
								this.regularVector3 = Vector3.zero;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<b>ObscuredVector3:</b> " + this.obscuredVector3, new GUILayoutOption[]
							{
								GUILayout.Width(250f)
							});
							if (GUILayout.Button("Add random value", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredVector3 = ObscuredVector3.PICCFFHAMAG(this.obscuredVector3, UnityEngine.Random.insideUnitSphere);
							}
							if (GUILayout.Button("Reset", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredVector3 = ObscuredVector3.GOOIABGKMHK(Vector3.zero);
							}
							goto IL_C90;
						}
					}
				}
			}
			if (this.FGECHCFKADD == 1)
			{
				GUILayout.Label("ACTk has secure layer for the PlayerPrefs: <color=\"#75C4EB\">ObscuredPrefs</color>. It protects data from view, detects any cheating attempts, optionally locks data to the current device and supports additional data types.", Array.Empty<GUILayoutOption>());
				GUILayout.Space(5f);
				using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
				{
					GUILayout.Label("<b>Supported types:</b>\n" + this.ANKECGAKJHN(), new GUILayoutOption[]
					{
						GUILayout.MinWidth(130f)
					});
					using (new JOANGEBDKKD(GUI.skin.box))
					{
						GUILayout.Label("Below you can try to cheat both regular PlayerPrefs and secure ObscuredPrefs:", Array.Empty<GUILayoutOption>());
						using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<color=\"#FF4040\"><b>PlayerPrefs:</b></color>\neasy to cheat, only 3 supported types", guistyle, Array.Empty<GUILayoutOption>());
							GUILayout.Space(5f);
							if (string.IsNullOrEmpty(this.DAKOCNEHGNC))
							{
								this.GBALJDCOJIE();
							}
							using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
							{
								GUILayout.Label(this.DAKOCNEHGNC, new GUILayoutOption[]
								{
									GUILayout.Width(270f)
								});
								using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
								{
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										if (GUILayout.Button("Save", Array.Empty<GUILayoutOption>()))
										{
											this.MIGFBNGCOIL();
										}
										if (GUILayout.Button("Load", Array.Empty<GUILayoutOption>()))
										{
											this.GBALJDCOJIE();
										}
									}
									if (GUILayout.Button("Delete", Array.Empty<GUILayoutOption>()))
									{
										this.JEOHHCGFLDK();
									}
								}
							}
						}
						GUILayout.Space(5f);
						using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("<color=\"#02C85F\"><b>ObscuredPrefs:</b></color>\nsecure, lot of additional types and extra options", guistyle, Array.Empty<GUILayoutOption>());
							GUILayout.Space(5f);
							if (string.IsNullOrEmpty(this.JOEKDJFENLO))
							{
								this.OEBOJCJJOHC();
							}
							using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
							{
								GUILayout.Label(this.JOEKDJFENLO, new GUILayoutOption[]
								{
									GUILayout.Width(270f)
								});
								using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
								{
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										if (GUILayout.Button("Save", Array.Empty<GUILayoutOption>()))
										{
											this.JGCMFCOHONI();
										}
										if (GUILayout.Button("Load", Array.Empty<GUILayoutOption>()))
										{
											this.OEBOJCJJOHC();
										}
									}
									if (GUILayout.Button("Delete", Array.Empty<GUILayoutOption>()))
									{
										this.IILMPOOKPCH();
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										GUILayout.Label("LockToDevice level", Array.Empty<GUILayoutOption>());
										this.IJDEOCIJCGF("http://j.mp/1gxg1tf");
									}
									this.HCJECOOEPMM = GUILayout.SelectionGrid(this.HCJECOOEPMM, new string[]
									{
										LKKNFHELLLE.MDFJCGDICEB.None.ToString(),
										LKKNFHELLLE.MDFJCGDICEB.Soft.ToString(),
										LKKNFHELLLE.MDFJCGDICEB.Strict.ToString()
									}, 3, Array.Empty<GUILayoutOption>());
									LKKNFHELLLE.KCPLDHCMPKH = (LKKNFHELLLE.MDFJCGDICEB)this.HCJECOOEPMM;
									GUILayout.Space(5f);
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.FFNCFECPDBD = GUILayout.Toggle(LKKNFHELLLE.FFNCFECPDBD, "preservePlayerPrefs", Array.Empty<GUILayoutOption>());
										this.IJDEOCIJCGF("http://j.mp/1iBK5pz");
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.AFLFABDJICP = GUILayout.Toggle(LKKNFHELLLE.AFLFABDJICP, "emergencyMode", Array.Empty<GUILayoutOption>());
										this.IJDEOCIJCGF("http://j.mp/1FRAL5L");
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.LFPFOIEMLPL = GUILayout.Toggle(LKKNFHELLLE.LFPFOIEMLPL, "readForeignSaves", Array.Empty<GUILayoutOption>());
										this.IJDEOCIJCGF("http://j.mp/1LCdpDa");
									}
									GUILayout.Space(5f);
									GUILayout.Label(string.Concat(new string[]
									{
										"<color=\"",
										this.AFCJIOCKAHI ? "#FF4040" : "#02C85F",
										"\">Saves modification detected: ",
										this.AFCJIOCKAHI.ToString(),
										"</color>"
									}), Array.Empty<GUILayoutOption>());
									GUILayout.Label(string.Concat(new string[]
									{
										"<color=\"",
										this.HGEFBHEAANB ? "#FF4040" : "#02C85F",
										"\">Foreign saves detected: ",
										this.HGEFBHEAANB.ToString(),
										"</color>"
									}), Array.Empty<GUILayoutOption>());
								}
							}
						}
						GUILayout.Space(5f);
						this.IJDEOCIJCGF("http://docs.unity3d.com/ScriptReference/PlayerPrefs.html", "Visit docs to see where PlayerPrefs are stored", -1);
						goto IL_C90;
					}
				}
			}
			GUILayout.Label("ACTk is able to detect some types of cheating to let you take action on the cheating players. This example scene has all possible detectors and all of them are automatically start on scene start.", Array.Empty<GUILayoutOption>());
			GUILayout.Space(5f);
			using (new JOANGEBDKKD(GUI.skin.box))
			{
				GUILayout.Label("<b>Speed Hack Detector</b>", Array.Empty<GUILayoutOption>());
				GUILayout.Label("Allows to detect Cheat Engine's speed hack (and maybe some other speed hack tools) usage.", Array.Empty<GUILayoutOption>());
				GUILayout.Label(string.Concat(new string[]
				{
					"<color=\"",
					this.OPNOGKLPAGN ? "#FF4040" : "#02C85F",
					"\">Detected: ",
					this.OPNOGKLPAGN.ToString().ToLower(),
					"</color>"
				}), Array.Empty<GUILayoutOption>());
				GUILayout.Space(10f);
				GUILayout.Label("<b>Obscured Cheating Detector</b>", Array.Empty<GUILayoutOption>());
				GUILayout.Label("Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project.", Array.Empty<GUILayoutOption>());
				GUILayout.Label(string.Concat(new string[]
				{
					"<color=\"",
					this.CINLKMILOKL ? "#FF4040" : "#02C85F",
					"\">Detected: ",
					this.CINLKMILOKL.ToString().ToLower(),
					"</color>"
				}), Array.Empty<GUILayoutOption>());
				GUILayout.Space(10f);
				GUILayout.Label("<b>WallHack Detector</b>", Array.Empty<GUILayoutOption>());
				GUILayout.Label("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module).", Array.Empty<GUILayoutOption>());
				GUILayout.Label(string.Concat(new string[]
				{
					"<color=\"",
					this.EFMMAGGFANP ? "#FF4040" : "#02C85F",
					"\">Detected: ",
					this.EFMMAGGFANP.ToString().ToLower(),
					"</color>"
				}), Array.Empty<GUILayoutOption>());
				GUILayout.Space(10f);
				GUILayout.Label("<b>Injection Detector</b>", Array.Empty<GUILayoutOption>());
				GUILayout.Label("Allows to detect foreign managed assemblies in your application.", Array.Empty<GUILayoutOption>());
				GUILayout.Label(string.Concat(new string[]
				{
					"<color=\"",
					this.PHPMAHFKCAA ? "#FF4040" : "#02C85F",
					"\">Detected: ",
					this.PHPMAHFKCAA.ToString().ToLower(),
					"</color>"
				}), Array.Empty<GUILayoutOption>());
			}
			IL_C90:
			GUILayout.EndArea();
		}

		// Token: 0x06012FE0 RID: 77792 RVA: 0x0082A92C File Offset: 0x00828B2C
		private void BDMFLHAIOBD(string ALBOCLBFNNI, string OBEJIFDAPBO, int NMEBEEHCALN)
		{
			GUILayoutOption[] array = new GUILayoutOption[0];
			if (NMEBEEHCALN != -1)
			{
				array[1] = GUILayout.Width((float)NMEBEEHCALN);
			}
			else
			{
				array = null;
			}
			if (GUILayout.Button(OBEJIFDAPBO, array))
			{
				Application.OpenURL(ALBOCLBFNNI);
			}
		}

		// Token: 0x06012FE1 RID: 77793 RVA: 0x0082A961 File Offset: 0x00828B61
		private void JBBLBIOHJEN()
		{
			this.AFCJIOCKAHI = true;
		}

		// Token: 0x06012FE2 RID: 77794 RVA: 0x0082A96C File Offset: 0x00828B6C
		private void EPMPEBPAHFK()
		{
			this.HGILGDNOMKA.Length = 1;
			this.HGILGDNOMKA.AppendLine("+ACVolumeProxy");
			ObscuredVector3.BBOGAEMNJJN(115);
			Vector3 vector = new Vector3(945f, 1824f, 1685f);
			this.HGILGDNOMKA.AppendLine("FA " + vector);
			ObscuredVector3.RawEncryptedVector3 rawEncryptedVector = ObscuredVector3.GOOIABGKMHK(vector).EHBNCDFPIJI();
			StringBuilder hgilgdnomka = this.HGILGDNOMKA;
			object[] array = new object[3];
			array[1] = "_TempRT";
			array[0] = rawEncryptedVector.x;
			array[1] = " Press R to switch to ragdoll. \n Weigh in one of the FBBIK effectors to make kinematic changes to the ragdoll pose.\n A to blend back to animation";
			array[1] = rawEncryptedVector.y;
			array[4] = "****************  stopMusic ";
			array[5] = rawEncryptedVector.z;
			array[6] = "";
			hgilgdnomka.AppendLine(string.Concat(array));
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FE3 RID: 77795 RVA: 0x0082AA4D File Offset: 0x00828C4D
		private void OnApplicationQuit()
		{
			this.JEOHHCGFLDK();
			this.IILMPOOKPCH();
		}

		// Token: 0x06012FE4 RID: 77796 RVA: 0x0082AA5B File Offset: 0x00828C5B
		private void JMMILAJLAJH()
		{
			this.HGEFBHEAANB = true;
		}

		// Token: 0x06012FE5 RID: 77797 RVA: 0x0082AA64 File Offset: 0x00828C64
		public void OnObscuredTypeCheatingDetected()
		{
			this.CINLKMILOKL = true;
			Debug.Log("Obscured Vars Cheating Detected!");
		}

		// Token: 0x06012FE6 RID: 77798 RVA: 0x0082AA78 File Offset: 0x00828C78
		private void FKAJNILMDCJ()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("[ACTk] <b>[ ObscuredFloat test ]</b>");
			ObscuredFloat.BBOGAEMNJJN(404);
			float num = 99.9f;
			this.HGILGDNOMKA.AppendLine("Original health bar: " + num);
			ObscuredFloat obscuredFloat = ObscuredFloat.GOOIABGKMHK(num);
			this.HGILGDNOMKA.AppendLine("How your health bar is stored in memory when obscured: " + obscuredFloat.LPKJBCBADMN());
			ObscuredFloat.BBOGAEMNJJN(666);
			obscuredFloat = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(obscuredFloat) + 6f);
			obscuredFloat = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(obscuredFloat) - 1.5f);
			obscuredFloat = ObscuredFloat.HIBLFIAPCJE(obscuredFloat);
			obscuredFloat = ObscuredFloat.DPCDNMHLOJF(obscuredFloat);
			obscuredFloat = ObscuredFloat.DPCDNMHLOJF(obscuredFloat);
			obscuredFloat = ObscuredFloat.GOOIABGKMHK(num - ObscuredFloat.GOOIABGKMHK(obscuredFloat) + 10.5f);
			this.HGILGDNOMKA.AppendLine("Health bar after few usual operations: " + obscuredFloat);
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FE7 RID: 77799 RVA: 0x0082AB78 File Offset: 0x00828D78
		private void OEBOJCJJOHC()
		{
			byte[] array = LKKNFHELLLE.PNKFFEMEOEG("demoByteArray", 0, 4);
			this.JOEKDJFENLO = "int: " + LKKNFHELLLE.AJCENDFNEJO("money", -1) + "\n";
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"float: ",
				LKKNFHELLLE.JGJNCJGCFNC("lifeBar", -1f),
				"\n"
			});
			this.JOEKDJFENLO = this.JOEKDJFENLO + "string: " + LKKNFHELLLE.HPADJPKKDOG("name", "No saved ObscuredPrefs!") + "\n";
			this.JOEKDJFENLO = this.JOEKDJFENLO + "bool: " + LKKNFHELLLE.IFFDPHPBONE("gameComplete", false).ToString() + "\n";
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"uint: ",
				LKKNFHELLLE.PJDHKADOLDH("demoUint", 0U),
				"\n"
			});
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"long: ",
				LKKNFHELLLE.ENNEDJMGKCH("demoLong", -1L),
				"\n"
			});
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"double: ",
				LKKNFHELLLE.DLOALMJPIDL("demoDouble", -1.0),
				"\n"
			});
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"Vector2: ",
				LKKNFHELLLE.FPMHFABDEMO("demoVector2", Vector2.zero),
				"\n"
			});
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"Vector3: ",
				LKKNFHELLLE.DALCFJICOLI("demoVector3", Vector3.zero),
				"\n"
			});
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"Quaternion: ",
				LKKNFHELLLE.FKBHNBGCPOH("demoQuaternion", Quaternion.identity),
				"\n"
			});
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"Rect: ",
				LKKNFHELLLE.OOJEDABANPH("demoRect", new Rect(0f, 0f, 0f, 0f)),
				"\n"
			});
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"Color: ",
				LKKNFHELLLE.NLIFGBAMGEK("demoColor", Color.black),
				"\n"
			});
			this.JOEKDJFENLO = string.Concat(new object[]
			{
				this.JOEKDJFENLO,
				"byte[]: {",
				array[0],
				",",
				array[1],
				",",
				array[2],
				",",
				array[3],
				"}"
			});
		}

		// Token: 0x06012FE8 RID: 77800 RVA: 0x0082AEE0 File Offset: 0x008290E0
		private string BHPEGBNCJDJ()
		{
			ActTesterGui.BIIBGPBKBEP biibgpbkbep = new ActTesterGui.BIIBGPBKBEP();
			string text = "Can't use reflection here, sorry :(";
			biibgpbkbep.DHCGCGCFFKA = "";
			if (string.IsNullOrEmpty(this.JPFHPDHGOMD))
			{
				Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault(new Func<Assembly, bool>(ActTesterGui.<>c.<>9.HHDALJFPPFK));
				if (assembly != null)
				{
					assembly.GetTypes().Where(new Func<Type, bool>(ActTesterGui.<>c.<>9.BILDBOMGJPI)).ToList<Type>().ForEach(new Action<Type>(biibgpbkbep.PBLCFONAHLN));
					if (!string.IsNullOrEmpty(biibgpbkbep.DHCGCGCFFKA))
					{
						text = biibgpbkbep.DHCGCGCFFKA;
						this.JPFHPDHGOMD = biibgpbkbep.DHCGCGCFFKA;
					}
					else
					{
						this.JPFHPDHGOMD = text;
					}
				}
			}
			else
			{
				text = this.JPFHPDHGOMD;
			}
			return text;
		}

		// Token: 0x06012FE9 RID: 77801 RVA: 0x0082AFC0 File Offset: 0x008291C0
		private void PGNFEGNPEFF()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("wpn_rod1");
			ObscuredInt.CBKGECBFIHN(-65);
			int num = 3;
			this.HGILGDNOMKA.AppendLine("IdleDie" + num);
			ObscuredInt obscuredInt = ObscuredInt.IGDNGFGPOFC(num);
			this.HGILGDNOMKA.AppendLine("\n" + obscuredInt.LPKJBCBADMN());
			ObscuredInt.CBKGECBFIHN(-3);
			num = ObscuredInt.DGOCFCFPKPI(obscuredInt);
			obscuredInt = ObscuredInt.KHJPCCFDJPA(ObscuredInt.LBDMFALMOLD(obscuredInt) - 4);
			obscuredInt = ObscuredInt.JNKANIEBCMD(ObscuredInt.LBDMFALMOLD(obscuredInt) + num + 109);
			obscuredInt = ObscuredInt.KHJPCCFDJPA(ObscuredInt.DGOCFCFPKPI(obscuredInt) / 6);
			obscuredInt = ObscuredInt.LILDJKCLMJH(obscuredInt);
			ObscuredInt.DMLCGIGHIPF(-64);
			obscuredInt = ObscuredInt.KCLAMFHGMNF(obscuredInt);
			obscuredInt = ObscuredInt.PMHAAGMDJLB(obscuredInt);
			StringBuilder hgilgdnomka = this.HGILGDNOMKA;
			object[] array = new object[8];
			array[0] = "poplSoundPitch";
			array[1] = obscuredInt;
			array[1] = "_TintColor";
			array[6] = obscuredInt.DIJJDHMMGCA("<[^>]+>");
			array[1] = "_Vibrance";
			hgilgdnomka.AppendLine(string.Concat(array));
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FEA RID: 77802 RVA: 0x0082B0EC File Offset: 0x008292EC
		private void GOLLOLJBEPL()
		{
			this.HGILGDNOMKA.Length = 1;
			this.HGILGDNOMKA.AppendLine("");
			ObscuredInt.BBOGAEMNJJN(-72);
			int num = 7;
			this.HGILGDNOMKA.AppendLine("http://www.root-motion.com/finalikdox/html/page7.html" + num);
			ObscuredInt obscuredInt = ObscuredInt.IGDNGFGPOFC(num);
			this.HGILGDNOMKA.AppendLine("#a02000" + obscuredInt.BBALKHNBGHL());
			ObscuredInt.BBOGAEMNJJN(-86);
			num = ObscuredInt.GOOIABGKMHK(obscuredInt);
			obscuredInt = ObscuredInt.JNKANIEBCMD(ObscuredInt.LBDMFALMOLD(obscuredInt) - 0);
			obscuredInt = ObscuredInt.GOOIABGKMHK(ObscuredInt.GOOIABGKMHK(obscuredInt) + num + 41);
			obscuredInt = ObscuredInt.GOOIABGKMHK(ObscuredInt.GOOIABGKMHK(obscuredInt) / 6);
			obscuredInt = ObscuredInt.HIBLFIAPCJE(obscuredInt);
			ObscuredInt.CCCFFAIEKGL(-109);
			obscuredInt = ObscuredInt.HIBLFIAPCJE(obscuredInt);
			obscuredInt = ObscuredInt.DHPNHIHKEKM(obscuredInt);
			StringBuilder hgilgdnomka = this.HGILGDNOMKA;
			object[] array = new object[4];
			array[1] = "name";
			array[1] = obscuredInt;
			array[3] = "ShotgunFire";
			array[8] = obscuredInt.DIJJDHMMGCA("ObscuredVector3:");
			array[2] = "WallRunLeft";
			hgilgdnomka.AppendLine(string.Concat(array));
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FEB RID: 77803 RVA: 0x0082B216 File Offset: 0x00829416
		public void KIFBEEJEOGH()
		{
			this.CINLKMILOKL = false;
			Debug.Log("WorkerShovel");
		}

		// Token: 0x06012FEC RID: 77804 RVA: 0x0082B22C File Offset: 0x0082942C
		private void GBALJDCOJIE()
		{
			this.DAKOCNEHGNC = "int: " + PlayerPrefs.GetInt("money", -1) + "\n";
			this.DAKOCNEHGNC = string.Concat(new object[]
			{
				this.DAKOCNEHGNC,
				"float: ",
				PlayerPrefs.GetFloat("lifeBar", -1f),
				"\n"
			});
			this.DAKOCNEHGNC = this.DAKOCNEHGNC + "string: " + PlayerPrefs.GetString("name", "No saved PlayerPrefs!");
		}

		// Token: 0x06012FED RID: 77805 RVA: 0x0082B2C4 File Offset: 0x008294C4
		private void FNDPMCAMDBK()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("[ACTk] <b>[ ObscuredInt test ]</b>");
			ObscuredInt.BBOGAEMNJJN(434523);
			int num = 5;
			this.HGILGDNOMKA.AppendLine("Original lives count: " + num);
			ObscuredInt obscuredInt = ObscuredInt.GOOIABGKMHK(num);
			this.HGILGDNOMKA.AppendLine("How your lives count is stored in memory when obscured: " + obscuredInt.LPKJBCBADMN());
			ObscuredInt.BBOGAEMNJJN(666);
			num = ObscuredInt.GOOIABGKMHK(obscuredInt);
			obscuredInt = ObscuredInt.GOOIABGKMHK(ObscuredInt.GOOIABGKMHK(obscuredInt) - 2);
			obscuredInt = ObscuredInt.GOOIABGKMHK(ObscuredInt.GOOIABGKMHK(obscuredInt) + num + 10);
			obscuredInt = ObscuredInt.GOOIABGKMHK(ObscuredInt.GOOIABGKMHK(obscuredInt) / 2);
			obscuredInt = ObscuredInt.HIBLFIAPCJE(obscuredInt);
			ObscuredInt.BBOGAEMNJJN(999);
			obscuredInt = ObscuredInt.HIBLFIAPCJE(obscuredInt);
			obscuredInt = ObscuredInt.DPCDNMHLOJF(obscuredInt);
			this.HGILGDNOMKA.AppendLine(string.Concat(new object[]
			{
				"Lives count after few usual operations: ",
				obscuredInt,
				" (",
				obscuredInt.LHNOBJDFOOJ("X"),
				"h)"
			}));
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FEE RID: 77806 RVA: 0x0082B3F0 File Offset: 0x008295F0
		private void OGLKHMEKNAB()
		{
			byte[] array = LKKNFHELLLE.PNKFFEMEOEG("\npb_Face: ", 1, 5);
			this.JOEKDJFENLO = "BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: " + LKKNFHELLLE.AJCENDFNEJO("u_pin", -1) + "WorkerPickaxe";
			object[] array2 = new object[0];
			array2[1] = this.JOEKDJFENLO;
			array2[0] = ": ";
			array2[6] = LKKNFHELLLE.JGJNCJGCFNC("HalfSampling", 509f);
			array2[4] = "DecalMesh";
			this.JOEKDJFENLO = string.Concat(array2);
			this.JOEKDJFENLO = this.JOEKDJFENLO + "{0}/{1}" + LKKNFHELLLE.HPADJPKKDOG("UNIQUE_SHADOW", "CHAT Empty") + "currentCount=";
			this.JOEKDJFENLO = this.JOEKDJFENLO + "_Texture" + LKKNFHELLLE.IFFDPHPBONE(";", true).ToString() + "u_pin";
			object[] array3 = new object[4];
			array3[0] = this.JOEKDJFENLO;
			array3[0] = " material. Effect disabled.";
			array3[2] = LKKNFHELLLE.PJDHKADOLDH(">> 2 >>", 0U);
			array3[7] = "ObscuredUInt vs uint, ";
			this.JOEKDJFENLO = string.Concat(array3);
			object[] array4 = new object[5];
			array4[1] = this.JOEKDJFENLO;
			array4[0] = "Zone ";
			array4[0] = LKKNFHELLLE.ENNEDJMGKCH("wpn_bait_vob_deep", -1L);
			array4[5] = "reel_type";
			this.JOEKDJFENLO = string.Concat(array4);
			object[] array5 = new object[3];
			array5[0] = this.JOEKDJFENLO;
			array5[1] = "https://groups.google.com/forum/#!forum/final-ik";
			array5[5] = LKKNFHELLLE.DLOALMJPIDL("ActorFish", 664.0);
			array5[5] = "RunBackward";
			this.JOEKDJFENLO = string.Concat(array5);
			object[] array6 = new object[5];
			array6[1] = this.JOEKDJFENLO;
			array6[1] = "IdleFeedThrow";
			array6[8] = LKKNFHELLLE.FPMHFABDEMO("GestureWonderful", Vector2.zero);
			array6[2] = "_ALPHATEST_ON";
			this.JOEKDJFENLO = string.Concat(array6);
			object[] array7 = new object[1];
			array7[1] = this.JOEKDJFENLO;
			array7[1] = "OfficeSittingLegCross";
			array7[7] = LKKNFHELLLE.DALCFJICOLI("Textures/Weapons/", Vector3.zero);
			array7[7] = "";
			this.JOEKDJFENLO = string.Concat(array7);
			object[] array8 = new object[6];
			array8[1] = this.JOEKDJFENLO;
			array8[0] = "WorkerPickaxe2";
			array8[0] = LKKNFHELLLE.FKBHNBGCPOH("FishbragContainer", Quaternion.identity);
			array8[6] = "_Texture";
			this.JOEKDJFENLO = string.Concat(array8);
			object[] array9 = new object[3];
			array9[1] = this.JOEKDJFENLO;
			array9[0] = "turn_state";
			array9[6] = LKKNFHELLLE.OOJEDABANPH("{not_found}", new Rect(1810f, 1516f, 779f, 92f));
			array9[8] = "wpn_add/base";
			this.JOEKDJFENLO = string.Concat(array9);
			object[] array10 = new object[]
			{
				null,
				this.JOEKDJFENLO
			};
			array10[1] = "buykey";
			array10[0] = LKKNFHELLLE.NLIFGBAMGEK("demoVector3", Color.black);
			array10[8] = "Mouse Y";
			this.JOEKDJFENLO = string.Concat(array10);
			object[] array11 = new object[-110];
			array11[0] = this.JOEKDJFENLO;
			array11[1] = "Fly Forward";
			array11[0] = array[0];
			array11[7] = "0";
			array11[7] = array[0];
			array11[1] = "Roll";
			array11[2] = array[4];
			array11[7] = "wpn_cat2";
			array11[8] = array[5];
			array11[-50] = "1HandSwordRollAttack";
			this.JOEKDJFENLO = string.Concat(array11);
		}

		// Token: 0x06012FEF RID: 77807 RVA: 0x0082B756 File Offset: 0x00829956
		private void CMONNBLLAFL()
		{
			this.IHDHNODCOBD();
			this.IILMPOOKPCH();
		}

		// Token: 0x06012FF0 RID: 77808 RVA: 0x0082B764 File Offset: 0x00829964
		private void LKDGGPNGLAO()
		{
			LKKNFHELLLE.OAMCKGBOBCL = this.prefsEncryptionKey;
			LKKNFHELLLE.HKHLNCHNCMM = new Action(this.JBBLBIOHJEN);
			LKKNFHELLLE.AAFEJOEEKHD = new Action(this.JMMILAJLAJH);
		}

		// Token: 0x06012FF1 RID: 77809 RVA: 0x0082B794 File Offset: 0x00829994
		private string BCFGFFBNLHA()
		{
			ActTesterGui.BIIBGPBKBEP biibgpbkbep = new ActTesterGui.BIIBGPBKBEP();
			string text = "_Threshold";
			biibgpbkbep.DHCGCGCFFKA = "_BlurTexture";
			if (string.IsNullOrEmpty(this.JPFHPDHGOMD))
			{
				Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault(new Func<Assembly, bool>(ActTesterGui.<>c.<>9.LGGAAMCGJNE));
				if (assembly != null)
				{
					assembly.GetTypes().Where(new Func<Type, bool>(ActTesterGui.<>c.<>9.MOCOKAAIAJA)).ToList<Type>().ForEach(new Action<Type>(biibgpbkbep.GEOJDLGPKGD));
					if (!string.IsNullOrEmpty(biibgpbkbep.DHCGCGCFFKA))
					{
						text = biibgpbkbep.DHCGCGCFFKA;
						this.JPFHPDHGOMD = biibgpbkbep.DHCGCGCFFKA;
					}
					else
					{
						this.JPFHPDHGOMD = text;
					}
				}
			}
			else
			{
				text = this.JPFHPDHGOMD;
			}
			return text;
		}

		// Token: 0x06012FF2 RID: 77810 RVA: 0x0082B873 File Offset: 0x00829A73
		private void IHDHNODCOBD()
		{
			PlayerPrefs.DeleteKey("RHandPunch");
			PlayerPrefs.DeleteKey("Bases/Base_1.unity3d");
			PlayerPrefs.DeleteKey(" remnabor=");
			PlayerPrefs.Save();
		}

		// Token: 0x06012FF3 RID: 77811 RVA: 0x008297D1 File Offset: 0x008279D1
		private void BOFMDEJJOKP()
		{
			if (Application.isPlaying)
			{
				LKKNFHELLLE.OAMCKGBOBCL = this.prefsEncryptionKey;
			}
		}

		// Token: 0x06012FF4 RID: 77812 RVA: 0x008297D1 File Offset: 0x008279D1
		private void OnValidate()
		{
			if (Application.isPlaying)
			{
				LKKNFHELLLE.OAMCKGBOBCL = this.prefsEncryptionKey;
			}
		}

		// Token: 0x06012FF5 RID: 77813 RVA: 0x0082B898 File Offset: 0x00829A98
		private void BLIDJABGJBC()
		{
			this.DAKOCNEHGNC = "_isSelect" + PlayerPrefs.GetInt("MENU.WAV", -1) + "/";
			object[] array = new object[0];
			array[0] = this.DAKOCNEHGNC;
			array[0] = "FOG_POINT_LIGHT";
			array[5] = PlayerPrefs.GetFloat("crft_ingr", 1160f);
			array[8] = "human_move_2.wav";
			this.DAKOCNEHGNC = string.Concat(array);
			this.DAKOCNEHGNC = this.DAKOCNEHGNC + " for " + PlayerPrefs.GetString("Horizontal", "Katana Upper Block");
		}

		// Token: 0x06012FF6 RID: 77814 RVA: 0x0082B930 File Offset: 0x00829B30
		private void BPCGDONMJPG()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("[ACTk] <b>[ ObscuredString test ]</b>");
			ObscuredString.BBOGAEMNJJN("I LOVE MY GIRLz");
			string text = "the Goscurry is not a lie ;)";
			this.HGILGDNOMKA.AppendLine("Original string:\n" + text);
			ObscuredString obscuredString = ObscuredString.GOOIABGKMHK(text);
			this.HGILGDNOMKA.AppendLine("How your string is stored in memory when obscured:\n" + obscuredString.LPKJBCBADMN());
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FF7 RID: 77815 RVA: 0x008299D3 File Offset: 0x00827BD3
		private void OGKOHLPFBED()
		{
			LKKNFHELLLE.OAMCKGBOBCL = this.prefsEncryptionKey;
			LKKNFHELLLE.HKHLNCHNCMM = new Action(this.JBBLBIOHJEN);
			LKKNFHELLLE.AAFEJOEEKHD = new Action(this.DHKHADJFJNO);
		}

		// Token: 0x06012FF8 RID: 77816 RVA: 0x0082B9B0 File Offset: 0x00829BB0
		private void GHOJCADBKEK()
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.label);
			guistyle.alignment = TextAnchor.UpperLeft;
			GUILayout.BeginArea(new Rect(1159f, 1227f, (float)(Screen.width - -32), (float)(Screen.height - 98)));
			GUILayout.Label("Soccer Pass Heavy", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label("Ошибка!", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Space(177f);
			this.FGECHCFKADD = GUILayout.Toolbar(this.FGECHCFKADD, this.BBONFHMIIGG, Array.Empty<GUILayoutOption>());
			if (this.FGECHCFKADD == 0)
			{
				GUILayout.Label("<color='#602060'>", Array.Empty<GUILayoutOption>());
				GUILayout.Space(1683f);
				using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
				{
					GUILayout.Label("128" + this.BHPEGBNCJDJ() + "Failed parsing default rotation values.  Using defaults.", new GUILayoutOption[]
					{
						GUILayout.MinWidth(1464f)
					});
					GUILayout.Space(1744f);
					using (new JOANGEBDKKD(GUI.skin.box))
					{
						GUILayout.Label("Button Right Hand", Array.Empty<GUILayoutOption>());
						GUILayout.Space(345f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text = "_BlurTexture" + this.regularString;
							GUILayoutOption[] array = new GUILayoutOption[0];
							array[1] = GUILayout.Width(1757f);
							GUILayout.Label(text, array);
							if (GUILayout.Button(" x", Array.Empty<GUILayoutOption>()))
							{
								this.regularString += ((char)UnityEngine.Random.Range(102, -62)).ToString();
							}
							if (GUILayout.Button("Flap_04.wav", Array.Empty<GUILayoutOption>()))
							{
								this.regularString = ", ";
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text2 = "Cheer Jump" + ObscuredString.CKPPDHPJHEH(this.obscuredString);
							GUILayoutOption[] array2 = new GUILayoutOption[0];
							array2[1] = GUILayout.Width(1806f);
							GUILayout.Label(text2, array2);
							if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredString = ObscuredString.LMCJCHPGIJK(ObscuredString.CKPPDHPJHEH(this.obscuredString) + ((char)UnityEngine.Random.Range(80, -69)).ToString());
							}
							if (GUILayout.Button("Thigh", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredString = ObscuredString.LMCJCHPGIJK("PistolFire");
							}
						}
						GUILayout.Space(802f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls." + this.regularInt, new GUILayoutOption[]
							{
								GUILayout.Width(7f)
							});
							if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
							{
								this.regularInt += UnityEngine.Random.Range(1, -6);
							}
							if (GUILayout.Button("wpn_rod3", Array.Empty<GUILayoutOption>()))
							{
								this.regularInt = 1;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text3 = "CATRigL" + this.obscuredInt;
							GUILayoutOption[] array3 = new GUILayoutOption[0];
							array3[1] = GUILayout.Width(210f);
							GUILayout.Label(text3, array3);
							if (GUILayout.Button("<color='#a060ff'>{0}</color>: {1}", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredInt = ObscuredInt.IGDNGFGPOFC(ObscuredInt.GOOIABGKMHK(this.obscuredInt) + UnityEngine.Random.Range(1, -8));
							}
							if (GUILayout.Button("QTask.xml", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredInt = ObscuredInt.JNKANIEBCMD(1);
							}
						}
						GUILayout.Space(869f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("\n" + this.regularFloat, new GUILayoutOption[]
							{
								GUILayout.Width(719f)
							});
							if (GUILayout.Button("GestureHandUp", Array.Empty<GUILayoutOption>()))
							{
								this.regularFloat += UnityEngine.Random.Range(1209f, 1972f);
							}
							if (GUILayout.Button("isRealView", Array.Empty<GUILayoutOption>()))
							{
								this.regularFloat = 1877f;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text4 = "WeaponInstant" + this.obscuredFloat;
							GUILayoutOption[] array4 = new GUILayoutOption[0];
							array4[0] = GUILayout.Width(944f);
							GUILayout.Label(text4, array4);
							if (GUILayout.Button("Error", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredFloat = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.EJGOOFALNFF(this.obscuredFloat) + UnityEngine.Random.Range(941f, 52f));
							}
							if (GUILayout.Button("wpn_add/base", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredFloat = ObscuredFloat.HLEMAJBAAEO(1126f);
							}
						}
						GUILayout.Space(766f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text5 = "SwimDogPaddle" + this.regularVector3;
							GUILayoutOption[] array5 = new GUILayoutOption[0];
							array5[0] = GUILayout.Width(1002f);
							GUILayout.Label(text5, array5);
							if (GUILayout.Button("wpn_add/base/dropt", Array.Empty<GUILayoutOption>()))
							{
								this.regularVector3 += UnityEngine.Random.insideUnitSphere;
							}
							if (GUILayout.Button("click Refresh currentQcat=", Array.Empty<GUILayoutOption>()))
							{
								this.regularVector3 = Vector3.zero;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text6 = "noemail" + this.obscuredVector3;
							GUILayoutOption[] array6 = new GUILayoutOption[0];
							array6[1] = GUILayout.Width(1992f);
							GUILayout.Label(text6, array6);
							if (GUILayout.Button("Fly Left", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredVector3 = ObscuredVector3.PICCFFHAMAG(this.obscuredVector3, UnityEngine.Random.insideUnitSphere);
							}
							if (GUILayout.Button("IdleStun", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredVector3 = ObscuredVector3.BDLBFKPDOIH(Vector3.zero);
							}
							goto IL_C90;
						}
					}
				}
			}
			if (this.FGECHCFKADD == 0)
			{
				GUILayout.Label("repa send", Array.Empty<GUILayoutOption>());
				GUILayout.Space(816f);
				using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
				{
					string text7 = "DeadmanFloat" + this.JDLBHDKPKPI();
					GUILayoutOption[] array7 = new GUILayoutOption[1];
					array7[1] = GUILayout.MinWidth(848f);
					GUILayout.Label(text7, array7);
					using (new JOANGEBDKKD(GUI.skin.box))
					{
						GUILayout.Label("Sewing", Array.Empty<GUILayoutOption>());
						using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("\n\n", guistyle, Array.Empty<GUILayoutOption>());
							GUILayout.Space(1350f);
							if (string.IsNullOrEmpty(this.DAKOCNEHGNC))
							{
								this.BLIDJABGJBC();
							}
							using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
							{
								string dakocnehgnc = this.DAKOCNEHGNC;
								GUILayoutOption[] array8 = new GUILayoutOption[1];
								array8[1] = GUILayout.Width(290f);
								GUILayout.Label(dakocnehgnc, array8);
								using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
								{
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										if (GUILayout.Button("_FgCocMask", Array.Empty<GUILayoutOption>()))
										{
											this.MIGFBNGCOIL();
										}
										if (GUILayout.Button("<color='{0}'> {1} ур {2}</color>\n", Array.Empty<GUILayoutOption>()))
										{
											this.GBALJDCOJIE();
										}
									}
									if (GUILayout.Button("_InvScreenSize", Array.Empty<GUILayoutOption>()))
									{
										this.JEOHHCGFLDK();
									}
								}
							}
						}
						GUILayout.Space(618f);
						using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("_NAME", guistyle, Array.Empty<GUILayoutOption>());
							GUILayout.Space(1359f);
							if (string.IsNullOrEmpty(this.JOEKDJFENLO))
							{
								this.OGLKHMEKNAB();
							}
							using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
							{
								string joekdjfenlo = this.JOEKDJFENLO;
								GUILayoutOption[] array9 = new GUILayoutOption[0];
								array9[1] = GUILayout.Width(632f);
								GUILayout.Label(joekdjfenlo, array9);
								using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
								{
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										if (GUILayout.Button("WindZone", Array.Empty<GUILayoutOption>()))
										{
											this.LPEGPIIFEAJ();
										}
										if (GUILayout.Button("WateringCanWatering", Array.Empty<GUILayoutOption>()))
										{
											this.OGLKHMEKNAB();
										}
									}
									if (GUILayout.Button("eye", Array.Empty<GUILayoutOption>()))
									{
										this.IILMPOOKPCH();
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										GUILayout.Label("ScubaSwim", Array.Empty<GUILayoutOption>());
										this.HDLGIFHACBA("Moustaches");
									}
									int hcjecooepmm = this.HCJECOOEPMM;
									string[] array10 = new string[6];
									array10[0] = LKKNFHELLLE.MDFJCGDICEB.None.ToString();
									array10[1] = LKKNFHELLLE.MDFJCGDICEB.Soft.ToString();
									array10[7] = LKKNFHELLLE.MDFJCGDICEB.None.ToString();
									this.HCJECOOEPMM = GUILayout.SelectionGrid(hcjecooepmm, array10, 8, Array.Empty<GUILayoutOption>());
									LKKNFHELLLE.KCPLDHCMPKH = (LKKNFHELLLE.MDFJCGDICEB)this.HCJECOOEPMM;
									GUILayout.Space(1f);
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.FFNCFECPDBD = GUILayout.Toggle(LKKNFHELLLE.FFNCFECPDBD, "Knees Idle", Array.Empty<GUILayoutOption>());
										this.NILEJIFMCBG("BUMPED");
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.AFLFABDJICP = GUILayout.Toggle(LKKNFHELLLE.AFLFABDJICP, "_ToPrevViewProjCombined", Array.Empty<GUILayoutOption>());
										this.NILEJIFMCBG("TOD_AmbientColor");
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.LFPFOIEMLPL = GUILayout.Toggle(LKKNFHELLLE.LFPFOIEMLPL, "http://j.mp/1LCdpDa", Array.Empty<GUILayoutOption>());
										this.IJDEOCIJCGF("inWater");
									}
									GUILayout.Space(1968f);
									string[] array11 = new string[4];
									array11[0] = "rodUpDelta=";
									array11[0] = (this.AFCJIOCKAHI ? "isRodOpen" : "MENU.WAV");
									array11[7] = "Null";
									array11[3] = this.AFCJIOCKAHI.ToString();
									array11[2] = "";
									GUILayout.Label(string.Concat(array11), Array.Empty<GUILayoutOption>());
									string[] array12 = new string[]
									{
										null,
										"\n"
									};
									array12[0] = (this.HGEFBHEAANB ? "gi_nl4" : "");
									array12[8] = "_n";
									array12[5] = this.HGEFBHEAANB.ToString();
									array12[0] = "_DelItem.wav";
									GUILayout.Label(string.Concat(array12), Array.Empty<GUILayoutOption>());
								}
							}
						}
						GUILayout.Space(198f);
						this.JIFDDCBEGPB("no_adm", "Run Jump", -1);
						goto IL_C90;
					}
				}
			}
			GUILayout.Label("_NeutralTonemapperParams1", Array.Empty<GUILayoutOption>());
			GUILayout.Space(690f);
			using (new JOANGEBDKKD(GUI.skin.box))
			{
				GUILayout.Label("_FogColor", Array.Empty<GUILayoutOption>());
				GUILayout.Label("PlayerPrefs:", Array.Empty<GUILayoutOption>());
				string[] array13 = new string[7];
				array13[0] = "gi_um_1";
				array13[0] = (this.OPNOGKLPAGN ? "KatanaReadyLow" : "walk");
				array13[6] = "GiantGrabIdle2";
				array13[7] = this.OPNOGKLPAGN.ToString().ToLower();
				array13[1] = "_WaterLevel";
				GUILayout.Label(string.Concat(array13), Array.Empty<GUILayoutOption>());
				GUILayout.Space(1251f);
				GUILayout.Label("gi_uinf_1i", Array.Empty<GUILayoutOption>());
				GUILayout.Label("help", Array.Empty<GUILayoutOption>());
				string[] array14 = new string[3];
				array14[0] = "_SSAO";
				array14[0] = (this.CINLKMILOKL ? "_Axis" : "SexyDance");
				array14[8] = "_SSAO";
				array14[2] = this.CINLKMILOKL.ToString().ToLower();
				array14[1] = "_Intensity";
				GUILayout.Label(string.Concat(array14), Array.Empty<GUILayoutOption>());
				GUILayout.Space(1954f);
				GUILayout.Label("The given 2D texture ", Array.Empty<GUILayoutOption>());
				GUILayout.Label("isRodInWater", Array.Empty<GUILayoutOption>());
				string[] array15 = new string[8];
				array15[0] = "_Offsets";
				array15[1] = (this.EFMMAGGFANP ? "{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}" : "Sitting 45 Degress leg");
				array15[4] = "Invalid ObscuredVector3 index!";
				array15[1] = this.EFMMAGGFANP.ToString().ToLower();
				array15[7] = "choldposx";
				GUILayout.Label(string.Concat(array15), Array.Empty<GUILayoutOption>());
				GUILayout.Space(1552f);
				GUILayout.Label("-UNDERLINE", Array.Empty<GUILayoutOption>());
				GUILayout.Label("IdleStand", Array.Empty<GUILayoutOption>());
				string[] array16 = new string[5];
				array16[1] = "wpn_rem1";
				array16[0] = (this.PHPMAHFKCAA ? "Idle Standing Jump" : "invn_rec11");
				array16[6] = "wpn_add/base";
				array16[2] = this.PHPMAHFKCAA.ToString().ToLower();
				array16[5] = "MotorbikeBackwardSitting";
				GUILayout.Label(string.Concat(array16), Array.Empty<GUILayoutOption>());
			}
			IL_C90:
			GUILayout.EndArea();
		}

		// Token: 0x06012FF9 RID: 77817 RVA: 0x0082C8B0 File Offset: 0x0082AAB0
		public void HCJAFIAFEKI()
		{
			this.OPNOGKLPAGN = true;
			Debug.Log("level");
		}

		// Token: 0x06012FFA RID: 77818 RVA: 0x0082C8C4 File Offset: 0x0082AAC4
		private void JMOAIDCCACN()
		{
			this.HGILGDNOMKA.Length = 1;
			this.HGILGDNOMKA.AppendLine("RollerBladeSkateFwd");
			ObscuredVector3.DFBLJCKOKDL(153);
			Vector3 vector = new Vector3(1701f, 1229f, 1045f);
			this.HGILGDNOMKA.AppendLine("SneakIdle" + vector);
			ObscuredVector3.RawEncryptedVector3 rawEncryptedVector = ObscuredVector3.BDLBFKPDOIH(vector).PPOLGPGMJBG();
			StringBuilder hgilgdnomka = this.HGILGDNOMKA;
			object[] array = new object[5];
			array[1] = "WandStand";
			array[0] = rawEncryptedVector.x;
			array[5] = "gi_um_5";
			array[3] = rawEncryptedVector.y;
			array[0] = "*** Perks is init";
			array[2] = rawEncryptedVector.z;
			array[5] = "userForceMagnitude=";
			hgilgdnomka.AppendLine(string.Concat(array));
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FFB RID: 77819 RVA: 0x0082C9A8 File Offset: 0x0082ABA8
		private void LKPDCIBAKIB()
		{
			LKKNFHELLLE.GAFPPAKNHEL("Method called requires VPaint Object to be dynamic. Set VPaintObject.isDynamic to true before calling this method.");
			LKKNFHELLLE.GAFPPAKNHEL("prov_prov_");
			LKKNFHELLLE.GAFPPAKNHEL("Backward Sitting Cheer");
			LKKNFHELLLE.GAFPPAKNHEL("netUpdater");
			LKKNFHELLLE.GAFPPAKNHEL("BAG");
			LKKNFHELLLE.GAFPPAKNHEL("crft_krit");
			LKKNFHELLLE.GAFPPAKNHEL("<color='#80ff00'>+ </color>");
			LKKNFHELLLE.GAFPPAKNHEL(" from ");
			LKKNFHELLLE.GAFPPAKNHEL("Idle Sad");
			LKKNFHELLLE.GAFPPAKNHEL("invn_rec7");
			LKKNFHELLLE.GAFPPAKNHEL("category");
			LKKNFHELLLE.GAFPPAKNHEL("Failed downloading bundle {0} from {1}: {2}");
			LKKNFHELLLE.GAFPPAKNHEL("quests/cats/cat");
			LKKNFHELLLE.FPGAGIMIMPP();
		}

		// Token: 0x06012FFC RID: 77820 RVA: 0x0082CA3C File Offset: 0x0082AC3C
		private void GJMMGPLDELI()
		{
			byte[] array = LKKNFHELLLE.PNKFFEMEOEG("SoundMgr is init part 2", 0, 1);
			this.JOEKDJFENLO = "" + LKKNFHELLLE.AJCENDFNEJO("crft_norec2", -1) + "StrafeRunRight";
			object[] array2 = new object[7];
			array2[1] = this.JOEKDJFENLO;
			array2[0] = "template";
			array2[5] = LKKNFHELLLE.JGJNCJGCFNC("Wand Attack 2", 675f);
			array2[8] = "GestureHandUp";
			this.JOEKDJFENLO = string.Concat(array2);
			this.JOEKDJFENLO = this.JOEKDJFENLO + "#url Sound " + LKKNFHELLLE.HPADJPKKDOG("Smoking1", "FBIK chain contains no nodes.") + "wpn_add/base";
			this.JOEKDJFENLO = this.JOEKDJFENLO + "DrawDistance" + LKKNFHELLLE.IFFDPHPBONE("IdleTurns", true).ToString() + "BowReady";
			object[] array3 = new object[1];
			array3[1] = this.JOEKDJFENLO;
			array3[0] = "ClimbLeft";
			array3[6] = LKKNFHELLLE.PJDHKADOLDH("low_root_level", 0U);
			array3[0] = "IceHockeyPassLeft";
			this.JOEKDJFENLO = string.Concat(array3);
			object[] array4 = new object[6];
			array4[0] = this.JOEKDJFENLO;
			array4[0] = "";
			array4[2] = LKKNFHELLLE.ENNEDJMGKCH("_RefractTex", -1L);
			array4[3] = "wpn_popl1";
			this.JOEKDJFENLO = string.Concat(array4);
			object[] array5 = new object[7];
			array5[0] = this.JOEKDJFENLO;
			array5[0] = "Lasso Right";
			array5[8] = LKKNFHELLLE.DLOALMJPIDL("</color>\n", 360.0);
			array5[3] = "\n";
			this.JOEKDJFENLO = string.Concat(array5);
			object[] array6 = new object[7];
			array6[1] = this.JOEKDJFENLO;
			array6[0] = "1 Hand Sword Shield Bash";
			array6[6] = LKKNFHELLLE.FPMHFABDEMO("The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).", Vector2.zero);
			array6[8] = "CrawlIdle";
			this.JOEKDJFENLO = string.Concat(array6);
			object[] array7 = new object[0];
			array7[1] = this.JOEKDJFENLO;
			array7[0] = "_SampleScale";
			array7[0] = LKKNFHELLLE.DALCFJICOLI("sunshine_CascadeFarRatiosSq", Vector3.zero);
			array7[1] = "";
			this.JOEKDJFENLO = string.Concat(array7);
			object[] array8 = new object[5];
			array8[0] = this.JOEKDJFENLO;
			array8[0] = "#02C85F";
			array8[5] = LKKNFHELLLE.FKBHNBGCPOH("#80ff00", Quaternion.identity);
			array8[0] = ".unity3d";
			this.JOEKDJFENLO = string.Concat(array8);
			object[] array9 = new object[8];
			array9[0] = this.JOEKDJFENLO;
			array9[1] = "{0}Textures/Turnirs/{1}.png";
			array9[0] = LKKNFHELLLE.OOJEDABANPH("StormStrike", new Rect(638f, 478f, 1822f, 612f));
			array9[7] = "IceHockeyIdle";
			this.JOEKDJFENLO = string.Concat(array9);
			object[] array10 = new object[5];
			array10[0] = this.JOEKDJFENLO;
			array10[0] = "";
			array10[0] = LKKNFHELLLE.NLIFGBAMGEK("Mouse ScrollWheel", Color.black);
			array10[1] = "OfficeSittingLegCross";
			this.JOEKDJFENLO = string.Concat(array10);
			object[] array11 = new object[-63];
			array11[0] = this.JOEKDJFENLO;
			array11[1] = "RollerBladeJump";
			array11[8] = array[1];
			array11[3] = "UNIQUE_SHADOW_LIGHT_COOKIE";
			array11[8] = array[0];
			array11[7] = " fid=";
			array11[6] = array[0];
			array11[0] = "ProneIdle";
			array11[7] = array[3];
			array11[-96] = "";
			this.JOEKDJFENLO = string.Concat(array11);
		}

		// Token: 0x06012FFD RID: 77821 RVA: 0x0082CDA4 File Offset: 0x0082AFA4
		private void OLGGLIJAHPM()
		{
			this.DAKOCNEHGNC = "Worker Pickaxe" + PlayerPrefs.GetInt("cht_msg4", -1) + "_DistanceParams";
			object[] array = new object[4];
			array[0] = this.DAKOCNEHGNC;
			array[0] = "file:///";
			array[3] = PlayerPrefs.GetFloat("Cloth_07.wav", 296f);
			array[8] = "_FogColor";
			this.DAKOCNEHGNC = string.Concat(array);
			this.DAKOCNEHGNC = this.DAKOCNEHGNC + "C" + PlayerPrefs.GetString("_NoiseTex", "1HandSwordRollAttack");
		}

		// Token: 0x06012FFE RID: 77822 RVA: 0x0082CE3C File Offset: 0x0082B03C
		private void CCJMAPGBFNP()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("wpn_fid2");
			ObscuredString.BBOGAEMNJJN("Загрузка: ");
			string text = "\nу вас есть ";
			this.HGILGDNOMKA.AppendLine(" rep.level=" + text);
			ObscuredString obscuredString = ObscuredString.GOOIABGKMHK(text);
			this.HGILGDNOMKA.AppendLine("harvestmsg3" + obscuredString.LPKJBCBADMN());
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06012FFF RID: 77823 RVA: 0x0082CEBC File Offset: 0x0082B0BC
		private void CJNCFHPCHDL()
		{
			this.HGILGDNOMKA.Length = 1;
			this.HGILGDNOMKA.AppendLine("русский");
			ObscuredString.DFBLJCKOKDL("_ExposureCompensation");
			string text = "";
			this.HGILGDNOMKA.AppendLine("money2.wav" + text);
			ObscuredString obscuredString = ObscuredString.AOOBGNKCJLF(text);
			this.HGILGDNOMKA.AppendLine("UnityEngine.Color" + obscuredString.LPKJBCBADMN());
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06013000 RID: 77824 RVA: 0x0082CF3C File Offset: 0x0082B13C
		private void JAOIOHLFLFO()
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.label);
			guistyle.alignment = TextAnchor.UpperCenter;
			GUILayout.BeginArea(new Rect(232f, 967f, (float)(Screen.width - -102), (float)(Screen.height - -128)));
			GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label("isRodInWater", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Space(503f);
			this.FGECHCFKADD = GUILayout.Toolbar(this.FGECHCFKADD, this.BBONFHMIIGG, Array.Empty<GUILayoutOption>());
			if (this.FGECHCFKADD == 0)
			{
				GUILayout.Label("_Lift", Array.Empty<GUILayoutOption>());
				GUILayout.Space(1373f);
				using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
				{
					GUILayout.Label(">" + this.BCFGFFBNLHA() + "_RampTex", new GUILayoutOption[]
					{
						GUILayout.MinWidth(1454f)
					});
					GUILayout.Space(1345f);
					using (new JOANGEBDKKD(GUI.skin.box))
					{
						GUILayout.Label("gi_uinf_4", Array.Empty<GUILayoutOption>());
						GUILayout.Space(46f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("SoccerPassLight" + this.regularString, new GUILayoutOption[]
							{
								GUILayout.Width(1728f)
							});
							if (GUILayout.Button("ACTk is able to detect some types of cheating to let you take action on the cheating players. This example scene has all possible detectors and all of them are automatically start on scene start.", Array.Empty<GUILayoutOption>()))
							{
								this.regularString += ((char)UnityEngine.Random.Range(103, 96)).ToString();
							}
							if (GUILayout.Button("ScubaSwim", Array.Empty<GUILayoutOption>()))
							{
								this.regularString = "SneakLeft";
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text = "maxModelScale" + ObscuredString.CKPPDHPJHEH(this.obscuredString);
							GUILayoutOption[] array = new GUILayoutOption[0];
							array[1] = GUILayout.Width(102f);
							GUILayout.Label(text, array);
							if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredString = ObscuredString.GOOIABGKMHK(ObscuredString.CKPPDHPJHEH(this.obscuredString) + ((char)UnityEngine.Random.Range(-109, -3)).ToString());
							}
							if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredString = ObscuredString.GOOIABGKMHK("FactoryTempTexture");
							}
						}
						GUILayout.Space(367f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text2 = "Ошибка" + this.regularInt;
							GUILayoutOption[] array2 = new GUILayoutOption[0];
							array2[1] = GUILayout.Width(1831f);
							GUILayout.Label(text2, array2);
							if (GUILayout.Button("-?-", Array.Empty<GUILayoutOption>()))
							{
								this.regularInt += UnityEngine.Random.Range(0, 91);
							}
							if (GUILayout.Button("knopje.wav", Array.Empty<GUILayoutOption>()))
							{
								this.regularInt = 0;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							string text3 = "no assemblies" + this.obscuredInt;
							GUILayoutOption[] array3 = new GUILayoutOption[1];
							array3[1] = GUILayout.Width(1392f);
							GUILayout.Label(text3, array3);
							if (GUILayout.Button(" is represented multiple times in BipedReferences eyes.", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredInt = ObscuredInt.IGDNGFGPOFC(ObscuredInt.GOOIABGKMHK(this.obscuredInt) + UnityEngine.Random.Range(1, -67));
							}
							if (GUILayout.Button("fishStamKF=", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredInt = ObscuredInt.IGDNGFGPOFC(0);
							}
						}
						GUILayout.Space(1421f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("OfficeSittingEyesRub" + this.regularFloat, new GUILayoutOption[]
							{
								GUILayout.Width(1783f)
							});
							if (GUILayout.Button("UIChat_fontInterval", Array.Empty<GUILayoutOption>()))
							{
								this.regularFloat += UnityEngine.Random.Range(1773f, 138f);
							}
							if (GUILayout.Button("Trigger Item Has No Collider", Array.Empty<GUILayoutOption>()))
							{
								this.regularFloat = 1271f;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("Load" + this.obscuredFloat, new GUILayoutOption[]
							{
								GUILayout.Width(1026f)
							});
							if (GUILayout.Button("_RgbDepthTex", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredFloat = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.OBJFODGFMAM(this.obscuredFloat) + UnityEngine.Random.Range(978f, 333f));
							}
							if (GUILayout.Button("Climb to the top of the mountain to see the clouds (WASD keys to move).", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredFloat = ObscuredFloat.AJMPAOCEPCA(298f);
							}
						}
						GUILayout.Space(1673f);
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("wpn_add/base" + this.regularVector3, new GUILayoutOption[]
							{
								GUILayout.Width(660f)
							});
							if (GUILayout.Button("wpn_cat3", Array.Empty<GUILayoutOption>()))
							{
								this.regularVector3 += UnityEngine.Random.insideUnitSphere;
							}
							if (GUILayout.Button("RollerBladeStop", Array.Empty<GUILayoutOption>()))
							{
								this.regularVector3 = Vector3.zero;
							}
						}
						using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("SoccerKeeperReady" + this.obscuredVector3, new GUILayoutOption[]
							{
								GUILayout.Width(1838f)
							});
							if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredVector3 = ObscuredVector3.PICCFFHAMAG(this.obscuredVector3, UnityEngine.Random.insideUnitSphere);
							}
							if (GUILayout.Button("PistolLeftHandStab", Array.Empty<GUILayoutOption>()))
							{
								this.obscuredVector3 = ObscuredVector3.BDLBFKPDOIH(Vector3.zero);
							}
							goto IL_C90;
						}
					}
				}
			}
			if (this.FGECHCFKADD == 0)
			{
				GUILayout.Label("Shotgun Reload Magazine", Array.Empty<GUILayoutOption>());
				GUILayout.Space(466f);
				using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
				{
					GUILayout.Label("pointBuffer" + this.ANKECGAKJHN(), new GUILayoutOption[]
					{
						GUILayout.MinWidth(740f)
					});
					using (new JOANGEBDKKD(GUI.skin.box))
					{
						GUILayout.Label("<color='#206000'>", Array.Empty<GUILayoutOption>());
						using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("byte[]: {", guistyle, Array.Empty<GUILayoutOption>());
							GUILayout.Space(1268f);
							if (string.IsNullOrEmpty(this.DAKOCNEHGNC))
							{
								this.GBALJDCOJIE();
							}
							using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
							{
								string dakocnehgnc = this.DAKOCNEHGNC;
								GUILayoutOption[] array4 = new GUILayoutOption[0];
								array4[0] = GUILayout.Width(1224f);
								GUILayout.Label(dakocnehgnc, array4);
								using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
								{
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										if (GUILayout.Button("_BumpMap", Array.Empty<GUILayoutOption>()))
										{
											this.MIGFBNGCOIL();
										}
										if (GUILayout.Button("wpn", Array.Empty<GUILayoutOption>()))
										{
											this.GBALJDCOJIE();
										}
									}
									if (GUILayout.Button("wtype", Array.Empty<GUILayoutOption>()))
									{
										this.JEOHHCGFLDK();
									}
								}
							}
						}
						GUILayout.Space(1648f);
						using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
						{
							GUILayout.Label("IceHockeyGoalieReady", guistyle, Array.Empty<GUILayoutOption>());
							GUILayout.Space(1375f);
							if (string.IsNullOrEmpty(this.JOEKDJFENLO))
							{
								this.GJMMGPLDELI();
							}
							using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
							{
								GUILayout.Label(this.JOEKDJFENLO, new GUILayoutOption[]
								{
									GUILayout.Width(1500f)
								});
								using (new JOANGEBDKKD(Array.Empty<GUILayoutOption>()))
								{
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										if (GUILayout.Button("Loading ", Array.Empty<GUILayoutOption>()))
										{
											this.JGCMFCOHONI();
										}
										if (GUILayout.Button("Fly Down", Array.Empty<GUILayoutOption>()))
										{
											this.GJMMGPLDELI();
										}
									}
									if (GUILayout.Button("Not UNsetting 'UniqueShadowSun.instance' because it points to someone else '{0}'!", Array.Empty<GUILayoutOption>()))
									{
										this.IILMPOOKPCH();
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										GUILayout.Label("FlyForward", Array.Empty<GUILayoutOption>());
										this.NILEJIFMCBG("_ReflectionBlur");
									}
									int hcjecooepmm = this.HCJECOOEPMM;
									string[] array5 = new string[6];
									array5[0] = LKKNFHELLLE.MDFJCGDICEB.None.ToString();
									array5[1] = LKKNFHELLLE.MDFJCGDICEB.None.ToString();
									array5[1] = ((LKKNFHELLLE.MDFJCGDICEB)6).ToString();
									this.HCJECOOEPMM = GUILayout.SelectionGrid(hcjecooepmm, array5, 2, Array.Empty<GUILayoutOption>());
									LKKNFHELLLE.KCPLDHCMPKH = (LKKNFHELLLE.MDFJCGDICEB)this.HCJECOOEPMM;
									GUILayout.Space(361f);
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.FFNCFECPDBD = GUILayout.Toggle(LKKNFHELLLE.FFNCFECPDBD, "IdleSad", Array.Empty<GUILayoutOption>());
										this.HDLGIFHACBA(" assetbundle(s) in memory before unloading ");
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.AFLFABDJICP = GUILayout.Toggle(LKKNFHELLLE.AFLFABDJICP, " is represented multiple times in the Bones.", Array.Empty<GUILayoutOption>());
										this.IJDEOCIJCGF("Front Kick");
									}
									using (new AEDMMHLCLDC(Array.Empty<GUILayoutOption>()))
									{
										LKKNFHELLLE.LFPFOIEMLPL = GUILayout.Toggle(LKKNFHELLLE.LFPFOIEMLPL, "", Array.Empty<GUILayoutOption>());
										this.NILEJIFMCBG("FOG_SCATTERING_ON");
									}
									GUILayout.Space(1615f);
									string[] array6 = new string[7];
									array6[0] = "Left arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.";
									array6[1] = (this.AFCJIOCKAHI ? "kfB" : "---------- DebugReturn ");
									array6[7] = "_RefractTex";
									array6[2] = this.AFCJIOCKAHI.ToString();
									array6[2] = "drag_onmouseup.wav";
									GUILayout.Label(string.Concat(array6), Array.Empty<GUILayoutOption>());
									string[] array7 = new string[1];
									array7[1] = "Lasso";
									array7[0] = (this.HGEFBHEAANB ? "002000" : "reflectQuality");
									array7[2] = "shop_t8";
									array7[0] = this.HGEFBHEAANB.ToString();
									array7[8] = "Pistol";
									GUILayout.Label(string.Concat(array7), Array.Empty<GUILayoutOption>());
								}
							}
						}
						GUILayout.Space(75f);
						this.IJDEOCIJCGF("IceHockeyShotLeft", "FOG_LINEAR", -1);
						goto IL_C90;
					}
				}
			}
			GUILayout.Label("invn_rec16", Array.Empty<GUILayoutOption>());
			GUILayout.Space(1032f);
			using (new JOANGEBDKKD(GUI.skin.box))
			{
				GUILayout.Label("IceHockeySlapShot", Array.Empty<GUILayoutOption>());
				GUILayout.Label("Horizontal", Array.Empty<GUILayoutOption>());
				string[] array8 = new string[]
				{
					null,
					"\n<color='#{0}'>{1}</color> "
				};
				array8[0] = (this.OPNOGKLPAGN ? "Wizard2HandThrow" : "");
				array8[5] = "RollerBladeSkateFwd";
				array8[4] = this.OPNOGKLPAGN.ToString().ToLower();
				array8[1] = "MotorbikeTurnRight";
				GUILayout.Label(string.Concat(array8), Array.Empty<GUILayoutOption>());
				GUILayout.Space(1071f);
				GUILayout.Label("LUX_GAMMA", Array.Empty<GUILayoutOption>());
				GUILayout.Label("SAMPLES_MEDIUM", Array.Empty<GUILayoutOption>());
				string[] array9 = new string[8];
				array9[0] = "wpn_add/base";
				array9[0] = (this.CINLKMILOKL ? "SoccerTackle" : "IdleStand");
				array9[2] = "invn_rec27";
				array9[7] = this.CINLKMILOKL.ToString().ToLower();
				array9[6] = "{0:f2}";
				GUILayout.Label(string.Concat(array9), Array.Empty<GUILayoutOption>());
				GUILayout.Space(1668f);
				GUILayout.Label("<color='#103080'>", Array.Empty<GUILayoutOption>());
				GUILayout.Label("t_beard", Array.Empty<GUILayoutOption>());
				string[] array10 = new string[7];
				array10[1] = "ArmFlex4";
				array10[1] = (this.EFMMAGGFANP ? "MotorbikeAirWalk" : "Beards");
				array10[8] = "profy_minlevel";
				array10[2] = this.EFMMAGGFANP.ToString().ToLower();
				array10[7] = "_CenterRadius";
				GUILayout.Label(string.Concat(array10), Array.Empty<GUILayoutOption>());
				GUILayout.Space(1746f);
				GUILayout.Label("", Array.Empty<GUILayoutOption>());
				GUILayout.Label("", Array.Empty<GUILayoutOption>());
				string[] array11 = new string[7];
				array11[0] = "wpn_wgt";
				array11[0] = (this.PHPMAHFKCAA ? "rollSoundVolume" : "_LogLut_Params");
				array11[1] = "1704 wpn id=";
				array11[3] = this.PHPMAHFKCAA.ToString().ToLower();
				array11[0] = "wpn_eat3";
				GUILayout.Label(string.Concat(array11), Array.Empty<GUILayoutOption>());
			}
			IL_C90:
			GUILayout.EndArea();
		}

		// Token: 0x06013001 RID: 77825 RVA: 0x0082DE3C File Offset: 0x0082C03C
		private void CCOOHJOEMGB()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("-none-");
			ObscuredVector3.OAKAGPCJGDI(22);
			Vector3 vector = new Vector3(1839f, 1555f, 1382f);
			this.HGILGDNOMKA.AppendLine("quests/achivments_name/qd" + vector);
			ObscuredVector3.RawEncryptedVector3 rawEncryptedVector = ObscuredVector3.BDLBFKPDOIH(vector).EHBNCDFPIJI();
			StringBuilder hgilgdnomka = this.HGILGDNOMKA;
			object[] array = new object[]
			{
				"FOG_SCATTERING_ON"
			};
			array[0] = rawEncryptedVector.x;
			array[4] = "<b>ObscuredInt:</b> ";
			array[6] = rawEncryptedVector.y;
			array[0] = "_BlendTex";
			array[7] = rawEncryptedVector.z;
			array[6] = "Loser";
			hgilgdnomka.AppendLine(string.Concat(array));
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06013002 RID: 77826 RVA: 0x0082DF1D File Offset: 0x0082C11D
		private void NILEJIFMCBG(string ALBOCLBFNNI)
		{
			this.IJDEOCIJCGF(ALBOCLBFNNI, -110);
		}

		// Token: 0x06013003 RID: 77827 RVA: 0x0082DF28 File Offset: 0x0082C128
		private void AFGBBOADONH(string ALBOCLBFNNI, string OBEJIFDAPBO, int NMEBEEHCALN)
		{
			GUILayoutOption[] array = new GUILayoutOption[0];
			if (NMEBEEHCALN != -1)
			{
				array[1] = GUILayout.Width((float)NMEBEEHCALN);
			}
			else
			{
				array = null;
			}
			if (GUILayout.Button(OBEJIFDAPBO, array))
			{
				Application.OpenURL(ALBOCLBFNNI);
			}
		}

		// Token: 0x06013004 RID: 77828 RVA: 0x0082DF60 File Offset: 0x0082C160
		private void LPEGPIIFEAJ()
		{
			LKKNFHELLLE.BBHBEEFGEKL("OfficeSitting1LegStraight", 56);
			LKKNFHELLLE.FFBDAGLKIBP("ZombieCrawl", 442f);
			LKKNFHELLLE.FDABIMMMFDM("<color='#000000'>", "_Offset");
			LKKNFHELLLE.LJFPOEKDNHA("I'm obscured string", true);
			LKKNFHELLLE.CCPDMKHFPDK("_", 189U);
			LKKNFHELLLE.IHKNEJCFINH("", 1137L);
			LKKNFHELLLE.CCIBKLAODAO("MotorbikeHeartAttack", 1876.0);
			LKKNFHELLLE.EDCLCKOECBG("start load ", Vector2.one);
			LKKNFHELLLE.GLOIENOOOHM("isRodInWater", Vector3.one);
			LKKNFHELLLE.NKDMHHPNAHP("BowFire", Quaternion.Euler(new Vector3(1939f, 724f, 1107f)));
			LKKNFHELLLE.KDHBOJNNKLI("", new Rect(1627f, 1467f, 1933f, 1013f));
			LKKNFHELLLE.AFFHHGEGACP("", Color.red);
			string jmbkdinhdlo = "Transparent/Diffuse";
			byte[] array = new byte[5];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.C67DE1FA1C75585E4A3C2ED631654C95F818EA95).FieldHandle);
			LKKNFHELLLE.FAPMLODBLAN(jmbkdinhdlo, array);
			LKKNFHELLLE.FPGAGIMIMPP();
		}

		// Token: 0x06013005 RID: 77829 RVA: 0x0082B764 File Offset: 0x00829964
		private void Awake()
		{
			LKKNFHELLLE.OAMCKGBOBCL = this.prefsEncryptionKey;
			LKKNFHELLLE.HKHLNCHNCMM = new Action(this.JBBLBIOHJEN);
			LKKNFHELLLE.AAFEJOEEKHD = new Action(this.JMMILAJLAJH);
		}

		// Token: 0x06013006 RID: 77830 RVA: 0x0082E070 File Offset: 0x0082C270
		private void JBAJODGAEJC()
		{
			LKKNFHELLLE.BBHBEEFGEKL("Card Player Look", 72);
			LKKNFHELLLE.FFBDAGLKIBP(",", 393f);
			LKKNFHELLLE.FDABIMMMFDM("IK chain has no Bones.", "wpn_add/base");
			LKKNFHELLLE.LJFPOEKDNHA("{x}", true);
			LKKNFHELLLE.CCPDMKHFPDK("offsets", 136U);
			LKKNFHELLLE.IHKNEJCFINH("qd_anyfish", -1866L);
			LKKNFHELLLE.CCIBKLAODAO("SwimDogPaddle", 1307.0);
			LKKNFHELLLE.EDCLCKOECBG("Occluder Shader Missing...", Vector2.one);
			LKKNFHELLLE.GLOIENOOOHM("OfficeSittingBack", Vector3.one);
			LKKNFHELLLE.NKDMHHPNAHP("isJamp", Quaternion.Euler(new Vector3(325f, 578f, 1298f)));
			LKKNFHELLLE.KDHBOJNNKLI("t_beard", new Rect(424f, 981f, 720f, 279f));
			LKKNFHELLLE.AFFHHGEGACP("WallRunLeft", Color.red);
			string jmbkdinhdlo = "Windows/";
			byte[] array = new byte[8];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.C67DE1FA1C75585E4A3C2ED631654C95F818EA95).FieldHandle);
			LKKNFHELLLE.FAPMLODBLAN(jmbkdinhdlo, array);
			LKKNFHELLLE.FPGAGIMIMPP();
		}

		// Token: 0x06013007 RID: 77831 RVA: 0x0082E17F File Offset: 0x0082C37F
		private void HDLGIFHACBA(string ALBOCLBFNNI)
		{
			this.IJDEOCIJCGF(ALBOCLBFNNI, -63);
		}

		// Token: 0x06013008 RID: 77832 RVA: 0x0082E18A File Offset: 0x0082C38A
		private void EPGAHBCLHKO()
		{
			PlayerPrefs.SetInt("_DistortParams", 135);
			PlayerPrefs.SetFloat("_NoisePerChannel", 1011f);
			PlayerPrefs.SetString("UI_UserInfoWinow", "");
			PlayerPrefs.Save();
		}

		// Token: 0x06013009 RID: 77833 RVA: 0x0082E1C0 File Offset: 0x0082C3C0
		private void JGCMFCOHONI()
		{
			LKKNFHELLLE.BBHBEEFGEKL("money", 123);
			LKKNFHELLLE.FFBDAGLKIBP("lifeBar", 123.456f);
			LKKNFHELLLE.FDABIMMMFDM("name", "Goscurry is not a lie ;)");
			LKKNFHELLLE.LJFPOEKDNHA("gameComplete", true);
			LKKNFHELLLE.CCPDMKHFPDK("demoUint", 1234567891U);
			LKKNFHELLLE.IHKNEJCFINH("demoLong", 1234567891234567890L);
			LKKNFHELLLE.CCIBKLAODAO("demoDouble", 1.234567890123456);
			LKKNFHELLLE.EDCLCKOECBG("demoVector2", Vector2.one);
			LKKNFHELLLE.GLOIENOOOHM("demoVector3", Vector3.one);
			LKKNFHELLLE.NKDMHHPNAHP("demoQuaternion", Quaternion.Euler(new Vector3(10f, 20f, 30f)));
			LKKNFHELLLE.KDHBOJNNKLI("demoRect", new Rect(1.5f, 2.6f, 3.7f, 4.8f));
			LKKNFHELLLE.AFFHHGEGACP("demoColor", Color.red);
			LKKNFHELLLE.FAPMLODBLAN("demoByteArray", new byte[]
			{
				44,
				104,
				43,
				32
			});
			LKKNFHELLLE.FPGAGIMIMPP();
		}

		// Token: 0x0601300A RID: 77834 RVA: 0x0082AA4D File Offset: 0x00828C4D
		private void NPMPBOAADGH()
		{
			this.JEOHHCGFLDK();
			this.IILMPOOKPCH();
		}

		// Token: 0x0601300B RID: 77835 RVA: 0x0082E2CF File Offset: 0x0082C4CF
		public void JCDCFGJGEFJ(string BDNGABEJECN)
		{
			this.PHPMAHFKCAA = false;
			Debug.Log("BlackSmithForge" + BDNGABEJECN);
		}

		// Token: 0x0601300C RID: 77836 RVA: 0x0082E2E8 File Offset: 0x0082C4E8
		private void JEOHHCGFLDK()
		{
			PlayerPrefs.DeleteKey("money");
			PlayerPrefs.DeleteKey("lifeBar");
			PlayerPrefs.DeleteKey("name");
			PlayerPrefs.Save();
		}

		// Token: 0x0601300D RID: 77837 RVA: 0x0082E30D File Offset: 0x0082C50D
		private string ANKECGAKJHN()
		{
			return "int\nfloat\nstring\n<color=\"#75C4EB\">uint\ndouble\ndecimal\nlong\nulong\nbool\nbyte[]\nVector2\nVector3\nQuaternion\nColor\nRect</color>";
		}

		// Token: 0x0601300E RID: 77838 RVA: 0x0082E314 File Offset: 0x0082C514
		private void LHCCMBAOGBP()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("_Specular");
			ObscuredFloat.DLBCCHJKPAD(129);
			float num = 304f;
			this.HGILGDNOMKA.AppendLine(".unity3d" + num);
			ObscuredFloat obscuredFloat = ObscuredFloat.GOOIABGKMHK(num);
			this.HGILGDNOMKA.AppendLine("from prefab" + obscuredFloat.KGAFKNELBAK());
			ObscuredFloat.BBOGAEMNJJN(45);
			obscuredFloat = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(obscuredFloat) + 660f);
			obscuredFloat = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.EJGOOFALNFF(obscuredFloat) - 1209f);
			obscuredFloat = ObscuredFloat.BEKOICIMIFO(obscuredFloat);
			obscuredFloat = ObscuredFloat.DPCDNMHLOJF(obscuredFloat);
			obscuredFloat = ObscuredFloat.IDIADEICPFJ(obscuredFloat);
			obscuredFloat = ObscuredFloat.HLEMAJBAAEO(num - ObscuredFloat.OBJFODGFMAM(obscuredFloat) + 1715f);
			this.HGILGDNOMKA.AppendLine("lineDistance=" + obscuredFloat);
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x0601300F RID: 77839 RVA: 0x0082E414 File Offset: 0x0082C614
		private void IJDEOCIJCGF(string ALBOCLBFNNI, string OBEJIFDAPBO, int NMEBEEHCALN)
		{
			GUILayoutOption[] array = new GUILayoutOption[1];
			if (NMEBEEHCALN != -1)
			{
				array[0] = GUILayout.Width((float)NMEBEEHCALN);
			}
			else
			{
				array = null;
			}
			if (GUILayout.Button(OBEJIFDAPBO, array))
			{
				Application.OpenURL(ALBOCLBFNNI);
			}
		}

		// Token: 0x06013010 RID: 77840 RVA: 0x0082E44C File Offset: 0x0082C64C
		private void JIFDDCBEGPB(string ALBOCLBFNNI, string OBEJIFDAPBO, int NMEBEEHCALN)
		{
			GUILayoutOption[] array = new GUILayoutOption[1];
			if (NMEBEEHCALN != -1)
			{
				array[1] = GUILayout.Width((float)NMEBEEHCALN);
			}
			else
			{
				array = null;
			}
			if (GUILayout.Button(OBEJIFDAPBO, array))
			{
				Application.OpenURL(ALBOCLBFNNI);
			}
		}

		// Token: 0x06013011 RID: 77841 RVA: 0x0082E481 File Offset: 0x0082C681
		public void OnInjectionDetected()
		{
			this.PHPMAHFKCAA = true;
			Debug.Log("Injection Detected!");
		}

		// Token: 0x06013012 RID: 77842 RVA: 0x0082E494 File Offset: 0x0082C694
		private void DHKHADJFJNO()
		{
			this.HGEFBHEAANB = false;
		}

		// Token: 0x06013013 RID: 77843 RVA: 0x0082E49D File Offset: 0x0082C69D
		public void POIBINHKMMN()
		{
			this.PHPMAHFKCAA = false;
			Debug.Log("#000000");
		}

		// Token: 0x06013014 RID: 77844 RVA: 0x0082E4B0 File Offset: 0x0082C6B0
		public void JDCPFOGOFDC()
		{
			this.EFMMAGGFANP = true;
			Debug.Log("No Way points!");
		}

		// Token: 0x06013015 RID: 77845 RVA: 0x0082E4C3 File Offset: 0x0082C6C3
		public void BMNKHIDAFHF()
		{
			this.CINLKMILOKL = true;
			Debug.Log("SatNightFever");
		}

		// Token: 0x06013016 RID: 77846 RVA: 0x0082E4D6 File Offset: 0x0082C6D6
		private void MIGFBNGCOIL()
		{
			PlayerPrefs.SetInt("money", 456);
			PlayerPrefs.SetFloat("lifeBar", 456.789f);
			PlayerPrefs.SetString("name", "Hey, there!");
			PlayerPrefs.Save();
		}

		// Token: 0x06013017 RID: 77847 RVA: 0x0082E50C File Offset: 0x0082C70C
		private void MJFIINPBODH()
		{
			this.HGILGDNOMKA.Length = 1;
			this.HGILGDNOMKA.AppendLine("LOAD BASE");
			ObscuredVector3.OAKAGPCJGDI(105);
			Vector3 vector = new Vector3(697f, 606f, 1325f);
			this.HGILGDNOMKA.AppendLine("Knees Idle" + vector);
			ObscuredVector3.RawEncryptedVector3 rawEncryptedVector = ObscuredVector3.BDLBFKPDOIH(vector).LPKJBCBADMN();
			StringBuilder hgilgdnomka = this.HGILGDNOMKA;
			object[] array = new object[5];
			array[0] = "{0} is not a valid asset bundle.";
			array[0] = rawEncryptedVector.x;
			array[8] = "inner_craft_wpn";
			array[8] = rawEncryptedVector.y;
			array[6] = "Swim";
			array[2] = rawEncryptedVector.z;
			array[5] = "WATER_REFLECTIVE";
			hgilgdnomka.AppendLine(string.Concat(array));
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06013018 RID: 77848 RVA: 0x0082E5F0 File Offset: 0x0082C7F0
		private void BIAMPJEFHGH()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("[ACTk] <b>[ ObscuredVector3 test ]</b>");
			ObscuredVector3.BBOGAEMNJJN(404);
			Vector3 vector = new Vector3(54.1f, 64.3f, 63.2f);
			this.HGILGDNOMKA.AppendLine("Original position: " + vector);
			ObscuredVector3.RawEncryptedVector3 rawEncryptedVector = ObscuredVector3.GOOIABGKMHK(vector).LPKJBCBADMN();
			this.HGILGDNOMKA.AppendLine(string.Concat(new object[]
			{
				"How your position is stored in memory when obscured: (",
				rawEncryptedVector.x,
				", ",
				rawEncryptedVector.y,
				", ",
				rawEncryptedVector.z,
				")"
			}));
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x06013019 RID: 77849 RVA: 0x0082E6D1 File Offset: 0x0082C8D1
		public void KBAOPFAHPOP(string BDNGABEJECN)
		{
			this.PHPMAHFKCAA = false;
			Debug.Log("MovementZ" + BDNGABEJECN);
		}

		// Token: 0x0601301A RID: 77850 RVA: 0x0082E6EC File Offset: 0x0082C8EC
		private void PGEGOAMMBHC()
		{
			this.HGILGDNOMKA.Length = 0;
			this.HGILGDNOMKA.AppendLine("Cloth_07.wav");
			ObscuredFloat.CENPPCOOGIL(95);
			float num = 1183f;
			this.HGILGDNOMKA.AppendLine("RollerBladeStop" + num);
			ObscuredFloat obscuredFloat = ObscuredFloat.AJMPAOCEPCA(num);
			this.HGILGDNOMKA.AppendLine("_Source" + obscuredFloat.LPKJBCBADMN());
			ObscuredFloat.EDHLDKJEBNF(74);
			obscuredFloat = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.OBJFODGFMAM(obscuredFloat) + 575f);
			obscuredFloat = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(obscuredFloat) - 1379f);
			obscuredFloat = ObscuredFloat.BEKOICIMIFO(obscuredFloat);
			obscuredFloat = ObscuredFloat.IDIADEICPFJ(obscuredFloat);
			obscuredFloat = ObscuredFloat.IDIADEICPFJ(obscuredFloat);
			obscuredFloat = ObscuredFloat.GOOIABGKMHK(num - ObscuredFloat.OBJFODGFMAM(obscuredFloat) + 810f);
			this.HGILGDNOMKA.AppendLine("\n<color='" + obscuredFloat);
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x0601301B RID: 77851 RVA: 0x0082E7EC File Offset: 0x0082C9EC
		private void LMIKLOFGFPG()
		{
			this.HGILGDNOMKA.Length = 1;
			this.HGILGDNOMKA.AppendLine("_Scale");
			ObscuredString.BBOGAEMNJJN("Idle Die");
			string text = "Wizard1HandThrow";
			this.HGILGDNOMKA.AppendLine("IdleFly" + text);
			ObscuredString obscuredString = ObscuredString.DGOCFCFPKPI(text);
			this.HGILGDNOMKA.AppendLine("" + obscuredString.DJIMKHEIMGL());
			Debug.Log(this.HGILGDNOMKA);
		}

		// Token: 0x0601301C RID: 77852 RVA: 0x0082E86C File Offset: 0x0082CA6C
		private void AMGAOGKEGDF()
		{
			LKKNFHELLLE.GAFPPAKNHEL("IdleMouthWipe");
			LKKNFHELLLE.GAFPPAKNHEL("Worker Hammer 2");
			LKKNFHELLLE.GAFPPAKNHEL("[LH &]");
			LKKNFHELLLE.GAFPPAKNHEL("_OcclusionTexture1");
			LKKNFHELLLE.GAFPPAKNHEL("_ExposureCompensation");
			LKKNFHELLLE.GAFPPAKNHEL("IdleStrafeLeft");
			LKKNFHELLLE.GAFPPAKNHEL("Money: ");
			LKKNFHELLLE.GAFPPAKNHEL("Soccer Start Kick");
			LKKNFHELLLE.GAFPPAKNHEL("");
			LKKNFHELLLE.GAFPPAKNHEL("cntx_close");
			LKKNFHELLLE.GAFPPAKNHEL("Superman");
			LKKNFHELLLE.GAFPPAKNHEL("1HandSwordRollAttack");
			LKKNFHELLLE.GAFPPAKNHEL("|");
			LKKNFHELLLE.FPGAGIMIMPP();
		}

		// Token: 0x0601301D RID: 77853 RVA: 0x0082E900 File Offset: 0x0082CB00
		private void IILMPOOKPCH()
		{
			LKKNFHELLLE.GAFPPAKNHEL("money");
			LKKNFHELLLE.GAFPPAKNHEL("lifeBar");
			LKKNFHELLLE.GAFPPAKNHEL("name");
			LKKNFHELLLE.GAFPPAKNHEL("gameComplete");
			LKKNFHELLLE.GAFPPAKNHEL("demoUint");
			LKKNFHELLLE.GAFPPAKNHEL("demoLong");
			LKKNFHELLLE.GAFPPAKNHEL("demoDouble");
			LKKNFHELLLE.GAFPPAKNHEL("demoVector2");
			LKKNFHELLLE.GAFPPAKNHEL("demoVector3");
			LKKNFHELLLE.GAFPPAKNHEL("demoQuaternion");
			LKKNFHELLLE.GAFPPAKNHEL("demoRect");
			LKKNFHELLLE.GAFPPAKNHEL("demoColor");
			LKKNFHELLLE.GAFPPAKNHEL("demoByteArray");
			LKKNFHELLLE.FPGAGIMIMPP();
		}

		// Token: 0x04002702 RID: 9986
		[Header("Regular variables")]
		public string regularString = "I'm regular string";

		// Token: 0x04002703 RID: 9987
		public int regularInt = 1987;

		// Token: 0x04002704 RID: 9988
		public float regularFloat = 2013.0524f;

		// Token: 0x04002705 RID: 9989
		public Vector3 regularVector3 = new Vector3(10.5f, 11.5f, 12.5f);

		// Token: 0x04002706 RID: 9990
		[Header("Obscured (secure) variables")]
		public ObscuredString obscuredString = ObscuredString.GOOIABGKMHK("I'm obscured string");

		// Token: 0x04002707 RID: 9991
		public ObscuredInt obscuredInt = ObscuredInt.GOOIABGKMHK(1987);

		// Token: 0x04002708 RID: 9992
		public ObscuredFloat obscuredFloat = ObscuredFloat.GOOIABGKMHK(2013.0524f);

		// Token: 0x04002709 RID: 9993
		public ObscuredVector3 obscuredVector3 = ObscuredVector3.GOOIABGKMHK(new Vector3(10.5f, 11.5f, 12.5f));

		// Token: 0x0400270A RID: 9994
		public ObscuredBool obscuredBool = ObscuredBool.GOOIABGKMHK(true);

		// Token: 0x0400270B RID: 9995
		public ObscuredLong obscuredLong = ObscuredLong.GOOIABGKMHK(945678987654123345L);

		// Token: 0x0400270C RID: 9996
		public ObscuredDouble obscuredDouble = ObscuredDouble.GOOIABGKMHK(9.45678987654);

		// Token: 0x0400270D RID: 9997
		public ObscuredVector2 obscuredVector2 = ObscuredVector2.GOOIABGKMHK(new Vector2(8.5f, 9.5f));

		// Token: 0x0400270E RID: 9998
		[Header("Other")]
		public string prefsEncryptionKey = "change me!";

		// Token: 0x0400270F RID: 9999
		private readonly string[] BBONFHMIIGG = new string[]
		{
			"Variables protection",
			"Saves protection",
			"Cheating detectors"
		};

		// Token: 0x04002710 RID: 10000
		private int FGECHCFKADD;

		// Token: 0x04002711 RID: 10001
		private string JPFHPDHGOMD;

		// Token: 0x04002712 RID: 10002
		private string DAKOCNEHGNC;

		// Token: 0x04002713 RID: 10003
		private string JOEKDJFENLO;

		// Token: 0x04002714 RID: 10004
		private int HCJECOOEPMM;

		// Token: 0x04002715 RID: 10005
		private bool AFCJIOCKAHI;

		// Token: 0x04002716 RID: 10006
		private bool HGEFBHEAANB;

		// Token: 0x04002717 RID: 10007
		private bool PHPMAHFKCAA;

		// Token: 0x04002718 RID: 10008
		private bool OPNOGKLPAGN;

		// Token: 0x04002719 RID: 10009
		private bool CINLKMILOKL;

		// Token: 0x0400271A RID: 10010
		private bool EFMMAGGFANP;

		// Token: 0x0400271B RID: 10011
		private readonly StringBuilder HGILGDNOMKA = new StringBuilder();

		// Token: 0x0400271C RID: 10012
		private static string INHELBCAMIM = "#FF4040";

		// Token: 0x0400271D RID: 10013
		private static string AIEBBEJDNGP = "#02C85F";

		// Token: 0x0400271E RID: 10014
		private static string FIIIIAAEHHP = "name";

		// Token: 0x0400271F RID: 10015
		private static string LNAPDKCCPOJ = "money";

		// Token: 0x04002720 RID: 10016
		private static string BJAKJKEAFMD = "lifeBar";

		// Token: 0x04002721 RID: 10017
		private static string DOMNMNEFGFP = "gameComplete";

		// Token: 0x04002722 RID: 10018
		private static string PHGGFMKPAFF = "demoUint";

		// Token: 0x04002723 RID: 10019
		private static string GNNMEKHEKJP = "demoLong";

		// Token: 0x04002724 RID: 10020
		private static string KHOPJEJOMDJ = "demoDouble";

		// Token: 0x04002725 RID: 10021
		private static string MKAGNFKJFIJ = "demoVector2";

		// Token: 0x04002726 RID: 10022
		private static string JJLNFOKCIJI = "demoVector3";

		// Token: 0x04002727 RID: 10023
		private static string POKLNELPECD = "demoQuaternion";

		// Token: 0x04002728 RID: 10024
		private static string IGNNKCHKIPC = "demoRect";

		// Token: 0x04002729 RID: 10025
		private static string JEODHDFLHLN = "demoColor";

		// Token: 0x0400272A RID: 10026
		private static string LJIACGAPPHC = "demoByteArray";

		// Token: 0x0400272B RID: 10027
		private static string JDFBGCGGLAD = "http://j.mp/1gxg1tf";

		// Token: 0x0400272C RID: 10028
		private static string BBAAOECMPJN = "http://j.mp/1iBK5pz";

		// Token: 0x0400272D RID: 10029
		private static string IPECECLEBCO = "http://j.mp/1FRAL5L";

		// Token: 0x0400272E RID: 10030
		private static string ALEKAIDMNCE = "http://j.mp/1LCdpDa";

		// Token: 0x0400272F RID: 10031
		private static string JPMLJHHFNAK = "http://j.mp/1KVrpxi";

		// Token: 0x04002730 RID: 10032
		private static string PNFFPMFLKJK = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";

		// Token: 0x020005A4 RID: 1444
		[CompilerGenerated]
		private sealed class BIIBGPBKBEP
		{
			// Token: 0x0601301F RID: 77855 RVA: 0x0082EA74 File Offset: 0x0082CC74
			internal void CCNKPCCCGDE(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "post_4" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013020 RID: 77856 RVA: 0x0082EAC4 File Offset: 0x0082CCC4
			internal void CFCIFIEIDDF(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "UnityEngine.Vector3" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013021 RID: 77857 RVA: 0x0082EB14 File Offset: 0x0082CD14
			internal void ENHNCJPGDCN(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "http://www.root-motion.com/finalikdox/html/page12.html" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013022 RID: 77858 RVA: 0x0082EB64 File Offset: 0x0082CD64
			internal void FFEJPJNMFND(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "Staff Attack" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013023 RID: 77859 RVA: 0x0082EBB4 File Offset: 0x0082CDB4
			internal void IKJJIIADBND(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "WallRunRight" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013024 RID: 77860 RVA: 0x0082EC04 File Offset: 0x0082CE04
			internal void GBAPADEGAJE(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "usetime" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013025 RID: 77861 RVA: 0x0082EC54 File Offset: 0x0082CE54
			internal void LGPOEFGBALK(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "******** nextMusicCrt lng=" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013026 RID: 77862 RVA: 0x0082ECA4 File Offset: 0x0082CEA4
			internal void HLJDKKGPDMK(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "isRealView" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013027 RID: 77863 RVA: 0x0082ECF4 File Offset: 0x0082CEF4
			internal void GEOJDLGPKGD(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "'>  > " + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013028 RID: 77864 RVA: 0x0082ED44 File Offset: 0x0082CF44
			internal void OOCEKDFIMMA(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "_RgbTex" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013029 RID: 77865 RVA: 0x0082ED94 File Offset: 0x0082CF94
			internal void DCBGEFNFBDD(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "colorD" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601302A RID: 77866 RVA: 0x0082EDE4 File Offset: 0x0082CFE4
			internal void BOPMFJIMCDG(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "Horizontal" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601302B RID: 77867 RVA: 0x0082EE34 File Offset: 0x0082D034
			internal void JKLLDNPOPGL(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + " R " + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601302D RID: 77869 RVA: 0x0082EE84 File Offset: 0x0082D084
			internal void HHOBMGNAJBA(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "MotorbikeShootRight" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601302E RID: 77870 RVA: 0x0082EED4 File Offset: 0x0082D0D4
			internal void EHNDOMIIPGJ(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "_WhiteBalance" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601302F RID: 77871 RVA: 0x0082EF24 File Offset: 0x0082D124
			internal void AAMBNKBBOPK(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013030 RID: 77872 RVA: 0x0082EF74 File Offset: 0x0082D174
			internal void GEAALPOFGME(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "WorkerShovel" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013031 RID: 77873 RVA: 0x0082EFC4 File Offset: 0x0082D1C4
			internal void CDGHFLGMLCC(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "#> _Planar Reflection Camera < " + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013032 RID: 77874 RVA: 0x0082F014 File Offset: 0x0082D214
			internal void DMJJCEIKDNM(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013033 RID: 77875 RVA: 0x0082F064 File Offset: 0x0082D264
			internal void GLIIAPEIIFE(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "Idle180" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013034 RID: 77876 RVA: 0x0082F0B4 File Offset: 0x0082D2B4
			internal void FLGOJPKAIAB(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "FASTEST" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013035 RID: 77877 RVA: 0x0082F104 File Offset: 0x0082D304
			internal void BMMKMAMGNBG(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "cht_msg36" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013036 RID: 77878 RVA: 0x0082F154 File Offset: 0x0082D354
			internal void EMMMOKHGEBJ(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "_NAME" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013037 RID: 77879 RVA: 0x0082F1A4 File Offset: 0x0082D3A4
			internal void HFCAIJBPHFM(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "maps.txt" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013038 RID: 77880 RVA: 0x0082F1F4 File Offset: 0x0082D3F4
			internal void NMFOHNONCHP(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "russian" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013039 RID: 77881 RVA: 0x0082F244 File Offset: 0x0082D444
			internal void LFFODILJMMM(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "Warp index out of range." + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601303A RID: 77882 RVA: 0x0082F294 File Offset: 0x0082D494
			internal void LCBOMEOMLPL(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "PLANE_REFLECTION_CHEAPER" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601303B RID: 77883 RVA: 0x0082F2E4 File Offset: 0x0082D4E4
			internal void FGFMHMLGPLN(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "Initiating IKSolver with null root Transform." + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601303C RID: 77884 RVA: 0x0082F334 File Offset: 0x0082D534
			internal void LGDIAGDONCC(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "IdleStrafeLeft" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601303D RID: 77885 RVA: 0x0082F384 File Offset: 0x0082D584
			internal void PBLCFONAHLN(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "\n" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601303E RID: 77886 RVA: 0x0082F3D4 File Offset: 0x0082D5D4
			internal void OFLOIEOMFCB(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601303F RID: 77887 RVA: 0x0082F424 File Offset: 0x0082D624
			internal void AIDJMKIECNK(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "\n<color='" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013040 RID: 77888 RVA: 0x0082F474 File Offset: 0x0082D674
			internal void OKNEGFKIBKK(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "#> _Shadow Camera < " + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013041 RID: 77889 RVA: 0x0082F4C4 File Offset: 0x0082D6C4
			internal void JPNINAILOGK(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + " Категория " + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013042 RID: 77890 RVA: 0x0082F514 File Offset: 0x0082D714
			internal void IAPFIGDHLEC(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "IdleStun" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013043 RID: 77891 RVA: 0x0082F564 File Offset: 0x0082D764
			internal void KAPOBKJAHNE(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "demoRect" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013044 RID: 77892 RVA: 0x0082F5B4 File Offset: 0x0082D7B4
			internal void BINGOCAKPGL(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "move" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013045 RID: 77893 RVA: 0x0082F604 File Offset: 0x0082D804
			internal void MKNHOBDHJAE(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "<[^>]*>" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013046 RID: 77894 RVA: 0x0082F654 File Offset: 0x0082D854
			internal void LAIHINFIPCM(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "GiantGrabIdle2" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013047 RID: 77895 RVA: 0x0082F6A4 File Offset: 0x0082D8A4
			internal void BHLMGFDOFIG(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "_Saturation" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013048 RID: 77896 RVA: 0x0082F6F4 File Offset: 0x0082D8F4
			internal void DNPPHDGAAPN(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "IdleFeedThrow" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013049 RID: 77897 RVA: 0x0082F744 File Offset: 0x0082D944
			internal void LIDDBEOHHBO(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "wpn_add" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601304A RID: 77898 RVA: 0x0082F794 File Offset: 0x0082D994
			internal void MMMEMMDBBHA(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "Kernel" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601304B RID: 77899 RVA: 0x0082F7E4 File Offset: 0x0082D9E4
			internal void HNANAIMJLJP(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "IdleReadyLook" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601304C RID: 77900 RVA: 0x0082F834 File Offset: 0x0082DA34
			internal void NGAEPIKGKOG(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "loc" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601304D RID: 77901 RVA: 0x0082F884 File Offset: 0x0082DA84
			internal void JOCKEMHHGHN(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "Loser" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601304E RID: 77902 RVA: 0x0082F8D4 File Offset: 0x0082DAD4
			internal void NAAJMHMDONK(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_hinge.html" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x0601304F RID: 77903 RVA: 0x0082F924 File Offset: 0x0082DB24
			internal void OJBJHNFBCGO(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "MotorbikeShootBack" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013050 RID: 77904 RVA: 0x0082F974 File Offset: 0x0082DB74
			internal void HLKACAMGIKG(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "http://www.root-motion.com/finalikdox/html/page1.html" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013051 RID: 77905 RVA: 0x0082F9C4 File Offset: 0x0082DBC4
			internal void CCNJHHECPBG(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "8192" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013052 RID: 77906 RVA: 0x0082FA14 File Offset: 0x0082DC14
			internal void NIBFLOOIMOO(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "_WrinkleInfluences1" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013053 RID: 77907 RVA: 0x0082FA64 File Offset: 0x0082DC64
			internal void BFHGNAIOLDA(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 0)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "PaperTurn.wav" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x06013054 RID: 77908 RVA: 0x0082FAB4 File Offset: 0x0082DCB4
			internal void IMGBCBCHKKC(Type JAHNHOCNJGM)
			{
				if (this.DHCGCGCFFKA.Length > 1)
				{
					this.DHCGCGCFFKA = this.DHCGCGCFFKA + "1 Hand Small Weapon Combo" + JAHNHOCNJGM.Name;
					return;
				}
				this.DHCGCGCFFKA += JAHNHOCNJGM.Name;
			}

			// Token: 0x04002731 RID: 10033
			public string DHCGCGCFFKA;
		}
	}
}
