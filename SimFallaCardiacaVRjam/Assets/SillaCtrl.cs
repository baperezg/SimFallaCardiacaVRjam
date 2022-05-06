using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SillaCtrl : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public int PlayAnimation(string name)
    {
        if (name == "sillaadelante")
        {
            anim.SetBool("sillaadelante", true);
            anim.SetBool("sillaatras", false);
        }
        else if (name == "sillaatras")
        {
            anim.SetBool("sillaatras", true);
            anim.SetBool("sillaadelante", false);
        }

        return 1000;
    }


}


