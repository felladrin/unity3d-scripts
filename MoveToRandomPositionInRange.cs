using UnityEngine;
using System.Collections;

public class MoveToRandomPositionInRange : MonoBehaviour {
    private Vector3 originalPosition;
    public Vector3 maxDistance;
    public float secondsBetweenMoves;
    
    void Start () {
        originalPosition = transform.position;
        InvokeRepeating("Move", secondsBetweenMoves, secondsBetweenMoves);
    }
    
    void Move () {
        transform.position = new Vector3(
            originalPosition.x + Random.Range(-maxDistance.x, maxDistance.x),
            originalPosition.y + Random.Range(-maxDistance.y, maxDistance.y),
            originalPosition.z + Random.Range(-maxDistance.z, maxDistance.z)
        );
    }
}
