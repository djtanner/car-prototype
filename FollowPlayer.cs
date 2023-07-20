using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private bool keySwitch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        
        //Switch camera views on spacebar press
       
        if (Input.GetKeyDown(KeyCode.Space)) {
            keySwitch = !keySwitch;
            
        }

        if (keySwitch) { offset = new Vector3(0, 5, 0); }
        else { offset = new Vector3(0, 5, -7); }

        transform.position = player.transform.position + offset;


    }





}
