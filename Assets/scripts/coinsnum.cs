using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsnum : MonoBehaviour
{
    
    
    private void OnTriggerEnter(Collider col){
        
            
            coins.thescore++;
            
            Destroy(gameObject);
        
            
            
        
    }
}
