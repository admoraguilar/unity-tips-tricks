using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityTipsTricks.P00004_Scenes
{
	public class SceneChanger : MonoBehaviour
	{
		[SerializeField]
		private string _destinationScene = string.Empty;

		private void Update()
		{
			if(Input.GetKeyDown(KeyCode.A)) {
				SceneManager.LoadScene(_destinationScene);
			}
		}
	}
}
