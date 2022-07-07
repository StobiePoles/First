using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRunning : MonoBehaviour
{
    public string Side;




    [SerializeField] private float _wallRunUpForce;
    [SerializeField] private float _wallRunPushForce;
    //<<Summary>> Boolean that is used for adding forces when jumping off the walls, used to determine which direction.
    private bool isRightWall;
    private bool isLeftWall;

    //Used for effects etc.
    public static bool isWallRunning;
    //<<Summary>> Checks the distance from walls and takes the wall that is the closest to the player
    private float distanceFromLeftWall;
    private float distanceFromRightWall;

    //Used to add forces.
    private Rigidbody rb;
    public Transform cam;
    public Transform head;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void wallChecker()
    {
        RaycastHit rightRaycast;
        RaycastHit leftRaycast;

        if (Physics.Raycast(head.transform.position, head.transform.right, out rightRaycast, 1))
        {
            distanceFromRightWall = Vector3.Distance(head.transform.position, rightRaycast.point);
            if (distanceFromRightWall <= 10f)
            {
                isRightWall = true;
                isLeftWall = false;

            }
            else
            {
                isRightWall = false;
                PlayerMovement.WallRunSide = 3;
            }
        }
        else if (Physics.Raycast(head.transform.position, -head.transform.right, out leftRaycast, 1))
        {
            distanceFromLeftWall = Vector3.Distance(head.transform.position, leftRaycast.point);
            if (distanceFromLeftWall <= 10f)
            {
                isRightWall = false;
                isLeftWall = true;
            }
            else
            {
                isLeftWall = false;
                PlayerMovement.WallRunSide = 3;
            }
        }
        else
        {
            isRightWall = false;
            isLeftWall = false;
            PlayerMovement.WallRunSide = 3;
        }
    }

    private void Update()
    {
        wallChecker();

        if (isRightWall)
        {
            PlayerMovement.WallRunSide = 1;
        }
        else if (isLeftWall)
        {
            PlayerMovement.WallRunSide = 2;
        }
        else
        {
            PlayerMovement.WallRunSide = 3;

        }

    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("RunnableWall")|| collision.transform.CompareTag("RunnableWall2"))
        {
            isWallRunning = true;
            rb.useGravity = false;

        }
       /* if (collision.transform.CompareTag("RunnableWall"))
        {
            Side = "left";
        }
        else if (collision.transform.CompareTag("RunnableWall2"))
        {
            Side = "right";
        }
       */

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("RunnableWall") || collision.transform.CompareTag("RunnableWall2"))
        {
            if (Input.GetKey(KeyCode.Space) && isLeftWall)
            {
                rb.AddForce(Vector3.up * _wallRunUpForce, ForceMode.Impulse);
                rb.AddForce(head.transform.right * _wallRunUpForce, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.Space) && isRightWall)
            {
                rb.AddForce(Vector3.up * _wallRunUpForce, ForceMode.Impulse);
                rb.AddForce(-head.transform.right * _wallRunUpForce, ForceMode.Impulse);
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {

        if (collision.transform.CompareTag("RunnableWall") || collision.transform.CompareTag("RunnableWall2"))
        {
            //cam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
            isWallRunning = false;
            rb.useGravity = true;


        }
    }
}