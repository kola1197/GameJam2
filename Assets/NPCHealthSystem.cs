using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHealthSystem : DmageSckript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void ChangeHp(float deltaHP)
    {
        hp += deltaHP;
        if (hp <= 0)
        {
            Death();
        }
    }

    public override void Death()
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
