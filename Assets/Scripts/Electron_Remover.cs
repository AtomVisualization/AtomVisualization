using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Electron_Remover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Electron") || other.CompareTag("Hydrogen") || other.CompareTag("Carbon") || other.CompareTag("Sodium") || other.CompareTag("Chlorine") || other.CompareTag("Oxygen"))
        {

            Debug.Log("Electron entered the trigger zone!");

       
            Destroy(other.gameObject);

            
        }
    }
}
