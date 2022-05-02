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

		//List<InputDevice> devices = new List<InputDevice>();
		//InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
		//InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

		//foreach (var item in devices)
		//{
		//	Debug.Log(item.name + item.characteristics);
		//}

		//if (devices.Count > 0)
		//{
		//	targetDevice = devices[0];
		//}
	}
	
	void Update () {
		//if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
		//	animator.SetBool("isGrabbing", true);
		//else
		//	animator.SetBool("isGrabbing", false);

		//if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
		//	animator.SetBool("isGrabbing", true);
		//else
		//	animator.SetBool("isGrabbing", false);

		//if (targetDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool gripButtonValue) && gripButtonValue)
		//	animator.SetBool("isGrabbing", true);
		//else
		//	animator.SetBool("isGrabbing", false);




		//animator.SetBool("isGrabbing", Input.GetKey(KeyCode.F));
	}
}
