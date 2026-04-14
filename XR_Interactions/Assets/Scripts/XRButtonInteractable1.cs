using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class XRButtonInteractable1 : XRSimpleInteractable
{
    [SerializeField] Image buttonImage;
    [SerializeField] Color[] buttonColors = new Color[4];

    private Color normalColor;
    private Color highlightedColor;
    // Start is called before the first frame update
    void Start()
    {
        normalColor = buttonImage.color;
        highlightedColor = buttonColors[1];

        buttonImage.color = normalColor;
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        buttonImage.color = highlightedColor;   
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        buttonImage.color = normalColor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
