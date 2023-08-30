using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
    [Header("Wheels collider")]
    public WheelCollider frontRightWheelCollider;
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider backRightWheelCollider;
    public WheelCollider backLeftWheelCollider;

    [Header("Wheels transform")]
    public Transform frontRightWheelTransform;
    public Transform frontLeftWheelTransform;
    public Transform backRightWheelTransform;
    public Transform backLeftWheelTransform;

    [Header("Car engine")]
    public float accelerationForce = 300f;
    public float brakingForce = 3000f;
    private float presentBrakeForce = 0f;
    private float presentAcceleration = 0f;


    private void Update() {
        MoveCar();
    }

    private void MoveCar() {
        frontLeftWheelCollider.motorTorque = presentAcceleration;
        frontRightWheelCollider.motorTorque = presentAcceleration;
        presentAcceleration = accelerationForce * Input.GetAxis("Vertical");

    }


}
