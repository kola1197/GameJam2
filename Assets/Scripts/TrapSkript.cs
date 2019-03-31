using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSkript : MonoBehaviour
{
    public bool canDamage = false;
    public float damage = 80;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (canDamage)
        {
            Debug.Log(other.transform.root.GetComponent<DmageSckript>());
            if (other.gameObject.tag == "Body")
            {
                other.transform.root.GetComponent<DmageSckript>().ChangeHp(-damage);
            }
        }
    }

}
