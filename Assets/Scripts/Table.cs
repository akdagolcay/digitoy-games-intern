using UnityEngine;
using TMPro;
public class Table : MonoBehaviour
{
    [SerializeField] public TableTypes type;
    [SerializeField] public int betAmount;
    [SerializeField] TextMeshProUGUI betText;
    [SerializeField] TextMeshProUGUI modeText;

    private void Start()
    {
        betText.text = "200$ - " + betAmount.ToString() + "$";
        switch (type)
        {
            case 0:
                modeText.text = "HIZLI"; 
                break;
            case (TableTypes)1:
                modeText.text = "TEKETEK";
                break;
            case (TableTypes)2:
                modeText.text = "RÖVANŞ";
                break;
        }
    }
}
