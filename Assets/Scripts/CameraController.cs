using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Animator animator;
    public bool isMainCam = true;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            CameraChange();
        }
    }

    void CameraChange()
    {
        if (isMainCam)
        {
            animator.Play("AnaCam");
        }
        else
        {
            animator.Play("EkCam");
        }
        isMainCam = !isMainCam;

    }
}
