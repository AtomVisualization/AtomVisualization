using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibrate : MonoBehaviour
{
    public float duration;
    public float amplitude;
    public float frequency;

    public void Trigger(OVRInput.Controller controller)
    {
        OVRInput.SetControllerVibration(frequency, amplitude, controller);

        StartCoroutine(Routine(controller));
    }

    public IEnumerator Routine(OVRInput.Controller controller)
    {
        OVRInput.SetControllerVibration(frequency, amplitude, controller);
        yield return new WaitForSeconds(duration);
        OVRInput.SetControllerVibration(0, 0, controller);
    }

}
