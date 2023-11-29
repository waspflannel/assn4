using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class StateMachine
{
    public static void NextScene(int counter)
    {
        if (counter < 3)
        {
            SceneManager.LoadScene("SampleScene");
        }

        else
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}