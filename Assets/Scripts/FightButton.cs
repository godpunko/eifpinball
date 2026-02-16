using UnityEngine;

public class FightButton : MonoBehaviour
{

    [SerializeField] bool fightButton = false;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject targetSoul;
    [SerializeField] float pointsDealt = 100f;
    [SerializeField] float healsFor = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (fightButton)
        {

            targetSoul.GetComponent<TheSoullBall>().score = targetSoul.GetComponent<TheSoullBall>().score + pointsDealt;
            targetSoul.GetComponent<TheSoullBall>().genscore = targetSoul.GetComponent<TheSoullBall>().genscore + 1;

            enemy.GetComponent<EnemyScript>().proceed = true;
            enemy.GetComponent<SpriteRenderer>().color = Color.red;

            GetComponent<AudioSource>().Play();

        }

        else
        {

            targetSoul.GetComponent<TheSoullBall>().soulHP = targetSoul.GetComponent<TheSoullBall>().soulHP + healsFor;
            targetSoul.GetComponent<TheSoullBall>().pacscore = targetSoul.GetComponent<TheSoullBall>().pacscore + 1;

            enemy.GetComponent<EnemyScript>().proceed = true;
            enemy.GetComponent<SpriteRenderer>().color = Color.yellow;

            GetComponent<AudioSource>().Play();

        }
        
        

    }

}
