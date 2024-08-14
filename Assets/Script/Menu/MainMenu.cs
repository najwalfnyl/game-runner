using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Nama scene yang ingin dijalankan saat tombol "Play" diklik
    public string DesertRun;

    // Metode ini akan dipanggil saat tombol "Play" diklik
    public void OnPlayButtonClicked()
    {
        // Memuat scene yang diinginkan
        SceneManager.LoadScene(DesertRun);
    }
}