using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private float speed = 20;
    private float xRange = 20;

    public float horizontalInput;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x < -xRange){
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);

        }else if (transform.position.x > xRange){
             transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }

        // * horizontalInput because that will tell the direction, deltaTime is used so it updates every over time not every frame, speed
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Checking if Space Bar is pressed down
        if (Input.GetKeyDown(KeyCode.Space)){
            // Launch projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }
        

    }
}
