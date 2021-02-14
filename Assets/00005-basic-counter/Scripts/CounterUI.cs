using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UnityTipsTricks.P00005_Counter
{
	public class CounterUI : MonoBehaviour
	{
		[Header("UI")]
		[SerializeField]
		private TMP_Text _valueText = null;

		[SerializeField]
		private Button _incrementButton = null;

		[SerializeField]
		private Button _decrementButton = null;

		[SerializeField]
		private Button _resetButton = null;

		private Counter _counter = new Counter();

		private void OnValueUpdate(int value)
		{
			_valueText.text = value.ToString();
		}

		private void OnIncrementButtonClicked()
		{
			_counter.value++;
		}

		private void OnDecrementButtonClicked()
		{
			_counter.value--;
		}

		private void OnResetButtonClicked()
		{
			_counter.value = 0;
		}

		private void OnEnable()
		{
			_counter.onValueChanged += OnValueUpdate;
			_incrementButton.onClick.AddListener(OnIncrementButtonClicked);
			_decrementButton.onClick.AddListener(OnDecrementButtonClicked);
			_resetButton.onClick.AddListener(OnResetButtonClicked);
		}

		private void OnDisable()
		{
			_counter.onValueChanged -= OnValueUpdate;
			_incrementButton.onClick.RemoveListener(OnIncrementButtonClicked);
			_decrementButton.onClick.RemoveListener(OnDecrementButtonClicked);
			_resetButton.onClick.RemoveListener(OnResetButtonClicked);
		}
	}
}
