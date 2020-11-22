using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangePosition");
        //Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* private IEnumerator ChangePosition()
    {   for(int i=0;i<=5;i++)
        {
            transform.Translate(0, 1, 0);
            yield return new WaitForSeconds(2);
        }
       
    }*/

    
    void Move()
    {
        for (int i = 0; i <= 5; i++)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = i;
            
            
        }
    }
}
