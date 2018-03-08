using UnityEngine;

/* This object updates the inventory UI. */

public class InventoryUI : MonoBehaviour {

	public Transform itemsParent;	// The parent object of all the items
	public GameObject inventoryUI;

	Inventory inventory;	// Our current inventory

	InventorySlot[] slots;	// List of all the slots

	void Start () {
		inventory = Inventory.instance;
		inventory.onItemChangedCallback += UpdateUI;	// Subscribe to the onItemChanged callback

		// Populate our slots array
		slots = itemsParent.GetComponentsInChildren<InventorySlot>();
	}

	public void Exit(){
		inventoryUI.SetActive(!inventoryUI.activeSelf);
	}
	void Update () {

	
		// Check to see if we should open/close the inventory
			if (Input.GetButtonDown("Inventory"))
			{
				inventoryUI.SetActive(!inventoryUI.activeSelf);
		}
	}

	// Update the inventory UI by:
	//		- Adding items
	//		- Clearing empty slots
	// This is called using a delegate on the Inventory.
	void UpdateUI ()
	{

		Debug.Log ("Update UI");


		// Loop through all the slots
		for (int i = 0; i < slots.Length; i++)
		{

			if (i < inventory.items.Count)	// If there is an item to add
			{
				Debug.Log ("x"+inventory.items[i]);
				slots[i].AddItem(inventory.items[i]);	// Add it
			} else
			{
				// Otherwise clear the slot
				slots[i].ClearSlot();
			}
		}
	}
}

