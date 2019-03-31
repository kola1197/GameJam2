using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public Transform playerPos;
    public DmageSckript playerDamage;
    public BoxCollider radar;
    public int type=1;
    public int HP = 100;
    public int damage = 100;
    public float vel = 1.2f;
    bool triggered = false;
    public Movement moves;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            float dist = distToTarget();
            if (dist < 4)
            {
                //here attack animation
                playerDamage.ChangeHp(-damage);
            }
            else
            {
                  //move to enemy
            }
        }
    }

    public void AttackPlayer()
    {

    }

    private float distToTarget()
    {
        float result = -1;
        result = Mathf.Sqrt((playerPos.position.x - this.transform.position.x)* (playerPos.position.x - this.transform.position.x)+ (playerPos.position.y - this.transform.position.y)*(playerPos.position.y - this.transform.position.y));


        return result;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggered = true;
        }
    }
}
