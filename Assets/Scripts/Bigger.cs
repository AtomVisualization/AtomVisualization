using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigger : MonoBehaviour
{
    // Start is called before the first frame update
   public void enlarge()
    {
       transform.localScale = new Vector3(2f, 2f, 2f);
    }

    public void shrink()
    {
       transform.localScale = new Vector3(.3f, .3f, .3f);
    }
}
