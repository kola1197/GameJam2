﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public Text textplane;
    public CameraFollowScript fol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            textplane.text = "Ну чтоже, даже мертвые заслуживают 2 шанс, ну или сколько ты встречал смерть на своем пути? Не забудь, что ты вынес из этой истории";

            fol.enabled = false;
        }
    }
}
