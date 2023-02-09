using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 200f;

    public GameObject credits;

    // Start is called before the first frame update
    void Start()
    {
        // credits.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ( Input.GetKey("w") )
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);

        }
        while(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
