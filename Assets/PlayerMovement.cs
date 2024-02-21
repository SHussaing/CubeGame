using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float speed = 2000f;
    public float movement = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
            
        } 
        else if (Input.GetKey("a"))
        {
            rb.AddForce(speed * -1 * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, speed * -1 * Time.deltaTime);
            
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }

    }
}
