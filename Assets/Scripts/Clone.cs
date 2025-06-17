using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{

    public GameObject Original;
    public int timesCloned;

public void clone() {
        //checks how many times the object your holding has been cloned and if it's more than one the it doesn't clone anymore
    if (timesCloned >= 1) {
        return;
    }
    else {
            //clones the electron 
        GameObject clone = Instantiate(Original);
        timesCloned = timesCloned +1;
    }
 }
}
