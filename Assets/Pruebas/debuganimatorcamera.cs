using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debuganimatorcamera : MonoBehaviour
{
    public Animator animacion;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("para mover la camara dale click a la pantalla xd");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animacion.SetTrigger("cambio");
        }
    }
}
