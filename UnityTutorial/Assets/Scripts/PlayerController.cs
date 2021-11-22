using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private float turnSpeed = 40.0f;

    public Camera mainCamera;
    public Camera POVCamera;
    public KeyCode keyCode;

    public float horizontalMovement;
    public float verticalMovement;
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal"  + inputID);
        verticalMovement = Input.GetAxis("Vertical" + inputID);
        //Move the vehicle forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalMovement);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalMovement);

        if(Input.GetKeyDown(keyCode))
        {
            mainCamera.enabled = !mainCamera.enabled;
            POVCamera.enabled = !POVCamera.enabled;
        }
    }
}
