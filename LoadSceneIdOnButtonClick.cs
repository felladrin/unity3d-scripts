using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Place this script in a button and link itself to the UnityEvent on the button,
/// calling the LoadScene method and indicating the Scene ID to be loaded.
/// </summary>
public class LoadSceneIdOnButtonClick : MonoBehaviour
{
	public void LoadScene(int sceneIdOnBuildSettings)
	{
		SceneManager.LoadScene(sceneIdOnBuildSettings);
	}
}
