using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Const
{
	public abstract class AbstractValueType
	{
		protected AbstractValueType(string id, string label)
		{
			ID = id;
			Label = label;
		}

		[Key]
		public string ID { get; protected set; }
		public string Label { get; protected set; }
	}
}
