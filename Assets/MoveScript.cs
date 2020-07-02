using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public int speed = 5;
    public int speedRotation = 3;
    public int jumpSpeed = 50;
    void Start()
    {
        player = (GameObject)this.gameObject;
    }
    /*private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            
        if (Input.GetKey(KeyCode.D))
            
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.up);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.down);

    }*/
    // Update is called once per frame
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.position += player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.position += player.transform.up * jumpSpeed * Time.deltaTime;
        }
    }
}