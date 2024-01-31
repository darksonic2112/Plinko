using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballspawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnTransform;

    

    // Start is called before the first frame update
    void Start()
    {
 
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 spawnPosition = spawnTransform.position;
            int randomNumber = Random.Range(1, 14);
            spawnPosition.z = randomNumber;
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        }
    }

}
