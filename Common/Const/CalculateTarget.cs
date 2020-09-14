using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Const
{
	public sealed class CalculateTarget : NamedLabel<CalculateTarget>
	{
		public static readonly CalculateTarget Shares = new CalculateTarget()
		{
			Name = "Shares",
			Label = "【株式情報】",
		};
		public static readonly CalculateTarget SysTermReq = new CalculateTarget()
		{
			Name = "SysTermReq",
			Label = "【システム科目（必須設定）】",
		};
		public static readonly CalculateTarget SysTerm = new CalculateTarget()
		{
			Name = "SysTerm",
			Label = "【システム科目（任意設定）】",
		};
		public static readonly CalculateTarget ProfitsCtrl = new CalculateTarget()
		{
			Name = "ProfitsCtrl",
			Label = "【利益調整情報】",
		};
		public static readonly CalculateTarget Residual = new CalculateTarget()
		{
			Name = "Residual",
			Label = "【新株予約権情報】",
		};
		public static readonly CalculateTarget Stock = new CalculateTarget()
		{
			Name = "Stock",
			Label = "【ストック・オプション情報】",
		};
	}
}
