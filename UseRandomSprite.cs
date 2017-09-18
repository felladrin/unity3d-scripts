using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class UseRandomSprite : MonoBehaviour {
	public List<Sprite> spriteList = new List<Sprite>();

	void Awake () {
		if (spriteList.Count > 0) {
			GetComponent<SpriteRenderer> ().sprite = spriteList [Random.Range (0, spriteList.Count)];
		}
	}
}
