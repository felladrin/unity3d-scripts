using UnityEngine;

public class MoveVerticallyWithKeys : MonoBehaviour
{
	public float Velocity;
	public Rigidbody2D rigidBody;
	public KeyCode upKey;
	public KeyCode downKey;

	void Update ()
	{
		if (Input.GetKey (upKey)) {
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, Velocity);
		} else if (Input.GetKey (downKey)) {
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, -Velocity);
		} else {
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, 0);
		}
	}
}