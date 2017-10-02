using UnityEngine;

public class SimpleFollow : MonoBehaviour
{
	public GameObject target;
	public bool FollowXPosition;
	public bool FollowYPosition;
	public bool FollowZPosition;

	void Update ()
	{
		if (target == null) {
			return;
		}

		if (FollowXPosition) {
			transform.position = new Vector3 (
				target.transform.position.x,
				transform.position.y,
				transform.position.z
			);
		}

		if (FollowYPosition) {
			transform.position = new Vector3 (
				transform.position.x,
				target.transform.position.y,
				transform.position.z
			);
		}

		if (FollowZPosition) {
			transform.position = new Vector3 (
				transform.position.x,
				transform.position.y,
				target.transform.position.z
			);
		}
	}
}
