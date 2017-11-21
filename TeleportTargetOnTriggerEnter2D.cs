using UnityEngine;

public class TeleportTargetOnTriggerEnter2D : MonoBehaviour {
	public Vector2 PositionToTeleport;
	public GameObject ObjectToWatchIfCollided;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == ObjectToWatchIfCollided.name) {
			other.transform.position = PositionToTeleport;
		}
	}
}
