using Unity.VisualScripting;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    private bool isStarted = false;

    private void Awake()
    {
        StartScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartScreen.SetActive(false);
            isStarted = true;
            Time.timeScale = 1f;
        }
    }
}
