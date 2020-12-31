using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMachine : MonoBehaviour
{
    //Units Spawn in

    //Read Teams
    Dictionary<int, Unit> allUnits = new Dictionary<int, Unit>();
    Dictionary<int, Unit> heroUnits = new Dictionary<int, Unit>();
    Dictionary<int, Unit> enemyUnits = new Dictionary<int, Unit>();

    Dictionary<int, Unit> turnOrder = new Dictionary<int, Unit>();

}
