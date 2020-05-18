using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavEnemy : MonoBehaviour{

    private NavMeshAgent agent;
    private int i;
    public List<GameObject> waypoints;

    void Start(){
        agent = GetComponent<NavMeshAgent>();
        //waypoints = new List<GameObject>();
        i = 0;
        if (agent) agent.SetDestination(waypoints[0].transform.position);
    }

    void Update(){
        Vector3 wp = waypoints[i].transform.position;
        if (transform.position.ToString() == wp.ToString()) {
            if(i < 3) {
                i += 1;
            } else {
                i = 0;
            }
        }
        agent.SetDestination(waypoints[i].transform.position);
    }
}
