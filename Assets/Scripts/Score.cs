
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoretext;

    // Update is called once per frame
    void Update()
    {
        scoretext.text = player.position.z.ToString("0");
    }
}
