using System.Collections;
using TMPro;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public bool pause;
    public int power;
    public int powerTime;
    public int grandMother;
    public int farm;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI fingerText;
    public TextMeshProUGUI GrandMotherText;
    public TextMeshProUGUI farmText;
    private bool pouce;
    private int powerPrice;
    private int timePrice;
    public int multiplePrice;
    public int grandMotherPrice;
    public int farmPrice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1;
        powerPrice = 10;
        timePrice = 10;
        powerTime = 0;
        multiplePrice = 10;
        grandMother = 0;
        grandMotherPrice = 100;
        farm = 0;
        farmPrice = 1000;
        StartCoroutine(GoldOverTime());
        StartCoroutine(GrandMotherOverTime());
        StartCoroutine(FarmOverTime());
    }
    public void Pause()
    {
        pause = !pause;

    }
    public void changeGold()
    { 

        goldAmount += power;
       
    }

    public void ChangePower()
    {
        if (goldAmount >=powerPrice)
        {
            goldAmount -= powerPrice;
            powerPrice = Mathf.RoundToInt(powerPrice * 1.2f);

            power += 1;

            
        }
    }

    public void RisePowerTime()
    {

        if (goldAmount >= multiplePrice)
        {
            goldAmount -= multiplePrice;
            multiplePrice = Mathf.RoundToInt(multiplePrice * 1.1f);
            
            powerTime += 1;
        }
        
    }

    public void GrandMother()
    {

        if (goldAmount >= grandMotherPrice)
        {
            goldAmount -= grandMotherPrice;
            grandMotherPrice = Mathf.RoundToInt(grandMotherPrice * 1.1f);

            grandMother += 1;
        }

    }

    public void Farm()
    {

        if (goldAmount >= farmPrice)
        {
            goldAmount -= farmPrice;
            farmPrice = Mathf.RoundToInt(farmPrice * 1.1f);

            farm += 100;
        }

    }

    public IEnumerator GoldOverTime()
    {
        while (true)
        {
            while (pause)
            {
                yield return new WaitForEndOfFrame();
            }
            goldAmount += powerTime;
            yield return new WaitForSeconds(10);
        }
    }

    public IEnumerator GrandMotherOverTime()
    {
        while (true)
        {
            while (pause)
            {
                yield return new WaitForEndOfFrame();
            }
            goldAmount += grandMother;
            yield return new WaitForSeconds(1);
        }
    }

    public IEnumerator FarmOverTime()
    {
        while (true)
        {
            while (pause)
            {
                yield return new WaitForEndOfFrame();
            }
            goldAmount += farm;
            yield return new WaitForSeconds(5);
        }
    }


    // Update is called once per frame
    void Update()
    {
        powerText.text = power.ToString("00");
        //    goldText.text = goldAmount.ToString("00");
        fingerText.text = powerTime.ToString("00");
        GrandMotherText.text = grandMother.ToString("00");
        farmText.text = (farm/100).ToString("00");
    }
   }
