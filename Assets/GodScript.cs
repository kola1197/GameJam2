using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodScript : MonoBehaviour
{
    bool isHere = true;
    int counter=0;
    public string reply;
    Text textPlane;
    bool startAlpha=false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject G = GameObject.Find("TextPlane");
        textPlane = G.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isHere)
        {
            Debug.Log("GGGOOODDD");
            textPlane.text = reply;
            counter = 0;
            isHere = false;
        }
    }

    private void FixedUpdate()
    {
        if (counter < 400)
        {
            counter++;
        }
        if (counter == 300)
        {
            startAlpha = true;
        }
        if (startAlpha)
        {
            Color c = textPlane.color;
            c.a = textPlane.color.a - 0.02f;
            textPlane.color = c;
            if (textPlane.color.a < 0.04f)
            {
                startAlpha = false;
                c = textPlane.color;
                c.a = 1f;
                textPlane.color = c;
                textPlane.text = "";

            }
        }
    }
}
