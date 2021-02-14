using System;

namespace UnityTipsTricks.P00006_BasicPause
{
	public class Timer
	{
		private TimeSpan _time = TimeSpan.Zero;

		public void Run(float deltaTime)
		{
			_time = _time.Add(TimeSpan.FromSeconds(deltaTime));
		}

		public string AsString()
		{
			return $"{_time.TotalHours:00}:{_time.TotalMinutes:00}:{_time.TotalSeconds:00}";
		}
	}
}
