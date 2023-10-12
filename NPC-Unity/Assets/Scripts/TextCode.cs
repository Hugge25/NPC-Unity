using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class TextCode : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    private float rad = 3;
    void Start()
    {
        tmp = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Offset_1 = GameObject.FindWithTag("Player").transform.position - GameObject.FindWithTag("npc1").transform.position;
        float Distance_1 = Offset_1.magnitude;

        Vector3 Offset_2 = GameObject.FindWithTag("Player").transform.position - GameObject.FindWithTag("npc2").transform.position;
        float Distance_2 = Offset_2.magnitude;

        if(Distance_1 <= rad && Input.GetKeyDown(KeyCode.E))
        {
            tmp.text = "Hey";
        }
        else if(Distance_2 <= rad && Input.GetKeyDown(KeyCode.E))
        {
            tmp.text = "Hello";
        }
        else if(Distance_1 >= rad && Distance_2 >= rad)
        {
            tmp.text = "";
        }


        
       
    }
}
