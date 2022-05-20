using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindTables : MonoBehaviour
{
    [SerializeField] List<Toggle> toggles;
    List<int> indexes = new List<int>();
    int betAmount = 0;
    [SerializeField] Slider moneySlider;
    [SerializeField] Animator noGameFound;
    private void Start()
    {
        GameEvents.instance.sendTables += FindRightTables;
    }
    private void OnDestroy()
    {
        GameEvents.instance.sendTables -= FindRightTables;
    }

    private void FindRightTables(List<Table> tables)
    {
        bool isGameFound = false;
        indexes.Clear();
        foreach (Table table in tables)
        {
            table.gameObject.SetActive(false);
        }
        for (int i = 0; i < toggles.Count; i++)
        {
            if (toggles[i].isOn)
            {
                indexes.Add(i);
            }
        }
        foreach (Table table in tables)
        {
            for (int i = 0; i < indexes.Count; i++)
            {
                if (table.type == (TableTypes)indexes[i])
                {
                    if (table.betAmount <= (int)moneySlider.value)
                    {
                        isGameFound = true;
                        table.gameObject.SetActive(true);
                    }
                }
            }
        }
        if (isGameFound)
        {
            GameEvents.instance.tableOpen?.Invoke();
        }
        else
        {
            noGameFound.Play("masabulunamadi", 0, 0);
        }
    }
}
