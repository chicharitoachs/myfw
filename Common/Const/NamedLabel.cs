using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common.Const
{
	public abstract class NamedLabel<T> where T : NamedLabel<T>
	{
		private static readonly object _lock = new object();
		private static IEnumerable<T> _values = null;

		public string Label
		{
			get;
			protected set;
		}

		public string Name
		{
			get;
			protected set;
		}

		public override string ToString()
		{
			return Label;
		}

		public static IEnumerable<T> Values
		{
			get
			{
				lock (_lock)
				{
					if (_values == null)
					{
						var type = typeof(T);
						_values = (from field in type.GetFields(BindingFlags.Public | BindingFlags.Static)
								   where type == field.FieldType
								   select (T)field.GetValue(null)).ToArray();

					}
				}
				return _values.ToArray();
			}
		}
	}
}
