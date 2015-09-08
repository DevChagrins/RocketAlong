using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraFollowComponent : MonoBehaviour
{
    public GameObject Target = null;
    public Vector3 FollowOffset = Vector3.zero;

    private Vector3 ZOffset = Vector3.zero;

	// Use this for initialization
	void Start()
    {
        ZOffset = new Vector3(0f, 0f, transform.position.z);
	    if(Target != null)
        {
            transform.position = Target.transform.position - FollowOffset + ZOffset;
        }
	}
	
	// Update is called once per frame
	void LateUpdate()
    {
        if (Target != null)
        {
            transform.position = Target.transform.position - FollowOffset + ZOffset;
        }
	}
}
