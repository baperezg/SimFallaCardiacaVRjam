using System.Threading.Tasks;
using UnityEngine;
using System;


public class Personaje : MonoBehaviour
{
    Animator anim;
    
    GameObject playerObject;
    public bool lookat=true;

    void Awake() 
    {
        anim = gameObject.GetComponent<Animator>();
        playerObject = GameObject.Find("CenterEyeAnchor");
    }

    // Update is called once per frame
    void Update()
    {
        if(lookat)
        {
            gameObject.transform.LookAt(playerObject.transform, Vector3.zero);
            transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);
        }
    }

    public void PlayFootstepSound()
    {
        GetComponent<AudioSource>().Play();
    }

    public void StopFootstepSound()
    {
        GetComponent<AudioSource>().Stop();
    }
    
    public int PlayAnimation(object animationName)
    {
        print("playing... "+ animationName);

        int delay = 0;
        
        switch (animationName)
        {
            case "acostarse":
                anim.SetBool("acostarse", true);
                anim.SetBool("idle", false);
                break;
            case "sentarse":
                anim.SetBool("sentarse", true);
                anim.SetBool("saludar", false);
                break;                  
            case "saludar":
                anim.SetBool("saludar", true);
                anim.SetBool("sentarse", false);
                break;
            case "idle":
                //Poner las animaciones en false
                // pueden crear su propio sistema también
                anim.SetBool("sentarse", false);
                anim.SetBool("saludar", false);
                anim.SetBool("acostarse", false);
                delay = 500;
                break;
        }

        if(animationName.ToString() != "Idle")
        {
            //delay = (int.Parse(""+ Convert.ToInt32(anim.GetCurrentAnimatorClipInfo(0)[0].clip.length*1000)));
            delay = (int.Parse(""+ Convert.ToInt32(DarTiempoClip(animationName.ToString())*1000)));
            anim.SetBool("idle", true);
        }
        
        return delay;
    }

    public float DarTiempoClip(string clipName)
    {
        float delay = 0;
        switch (clipName)
        {
            case "acostarse":
                delay = 1f;
                break;
            case "sentarse":
                delay = 1f;
                break;

            case "saludar":
                delay = 2.5f;
                break;

            case "Idle":
                delay = 1;
                break;
        }

        return delay;
    }
    

    public void MirarJugador(object mirar)
    {
        if(mirar.ToString()=="true")
        {
             lookat=true;
        } 
        else 
        {
            lookat=false;
        }
    }
}
