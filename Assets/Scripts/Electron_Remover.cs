using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Electron_Remover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // checks for electrons and specific molecules
        if (other.CompareTag("Electron") || other.CompareTag("Hydrogen") || other.CompareTag("Carbon") || other.CompareTag("Sodium") || other.CompareTag("Chlorine") || other.CompareTag("Oxygen"))
        {

            Debug.Log("Electron entered the trigger zone!");
            // deletes them when they enter the trash area 
       
            Destroy(other.gameObject);

            
        }
    }
}
