using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public Animator profileAnimator; // Profile panel için Animator referansı
    public Animator helpAnimator;    // Help panel için Animator referansı

    private bool isProfileOpen = false;
    private bool isHelpOpen = false;

    public void ToggleProfilePanel()
    {
        if (isProfileOpen)
        {
            profileAnimator.SetTrigger("closeTrigger");
            isProfileOpen = false;
        }
        else
        {
            if (isHelpOpen)
            {
                helpAnimator.SetTrigger("closeTrigger");
                isHelpOpen = false;
            }
            profileAnimator.SetTrigger("openTrigger");
            isProfileOpen = true;
        }
    }

    public void ToggleHelpPanel()
    {
        if (isHelpOpen)
        {
            helpAnimator.SetTrigger("closeTrigger");
            isHelpOpen = false;
        }
        else
        {
            if (isProfileOpen)
            {
                profileAnimator.SetTrigger("closeTrigger");
                isProfileOpen = false;
            }
            helpAnimator.SetTrigger("openTrigger");
            isHelpOpen = true;
        }
    }
}
