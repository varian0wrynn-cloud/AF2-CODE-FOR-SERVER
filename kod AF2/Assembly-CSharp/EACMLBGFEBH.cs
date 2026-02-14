using System;
using UnityEngine;

// Token: 0x020004E0 RID: 1248
public static class EACMLBGFEBH
{
	// Token: 0x06010ECD RID: 69325 RVA: 0x00793260 File Offset: 0x00791460
	public static Vector3 OJCMBDNOEJI(this OOKNJMJKFPM OODAGDHPJAE)
	{
		Vector3 one = Vector3.one;
		if ((OODAGDHPJAE & OOKNJMJKFPM.X) > OOKNJMJKFPM.None)
		{
			one.x = -1f;
		}
		if ((OODAGDHPJAE & OOKNJMJKFPM.Y) > OOKNJMJKFPM.None)
		{
			one.y = -1f;
		}
		if ((OODAGDHPJAE & OOKNJMJKFPM.Z) > OOKNJMJKFPM.None)
		{
			one.z = -1f;
		}
		return one;
	}
}
