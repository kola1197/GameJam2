using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScript : MonoBehaviour
{
    int counter = 0;
    public Text t;
    public InputManager inpMan;
    public Transform playerTr;
    public Movement playerMove;
    bool endactive = false;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    public void StartEnding()
    {
        inpMan.enabled = false;
        playerTr.position = new Vector3(120f, 0f, 120f);
        endactive = true;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {

            Debug.Log("you win");
            StartEnding();
        }
    }

    private void FixedUpdate()
    {
        if (counter < 40) { counter++; }
        if (endactive)
        {
            if (counter > 30)
            {
                playerMove.desiredMovement = new Vector3(0f, 0f, 0.2f);
            }
        }
    }
}
