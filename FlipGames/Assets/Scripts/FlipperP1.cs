using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperP1 : MonoBehaviour
{
    public float resPosition = 0f;
    public float pressedPostion = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;

    public string inputName;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    private void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPostion;
        }
        else
        {
            spring.targetPosition = resPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}