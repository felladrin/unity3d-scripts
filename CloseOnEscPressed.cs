using UnityEngine;

public class CloseOnEscPressed : MonoBehaviour
{
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
			gameObject.SetActive (false);
	}
}