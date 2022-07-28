using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grappleHook : MonoBehaviour
{

    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrapple;
    public Transform gunTip, camera, player;
    private float maxDistance = 100f;
    private SpringJoint joint;


    public Image green;
    public Image red;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }


    private void Start()
    {
        red.enabled = true;
        green.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {



        RaycastHit hit;
        if (Physics.Raycast(camera.position, camera.forward, out hit, maxDistance, whatIsGrapple))
        {

            green.enabled = true;
            red.enabled = false;


        }
        else if (!Physics.Raycast(camera.position, camera.forward, out hit, maxDistance, whatIsGrapple))
        {

            red.enabled = true;
            green.enabled = false;

        }

        if (Input.GetMouseButtonDown(1))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonUp(1))
        {
            StopGrapple();
        }




        if (PlayerMovement.WantToStopHook == true)
        {
            StopGrapple();
        }

    }
    private void LateUpdate()
    {
        DrawRope();
    }
    void StartGrapple()
    {   
        RaycastHit hit;
        if(Physics.Raycast(camera.position,camera.forward, out hit, maxDistance, whatIsGrapple))
        {
            grapplePoint = hit.point;
            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            float distanceFromPoint = Vector3.Distance(player.position, grapplePoint);

            joint.maxDistance = distanceFromPoint * 0.5f;
            joint.minDistance = distanceFromPoint * 0.25f;


            joint.spring = 3f;
            joint.damper = 4f;
            joint.massScale = 0.5f;

            lr.positionCount = 2;
           // PlayerMovement.grounded = true; try and add a grounded affect when hit grapple
        }
    }
    void DrawRope()
    {
        if (!joint) return;
        lr.SetPosition(0,gunTip.position);
        lr.SetPosition(1,grapplePoint);
    }

    public void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }


}
