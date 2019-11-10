using System;
using System.Collections.ObjectModel;
using ToolBox.Attributes;
using UnityEngine;

namespace ToolBox.Collections
{
	public class Collection<T> : ScriptableObject
	{
		public ReadOnlyCollection<T> Elements => Array.AsReadOnly(elements);

		[SerializeField, ReorderableList] private T[] elements = null;
	}
}
