using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextCode : MonoBehaviour
{
    public GameObject Text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Offset_1 = GameObject.FindWithTag("Player").transform.position - GameObject.FindWithTag("npc1").transform.position;
        float Distance_1 = Offset_1.magnitude;

        Vector3 Offset_2 = GameObject.FindWithTag("Player").transform.position - GameObject.FindWithTag("npc2").transform.position;
        float Distance_2 = Offset_2.magnitude;

        if(Distance_1 <= 2f && Input.GetKeyDown(KeyCode.E))
        {
            
        }

        if(Distance_2 <= 2f && Input.GetKeyDown(KeyCode.E))
        {
            
        }
       
    }
}
