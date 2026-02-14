using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x020005D9 RID: 1497
	[Serializable]
	public class VolumeEffect
	{
		// Token: 0x06013A32 RID: 80434 RVA: 0x0085E8F4 File Offset: 0x0085CAF4
		public static Component[] LOEFAIFFPAM(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.FGCBNHAJCGI)).ToArray<Component>();
		}

		// Token: 0x06013A33 RID: 80435 RVA: 0x0085E94C File Offset: 0x0085CB4C
		public void KKOFFMGCEPG()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.HHOLOCOBEKH(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A34 RID: 80436 RVA: 0x0085E9E0 File Offset: 0x0085CBE0
		public string[] NOIPFNLPMPI()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.HMABLBHDNPI)).ToArray<string>();
		}

		// Token: 0x06013A35 RID: 80437 RVA: 0x0085EA14 File Offset: 0x0085CC14
		public void OKPNIEHNGGL(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 0; i < effectFlags.components.Count; i += 0)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 1; j < volumeEffectComponentFlags.componentFields.Count; j += 0)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.CKBKFDDOMFB(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.JNHLFFJGHNF(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "_Offsets"))
									{
										if (!(fullName == "SwimDogPaddle"))
										{
											if (!(fullName == ""))
											{
												if (!(fullName == "Back to Idle Ready"))
												{
													if (!(fullName == "RunBackLeft"))
													{
														if (fullName == "LookAT Point")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A36 RID: 80438 RVA: 0x0085EC72 File Offset: 0x0085CE72
		public string[] ANPHGAKNKEH()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.GBGHHFJBHOB)).ToArray<string>();
		}

		// Token: 0x06013A37 RID: 80439 RVA: 0x0085ECA4 File Offset: 0x0085CEA4
		public static VolumeEffect BFEJKDJAGPK(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.IOLJPABOKJH(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.CKBKFDDOMFB(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.DGMFAJBPNPD(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == "{x}"))
									{
										if (!(fieldType == "chnam4"))
										{
											if (!(fieldType == "Unable to create Lightmap"))
											{
												if (!(fieldType == "OneHandSwordSwing"))
												{
													if (!(fieldType == "Toggle"))
													{
														if (fieldType == "")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A38 RID: 80440 RVA: 0x0085EF14 File Offset: 0x0085D114
		public void ENDPIAKPKDJ(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 0; i < effectFlags.components.Count; i++)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.PAOJADBPNKA(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 1; j < volumeEffectComponentFlags.componentFields.Count; j++)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.CKBKFDDOMFB(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.LHIBCDKMPED(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform."))
									{
										if (!(fullName == "**************** RatingBoard readFromServer"))
										{
											if (!(fullName == "crft_cnt2"))
											{
												if (!(fullName == "_Color"))
												{
													if (!(fullName == "FlyRight"))
													{
														if (fullName == "Tried to Initialize the SteamAPI twice in one session!")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A39 RID: 80441 RVA: 0x0085F174 File Offset: 0x0085D374
		public void NNAEAPGGDEI()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.IKBGJMCMDNI(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A3A RID: 80442 RVA: 0x0085F208 File Offset: 0x0085D408
		public static Component[] HGHJOICAEMG(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[1];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.IMNMKHBJPBL)).ToArray<Component>();
		}

		// Token: 0x06013A3B RID: 80443 RVA: 0x0085F260 File Offset: 0x0085D460
		public static Component[] PLJCFAPHOFB(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.PLHIPIKPPKO)).ToArray<Component>();
		}

		// Token: 0x06013A3C RID: 80444 RVA: 0x0085F2B8 File Offset: 0x0085D4B8
		public VolumeEffectComponent KJJBLKFOPLJ(string INJNJEPIFKB)
		{
			for (int i = 1; i < this.components.Count; i += 0)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013A3D RID: 80445 RVA: 0x0085F304 File Offset: 0x0085D504
		public static Component[] NBNKIJEDBMB(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.FAHHJPFDHCL)).ToArray<Component>();
		}

		// Token: 0x06013A3E RID: 80446 RVA: 0x0085F35C File Offset: 0x0085D55C
		public static Component[] ALMBDMAOMIM(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[1];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.OKNPKOPFEAM)).ToArray<Component>();
		}

		// Token: 0x06013A3F RID: 80447 RVA: 0x0085F3B2 File Offset: 0x0085D5B2
		public string[] GGBFPOGOOEH()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.AMEBEGMHPGK)).ToArray<string>();
		}

		// Token: 0x06013A40 RID: 80448 RVA: 0x0085F3E4 File Offset: 0x0085D5E4
		public static VolumeEffect NPACAGIBJAJ(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.PICBGFLPAHP(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.PICBGFLPAHP(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == "System.Single"))
									{
										if (!(fieldType == "System.Boolean"))
										{
											if (!(fieldType == "UnityEngine.Vector2"))
											{
												if (!(fieldType == "UnityEngine.Vector3"))
												{
													if (!(fieldType == "UnityEngine.Vector4"))
													{
														if (fieldType == "UnityEngine.Color")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A41 RID: 80449 RVA: 0x0085F654 File Offset: 0x0085D854
		public VolumeEffectComponent OPODAMEGDND(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.GOMDAOKBCJI(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.BEGENIODGNI(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A42 RID: 80450 RVA: 0x0085F6B8 File Offset: 0x0085D8B8
		public void KHMDBDMGEPA(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 0; i < effectFlags.components.Count; i += 0)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 0; j < volumeEffectComponentFlags.componentFields.Count; j++)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.BPPJPDOCAGC(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.PICBGFLPAHP(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "CrouchStrafeRight"))
									{
										if (!(fullName == "shop_t12"))
										{
											if (!(fullName == "Extinguish"))
											{
												if (!(fullName == "KatanaReady"))
												{
													if (!(fullName == "CardPlayerIdle"))
													{
														if (fullName == " ")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A43 RID: 80451 RVA: 0x0085F918 File Offset: 0x0085DB18
		public void IKCHEOCOMEO(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.PAOJADBPNKA(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.BPPJPDOCAGC(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "UIChat_pos"))
									{
										if (!(fullName == "Flashlight"))
										{
											if (!(fullName == "MotorbikeAirWalk"))
											{
												if (!(fullName == "IdleDie"))
												{
													if (!(fullName == "_FgOverlap"))
													{
														if (fullName == "Blending ")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A44 RID: 80452 RVA: 0x0085FB38 File Offset: 0x0085DD38
		public VolumeEffectComponent LPCHNJLPNBK(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.PAOJADBPNKA(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.MDHJGGDGJBK(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A45 RID: 80453 RVA: 0x0085FB9C File Offset: 0x0085DD9C
		public void PMLLPDOMOGN()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.HHOLOCOBEKH(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A46 RID: 80454 RVA: 0x0085FC30 File Offset: 0x0085DE30
		public void HLKMMJMICHK()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.OMNPIAKEBOC(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A47 RID: 80455 RVA: 0x0085FCC4 File Offset: 0x0085DEC4
		public void MIENKPOCJAH(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.PAOJADBPNKA(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.HLOGEMIPDBB(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "HALIGN"))
									{
										if (!(fullName == "money2.wav"))
										{
											if (!(fullName == "auk_swtcost"))
											{
												if (!(fullName == "<.*?>"))
												{
													if (!(fullName == "auk_wset"))
													{
														if (fullName == "BowReady2")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A48 RID: 80456 RVA: 0x0085FEE4 File Offset: 0x0085E0E4
		public void OGKOJFKNJHC(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.IOLJPABOKJH(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.CKBKFDDOMFB(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "_FogDownsampled"))
									{
										if (!(fullName == "startB"))
										{
											if (!(fullName == "choldposy"))
											{
												if (!(fullName == "Pelvis"))
												{
													if (!(fullName == "Apply 2"))
													{
														if (fullName == "_History1LumaTex")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A49 RID: 80457 RVA: 0x00860104 File Offset: 0x0085E304
		public void JLGBIMEDNBN(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A4A RID: 80458 RVA: 0x00860114 File Offset: 0x0085E314
		public VolumeEffectComponent IKBGJMCMDNI(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.GOMDAOKBCJI(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.DFOEJJCDFIK(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A4B RID: 80459 RVA: 0x00860178 File Offset: 0x0085E378
		public void MELPHKDBAEP(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 0; i < effectFlags.components.Count; i += 0)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BHHCODHHDLJ(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 1; j < volumeEffectComponentFlags.componentFields.Count; j++)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.DDEPIBFMILD(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.HLKLONJMLJL(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "wpn_fid2"))
									{
										if (!(fullName == "crft_treb"))
										{
											if (!(fullName == "AntaresController"))
											{
												if (!(fullName == "CratePush"))
												{
													if (!(fullName == ""))
													{
														if (fullName == "(")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A4C RID: 80460 RVA: 0x008603D8 File Offset: 0x0085E5D8
		public void ICCCAIIMPNH(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 1; i < effectFlags.components.Count; i += 0)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 0; j < volumeEffectComponentFlags.componentFields.Count; j++)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.HODAOIDEAGL(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.BBCBIJAEGKN(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "[ACTk] Injection Detector: can't be started since it doesn't exists in scene or not yet initialized!"))
									{
										if (!(fullName == "UnityEngine.GameObject"))
										{
											if (!(fullName == "ncht_ach2"))
											{
												if (!(fullName == "sunshine_DepthBiases"))
												{
													if (!(fullName == "_DepthOfFieldCoCTex"))
													{
														if (fullName == "HA ")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A4D RID: 80461 RVA: 0x00860104 File Offset: 0x0085E304
		public void COOJLPPOPPI(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A4E RID: 80462 RVA: 0x00860638 File Offset: 0x0085E838
		public void DMENPDJJKNP(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 0; i < effectFlags.components.Count; i++)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.PAOJADBPNKA(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 1; j < volumeEffectComponentFlags.componentFields.Count; j++)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.LHIBCDKMPED(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.HLOGEMIPDBB(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "cht_msg30"))
									{
										if (!(fullName == ""))
										{
											if (!(fullName == "wrist"))
											{
												if (!(fullName == "x"))
												{
													if (!(fullName == "The image effect "))
													{
														if (fullName == "<color='#000000'>{0}</color>")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A4F RID: 80463 RVA: 0x00860898 File Offset: 0x0085EA98
		public void FMCJHJHCGMI()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.AEPGKBNEHHG(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A50 RID: 80464 RVA: 0x0086092C File Offset: 0x0085EB2C
		public void IKIICMMAODG()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.OMNPIAKEBOC(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A51 RID: 80465 RVA: 0x008609C0 File Offset: 0x0085EBC0
		public static VolumeEffect KBBCAMNNNHA(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.BHHCODHHDLJ(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.IOLJPABOKJH(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.BBCBIJAEGKN(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.CKBKFDDOMFB(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == "isBrag"))
									{
										if (!(fieldType == "\n\n "))
										{
											if (!(fieldType == "SUNSHINE_THREE_CASCADES"))
											{
												if (!(fieldType == "_Balance"))
												{
													if (!(fieldType == "msgNo"))
													{
														if (fieldType == "Отмена")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A52 RID: 80466 RVA: 0x0085EC72 File Offset: 0x0085CE72
		public string[] BDIBPPOFADF()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.GBGHHFJBHOB)).ToArray<string>();
		}

		// Token: 0x06013A53 RID: 80467 RVA: 0x00860C30 File Offset: 0x0085EE30
		public VolumeEffectComponent MPOKIKGAOCB(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.IOLJPABOKJH(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.BGKHOBNDJOI(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A54 RID: 80468 RVA: 0x00860C94 File Offset: 0x0085EE94
		public void HOIDGICLDMF()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.HHOLOCOBEKH(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A55 RID: 80469 RVA: 0x00860D28 File Offset: 0x0085EF28
		public string[] CCMAHHHIHIE()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.IHONPINCKDM)).ToArray<string>();
		}

		// Token: 0x06013A56 RID: 80470 RVA: 0x00860D5C File Offset: 0x0085EF5C
		public void KNFMMDDFMEG()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.DJBCCEINJDK(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A57 RID: 80471 RVA: 0x00860DF0 File Offset: 0x0085EFF0
		public static Component[] MAGIIKPPBID(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.FLMJALFPMCM)).ToArray<Component>();
		}

		// Token: 0x06013A58 RID: 80472 RVA: 0x00860E48 File Offset: 0x0085F048
		public static Component[] OCDDMDGFNJL(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.PLHIPIKPPKO)).ToArray<Component>();
		}

		// Token: 0x06013A59 RID: 80473 RVA: 0x00860104 File Offset: 0x0085E304
		public void JIEIJEMEGHP(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A5A RID: 80474 RVA: 0x00860EA0 File Offset: 0x0085F0A0
		public VolumeEffectComponent GOMDAOKBCJI(string INJNJEPIFKB)
		{
			for (int i = 0; i < this.components.Count; i += 0)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013A5B RID: 80475 RVA: 0x00860EEA File Offset: 0x0085F0EA
		public string[] OKBGLGPNHFA()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.IDGGOGEOMDL)).ToArray<string>();
		}

		// Token: 0x06013A5C RID: 80476 RVA: 0x00860F1C File Offset: 0x0085F11C
		public VolumeEffectComponent BBBLOAHECJC(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.BMFDPGKFOOE(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.PALKCHAMFLE(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A5D RID: 80477 RVA: 0x00860F80 File Offset: 0x0085F180
		public static VolumeEffect PGKKGILMMGE(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.GOMDAOKBCJI(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.GOMDAOKBCJI(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.KMEAPJDNGGC(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.HLKLONJMLJL(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == "-L-"))
									{
										if (!(fieldType == "wpn_add/base"))
										{
											if (!(fieldType == "BackPackOff"))
											{
												if (!(fieldType == "MotorbikeSpecialFlip"))
												{
													if (!(fieldType == ""))
													{
														if (fieldType == "OFF")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A5E RID: 80478 RVA: 0x00860104 File Offset: 0x0085E304
		public void PMAIAMHIOHL(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A5F RID: 80479 RVA: 0x008611F0 File Offset: 0x0085F3F0
		public string[] MIBIDBIGKDK()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.FFPHGAOHOKP)).ToArray<string>();
		}

		// Token: 0x06013A60 RID: 80480 RVA: 0x00861224 File Offset: 0x0085F424
		public void JFGCCJPJEBI(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.GOMDAOKBCJI(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.JNHLFFJGHNF(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "Cloth_05_00.wav"))
									{
										if (!(fullName == "Sampling AO on "))
										{
											if (!(fullName == "none"))
											{
												if (!(fullName == "camouflage_scale"))
												{
													if (!(fullName == "Ball"))
													{
														if (fullName == "COLOR")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A61 RID: 80481 RVA: 0x00860104 File Offset: 0x0085E304
		public void BGFLMOGEHDE(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A62 RID: 80482 RVA: 0x00861444 File Offset: 0x0085F644
		public void PFIOGBANOCL()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.BBBLOAHECJC(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A63 RID: 80483 RVA: 0x008614D8 File Offset: 0x0085F6D8
		public VolumeEffectComponent HHOLOCOBEKH(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.GOMDAOKBCJI(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.BEGENIODGNI(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A64 RID: 80484 RVA: 0x0086153C File Offset: 0x0085F73C
		public void EOBGCAEANJJ()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.HILNFFAFCCO(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A65 RID: 80485 RVA: 0x008615D0 File Offset: 0x0085F7D0
		public string[] BCNNBEOLELJ()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.DPPDIIFBBKI)).ToArray<string>();
		}

		// Token: 0x06013A66 RID: 80486 RVA: 0x00861604 File Offset: 0x0085F804
		public static VolumeEffect LEHEBBFHMHO(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.PAOJADBPNKA(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.GOMDAOKBCJI(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.BPPJPDOCAGC(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.PICBGFLPAHP(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == "impfail"))
									{
										if (!(fieldType == "Bezier curve must have two or more control points!"))
										{
											if (!(fieldType == "hgtDst="))
											{
												if (!(fieldType == "PaperTurn.wav"))
												{
													if (!(fieldType == "Anti-Cheat Toolkit Detectors"))
													{
														if (fieldType == "error.wav")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A67 RID: 80487 RVA: 0x00861874 File Offset: 0x0085FA74
		public VolumeEffectComponent HGJKMNFHMCH(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.KJJBLKFOPLJ(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.ADMFLBMNFCB(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A68 RID: 80488 RVA: 0x008618D8 File Offset: 0x0085FAD8
		public VolumeEffectComponent CFBJJOKGMCE(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.PAOJADBPNKA(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.CPKDHGBHGKH(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A69 RID: 80489 RVA: 0x00860104 File Offset: 0x0085E304
		public void NMODFDDOIFI(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A6A RID: 80490 RVA: 0x0086193C File Offset: 0x0085FB3C
		public VolumeEffectComponent HILNFFAFCCO(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.KJJBLKFOPLJ(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.KAOEPKHABND(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A6B RID: 80491 RVA: 0x0086199F File Offset: 0x0085FB9F
		public VolumeEffect(AmplifyColorBase JLEACBAILGG)
		{
			this.gameObject = JLEACBAILGG;
			this.components = new List<VolumeEffectComponent>();
		}

		// Token: 0x06013A6C RID: 80492 RVA: 0x008611F0 File Offset: 0x0085F3F0
		public string[] ANKCPANONGC()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.FFPHGAOHOKP)).ToArray<string>();
		}

		// Token: 0x06013A6D RID: 80493 RVA: 0x00860104 File Offset: 0x0085E304
		public void MGOOCBCDHGH(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A6E RID: 80494 RVA: 0x008619BC File Offset: 0x0085FBBC
		public static Component[] LKBMIILKDAO(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.PLHIPIKPPKO)).ToArray<Component>();
		}

		// Token: 0x06013A6F RID: 80495 RVA: 0x00861A14 File Offset: 0x0085FC14
		public static VolumeEffect HNMFKFHCBNC(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.BHHCODHHDLJ(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.BHHCODHHDLJ(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.HLKLONJMLJL(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.BPPJPDOCAGC(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == "_PrevViewProj"))
									{
										if (!(fieldType == "StartControllerModule"))
										{
											if (!(fieldType == "#80ff00"))
											{
												if (!(fieldType == "_NeutralTonemapperParams1"))
												{
													if (!(fieldType == "RoundHouse"))
													{
														if (fieldType == "#> _Wrinkles Occlusion Camera < ")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A70 RID: 80496 RVA: 0x00861C84 File Offset: 0x0085FE84
		public string[] NNKAABCOPGP()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.NPCHJANPPGB)).ToArray<string>();
		}

		// Token: 0x06013A71 RID: 80497 RVA: 0x00861CB8 File Offset: 0x0085FEB8
		public void LEIBINJJDLO(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.PAOJADBPNKA(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.JNHLFFJGHNF(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "_Distance"))
									{
										if (!(fullName == "{0}"))
										{
											if (!(fullName == "{not_found}"))
											{
												if (!(fullName == "WoodSaw"))
												{
													if (!(fullName == "OfficeSittingReading"))
													{
														if (fullName == "Zone ")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A72 RID: 80498 RVA: 0x00861ED8 File Offset: 0x008600D8
		public static Component[] LBIPBEGBIKC(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.INFJGAEKPMD)).ToArray<Component>();
		}

		// Token: 0x06013A73 RID: 80499 RVA: 0x00860104 File Offset: 0x0085E304
		public void CBGIIBKJFEG(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A74 RID: 80500 RVA: 0x00861F2E File Offset: 0x0086012E
		public string[] HHOMKECBKJO()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.MKKOOJOCDKI)).ToArray<string>();
		}

		// Token: 0x06013A75 RID: 80501 RVA: 0x00860104 File Offset: 0x0085E304
		public void NFDBIKAOFDO(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A76 RID: 80502 RVA: 0x00861F60 File Offset: 0x00860160
		public void GBIKOLPKBEO()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.OPODAMEGDND(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A77 RID: 80503 RVA: 0x00861FF4 File Offset: 0x008601F4
		public string[] HENPJGPPPFK()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.HHEKCGFCNJB)).ToArray<string>();
		}

		// Token: 0x06013A78 RID: 80504 RVA: 0x00862025 File Offset: 0x00860225
		public string[] ADKBPIPHNJO()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.BFAEIFACFDH)).ToArray<string>();
		}

		// Token: 0x06013A79 RID: 80505 RVA: 0x00862058 File Offset: 0x00860258
		public void DGKBNAFOILB(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 0; i < effectFlags.components.Count; i += 0)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 1; j < volumeEffectComponentFlags.componentFields.Count; j += 0)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.JNHLFFJGHNF(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.LBFCDONKPAI(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "<color='#100000'>{0} {1}</color>"))
									{
										if (!(fullName == "loadRodObject "))
										{
											if (!(fullName == "knopje.wav"))
											{
												if (!(fullName == "error.wav"))
												{
													if (!(fullName == "AimIK and LookAtIK need to have their 'Target' value assigned."))
													{
														if (fullName == "_FoamContrast")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A7A RID: 80506 RVA: 0x008622B8 File Offset: 0x008604B8
		public VolumeEffectComponent BMFDPGKFOOE(string INJNJEPIFKB)
		{
			for (int i = 0; i < this.components.Count; i++)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013A7B RID: 80507 RVA: 0x00862304 File Offset: 0x00860504
		public VolumeEffectComponent BLGHNJPLKKJ(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.GOMDAOKBCJI(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.CENDGENKMCH(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A7C RID: 80508 RVA: 0x0085EC72 File Offset: 0x0085CE72
		public string[] GHHKCAEPKEB()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.GBGHHFJBHOB)).ToArray<string>();
		}

		// Token: 0x06013A7D RID: 80509 RVA: 0x00862368 File Offset: 0x00860568
		public VolumeEffectComponent IOLJPABOKJH(string INJNJEPIFKB)
		{
			for (int i = 1; i < this.components.Count; i += 0)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013A7E RID: 80510 RVA: 0x008623B4 File Offset: 0x008605B4
		public static Component[] EOHNKJFLNHN(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.FGCBNHAJCGI)).ToArray<Component>();
		}

		// Token: 0x06013A7F RID: 80511 RVA: 0x00860EEA File Offset: 0x0085F0EA
		public string[] CDIBFMAMFJO()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.IDGGOGEOMDL)).ToArray<string>();
		}

		// Token: 0x06013A80 RID: 80512 RVA: 0x0086240C File Offset: 0x0086060C
		public void DKKLLAGACIN(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 1; i < effectFlags.components.Count; i++)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.GOMDAOKBCJI(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.IOLJPABOKJH(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 1; j < volumeEffectComponentFlags.componentFields.Count; j += 0)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.BBCBIJAEGKN(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.DGMFAJBPNPD(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "startB"))
									{
										if (!(fullName == "Roar"))
										{
											if (!(fullName == "KatanaReadyLow"))
											{
												if (!(fullName == "knopje.wav"))
												{
													if (!(fullName == "The 'font' command requires a font name parameter and an optional font size parameter."))
													{
														if (fullName == "______________________________")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A81 RID: 80513 RVA: 0x0086266C File Offset: 0x0086086C
		public void BCINHOOLIDI()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.EEFFBLIPODA(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A82 RID: 80514 RVA: 0x008615D0 File Offset: 0x0085F7D0
		public string[] DNLIGLIOFCP()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.DPPDIIFBBKI)).ToArray<string>();
		}

		// Token: 0x06013A83 RID: 80515 RVA: 0x00862700 File Offset: 0x00860900
		public static Component[] ILPGFGBFFCE(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.FGCBNHAJCGI)).ToArray<Component>();
		}

		// Token: 0x06013A84 RID: 80516 RVA: 0x00862758 File Offset: 0x00860958
		public void HALIHFLFCNH(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.GOMDAOKBCJI(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.DGMFAJBPNPD(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "StrafeRunRight"))
									{
										if (!(fullName == "Vertical"))
										{
											if (!(fullName == "t_bottom"))
											{
												if (!(fullName == "fwgt_uniq_w"))
												{
													if (!(fullName == "cht_msg4"))
													{
														if (fullName == ": ")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A85 RID: 80517 RVA: 0x00862978 File Offset: 0x00860B78
		public VolumeEffectComponent OGIGKJDFCPM(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.IOLJPABOKJH(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.JBEGMKAPBGA(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A86 RID: 80518 RVA: 0x00860104 File Offset: 0x0085E304
		public void IJAKJCJJDHO(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A87 RID: 80519 RVA: 0x008629DC File Offset: 0x00860BDC
		public void BPMIKKFNOGM(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 0; i < effectFlags.components.Count; i++)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 0; j < volumeEffectComponentFlags.componentFields.Count; j++)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.PICBGFLPAHP(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.PICBGFLPAHP(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "System.Single"))
									{
										if (!(fullName == "System.Boolean"))
										{
											if (!(fullName == "UnityEngine.Vector2"))
											{
												if (!(fullName == "UnityEngine.Vector3"))
												{
													if (!(fullName == "UnityEngine.Vector4"))
													{
														if (fullName == "UnityEngine.Color")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A88 RID: 80520 RVA: 0x00862C3C File Offset: 0x00860E3C
		public static VolumeEffect GBBHLPJGIKF(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.PAOJADBPNKA(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.BBCBIJAEGKN(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.JBJIHHJCIPJ(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == ""))
									{
										if (!(fieldType == "Allows to detect Cheat Engine's speed hack (and maybe some other speed hack tools) usage."))
										{
											if (!(fieldType == "costume_"))
											{
												if (!(fieldType == "IdleStand"))
												{
													if (!(fieldType == "Assets/Weapons/bootsBase.unity3d"))
													{
														if (fieldType == "_WaterLevel")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A89 RID: 80521 RVA: 0x00860104 File Offset: 0x0085E304
		public void BCPLNIKMMLP(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A8A RID: 80522 RVA: 0x00862EAC File Offset: 0x008610AC
		public void LFIJABGBBAP(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.DGMFAJBPNPD(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "Hidden/Amplify Color/DepthMask"))
									{
										if (!(fullName == "error: mainAsset is null"))
										{
											if (!(fullName == "_Intensity"))
											{
												if (!(fullName == "Отпущена рыба"))
												{
													if (!(fullName == "ui_default_close.wav"))
													{
														if (fullName == "invn_win1")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A8B RID: 80523 RVA: 0x00860104 File Offset: 0x0085E304
		public void LFEJECAFLGM(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013A8C RID: 80524 RVA: 0x008630CC File Offset: 0x008612CC
		public void DIDFAFIPBJB()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.BBBLOAHECJC(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A8D RID: 80525 RVA: 0x00863160 File Offset: 0x00861360
		public void AFANOCCLBCD(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.IOLJPABOKJH(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.DGMFAJBPNPD(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "n"))
									{
										if (!(fullName == "OfficeSitting"))
										{
											if (!(fullName == " "))
											{
												if (!(fullName == "IdleCheer"))
												{
													if (!(fullName == "Assets/Weapons/"))
													{
														if (fullName == "FlyRight")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A8E RID: 80526 RVA: 0x00863380 File Offset: 0x00861580
		public VolumeEffectComponent IDJMEBLGCIM(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.BHHCODHHDLJ(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.BGKHOBNDJOI(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A8F RID: 80527 RVA: 0x008633E4 File Offset: 0x008615E4
		public VolumeEffectComponent BHHCODHHDLJ(string INJNJEPIFKB)
		{
			for (int i = 1; i < this.components.Count; i++)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013A90 RID: 80528 RVA: 0x00863430 File Offset: 0x00861630
		public static VolumeEffect HEBKEFEELKK(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.BHHCODHHDLJ(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.HODAOIDEAGL(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.AMBBNKINALO(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == ""))
									{
										if (!(fieldType == "_FogSkyColor"))
										{
											if (!(fieldType == "Sounds/ShootSound"))
											{
												if (!(fieldType == "IdleTyping"))
												{
													if (!(fieldType == "_LogLut"))
													{
														if (fieldType == "_SrcBlend")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A91 RID: 80529 RVA: 0x008636A0 File Offset: 0x008618A0
		public static Component[] BPAOBKBEEPH(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.HPGMHEMFKDD)).ToArray<Component>();
		}

		// Token: 0x06013A92 RID: 80530 RVA: 0x008636F8 File Offset: 0x008618F8
		public static VolumeEffect DIDFGMBPDID(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.JFAHCMKANAE(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.JNHLFFJGHNF(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.JBJIHHJCIPJ(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == ""))
									{
										if (!(fieldType == "GiantGrabIdle2"))
										{
											if (!(fieldType == "Hidden/Post FX/Lut Generator"))
											{
												if (!(fieldType == "invn_rec17"))
												{
													if (!(fieldType == "wpn_med2"))
													{
														if (fieldType == "quality")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A93 RID: 80531 RVA: 0x00863968 File Offset: 0x00861B68
		public void IALJCGJKFAA(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 1; i < effectFlags.components.Count; i++)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.GOMDAOKBCJI(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.IOLJPABOKJH(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 1; j < volumeEffectComponentFlags.componentFields.Count; j++)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.KMEAPJDNGGC(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.LHIBCDKMPED(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "id"))
									{
										if (!(fullName == "TOD_SunSkyColor"))
										{
											if (!(fullName == "bag"))
											{
												if (!(fullName == "SneakRight"))
												{
													if (!(fullName == "_Transparency"))
													{
														if (fullName == "Tenkoku DynamicSky")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A94 RID: 80532 RVA: 0x00861C84 File Offset: 0x0085FE84
		public string[] NANKELNKDKN()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.NPCHJANPPGB)).ToArray<string>();
		}

		// Token: 0x06013A95 RID: 80533 RVA: 0x0085EC72 File Offset: 0x0085CE72
		public string[] JPJIPOPIHHH()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.GBGHHFJBHOB)).ToArray<string>();
		}

		// Token: 0x06013A96 RID: 80534 RVA: 0x00863BC8 File Offset: 0x00861DC8
		public VolumeEffectComponent AEPGKBNEHHG(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.BMFDPGKFOOE(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.DFOEJJCDFIK(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A97 RID: 80535 RVA: 0x00863C2C File Offset: 0x00861E2C
		public VolumeEffectComponent KINIBNHMCGD(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.GOMDAOKBCJI(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.OOFKIOBCGNK(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A98 RID: 80536 RVA: 0x00863C90 File Offset: 0x00861E90
		public void EMBMBKNEPOE()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.OGIGKJDFCPM(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A99 RID: 80537 RVA: 0x00863D24 File Offset: 0x00861F24
		public void CMKKBHLHDEC()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.OGIGKJDFCPM(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A9A RID: 80538 RVA: 0x00863DB8 File Offset: 0x00861FB8
		public VolumeEffectComponent IJFOHCHFEGB(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.PAOJADBPNKA(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.KHENDOIAHLP(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013A9B RID: 80539 RVA: 0x00863E1C File Offset: 0x0086201C
		public void JGEGCGHAKDF()
		{
			if (this.gameObject == null)
			{
				return;
			}
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.gameObject.EffectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = this.gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						this.HILNFFAFCCO(component, volumeEffectComponentFlags);
					}
				}
			}
		}

		// Token: 0x06013A9C RID: 80540 RVA: 0x00863EB0 File Offset: 0x008620B0
		public static Component[] KNCICCAGMGG(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[1];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.IGJEHFBHEHA)).ToArray<Component>();
		}

		// Token: 0x06013A9D RID: 80541 RVA: 0x00863F08 File Offset: 0x00862108
		public static VolumeEffect ALLMMFNMCPO(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.PAOJADBPNKA(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.AMBBNKINALO(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.JBJIHHJCIPJ(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == "IKSolverAim poleAxis is Vector3.zero."))
									{
										if (!(fieldType == "Invalid source renderer type"))
										{
											if (!(fieldType == "BlendMaterial"))
											{
												if (!(fieldType == "Backward Stand"))
												{
													if (!(fieldType == "часа"))
													{
														if (fieldType == "_Parameter")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013A9E RID: 80542 RVA: 0x00864178 File Offset: 0x00862378
		public VolumeEffectComponent JFAHCMKANAE(string INJNJEPIFKB)
		{
			for (int i = 0; i < this.components.Count; i += 0)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013A9F RID: 80543 RVA: 0x008641C4 File Offset: 0x008623C4
		public VolumeEffectComponent KGACLGGFOID(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.BMFDPGKFOOE(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.BEGENIODGNI(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013AA0 RID: 80544 RVA: 0x00864228 File Offset: 0x00862428
		public void BDHOOBMLKNG(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.HLKLONJMLJL(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "Hidden/DepthOfField/MedianFilter"))
									{
										if (!(fullName == "post_10"))
										{
											if (!(fullName == "GestureWonderful"))
											{
												if (!(fullName == "MotorbikeSuperman"))
												{
													if (!(fullName == "get 108 packet"))
													{
														if (fullName == "SatNightFever")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013AA1 RID: 80545 RVA: 0x00864448 File Offset: 0x00862648
		public static Component[] CIEIBFKLKCC(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.PLHIPIKPPKO)).ToArray<Component>();
		}

		// Token: 0x06013AA2 RID: 80546 RVA: 0x008644A0 File Offset: 0x008626A0
		public VolumeEffectComponent MLNMJNNOGEC(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.IOLJPABOKJH(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.CIMCHDCGMHH(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013AA3 RID: 80547 RVA: 0x00864504 File Offset: 0x00862704
		public static Component[] ICEBFCLGLOH(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[0];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.OKHEKDDNHOP)).ToArray<Component>();
		}

		// Token: 0x06013AA4 RID: 80548 RVA: 0x0086455C File Offset: 0x0086275C
		public VolumeEffectComponent BPEEEKHFEAM(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.KJJBLKFOPLJ(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.LODMFEMHBBB(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013AA5 RID: 80549 RVA: 0x008645C0 File Offset: 0x008627C0
		public VolumeEffectComponent OMNPIAKEBOC(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.JFAHCMKANAE(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.BGKHOBNDJOI(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013AA6 RID: 80550 RVA: 0x00864624 File Offset: 0x00862824
		public void GCIDBHEKKML(AmplifyColorBase GODDDAOGMJK)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in effectFlags.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null)
					{
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.PICBGFLPAHP(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "System.Single"))
									{
										if (!(fullName == "System.Boolean"))
										{
											if (!(fullName == "UnityEngine.Vector2"))
											{
												if (!(fullName == "UnityEngine.Vector3"))
												{
													if (!(fullName == "UnityEngine.Vector4"))
													{
														if (fullName == "UnityEngine.Color")
														{
															field.SetValue(component, volumeEffectField.valueColor);
														}
													}
													else
													{
														field.SetValue(component, volumeEffectField.valueVector4);
													}
												}
												else
												{
													field.SetValue(component, volumeEffectField.valueVector3);
												}
											}
											else
											{
												field.SetValue(component, volumeEffectField.valueVector2);
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, volumeEffectField.valueSingle);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013AA7 RID: 80551 RVA: 0x00864844 File Offset: 0x00862A44
		public VolumeEffectComponent GEEEHLCHHGO(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.PAOJADBPNKA(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.PALKCHAMFLE(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013AA8 RID: 80552 RVA: 0x008648A8 File Offset: 0x00862AA8
		public void MCOHKKEPCJL(AmplifyColorBase GODDDAOGMJK, VolumeEffect INDANOPGHCN, float HOLFDLKMHLG)
		{
			VolumeEffectFlags effectFlags = GODDDAOGMJK.EffectFlags;
			GameObject gameObject = GODDDAOGMJK.gameObject;
			for (int i = 0; i < effectFlags.components.Count; i++)
			{
				VolumeEffectComponentFlags volumeEffectComponentFlags = effectFlags.components[i];
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = gameObject.GetComponent(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent = this.BMFDPGKFOOE(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = INDANOPGHCN.IOLJPABOKJH(volumeEffectComponentFlags.componentName);
					if (!(component == null) && volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						for (int j = 1; j < volumeEffectComponentFlags.componentFields.Count; j += 0)
						{
							VolumeEffectFieldFlags volumeEffectFieldFlags = volumeEffectComponentFlags.componentFields[j];
							if (volumeEffectFieldFlags.blendFlag)
							{
								FieldInfo field = component.GetType().GetField(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField = volumeEffectComponent.NLGOKBCGMBI(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.BPPJPDOCAGC(volumeEffectFieldFlags.fieldName);
								if (!(field == null) && volumeEffectField != null && volumeEffectField2 != null)
								{
									string fullName = field.FieldType.FullName;
									if (!(fullName == "Save"))
									{
										if (!(fullName == ""))
										{
											if (!(fullName == "Horizontal"))
											{
												if (!(fullName == "_LerpRgbTex"))
												{
													if (!(fullName == "TYPES"))
													{
														if (fullName == "OfficeSittingHandRestFingerTap")
														{
															field.SetValue(component, Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, HOLFDLKMHLG));
														}
													}
													else
													{
														field.SetValue(component, Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, HOLFDLKMHLG));
													}
												}
												else
												{
													field.SetValue(component, Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, HOLFDLKMHLG));
												}
											}
											else
											{
												field.SetValue(component, Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, HOLFDLKMHLG));
											}
										}
										else
										{
											field.SetValue(component, volumeEffectField2.valueBoolean);
										}
									}
									else
									{
										field.SetValue(component, Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, HOLFDLKMHLG));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013AA9 RID: 80553 RVA: 0x00864B08 File Offset: 0x00862D08
		public VolumeEffectComponent PAOJADBPNKA(string INJNJEPIFKB)
		{
			for (int i = 0; i < this.components.Count; i += 0)
			{
				if (this.components[i].componentName == INJNJEPIFKB)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x06013AAA RID: 80554 RVA: 0x00864B54 File Offset: 0x00862D54
		public VolumeEffectComponent DJBCCEINJDK(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.GOMDAOKBCJI(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.FOCOKMDNKAA(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013AAB RID: 80555 RVA: 0x00860D28 File Offset: 0x0085EF28
		public string[] HBBDLFDDECO()
		{
			return this.components.Select(new Func<VolumeEffectComponent, string>(VolumeEffect.<>c.<>9.IHONPINCKDM)).ToArray<string>();
		}

		// Token: 0x06013AAC RID: 80556 RVA: 0x00860104 File Offset: 0x0085E304
		public void FHDMKHJPAKK(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x06013AAD RID: 80557 RVA: 0x00864BB8 File Offset: 0x00862DB8
		public static VolumeEffect CDAGJCCCOGO(VolumeEffectFlags CFKACPIFLAK, VolumeEffect BCLFPNKKOAB, VolumeEffect DLDPCJHLGGP, float PDKLBDEKFOL)
		{
			VolumeEffect volumeEffect = new VolumeEffect(BCLFPNKKOAB.gameObject);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in CFKACPIFLAK.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					VolumeEffectComponent volumeEffectComponent = BCLFPNKKOAB.GOMDAOKBCJI(volumeEffectComponentFlags.componentName);
					VolumeEffectComponent volumeEffectComponent2 = DLDPCJHLGGP.BHHCODHHDLJ(volumeEffectComponentFlags.componentName);
					if (volumeEffectComponent != null && volumeEffectComponent2 != null)
					{
						VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(volumeEffectComponent.componentName);
						foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in volumeEffectComponentFlags.componentFields)
						{
							if (volumeEffectFieldFlags.blendFlag)
							{
								VolumeEffectField volumeEffectField = volumeEffectComponent.NLGOKBCGMBI(volumeEffectFieldFlags.fieldName);
								VolumeEffectField volumeEffectField2 = volumeEffectComponent2.HLKLONJMLJL(volumeEffectFieldFlags.fieldName);
								if (volumeEffectField != null && volumeEffectField2 != null)
								{
									VolumeEffectField volumeEffectField3 = new VolumeEffectField(volumeEffectField.fieldName, volumeEffectField.fieldType);
									string fieldType = volumeEffectField3.fieldType;
									if (!(fieldType == "WeaponReady"))
									{
										if (!(fieldType == "****softSpawn from "))
										{
											if (!(fieldType == "_PrevViewProj"))
											{
												if (!(fieldType == "Hey, you can easily change me in memory!"))
												{
													if (!(fieldType == "WizardNeoBlock"))
													{
														if (fieldType == "BlurDepthTolerance")
														{
															volumeEffectField3.valueColor = Color.Lerp(volumeEffectField.valueColor, volumeEffectField2.valueColor, PDKLBDEKFOL);
														}
													}
													else
													{
														volumeEffectField3.valueVector4 = Vector4.Lerp(volumeEffectField.valueVector4, volumeEffectField2.valueVector4, PDKLBDEKFOL);
													}
												}
												else
												{
													volumeEffectField3.valueVector3 = Vector3.Lerp(volumeEffectField.valueVector3, volumeEffectField2.valueVector3, PDKLBDEKFOL);
												}
											}
											else
											{
												volumeEffectField3.valueVector2 = Vector2.Lerp(volumeEffectField.valueVector2, volumeEffectField2.valueVector2, PDKLBDEKFOL);
											}
										}
										else
										{
											volumeEffectField3.valueBoolean = volumeEffectField2.valueBoolean;
										}
									}
									else
									{
										volumeEffectField3.valueSingle = Mathf.Lerp(volumeEffectField.valueSingle, volumeEffectField2.valueSingle, PDKLBDEKFOL);
									}
									volumeEffectComponent3.fields.Add(volumeEffectField3);
								}
							}
						}
						volumeEffect.components.Add(volumeEffectComponent3);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x06013AAE RID: 80558 RVA: 0x00864E28 File Offset: 0x00863028
		public static Component[] AELFKEGIDCH(AmplifyColorBase APDJCCIGFAK)
		{
			if (APDJCCIGFAK == null)
			{
				return new Component[1];
			}
			return APDJCCIGFAK.GetComponents(typeof(Component)).Where(new Func<Component, bool>(VolumeEffect.<>c.<>9.LCGLFIGLIAB)).ToArray<Component>();
		}

		// Token: 0x06013AAF RID: 80559 RVA: 0x00864E80 File Offset: 0x00863080
		public VolumeEffectComponent EEFFBLIPODA(Component OAGAHEAMIAB, VolumeEffectComponentFlags LCNOOKMLHKE)
		{
			if (LCNOOKMLHKE == null)
			{
				VolumeEffectComponent volumeEffectComponent = new VolumeEffectComponent(string.Concat(OAGAHEAMIAB.GetType()));
				this.components.Add(volumeEffectComponent);
				return volumeEffectComponent;
			}
			VolumeEffectComponent volumeEffectComponent2;
			if ((volumeEffectComponent2 = this.GOMDAOKBCJI(string.Concat(OAGAHEAMIAB.GetType()))) != null)
			{
				volumeEffectComponent2.KAOEPKHABND(OAGAHEAMIAB, LCNOOKMLHKE);
				return volumeEffectComponent2;
			}
			VolumeEffectComponent volumeEffectComponent3 = new VolumeEffectComponent(OAGAHEAMIAB, LCNOOKMLHKE);
			this.components.Add(volumeEffectComponent3);
			return volumeEffectComponent3;
		}

		// Token: 0x06013AB0 RID: 80560 RVA: 0x00860104 File Offset: 0x0085E304
		public void DKHHCIJGPJI(VolumeEffectComponent MOEEOBJHHCK)
		{
			this.components.Remove(MOEEOBJHHCK);
		}

		// Token: 0x04002811 RID: 10257
		public AmplifyColorBase gameObject;

		// Token: 0x04002812 RID: 10258
		public List<VolumeEffectComponent> components;
	}
}
