using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public string baseAttackTrigger = "Strike";
    public string altAttackTrigger = "Poke";
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BaseAttack()
    {
        anim.SetTrigger(baseAttackTrigger);
    }


    public void AltAttack()
    {
        anim.SetTrigger(altAttackTrigger);
    }
}
