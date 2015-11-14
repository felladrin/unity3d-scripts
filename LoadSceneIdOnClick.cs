using UnityEngine;
using System.Collections;

public class LoadSceneIdOnClick : MonoBehaviour
{
    public int SceneIdOnBuildSettings;

    void OnMouseUp()
    {
        Application.LoadLevel(SceneIdOnBuildSettings);
    }
}
