using UnityEngine;
using TMPro;

public class scorekeeper : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] private GameObject targetSoul;


    void Update()
    {

        var score = targetSoul.GetComponent<TheSoullBall>().score.ToString();
        text.SetText(score + "P");

    }
}
