using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleObjectFadeInOut : MonoBehaviour
{
	public float Speed = 0.5F;
	public int TimeInSecondsBeforeStartFadingOut = 1;

	bool apprearing = true;
	SpriteRenderer spriteRenderer;
	Color spriteRendererColor;

	void Start ()
	{
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		spriteRendererColor = spriteRenderer.color;
		spriteRendererColor.a = 0;
		spriteRenderer.color = spriteRendererColor;
	}

	void Update ()
	{
		spriteRendererColor = spriteRenderer.color;
		var currentOpacity = spriteRenderer.color.a;

		if (apprearing) {
			if (currentOpacity < 1) {
				spriteRendererColor.a = currentOpacity + Speed * Time.deltaTime;
				spriteRenderer.color = spriteRendererColor;
			} else {
				Invoke ("SetAppearingFalse", TimeInSecondsBeforeStartFadingOut);
			}
		} else {
			if (currentOpacity > 0) {
				spriteRendererColor.a = currentOpacity - Speed * Time.deltaTime;
				spriteRenderer.color = spriteRendererColor;
			}
		}
	}

	void SetAppearingFalse ()
	{
		apprearing = false;
	}
}
