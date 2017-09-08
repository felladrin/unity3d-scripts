using UnityEngine;

public class DestroyWhenLeavesTheScreen : MonoBehaviour {
	bool hasBecameVisible;

	void OnBecameVisible() {
		hasBecameVisible = true;
	}

	void OnBecameInvisible() {
		if (hasBecameVisible) {
			Destroy (gameObject);
		}
	}
}
