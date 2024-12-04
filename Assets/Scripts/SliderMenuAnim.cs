using System.Collections.Generic;
using UnityEngine;

public class SliderMenuAnim : MonoBehaviour
{
    public GameObject panelToControl;  // Panel controlled by this button.
    public List<GameObject> allPanels; // List of all panels to manage.

    // Method called when the button is pressed.
    public void OnButtonPress()
    {
        if (panelToControl != null)
        {
            // Loop through all panels and close the ones that are not the selected panel.
            foreach (GameObject panel in allPanels)
            {
                Animator animator = panel.GetComponent<Animator>();
                if (animator != null)
                {
                    bool isThisPanel = (panel == panelToControl);
                    animator.SetBool("show", isThisPanel);  // Open the selected panel, close others.
                }
            }
        }
    }
}
