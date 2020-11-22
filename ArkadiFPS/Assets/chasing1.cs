using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chasing1 : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;
    public float range;
    string theCollider;
    public GameObject receiver;
    
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update( )
    {
       
            agent.SetDestination(target.position);
        
    }




    public void OnTriggerEnter(Collider other)
    {
        theCollider = other.tag;
        if (theCollider == "Player")
        {
            receiver.SendMessage("DecreaseHealth");
        }
    }


    /* public void OnTriggerEnter(Collider other)
     {   theCollider = other.tag;
         if(theCollider=="Player")
         {
             receiver.SendMessage("DecreaseHealth");
         }
     }*/
}
