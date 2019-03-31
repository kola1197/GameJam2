using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Loki : MonoBehaviour
{
    public Loki()
    {
        int Loki_talk = 0;
        List<string> Mars_phrases = new List<string>();
        string Msouth = "Марс:-Путь твой лежит на юг если ты хочешь внести своё имя в сагах о героях!";
        string Mnorth = "Марс:-Ты выберешь север если  ты хочешь чтобы потомки пели о тебе песни! ";
        string Mwest = "Марс:-Отправляйся на запад и боги примут тебя! ";
        string Meast = "Марс:-Иди на восток и топор твой не заржавеет в ножнах!";
        string Mssouth = "Марс:-На юге лежит твоя возможность вновь доказать своё неистовство! ";
        Mars_phrases.Add(Msouth);
        Mars_phrases.Add(Mnorth);
        Mars_phrases.Add(Mwest);
        Mars_phrases.Add(Meast);
        Mars_phrases.Add(Mssouth);

        List<string> Minervas_phrases = new List<string>();
        string Misouth = "Миневра:-На юге твой путь если в ряд провидцев попасть ты хочешь!";
        string Minorth = "Миневра:-Север твой выбор, если хочешь ты проявить хитрость! ";
        string Miwest = "Миневра:-Двигайся на запад и слава о твоей мудрости достигнет ушей самого коннунг! ";
        string Mieast = "Миневра:-Иди на восток если ум твой козырь! ";
        string Miswest = "Миневра:-На запад лежит твой путь, если мысль заменят тебе богадство!";
        Minervas_phrases.Add(Misouth);
        Minervas_phrases.Add(Minorth);
        Minervas_phrases.Add(Miwest);
        Minervas_phrases.Add(Mieast);
        Minervas_phrases.Add(Miswest);

        List<string> Upiter_phrases = new List<string>();
        string Usouth = "Юпитер:-Иди на юг и твой путь будет лёгким!";
        string Unorth = "Юпитер:-На север отправляйся и спокойно будет в твоей душе!";
        string Uwest = "Юпитер:-Запад та сторона, что выберешь ты, если хочешь избежать трудностей!";
        string Ueast = "Юпитер:-Лежит на восток твой путь, если ты хочешь сохранить жизнь!";
        string Ussouth = "Юпитер:-Твоя дорога на юг пролегает если хочешь, чтобы тебя зщитили боги!";
        Upiter_phrases.Add(Usouth);
        Upiter_phrases.Add(Unorth);
        Upiter_phrases.Add(Uwest);
        Upiter_phrases.Add(Ueast);
        Upiter_phrases.Add(Ussouth);
    }
}
