/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using UnityEditor;
using System.Collections;

namespace PostProcess
{
	[CustomEditor (typeof(BlinkEffect))]
	public class EyeBlinkEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			BlinkEffect effect = (BlinkEffect) target;
			if (effect.isActiveAndEnabled) {
				if (GUILayout.Button ("Test Animation")) {
					if (!Application.isPlaying) 
						effect.RunEditorPreview ();
					else 
						effect.Blink ();
				}
			} else {
				GUILayout.Space (5);
				GUILayout.Label ("Camera is inactive");
			}
		}
	}
}
