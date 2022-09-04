using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject display;
    [SerializeField] private Button closeButton;

    [Header("Specification Display")]
    [SerializeField] private Image partImage;
    [SerializeField] private TextMeshProUGUI partNameText;
    [SerializeField] private TextMeshProUGUI text1;
    [SerializeField] private TextMeshProUGUI text2;
    [SerializeField] private TextMeshProUGUI text3;
    [SerializeField] private TextMeshProUGUI text4;
    [SerializeField] private TextMeshProUGUI text5;
    [SerializeField] private TextMeshProUGUI text6;
    [SerializeField] private TextMeshProUGUI text7;

    [Header("Rules Display")]
    [SerializeField] private GameObject ruleDisplay;


    private bool isSpecDisplayOpen = false;
    private bool isRuleDisplayOpen = false;

    private void Start()
    {
        ruleDisplay.SetActive(true);
        isRuleDisplayOpen = true;
    }


    public void DisplayInfo(VehiclePartSO data)
    {
        partImage.sprite = data.partImage;

        partNameText.text = data.partName;
        text1.text = data.text1;
        text2.text = data.text2;
        text3.text = data.text3;
        text4.text = data.text4;
        text5.text = data.text5;
        text6.text = data.text6;
        text7.text = data.text7;

        display.SetActive(true);
        isSpecDisplayOpen = true;
    }

    public void OnCloseButtonClick()
    {
        display.SetActive(false);
        ruleDisplay.SetActive(false);
        isSpecDisplayOpen = false;
        isRuleDisplayOpen = false;
    }

    public bool IsDisplayOpen()
    {
        return isSpecDisplayOpen || isRuleDisplayOpen;
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
