using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public string baseAttackTrigger = "Strike";
    public string altAttackTrigger = "Poke";
    public TrapSkript weapon;
    private Animator anim;
    private float weaponActiveSeconds = 0.3f;
    private float weaponActivated;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (weaponActivated + weaponActiveSeconds < Time.time)
        {
            weapon.canDamage = false;
            Debug.Log(anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"));
        }
    }

    public void BaseAttack()
    {
        weaponActivated = Time.time;
        weapon.canDamage = true;
        anim.SetTrigger(baseAttackTrigger);

    }


    public void AltAttack()
    {
        weaponActivated = Time.time;
        weapon.canDamage = true;
        anim.SetTrigger(altAttackTrigger);
    }
}
