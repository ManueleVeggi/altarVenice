using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController_Visitor : MonoBehaviour

{
    // The Character Controller component, used to move in the 3D environment
    // the player
    public CharacterController visitorCharacterController;
    // The Animator used to change animation while moving
    // public Animator visitorAnimator;
    // The default speed, used to define the magnitude of the movement of the
    // player while it is moving into the map
    public float visitorMovingSpeed = 1;
    // The default speed, used to define the magnitude of the rotation of the
    // player while it is moving into the map
    public float visitorRotatingSpeed = 1;
    // A flag used to know is the character was moving the loop before. This is
    // mainly used to trigger an animation change
    private bool isMoving = false;
    // The tolerance used to define if a character is moving or not (the
    // direction is not important)
    private float toleranceMovement = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    // Responsible for the movement of the character
    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal"),
            vertical = Input.GetAxis("Vertical"),
            currentSpeed = visitorMovingSpeed * vertical;
        Vector3 forward = new Vector3();
        transform.Rotate(0, horizontal * visitorRotatingSpeed, 0);
        forward = transform.TransformDirection(Vector3.forward);
        // if (vertical > toleranceMovement)
        // {
        //     /* moving forward */
        //     if (!isMoving)
        //     {
        //         Debug.Log("Forwards");
        //         visitorAnimator.ResetTrigger("stopWalking");
        //         visitorAnimator.ResetTrigger("startWalkingBackward");
        //         visitorAnimator.SetTrigger("startWalkingForward");
        //         isMoving = true;
        //     }

        // } else if (vertical < (toleranceMovement * -1.0f))
        // {
        //     /* moving backwards */
        //     if (!isMoving)
        //     {
        //         Debug.Log("Backwards");
        //         visitorAnimator.ResetTrigger("stopWalking");
        //         visitorAnimator.ResetTrigger("startWalkingForward");
        //         visitorAnimator.SetTrigger("startWalkingBackward");
        //         isMoving = true;
        //     }
        // } else
        // {
        //     /* not moving */
        //     if (isMoving)
        //     {
        //         Debug.Log("Stopped");
        //         visitorAnimator.ResetTrigger("startWalkingForward");
        //         visitorAnimator.ResetTrigger("startWalkingBackward");
        //         visitorAnimator.SetTrigger("stopWalking");
        //         isMoving = false;
        //     }

        // }
        visitorCharacterController.SimpleMove(forward * currentSpeed);
    }
}


