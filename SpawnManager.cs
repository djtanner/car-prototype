using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject truck;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("CloneTrucks", 2.0f, 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CloneTrucks() {


        int x = -6;

        int randomGen = Random.Range(0, 2);


        if(randomGen == 1) { x = 3; }


        Instantiate(truck, new Vector3(x, 0, 181), Quaternion.identity);

    }

}
