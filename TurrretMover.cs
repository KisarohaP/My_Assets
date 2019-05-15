using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurrretMover : MonoBehaviour
{

    public float houshinKaitenSokudo;//砲身回転速度
    private float kaitenKaku; //砲身角度
    public Text kaiten;

    void Start()
    {
        kaitenKaku = 0.0f;
    }
    void FixedUpdate()
    {
        //砲身上下
        if (Input.GetKey("r"))
        {
            if (kaitenKaku > -33)
            {
                transform.Rotate(-houshinKaitenSokudo, 0, 0);
                kaitenKaku -= houshinKaitenSokudo;
                kaiten.text = "Altura : " + -1 * kaitenKaku + "°";
            }
        }
        if (Input.GetKey("f"))
        {
            if (kaitenKaku < 5)
            {
                transform.Rotate(houshinKaitenSokudo, 0, 0);
                kaitenKaku += houshinKaitenSokudo;
                kaiten.text = "Altura : " + -1 * kaitenKaku + "°";
            }
        }
    }
}