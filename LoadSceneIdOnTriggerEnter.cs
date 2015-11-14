using UnityEngine;
using System.Collections;

public class LoadSceneIdOnTriggerEnter : MonoBehaviour
{
    public int SceneIdOnBuildSettings;

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(SceneIdOnBuildSettings);
    }
}
