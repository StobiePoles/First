using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grappleHook : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrapple;
    public Transform gunTip, camera, player;
    private float maxDistance = 200f;
    private SpringJoint joint;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        DrawRope();


        if(Input.GetMouseButtonDown(1))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonUp(1))
        {
            StopGrapple();
        }
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

            joint.maxDistance = distanceFromPoint * 0.8f;
            joint.minDistance = distanceFromPoint * 0.25f;


            joint.spring = 35f;
            joint.damper = 7f;
            joint.massScale = 0.5f;

            lr.positionCount = 2;

        }
    }
    void DrawRope()
    {
        if (!joint) return;
        lr.SetPosition(0,gunTip.position);
        lr.SetPosition(1,grapplePoint);
    }

    void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }


}
