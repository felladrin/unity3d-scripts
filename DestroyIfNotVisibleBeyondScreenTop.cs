using UnityEngine;

public class DestroyIfNotVisibleBeyondScreenTop : MonoBehaviour
{
    public float HowFarBeyond;
    
    float limitPositionY;

    void Start()
    {
        limitPositionY = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y + HowFarBeyond;
    }

    void Update()
    {
        if (transform.position.y > limitPositionY )
        {
            Destroy(gameObject);
        }
    }
}
