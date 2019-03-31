using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmageSckript : MonoBehaviour
{
    public int hp = 100;
    public CapsuleCollider collider;
    public Transform playerPos;
    public Movement moveScript;
    GameObject G;
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
        Debug.Log("Collision with " + other.gameObject.tag);
        if (other.gameObject.tag == "trap")
        {
            Debug.Log("Collision sucksess");
            G = GameObject.Find(other.name);
            TrapSkript t = G.GetComponent<TrapSkript>();
            ChangeHp(-t.damage);
        }
    }
    public void Death()
    {
        Debug.Log("you died");
        playerPos.position = new Vector3(0,0,0);
        moveScript.canMove = false;
        //here death skript
    }

    public void ChangeHp(int deltaHP)
    {

        hp += deltaHP;
        Debug.Log("HP now " + hp.ToString());
        if (hp > 150)
        {
            hp = -239;
        }
        if (hp < 0)
        {
            Death();
        }
    }
}