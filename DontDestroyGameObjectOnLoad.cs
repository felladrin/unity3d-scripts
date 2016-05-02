using UnityEngine;

public class DontDestroyGameObjectOnLoad : MonoBehaviour
{
	void Awake()
	{
		DontDestroyOnLoad (gameObject);
	}
}
