using UnityEngine;

public class SelctionFilter : MonoBehaviour
{
    public GameObject button1gameObject;

    public GameObject button2gameObject;
    public GameObject button3gameObject;

    public Material baseMaterial;
    public Material firstMaterial;
    public Material sceondMaterial;
    public Material thirdMaterial;

    // Start is called before the first frame update
    private void Start()
    {
        button1gameObject.GetComponentInChildren<MeshRenderer>().material = baseMaterial;

        button2gameObject.GetComponentInChildren<MeshRenderer>().material = baseMaterial;
        button3gameObject.GetComponentInChildren<MeshRenderer>().material = baseMaterial;
    }

    public void OnclickButton1()
    {
        button3gameObject.SetActive(false);
        button2gameObject.SetActive(false);
        button1gameObject.SetActive(true);
    }

    public void OnclickButton2()
    {
        button3gameObject.SetActive(false);
        button2gameObject.SetActive(true);
        button1gameObject.SetActive(false);
    }

    public void OnclickButton3()
    {
        button3gameObject.SetActive(true);
        button2gameObject.SetActive(false);
        button1gameObject.SetActive(false);
    }

    public void OnClickBaseMaterial()
    {
        button1gameObject.GetComponentInChildren<MeshRenderer>().material = baseMaterial;

        button2gameObject.GetComponentInChildren<MeshRenderer>().material = baseMaterial;
        button3gameObject.GetComponentInChildren<MeshRenderer>().material = baseMaterial;
    }

    public void OnClickFirstMaterial()
    {
        button1gameObject.GetComponentInChildren<MeshRenderer>().material = firstMaterial;

        button2gameObject.GetComponentInChildren<MeshRenderer>().material = firstMaterial;
        button3gameObject.GetComponentInChildren<MeshRenderer>().material = firstMaterial;
    }

    public void OnClickSceondMaterial()
    {
        button1gameObject.GetComponentInChildren<MeshRenderer>().material = sceondMaterial;

        button2gameObject.GetComponentInChildren<MeshRenderer>().material = sceondMaterial;

        button3gameObject.GetComponentInChildren<MeshRenderer>().material = sceondMaterial;
    }

    public void OnClickThirdMaterial()
    {
        button1gameObject.GetComponentInChildren<MeshRenderer>().material = thirdMaterial;

        button2gameObject.GetComponentInChildren<MeshRenderer>().material = thirdMaterial;

        button3gameObject.GetComponentInChildren<MeshRenderer>().material = thirdMaterial;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
