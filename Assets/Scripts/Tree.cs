using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;

    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();
        if (player == null)
            return;

        player.HP -= 15;
        UIManager.instance.ShowNotiText($"Hurt -15\nHP: {player.HP}");

        if (player.HP <= 0)
        {
            player.HP = 0;
            UIManager.instance.ShowNotiText($"You are dead!!!\nPoints: {player.Point}");
            Time.timeScale = 0f;
            UIManager.instance.ShowHideRestertButton(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(210, 105, 30, 255);
    }
}