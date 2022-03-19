using UnityEngine;

public class movement : MonoBehaviour
{
    
    public Rigidbody rb;

    public float forwardForce=1000f;
    public float sideforce=300f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<gamemanager>().endgame();
        }
    }
}
