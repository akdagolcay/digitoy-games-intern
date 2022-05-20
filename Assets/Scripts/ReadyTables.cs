using System.Collections.Generic;
using UnityEngine;

public class ReadyTables : MonoBehaviour
{
    [SerializeField] List<Table> tables;
    private void Start()
    {
        GameEvents.instance.onSearch += SendTables;
    }
    private void OnDestroy()
    {
        GameEvents.instance.onSearch -= SendTables;
    }
    private void SendTables()
    {
        GameEvents.instance.sendTables?.Invoke(tables);
    }
}
