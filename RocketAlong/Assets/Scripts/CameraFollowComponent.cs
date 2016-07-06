using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraFollowComponent : MonoBehaviour
{
    public GameObject Target = null;
    public Vector3 FollowOffset = Vector3.zero;
    public bool IgnoreX = false;
    public bool IgnoreY = false;
    public bool IgnoreZ = false;

    private Vector3 ZOffset = Vector3.zero;

	// Use this for initialization
	void Start()
    {
        ZOffset = new Vector3(0f, 0f, transform.position.z);
	    if(Target != null)
        {
            transform.position = GetTargetPosition() - FollowOffset + ZOffset;
        }
	}
	
	// Update is called once per frame
	void LateUpdate()
    {
        if(Target != null)
        {
            transform.position = GetTargetPosition() - FollowOffset + ZOffset;
        }
	}

    Vector3 GetTargetPosition()
    {
        Vector3 position = Target.transform.position;

        if(IgnoreX)
        {
            position.x = transform.position.x;
        }

        if(IgnoreY)
        {
            position.y = transform.position.y;
        }

        if(IgnoreZ)
        {
            position.z = transform.position.z;
        }

        return position;
    }

    public static Bounds GetCameraBounds()
    {
        Vector3 cameraBoundSize = new Vector3();
        cameraBoundSize.x = Camera.main.orthographicSize;
        cameraBoundSize.y = cameraBoundSize.x * (Screen.width / Screen.height);

        Bounds cameraBounds = new Bounds(Camera.main.transform.position, cameraBoundSize);

        return cameraBounds;
    }
}
