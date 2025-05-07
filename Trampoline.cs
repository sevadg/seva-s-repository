using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpForce = 9;
    public float defaultJump = 2;
    
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = jumpForce;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = defaultJump;
    }
}
