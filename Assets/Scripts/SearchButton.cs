using UnityEngine;

public class SearchButton : MonoBehaviour
{
    [SerializeField] GameObject searchArea;
    private void Start()
    {
        GameEvents.instance.tableOpen += OpenCloseSearch;
    }
    private void OnDestroy()
    {
        GameEvents.instance.tableOpen -= OpenCloseSearch;
    }
    public void Search()
    {
        GameEvents.instance.onSearch?.Invoke();
    }
    public void OpenCloseSearch()
    {
        if (searchArea.activeSelf)
        {
            searchArea.SetActive(false);
        }
        else
        {
            searchArea.SetActive(true);
        }
    }
}
