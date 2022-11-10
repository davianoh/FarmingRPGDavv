using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int itemCode;
    private SpriteRenderer spriteRenderer;
    public int ItemCode { get { return itemCode; } set { itemCode = value; } }

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        if(itemCode != 0)
        {
            Init(itemCode);
        }
    }

    private void Init(int itemCode)
    {

    }
}
