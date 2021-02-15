using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UnityTipsTricks.P00006_BasicPause
{
	public class PauseUI : MonoBehaviour
	{
		[SerializeField]
		private Button _pauseButton = null;

		[SerializeField]
		private TMP_Text _pauseButtonText = null;

		private bool _isPaused = false;

		private void SetPaused(bool isPaused)
		{
			if(isPaused) {
				Time.timeScale = 0;
				_pauseButtonText.text = "Resume";
			} else {
				Time.timeScale = 1;
				_pauseButtonText.text = "Pause";
			}
		}

		private void OnPauseButtonClicked()
		{
			_isPaused = !_isPaused;
			SetPaused(_isPaused);
		}

		private void Start()
		{
			SetPaused(_isPaused);
		}

		private void OnEnable()
		{
			_pauseButton.onClick.AddListener(OnPauseButtonClicked);
		}

		private void OnDisable()
		{
			_pauseButton.onClick.RemoveListener(OnPauseButtonClicked);
		}
	}
}
