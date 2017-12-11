using UnityEngine;

public class SceneEditorCameraMovement : MonoBehaviour {
	public float TranslateSpeed;
	public float RotateSpeed;

	Vector3 lastMousePosition = Vector3.zero;
	
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * Time.deltaTime * TranslateSpeed);
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * Time.deltaTime * TranslateSpeed);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back * Time.deltaTime * TranslateSpeed);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * Time.deltaTime * TranslateSpeed);
		}

		if (Input.GetKey (KeyCode.Q)) {
			transform.Translate (Vector3.down * Time.deltaTime * TranslateSpeed);
		}

		if (Input.GetKey (KeyCode.E)) {
			transform.Translate (Vector3.up * Time.deltaTime * TranslateSpeed);
		}

		if (Input.GetMouseButton (1)) {
			var currentMousePosition = Input.mousePosition;

			var newRotation = transform.rotation.eulerAngles;

			if (currentMousePosition.x > lastMousePosition.x) {
				newRotation.y += Time.deltaTime * RotateSpeed;
			} else if (currentMousePosition.x < lastMousePosition.x) {
				newRotation.y -= Time.deltaTime * RotateSpeed;
			}

			if (currentMousePosition.y > lastMousePosition.y) {
				newRotation.x -= Time.deltaTime * RotateSpeed;
			} else if (currentMousePosition.y < lastMousePosition.y) {
				newRotation.x += Time.deltaTime * RotateSpeed;
			}

			transform.rotation = Quaternion.Euler (newRotation);

			lastMousePosition = currentMousePosition;
		}
	}
}
