using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DmageSckript : MonoBehaviour
{
    public float hp = 100.0f;
    //public CapsuleCollider collider;
    public Transform playerPos;
    public Movement moveScript;
    public Image HPBar;
    public Image DeathUI;
    public float respawnTime = 0.2f;
    GameObject G;
    private float maxHP;
    private AquilaSystem aquila;
    

    // Start is called before the first frame update
    void Start()
    {
        maxHP = hp;
        playerPos = GameObject.FindWithTag("Player").transform;
        moveScript = GetComponent<Movement>();
        aquila = GetComponent<AquilaSystem>();
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
        Respawn();
        moveScript.canMove = false;
        //here death skript
        StartCoroutine("Respawn");
    }

    private void ChangeHp(int deltaHP)
    {

        hp += deltaHP;
        HPBar.fillAmount = hp / maxHP;
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

    IEnumerator Respawn()
    {
        float timer = 0;
        float fadingSpeed = 1 / respawnTime;
        float fade = 0.0f;
        while (timer < respawnTime)
        {
            timer += Time.deltaTime;
            fade += fadingSpeed * Time.deltaTime;
            DeathUI.color = new Color(DeathUI.color.r, DeathUI.color.b, DeathUI.color.g, fade);
            yield return null;
        }
        Vector3 delta = aquila.respawn - playerPos.position;
        playerPos.position = aquila.respawn;
        aquila.RespawnAquila();
        Camera.main.transform.position += delta;
        timer = 0;
        while (timer < respawnTime)
        {
            timer += Time.deltaTime;
            fade -= fadingSpeed * Time.deltaTime;
            DeathUI.color = new Color(DeathUI.color.r, DeathUI.color.b, DeathUI.color.g, fade);
            yield return null;
        }
        moveScript.canMove = true;
        hp = maxHP;
        HPBar.fillAmount = 1;

    }
}