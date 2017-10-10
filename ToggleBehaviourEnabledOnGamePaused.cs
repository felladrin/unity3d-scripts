using UnityEngine;

public class ToggleBehaviourEnabledOnGamePaused : MonoBehaviour
{
	public Behaviour behaviour;

	void OnGamePaused (bool paused)
	{
		behaviour.enabled = !paused;
	}

	void OnEnable ()
	{
		EventManager.OnGamePaused += OnGamePaused;
	}

	void OnDisable ()
	{
		EventManager.OnGamePaused -= OnGamePaused;
	}
}
