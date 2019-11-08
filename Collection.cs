using ToolBox.Attributes;
using UnityEngine;

namespace ToolBox.Collections
{
	public class Collection<T> : ScriptableObject
	{
		public T[] Elements => elements;

		[SerializeField, ReorderableList] private T[] elements = null;
	}

}
