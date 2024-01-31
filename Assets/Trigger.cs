using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotTrigger : MonoBehaviour
{

    public int points;
    public int slotNumber;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log($"{other.name} entered slot {name}");
        Debug.Log($"Entered slot {slotNumber} an got {points} points");
    }
}
