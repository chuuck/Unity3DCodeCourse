using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    private float init_x, init_y, init_z;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        init_x = transform.position.x;
        init_y = transform.position.y;
        init_z = transform.position.z;
        
        offset = new Vector3(init_x, init_y, init_z);
    }

    // Update is called once per frame
    void LateUpdate()
    {


        //Offset the camera beheind the player by adding to the player's position
        transform.position = player.transform.position + new Vector3(init_x, init_y, init_z);

    }
}
