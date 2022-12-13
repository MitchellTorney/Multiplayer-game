using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Transform Player;
    public UnityEngine.AI.NavMeshAgent enemy;
    public Transform pathHolder;
    public float speed = 5;
    public float waitTime = .3f; 



    void Start()
    {
        Vector3[] waypoints = new Vector3[pathHolder.childCount];
        for (int i = 0; i < waypoints.Length; i++)
        {
            waypoints [i] = pathHolder.GetChild (i).position;
        }
    }

    /*
    IEnumerator FollowPath(Vector3[] waypoints)
    {
        transform.position = waypoints [0];
        int targetWaypointIndex = 1;
        Vector3 targetWaypoint = waypoints [targetWaypointIndex];
        while (true){
            enemy.SetDestination = Vector3.MoveTowards(transform.position, targetWaypoint, speed * Time.deltaTime);
        }
    }
    */

    void OnDrawGizmos()
            {
            Vector3 startPosition = pathHolder.GetChild (0).position;
            Vector3 previousPosition = startPosition;

            foreach (Transform waypoint in pathHolder)
            {
                Gizmos.DrawSphere(waypoint.position, .3f );
                Gizmos.DrawLine (previousPosition, waypoint.position);
                previousPosition = waypoint.position;
            }
            Gizmos.DrawLine(previousPosition, startPosition);
        }

        void Update()
        {
            enemy.SetDestination(Player.position);
        }

}
