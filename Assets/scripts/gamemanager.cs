using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
 
    public float delay = 2f;
    
    public GameObject completelevelUI;
    public void Completelevel(){
        completelevelUI.SetActive(true);
    }
    bool gameended = false;
    public void endgame(){
        if (gameended == false){

             gameended = true;
             Debug.Log("CHI");
             Invoke("Restart", delay);
             

        }
       
    }
    void Restart (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
