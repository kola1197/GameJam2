using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
     public bool canMove = true;
    public float movementSpeed = 12.0f;
    public Vector3 desiredMovement;
    private CharacterController charController;
    private Animator anim;

    // Start is called before the first frame update
    public Vector3 MovementVector
    {
        get
        {
            return desiredMovement;
        }
        set
        {
            if (value != Vector3.zero)
            {
                desiredMovement = Vector3.Normalize(value);
                anim.SetBool("isWalking", true);
            }
            else
            {
                anim.SetBool("isWalking", false);
            }
        }
    }

    void Awake()
    {
        charController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
        {
            //Debug.Log(desiredMovement);
            if (desiredMovement != Vector3.zero)
            {
                charController.Move(desiredMovement * movementSpeed);
                desiredMovement = Vector3.zero;
            }
        }
    }
}
