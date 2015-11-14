using UnityEngine;
using System.Collections;

public class GlowingButton : MonoBehaviour
{
    public float speed = 2;
    
    void Update()
    {
        Color newColor = new Color(1, 1, 1, Mathf.PingPong(Time.time * speed, 1));
        GetComponent<SpriteRenderer>().color = newColor;
    }
}
