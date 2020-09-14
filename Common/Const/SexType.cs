using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Const
{
	public sealed class SexType : AbstractValueType
	{
		public const string ID_MALE = "0";
		public const string ID_FEMALE = "1";

		public const string CODE_MALE = "male";
		public const string CODE_FEMALE = "female";

		public static SexType MALE = new SexType(ID_MALE, "Male", CODE_MALE);
		public static SexType FEMALE = new SexType(ID_FEMALE, "FeMale", CODE_FEMALE);

		private SexType(string id, string label, string code)
			: base(id, label)
		{
			this.code = code;
		}

		private string code;
		public string Code
		{
			get { return this.code; }
		}

		public static IEnumerable<SexType> Types
		{
			get
			{
				yield return MALE;
				yield return FEMALE;
			}
		}

		public static SexType GetInstance(string label)
		{
			switch (label)
			{
				case CODE_MALE:
					return MALE;
				case CODE_FEMALE:
					return FEMALE;
			}
			return null;
		}

		public static SexType GetInstanceById(string id)
		{
			switch (id)
			{
				case ID_MALE:
					return MALE;
				case ID_FEMALE:
					return FEMALE;
			}
			return null;
		}
	}
}
