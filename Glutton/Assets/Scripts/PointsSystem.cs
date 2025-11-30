using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PointsSystem : MonoBehaviour
{
    [SerializeField] private GameObject plateButton;
    [SerializeField] private GameObject pointsObj;

    private Button mainButton;
    private TextMeshProUGUI pointsText;
    

    private float points = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (plateButton != null)
        {
            mainButton = plateButton.GetComponent<Button>();
            mainButton.onClick.AddListener(AddPoints);
        }
        if (pointsObj != null)
            pointsText = pointsObj.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddPoints()
    {
        points += 1;
        Debug.Log(points);

        UpdatePointsText();
    }

    private void UpdatePointsText()
    {
        pointsText.text = points.ToString();
    }
}