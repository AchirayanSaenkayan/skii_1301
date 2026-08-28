using UnityEngine;

public class Finish : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();

        if (p == null)
            return;

        UIManager.instance.ShowNotiText($"You Win!!!\nPoints: {p.Point}");
    }
}