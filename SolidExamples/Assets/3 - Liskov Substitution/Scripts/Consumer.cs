using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Liskov
{
    public class Consumer : MonoBehaviour
    {
        private AnimalJumper _dog;
        private IAnimal _elephant;
        // Start is called before the first frame update
        void Start()
        {
            _dog = new Dog();
            PasTheHole(_dog); // Adminite a una entidad que puede comportarse como su padre. (LISKOV)
            _elephant = new Elephant();
            //PasTheHole(_elephant); no admite a una entidad que no pueda comportarse como su padre.
            
            
        }

        public void PasTheHole(AnimalJumper animal)
        {
            animal.Walk();
            animal.Jump();
            animal.Walk();
        }

    }
}
