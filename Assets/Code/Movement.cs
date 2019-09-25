using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jump;
    public float camera;
    public Camera cam;
    public Rigidbody body;
    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            move = new Vector3 (0f,0f, speed);
            transform.Translate(move);
        }
        if (Input.GetKey(KeyCode.S))
        {
            move = new Vector3(0f, 0f, -speed);
            transform.Translate(move);
        }
        if (Input.GetKey(KeyCode.D))
        {
            move = new Vector3(speed, 0f, 0f);
            transform.Translate(move);
        }
        if (Input.GetKey(KeyCode.A))
        {
            move = new Vector3(-speed, 0f, 0f);
            transform.Translate(move);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move = new Vector3(0f, jump, 0f);
            body.AddForce(move);
            //transform.Translate(move);
        }
        if (Input.GetKey(KeyCode.RightBracket) || Input.GetKey(KeyCode.RightArrow))
        {
            move = new Vector3(0f, camera, 0f);
            transform.Rotate(move);
        }
        if (Input.GetKey(KeyCode.LeftBracket) || Input.GetKey(KeyCode.LeftArrow))
        {
            move = new Vector3(0f, -camera, 0f);
            transform.Rotate(move);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move = new Vector3(camera,0f, 0f);
            cam.transform.Rotate(move);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move = new Vector3(-camera, 0f, 0f);
            cam.transform.Rotate(move);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            move = new Vector3(0f, -jump, 0f);
            body.AddForce(move);
        }
    }
}
