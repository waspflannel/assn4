using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI Hearts;

    public TextMeshProUGUI Zombies;

    public void Awake()
    {
        Hearts.SetText("You Collected " + PlayerPrefs.GetInt("Hearts", 0) + " Hearts");
        Zombies.SetText("You Slone " + PlayerPrefs.GetInt("Zombies", 0) + " Zombies");
    }
}