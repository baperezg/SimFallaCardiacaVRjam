using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auscultacion : MonoBehaviour
{
    static AudioSource audioSource;
    public static AudioClip heartnormal, heartregur;

    public bool ausc = false;


    void Awake()
    {
        heartnormal = Resources.Load<AudioClip>("heartnormal");
        heartregur = Resources.Load<AudioClip>("heartmitralregurgitation");

        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        //if (!ausc && other.tag == "IndexFinger")
        if (!ausc && other.CompareTag("Estetoscopio"))
        {
            CorazonNormal();
            ausc = true;
            //GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "Touched", ""));
        }
        else
        {
            ausc = false;
        }
    }

    public void ReiniciarBtn()
    {
        audioSource = GetComponent<AudioSource>(); 
        ausc = false;        
    }

    public void CorazonNormal()
    {
        
        audioSource.clip = heartnormal;
        audioSource.Play();

    }

    public void Corazonregurg()
    {

        audioSource.clip = heartregur;
        audioSource.Play();

    }
}
