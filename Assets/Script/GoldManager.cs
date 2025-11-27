using TMPro;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    private int powerPrice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1;
        powerPrice = 10;
    }

    public void changeGold()
    { 

        goldAmount += power; 
        goldText.text = goldAmount.ToString("00");
    }

    public void ChangePower()
    {
        if (goldAmount >powerPrice)
        {
            goldAmount -= 10;
            goldText.text = goldAmount.ToString("00");
            powerPrice = Mathf.RoundToInt(powerPrice * 1.2f);

            power += 1;

            powerText.text = power.ToString("00");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
