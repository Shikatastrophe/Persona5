using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public PersonaData Persona;
    public TextMeshProUGUI personaName;
    public Image personaImg;
    public TextMeshProUGUI personaArcana;
    public TextMeshProUGUI personaLevel;
    [Header("Elementals")]
    public TextMeshProUGUI[] elName;
    [Header("Stats")]
    public TextMeshProUGUI[] stats;
    [Header("Skills")]
    public TextMeshProUGUI[] skName;
    public TextMeshProUGUI[] skLevel;
    public Image[] skImg;
    public TextMeshProUGUI[] skEffect;
    public TextMeshProUGUI[] skCost;



    // Start is called before the first frame update
    void Start()
    {
        /*
        foreach(int el in Persona.Stats)
        {
        Debug.Log(Persona.Stats[el]);
        }
        */
        //Debug.Log(Persona.Skills[0].Eff);
        //personaStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void personaStats()
    {
        personaName.text = Persona.name;
        personaImg.sprite = Persona.Pict;
        personaArcana.text = Persona.Arcana;
        personaLevel.text = Persona.Lvl.ToString();
        for(int i=0; i <= 9; i++)
        {
            switch (Persona.Element[i])
            {
                case 0:
                    elName[i].text = "";
                    break;
                case 1:
                    elName[i].text = "WK";
                    break;
                case 2:
                    elName[i].text = "STR";
                    break;
            }

        }
        for(int i=0; i <= 4; i++)
        {
            //stats[i].text = Persona.Stats[i].ToString();
            switch (i)
            {
                case 0:
                    stats[i].text = "St "+ Persona.Stats[i].ToString();
                    break;
                case 1:
                    stats[i].text = "Ma " + Persona.Stats[i].ToString();
                    break;
                case 2:
                    stats[i].text = "En " + Persona.Stats[i].ToString();
                    break;
                case 3:
                    stats[i].text = "Ag " + Persona.Stats[i].ToString();
                    break;
                case 4:
                    stats[i].text = "Lu " + Persona.Stats[i].ToString();
                    break;
            }
        }
        for(int i=0; i <= 5; i++)
        {
            skName[i].text = Persona.Skills[i].Sname;
            skLevel[i].text = Persona.Skills[i].Level.ToString();
            skImg[i].sprite = Persona.Skills[i].Type2;
            skEffect[i].text = Persona.Skills[i].Eff;
            skCost[i].text = Persona.Skills[i].Cost;
        }
    }
}
