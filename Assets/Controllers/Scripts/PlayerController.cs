using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator survivalCharacter;
    Rigidbody characterRB;

    void Start()
    {
        survivalCharacter = GetComponent<Animator>();
        characterRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Walk character animation
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Animate walk
            survivalCharacter.SetBool("Walk", true);
            survivalCharacter.SetBool("Stop", false);
        }

        // Stop character animation
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            survivalCharacter.SetBool("Stop", true);
            survivalCharacter.SetBool("Walk", false);
        }
    }


    private void FixedUpdate()
    {


        // Move character forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            characterRB.AddForce(new Vector3(0, 0, -8), ForceMode.VelocityChange);
            characterRB.rotation = Quaternion.LookRotation(Vector3.back);

        }

        // Move character backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            characterRB.AddForce(new Vector3(0, 0, 8), ForceMode.VelocityChange);
            characterRB.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        // Move character left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            characterRB.AddForce(new Vector3(8, 0, 0), ForceMode.VelocityChange);
            characterRB.rotation = Quaternion.LookRotation(Vector3.right);

        }

        // Move character right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            characterRB.AddForce(new Vector3(-8, 0, 0), ForceMode.VelocityChange);
            characterRB.rotation = Quaternion.LookRotation(Vector3.left);

        }
    }

}
