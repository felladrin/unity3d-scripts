using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnKeyUp : MonoBehaviour
{
    public KeyCode Key;
    public KeyCode ComboKey;
    public UnityEvent OnKeyDown;

    void Update()
    {
        if (ComboKey == KeyCode.None)
        {
            if (Input.GetKeyUp(Key)) OnKeyDown.Invoke();
        }
        else
        {
            if (Input.GetKey(ComboKey) && Input.GetKeyUp(Key)) OnKeyDown.Invoke();
        }
    }
}
