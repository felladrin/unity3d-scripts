using UnityEngine;
using System.Collections;

public class DontDestroyObjectOnLoad : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
