using UnityEngine;
using TMPro;

public class StartOver : MonoBehaviour
{

    [SerializeField] TMP_Text text;
    [SerializeField] GameObject soul;

    private void Awake()
    {
        text.SetText("");
    }

    private void Update()
    {
        
        if (soul.GetComponent<TheSoullBall>().died)
        {

            var kills = soul.GetComponent<TheSoullBall>().genscore.ToString();
            var spares = soul.GetComponent<TheSoullBall>().pacscore.ToString();
            var score = soul.GetComponent<TheSoullBall>().score.ToString();

            text.SetText($"[TAB] to Restart\n\nKILLS : {kills}\nSPARES : {spares}\nSCORE : {score}");

        }


    }



}
