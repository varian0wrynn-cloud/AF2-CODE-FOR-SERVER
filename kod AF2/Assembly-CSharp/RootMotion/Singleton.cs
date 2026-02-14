using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x020003D9 RID: 985
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600D456 RID: 54358 RVA: 0x0060E929 File Offset: 0x0060CB29
		public static T COIPKPKLDAH
		{
			get
			{
				return Singleton<T>.AMPPFEHBFHH;
			}
		}

		// Token: 0x0600D457 RID: 54359 RVA: 0x0060E930 File Offset: 0x0060CB30
		protected virtual void Awake()
		{
			if (Singleton<T>.AMPPFEHBFHH != null)
			{
				Debug.LogError(base.name + "error: already initialized", this);
			}
			Singleton<T>.AMPPFEHBFHH = (T)((object)this);
		}

		// Token: 0x04001C24 RID: 7204
		private static T AMPPFEHBFHH;
	}
}
