using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public static void OnStartClick()
    {
        PlayerPrefs.SetInt("Hearts", 0);
        PlayerPrefs.SetInt("Zombies", 0);
        PlayerPrefs.SetInt("Wins", 0);

        StateMachine.NextScene(PlayerPrefs.GetInt("Wins", 0));
    }

    public static void OnEndClick()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
