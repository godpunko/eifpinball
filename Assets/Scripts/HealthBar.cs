using UnityEngine;

public class HealthBar : MonoBehaviour
{

    private float scalePercent;
    private float maxHP;
    [SerializeField] private GameObject targetSoul;

    void Start()
    {
        maxHP = targetSoul.GetComponent<TheSoullBall>().soulMaxHP;
        scalePercent = targetSoul.GetComponent<TheSoullBall>().soulHP / maxHP;

    }

    void Update()
    {

        scalePercent = targetSoul.GetComponent<TheSoullBall>().soulHP / maxHP;

        transform.localScale = new Vector3(scalePercent, 1, 1);

    }
}
