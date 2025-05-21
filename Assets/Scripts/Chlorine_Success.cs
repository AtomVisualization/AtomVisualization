using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chlorine_Success : MonoBehaviour
{

    private float count;
    public float timeTakenDuringLerp = 1f;
    public float distanceToMove = 1;
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private float _timeStartedLerping;
    private bool _islerping;
    private bool done = false;


    // Update is called once per frame
    void Update()
    {
        Invoke("check2", 1);
    }

    void check2()
    {
        count = Detection2.count;

        if (count >= 3)
        {
            StartLerping();
        }
    }


    void StartLerping()
    {
        if (done == false)
        {
            _islerping = true;
            _timeStartedLerping = Time.time;

            _startPosition = transform.position;
            _endPosition = transform.position + new Vector3(0, -.15f, -.25f);
            done = true;
            if (this.tag == "water" || this.tag == "Chlorine")
            {
                Invoke("del", 1.2f);
            }
           
        }
    }

    void FixedUpdate()
    {
        if (this.tag == "water" || this.tag == "Chlorine")
        {
            if (_islerping)
            {
                float timeSinceStarted = Time.time - _timeStartedLerping;
                float percentageComplete = timeSinceStarted / timeTakenDuringLerp;
                transform.position = Vector3.Lerp(_startPosition, _endPosition, percentageComplete);
                if (percentageComplete >= 1.0f)
                {
                    _islerping = false;
                }
            }

        }


    }

    void del()
    {
        Destroy(gameObject);
    }

            
    }

    




