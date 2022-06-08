using UnityEngine;

public class cantroller : MonoBehaviour
{
    public Rigidbody rb;
    public Joystick joystick;
    
    public float speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        joystick.transform.position= new Vector3(130+(Screen.width-260)*PlayerPrefs.GetFloat("HPos", 0),130+(Screen.height-260)*PlayerPrefs.GetFloat("VPos", 0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (Input.GetKey("w") | joystick.Vertical > 0.2f)
        {
            rb.AddForce(0, 0, speed * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("s") | joystick.Vertical < -0.2f)
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") | joystick.Horizontal < -0.2f)
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d") | joystick.Horizontal > 0.2f)
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < 0.3)
        {
          FindObjectOfType<GameManager>().EndGame();
        }
       
    }
    public void forward() {
        rb.AddForce(0, 0, speed * Time.deltaTime, ForceMode.VelocityChange);
    }
    public void backward() { rb.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.VelocityChange); }
    public void right()
    {
        rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void left()
    {
        rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
