using UnityEngine;
using System.Collections;

public class FollowWaypoints : MonoBehaviour
{
    public float speed = 2;
    public bool loop = true;
    public Transform[] waypoints;

    private int currentWaypoint = 0;

    void Update()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        if (currentWaypoint >= waypoints.Length)
        {
            if (loop)
            {
                currentWaypoint = 0;
            }
            else
            {
                return;
            }
        }

        if (Vector2.Distance(waypoints[currentWaypoint].position, transform.position) < 0.02)
        {
            currentWaypoint++;
        }
        else
        {
            Vector2 direction = waypoints[currentWaypoint].position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }
}