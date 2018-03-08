using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MKdemoCtrl : MonoBehaviour {

    public GameObject CrownItem;
    public GameObject ShoulderItem;
    public GameObject MKBarItem;    

    public int currentAnim = 1;
    public Text AnimDisplayed;

    public Toggle tCrown;
    public Toggle tShoulder;
    public Toggle tMKBar;

    public Animator MKanimator;
    public string[] animationList;


    // Use this for initialization
    void Start () {

     
    }
	
	// Update is called once per frame
	void Update () {
        
        ChangeShoulderItemState();
        ChangeMKBarItemState();
    }


    public void pickNextAnimation() {

        if (currentAnim <=11) {
            currentAnim++;
        }
        else
        {
            currentAnim = 0;
        }

        MKanimator.CrossFade(animationList[currentAnim], 0f);
        AnimDisplayed.text = animationList[currentAnim];
    }


    public void pickPrevAnimation()
    {

        if (currentAnim > 0)
        {
            currentAnim--;
        }
        else
        {
            currentAnim = 12;
        }

        MKanimator.CrossFade(animationList[currentAnim], 0f);
        AnimDisplayed.text = animationList[currentAnim];
    }


  
    
    
    //Change The visibility property of the Crown.
   public void CheckCrownItemState() {

        if (tCrown.isOn)
        {
            CrownItem.SetActive(true);
          
        }
        else
        {
            CrownItem.SetActive(false);
        }
    }

    //Change The visibility property of the Shoulder.
    void ChangeShoulderItemState() {


      
    }

    //Change The visibility property of the MkBar.
    void ChangeMKBarItemState()
    {


    }


}
