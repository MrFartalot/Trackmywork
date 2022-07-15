using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour       //stays public bcs of the reference in unity
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()       //method makes the camera wait for the car to move and then moves, bcs of this there is no stuttering
    {
        //Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
