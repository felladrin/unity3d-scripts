using UnityEngine;
using System.Collections;

public class LoadNextSceneButton : MonoBehaviour {

	public void LoadNextScene()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
