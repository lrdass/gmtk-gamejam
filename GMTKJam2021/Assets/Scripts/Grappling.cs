using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappling : MonoBehaviour
{
    public Transform leaf;
    public LineRenderer _lineRenderer;
    public SpringJoint2D _SpringJoint;

    // Start is called before the first frame update
    void Start()
    {
        _SpringJoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = leaf.position;
            _lineRenderer.SetPosition(0, mousePos);
            _lineRenderer.SetPosition(1, transform.position);
            _SpringJoint.connectedAnchor = mousePos;
            _SpringJoint.enabled = true;
            _lineRenderer.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _SpringJoint.enabled = false;
            _lineRenderer.enabled = false;
        }
        if (_SpringJoint.enabled)
        {
            _lineRenderer.SetPosition(1, transform.position);
        }
    }
}
