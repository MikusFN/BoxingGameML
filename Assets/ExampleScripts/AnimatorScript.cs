using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{

    Animator animatorEx;
    //Getting the hash values from the state machine because its lighter to use.
    int idleHash = Animator.StringToHash("IdleState");
    int dodgeHash = Animator.StringToHash("Dodge");

    // Use this for initialization
    void Start()
    {
        animatorEx = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dodgeValue = Input.GetAxis("Horizontal");

        if (animatorEx)
            animatorEx.SetFloat("dodgeDirection", dodgeValue);

        AnimatorStateInfo animatorState = animatorEx.GetCurrentAnimatorStateInfo(0);

        if (Input.GetKeyDown(KeyCode.Space))//&&animatorState.nameHash==idleHash)
        {
            animatorEx.SetTrigger(dodgeHash);
        }
    }
}
