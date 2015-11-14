using UnityEngine;
using System.Collections;

public class Mmorpg3dCamera: MonoBehaviour {
	public Transform target;
	public float distance = 8;
	public float distanceMin = 5;
	public float distanceMax = 10;
	public float height = 8;
	public float heightMin = 5;
	public float heightMax = 10;
	public float heightDamping = 3;
	public float rotationDamping = 0;
	public float rotationSpeed = 3;

	void Start() {
		target = GameObject.FindWithTag("Player").transform;
	}

	void LateUpdate() {
		if (Input.GetAxis("Mouse ScrollWheel") != 0) {
			if (Input.GetAxis("Mouse ScrollWheel") > 0) {
				distance -= 0.3f;
				height -= 0.3f;
			} else {
				distance += 0.3f;
				height += 0.3f;
			}

			if (distance < distanceMin) {
				distance = distanceMin;
			}

			if (distance > distanceMax) {
				distance = distanceMax;
			}

			if (height < heightMin) {
				height = heightMin;
			}

			if (height > heightMax) {
				height = heightMax;
			}
		}

		if (Input.GetMouseButton(1)) {
			transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y + Input.GetAxis("Mouse X") * rotationSpeed, 0);
		}

		if (target) {
			float wantedRotationAngle = target.eulerAngles.y;
			float wantedHeight = target.position.y + height;
			float currentRotationAngle = transform.eulerAngles.y;
			float currentHeight = transform.position.y;

			currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
			currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);
			Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);
			Vector3 pos = target.position;
			pos -= currentRotation * Vector3.forward * distance;
			pos.y = currentHeight;
			transform.position = pos;
			transform.LookAt(target);
		}
	}
}