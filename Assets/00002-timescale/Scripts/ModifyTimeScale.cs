using UnityEngine;

namespace UnityTipsTricks.P00002_Timescale
{
	public class ModifyTimeScale : MonoBehaviour
	{
		// https://answers.unity.com/questions/36509/if-timescale-is-lowered-how-can-i-aviod-to-get-the.html
		private void SetTimeScale(float scale)
		{
			Time.timeScale = scale;
			Time.fixedDeltaTime = scale * .02f;
		}

		private void Update()
		{
			// 1f = Normal time

			if(Input.GetKeyDown(KeyCode.Q)) {
				// Slow-down time
				SetTimeScale(.5f);
			}

			if(Input.GetKeyDown(KeyCode.W)) {
				// Freeze-time
				SetTimeScale(0f);
			}

			if(Input.GetKeyDown(KeyCode.E)) {
				// Faster time
				SetTimeScale(2f);
			}
		}
	}
}
