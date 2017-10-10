using UnityEngine;

public class MoveVerticallyWithArrows : MonoBehaviour
{
	public float Velocity;
	public Rigidbody2D rigidBody;

	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, Velocity);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, -Velocity);
		} else {
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, 0);
		}
	}
}
