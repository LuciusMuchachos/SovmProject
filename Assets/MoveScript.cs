using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public static int speed = 30;
    public static int speedRotation = 2;
    public static int jumpSpeed = 50000;
    void Start()
    {
        player = (GameObject)this.gameObject;
    }
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
            player.transform.Rotate(Vector3.down * speedRotation);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.position += player.transform.right * speed *Time.deltaTime;
            player.transform.Rotate(Vector3.up * speedRotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.position += player.transform.up * jumpSpeed * Time.deltaTime;
        }
    }
}