using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    public TextMeshProUGUI CoinCount;
    public TextMeshProUGUI CoinEnd;

    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectableControl.coinCount += 1;
        CollectableControl.coinEnd += 1;
        SetCountText(); // Call the non-static method directly
        this.gameObject.SetActive(false);
    }

    private void SetCountText()
    {
        CoinCount.text = " " + CollectableControl.coinCount.ToString();
        CoinEnd.text = " " + CollectableControl.coinCount.ToString();
    }
}