using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
   

	private float rotationSpeed = 50.0f;
	private float maxLeftAngle = 85.0f;
	private float maxRightAngle = 275.0f;
	

	void Update () {
	
		float mouseAxisX = Input.GetAxis("Horizontal");
		transform.Rotate(Vector3.back * mouseAxisX * this.rotationSpeed * Time.deltaTime);
		if (transform.eulerAngles.z > this.maxLeftAngle && transform.eulerAngles.z < 180.0 ){
			transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y, maxLeftAngle);
		}
		if (transform.eulerAngles.z < this.maxRightAngle && transform.eulerAngles.z > 180.0 ){
			transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y, maxRightAngle);
		}

	}
}
