using UnityEngine;

public class ButtonClickToToggleGameObjectActive : MonoBehaviour
{
	public void OnClick (GameObject target)
	{
		target.SetActive (!target.activeInHierarchy);
	}
}
