using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Window_Graph : MonoBehaviour
{

	[SerializeField] private Sprite circleSprite;
	private RectTransform graphContainer;

	private void Awake() {
		graphContainer = transform.Find("graphContainer").GetComponent<RectTransform>();
	
		List<int> valueList = new List<int>() {43, 23, 23, 13, 132, 121};
		ShowGraph(valueList);

	}	

	private void CreateCircle(Vector2 anchoredPosition) {
		GameObject gameObject = new GameObject("circle", typeof(Image));
		gameObject.transform.SetParent(graphContainer, false);
		gameObject.GetComponent<Image>().sprite = circleSprite;
		RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
		rectTransform.anchoredPosition = anchoredPosition;
		rectTransform.sizeDelta = new Vector2(11, 11);
		rectTransform.anchorMin = new Vector2(0, 0);
		rectTransform.anchorMax = new Vector2(0, 0);

	}

	private void ShowGraph(List<int> valueList) {
		float graphHeight = graphContainer.sizeDelta.y;
		float yMaximum = 100f;
		float xSize = 50f;
		for (int i = 0; i< valueList.Count; i++) {
			float xPosition = i * xSize;
			float yPosition = (valueList[i] / yMaximum) * graphHeight;
			CreateCircle(new Vector2(xPosition, yPosition));
		}
	}

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
