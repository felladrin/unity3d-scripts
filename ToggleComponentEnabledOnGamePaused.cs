using UnityEngine;

public class ToggleComponentEnabledOnGamePaused : MonoBehaviour {
	public string ComponentName;

	void Start() {
		Invoke("Pause", 1);
	}

	void Pause() {
		EventManager.InvokeOnGamePaused (true);
	}

	void OnGamePaused(bool paused) {
		var component = GetComponent (ComponentName);

		if (component != null) {
			((Behaviour)component).enabled = false;
		}
	}

	void OnEnable() {
		EventManager.OnGamePaused += OnGamePaused;
	}

	void OnDisable () {
		EventManager.OnGamePaused -= OnGamePaused;
	}
}
