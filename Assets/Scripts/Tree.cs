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
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(210, 105, 30, 255);
    }
}