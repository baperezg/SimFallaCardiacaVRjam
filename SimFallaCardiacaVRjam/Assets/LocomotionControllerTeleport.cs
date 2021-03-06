using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionControllerTeleport : MonoBehaviour
{
    public XRController rightTeleportRay;
    public XRController leftTeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
        leftTeleportRay.gameObject.SetActive(CheckIfActivated(leftTeleportRay));
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
