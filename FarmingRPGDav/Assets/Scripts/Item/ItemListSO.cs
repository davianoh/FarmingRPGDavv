using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "itemListSO", menuName = "Scriptable Objects/Item/Item List")]
public class ItemListSO : ScriptableObject
{
    [SerializeField] public List<ItemDetails> itemDetailsList;
}
