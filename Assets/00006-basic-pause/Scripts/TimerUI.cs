using UnityEngine;
using TMPro;

namespace UnityTipsTricks.P00006_BasicPause
{
	public class TimerUI : MonoBehaviour
	{
		[Header("UI")]
		[SerializeField]
		private TMP_Text _timerText = null;

		private Timer _timer = new Timer();

		private void Update()
		{
			_timer.Run(Time.deltaTime);
			_timerText.text = _timer.AsString();
		}
	}
}
