using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Const
{
	[AttributeUsage(AttributeTargets.Field)]
	public class EnumLabelAttribute : Attribute
    {
		public string Label { get; set; }

		public int Order { get; set; }

		public static EnumLabelAttribute GetAttribute(Enum e)
		{
			var name = Enum.GetName(e.GetType(), e);
			return e.GetType().GetFields()
				.First(m => m.Name == name)
				.GetCustomAttributes(typeof(EnumLabelAttribute), false)
				.FirstOrDefault() as EnumLabelAttribute;
		}

		public static string GetLabel(Enum e)
		{
			var attr = GetAttribute(e);
			if (attr != null)
			{
				return attr.Label;
			}
			else
			{
				return string.Empty;
			}
		}
	}
}
