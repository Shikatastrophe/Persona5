using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Persona Data", menuName ="New Persona Data")]
public class PersonaData : ScriptableObject
{
    [SerializeField] private string pname;
    [SerializeField] private Sprite pict;
    [SerializeField] private string arcana;
    [SerializeField] private int lvl;
    [SerializeField] private int[] stats;
    [SerializeField] private int[] element;
    [SerializeField] private InheritanceData inher;
    [SerializeField] private SkillsData[] skills;


    public string Pname { get { return pname; } }
    public Sprite Pict { get { return pict; } }
    public string Arcana { get { return arcana; } }
    public int Lvl { get { return lvl; } }
    public int[] Stats { get { return stats; } }
    public int[] Element { get { return element; } }
    public InheritanceData Inher { get { return inher; } }
    public SkillsData[] Skills { get { return skills; } }
}
