using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class TextCode : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public string Line;
    void Start()
    {
        tmp = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other) {

        if(other.transform.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            tmp.text = "Hello";
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        tmp.text = "";
    }
}