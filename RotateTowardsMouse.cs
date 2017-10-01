using UnityEngine;

public class RotateTowardsMouse : MonoBehaviour
{
	public UpAxisOption UpAxis;

	public enum UpAxisOption
	{
		X,
		Y,
		Z
	}

	void Update ()
	{
		var positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
		var mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint (Input.mousePosition);
		float angle = AngleBetweenTwoPoints (mouseOnScreen, positionOnScreen);

		switch (UpAxis) {
		case UpAxisOption.X:
			transform.rotation = Quaternion.Euler (new Vector3 (angle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
			break;
		case UpAxisOption.Y:
			transform.rotation = Quaternion.Euler (new Vector3 (transform.rotation.eulerAngles.x, angle, transform.rotation.eulerAngles.z));
			break;
		case UpAxisOption.Z:
			transform.rotation = Quaternion.Euler (new Vector3 (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, angle));
			break;
		}
	}

	static float AngleBetweenTwoPoints (Vector3 a, Vector3 b)
	{
		return Mathf.Atan2 (a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
