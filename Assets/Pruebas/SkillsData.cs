using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Skill Data", menuName ="New Skill Data")]
public class SkillsData : ScriptableObject
{
    [SerializeField] private int level;
    [SerializeField] private string type;
    [SerializeField] private Sprite type2;
    [SerializeField] private string sname;
    [SerializeField] private string eff;
    [SerializeField] private string cost;

    public int Level { get { return level; } }
    public string Type { get { return type; } }
    public string Type2 { get { return type; } }
    public string Sname { get { return sname; } }
    public string Eff { get { return eff; } }
    public string Cost { get { return cost; } }
}
