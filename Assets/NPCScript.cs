using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCScript : MonoBehaviour
{
    public Transform playerPos;
    public DmageSckript playerDamage;
    public BoxCollider radar;
    public int type=1;
    public float initHP = 100;
    public float initDamage = 50;
    public float initSpeed = 12.0f;
    public float reload = 1.0f;
    public float vel = 1.2f;
    public float attackRange = 1.2f;
    bool triggered = false;
    public NavMeshAgent moves;
    public float buffStrength = 0.001f;

    private int currentBuff = 0;
    private float HP = 100;
    private float Damage = 50;
    private float Speed = 12.0f;
    private float lastTimeReload;
    private float reloadTime;
    // Start is called before the first frame update
    private Attack attackSystem;

    void Start()
    {
        attackSystem = GetComponent<Attack>();
        moves = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        BuffOnDeath();
        if (triggered)
        {
            if ((playerPos.position - transform.position).magnitude <= attackRange)
            {
                //here attack animation
                if ((lastTimeReload + reload) < Time.time)
                {
                    attackSystem.BaseAttack();
                    lastTimeReload = Time.time;
                }
            }
            else
            {
                moves.SetDestination(playerPos.position);
                transform.forward = new Vector3((playerPos.position - transform.position).x, 0, (playerPos.position - transform.position).z);
            }
        }
    }

    public void BuffOnDeath()
    {
        if (playerPos.GetComponent<DmageSckript>().DeathCount > currentBuff)
        {
            for (int i = 0; i < playerPos.GetComponent<DmageSckript>().DeathCount - currentBuff; i++)
            {
                HP += HP * buffStrength;
                Damage += Damage * buffStrength;
                Speed += Speed * buffStrength;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggered = true;
        }
    }
}
