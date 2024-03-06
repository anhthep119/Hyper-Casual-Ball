using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [Header("InGame")]
    public Image levelSlider;
    public Image currentLevelImg;
    public Image nextLevelImg;

    private Material ballMat;

    private void Awake()
    {
        ballMat = FindObjectOfType<Ball>().transform.GetChild(0).GetComponent<MeshRenderer>().material;

        levelSlider.transform.parent.GetComponent<Image>().color = ballMat.color + Color.gray;
        levelSlider.color = ballMat.color;
        currentLevelImg.color = ballMat.color;
        nextLevelImg.color = ballMat.color;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSliderFill(float fillAmount)
    {
        levelSlider.fillAmount = fillAmount;
    }
}
