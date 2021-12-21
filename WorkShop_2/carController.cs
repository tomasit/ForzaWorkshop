using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class AxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public Transform rotationleft; //no collider juste mesh
    public Transform rotationright; //no collider juste mesh
    public bool motor;
    public bool steering;
}


public class carController : MonoBehaviour
{
    [Header("CarController")]
    public List<AxleInfo> axleInfos; 
    public float maxMotorTorque;
    public float maxSteeringAngle;
    public float AntiRoll;
    [SerializeField] private float speed = 10;

    [Header("Speed")]
    public float actualSpeed;

    public AudioSource audioSound;
    private int [] gearSpeed;
    private float CurrentSpeed = 0.0f;
    private int currentGear = 0;


    public void Start()
    {
        GetComponent<Rigidbody>().centerOfMass += new Vector3(0, 0, 1.0f);

        AntiRoll = 5000.0f;
        actualSpeed = 0.0f;
    }
     
    public void ApplyLocalPositionToVisuals(WheelCollider collider)
    {
        if (collider.transform.childCount == 0)
            return;
     
        Transform visualWheel = collider.transform.GetChild(0);
     
        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);
     
        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }
     
    public void FixedUpdate()
    {
        float motor = maxMotorTorque * (-Input.GetAxis("Vertical"));
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        WheelHit hit;
        float travelL = 1.0f;
        float travelR = 1.0f;

        bool firstWheels = false;
        float rotationX = 0f;
        float rotationY = 0f;
     
        foreach (AxleInfo axleInfo in axleInfos) 
        {
            
            //Rotation movement
            if (axleInfo.steering) {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor) {
                axleInfo.leftWheel.motorTorque = speed * -Input.GetAxis("Vertical") * 500 * Time.deltaTime;
                axleInfo.rightWheel.motorTorque = speed * -Input.GetAxis("Vertical") * 500 * Time.deltaTime;
            }
        }
        actualSpeed = motor;
    }
}