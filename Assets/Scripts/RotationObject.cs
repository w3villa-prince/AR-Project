using UnityEngine;

public class RotationObject : MonoBehaviour
{
    public GameObject gameobjectUI;// Start is called before the first frame update
    public bool uiCanvasActive = false;

    public AudioSource spraks;
    public bool spraksSound = false;

    private void Start()
    {
        spraks.Stop();
        //bool objectActive = gameobjectUI.active;
    }

    public void OnClickRotationIncress()
    {
        Debug.Log(transform.rotation);
        transform.Rotate(0f, transform.rotation.y + 10f, 0f, Space.World);
    }

    public void OnClickRotationDecress()
    {
        Debug.Log(transform.rotation);
        transform.Rotate(0f, transform.rotation.y - 10f, 0f, Space.World);
    }

    public void OnClickPositionUp()
    {
        transform.Translate(0f, 0.1f, 0f);
    }

    public void OnClickPositionDown()
    {
        transform.Translate(0, -0.1f, 0f);
    }

    public void OnclickInfo()
    {
        if (!uiCanvasActive)
        {
            gameobjectUI.SetActive(true);
            uiCanvasActive = true;
        }
        else
        {
            gameobjectUI.SetActive(false);
            uiCanvasActive = false;
        }

        // gameobjectUI.SetActive(true);
    }

    public void OnClickAudioPlay()
    {
        if (!spraksSound)
        {
            spraks.Play();
            spraksSound = true;
        }
        else
        {
            spraks.Stop();
            spraksSound = false;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
