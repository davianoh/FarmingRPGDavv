using System.Collections;
using UnityEngine;

public class TriggerObscuringItemFader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ObscuringItemFader[] obscuringItemFader = collision.gameObject.GetComponentsInChildren<ObscuringItemFader>();

        if(obscuringItemFader.Length > 0)
        {
            foreach(ObscuringItemFader obscuringItem in obscuringItemFader)
            {
                obscuringItem.FadeOut();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ObscuringItemFader[] obscuringItemFader = collision.gameObject.GetComponentsInChildren<ObscuringItemFader>();

        if (obscuringItemFader.Length > 0)
        {
            foreach (ObscuringItemFader obscuringItem in obscuringItemFader)
            {
                obscuringItem.FadeIn();
            }
        }
    }
}
