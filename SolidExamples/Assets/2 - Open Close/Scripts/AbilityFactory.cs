using System;
using System.Reflection;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OpenClose
{
    public class AbilityFactory
    {
        private Dictionary<string, Type> abilitiesByName;

        public AbilityFactory()
        {
            var abilityTypes = Assembly.GetAssembly(typeof(Ability))
                .GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

            abilitiesByName = new Dictionary<string, Type>();

            foreach(var t in abilityTypes)
            {
                var temp = Activator.CreateInstance(t) as Ability;
                abilitiesByName.Add(temp.Name, t);
            }
        }
        public Ability GetAbility(string abilityType)
        {
            if(abilitiesByName.ContainsKey(abilityType))
            {
                Type type = abilitiesByName[abilityType];
                var ability = Activator.CreateInstance(type) as Ability;
                return ability;
            }
            return null;
        }

    }
}