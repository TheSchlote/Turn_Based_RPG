using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Unit : ScriptableObject
{
    public string unitName;
    //different colors mayber

    public int maxHP;
    public int curHP;
    public int maxMP;
    public int curMP;

    public int Attack;
    public int Defense;
    public int Speed;
}
