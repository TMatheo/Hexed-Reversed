using System;
using TMPro;
using UnityEngine;

namespace Hexed.UIApi
{
	// Token: 0x02000048 RID: 72
	public class UITextMeshText
	{
		// Token: 0x06000228 RID: 552 RVA: 0x0000B4FC File Offset: 0x000096FC
		public UITextMeshText(GameObject parent, string Message, Vector2 position, int size, bool wordWrap = false, TextAlignmentOptions textAnchor = 257)
		{
			this.CreateText(parent, Message, position, size, wordWrap, textAnchor);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000B520 File Offset: 0x00009720
		public void SetText(string Message)
		{
			this.text.text = Message;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000B53C File Offset: 0x0000973C
		private void CreateText(GameObject parent, string Message, Vector2 position, int textsize, bool wordWrap, TextAlignmentOptions textAnchor)
		{
			this.TextObject = Object.Instantiate<GameObject>(MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/Panel_QM_Widget/Panel_QM_DebugInfo/Panel/Text_Ping").gameObject, parent.transform);
			foreach (Behaviour behaviour in this.TextObject.GetComponents<Behaviour>())
			{
				if (behaviour != this.TextObject.GetComponent<TextMeshProUGUI>())
				{
					Object.DestroyImmediate(behaviour);
				}
			}
			this.TextObject.name = "Hexed_UIText_" + Class109.RandomString(12);
			this.text = this.TextObject.GetComponent<TextMeshProUGUI>();
			this.text.name = this.TextObject.name;
			this.text.text = Message;
			this.text.richText = true;
			this.text.fontStyle = 1;
			this.text.enableWordWrapping = wordWrap;
			this.text.autoSizeTextContainer = false;
			this.text.fontSize = (float)textsize;
			this.text.fontSizeMax = (float)textsize;
			this.text.fontSizeMin = (float)textsize;
			this.text.alignment = textAnchor;
			this.text.enableKerning = false;
			this.TextObject.GetComponent<RectTransform>().localPosition = position;
			this.TextObject.GetComponent<RectTransform>().sizeDelta = new Vector2(600f, 0f);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002BF9 File Offset: 0x00000DF9
		internal static bool g4IXQoNfFep49C5flj1()
		{
			return UITextMeshText.QImgegNGBrPWIGFCuqO == null;
		}

		// Token: 0x040000F7 RID: 247
		public TextMeshProUGUI text;

		// Token: 0x040000F8 RID: 248
		public GameObject TextObject;

		// Token: 0x040000F9 RID: 249
		internal static UITextMeshText QImgegNGBrPWIGFCuqO;
	}
}
