
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}



