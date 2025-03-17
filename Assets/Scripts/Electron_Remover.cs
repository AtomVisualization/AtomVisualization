using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Electron_Remover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone has the tag "Electron"
        if (other.CompareTag("Electron") || other.CompareTag("Hydrogen"))
        {
            // Print a message to the console for debugging
            Debug.Log("Electron entered the trigger zone!");

            // Destroy the game object with the "Electron" tag
            Destroy(other.gameObject);
        }
    }
}
