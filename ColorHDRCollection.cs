using UnityEngine;

namespace ToolBox.Collections
{
	[CreateAssetMenu(menuName = "ToolBox/Collections/HDR Colors")]
	public class ColorHDRCollection : Collection<ColorHDR> { }
}


[System.Serializable]
public struct ColorHDR
{
	public Color32 Value => color;

	[SerializeField, ColorUsage(true, true)] private Color32 color;
}

