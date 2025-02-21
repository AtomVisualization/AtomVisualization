using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{

    public GameObject Original;
    public int timesCloned;

public void clone() {
    if (timesCloned >= 1) {
        return;
    }
    else {
        GameObject clone = Instantiate(Original);
        timesCloned = timesCloned +1;
    }
 }
}
