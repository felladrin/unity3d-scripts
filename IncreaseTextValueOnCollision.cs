using UnityEngine;
using UnityEngine.UI;

public class IncreaseTextValueOnCollision : MonoBehaviour {
	public Text TextComponent;
	public int AmountToIncrease;
	public GameObject ObjectToWatchIfCollided;

	int numericValue;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == ObjectToWatchIfCollided.name) {
			numericValue += AmountToIncrease;
			TextComponent.text = numericValue.ToString ("0000");
		}
	}
}
