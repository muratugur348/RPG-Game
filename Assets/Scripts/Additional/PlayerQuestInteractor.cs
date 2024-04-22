using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuestInteractor : MonoBehaviour
{
    public List<Questman> questmen = new List<Questman>();
    public GameObject inworldCamera;
    private Camera _mainCam;

    private void Start()
    {
        _mainCam = Camera.main;
    }
    public void AddQuestman(Questman questman)
    {
        if (!questmen.Contains(questman))
            questmen.Add(questman);
    }
    public void RemoveQuestman(Questman questman)
    {
        if (questmen.Contains(questman))
            questmen.Remove(questman);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && questmen.Count > 0 && !inworldCamera.gameObject.activeInHierarchy)
        {
            PassInworldCamera();
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && inworldCamera.gameObject.activeInHierarchy)
            PassNormalCamera();
    }
    private void PassInworldCamera()
    {
        inworldCamera.SetActive(true);
        inworldCamera.transform.SetPositionAndRotation(_mainCam.transform.position, _mainCam.transform.rotation);
        transform.DOMove(questmen[0].transform.position + questmen[0].transform.right * 3, 0.5f);
        inworldCamera.transform.DOMove(questmen[0].transform.position + new Vector3(0, 2f, 5), 0.5f).OnUpdate(() =>
        {
            inworldCamera.transform.LookAt(questmen[0].transform.position + new Vector3(0, 1.5f, 0));
        });
    }
    private void PassNormalCamera()
    {
        inworldCamera.transform.DOKill(false);
        inworldCamera.transform.DORotate(_mainCam.transform.eulerAngles, 0.5f);
        inworldCamera.transform.DOMove(_mainCam.transform.position, 0.5f).OnComplete(() =>
        {
            inworldCamera.SetActive(false);
        });
    }
}
