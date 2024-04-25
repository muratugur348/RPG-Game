using System.Collections;
using System.Collections.Generic;
using Inworld.Sample.RPM;
using UnityEngine;

namespace GameDevTV.UI
{
    public class ShowHideUI : MonoBehaviour
    {
        [SerializeField] KeyCode toggleKey = KeyCode.Escape;
        [SerializeField] GameObject uiContainer = null;

        private GameObject _inworldChat;

        // Start is called before the first frame update
        void Awake()
        {
            _inworldChat = FindObjectOfType<PlayerControllerRPM>().gameObject;
            uiContainer.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(toggleKey) && !_inworldChat.activeInHierarchy)
            {
                Toggle();
            }
        }

        public void Toggle()
        {
            uiContainer.SetActive(!uiContainer.activeSelf);
        }
    }
}