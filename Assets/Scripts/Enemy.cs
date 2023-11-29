using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage = 1;
    public ClickToMove player;
    private void Awake()
    {
        health = 1;
        damage = 1;
    }

    private void Update()
    {
        if (health <= 0)
        {
            player.zombiesKilled += 1;
            Destroy(gameObject);
        }
    }
}
