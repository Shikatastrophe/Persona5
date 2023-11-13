using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMover : MonoBehaviour
{
    public Animator animator;
    public void animSwap(string s)
    {
        animator.SetTrigger(s);
    }
}
