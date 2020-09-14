using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Common.Utility.Expressions
{
	public class ExpressionCoupler<T>
	{
		public Expression<Func<T, bool>> Body
		{
			get;
			private set;
		}

		public void And(ExpressionCoupler<T> coupler)
		{
			if (coupler.Body == null)
			{
				return;
			}
			else
			{
				And(coupler.Body);
			}
		}

		public void And(Expression<Func<T, bool>> exp)
		{
			if (Body == null)
			{
				this.Body = exp;
			}
			else
			{
				this.Body = ExpressionUtils.And<T>(this.Body, exp);
			}
		}

		public void Or(ExpressionCoupler<T> coupler)
		{
			if (coupler.Body == null)
			{
				return;
			}
			else
			{
				Or(coupler.Body);
			}
		}

		public void Or(Expression<Func<T, bool>> exp)
		{
			if (Body == null)
			{
				this.Body = exp;
			}
			else
			{
				this.Body = ExpressionUtils.Or<T>(this.Body, exp);
			}
		}
	}
}
