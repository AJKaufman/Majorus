using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {

  public int money;
  public float mana;
  public string[] Swords = {"Maramusa", "Scarred Cleaver", "Mutton Chop", "Massive Lance", "Agile Corsair", "Equalizer"};

  // Use this for initialization
  void Start () {
    Debug.Log("Pass me my " + GetRandomSword());
  }

  // Update is called once per frame
  void Update () {

  }

  // Get a sword
  public string GetRandomSword() {
    float max = (float)Swords.Length;
    return Swords[Random.Range(0.0f, max)];
  }
    
}
