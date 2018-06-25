using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineBetween : MonoBehaviour
{
    public Transform origin;

    public Transform destination;
    public LineRenderer line;

    void Update()
    {
        line.SetPosition(0, origin.position);
        line.SetPosition(1, destination.position);
    }
}
