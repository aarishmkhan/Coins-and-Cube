
using UnityEngine;

public class trigger : MonoBehaviour
{
    public gamemanager gm;
    void OnTriggerEnter() {
        gm.Completelevel();
    }
}
