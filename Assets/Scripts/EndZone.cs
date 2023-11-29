using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    public ClickToMove player;

    private void OnTriggerEnter(Collider collision)
    {
        bool isPlayer = collision.gameObject.name == "Player";

        if (isPlayer)
        {
            PlayerPrefs.SetInt("Hearts", PlayerPrefs.GetInt("Hearts", 0) + player.heartsCollected);
            PlayerPrefs.SetInt("Zombies", PlayerPrefs.GetInt("Zombies", 0) + player.zombiesKilled);
            PlayerPrefs.SetInt("Wins", PlayerPrefs.GetInt("Wins", 0) + 1);
            Debug.Log(PlayerPrefs.GetInt("Hearts", 0));
            Debug.Log(PlayerPrefs.GetInt("Zombies", 0));
            StateMachine.NextScene(PlayerPrefs.GetInt("Wins", 0));
        }
    }
}