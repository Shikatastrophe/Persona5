using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepersona : MonoBehaviour
{
    public PersonaData wichxd;
    public GameObject infoxd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeP()
    {
        infoxd.GetComponent<DataManager>().Persona = wichxd;
        infoxd.GetComponent<DataManager>().personaStats();
    }
}
