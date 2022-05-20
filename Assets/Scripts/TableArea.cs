using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableArea : MonoBehaviour
{
    [SerializeField] GameObject tableArea;
    private void Start()
    {
        GameEvents.instance.tableOpen += OpenArea;
    }
    private void OnDestroy()
    {
        GameEvents.instance.tableOpen -= OpenArea;
    }
    private void OpenArea()
    {
        tableArea.SetActive(true);
    }
    public void CloseArea()
    {
        tableArea.SetActive(false);
    }
}
