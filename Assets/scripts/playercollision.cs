using UnityEngine;

public class playercollision : MonoBehaviour
{
    
    public movement move;
    
    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "obstacle"){
            move.enabled = false;
            FindObjectOfType<gamemanager>().endgame();
            
        }
    }
}
