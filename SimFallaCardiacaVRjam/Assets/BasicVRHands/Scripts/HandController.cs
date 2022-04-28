using UnityEngine;
using UnityEngine.XR;
using System.Collections;
using System.Collections.Generic;


public class HandController : MonoBehaviour {

    private Animator animator;
	private InputDevice targetDevice;
	private List<InputDevice> devices;

	void Start () {
        animator = GetComponent<Animator>();
		devices = new List<InputDevice>();
		InputDevices.GetDevices(devices);

		foreach(var item in devices)
        {
			Debug.Log(item.name + item.characteristics);
			
        }
	}
	
	void Update () {
		targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
		//Debug.Log("Botón primario: "+primaryButtonValue);
		if (primaryButtonValue == true)
        {
			animator.SetBool("isGrabbing", true);
		}

		targetDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool gripButtonValue);
		if (gripButtonValue == true)
		{
			animator.SetBool("isGrabbing", true);
		}

		


		//animator.SetBool("isGrabbing", Input.GetKey(KeyCode.F));
	}
}
