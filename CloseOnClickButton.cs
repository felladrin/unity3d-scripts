using UnityEngine;

public class CloseOnClickButton : MonoBehaviour
{
	public void OnClick()
	{
		gameObject.SetActive (false);
	}
}

