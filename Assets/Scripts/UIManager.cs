using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Player player;

    public static UIManager instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    public void ShowNotiText(string s)
    {
        if (notiText != null)
        {
            notiText.text = s;
        }
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0f, 88f, -86.25f);
        player.HP = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestertButton(false);
    }

    public void ShowHideRestertButton(bool flag)
    {
        restartButton.SetActive(flag);
    }
}