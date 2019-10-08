using System;

namespace TD05
{
    public enum Gender { NEUTRAL, MALE, FEMALE };
    /// <summary>
    /// Représente une personne
    /// </summary>
    public class Person : ICloneable, IPerson
    {
        private string lastName;
        private string firstName;
        private string phone;
        private string email;
        private string address;
        private Gender gender;

        /// <summary>
        /// Fixe ou obtient le nom de la personne
        /// </summary>
        public string LastName { get => lastName; set => lastName = value; }
        /// <summary>
        /// Fixe ou obtient le prénom de la personne
        /// </summary>
        public string FirstName { get => firstName; set => firstName = value; }
        /// <summary>
        /// Fixe ou obtient le téléphone de la personne
        /// </summary>
        public string Phone { get => phone; set => phone = value; }
        /// <summary>
        /// Fixe ou obtient le mail de la personne
        /// </summary>
        public string EMail { get => email; set => email = value; }
        /// <summary>
        /// Fixe ou obtient l'adresse de la personne
        /// </summary>
        public string Address { get => address; set => address = value; }
        /// <summary>
        /// Fixe ou obtient le genre de la personne
        /// </summary>
        public Gender Gender { get => gender; set => gender = value; }

        /// <summary>
        /// Recopie les attributs de la personne paramètre
        /// </summary>
        /// <param name="p">la personne à recopier</param>
        public void Copy(Person p)
        {
            lastName = p.lastName;
            firstName = p.firstName;
            phone = p.phone;
            email = p.email;
            address = p.address;
            gender = p.gender;
        }

        public object Clone()
        {
            Person p = new Person();
            p.Copy(this);
            return p;
        }

        
        
    }
}
