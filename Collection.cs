using System;
using System.Collections.ObjectModel;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Collections
{
	public class Collection<T> : ScriptableObject
	{
		public ReadOnlyCollection<T> Elements => Array.AsReadOnly(_elements);

		[SerializeField, ListDrawerSettings(Expanded = true)] private T[] _elements = null;
	}
}
