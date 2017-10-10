using UnityEngine;

public class KeepConstantVelocity : MonoBehaviour {
	public float Velocity;
	public Rigidbody2D rigidBody;

	void Update () { 
		rigidBody.velocity = Velocity * (rigidBody.velocity.normalized);
	}
}
