using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WheelRotation : MonoBehaviour
{
    [SerializeField] private bool rotateOnX = false;
    [SerializeField] private bool rotateOnY = false;
    [SerializeField] private float rotationWeelSpeedX = 1;
    [SerializeField] private float rotationWeelSpeedY = 1;
    [SerializeField] private float maxRotationWeelY = 40;
    private float rotationWeelY = 0;

    private Quaternion baseRotation;
    private Transform weel;

    private void Awake()
    {
        baseRotation = transform.rotation;
        weel = transform.GetChild(0).transform;
    }

    private void RotationWeelY()
    {
        float speedY = rotationWeelSpeedY * Time.deltaTime;
        if (Input.GetAxis("Horizontal") < 0) {
            if (rotationWeelY > 0) {
                rotationWeelY = 0;
            }
            if (rotationWeelY - rotationWeelSpeedY > -maxRotationWeelY) {
                rotationWeelY -= rotationWeelSpeedY;
                transform.Rotate(0, -rotationWeelSpeedY, 0, Space.Self);
            }
        } else if (Input.GetAxis("Horizontal") > 0) {
            if (rotationWeelY < 0) {
                rotationWeelY = 0;
            }
            if (rotationWeelY + rotationWeelSpeedY < maxRotationWeelY) {
                rotationWeelY += rotationWeelSpeedY;
                transform.Rotate(0, rotationWeelSpeedY, 0, Space.Self);
            }
        }
    }

    private void RotationWeelX()
    {
        float speedX = rotationWeelSpeedX;
        if (Input.GetAxis("Vertical") < 0) {
            weel.Rotate(speedX, 0, 0, Space.Self);
        } else if (Input.GetAxis("Vertical") > 0) {
            weel.Rotate(-speedX, 0, 0, Space.Self);
        }
    }

    private void Update()
    {
        if (rotateOnY && Input.GetAxis("Horizontal") != 0) {
            RotationWeelY();
        } else {
            transform.localRotation = new Quaternion(transform.localRotation.x, baseRotation.y, transform.localRotation.z, transform.localRotation.w);
        }
        if (rotateOnX && Input.GetAxis("Vertical") != 0) {
            RotationWeelX();
        }
    }
}
