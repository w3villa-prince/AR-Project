using UnityEngine;

public class MovingSceneObject : MonoBehaviour
{
    public float MovingSpeed = 10;
    public Vector3 maxVectorPos = new Vector3(0, 0, 0);
    public Vector3 minVecyorPos = new Vector3(0, 0, 0);

    private Vector3 ObjectVector;

    // Start is called before the first frame update
    private void Start()
    {
        ObjectVector = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x <= maxVectorPos.x)
        {
            ObjectVector += new Vector3(1, 0, 0);
        }
        else
        {
            ObjectVector -= new Vector3(1, 0, 0);
        }

        transform.Translate(ObjectVector * Time.deltaTime * MovingSpeed);
    }
}
