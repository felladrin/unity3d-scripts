using UnityEngine;

namespace HeadOfState
{
	public class CloseOnEscPressed : MonoBehaviour
	{
		void Update ()
		{
			if (gameObject.activeInHierarchy && Input.GetKey (KeyCode.Escape))
				gameObject.SetActive (false);
		}
	}
}