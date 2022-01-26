using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public float xRang1 = 33;
    public float xRang2 = 31;
    public float zRang1 = 14.2f;
    public float zRang2 = 16.2f;
    public Joystick myJoystick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.x < -xRang2)
        {
            transform.position = new Vector3(-xRang2, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRang1)
        {
            transform.position = new Vector3(xRang1, transform.position.y, transform.position.z);
        }
        horizontalInput = myJoystick.Horizontal;

        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed * horizontalInput);

        if (transform.position.z < -zRang1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRang1);
        }
        else if (transform.position.z > zRang2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRang2);
        }
        verticalInput = myJoystick.Vertical;

        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed * verticalInput);

    }
}