using System;
using System.Collections.Generic;
using UnityEngine;

namespace AraSamples
{
	// Token: 0x020005B5 RID: 1461
	public class CarController : MonoBehaviour
	{
		// Token: 0x06013329 RID: 78633 RVA: 0x0083E35C File Offset: 0x0083C55C
		public void CIJDJLHJHHC()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("FishModel");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("</color>");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NHKMOJCFLHG(axleInfo.leftWheel);
				this.IDBOKNOOPOH(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601332A RID: 78634 RVA: 0x0083E424 File Offset: 0x0083C624
		public void EIBGPBOGMKE()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("DealerShuffle");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("---");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.IEFBJGFEPBG(axleInfo.leftWheel);
				this.PGPNLAEFNBK(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601332B RID: 78635 RVA: 0x0083E4EC File Offset: 0x0083C6EC
		public void EAOPJLPOALK()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("002000");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("RollerBladeCrossoverLeft");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.IEFBJGFEPBG(axleInfo.leftWheel);
				this.JJMDPLEJMOG(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601332C RID: 78636 RVA: 0x0083E5B4 File Offset: 0x0083C7B4
		public void NPGHIGJJALL(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601332D RID: 78637 RVA: 0x0083E5FC File Offset: 0x0083C7FC
		public void IGEKLKNIBKN(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601332E RID: 78638 RVA: 0x0083E644 File Offset: 0x0083C844
		public void NKNJMMECNPD()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("DecalMesh");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("<color='#206000'>");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.ONCEGJBMBLM(axleInfo.leftWheel);
				this.JJMDPLEJMOG(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601332F RID: 78639 RVA: 0x0083E70C File Offset: 0x0083C90C
		public void KDJCHCKDJJA(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013330 RID: 78640 RVA: 0x0083E754 File Offset: 0x0083C954
		public void CGOCFLOAOKC()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("I LOVE MY GIRL");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("shop_t3");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.BIIMLAMEDLN(axleInfo.leftWheel);
				this.KKBOHPNGNNK(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013331 RID: 78641 RVA: 0x0083E81C File Offset: 0x0083CA1C
		public void KMHBOLLCJHO()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("This script need an Image with a readbale Texture2D to work.");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("Hyperlink_");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.ILCEBHPFDCJ(axleInfo.leftWheel);
				this.LGIHKFMHOKG(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013332 RID: 78642 RVA: 0x0083E8E4 File Offset: 0x0083CAE4
		public void GNDEHAJMFDF(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013333 RID: 78643 RVA: 0x0083E92C File Offset: 0x0083CB2C
		public void JJMDPLEJMOG(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013334 RID: 78644 RVA: 0x0083E974 File Offset: 0x0083CB74
		public void FJAKGHPKJLE(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013335 RID: 78645 RVA: 0x0083E9BC File Offset: 0x0083CBBC
		public void FixedUpdate()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Vertical");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("Horizontal");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.ApplyLocalPositionToVisuals(axleInfo.leftWheel);
				this.ApplyLocalPositionToVisuals(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013336 RID: 78646 RVA: 0x0083EA84 File Offset: 0x0083CC84
		public void NNBMEPIBMGL(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013337 RID: 78647 RVA: 0x0083EACC File Offset: 0x0083CCCC
		public void GHABAOFKCCH(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013338 RID: 78648 RVA: 0x0083EB14 File Offset: 0x0083CD14
		public void BGLIJMGAHLP()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("TAA History");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("WATER_VERTEX_DISPLACEMENT_OFF");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.FJAKGHPKJLE(axleInfo.leftWheel);
				this.BCHJFKGPACP(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013339 RID: 78649 RVA: 0x0083EBDC File Offset: 0x0083CDDC
		public void MGGDEDLFBBI(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601333A RID: 78650 RVA: 0x0083EC24 File Offset: 0x0083CE24
		public void HFCGLGEGLPP(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601333B RID: 78651 RVA: 0x0083EC6C File Offset: 0x0083CE6C
		public void IEFBJGFEPBG(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601333C RID: 78652 RVA: 0x0083ECB4 File Offset: 0x0083CEB4
		public void BHPEMLIIMFF(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601333D RID: 78653 RVA: 0x0083ECFC File Offset: 0x0083CEFC
		public void ILCEBHPFDCJ(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601333E RID: 78654 RVA: 0x0083ED44 File Offset: 0x0083CF44
		public void ACPCJLEKCPM()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("offsets");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("__a");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NHLLKMGLNMJ(axleInfo.leftWheel);
				this.GHABAOFKCCH(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601333F RID: 78655 RVA: 0x0083EE0C File Offset: 0x0083D00C
		public void HBOCLMDHBJK(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013340 RID: 78656 RVA: 0x0083EE54 File Offset: 0x0083D054
		public void JGIJIPNENLI()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis(" <b>®</b></color> ");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("error");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.BIIMLAMEDLN(axleInfo.leftWheel);
				this.JJMDPLEJMOG(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013341 RID: 78657 RVA: 0x0083EF1C File Offset: 0x0083D11C
		public void NDLLDNIOLPK()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Windmill");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("OneHandSwordBlock");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NHKMOJCFLHG(axleInfo.leftWheel);
				this.AKNPNDKMGOB(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013342 RID: 78658 RVA: 0x0083EFE4 File Offset: 0x0083D1E4
		public void ONCEGJBMBLM(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013344 RID: 78660 RVA: 0x0083F02C File Offset: 0x0083D22C
		public void EPBHPIOFEAC(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013345 RID: 78661 RVA: 0x0083F074 File Offset: 0x0083D274
		public void NHLLKMGLNMJ(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013346 RID: 78662 RVA: 0x0083F0BC File Offset: 0x0083D2BC
		public void KJGPKCLBLJA()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Blending ");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("RollerBladeRoll");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.ILCEBHPFDCJ(axleInfo.leftWheel);
				this.AEKAMNMMDMB(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013347 RID: 78663 RVA: 0x0083F184 File Offset: 0x0083D384
		public void BHKNJMBFFFF(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013348 RID: 78664 RVA: 0x0083F1CC File Offset: 0x0083D3CC
		public void IAGDKFGKPGG()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("wpn_add/base");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("SoccerRun");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NHKMOJCFLHG(axleInfo.leftWheel);
				this.ONCEGJBMBLM(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013349 RID: 78665 RVA: 0x0083F294 File Offset: 0x0083D494
		public void BCHJFKGPACP(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601334A RID: 78666 RVA: 0x0083F2DC File Offset: 0x0083D4DC
		public void JPPDLBFHPCG()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Wood Cut");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("ElvisLegsLoop");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.IEFBJGFEPBG(axleInfo.leftWheel);
				this.JJMDPLEJMOG(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601334B RID: 78667 RVA: 0x0083F3A4 File Offset: 0x0083D5A4
		public void EDGFFIEPGPD()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("crft_use");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("OfficeSittingReadingPageFlip");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.CPEKAHBGAMI(axleInfo.leftWheel);
				this.LGIHKFMHOKG(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601334C RID: 78668 RVA: 0x0083F46C File Offset: 0x0083D66C
		public void LOIPNCCDMLM()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("1");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("DrawDistance");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NNBMEPIBMGL(axleInfo.leftWheel);
				this.LGIHKFMHOKG(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601334D RID: 78669 RVA: 0x0083F534 File Offset: 0x0083D734
		public void AEKAMNMMDMB(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601334E RID: 78670 RVA: 0x0083F57C File Offset: 0x0083D77C
		public void MCNAPFOFHHA()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("_TempRT");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("Wrist");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.IDBOKNOOPOH(axleInfo.leftWheel);
				this.BIIMLAMEDLN(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601334F RID: 78671 RVA: 0x0083F644 File Offset: 0x0083D844
		public void FKOJOBCLLDC(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013350 RID: 78672 RVA: 0x0083F68C File Offset: 0x0083D88C
		public void AKNPNDKMGOB(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013351 RID: 78673 RVA: 0x0083F6D4 File Offset: 0x0083D8D4
		public void EMGCKNECDNB()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis(",");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.PGPNLAEFNBK(axleInfo.leftWheel);
				this.NHKMOJCFLHG(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013352 RID: 78674 RVA: 0x0083F79C File Offset: 0x0083D99C
		public void IHNMKAOBPOH(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013353 RID: 78675 RVA: 0x0083F7E4 File Offset: 0x0083D9E4
		public void HFOHPLNOFKC()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("wpn_hookf");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("colorD");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.IGEKLKNIBKN(axleInfo.leftWheel);
				this.GNDEHAJMFDF(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013354 RID: 78676 RVA: 0x0083F8AC File Offset: 0x0083DAAC
		public void DBNIIOPOGAK()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Flap_08.wav");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis(" ");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.GNDEHAJMFDF(axleInfo.leftWheel);
				this.GHABAOFKCCH(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013355 RID: 78677 RVA: 0x0083F974 File Offset: 0x0083DB74
		public void DOCCKNGPJGO()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("{{{{{0},{1}}}}}");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.FJAKGHPKJLE(axleInfo.leftWheel);
				this.JJMDPLEJMOG(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013356 RID: 78678 RVA: 0x0083FA3C File Offset: 0x0083DC3C
		public void EJJCEIAGKNK()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("_ReflectionTexture1");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("{0}/{1}");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.BHPEMLIIMFF(axleInfo.leftWheel);
				this.LDCDACJNDAA(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013357 RID: 78679 RVA: 0x0083FB04 File Offset: 0x0083DD04
		public void FAGCCPMNMED()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("SixStep");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("cht_msg36");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.ONCEGJBMBLM(axleInfo.leftWheel);
				this.LGIHKFMHOKG(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013358 RID: 78680 RVA: 0x0083FBCC File Offset: 0x0083DDCC
		public void FHLJGAGEHBL(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013359 RID: 78681 RVA: 0x0083FC14 File Offset: 0x0083DE14
		public void CPEKAHBGAMI(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601335A RID: 78682 RVA: 0x0083FC5C File Offset: 0x0083DE5C
		public void PGPNLAEFNBK(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601335B RID: 78683 RVA: 0x0083FCA4 File Offset: 0x0083DEA4
		public void GEOKBOMOFBO(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601335C RID: 78684 RVA: 0x0083FCEC File Offset: 0x0083DEEC
		public void ApplyLocalPositionToVisuals(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601335D RID: 78685 RVA: 0x0083FD34 File Offset: 0x0083DF34
		public void IFINKBGCKML()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Transforms.Length is 0.");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("_InputGamma");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.EPBHPIOFEAC(axleInfo.leftWheel);
				this.MGGDEDLFBBI(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601335E RID: 78686 RVA: 0x0083FDFC File Offset: 0x0083DFFC
		public void JGCOLIFLHLP()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("invn_rec3");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("<color='#b0a0c0'>");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.HCNCMLIBGHP(axleInfo.leftWheel);
				this.BHPEMLIIMFF(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601335F RID: 78687 RVA: 0x0083FEC4 File Offset: 0x0083E0C4
		public void CMOBKEINKPF()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("OneHandSwordIdle");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("<<");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NHKMOJCFLHG(axleInfo.leftWheel);
				this.EPBHPIOFEAC(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013360 RID: 78688 RVA: 0x0083FF8C File Offset: 0x0083E18C
		public void GAODPIIFKDB()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("No Cell wpn.cell=");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("\n");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.HCNCMLIBGHP(axleInfo.leftWheel);
				this.NFFPLJNBCMH(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013361 RID: 78689 RVA: 0x00840054 File Offset: 0x0083E254
		public void GPNLIIOPFLI()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Shoot Right");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis(" l ");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.JJMDPLEJMOG(axleInfo.leftWheel);
				this.NPGHIGJJALL(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013362 RID: 78690 RVA: 0x0084011C File Offset: 0x0083E31C
		public void COMGGKGILHC()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("wpn_add/addperks/addPerk");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.ABJCLLHJPAC(axleInfo.leftWheel);
				this.AKNPNDKMGOB(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013363 RID: 78691 RVA: 0x008401E4 File Offset: 0x0083E3E4
		public void KKBOHPNGNNK(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013364 RID: 78692 RVA: 0x0084022C File Offset: 0x0083E42C
		public void BIIMLAMEDLN(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013365 RID: 78693 RVA: 0x00840274 File Offset: 0x0083E474
		public void JONHPGJKPBE()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("_info");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("{0}");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.BHKNJMBFFFF(axleInfo.leftWheel);
				this.HFCGLGEGLPP(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013366 RID: 78694 RVA: 0x0084033C File Offset: 0x0083E53C
		public void ABJCLLHJPAC(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013367 RID: 78695 RVA: 0x00840384 File Offset: 0x0083E584
		public void CAMKGFPCICI(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013368 RID: 78696 RVA: 0x008403CC File Offset: 0x0083E5CC
		public void IDBOKNOOPOH(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013369 RID: 78697 RVA: 0x00840414 File Offset: 0x0083E614
		public void NBCLNFLJMHP()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis(" ");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("L");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.CAMKGFPCICI(axleInfo.leftWheel);
				this.BIIMLAMEDLN(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601336A RID: 78698 RVA: 0x008404DC File Offset: 0x0083E6DC
		public void NFFPLJNBCMH(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601336B RID: 78699 RVA: 0x00840524 File Offset: 0x0083E724
		public void NEHOCLNFDHP()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("**********  dropPrikormEvnt");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("ProneIdle");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NHKMOJCFLHG(axleInfo.leftWheel);
				this.PGPNLAEFNBK(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601336C RID: 78700 RVA: 0x008405EC File Offset: 0x0083E7EC
		public void OIIMEOFJIFP()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("How your position is stored in memory when obscured:\n(");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("WalkInjured");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.GHABAOFKCCH(axleInfo.leftWheel);
				this.FKOJOBCLLDC(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601336D RID: 78701 RVA: 0x008406B4 File Offset: 0x0083E8B4
		public void MNEBLODGADC()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("SUNSHINE_FILTER_PCF_2x2");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("Mutilate");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NFFPLJNBCMH(axleInfo.leftWheel);
				this.JJMDPLEJMOG(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601336E RID: 78702 RVA: 0x0084077C File Offset: 0x0083E97C
		public void LJGKOHGECEL(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601336F RID: 78703 RVA: 0x008407C4 File Offset: 0x0083E9C4
		public void KHAEPCKACBD()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("DITHER_ON");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("ArmFlex5");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.KMJCNDMLINM(axleInfo.leftWheel);
				this.ApplyLocalPositionToVisuals(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013370 RID: 78704 RVA: 0x0084088C File Offset: 0x0083EA8C
		public void LDCDACJNDAA(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013371 RID: 78705 RVA: 0x008408D4 File Offset: 0x0083EAD4
		public void KMJCNDMLINM(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(0);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013372 RID: 78706 RVA: 0x0084091C File Offset: 0x0083EB1C
		public void ENOHCEKJCBI()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("_History1ChromaTex");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("WalkDehydrated");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NPGHIGJJALL(axleInfo.leftWheel);
				this.AEKAMNMMDMB(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013373 RID: 78707 RVA: 0x008409E4 File Offset: 0x0083EBE4
		public void HCNCMLIBGHP(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013374 RID: 78708 RVA: 0x00840A2C File Offset: 0x0083EC2C
		public void GJIMCFPPAEP()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("money");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("MotorbikeHandlebarSit");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.IEFBJGFEPBG(axleInfo.leftWheel);
				this.MGGDEDLFBBI(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013375 RID: 78709 RVA: 0x00840AF4 File Offset: 0x0083ECF4
		public void LGIHKFMHOKG(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x06013376 RID: 78710 RVA: 0x00840B3C File Offset: 0x0083ED3C
		public void GPNKIPJNFNF()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Horizontal");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("wpn_add/base");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.BCHJFKGPACP(axleInfo.leftWheel);
				this.LGIHKFMHOKG(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013377 RID: 78711 RVA: 0x00840C04 File Offset: 0x0083EE04
		public void NMLBOIJFMMB()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("Scuba OK");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("wpn_cat1");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.BCHJFKGPACP(axleInfo.leftWheel);
				this.ABJCLLHJPAC(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013378 RID: 78712 RVA: 0x00840CCC File Offset: 0x0083EECC
		public void JCNOFKABMCM()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("PistolFire");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("invn_rec28");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.NPGHIGJJALL(axleInfo.leftWheel);
				this.IEFBJGFEPBG(axleInfo.rightWheel);
			}
		}

		// Token: 0x06013379 RID: 78713 RVA: 0x00840D94 File Offset: 0x0083EF94
		public void ONLJFGLDAJI()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis(", ");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("ZombieIdle");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.KKBOHPNGNNK(axleInfo.leftWheel);
				this.NPGHIGJJALL(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601337A RID: 78714 RVA: 0x00840E5C File Offset: 0x0083F05C
		public void KJIHEDJJFNO(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x0601337B RID: 78715 RVA: 0x00840EA4 File Offset: 0x0083F0A4
		public void JHPFENJCEKP()
		{
			float motorTorque = this.maxMotorTorque * Input.GetAxis("StaffAttack");
			float steerAngle = this.maxSteeringAngle * Input.GetAxis("id");
			foreach (AxleInfo axleInfo in this.axleInfos)
			{
				if (axleInfo.steering)
				{
					axleInfo.leftWheel.steerAngle = steerAngle;
					axleInfo.rightWheel.steerAngle = steerAngle;
				}
				if (axleInfo.motor)
				{
					axleInfo.leftWheel.motorTorque = motorTorque;
					axleInfo.rightWheel.motorTorque = motorTorque;
				}
				this.FHLJGAGEHBL(axleInfo.leftWheel);
				this.FHLJGAGEHBL(axleInfo.rightWheel);
			}
		}

		// Token: 0x0601337C RID: 78716 RVA: 0x00840F6C File Offset: 0x0083F16C
		public void NHKMOJCFLHG(WheelCollider JNBDKOKIPEC)
		{
			if (JNBDKOKIPEC.transform.childCount == 0)
			{
				return;
			}
			Transform child = JNBDKOKIPEC.transform.GetChild(1);
			Vector3 position;
			Quaternion rotation;
			JNBDKOKIPEC.GetWorldPose(out position, out rotation);
			child.transform.position = position;
			child.transform.rotation = rotation;
		}

		// Token: 0x04002771 RID: 10097
		public List<AxleInfo> axleInfos;

		// Token: 0x04002772 RID: 10098
		public float maxMotorTorque;

		// Token: 0x04002773 RID: 10099
		public float maxSteeringAngle;
	}
}
