using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Minevra : MonoBehaviour
{
    int Minevra_talk;
    int Loki_like_Minevra;
    List<string> Minevras_phrases;
    List<string> Loki_phrases;
    public int dif;
    public string Where_Minevra(string a)
    {
        if (a == "юг") { return Minevras_phrases[0]; }
        if (a == "север") { return Minevras_phrases[1]; }
        if (a == "восток") { return Minevras_phrases[2]; }
        if (a == "запад") { return Minevras_phrases[3]; }
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
    public string Loki_or_Minevra(int a, int b, string c)
    {
        a = Minevra_talk;
        b = Loki_like_Minevra;
        if (a - b > dif)
        {
            return Where_Loki(c);
        }
        if (b - a > dif)
        {
            return Where_Minevra(c);
        }
        int r = Random.Range(1, 2);
        if (r == 1) { return Where_Minevra(c); }
        else { return Where_Loki(c); }
        return " ";
    }
    public Minevra()
    {
        Minevra_talk = 0;
        Loki_like_Minevra = 0;
        Minevras_phrases = new List<string>();
        string south = "Минвра:-На юге твой путь если в ряд мудрецов попасть ты хочешь!";
        string north = "Минерва:-Север твой выбор, если хочешь ты проявить смекалку! ";
        string west = "Минерва:-Двигайся на запад и слава о твоей мудрости достигнет ушей самого императора! ";
        string east = "Минерва:-Иди на восток если ум твоя сильная сторона! ";
        string swest = "Минерва:-На запад лежит твой путь, если мысль заменят тебе оружие!";
        Minevras_phrases.Add(south);
        Minevras_phrases.Add(north);
        Minevras_phrases.Add(west);
        Minevras_phrases.Add(east);
        Minevras_phrases.Add(swest);
        Loki_phrases = new List<string>();
        string Misouth = "Минерва:-На юге твой путь если в ряд провидцев попасть ты хочешь!";
        string Minorth = "Минерва:-Север твой выбор, если хочешь ты проявить хитрость! ";
        string Miwest = "Минерва:-Двигайся на запад и слава о твоей мудрости достигнет ушей самого коннунг! ";
        string Mieast = "Минерва:-Иди на восток если ум твой козырь! ";
        string Miswest = "Минерва:-На запад лежит твой путь, если мысль заменят тебе богадство!";
        Loki_phrases.Add(Misouth);
        Loki_phrases.Add(Minorth);
        Loki_phrases.Add(Miwest);
        Loki_phrases.Add(Mieast);
        Loki_phrases.Add(Miswest);
    }
}