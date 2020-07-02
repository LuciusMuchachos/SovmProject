using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
<<<<<<< HEAD
    public static int speed = 20;
    public static int speedRotation = 2;
    public static int jumpSpeed = 50000;
||||||| a0e02c1
    public static int speed = 30;
    public static int speedRotation = 2;
    public static int jumpSpeed = 50000;
=======
    public static int speed = 10;
<<<<<<< HEAD
    public static int jumpSpeed = 10;
>>>>>>> c0bf2f56e4450198f851abd5fdf3dfbe7930c2a9
||||||| c0bf2f5
    public static int jumpSpeed = 10;
=======
    public static int jumpSpeed = 100;
>>>>>>> origin/MaksikDurik
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
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.position += player.transform.right * speed *Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.position += player.transform.up * jumpSpeed * Time.deltaTime;
        }
    }
}