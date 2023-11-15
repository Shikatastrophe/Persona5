using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDeCamara : MonoBehaviour
{
    public Animator animator;
    public int ram;
    public void cambiosec()
    {
        animator.SetTrigger("second");
    }
    public void randomAnim()
    {
        ram = Random.Range(1, 3);
        if(ram == 1)
        {
            animator.SetTrigger("third");
        }
        else
        {
            animator.SetTrigger("fourth");
        }
    }
    public void backSec()
    {
        animator.SetTrigger("secondback");
    }
    public void backxd()
    {
        if (ram == 1)
        {
            animator.SetTrigger("third back");
        }
        else
        {
            animator.SetTrigger("fourthback");
        }
    }
}
