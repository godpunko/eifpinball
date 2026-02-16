using UnityEngine;
using TMPro;

public class EnemyScript : MonoBehaviour
{

    [SerializeField] Sprite[] spriteList;
    [SerializeField] string[] enemyNames;
    [SerializeField] TMP_Text textbox;
    private string nameEnemy = "";
    private float enemyNum = 0f;
    public bool proceed = false;

    private void Awake()
    {

        proceed = true;

    }

    private void Update()
    {
        
        if (proceed)
        {

            var chosenSprite = Random.Range(0, spriteList.Length);

            GetComponent<SpriteRenderer>().sprite = spriteList[chosenSprite];
            nameEnemy = enemyNames[chosenSprite];

            enemyNum = enemyNum + 1;
            var enemyNumStr = (enemyNum).ToString();

            textbox.SetText("("+enemyNum+") "+ nameEnemy);

            proceed = false;

            GetComponent<SpriteRenderer>().color = Color.white;


        }

    }


}
