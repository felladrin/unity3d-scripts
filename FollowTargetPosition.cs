using UnityEngine;

public class FollowTargetPosition : MonoBehaviour
{
    public GameObject target;
    public bool FollowXPosition;
    public bool FollowYPosition;
    public bool FollowZPosition;

    void Update()
    {
        if (target == null)
        {
            return;
        }

        var currentPosition = transform.position;
        var targetPosition = target.transform.position;

        if (FollowXPosition)
        {
            currentPosition.x = targetPosition.x;
        }

        if (FollowYPosition)
        {
            currentPosition.y = targetPosition.y;
        }

        if (FollowZPosition)
        {
            currentPosition.z = targetPosition.z;
        }

        transform.position = currentPosition;
    }
}
