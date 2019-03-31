using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquilaSystem : MonoBehaviour
{
    public GameObject aquilaWorld;
    public GameObject aquilaOnBack;
    public Vector3 respawn;
    public float range = 5.0f;

    private GameObject player;
    private Vector3 startRespawn;
    private Vector3 startAquillaPosition;
    private DmageSckript healthSystem;

    public enum AquilaState
    {
        OnBack,
        Hidden,
        Lost,
    }

    public AquilaState currentState = AquilaState.Lost;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        healthSystem = GetComponent<DmageSckript>();
        startAquillaPosition = new Vector3(aquilaWorld.transform.position.x, aquilaWorld.transform.position.y, aquilaWorld.transform.position.z);
        startRespawn = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z);
        respawn = startRespawn;
    }

    private bool CheckPointInRange()
    {
        GameObject[] checkPoints = GameObject.FindGameObjectsWithTag("CheckPoint");
        for (int i = 0; i < checkPoints.Length; i++)
        {
            if ((checkPoints[i].transform.position - player.transform.position).magnitude < range)
            {
                return true;
            }
        }
        return false;
    }

    private bool AquillaInRange()
    {
        return (aquilaWorld.transform.position - transform.position).magnitude < range;
    }

    private void TakeAquila()
    {
        Debug.Log("Found");
        aquilaWorld.SetActive(false);
        aquilaOnBack.SetActive(true);
        currentState = AquilaState.OnBack;
        respawn = startRespawn;
    }

    private void PlaceAquila()
    {
        Debug.Log("Hid");
        aquilaOnBack.SetActive(false);
        aquilaWorld.SetActive(true);
        aquilaWorld.transform.position = player.transform.position;
        currentState = AquilaState.Hidden;
        respawn = aquilaWorld.transform.position; 
    }

    private void DropAquila()
    {
        Debug.Log("Dropped");
        aquilaOnBack.SetActive(false);
        aquilaWorld.SetActive(true);
        aquilaWorld.transform.position = player.transform.position;
        currentState = AquilaState.Lost;
        respawn = startRespawn;
    }

    public void AquilaAction()
    {
        if (currentState == AquilaState.OnBack)
        {
            Debug.Log(CheckPointInRange());
            if (CheckPointInRange())
            {
                PlaceAquila();
            }
            else
            {
                DropAquila();
            }
            return;
        }

        if (currentState == AquilaState.Hidden)
        {
            Debug.Log(AquillaInRange());
            if (AquillaInRange())
            {
                TakeAquila();
            }
            else
            {
                return;
            }
            return;
        }

        if (currentState == AquilaState.Lost)
        {
            if (AquillaInRange())
            {
                TakeAquila();
            }
            else
            {
                return;
            }
            return;
        }
    }

    public void RespawnAquila()
    {
        if (currentState != AquilaState.Hidden)
        {
            DropAquila();
            aquilaWorld.transform.position = startAquillaPosition;
        }
    }
}
