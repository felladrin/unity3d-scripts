using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneIdOnClick : MonoBehaviour
{
	public int SceneIdOnBuildSettings;

	void OnMouseUp()
	{
		SceneManager.LoadScene(SceneIdOnBuildSettings);
	}
}
