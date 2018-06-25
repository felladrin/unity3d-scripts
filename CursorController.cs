using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Vector2 CursorHotspot;
    public Texture2D cursorTexture;

    static CursorController instance;
    public static CursorController Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        SetCustomCursor();
    }

    void OnDisable()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    void SetCustomCursor()
    {
        Cursor.SetCursor(cursorTexture, CursorHotspot, CursorMode.Auto);
    }
}
