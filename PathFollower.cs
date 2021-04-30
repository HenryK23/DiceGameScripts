using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{

    public Transform[] Waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;

    
    void Start()
    {
        transform.position = Waypoints[waypointIndex].transform.position; 
            
    }

   
    void Update()
    {
        if (moveAllowed)
        {
            Move();
        }
    }

    private void Move()
    {
        if (waypointIndex <= Waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                Waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);

            if(transform.position == Waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }

          
        }
    }

}
