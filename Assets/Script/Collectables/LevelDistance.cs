using System.Collections;
using UnityEngine;
using TMPro;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public TextMeshProUGUI DisplayCount;
    public TextMeshProUGUI DisplayEnd;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.35f;

    void Start()
    {
        // Mengatur teks awal di TextMeshProUGUI
        DisplayCount.text = "0";
        DisplayEnd.text = "0";
    }

    void Update()
    {
        if (!addingDis)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        DisplayCount.text = disRun.ToString();
        DisplayEnd.text = disRun.ToString(); // Menggunakan ToString() untuk mengubah nilai int ke string
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
