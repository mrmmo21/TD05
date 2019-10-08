using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD05
{
    /// <summary>
    /// Représente une collection de personnes
    /// </summary>
    public class Directory
    {
        private List<Person> personnes = new List<Person>();

        /// <summary>
        /// Ajoute une personne
        /// </summary>
        /// <param name="p">la personne à ajouter</param>
        public void Add(Person p)
        {
            personnes.Add(p);
        }

        /// <summary>
        /// Retire une personne
        /// </summary>
        /// <param name="p">la personne à retirer</param>
        public void Remove(Person p)
        {
            personnes.Remove(p);
        }

        /// <summary>
        /// Fournit un tableau des personnes stockées
        /// </summary>
        /// <returns></returns>
        public Person[] ListAll()
        {
            return personnes.ToArray();
        }
    }
}
