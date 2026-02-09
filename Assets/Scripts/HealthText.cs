using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{

    [SerializeField] TMP_Text text;
    private string maxHP;
    [SerializeField] private GameObject targetSoul;

    void Start()
    {

        maxHP = targetSoul.GetComponent<TheSoullBall>().soulMaxHP.ToString();

    }

    // Update is called once per frame
    void Update()
    {

        var hp = targetSoul.GetComponent<TheSoullBall>().soulHP.ToString();
        text.SetText(hp + "/" + maxHP + " HP");
        
    }
}
