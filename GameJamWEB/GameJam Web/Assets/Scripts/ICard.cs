using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ICard
{
    void SelectCard(Transform _selectedCard);
    void DeselectCard(Transform _selectedCard);
}
