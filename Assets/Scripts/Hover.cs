using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Haptics;

public class Hover : MonoBehaviour
{

    [SerializeField] private HapticClip clip1;
    private HapticClipPlayer leftClipPlayer1;
    private HapticClipPlayer rightClipPlayer1;

    private void Start()
    {
        // We create two haptic clip players for each hand.
        leftClipPlayer1 = new HapticClipPlayer(clip1);
        rightClipPlayer1 = new HapticClipPlayer(clip1);
  


    }

   
    public void control(Controller hand)
    {
        switch (hand)
        {
            case Controller.Right:
                rightClipPlayer1.Play(Controller.Right);
                return;
            case Controller.Left:
                leftClipPlayer1.Play(Controller.Left);
                return;
            default:
                return;
        }
        
    }
}
