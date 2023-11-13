using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public PersonaData Persona;
    
    // Start is called before the first frame update
    void Start()
    {
        /*
        foreach(int el in Persona.Stats)
        {
        Debug.Log(Persona.Stats[el]);
        }
        */
        Debug.Log(Persona.Skills[0].Eff);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
