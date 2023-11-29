
using UnityEngine;

public class Hearts : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision object has an Enemy component
        ClickToMove player = collision.collider.GetComponent<ClickToMove>();
        if (player != null)
        {
            Destroy(gameObject);
            player.health += 5;
            player.heartsCollected += 1;
            Debug.Log("hearts collected: " + player.heartsCollected);
        }
    }
}
