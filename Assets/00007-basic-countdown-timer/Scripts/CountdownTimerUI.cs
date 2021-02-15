using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace UnityTipsTricks.P00007_BasicCountdownTimer
{
	public class CountdownTimerUI : MonoBehaviour
	{
		public int startingSeconds = 10;
		public bool runOnStart = true;

		[SerializeField]
		private UnityEvent _onTimerRun = null;

		[SerializeField]
		private UnityEvent _onTimerFinished = null;

		[Header("UI")]
		[SerializeField]
		private TMP_Text _timerValueText = null;

		private float _timerValue = 0f;
		private bool _isDone = false;

		[ContextMenu("Run")]
		public void Run()
		{
			_timerValue = startingSeconds;
			_isDone = false;
			_onTimerRun.Invoke();
		}

		private void Start()
		{
			if(runOnStart) {
				Run();
			}
		}

		private void Update()
		{
			if(!_isDone) {
				if(_timerValue <= 0) {
					_isDone = true;
					_onTimerFinished.Invoke();
				} else {
					_timerValue -= Time.deltaTime;
				}

				_timerValueText.text = _timerValue.ToString("F0");
			}
		}
	}
}
