using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GameUIHandller : MonoBehaviour
{
    [SerializeField]
    private ARRaycastManager m_RaycastManager;

    public TextMeshProUGUI gameStartText;
    public TextMeshProUGUI mousePositionText;

    private void Start()
    {
        gameStartText.text = " Application Started ";
    }

    private List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();

    // Start is called before the first frame update

    private void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                gameStartText.text = "Touch Detected";

                // mousePositionText.text = Input.GetTouch(i).position.ToString();
            }

            if (Input.touchCount == 0)
                return;

            if (m_RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits))
            {
                Debug.Log(m_Hits);

                //mousePositionText.text =

                // Only returns true if there is at least one hit
            }
        }
    }
}
