using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using System.Collections;

public class UserMoveComponent : MonoBehaviour
{
    public float SpeedMinimum = 1f;
    public float SpeedMaximum = 5f;
    public float Drag = 0.5f;
    public float TapBoost = 1f;

    public Vector3 Direction = Vector3.right;

    public GUIUpdateText SpeedDisplay = null;
    public float Speed = 1f;
	// Use this for initialization
	void Start()
    {
	}
	
	// Update is called once per frame
	void Update()
    {
        Speed -= Drag * Time.deltaTime;

        if(Input.GetButtonDown("Tap"))
        {
            Speed += TapBoost * Time.deltaTime;
        }

        Speed = Mathf.Min(Speed, SpeedMaximum);
        Speed = Mathf.Max(Speed, SpeedMinimum);

        Vector3 movementVector = Direction * (Speed * Time.deltaTime);

        gameObject.transform.position += movementVector;

        if(SpeedDisplay != null)
        {
            SpeedDisplay.TextUpdate(Speed);
        }
	}
}
