using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Hexed.UIApi
{
	// Token: 0x02000047 RID: 71
	public class UIMenuText
	{
		// Token: 0x06000224 RID: 548 RVA: 0x0000B370 File Offset: 0x00009570
		public UIMenuText(GameObject parent, string Message, Vector2 position, int size, bool wordWrap = false, TextAnchor textAnchor = 0)
		{
			this.CreateText(parent, Message, position, size, wordWrap, textAnchor);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000B394 File Offset: 0x00009594
		public void SetText(string Message)
		{
			if (this.text != null)
			{
				this.text.text = Message;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000B3BC File Offset: 0x000095BC
		private void CreateText(GameObject parent, string Message, Vector2 position, int textsize, bool wordWrap, TextAnchor textAnchor)
		{
			this.TextObject = Object.Instantiate<GameObject>(Resources.FindObjectsOfTypeAll<Text>().FirstOrDefault<Text>().gameObject, parent.transform);
			foreach (Behaviour behaviour in this.TextObject.GetComponents<Behaviour>())
			{
				if (behaviour != this.TextObject.GetComponent<Text>())
				{
					Object.DestroyImmediate(behaviour);
				}
			}
			this.TextObject.name = "Hexed_UIText_" + Class109.RandomString(8);
			this.text = this.TextObject.GetComponent<Text>();
			this.text.text = Message;
			this.text.resizeTextForBestFit = wordWrap;
			this.text.horizontalOverflow = ((!wordWrap) ? 1 : 0);
			this.text.verticalOverflow = 1;
			this.text.fontSize = textsize;
			this.text.alignment = textAnchor;
			this.text.supportRichText = true;
			this.text.font = Font.GetDefault();
			this.TextObject.transform.localPosition = position;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002BEF File Offset: 0x00000DEF
		internal static bool OWFDQjNcyeufan3GiKC()
		{
			return UIMenuText.s1EAQQN5qLtary9e13t == null;
		}

		// Token: 0x040000F4 RID: 244
		public Text text;

		// Token: 0x040000F5 RID: 245
		public GameObject TextObject;

		// Token: 0x040000F6 RID: 246
		internal static UIMenuText s1EAQQN5qLtary9e13t;
	}
}
