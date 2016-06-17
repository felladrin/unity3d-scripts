using UnityEngine;
using UnityEngine.UI;

public class ToggleImageOnClick : MonoBehaviour {
	public Sprite DefaultImage;
	public Sprite AlternativaImage;

	private Image imageComponent;

	// Use this for initialization
	void Start () {
		imageComponent = GetComponent<Image>();
	}

	void OnClick() {
		imageComponent.sprite = (imageComponent.sprite == DefaultImage) ? AlternativaImage : DefaultImage;
	}
}
