using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    private static LTDescr delay;

    private static TooltipSystem current;

    public Tooltip tooltip;

    public void Awake()
    {
        current = this;
    }

    public static void Show(string content, string header)
    {
        current.tooltip.SetText(content, header);
        LeanTween.alphaCanvas(current.tooltip.gameObject.GetComponent<CanvasGroup>(), 1f, .1f);
        current.tooltip.gameObject.SetActive(true);
    }

    public static void Hide()
    {
        LeanTween.alphaCanvas(current.tooltip.gameObject.GetComponent<CanvasGroup>(), 0f, .1f);
        delay = LeanTween.delayedCall(0.3f, () =>
        {
            current.tooltip.gameObject.SetActive(false);
        });
    }
}
