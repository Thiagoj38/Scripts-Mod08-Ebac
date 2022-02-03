using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuAnimationBase : MonoBehaviour
{
    #region VARIABLES

    public List<GameObject> myObjects;
    public float delayBetweenObjects = .1f;
    public Animator animator;
    public string triggerShow = "Show";
    public string triggerHide = "Hide";
    
    private bool _isShowing = false;

    #endregion

    #region BUTTON_MENU

    public void ShowMenu()
    {
        if (_isShowing)
        {
            HideMenu();
            animator.SetTrigger(triggerHide);
            
        }
        else
        {
            animator.SetTrigger(triggerShow);
            _isShowing = true;
            StartCoroutine(IShowMenu());
        }
    }
    
    IEnumerator IShowMenu()
    {
        foreach (GameObject g in myObjects)
        {
            yield return new WaitForSeconds(delayBetweenObjects);
            g.SetActive(true);

        }
    }
    #endregion

    #region BUTTON_SHOP

    public void ShowShop()
    {
        if (_isShowing)
        {
            HideMenu();
            animator.SetTrigger(triggerHide);

        }
        else
        {
            animator.SetTrigger(triggerShow);
            _isShowing = true;
            StartCoroutine(IShowShop());
        }


    }

    IEnumerator IShowShop()
    {
        foreach (GameObject g in myObjects)
        {
            yield return new WaitForSeconds(delayBetweenObjects);
            g.SetActive(true);

        }
    }

    #endregion

    #region BUTTON_INVENTORY

    public void ShowInventory()
    {
        if (_isShowing)
        {
            HideMenu();
            animator.SetTrigger(triggerHide);

        }
        else
        {
            animator.SetTrigger(triggerShow);
            _isShowing = true;
            StartCoroutine(IShowInventory());
        }


    }

    IEnumerator IShowInventory()
    {
        foreach (GameObject g in myObjects)
        {
            yield return new WaitForSeconds(delayBetweenObjects);
            g.SetActive(true);

        }
    }

    #endregion

    #region BUTTON_EMAIL

    public void ShowEmail()
    {
        if (_isShowing)
        {
            HideMenu();
            animator.SetTrigger(triggerHide);

        }
        else
        {
            animator.SetTrigger(triggerShow);
            _isShowing = true;
            StartCoroutine(IShowEmail());
        }


    }

    IEnumerator IShowEmail()
    {
        foreach (GameObject g in myObjects)
        {
            yield return new WaitForSeconds(delayBetweenObjects);
            g.SetActive(true);

        }
    }

    #endregion

    #region BUTTON_CONFIG

    public void ShowConfig()
    {
        if (_isShowing)
        {
            HideMenu();
            animator.SetTrigger(triggerHide);

        }
        else
        {
            animator.SetTrigger(triggerShow);
            _isShowing = true;
            StartCoroutine(IShowConfig());
        }


    }

    IEnumerator IShowConfig()
    {
        foreach (GameObject g in myObjects)
        {
            yield return new WaitForSeconds(delayBetweenObjects);
            g.SetActive(true);

        }
    }

    #endregion

    private void HideMenu()
    {
        _isShowing = false;
        foreach (GameObject g in myObjects)
        {
            g.SetActive(false);
        }
    }

    private void Awake()
    {
        HideMenu();
    }

}



