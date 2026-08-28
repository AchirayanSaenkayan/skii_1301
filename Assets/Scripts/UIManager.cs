using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

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
}