using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnDestroy : MonoBehaviour
{
    public GameObject ExplosionPrefab;

    bool isQuitting;

    void OnDestroy()
    {
        if (!isQuitting) Instantiate(ExplosionPrefab, transform.position, transform.rotation);
    }

    void OnApplicationQuit()
    {
        isQuitting = true;
    }
}
