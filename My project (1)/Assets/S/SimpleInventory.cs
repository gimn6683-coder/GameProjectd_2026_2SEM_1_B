using UnityEngine;
using UnityEngine. InputSystem;
using TMPro;
using System.Collections.Generic;

public class SimpleInventory : MonoBehaviour


{
    
    
        [Header("UI 연결")]
        [SerializeField] private GameObject inventoryPanel;
        [SerializeField] private TextMeshProUGUI[] slotTexts;

        private List<InventoryItem> items = new List<InventoryItem>();

        private PlayerController playerController;
        private PlayerPickup playerPickup;
        private ThirdPersonCamera thirdPersonCamera;
        private bool isOpen;

        private void Awake()
        {
            playerController = GetComponent<PlayerController>();
            playerPickup = GetComponent<PlayerPickup>();

            if (Camera.main != null)
            {
                thirdPersonCamera = Camera.main.GetComponent<ThirdPersonCamera>();
            }

            inventoryPanel.SetActive(false);
        }

    void Start()
    {
        UpdateUI(); 
    }
        private void UpdateUI()
        {
            for (int i = 0; i < slotTexts.Length; i++)
            {
                if (i < items.Count)
                {
                    slotTexts[i].text = items[i].itemName + "\n" + items[i].amount + "개";
                }
                else
                {
                    slotTexts[i].text = "비어 있음";
                }
            }
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        
        // Update is called once per frame
        void Update()
        {
          
           Keyboard keyboard = Keyboard.current;
            
        if (keyboard == null) return;
        if ( keyboard. iKey.wasPressedThisFtame)
        {
            
        }



    }
    }

