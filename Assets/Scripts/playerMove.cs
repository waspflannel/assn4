using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI;


public class ClickToMove : MonoBehaviour
{
    public Camera cam; 
    public NavMeshAgent agent; 


    public int heartsCollected;
    public int zombiesKilled;
    public int damage;
    public int health;

    public int coinCount;

    private void Awake()
    {
        heartsCollected = 0;
        zombiesKilled = 0;
        damage = 2;
        health = 10;
    }
    void Update()
    {
        move();

        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
         
                agent.SetDestination(hit.point);
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.health -= damage; 
            health -= enemy.damage;
            //Debug.Log("Player health: " + health);
            //Debug.Log("Zombies Slain: " + zombiesKilled);

        }

    }
}

