using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SliderValueToMoney : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI sliderMoney;
    [SerializeField] Slider moneySlider;
    public void SetValueForSliderMoney()
    {
        sliderMoney.text = moneySlider.value.ToString() + "$";
    }
}
