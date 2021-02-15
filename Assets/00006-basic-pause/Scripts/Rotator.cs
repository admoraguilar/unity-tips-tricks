using UnityEngine;

namespace UnityTipsTricks.P00006_BasicPause
{
	public class Rotator : MonoBehaviour
	{
		public Space space = Space.Self;
		public Vector3 rotation = Vector3.zero;
		public float rotationSpeed = 10f;

		public new Transform transform
		{
			get {
				if(_transform == null) { _transform = GetComponent<Transform>(); }
				return _transform;
			}
		}
		private Transform _transform = null;

		private void Update()
		{
			transform.Rotate(rotation * rotationSpeed * Time.deltaTime, space);
		}
	}
}
