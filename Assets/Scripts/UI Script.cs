using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.IO;

public class UIScript : MonoBehaviour
{
    public GameObject DomainExpansion, UIText, Button, Red, Blue, HollowPurple, HollowPurpleButton, HollowPurpleObject;
    public Vector3 DomainExpand, RedV, BlueV, HollowPurpleV, TargetPos;
    public float TargetTime, DomainExpandSpeed, HollowPurpleF;

    public void Start()
    {
        Red.SetActive(false); 
        Blue.SetActive(false);

    }

    public void ExpandDomain()
    {
        HollowPurpleObject.SetActive(false);
        DomainExpansion.transform.DOScale(Vector3.zero, 1.5f);
        //DomainExpansion.transform.DOScale(Vector3.up, 1.5f);
        //DomainExpansion.transform.DOScale(Vector3.left, 1.5f);
        //DomainExpansion.transform.DOScale(Vector3.down, 1.5f);
        //DomainExpansion.transform.DOScale(Vector3.right, 1.5f);
        UIText.SetActive(false);
        Button.SetActive(false);
        DomainExpansion.transform.DOScale(DomainExpand, DomainExpandSpeed).SetEase(Ease.InCirc);
    }

    public void HollowPurpleAction()
    {
        Red.SetActive(true); 
        Blue.SetActive(true);
        DomainExpansion.SetActive(false);
        HollowPurpleButton.SetActive(false);
        Red.transform.DOLocalMove(RedV, HollowPurpleF).SetEase(Ease.Flash).OnComplete(()=> Destroy(Red));
        Blue.transform.DOLocalMove(BlueV, HollowPurpleF).SetEase(Ease.Flash).OnComplete(()=> Destroy(Blue));
        HollowPurple.transform.DOScale(HollowPurpleV, HollowPurpleF);
    }
}
