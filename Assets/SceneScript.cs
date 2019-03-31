using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour
{
    int counter=0;
    public AudioSource audio;
    public Text t;
    Movement[] leg = new Movement[8]; 
        bool LegioMove = false;
    public Camera mCamera;
    public Camera oldCamera;
    bool cameraMove = false;


    bool textAlphaChenge = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject G;
        for (int i = 0; i < 8; i++)
        {
            G = GameObject.Find("Player"+(i+1).ToString());
            Transform tt = G.GetComponent<Transform>();
            leg[i] = G.GetComponent<Movement>();
            leg[i].movementSpeed = 0.05f;
        }
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (LegioMove)
        {
            foreach (var v in leg)
            {
                v.desiredMovement = new Vector3(1,0,0);
            }
        }
        if (cameraMove)
        {
            mCamera.transform.localPosition += new Vector3(0, 0, 0.01f);
        }
        Color c;
        if (textAlphaChenge)
        {
            c = t.color;
            c.a = c.a-0.02f;
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
                cameraMove = true;
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
            default:break;
        }
    }
}
