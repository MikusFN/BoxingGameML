﻿using UnityEngine;
using System.Collections;

public class AnimatorOverride : MonoBehaviour
{
    void OnAnimatorMove()
    {
        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            //Vector3 newPosition = transform.position;
            //newPosition.z += (animator.GetFloat("Runspeed") * Time.deltaTime)/10;
            //transform.position = newPosition;
        }
    }
}