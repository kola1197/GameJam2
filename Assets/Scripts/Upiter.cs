using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Upiter : MonoBehaviour
{
    int Upiter_talk;
    int Loki_like_Upiter;
    List<string> Upiter_phrases;
    List<string> Loki_phrases;
    public int dif;
    public string Where_Upiter(string a)
    {
        if (a == "юг") { return Upiter_phrases[0]; }
        if (a == "север") { return Upiter_phrases[1]; }
        if (a == "восток") { return Upiter_phrases[2]; }
        if (a == "запад") { return Upiter_phrases [3]; }
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
    public string Loki_or_Upiter(int a, int b, string c)
    {
        a = Upiter_talk;
        b = Loki_like_Upiter;
        if(a - b > dif)
        {
            return Where_Loki(c);
        }
        if(b - a > dif)
        {
            return Where_Upiter(c);
        }
        int r = Random.Range(1,2);
        if (r == 1) { return Where_Upiter(c); }
        else { return Where_Loki(c); }
        return " ";
    }
    public Upiter()
    {
        Upiter_talk = 0;
        Loki_like_Upiter = 0;
        Upiter_phrases = new List<string>();
        string south = "Юпитер:-Иди на юг и лёгким будет путь твой!";
        string north = "Юпитер:-На север отправляйся и спокойствие прибудет в душе твоей!";
        string west = "Юпитер:-Запад та сторона, что выберешь ты, если трудностей избежать хочешь!";
        string east = "Юпитер:-Лежит на восток твой путь, если жизнь сохранить ты хочешь!";
        string ssouth = "Юпитер:-Твоя дорога на юг пролегает коли хочешь, чтобы боги тебя защитили!";
        Upiter_phrases.Add(south);
        Upiter_phrases.Add(north);
        Upiter_phrases.Add(west);
        Upiter_phrases.Add(east);
        Upiter_phrases.Add(ssouth);
        Loki_phrases = new List<string>();
        string Usouth = "Юпитер:-Иди на юг и твой путь будет лёгким!";
        string Unorth = "Юпитер:-На север отправляйся и спокойно будет в твоей душе!";
        string Uwest = "Юпитер:-Запад та сторона, что выберешь ты, если хочешь избежать трудностей!";
        string Ueast = "Юпитер:-Лежит на восток твой путь, если ты хочешь сохранить жизнь!";
        string Ussouth = "Юпитер:-Твоя дорога на юг пролегает если хочешь, чтобы тебя защитили боги!";
        Loki_phrases.Add(Usouth);
        Loki_phrases.Add(Unorth);
        Loki_phrases.Add(Uwest);
        Loki_phrases.Add(Ueast);
        Loki_phrases.Add(Ussouth);
    }
}
