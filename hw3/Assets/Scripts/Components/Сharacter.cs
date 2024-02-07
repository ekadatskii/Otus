using UnityEngine;

namespace Sample
{
    public sealed class Сharacter : MonoBehaviour
    {
        private void FixedUpdate()
        {
            this.UpdateLifeState();
        }

        private void UpdateLifeState()
        {
            //TODO:
            //Реализовать условие перемещения и поворота:
            //перемещаться и вращаться можно если здоровье больше нуля, иначе перемещение и вращение не происходят 
        }
    }
}