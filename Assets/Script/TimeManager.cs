using System.Collections;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float timeToWait;
    public GoldManager goldUpdate;
    public int x;
    public bool shouldXTournerenboucle;
    public bool pause;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FaireDesChoses());
    }

    public float tempsEcoule;
    // Update is called once per frame
    void Update()
    {
        
    }
    private float tempsDAttente;

    public void TooglePause()
    {
        pause = !pause;
    }
    public IEnumerator FaireDesChoses()
    {
        while (true)
        {
            while (pause)
            {
                yield return new WaitForEndOfFrame();
            }
            goldUpdate.changeGold();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
