using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{
    
    public GameObject scoretext;
    public static int thescore;
    
    
    void Update(){
        
            scoretext.GetComponent<Text>().text= thescore.ToString();
            
        
    }
}
