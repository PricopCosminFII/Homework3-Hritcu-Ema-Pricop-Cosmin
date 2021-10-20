using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {if (Input.GetKey(KeyCode.LeftArrow))
            anim.SetBool("Waving1", true);
        else
            anim.SetBool("Waving1", false);

        if (Input.GetKey(KeyCode.RightArrow))
            anim.SetBool("Waving2", true);
        else
            anim.SetBool("Waving2", false);

    }
}
