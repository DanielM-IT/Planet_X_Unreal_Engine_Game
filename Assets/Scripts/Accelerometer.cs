using UnityEngine;
using UnityEngine.UI;

public class Accelerometer : MonoBehaviour
{
    public Toggle toggleBox;
    float movementSpeed = 20f;
    Transform target;
    float speed;


    void Update()
    {
        if (toggleBox.GetComponent<Toggle>().isOn == true)
        {
            Vector3 direction = Vector3.zero;

            // we assume that device is held parallel to the ground
            // and Home button is in the right hand

            // remap device acceleration axis to game coordinates:
            //  1) XY plane of the device is mapped onto XZ plane
            //  2) rotated 90 degrees around Y axis
            direction.x = -Input.acceleration.y;
            direction.z = Input.acceleration.x;

            // clamp acceleration vector to unit sphere
            if (direction.sqrMagnitude > 1)
                direction.Normalize();

            // Make it move 20 meters per second instead of 10 meters per frame...
            direction *= Time.deltaTime;

            // Move object
            transform.Translate(direction * movementSpeed);
        }
    }
}
