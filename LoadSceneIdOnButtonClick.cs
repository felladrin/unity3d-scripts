using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneIdOnButtonClick : MonoBehaviour
{
	public int SceneIdOnBuildSettings;

	public void OnClick()
	{
		SceneManager.LoadScene(SceneIdOnBuildSettings);
	}
}
