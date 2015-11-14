using UnityEngine;
using System.Collections;

public class LoadLevelNameOnAnyKeyDown : MonoBehaviour
{
    public string LevelName;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            Application.LoadLevel(LevelName);
        }
    }
}
