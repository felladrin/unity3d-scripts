using UnityEngine;

public class OffsetScroller : MonoBehaviour
{
	public float VerticalScrollSpeed;
	public float HorizontalScrollSpeed;
	Vector2 savedOffset;

	Renderer rendererComponent;

	void Start ()
	{
		rendererComponent = GetComponent<Renderer> ();
		savedOffset = rendererComponent.material.mainTextureOffset;
	}

	void Update ()
	{
		float y = Mathf.Repeat (Time.time * VerticalScrollSpeed, 1);
		float x = Mathf.Repeat (Time.time * HorizontalScrollSpeed, 1);
		var offset = new Vector2 (x, y);
		rendererComponent.material.mainTextureOffset = offset;
	}

	void OnDisable ()
	{
		rendererComponent.material.mainTextureOffset = savedOffset;
	}
}
