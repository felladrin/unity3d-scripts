using UnityEngine;

public class StartWithImpulse : MonoBehaviour
{
	public float Impulse;
	public Rigidbody2D rigidBody;

	void Start ()
	{
		var xMultiplier = (Random.value > 0.5) ? 1 : -1;
		var yMultiplier = (Random.value > 0.5) ? 1 : -1;

		rigidBody.AddForce (new Vector2 (Impulse * xMultiplier, Impulse * yMultiplier), ForceMode2D.Impulse);
	}
}
