using UnityEngine;

public class ToggleGameObjectActiveOnClick : MonoBehaviour
{
	public GameObject TargetObject;

	public void OnClick()
	{
		TargetObject.SetActive (!TargetObject.activeInHierarchy);
	}
}