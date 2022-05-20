using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEvents : MonoSingleton<GameEvents>
{
    public UnityAction onSearch;
    public UnityAction<List<Table>> sendTables;
    public UnityAction tableOpen;

}
