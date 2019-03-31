using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCHealthSystem : DmageSckript
{
    public Transform Valhalla;
    public bool fixedInValhalla;
    private Vector3 originalPosition;

    protected override void Start()
    {
        base.Start();
        originalPosition = transform.position;
    }

    public override void ChangeHp(float deltaHP)
    {
        hp += deltaHP;
        if (hp <= 0)
        {
            Death();
        }
    }

    public float HealthLost()
    {
        return hp/maxHP;
    }

    public void setMaxHP(float value)
    {
        maxHP = value;
        hp = maxHP;
    }


    public override void Death()
    {
        transform.parent = Valhalla; 
        transform.localPosition = Vector3.zero;
        GetComponent<NPCScript>().UnTrigger();
    }

    public void Return()
    {
        hp = maxHP;
        transform.parent = null;
        transform.position = originalPosition;
        GetComponent<NavMeshAgent>().enabled = true;
    }

    // Update is called once per frame

}
