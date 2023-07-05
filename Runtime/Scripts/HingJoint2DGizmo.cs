using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vertx.Debugging;

#if UNITY_EDITOR
[RequireComponent(typeof(HingeJoint2D))]
public class HingJoint2DGizmo : MonoBehaviour
{

	HingeJoint2D h2d = null;

	void OnDrawGizmosSelected()
	{
		if (h2d == null) h2d = GetComponent<HingeJoint2D>();

		//Draw Anchor
		var localMatrix = transform.worldToLocalMatrix;
		var anchorLocal = h2d.anchor;
		var anchorWorld = localMatrix.MultiplyPoint(anchorLocal);
		D.raw(new Shape.Circle2D(anchorWorld, 0.1f), Color.blue);
		D.raw(new Shape.Circle2D(anchorWorld, 0.06f), Color.blue);
		D.raw(new Shape.Circle2D(anchorWorld, 0.04f), Color.blue);
		D.raw(new Shape.Circle2D(anchorWorld, 0.02f), Color.blue);
		D.raw(new Shape.Point2D(anchorWorld), Color.blue);

		//Draw ConnectedAnchor
		var connectRigidMatrix = Matrix4x4.identity;
		if (h2d.connectedBody != null) connectRigidMatrix = h2d.connectedBody.transform.worldToLocalMatrix;
		var cAnchorLocal = h2d.connectedAnchor;
		var cAnchorWorld = connectRigidMatrix.MultiplyPoint(cAnchorLocal);
		D.raw(new Shape.Circle2D(cAnchorWorld, 0.1f), Color.red);
		D.raw(new Shape.Circle2D(cAnchorWorld, 0.06f), Color.red);
		D.raw(new Shape.Circle2D(cAnchorWorld, 0.04f), Color.red);
		D.raw(new Shape.Circle2D(cAnchorWorld, 0.02f), Color.red);
		D.raw(new Shape.Point2D(cAnchorWorld), Color.red);


		//Draw Line
		D.raw(new Shape.Linecast2D(transform.position, anchorWorld, null), Color.blue);

		//Draw Arc
		D.raw(new Shape.Arc2D(anchorWorld, 0f, 1f, Shape.Angle.FromDegrees(100)), Color.blue);
	}
}
#endif