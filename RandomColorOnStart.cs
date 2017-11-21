using UnityEngine;

public class RandomColorOnStart : MonoBehaviour
{
	public float hueMin = 0.1f;
	public float hueMax = 1f;
	public float saturationMin = 1f;
	public float saturationMax = 1f;
	public float valueMin = 0.5f;
	public float valueMax = 1f;

	void Start ()
	{
		GetComponent<Renderer> ().material.color = Random.ColorHSV (hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax);
	}
}