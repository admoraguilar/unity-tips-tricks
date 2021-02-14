using System;

namespace UnityTipsTricks.P00005_Counter
{
	public class Counter
	{
		public event Action<int> onValueChanged = delegate { };

		public int value
		{
			get => _value;
			set {
				_value = value;
				onValueChanged(_value);
			}
		}
		private int _value;
	}
}
