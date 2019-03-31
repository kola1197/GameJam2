using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour
{
    int counter=0;
    public AudioSource audioM;
    public Text t;
    Movement[] leg = new Movement[8]; 
        bool LegioMove = false;

    public AudioClip cl1;
    public AudioClip cl2;
    public AudioClip cl3;


    public Camera mCamera;
    public Camera oldCamera;
    bool cameraMovef = false;
    bool cameraMoveS = false;
    public bool withIntro = true;

    bool textAlphaChenge = false;

    // Start is called before the first frame update
    void Start()
    {
        if (withIntro)
        {
            GameObject G;
            for (int i = 0; i < 8; i++)
            {
                G = GameObject.Find("Player" + (i + 1).ToString());
                Transform tt = G.GetComponent<Transform>();
                leg[i] = G.GetComponent<Movement>();
                leg[i].movementSpeed = 0.05f;
            }
            audioM.Play();
        }
        else
        {
            oldCamera.enabled = true;
            mCamera.enabled = false;
            int numb = Random.Range(1,4);
            switch (numb) 
            {
                case 1:
                    audioM.clip = cl1;
                    break;
                case 2:
                    audioM.clip = cl2;
                    break;
                case 3:
                    audioM.clip = cl3;
                    break;
            }
            audioM.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (withIntro)
        {
            if (LegioMove)
            {
                foreach (var v in leg)
                {
                    v.desiredMovement = new Vector3(1, 0, 0);
                }
            }
            if (cameraMovef)
            {
                mCamera.transform.localPosition += new Vector3(0.01f, 0, -0.01f);
            }
            if (cameraMoveS)
            {
                mCamera.transform.localPosition += new Vector3(0.02f, 0, 0.02f);
            }
            Color c;
            if (textAlphaChenge)
            {
                c = t.color;
                c.a = c.a - 0.02f;
                t.color = c;
            }
            counter++;
            switch (counter)
            {
                case 10:
                    t.text = "«Квинтилий Вар, верни мне легионы!!!»";
                    break;
                case 150:
                    textAlphaChenge = true;
                    break;
                case 200:
                    textAlphaChenge = false;
                    c = t.color;
                    c.a = 1f;
                    t.color = c;
                    t.text = "Квинтилий Вар - «Нести аквиллу это большая честь, благоволение  духа легиона будет зависить от тебя» ";
                    break;
                case 550:
                    textAlphaChenge = true;
                    break;
                case 600:
                    textAlphaChenge = false;
                    c = t.color;
                    c.a = 1f;
                    t.color = c;
                    t.text = "Луций - «даже если мне придется пробираться назад из царства аида, я не оставлю свой долг» ";
                    break;
                case 950:
                    textAlphaChenge = true;
                    break;
                case 1000:
                    textAlphaChenge = false;
                    c = t.color;
                    c.a = 1f;
                    t.color = c;
                    t.text = "Голос -  «etiam, immo … ut vis»  ";
                    break;
                case 1250:
                    textAlphaChenge = true;
                    break;
                case 1300:
                    mCamera.transform.position = new Vector3(-141f, 3, -120f);
                    mCamera.transform.RotateAround(new Vector3(0, 1, 0), 120);
                    cameraMovef = true;
                    oldCamera.enabled = false;
                    mCamera.enabled = true;
                    textAlphaChenge = false;
                    c = t.color;
                    c.a = 1f;
                    t.color = c;
                    t.text = "9 год нашей эры, сентябрь";
                    LegioMove = true;
                    break;
                case 1750:
                    textAlphaChenge = true;
                    break;
                case 1800:
                    mCamera.transform.position = new Vector3(-114f, 3f, -110f);
                    mCamera.transform.RotateAround(new Vector3(0, 1, 0), 190);
                    cameraMovef = false;
                    cameraMoveS = true;
                    textAlphaChenge = false;
                    c = t.color;
                    c.a = 1f;
                    t.color = c;
                    t.text = "Тевтобургский лес";
                    break;
                case 2050:
                    textAlphaChenge = true;
                    break;
                case 2100:
                    textAlphaChenge = false;
                    c = t.color;
                    c.a = 1f;
                    t.color = c;
                    t.text = "Войска Римской империи направляются на север германских земель";
                    break;
                case 2250:
                    textAlphaChenge = true;
                    break;
                case 2300:
                    textAlphaChenge = false;
                    c = t.color;
                    c.a = 1f;
                    t.color = c;
                    t.text = "Легионы непобедимы на поле боя";
                    break;
                case 2450:
                    textAlphaChenge = true;
                    break;
                case 2500:
                    textAlphaChenge = false;
                    c = t.color;
                    c.a = 1f;
                    t.color = c;
                    t.text = "Но не на марше";
                    break;
                default: break;
            }
        }
    }
}
