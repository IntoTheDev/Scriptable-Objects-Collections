using ToolBox.Attributes;
using UnityEngine;

namespace ToolBox.Collections
{
	public class Collection<T> : ScriptableObject
	{
		[SerializeField, ReorderableList] private T[] elements = null;

		public T GetElement(int index) => elements[index];
	}

}
