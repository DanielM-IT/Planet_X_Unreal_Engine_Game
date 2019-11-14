using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Gets the animator and rigidbody game objects and creates a variable for each to store each user command in so it can be sent to and used by the came object.
    //Animator survivalCharacter;
    public GameObject theCharacter;
    Rigidbody characterRB;
    public ConstantForce gravity;

    void Start()
    {
        //survivalCharacter = GetComponent<Animator>();
        characterRB = GetComponent<Rigidbody>();
        gravity = gameObject.AddComponent<ConstantForce>();
        gravity.force = new Vector3(0.0f, -9.81f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("UpKey") || Input.GetButtonDown("LeftKey") || Input.GetButtonDown("DownKey") || Input.GetButtonDown("RightKey"))
        {
            theCharacter.GetComponent<Animator>().Play("Run");
        }
        else if (Input.GetButtonUp("UpKey") || Input.GetButtonUp("LeftKey") || Input.GetButtonUp("DownKey") || Input.GetButtonUp("RightKey"))
        {
            theCharacter.GetComponent<Animator>().Play("Idle");
        }
    }


    private void FixedUpdate()
    {
        // Move and face character forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            characterRB.AddForce(new Vector3(0, 0, -8), ForceMode.VelocityChange);
            characterRB.rotation = Quaternion.LookRotation(Vector3.back);

        }

        // Move and face character backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            characterRB.AddForce(new Vector3(0, 0, 8), ForceMode.VelocityChange);
            characterRB.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        // Move and face character left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            characterRB.AddForce(new Vector3(8, 0, 0), ForceMode.VelocityChange);
            characterRB.rotation = Quaternion.LookRotation(Vector3.right);

        }

        // Move and face character right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            characterRB.AddForce(new Vector3(-8, 0, 0), ForceMode.VelocityChange);
            characterRB.rotation = Quaternion.LookRotation(Vector3.left);
        }
    }

}
