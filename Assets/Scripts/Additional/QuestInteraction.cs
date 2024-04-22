using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestInteraction : MonoBehaviour
{
    private PlayerQuestInteractor _playerQuestInteractor;
    private void Start()
    {
        _playerQuestInteractor = transform.GetComponentInParent<PlayerQuestInteractor>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Questman") && other.TryGetComponent(out Questman questman))
        {
            questman.ChangeActivityOfButton(true);
            _playerQuestInteractor.AddQuestman(questman);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Questman") && other.TryGetComponent(out Questman questman))
        {
            questman.ChangeActivityOfButton(false);
            _playerQuestInteractor.RemoveQuestman(questman);
        }
    }
}
