using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Mars : MonoBehaviour
{
    int Mars_talk;
    int Loki_like_Mars;
    List<string> Mars_phrases;
    List<string> Loki_phrases;
    public int dif;
    public string Where_Mars(string a)
    {
        if (a == "юг") { return Mars_phrases [0]; }
        if (a == "север") { return Mars_phrases [1]; }
        if (a == "восток") { return Mars_phrases [2]; }
        if (a == "запад") { return Mars_phrases [3]; }
        return " ";
    }
    public string Where_Loki(string a)
    {
        if (a == "юг") { return Loki_phrases[0]; }
        if (a == "север") { return Loki_phrases[1]; }
        if (a == "восток") { return Loki_phrases[2]; }
        if (a == "запад") { return Loki_phrases[3]; }
        return " ";
    }

    public string Loki_or_Mars(int a, int b, string c)
    {
        a = Mars_talk;
        b = Loki_like_Mars;
        if (a - b > dif)
        {
            return Where_Loki(c);
        }
        if (b - a > dif)
        {
            return Where_Mars(c);
        }
        int r = Random.Range(1, 2);
        if (r == 1) { return Where_Mars(c); }
        else { return Where_Loki(c); }
        return " ";
    }
    public Mars()
    {
        Mars_talk = 0;
        Mars_phrases = new List<string>();

        string south = "Марс:-Путь твой лежит на юг если ты хочешь внести своё имя в легенды о героях!";
        string north = "Марс:-Ты выберешь север если  ты хочешь чтобы потомки гордились тобою! ";
        string west = "Марс:-Отправляйся на запад и слава сама придёт к тебе! ";
        string east = "Марс:-Иди на восток и меч твой не заржавеет в ножнах!";
        string ssouth = "Марс:-На юге лежит твоя возможность вновь доказать свою храбрость! ";
        Mars_phrases.Add(south);
        Mars_phrases.Add(north);
        Mars_phrases.Add(west);
        Mars_phrases.Add(east);
        Mars_phrases.Add(ssouth);

        List<string> Loki_phrases = new List<string>();
        string Msouth = "Марс:-Путь твой лежит на юг если ты хочешь внести своё имя в сагах о героях!";
        string Mnorth = "Марс:-Ты выберешь север если  ты хочешь чтобы потомки пели о тебе песни! ";
        string Mwest = "Марс:-Отправляйся на запад и боги примут тебя! ";
        string Meast = "Марс:-Иди на восток и топор твой не заржавеет в ножнах!";
        string Mssouth = "Марс:-На юге лежит твоя возможность вновь доказать своё неистовство! ";
        Loki_phrases.Add(Msouth);
        Loki_phrases.Add(Mnorth);
        Loki_phrases.Add(Mwest);
        Loki_phrases.Add(Meast);
        Loki_phrases.Add(Mssouth);
    }

}
