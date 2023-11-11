using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Inheritance Data", menuName ="New Inheritance Data")]
public class InheritanceData : ScriptableObject
{
    [SerializeField] private string iname;
    [SerializeField] private bool physic;
    [SerializeField] private bool gun;
    [SerializeField] private bool fire;
    [SerializeField] private bool ice;
    [SerializeField] private bool electric;
    [SerializeField] private bool wind;
    [SerializeField] private bool psy;
    [SerializeField] private bool nuclear;
    [SerializeField] private bool bless;
    [SerializeField] private bool curse;
    [SerializeField] private bool heal;
    [SerializeField] private bool ailment;

    public string Iname { get { return iname; } }
    public bool Physic { get { return physic; } }
    public bool Gun { get { return gun; } }
    public bool Fire { get { return fire; } }
    public bool Ice { get { return ice; } }
    public bool Electric { get { return electric; } }
    public bool Wind { get { return wind; } }
    public bool Psy { get { return psy; } }
    public bool Nuclear { get { return nuclear; } }
    public bool Bless { get { return bless; } }
    public bool Curse { get { return curse; } }
    public bool Heal { get { return heal; } }
    public bool Ailment { get { return ailment; } }

}
