using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoverDisplay : MonoBehaviour
{

    public GameObject textPrefab;
    private GameObject currentText;
    private Camera mainCamera;
    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject != null)
            {
                if (currentText == null)
                {
                    currentText = Instantiate(textPrefab, canvas.transform);
                }

                //TextMeshPro tmp = currentText.GetComponent<TextMeshPro>();
                TextMeshProUGUI tmp = currentText.GetComponent<TextMeshProUGUI>();
                tmp.text = hit.transform.gameObject.name;

                //currentText.transform.position = hit.transform.position + Vector3.up;

                //currentText.transform.LookAt(mainCamera.transform);
                //currentText.transform.Rotate(0, 180, 0);

                Vector3 screenPosition = mainCamera.WorldToScreenPoint(hit.transform.position + Vector3.up);

                RectTransform canvasRT = canvas.GetComponent<RectTransform>();
                float canvasWidth = canvasRT.sizeDelta.x;
                float canvasHeight = canvasRT.sizeDelta.y;

                float widthRatio = canvasWidth / Screen.width;
                float heightRatio = canvasHeight / Screen.height;

                screenPosition.x *= widthRatio;
                screenPosition.y *= heightRatio;

                screenPosition.x -= canvasWidth * 0.5f;
                screenPosition.y -= canvasHeight * 0.5f;

                currentText.GetComponent<RectTransform>().localPosition = screenPosition;
            }
        }
        else
        {
            if (currentText != null)
            {
                Destroy(currentText);
                currentText = null;
            }
        }
    }
}
