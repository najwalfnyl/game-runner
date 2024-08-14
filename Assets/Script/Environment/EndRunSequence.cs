using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject endPause;

    public void TriggerEndSequence()
    {
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        endPause.SetActive(false);
    }
}
